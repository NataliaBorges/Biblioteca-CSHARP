﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.Util {
    class NovaJanela {
        private NovaJanela() { }
        public static void novaJanela(Form form, Rectangle boundsForm) {
            Rectangle bounds = boundsForm;
            form.SetBounds(bounds.X, bounds.Y, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height-48);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}
