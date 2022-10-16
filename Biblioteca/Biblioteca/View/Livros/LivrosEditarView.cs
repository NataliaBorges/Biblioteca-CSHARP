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
        public LivrosEditarView() {
            LivroModel livroSingleton = singleton.getLivroExemplar();
            this.livro = controller.BuscarLivroId(livroSingleton.getId());
            singleton.setLivroExemplar(null);
            InitializeComponent();

        }

        private void LivrosItemView_Load(object sender, EventArgs e) {

            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String titulo = tbNome.Text;
            

            if (titulo.Length <= 0)
            {
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
                int autor = this.livro.IdAutor;
                if(singleton.getAutorBusca()!= null)
                {
                    autor = singleton.getAutorBusca().Id_autor;
                }
                int Genero = this.livro.IdGenero;
                if (singleton.getGeneroBusca() != null)
                {
                    Genero = singleton.getGeneroBusca().Id_genero;
                }

                int Editora = this.livro.IdEditora;
                if (singleton.getEditoraBusca() != null)
                {
                    Editora = singleton.getEditoraBusca().ID;
                }

                LivroModel livro = new LivroModel(this.livro.getId(), titulo, Editora, autor, Genero);
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
    }
}
