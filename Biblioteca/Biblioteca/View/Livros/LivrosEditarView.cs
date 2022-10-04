using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Model;
using Biblioteca.Controller;
using Biblioteca.Util;

namespace Biblioteca.View.Livros {
    public partial class LivrosEditarView : Form {
        LivroModel livro;
        LivroController controller = new LivroController();
        Singleton singleton = Singleton.GetInstancia();
        DateTime data;
        public LivrosEditarView(LivroModel livroSelecionado) {
            this.livro = livroSelecionado;
            InitializeComponent();

        }

        private void LivrosItemView_Load(object sender, EventArgs e) {

            this.menuControl1.setPanel(pnltotal);

            if (livro != null) {
                tbNome.Text = this.livro.Titulo;
                tbAutor.Text = this.livro.NomeAutor;
                tbEditora.Text = this.livro.NomeEditora;
                tbGenero.Text = this.livro.NomeGenero;
                tbQuantidade.Text = this.livro.Quantidade.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                if (controller.Excluir(livro)) {
                    MessageBox.Show("Excluído com sucesso", "Parabéns", MessageBoxButtons.OK);
                } else {
                    MessageBox.Show("Não foi possível excluir", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            String titulo = tbNome.Text;
            int Quantidade = int.Parse(tbQuantidade.Text);
            int autor = singleton.getAutorBusca().Id_autor;
            int Genero = singleton.getEditoraBusca().ID;
            int Editora = singleton.getGeneroBusca().Id_genero;

            if (titulo.Length <= 0) {
                    MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                    tbAutor.Focus();
                }
                else if (tbEditora.Text.Length <= 0)
                {
                    MessageBox.Show("Você selecionar uma editora.", "Atenção", MessageBoxButtons.OK);
                    tbEditora.Focus();
                }
                else if (tbAutor.Text.Length <= 0)
                {
                    MessageBox.Show("Você precisa digitar um Autor.", "Atenção", MessageBoxButtons.OK);
                    tbAutor.Focus();
                }
                else if (tbEditora.Text.Length <= 0)
                {
                    MessageBox.Show("Você precisa digitar um Autor.", "Atenção", MessageBoxButtons.OK);
                    tbEditora.Focus();
                }
                else if (tbGenero.Text.Length <= 0)
                {
                    MessageBox.Show("Você precisa digitar um Autor.", "Atenção", MessageBoxButtons.OK);
                    tbGenero.Focus();
                }
                else
                {
                    LivroModel livro = new LivroModel(this.livro.getId(), titulo, autor, Genero, Editora);
                    if (controller.Atualizar(livro))
                    {
                        MessageBox.Show("Atualizado com sucesso", "Parabéns", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar.", "Atenção", MessageBoxButtons.OK);
                    }
            }
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair sem Salvar?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                LivrosBuscarView livrosBuscarView = new LivrosBuscarView();
                NovaJanela.novaJanela(livrosBuscarView, this.Bounds);
            }
            
        }

        private void LivrosEditarView_Activated(object sender, EventArgs e)
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
    }
}
