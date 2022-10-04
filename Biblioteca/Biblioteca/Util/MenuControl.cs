using Biblioteca.Util;
using Biblioteca.View;
using Biblioteca.View.Autor;
using Biblioteca.View.Edicao;
using Biblioteca.View.Emprestimo;
using Biblioteca.View.Exemplar;
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
using EdicaoCadastrarView = Biblioteca.View.Edicao.EdicaoCadastrarView;

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
        private void fecharTelas()
        {
            FormCollection fc = Application.OpenForms;

            if (fc != null && fc.Count > 0)

            {

                for (int i = 1; i < fc.Count; i++)

                {

                    if (fc[i] != null && fc[i].IsDisposed != true)

                    {

                        fc[i].Dispose();

                    }

                }

            }
        }
        private void MenuControl_Load(object sender, EventArgs e){
                    ddmLivro.IsMainMenu = true;
                    ddmLivro.PrimaryColor = Color.Chocolate;
                    ddmLivro.MenuItemTextColor = Color.Chocolate;
                    

                    ddmLeitor.IsMainMenu = true;
                    ddmLeitor.PrimaryColor = Color.Chocolate;
                    ddmLeitor.MenuItemTextColor = Color.Chocolate;

                    ddmEmprestimo.IsMainMenu = true;
                    ddmEmprestimo.PrimaryColor = Color.Chocolate;
                    ddmEmprestimo.MenuItemTextColor = Color.Chocolate;

                    ddmReserva.IsMainMenu = true;
                    ddmReserva.PrimaryColor = Color.Chocolate;
                    ddmReserva.MenuItemTextColor = Color.Chocolate;

                    ddmRelatorio.IsMainMenu = true;
                    ddmRelatorio.PrimaryColor = Color.Chocolate;
                    ddmRelatorio.MenuItemTextColor = Color.Chocolate;

                    ddmFuncionario.IsMainMenu = true;
                    ddmFuncionario.PrimaryColor = Color.Chocolate;
                    ddmFuncionario.MenuItemTextColor = Color.Chocolate;
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

        private void BtnLivro_Click(object sender, EventArgs e)
        {
            ddmLivro.Show(btnLivro, ddmLivro.Width, 0);
        }
        private void BtnLeitor_Click(object sender, EventArgs e)
        {
            ddmLeitor.Show(btnLeitor, ddmLeitor.Width, 0);
        }

        private void BtnEmprestimo_Click(object sender, EventArgs e)
        {
            ddmEmprestimo.Show(btnEmprestimo, ddmEmprestimo.Width, 0);
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            ddmReserva.Show(btnReserva, ddmReserva.Width, 0);
        }

        private void btnRelatório_Click(object sender, EventArgs e)
        {
            ddmRelatorio.Show(btnRelatório, ddmRelatorio.Width, 0);
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            ddmFuncionario.Show(btnFuncionario, ddmFuncionario.Width, 0);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            fecharTelas();
            PrincipalTelaView principalTelaView = new PrincipalTelaView();
            NovaJanela.novaJanela(principalTelaView, Bounds);
        }

        private void icnButtonBar_Click(object sender, EventArgs e)
        {
            FecharMenu();
        }


        //Livro Cadastrar
        private void itemCadastrarLivro_Click(object sender, EventArgs e)
        {
            fecharTelas();
            LivrosCadastrarView livrosCadastrarView = new LivrosCadastrarView();
            NovaJanela.novaJanela(livrosCadastrarView, Bounds);
        }

        private void itemCadastrarExemplar_Click(object sender, EventArgs e)
        {
            ExemplarCadastrarView exemplarCadastrarView = new ExemplarCadastrarView();
            NovaJanela.novaJanela(exemplarCadastrarView, Bounds);
        }

        private void itemCadastrarEditora_Click(object sender, EventArgs e)
        {
            fecharTelas();
            EditoraCadastrarView editoraCadastrarView = new EditoraCadastrarView();
            NovaJanela.novaJanela(editoraCadastrarView, Bounds);
        }

        private void itemCadastrarAutor_Click(object sender, EventArgs e)
        {
            fecharTelas();
            AutorCadastrarView autorCadastrarView = new AutorCadastrarView();
            NovaJanela.novaJanela(autorCadastrarView, Bounds);
        }

        private void ItemCadastrarGenero_Click(object sender, EventArgs e)
        {
            fecharTelas();
            GeneroCadastrarView generoCadastrarView = new GeneroCadastrarView();
            NovaJanela.novaJanela(generoCadastrarView, Bounds);
        }

        private void itemCadastrarEdicao_Click(object sender, EventArgs e)
        {
            EdicaoCadastrarView edicaoCadastrarView = new EdicaoCadastrarView();
            NovaJanela.novaJanela(edicaoCadastrarView, Bounds);
        }

        //Livro Buscar
        private void itemBuscarLivro_Click(object sender, EventArgs e)
        {
            fecharTelas();
            LivrosBuscarView livrosBuscarView = new LivrosBuscarView();
            NovaJanela.novaJanela(livrosBuscarView, Bounds);
        }

        private void itemBuscarExemplar_Click(object sender, EventArgs e)
        {
            ExemplarBuscarView exemplarBuscarView = new ExemplarBuscarView();
            NovaJanela.novaJanela(exemplarBuscarView, Bounds);
        }

        private void itemBuscarEditora_Click(object sender, EventArgs e)
        {
            fecharTelas();
            EditoraBuscarView editoraBuscarView = new EditoraBuscarView();
            NovaJanela.novaJanela(editoraBuscarView, Bounds);
        }

        private void itemBuscarAutor_Click(object sender, EventArgs e)
        {
            fecharTelas();
            AutorBuscarView autorBuscarView = new AutorBuscarView();
            NovaJanela.novaJanela(autorBuscarView, Bounds);
        }

        private void itemBuscarGenero_Click(object sender, EventArgs e)
        {
            fecharTelas();
            GeneroBuscarView generoBuscarView = new GeneroBuscarView();
            NovaJanela.novaJanela(generoBuscarView, Bounds);
        }

        private void itemBuscarEdicao_Click(object sender, EventArgs e)
        {
            EdicaoBuscarView edicaoBuscarView = new EdicaoBuscarView();
            NovaJanela.novaJanela(edicaoBuscarView, Bounds);
        }

        //Leitor Cadastrar
        private void itemCadastrarLeitor_Click(object sender, EventArgs e)
        {
            fecharTelas();
            LeitorCadastrarView leitorCadastrarView = new LeitorCadastrarView();
            NovaJanela.novaJanela(leitorCadastrarView, Bounds);
        }

        //Leitor BUscar
        private void itemBuscarLeitor_Click(object sender, EventArgs e)
        {
            fecharTelas();
            LeitorBuscarView leitorBuscarView = new LeitorBuscarView();
            NovaJanela.novaJanela(leitorBuscarView, Bounds);
        }

        //Empréstimo Cadastrar
        private void itemCadastrarEmprestimo_Click(object sender, EventArgs e)
        {
            fecharTelas();
            EmprestimoCadastroView emprestimoCadastroView = new EmprestimoCadastroView();
            NovaJanela.novaJanela(emprestimoCadastroView, Bounds);
        }

        //Empréstimo buscar
        private void itemBuscarEmprestimo_Click(object sender, EventArgs e)
        {
            fecharTelas();
            EmprestimoBuscarView emprestimoBuscarView = new EmprestimoBuscarView();
            NovaJanela.novaJanela(emprestimoBuscarView, Bounds);
        }

        //Reserva Cadastrar
        private void itemCadastrarReserva_Click(object sender, EventArgs e)
        {
            fecharTelas();
            ReservaCadastroView reservaCadastroView = new ReservaCadastroView();
            NovaJanela.novaJanela(reservaCadastroView, Bounds);
        }

        //ReservaBuscar
        private void itemBuscarReserva_Click(object sender, EventArgs e)
        {
            fecharTelas();
            ReservaBuscarView reservaBuscarView = new ReservaBuscarView();
            NovaJanela.novaJanela(reservaBuscarView, Bounds);
        }

        //Funcionário Cadastrar
        private void itemCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            fecharTelas();
            FuncionarioCadastrarView funcionarioCadastrarView = new FuncionarioCadastrarView();
            NovaJanela.novaJanela(funcionarioCadastrarView, Bounds);
        }

        //Funcionário Buscar
        private void itemBuscarFuncionario_Click(object sender, EventArgs e)
        {
            fecharTelas();
            FuncionarioBuscarView funcionarioBuscarView = new FuncionarioBuscarView();
            NovaJanela.novaJanela(funcionarioBuscarView, Bounds);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            fecharTelas();
            TelaLoginView login = new TelaLoginView();
            NovaJanela.novaJanela(login, Bounds);
        }

        
    }
}
