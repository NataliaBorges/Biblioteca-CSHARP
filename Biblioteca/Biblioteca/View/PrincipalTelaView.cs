using Biblioteca.Util;
using Biblioteca.View;
using Biblioteca.View.Emprestimo;
using Biblioteca.View.Fornecedor;
using Biblioteca.View.Funcionario;
using Biblioteca.View.Leitor;
using Biblioteca.View.Livros;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View {
    public partial class PrincipalTelaView : Form {

        Singleton singleton = Singleton.GetInstancia();
        private int borderSize = 2;

        public PrincipalTelaView() {
            InitializeComponent();

            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(0, 0, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panelTituloBar_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelTituloBar_Resize(object sender, EventArgs e) {
            AdjustForm();
        }
        private void AdjustForm() {
            switch (this.WindowState) {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if(this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
            
        }

        private void iconButtonMinimizar_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton_Click(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Normal) 
                this.WindowState = FormWindowState.Maximized;
            else {
                this.WindowState = FormWindowState.Normal;
            }

        }
        private void PrincipalTelaView_Load(object sender, EventArgs e) {
            this.menuControl1.setPanel(pnltotal);
        }
    }
}
