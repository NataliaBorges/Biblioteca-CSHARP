using Biblioteca.Util;
using Biblioteca.View;
using Biblioteca.View.Autor;
using Biblioteca.View.Emprestimo;
using Biblioteca.View.Fornecedor;
using Biblioteca.View.Funcionario;
using Biblioteca.View.Genero;
using Biblioteca.View.Leitor;
using Biblioteca.View.Livros;
using Biblioteca.View.Reserva;
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
        //Buttons da tela
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
        private void btnHome_Click(object sender, EventArgs e)
        {
            PrincipalTelaView principalTelaView = new PrincipalTelaView();
            NovaJanela.novaJanela(principalTelaView, Bounds);
        }

        private void icnButtonBar_Click(object sender, EventArgs e)
        {
            FecharMenu();
        }

        //private void livroToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    //if(form as LivrosBuscarView)
        //    //{
        //    //    form.Close();
        //    //    LivrosBuscarView livroBuscarView = new LivrosBuscarView();
        //    //    NovaJanela.novaJanela(livroBuscarView, Bounds);
        //    //}
            
        //}

        //Cadastrar
        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LivrosCadastrarView livrosCadastrarView = new LivrosCadastrarView();
            NovaJanela.novaJanela(livrosCadastrarView, Bounds);
        }
        private void leitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeitorCadastrarView leitorCadastrarView = new LeitorCadastrarView();
            NovaJanela.novaJanela(leitorCadastrarView, Bounds);
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncionarioCadastrarView funcionarioCadastrarView = new FuncionarioCadastrarView();
            NovaJanela.novaJanela(funcionarioCadastrarView, Bounds);
        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditoraCadastrarView editoraCadastrarView = new EditoraCadastrarView();
            NovaJanela.novaJanela(editoraCadastrarView, Bounds);
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutorCadastrarView autorCadastrarView = new AutorCadastrarView();
            NovaJanela.novaJanela(autorCadastrarView, Bounds);
        }

        private void gêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneroCadastrarView generoCadastrarView = new GeneroCadastrarView();
            NovaJanela.novaJanela(generoCadastrarView, Bounds);
        }

        //Buscar
        private void livroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LivrosBuscarView livrosBuscarView = new LivrosBuscarView();
            NovaJanela.novaJanela(livrosBuscarView, Bounds);
        }

        private void leitorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LeitorBuscarView leitorBuscarView = new LeitorBuscarView();
            NovaJanela.novaJanela(leitorBuscarView, Bounds);
        }

        private void funcionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FuncionarioBuscarView funcionarioBuscarView = new FuncionarioBuscarView();
            NovaJanela.novaJanela(funcionarioBuscarView, Bounds);
        }

        private void editoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditoraBuscarView editoraBuscarView = new EditoraBuscarView();
            NovaJanela.novaJanela(editoraBuscarView, Bounds);
        }

        private void autorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AutorBuscarView autorBuscarView = new AutorBuscarView();
            NovaJanela.novaJanela(autorBuscarView, Bounds);
        }

        private void gêneroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GeneroBuscarView generoBuscarView = new GeneroBuscarView();
            NovaJanela.novaJanela(generoBuscarView, Bounds);
        }
        //Empréstimo
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmprestimoCadastroView emprestimoCadastroView = new EmprestimoCadastroView();
            NovaJanela.novaJanela(emprestimoCadastroView, Bounds);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EmprestimoBuscarView emprestimoBuscarView = new EmprestimoBuscarView();
            NovaJanela.novaJanela(emprestimoBuscarView, Bounds);
        }
        //Reserva
        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            ReservaCadastroView reservaCadastroView = new ReservaCadastroView();
            NovaJanela.novaJanela(reservaCadastroView, Bounds);
        }

        private void buscarReserva_Click(object sender, EventArgs e)
        {
            ReservaBuscarView reservaBuscarView = new ReservaBuscarView();
            NovaJanela.novaJanela(reservaBuscarView, Bounds);
        }
    }
}
