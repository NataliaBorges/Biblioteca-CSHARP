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
        private int borderSize = 2;
        public PrincipalTelaView() {
            InitializeComponent();
            FecharMenu();
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

        private void iconButtonFechar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e) {
            FecharMenu();
        }

        private void FecharMenu() {
            if (this.panelMenu.Width > 200) {
                panelMenu.Width = 80;
                pictureBox1.Visible = false;
                lbNome.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>()) {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else {
                panelMenu.Width = 230;
                pictureBox1.Visible = true;
                lbNome.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>()) {
                    menuButton.Text = "  "+ menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }

            }
        }
        private void PrincipalTelaView_Load(object sender, EventArgs e) {
            ddmCadastro.IsMainMenu = true;
            ddmCadastro.PrimaryColor = Color.Chocolate;
            ddmCadastro.MenuItemTextColor = Color.Chocolate;
            ddmBuscar.IsMainMenu = true;
            ddmBuscar.PrimaryColor = Color.Chocolate;
            ddmBuscar.MenuItemTextColor = Color.Chocolate;
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            ddmCadastro.Show(btnCadastrar, btnCadastrar.Width, 0);
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            ddmBuscar.Show(btnBuscar, btnBuscar.Width, 0);
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e) {
            LivrosCadastrarView livrosCadastrarlView = new LivrosCadastrarView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirPanel(livrosCadastrarlView);

        }

        private void leitorToolStripMenuItem_Click(object sender, EventArgs e) {
            LeitorCadastrarView leitorCadastrarView = new LeitorCadastrarView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirPanel(leitorCadastrarView);
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e) {
            FuncionarioCadastrarView funcionarioCadastrarView = new FuncionarioCadastrarView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirPanel(funcionarioCadastrarView);
        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e) {
            EditoraCadastrarView editoraCadastrarView = new EditoraCadastrarView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirPanel(editoraCadastrarView);
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void gêneroToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void livroToolStripMenuItem1_Click(object sender, EventArgs e) {
            LivrosBuscarView livrosBuscarView = new LivrosBuscarView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirPanel(livrosBuscarView);
        }
        private void abrirPanel(Form form) {
            panelDesktop.Controls.Clear();
            form.FormBorderStyle = FormBorderStyle.None;
            panelDesktop.Controls.Add(form);
            form.Show();
        }

        private void leitorToolStripMenuItem1_Click(object sender, EventArgs e) {
            LeitorBuscarView leitorBuscarView = new LeitorBuscarView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirPanel(leitorBuscarView);
        }

        private void funcionárioToolStripMenuItem1_Click(object sender, EventArgs e) {
            FuncionarioBuscarView funcionarioBuscarView = new FuncionarioBuscarView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirPanel(funcionarioBuscarView);
        }

        private void editoraToolStripMenuItem1_Click(object sender, EventArgs e) {
            EditoraBuscarView editoraBuscarView = new EditoraBuscarView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirPanel(editoraBuscarView);
        }

        private void autorToolStripMenuItem1_Click(object sender, EventArgs e) {
        }

        private void gêneroToolStripMenuItem1_Click(object sender, EventArgs e) {

        }

        private void empréstimoToolStripMenuItem_Click(object sender, EventArgs e) {
            EmprestimoBuscarView emprestimoBuscarView = new EmprestimoBuscarView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirPanel(emprestimoBuscarView);
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void btnSair_Click(object sender, EventArgs e) {
            TelaLoginView telaLoginView = new TelaLoginView();

            this.Close();
            Rectangle bounds = this.Bounds;
            telaLoginView.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
            telaLoginView.StartPosition = FormStartPosition.CenterScreen;
            telaLoginView.ShowDialog();
        }
    }
}
