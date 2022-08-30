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

namespace Biblioteca.Util
{
    public partial class MenuControl : UserControl
    {
        private object lblNome;
        TableLayoutPanel panel;
        Form form;

        public void setForm(Form form)
        {
            this.form = form;
        }
        public void setPanel(TableLayoutPanel panel)
        {
            this.panel = panel;
        }

        public MenuControl()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(0, 0, 0);
        }
        private void MenuControl_Load(object sender, EventArgs e){
                    ddmCadastro.IsMainMenu = true;
                    ddmCadastro.PrimaryColor = Color.Chocolate;
                    ddmCadastro.MenuItemTextColor = Color.Chocolate;

                    ddmBuscar.IsMainMenu = true;
                    ddmBuscar.PrimaryColor = Color.Chocolate;
                    ddmBuscar.MenuItemTextColor = Color.Chocolate;

                    ddmEmprestimo.IsMainMenu = true;
                    ddmEmprestimo.PrimaryColor = Color.Chocolate;
                    ddmEmprestimo.MenuItemTextColor = Color.Chocolate;

                    ddmReserva.IsMainMenu = true;
                    ddmReserva.PrimaryColor = Color.Chocolate;
                    ddmReserva.MenuItemTextColor = Color.Chocolate;

        }
        private void FecharMenu()
        {
            if (this.Width > 100)
            {
                if (this.panel != null)
                {
                    this.panel.ColumnStyles.Clear();
                    this.panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
                    this.panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95F));
                }
                this.Width = (int)100F;
                lbNome.Visible = false;
                icnButtonBar.Dock = DockStyle.Fill;
                foreach (Button menuButton in this.Menu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { 
                this.panel.ColumnStyles.Clear();
                this.panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
                this.panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
                this.Width = (int)200F;
                lbNome.Visible = true;
                icnButtonBar.Dock = DockStyle.None;
                foreach (Button menuButton in this.Menu.Controls.OfType<Button>())
                {
                    menuButton.Text = "  " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }

            }
        }
            private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ddmCadastro.Show(btnHome, btnHome.Width, 0);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ddmBuscar.Show(btnBuscar, btnBuscar.Width, 0);
        }

        private void btnEmrestimo_Click(object sender, EventArgs e)
        {
            ddmEmprestimo.Show(btnEmprestimo, btnEmprestimo.Width, 0);
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            ddmReserva.Show(btnReserva, btnReserva.Width, 0);
        }

        private void icnButtonBar_Click(object sender, EventArgs e)
        {
            FecharMenu();
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LivrosCadastrarView livrosCadastrarView = new LivrosCadastrarView();
            NovaJanela.novaJanela(livrosCadastrarView, Bounds);
        }

        private void livroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //if(form as LivrosBuscarView)
            //{
            //    form.Close();
            //    LivrosBuscarView livroBuscarView = new LivrosBuscarView();
            //    NovaJanela.novaJanela(livroBuscarView, Bounds);
            //}
            
        }
    }
}
