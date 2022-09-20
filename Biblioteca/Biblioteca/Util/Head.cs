using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace Biblioteca.Util
{
    public partial class Head : UserControl
    {
        Singleton singleton = Singleton.GetInstancia();
        private int borderSize = 2;
        public Head()
        {
            InitializeComponent(); 
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void panelTituloBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelTituloBar_Resize(object sender, EventArgs e)
        {
            //AdjustForm();
        }
        private void AdjustForm()
        {
            //switch (WindowState)
            //{
            //    case (windowstate)formwindowstate.maximized:
            //        this.padding = new padding(8, 8, 8, 0);
            //        break;
            //    case (windowstate)formwindowstate.normal:
            //        if (this.padding.top != bordersize)
            //            this.padding = new padding(bordersize);
            //        break;
            //}

        }

        private void icButtonMin_Click(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Minimized;
        }

        private void icButtonMax_Click(object sender, EventArgs e)
        {
            //if (WindowState == FormWindowState.Normal)
            //    WindowState = FormWindowState.Maximized;
            //else
            //{
            //    WindowState = FormWindowState.Normal;
            //}
        }

        private void icButtonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
