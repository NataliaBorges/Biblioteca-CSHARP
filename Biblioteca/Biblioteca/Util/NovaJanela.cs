using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.Util {
    class NovaJanela {
        private NovaJanela() { }
        public static void novaJanela(Form form, Rectangle boundsForm) {
            Rectangle bounds = boundsForm;
            form.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(88, 35);
            form.ShowDialog();
        }
    }
}
