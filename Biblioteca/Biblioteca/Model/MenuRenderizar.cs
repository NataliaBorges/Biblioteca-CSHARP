using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Biblioteca.Model {
    public class MenuRenderizar: ToolStripProfessionalRenderer {
        private Color primaryColor;
        private Color TextColor;
        private int seta;

        public MenuRenderizar (bool isMainMenu, Color primaryColor, Color text):base(new CorMenu(isMainMenu, primaryColor)) {
            this.primaryColor = primaryColor;
            this.TextColor = TextColor;
            if (isMainMenu) seta = 3;
            else seta = 2;
        }
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e) {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? Color.White : TextColor;
        }
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e) {
            var graph = e.Graphics;
            var arrowSize = new Size(5, 12);
            var arrowColor = e.Item.Selected ? Color.White : primaryColor;
            var rect = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height - arrowSize.Height) / 2, arrowSize.Width, arrowSize.Height);
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(arrowColor, seta)) {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2);
                path.AddLine(rect.Right, rect.Top + rect.Height / 2, rect.Left, rect.Top + rect.Height);
                graph.DrawPath(pen, path);

            }
        }
    }
}
