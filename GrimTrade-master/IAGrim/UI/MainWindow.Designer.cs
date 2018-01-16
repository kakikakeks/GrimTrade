namespace IAGrim.UI {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageItems = new System.Windows.Forms.TabPage();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.buttonDevTools = new System.Windows.Forms.Button();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.tabPageMods = new System.Windows.Forms.TabPage();
            this.modsPanel = new System.Windows.Forms.Panel();
            this.tabPageBackups = new System.Windows.Forms.TabPage();
            this.backupPanel = new System.Windows.Forms.Panel();
            this.tabPageBuddy = new System.Windows.Forms.TabPage();
            this.buddyPanel = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelLogging = new System.Windows.Forms.Panel();
            this.tabPageHelp = new System.Windows.Forms.TabPage();
            this.panelHelp = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabTrade = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelTrade = new System.Windows.Forms.TableLayoutPanel();
            this.textbox_sent_message = new System.Windows.Forms.TextBox();
            this.button_trade_sent = new System.Windows.Forms.Button();
            this.button_trade_accept = new System.Windows.Forms.Button();
            this.button_trade_edit = new System.Windows.Forms.Button();
            this.textbox_received_message = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageItems.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabPageMods.SuspendLayout();
            this.tabPageBackups.SuspendLayout();
            this.tabPageBuddy.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageHelp.SuspendLayout();
            this.trayContextMenuStrip.SuspendLayout();
            this.TabTrade.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 590);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1376, 22);
            this.statusStrip.TabIndex = 25;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(1361, 17);
            this.statusLabel.Spring = true;
            this.statusLabel.Text = "GrimTrade";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageItems);
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Controls.Add(this.tabPageMods);
            this.tabControl1.Controls.Add(this.tabPageBackups);
            this.tabControl1.Controls.Add(this.tabPageBuddy);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageHelp);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 587);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPageItems
            // 
            this.tabPageItems.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageItems.Controls.Add(this.searchPanel);
            this.tabPageItems.Location = new System.Drawing.Point(4, 22);
            this.tabPageItems.Name = "tabPageItems";
            this.tabPageItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItems.Size = new System.Drawing.Size(699, 561);
            this.tabPageItems.TabIndex = 0;
            this.tabPageItems.Tag = "iatag_ui_tab_items";
            this.tabPageItems.Text = "Trade";
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel.Controls.Add(this.buttonDevTools);
            this.searchPanel.Location = new System.Drawing.Point(-4, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(707, 561);
            this.searchPanel.TabIndex = 1;
            // 
            // buttonDevTools
            // 
            this.buttonDevTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDevTools.Location = new System.Drawing.Point(632, 0);
            this.buttonDevTools.Name = "buttonDevTools";
            this.buttonDevTools.Size = new System.Drawing.Size(75, 23);
            this.buttonDevTools.TabIndex = 0;
            this.buttonDevTools.Text = "DevTools";
            this.buttonDevTools.UseVisualStyleBackColor = true;
            this.buttonDevTools.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSettings.Controls.Add(this.settingsPanel);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(929, 560);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Tag = "iatag_ui_tab_settings";
            this.tabPageSettings.Text = "Settings";
            // 
            // settingsPanel
            // 
            this.settingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.settingsPanel.Location = new System.Drawing.Point(-4, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(937, 560);
            this.settingsPanel.TabIndex = 0;
            // 
            // tabPageMods
            // 
            this.tabPageMods.Controls.Add(this.modsPanel);
            this.tabPageMods.Location = new System.Drawing.Point(4, 22);
            this.tabPageMods.Name = "tabPageMods";
            this.tabPageMods.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMods.Size = new System.Drawing.Size(929, 560);
            this.tabPageMods.TabIndex = 4;
            this.tabPageMods.Tag = "iatag_ui_tab_mods";
            this.tabPageMods.Text = "Database/Mods";
            this.tabPageMods.UseVisualStyleBackColor = true;
            // 
            // modsPanel
            // 
            this.modsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modsPanel.Location = new System.Drawing.Point(-4, 0);
            this.modsPanel.Name = "modsPanel";
            this.modsPanel.Size = new System.Drawing.Size(937, 557);
            this.modsPanel.TabIndex = 1;
            // 
            // tabPageBackups
            // 
            this.tabPageBackups.Controls.Add(this.backupPanel);
            this.tabPageBackups.Location = new System.Drawing.Point(4, 22);
            this.tabPageBackups.Name = "tabPageBackups";
            this.tabPageBackups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBackups.Size = new System.Drawing.Size(699, 561);
            this.tabPageBackups.TabIndex = 3;
            this.tabPageBackups.Tag = "iatag_ui_tab_backups";
            this.tabPageBackups.Text = "Backups";
            this.tabPageBackups.UseVisualStyleBackColor = true;
            // 
            // backupPanel
            // 
            this.backupPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backupPanel.Location = new System.Drawing.Point(-4, 0);
            this.backupPanel.Name = "backupPanel";
            this.backupPanel.Size = new System.Drawing.Size(703, 561);
            this.backupPanel.TabIndex = 0;
            // 
            // tabPageBuddy
            // 
            this.tabPageBuddy.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageBuddy.Controls.Add(this.buddyPanel);
            this.tabPageBuddy.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuddy.Name = "tabPageBuddy";
            this.tabPageBuddy.Size = new System.Drawing.Size(929, 560);
            this.tabPageBuddy.TabIndex = 2;
            this.tabPageBuddy.Tag = "iatag_ui_tab_buddy";
            this.tabPageBuddy.Text = "Buddy";
            // 
            // buddyPanel
            // 
            this.buddyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buddyPanel.Location = new System.Drawing.Point(-4, 0);
            this.buddyPanel.Name = "buddyPanel";
            this.buddyPanel.Size = new System.Drawing.Size(933, 564);
            this.buddyPanel.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelLogging);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(929, 560);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Tag = "iatag_ui_tab_log";
            this.tabPage1.Text = "Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelLogging
            // 
            this.panelLogging.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogging.ForeColor = System.Drawing.SystemColors.Control;
            this.panelLogging.Location = new System.Drawing.Point(-4, 0);
            this.panelLogging.Name = "panelLogging";
            this.panelLogging.Size = new System.Drawing.Size(933, 564);
            this.panelLogging.TabIndex = 1;
            // 
            // tabPageHelp
            // 
            this.tabPageHelp.Controls.Add(this.panelHelp);
            this.tabPageHelp.Location = new System.Drawing.Point(4, 22);
            this.tabPageHelp.Name = "tabPageHelp";
            this.tabPageHelp.Size = new System.Drawing.Size(699, 561);
            this.tabPageHelp.TabIndex = 5;
            this.tabPageHelp.Tag = "iatag_ui_tab_help";
            this.tabPageHelp.Text = "Help";
            this.tabPageHelp.UseVisualStyleBackColor = true;
            // 
            // panelHelp
            // 
            this.panelHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHelp.Location = new System.Drawing.Point(-2, 0);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(0, 561);
            this.panelHelp.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipTitle = "Item Assistant";
            this.notifyIcon1.ContextMenuStrip = this.trayContextMenuStrip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "GD Item Assistant";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // trayContextMenuStrip
            // 
            this.trayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.trayContextMenuStrip.Name = "trayContextMenuStrip";
            this.trayContextMenuStrip.Size = new System.Drawing.Size(93, 26);
            this.trayContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.trayContextMenuStrip_Opening);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // TabTrade
            // 
            this.TabTrade.AccessibleDescription = "";
            this.TabTrade.AccessibleName = "";
            this.TabTrade.Controls.Add(this.tabPage2);
            this.TabTrade.Controls.Add(this.tabPage3);
            this.TabTrade.Controls.Add(this.tabPage4);
            this.TabTrade.Location = new System.Drawing.Point(709, 0);
            this.TabTrade.Name = "TabTrade";
            this.TabTrade.SelectedIndex = 0;
            this.TabTrade.Size = new System.Drawing.Size(667, 587);
            this.TabTrade.TabIndex = 35;
            this.TabTrade.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.textbox_received_message);
            this.tabPage2.Controls.Add(this.button_trade_edit);
            this.tabPage2.Controls.Add(this.button_trade_accept);
            this.tabPage2.Controls.Add(this.button_trade_sent);
            this.tabPage2.Controls.Add(this.textbox_sent_message);
            this.tabPage2.Controls.Add(this.tableLayoutPanelTrade);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(659, 561);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Trade User 1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(659, 561);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Trade User 2";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(659, 561);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Trade User3";
            // 
            // tableLayoutPanelTrade
            // 
            this.tableLayoutPanelTrade.ColumnCount = 2;
            this.tableLayoutPanelTrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTrade.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanelTrade.Name = "tableLayoutPanelTrade";
            this.tableLayoutPanelTrade.RowCount = 1;
            this.tableLayoutPanelTrade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTrade.Size = new System.Drawing.Size(659, 486);
            this.tableLayoutPanelTrade.TabIndex = 0;
            // 
            // textbox_sent_message
            // 
            this.textbox_sent_message.BackColor = System.Drawing.Color.Moccasin;
            this.textbox_sent_message.Location = new System.Drawing.Point(0, 522);
            this.textbox_sent_message.MaxLength = 100;
            this.textbox_sent_message.Multiline = true;
            this.textbox_sent_message.Name = "textbox_sent_message";
            this.textbox_sent_message.Size = new System.Drawing.Size(328, 33);
            this.textbox_sent_message.TabIndex = 1;
            this.textbox_sent_message.Text = "Sent Message";
            // 
            // button_trade_sent
            // 
            this.button_trade_sent.Location = new System.Drawing.Point(335, 522);
            this.button_trade_sent.Name = "button_trade_sent";
            this.button_trade_sent.Size = new System.Drawing.Size(92, 33);
            this.button_trade_sent.TabIndex = 2;
            this.button_trade_sent.Text = "Send";
            this.button_trade_sent.UseVisualStyleBackColor = true;
            // 
            // button_trade_accept
            // 
            this.button_trade_accept.Location = new System.Drawing.Point(559, 524);
            this.button_trade_accept.Name = "button_trade_accept";
            this.button_trade_accept.Size = new System.Drawing.Size(92, 33);
            this.button_trade_accept.TabIndex = 3;
            this.button_trade_accept.Text = "Accept";
            this.button_trade_accept.UseVisualStyleBackColor = true;
            // 
            // button_trade_edit
            // 
            this.button_trade_edit.Location = new System.Drawing.Point(433, 522);
            this.button_trade_edit.Name = "button_trade_edit";
            this.button_trade_edit.Size = new System.Drawing.Size(92, 33);
            this.button_trade_edit.TabIndex = 4;
            this.button_trade_edit.Text = "Edit";
            this.button_trade_edit.UseVisualStyleBackColor = true;
            // 
            // textbox_received_message
            // 
            this.textbox_received_message.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textbox_received_message.Location = new System.Drawing.Point(2, 2);
            this.textbox_received_message.MaxLength = 100;
            this.textbox_received_message.Multiline = true;
            this.textbox_received_message.Name = "textbox_received_message";
            this.textbox_received_message.Size = new System.Drawing.Size(653, 25);
            this.textbox_received_message.TabIndex = 5;
            this.textbox_received_message.Text = "Received Message";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 612);
            this.Controls.Add(this.TabTrade);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Tag = "iatag_ui_itemassistant";
            this.Text = "GrimTrade";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageItems.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageMods.ResumeLayout(false);
            this.tabPageBackups.ResumeLayout(false);
            this.tabPageBuddy.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPageHelp.ResumeLayout(false);
            this.trayContextMenuStrip.ResumeLayout(false);
            this.TabTrade.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageItems;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.TabPage tabPageBuddy;
        private System.Windows.Forms.Panel buddyPanel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip trayContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageBackups;
        private System.Windows.Forms.Panel backupPanel;
        private System.Windows.Forms.TabPage tabPageMods;
        private System.Windows.Forms.Panel modsPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button buttonDevTools;
        private System.Windows.Forms.TabPage tabPageHelp;
        private System.Windows.Forms.Panel panelHelp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelLogging;
        private System.Windows.Forms.TabControl TabTrade;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_trade_edit;
        private System.Windows.Forms.Button button_trade_accept;
        private System.Windows.Forms.Button button_trade_sent;
        private System.Windows.Forms.TextBox textbox_sent_message;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTrade;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textbox_received_message;
    }
}