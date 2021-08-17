using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    public class ComboBoxItem {
        public string Text { get; set; }
        public string Value { get; set; }

        public ComboBoxItem(string Text, string Value) {
            this.Text = Text;
            this.Value = Value;
        }

        public override string ToString() {
            return Text;
        }
    }
}
