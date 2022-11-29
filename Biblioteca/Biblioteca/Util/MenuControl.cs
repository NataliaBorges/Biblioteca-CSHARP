using Biblioteca.Util;
using Biblioteca.View;
using Biblioteca.View.Autor;
using Biblioteca.View.Edicao;
using Biblioteca.View.Emprestimo;
using Biblioteca.View.Exemplar;
using Biblioteca.View.Editora;
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
using Biblioteca.View.Relatorio;

namespace Biblioteca.Util
{
    public partial class MenuControl : UserControl
    {
        Singleton singleton = Singleton.GetInstancia();
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
            lbmenuNome.Text = singleton.getFuncionario().Nome_funcionario;
            lbmenuFuncao.Text = singleton.getFuncionario().Funcao;
            lblUser.Text = singleton.getFuncionario().Nome_funcionario.Substring(0, 1);
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
        private void MenuControl_Load(object sender, EventArgs e)
        {
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

            ddmUsuario.IsMainMenu = true;
            ddmUsuario.PrimaryColor = Color.Chocolate;
            ddmUsuario.MenuItemTextColor = Color.Chocolate;
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
                pnlUser.Dock = DockStyle.Top;
                icnButtonBar.Dock = DockStyle.Bottom;
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

        private void lblUser_Click(object sender, EventArgs e)
        {
            if (this.Width > 100)
            {
                ddmUsuario.Show(lblUser, 115, 0);
            }
            else
            {
                ddmUsuario.Show(lblUser, 50, 0);
            }
        }

        private void BtnLivro_Click(object sender, EventArgs e)
        {
            if (singleton.getFuncionario().Funcao != "Auxiliar")
            {
                if (this.Width > 100)
                {
                    ddmLivro.Show(btnLivro, 167, 0);
                }
                else
                {
                    ddmLivro.Show(btnLivro, 67, 0);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissão para acessar esta área.", "Atenção", MessageBoxButtons.OK);
            }
        }
        private void BtnLeitor_Click(object sender, EventArgs e)
        {
            if (singleton.getFuncionario().Funcao != "Auxiliar")
            {
                if (this.Width > 100)
                {
                    ddmLeitor.Show(btnLeitor, 167, 0);
                }
                else
                {
                    ddmLeitor.Show(btnLeitor, 67, 0);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissão para acessar esta área.", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void BtnEmprestimo_Click(object sender, EventArgs e)
        {
            if (this.Width > 100)
            {
                ddmEmprestimo.Show(btnEmprestimo, 167, 0);
            }
            else
            {
                ddmEmprestimo.Show(btnEmprestimo, 67, 0);
            }
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            if (this.Width > 100)
            {
                ddmReserva.Show(btnReserva, 167, 0);
            }
            else
            {
                ddmReserva.Show(btnReserva, 67, 0);
            }
        }

        private void btnRelatório_Click(object sender, EventArgs e)
        {
            if (singleton.getFuncionario().Funcao == "Administrador")
            {
                if (this.Width > 100)
                {
                    ddmRelatorio.Show(btnRelatório, 167, 0);
                }
                else
                {
                    ddmRelatorio.Show(btnRelatório, 67, 0);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissão para acessar esta área.", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            if (singleton.getFuncionario().Funcao == "Administrador")
            {
                if (this.Width > 100)
                {
                    ddmFuncionario.Show(btnFuncionario, 167, 0);
                }
                else
                {
                    ddmFuncionario.Show(btnFuncionario, 67, 0);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissão para acessar esta área.", "Atenção", MessageBoxButtons.OK);
            }
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

        //Livro
        private void cadastrarLivro_Click(object sender, EventArgs e)
        {
            fecharTelas();
            LivrosCadastrarView livrosCadastrarView = new LivrosCadastrarView();
            NovaJanela.novaJanela(livrosCadastrarView, Bounds);
        }

        private void buscarLivro_Click(object sender, EventArgs e)
        {
            fecharTelas();
            LivrosBuscarView livrosBuscarView = new LivrosBuscarView();
            NovaJanela.novaJanela(livrosBuscarView, Bounds);
        }
        //Exemplar
        private void cadastrarExemplar_Click(object sender, EventArgs e)
        {
            fecharTelas();
            ExemplarBuscarLivroView exemplarBuscarLivroView = new ExemplarBuscarLivroView();
            NovaJanela.novaJanela(exemplarBuscarLivroView, Bounds);
        }
        private void buscarExemplar_Click(object sender, EventArgs e)
        {
            fecharTelas();
            ExemplarBuscarView exemplarBuscarView = new ExemplarBuscarView();
            NovaJanela.novaJanela(exemplarBuscarView, Bounds);
        }
        //Editora
        private void cadastrarEditora_Click(object sender, EventArgs e)
        {
            fecharTelas();
            EditoraCadastrarView editoraCadastrarView = new EditoraCadastrarView();
            NovaJanela.novaJanela(editoraCadastrarView, Bounds);
        }
        private void BuscarEditora_Click(object sender, EventArgs e)
        {
            fecharTelas();
            EditoraBuscarView editoraBuscarView = new EditoraBuscarView();
            NovaJanela.novaJanela(editoraBuscarView, Bounds);
        }
        //autor
        private void cadastrarAutor_Click(object sender, EventArgs e)
        {
            fecharTelas();
            AutorCadastrarView autorCadastrarView = new AutorCadastrarView();
            NovaJanela.novaJanela(autorCadastrarView, Bounds);
        }

        private void BuscarAutor_Click(object sender, EventArgs e)
        {
            fecharTelas();
            AutorBuscarView autorBuscarView = new AutorBuscarView();
            NovaJanela.novaJanela(autorBuscarView, Bounds);
        }
        //Gênero
        private void cadastrarGenero_Click(object sender, EventArgs e)
        {
            fecharTelas();
            GeneroCadastrarView generoCadastrarView = new GeneroCadastrarView();
            NovaJanela.novaJanela(generoCadastrarView, Bounds);
        }
        private void buscarGenero_Click(object sender, EventArgs e)
        {
            fecharTelas();
            GeneroBuscarView generoBuscarView = new GeneroBuscarView();
            NovaJanela.novaJanela(generoBuscarView, Bounds);
        }
        //Edição
        private void cadastrarEdicao_Click(object sender, EventArgs e)
        {
            fecharTelas();
            EdicaoCadastrarView edicaoCadastrarView = new EdicaoCadastrarView();
            NovaJanela.novaJanela(edicaoCadastrarView, Bounds);
        }
        private void buscarEdicao_Click(object sender, EventArgs e)
        {
            fecharTelas();
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

        //Leitor Buscar
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

        private void VisualizarReserva_Click(object sender, EventArgs e)
        {
            ReservaMesView reservaVisualizarView = new ReservaMesView();
            NovaJanela.novaJanela(reservaVisualizarView, Bounds);
        }

        private void RelatorioEditora(object sender, EventArgs e)
        {
            RelatorioEditoraView relatorioEditoraView = new RelatorioEditoraView();
            NovaJanela.novaJanela(relatorioEditoraView, Bounds);
        }

        private void RelatorioLivro_Click(object sender, EventArgs e)
        {
            RelatorioLivroView relatorioLivroView = new RelatorioLivroView();
            NovaJanela.novaJanela(relatorioLivroView, Bounds);
        }

        private void RelatorioEmprestimo_Click(object sender, EventArgs e)
        {
            RelatorioEmprestimoView relatorioEmprestimoView = new RelatorioEmprestimoView();
            NovaJanela.novaJanela(relatorioEmprestimoView, Bounds);
        }

        private void btnRelatorioReserva_Click(object sender, EventArgs e)
        {
            RelatorioReservaView relatorioReservaView = new RelatorioReservaView();
            NovaJanela.novaJanela(relatorioReservaView, Bounds);
        }


        private void btnTrocarSenha_Click(object sender, EventArgs e)
        {
            FuncionarioTrocarSenhaView funcionarioTrocarSenhaView = new FuncionarioTrocarSenhaView();
            NovaJanela.novaJanela(funcionarioTrocarSenhaView, Bounds);
        }
    }
}
