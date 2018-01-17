namespace IAGrim.Theme
{
    class ComboBoxItem {
        public string[] Filter {
            get;
            set;
        }
        public string Text {
            get;
            set;
        }

        public override string ToString() {
            return Text;
        }
    }
}
