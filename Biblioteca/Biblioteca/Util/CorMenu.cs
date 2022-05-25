using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing; 

namespace Biblioteca.Model {
    public class CorMenu: ProfessionalColorTable {
        private Color backColor;
        private Color leftColumnColor;
        private Color borderColor;
        private Color menuItemBorderColor;
        private Color menuItemSelectedColor;

        public CorMenu (bool isMainMenu, Color primaryColor) {
            if (isMainMenu) {
                backColor = Color.FromArgb(37, 39, 60);
                leftColumnColor = Color.FromArgb(32, 33, 51);
                borderColor = Color.FromArgb(32, 33, 51);
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = primaryColor;
            }
            else {
                backColor = Color.White;
                leftColumnColor = Color.LightGray;
                borderColor = Color.LightGray;
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = primaryColor; 
            }
        }
        public override Color ToolStripDropDownBackground => backColor;
        public override Color MenuBorder => borderColor;
        public override Color MenuItemBorder => menuItemBorderColor;
        public override Color MenuItemSelected => menuItemSelectedColor;
        public override Color ImageMarginGradientBegin => leftColumnColor;
        public override Color ImageMarginGradientMiddle => leftColumnColor;
        public override Color ImageMarginRevealedGradientEnd => leftColumnColor;
    }
}
