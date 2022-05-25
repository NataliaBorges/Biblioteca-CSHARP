﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Biblioteca.Model {
    public class DropDownMenu: ContextMenuStrip {
        private bool isMainMenu;
        private int menuItemHeight = 25;
        private Color menuItemTextColor = Color.DimGray;
        private Color primaryColor = Color.MediumSlateBlue;

        private Bitmap menuItemHeaderSize;
        public DropDownMenu(IContainer container): base(container) {

        }
        [Browsable(false)]
        public bool IsMainMenu { get => isMainMenu; set => isMainMenu = value; }

        [Browsable(false)]
        public int MenuItemHeight { get => menuItemHeight; set => menuItemHeight = value; }

        [Browsable(false)]
        public Color MenuItemTextColor { get => menuItemTextColor; set => menuItemTextColor = value; }

        [Browsable(false)]
        public Color PrimaryColor { get => primaryColor; set => primaryColor = value; }

        private void LoadMenuItemAppearance() {
            if (isMainMenu) {
                menuItemHeaderSize = new Bitmap(25, 45);
                menuItemTextColor = Color.Gainsboro;
            }
            else {
                menuItemHeaderSize = new Bitmap(15, MenuItemHeight);
            }
            foreach(ToolStripMenuItem menuItemL1 in this.Items) {
                menuItemL1.ForeColor = menuItemTextColor;
                menuItemL1.ImageScaling = ToolStripItemImageScaling.None;
                if (menuItemL1.Image == null) menuItemL1.Image = menuItemHeaderSize;

                foreach (ToolStripMenuItem menuItemL2 in menuItemL1.DropDownItems) {
                    menuItemL2.ForeColor = menuItemTextColor;
                    menuItemL2.ImageScaling = ToolStripItemImageScaling.None;
                    if (menuItemL2.Image == null) menuItemL2.Image = menuItemHeaderSize;

                    foreach (ToolStripMenuItem menuItemL3 in menuItemL2.DropDownItems) {
                        menuItemL3.ForeColor = menuItemTextColor;
                        menuItemL3.ImageScaling = ToolStripItemImageScaling.None;
                        if (menuItemL3.Image == null) menuItemL3.Image = menuItemHeaderSize;

                        foreach (ToolStripMenuItem menuItemL4 in menuItemL3.DropDownItems) {
                            menuItemL4.ForeColor = menuItemTextColor;
                            menuItemL4.ImageScaling = ToolStripItemImageScaling.None;
                            if (menuItemL4.Image == null) menuItemL4.Image = menuItemHeaderSize;
                        }
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            if (this.DesignMode == false) {
                LoadMenuItemAppearance();
                this.Renderer = new MenuRenderizar(IsMainMenu, primaryColor, menuItemTextColor);
            }
        }
    }
}
