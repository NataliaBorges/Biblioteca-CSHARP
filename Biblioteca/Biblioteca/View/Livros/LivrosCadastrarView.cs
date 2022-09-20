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
using Biblioteca.View.Fornecedor;
using Biblioteca.View.Genero;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Biblioteca.View.Livros {
    public partial class LivrosCadastrarView : Form {

        LivroController controller = new LivroController();
        List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
        Singleton singleton = Singleton.GetInstancia();
        DateTime data;

        public LivrosCadastrarView() {
            InitializeComponent();
        }

        private void LivrosCadastrarView_Load_1(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);
        }

        private void ClearForm() {
            this.tbNome.Clear();
            this.tbAutor.Clear();
            this.tbEdicao.Clear();
            this.maskedTextBoxAno.Clear();
            this.tbISBN.Clear();
            this.tbEditora.Clear();
            this.tbGenero.Clear();
            this.tbQuantidade.Clear();
        }

        private void btnPesqAutor_Click(object sender, EventArgs e)
        {
            singleton.setBuscarAutor(true);
            LivroPesquisarAutor livroPesquisarAutor = new LivroPesquisarAutor();
            NovaJanela.novaJanela(livroPesquisarAutor, this.Bounds);
        }

        private void btlPesqEditora_Click_1(object sender, EventArgs e)
        {
            singleton.setBuscarEditora(true);
            LivroPesquisarEditora livroPesquisarEditora= new LivroPesquisarEditora();
            NovaJanela.novaJanela(livroPesquisarEditora, this.Bounds);
        }

        private void btnPesqGenero_Click_1(object sender, EventArgs e)
        {
            singleton.setBuscarGenero(true);
            LivroPesquisarGenero livroPesquisarGenero = new LivroPesquisarGenero();
            NovaJanela.novaJanela(livroPesquisarGenero, this.Bounds);
        }

        private void LinkLblCadastroEmprestimo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            EditoraCadastrarView editoraCadastrarView = new EditoraCadastrarView();
            NovaJanela.novaJanela(editoraCadastrarView, this.Bounds);

        }

        private void linklblCadastrarAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AutorCadastrarView autorCadastrarView = new AutorCadastrarView();
            NovaJanela.novaJanela(autorCadastrarView, this.Bounds);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String titulo = tbNome.Text;
            String edicao = tbEdicao.Text;
            String ano = maskedTextBoxAno.Text;
            String ISBN = tbISBN.Text;
            int Quantidade = int.Parse(tbQuantidade.Text);
            int autor = singleton.getAutorBusca().Id_autor;
            int Genero = singleton.getEditoraBusca().ID;
            int Editora = singleton.getGeneroBusca().Id_genero;

            if (titulo.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                tbNome.Focus();
            }
            else if (tbAutor.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um Autor.", "Atenção", MessageBoxButtons.OK);
                tbAutor.Focus();
            }
            else if (edicao.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar uma Edição.", "Atenção", MessageBoxButtons.OK);
                tbEdicao.Focus();
            }
            else if (ano == "")
            {
                MessageBox.Show("Você precisa digitar um ano.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxAno.Focus();
            }
            else if (tbISBN.Text.Length < 13)
            {
                MessageBox.Show("Você precisa digitar um ISBN Válido.", "Atenção", MessageBoxButtons.OK);
                tbISBN.Focus();
            }
            else if (tbEditora.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa selecionar uma Editora Válida.", "Atenção", MessageBoxButtons.OK);
                tbEditora.Focus();
            }
            else if (tbGenero.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa selecionar um Gênero Válido.", "Atenção", MessageBoxButtons.OK);
                tbGenero.Focus();
            }
            else if (tbQuantidade.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar uma quantidade válida.", "Atenção", MessageBoxButtons.OK);
                tbQuantidade.Focus();
            }
            else
            {
                LivroModel livro = new LivroModel(titulo, edicao, ano, Quantidade, ISBN, autor, Genero, Editora );
                if (controller.Insercao(livro))
                {
                    MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
                }
            }

        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LivrosCadastrarView_Activated(object sender, EventArgs e)
        {
            if (singleton.getBuscarAutor())
            {
                singleton.setBuscarAutor(false);
                tbAutor.Text = singleton.getAutorBusca().Nome_Autor;
            }

            if (singleton.getBuscarEditora())
            {
                singleton.setBuscarEditora(false);
                tbEditora.Text = singleton.getEditoraBusca().Nome;
            }

            if (singleton.getBuscarGenero())
            {
                singleton.setBuscarGenero(false);
                tbGenero.Text = singleton.getGeneroBusca().Nome_genero;
            }
        }

        private void linklblCadastrarGenero_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GeneroCadastrarView generoCadastrarView = new GeneroCadastrarView();
            NovaJanela.novaJanela(generoCadastrarView, this.Bounds);
        }
    }
}
