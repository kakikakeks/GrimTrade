﻿using IAGrim.Database.Dto;
using IAGrim.Database.Interfaces;
using IAGrim.Theme;
using IAGrim.UI.Controller;
using IAGrim.Utilities.HelperClasses;
using log4net;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IAGrim.UI.Tabs.Util;

namespace IAGrim.UI
{

    partial class SearchWindow : Form {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SearchWindow));
        private readonly Action<string> _setStatus;
        private ScrollPanelMessageFilter _scrollableFilterView;
        private System.Windows.Forms.Timer _delayedTextChangedTimer;
        private readonly SearchController _searchController;
        private readonly IDatabaseItemDao _databaseItemDao;
        private readonly List<TextboxHoverFocusHighlight> _highlights = new List<TextboxHoverFocusHighlight>();
        public readonly ModSelectionHandler ModSelectionHandler;

        public SearchWindow(Control browser, Action<string> setStatus, IPlayerItemDao playerItemDao, SearchController searchController, IDatabaseItemDao databaseItemDao) {
            InitializeComponent();
            toolStripContainer.ContentPanel.Controls.Add(browser);
            this._setStatus = setStatus;
            this._searchController = searchController;
            this._databaseItemDao = databaseItemDao;

            this.Activated += SearchWindow_Activated;
            this.Deactivate += SearchWindow_Deactivate;

            minLevel.KeyPress += MinLevel_KeyPress;
            minLevel.MouseWheel += MinLevel_MouseWheel;
            _highlights.Add(new TextboxHoverFocusHighlight(minLevel));
            maxLevel.KeyPress += MinLevel_KeyPress;
            maxLevel.MouseWheel += MaxLevel_MouseWheel;
            _highlights.Add(new TextboxHoverFocusHighlight(maxLevel));

            ModSelectionHandler = new ModSelectionHandler(cbModFilter, playerItemDao, UpdateListviewDelayed, setStatus);
        }

        public void UpdateInterface() {
            _filterWindow.OnChanged -= filterWindow_OnChanged;
            _filterWindow.Close();
            panelFilter.Controls.Remove(_filterWindow);

            ConfigureAndCreateFilterWindow();
        }

        private void SearchWindow_Deactivate(object sender, EventArgs e) {
            Application.RemoveMessageFilter(_scrollableFilterView);
        }

        private void HandleDelayedTextChangedTimerTick(object sender, EventArgs e) {
            if (_delayedTextChangedTimer != null) {
                _delayedTextChangedTimer.Stop();
                _delayedTextChangedTimer = null;
            }

            if (InvokeRequired) {
                Invoke((MethodInvoker)delegate {
                    UpdateListview(_filterWindow.Filters);
                });
            }
            else {
                UpdateListview(_filterWindow.Filters);
            }
        }

        private void SearchWindow_Activated(object sender, EventArgs e) {
            _scrollableFilterView = new ScrollPanelMessageFilter(_filterWindow);
            Application.AddMessageFilter(_scrollableFilterView);
        }
        
        public void UpdateListview() {
            UpdateListview(_filterWindow.Filters);
        }

        private void UpdateListview(FilterEventArgs filters) {
            GDTransferFile mf = ModSelectionHandler.SelectedMod;
            if (mf == null)
                return;

            ComboBoxItemQuality rarity = comboBoxItemQuality.SelectedItem as ComboBoxItemQuality;
            var slot = slotFilter.SelectedItem as ComboBoxItem;
            var query = new Search {
                Wildcard = searchField.Text,
                filters = filters.Filters,
                MinimumLevel = ParseNumeric(minLevel),
                MaximumLevel = ParseNumeric(maxLevel),
                Rarity = rarity?.Rarity,
                Slot = slot?.Filter,
                PetBonuses = filters.PetBonuses,
                IsRetaliation = filters.IsRetaliation,
                Mod = mf.Mod,
                IsHardcore = mf.IsHardcore,
                Classes = filters.DesiredClass,
                SocketedOnly = filters.SocketedOnly,
            };

            bool includeBuddyItems = (bool)Properties.Settings.Default.BuddySyncEnabled;
            var message = _searchController.Search(query, filters.DuplicatesOnly, includeBuddyItems, checkBoxOrderByLevel.Checked);

            Logger.Info("Updating UI..");
            _setStatus(message);
            Logger.Info("Done");
        }

        private void MaxLevel_MouseWheel(object sender, MouseEventArgs e) {
            Control c = sender as Control;
            if (c != null) {
                if (e.Delta > 0) {
                    c.Text = Math.Min(ParseNumeric(c) + 1, 110).ToString();
                }
                else if (e.Delta < 0) {
                    
                    var newValue = Math.Min(Math.Max(0, ParseNumeric(c) - 1), 110);
                    if (ParseNumeric(minLevel) > newValue) {
                        minLevel.Text = newValue.ToString();
                    }
                    c.Text = Math.Min(Math.Max(0, ParseNumeric(c) - 1), 110).ToString();
                }
            }

            UpdateListviewDelayed(1200);
        }

        private void MinLevel_MouseWheel(object sender, MouseEventArgs e) {
            Control c = sender as Control;
            if (c != null) {
                if (e.Delta > 0) {
                    var newValue = Math.Min(ParseNumeric(c) + 1, 110);
                    if (ParseNumeric(maxLevel) < newValue) {
                        maxLevel.Text = newValue.ToString();
                    }
                    c.Text = newValue.ToString();
                }
                else if (e.Delta < 0) {
                    c.Text = Math.Min(Math.Max(0, ParseNumeric(c) - 1), 110).ToString();
                }
            }

            UpdateListviewDelayed(1200);
        }

        private void MinLevel_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsDigit(e.KeyChar) || ParseNumeric(minLevel) > 105 || e.KeyChar == '\b');
            UpdateListviewDelayed(1200);
        }

        private int ParseNumeric(Control tb) {
            int val;
            if (int.TryParse(tb.Text, out val))
                return val;
            else
                return 0;
        }


        private void ConfigureAndCreateFilterWindow() {
            _filterWindow.TopLevel = false;
            _filterWindow.OnChanged += filterWindow_OnChanged;
            panelFilter.Controls.Add(_filterWindow);
            _filterWindow.Show();
        }

        private void SearchWindow_Load(object sender, EventArgs e) {
            this.Dock = DockStyle.Fill;
            ConfigureAndCreateFilterWindow();
            ModSelectionHandler.ConfigureModFilter();

            // Fill quality drop down
            comboBoxItemQuality.Items.AddRange(UIHelper.QualityFilter);
            comboBoxItemQuality.SelectedIndex = 0;

            // Fill the slot dropdown
            slotFilter.Items.AddRange(UIHelper.SlotFilter);
            slotFilter.SelectedIndex = 0;

            this.FormClosing += SearchWindow_FormClosing;
            searchField.KeyDown += SearchField_KeyDown;
        }

        private void SearchField_KeyDown(object sender, KeyEventArgs e) {
            if (!Properties.Settings.Default.AutoSearch) {
                if (e.KeyCode == Keys.Enter) {
                    UpdateListview();
                    e.Handled = true;
                }
            }
        }

        private void SearchWindow_FormClosing(object sender, FormClosingEventArgs e) {
  
            this.Activated -= SearchWindow_Activated;
            this.Deactivate -= SearchWindow_Deactivate;

            toolStripContainer.ContentPanel.Controls.Clear();
        }

        public void ClearFilters() {
            searchField.Text = string.Empty;
            comboBoxItemQuality.SelectedIndex = 0;
            slotFilter.SelectedIndex = 0;
            minLevel.Text = "0";
            maxLevel.Text = "110";

            UpdateListviewDelayed();
        }



        public void UpdateListviewDelayed() {
            UpdateListviewDelayed(200);
        }

        private void UpdateListviewDelayed(int delay) {
            if (_delayedTextChangedTimer != null) {
                _delayedTextChangedTimer.Stop();
            }

            _delayedTextChangedTimer = new System.Windows.Forms.Timer();
            _delayedTextChangedTimer.Tick += new EventHandler(HandleDelayedTextChangedTimerTick);
            _delayedTextChangedTimer.Interval = delay;
            _delayedTextChangedTimer.Start();
        }


        #region Click Listeners

        private void SearchField_TextChanged(object sender, EventArgs e) {
            if (Properties.Settings.Default.AutoSearch) {
                //if (searchField.Text.Length >= 1 || searchField.Text.Length == 0)
                UpdateListviewDelayed(600);
            }
        }

        private void ComboBoxItemQuality_SelectedIndexChanged(object sender, EventArgs e) {
            if (Properties.Settings.Default.AutoSearch)
                UpdateListviewDelayed();
        }

        private void SlotFilter_SelectedIndexChanged(object sender, EventArgs e) {
            if (Properties.Settings.Default.AutoSearch)
                UpdateListviewDelayed();
        }


        /// <summary>
        /// Callback for change in filters (dmg type, resist, etc)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterWindow_OnChanged(object sender, FilterEventArgs args) {
            if (Properties.Settings.Default.AutoSearch)
                UpdateListviewDelayed();
        }
        
        #endregion Click Listeners

        private void CheckBoxOrderByLevel_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListviewDelayed();
        }
    }
}