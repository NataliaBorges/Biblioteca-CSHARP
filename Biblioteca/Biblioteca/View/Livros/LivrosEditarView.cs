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
        DateTime data;
        public LivrosEditarView() {
            InitializeComponent();
        }

        private void LivrosItemView_Load(object sender, EventArgs e) {

            this.menuControl1.setPanel(pnltotal);

            if (livro != null) {
                //tbNome.Text = this.Titulo;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                if (controller.Excluir(livro)) {
                    MessageBox.Show("Excluído com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                } else {
                    MessageBox.Show("Não foi possível excluir", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
                String nome = tbAutor.Text;
                String autor = tbAutor.Text;
                String edicao = tbEdicao.Text;
                String ano = maskedTextBoxAno.Text;
                DateTime data = this.data; //.ToString("yyyy-MM-dd");
                String ISBN = tbISBN.Text;

                if (nome.Length <= 0) {
                    MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                    tbAutor.Focus();
                }
                else if (tbEditora.Text.Length <= 0)
                {
                    MessageBox.Show("Você selecionar uma editora.", "Atenção", MessageBoxButtons.OK);
                    tbEditora.Focus();
                }
                else if (autor.Length <= 0) {
                    MessageBox.Show("Você precisa digitar um Autor.", "Atenção", MessageBoxButtons.OK);
                    tbAutor.Focus();
                }
                else if (edicao.Length <= 0) {
                    MessageBox.Show("Você precisa digitar uma Edição.", "Atenção", MessageBoxButtons.OK);
                    tbEdicao.Focus();
                }
                else if (ano == "") {
                    MessageBox.Show("Você precisa digitar um ano.", "Atenção", MessageBoxButtons.OK);
                    maskedTextBoxAno.Focus();
                }
                else if (tbISBN.Text.Length < 13) {
                    MessageBox.Show("Você precisa digitar um ISBN Válido.", "Atenção", MessageBoxButtons.OK);
                }
                //else if (Validar.ValidaISBN13(ISBN)) {
                //    MessageBox.Show("Você precisa digitar um ISBN Válido.", "Atenção", MessageBoxButtons.OK);
                //    tbISBN.Focus();
                ////}
                //else {
                //    LivroModel livro = new LivroModel(this.livro.getId(),nome, autor, edicao, ano, data, ISBN,);
                //    if (controller.Atualizar(livro)) {
                //        MessageBox.Show("Atualizado com sucesso", "Parabéns", MessageBoxButtons.OK);
                //        this.Close();
                //    }
                //    else {
                //        MessageBox.Show("Não foi possível atualizar.", "Atenção", MessageBoxButtons.OK);
                //    }
                //}
            }
    }
}
