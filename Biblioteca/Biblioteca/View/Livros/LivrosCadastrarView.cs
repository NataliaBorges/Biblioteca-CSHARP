using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;
using Biblioteca.View.Autor;
using Biblioteca.View.Emprestimo;
using Biblioteca.View.Editora;
using Biblioteca.View.Genero;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Biblioteca.View.Livros
{
    public partial class LivrosCadastrarView : Form
    {

        LivroController controller = new LivroController();
        List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
        Singleton singleton = Singleton.GetInstancia();
        DateTime data;

        public LivrosCadastrarView()
        {
            InitializeComponent();
            this.tbAutor.Enabled = false;
            this.tbEditora.Enabled = false;
            this.tbGenero.Enabled = false;
        }

        private void LivrosCadastrarView_Load_1(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

        }

        private void ClearForm()
        {
            this.tbNome.Clear();
            this.tbAutor.Clear();
            this.tbEditora.Clear();
            this.tbGenero.Clear();
        }
        private void BtnAutor_Click(object sender, EventArgs e)
        {
            singleton.setBuscarAutor(true);
            LivroPesquisarAutor livroPesquisarAutor = new LivroPesquisarAutor();
            NovaJanela.novaJanela(livroPesquisarAutor, this.Bounds);
        }
        private void BtnEditora_Click(object sender, EventArgs e)
        {
            singleton.setBuscarEditora(true);
            LivroPesquisarEditora livroPesquisarEditora = new LivroPesquisarEditora();
            NovaJanela.novaJanela(livroPesquisarEditora, this.Bounds);
        }

        private void BtnGenero_Click(object sender, EventArgs e)
        {
            singleton.setBuscarGenero(true);
            LivroPesquisarGenero livroPesquisarGenero = new LivroPesquisarGenero();
            NovaJanela.novaJanela(livroPesquisarGenero, this.Bounds);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String titulo = tbNome.Text;
            int autor = 0;
            int Editora = 0;
            int Genero = 0;

            if (titulo.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                tbNome.Focus();
            }
            else if (singleton.getAutorBusca() == null)
            {
                MessageBox.Show("Você precisa selecionar um Autor Válido.", "Atenção", MessageBoxButtons.OK);
                tbAutor.Focus();
            }
            else if (singleton.getGeneroBusca() == null)
            {
                MessageBox.Show("Você precisa selecionar um Gênero Válido.", "Atenção", MessageBoxButtons.OK);
                tbGenero.Focus();

            }
            else if (singleton.getEditoraBusca() == null)
            {
                MessageBox.Show("Você precisa selecionar uma Editora Válida.", "Atenção", MessageBoxButtons.OK);
                tbEditora.Focus();
            }
            else
            {
                autor = singleton.getAutorBusca().Id_autor;
                Genero = singleton.getGeneroBusca().Id_genero;
                Editora = singleton.getEditoraBusca().ID;

                LivroModel livro = new LivroModel(titulo, Editora, autor, Genero);
                try
                {
                    controller.Insercao(livro);
                    MessageBox.Show("Cadastrado com Sucesso!", "Parabéns", MessageBoxButtons.OK);
                    ClearForm();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LivrosCadastrarView_Activated(object sender, EventArgs e)
        {
            if (singleton.getBuscarAutor() && singleton.getAutorBusca() != null)
            {
                singleton.setBuscarAutor(false);
                tbAutor.Text = singleton.getAutorBusca().Nome_Autor;
            }

            if (singleton.getBuscarEditora() && singleton.getEditoraBusca() != null)
            {
                singleton.setBuscarEditora(false);
                tbEditora.Text = singleton.getEditoraBusca().Nome;
            }

            if (singleton.getBuscarGenero() && singleton.getGeneroBusca() != null)
            {
                singleton.setBuscarGenero(false);
                tbGenero.Text = singleton.getGeneroBusca().Nome_genero;
            }
        }
    }
}
