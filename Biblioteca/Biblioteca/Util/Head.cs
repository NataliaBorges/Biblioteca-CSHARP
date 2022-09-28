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

        Form form;
        Padding  padding;

        public void setForm(Form form)
        {
            this.form = form;
        }
        public void setPaddind(Padding padding)
        {
            this.padding = padding;
        }
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

        private void panelTituloBar_Resize_1(object sender, EventArgs e)
        {
            if(form != null)
            {
                AdjustForm();
            }
        }
        private void AdjustForm()
        {
            switch (form.WindowState)
            {
                case (FormWindowState)FormWindowState.Maximized:
                    this.padding = new Padding(8, 8, 8, 0);
                    break;
                case (FormWindowState)FormWindowState.Normal:
                    if (this.padding.Top != borderSize)
                        this.padding = new Padding(borderSize);
                    break;
            }

        }

        private void icButtonMin_Click(object sender, EventArgs e)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        private void icButtonMax_Click(object sender, EventArgs e)
        {
            if (form.WindowState == FormWindowState.Normal)
                form.WindowState = FormWindowState.Maximized;
            else
            {
                form.WindowState = FormWindowState.Normal;
            }
        }

        private void icButtonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
