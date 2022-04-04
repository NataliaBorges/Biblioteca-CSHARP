using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;

namespace Biblioteca.View.Livros {
    public partial class LivrosBuscarView : Form {

        LivroController controller = new LivroController();

        public LivrosBuscarView() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            String busca = tbBuscar.Text;

            if (rbNome.Checked) {
                List<LivroModel> lista = controller.Buscar(busca, isNome: true);
                popular(lista);
            }

            if (rbAutor.Checked) {
                List<LivroModel> lista = controller.Buscar(busca, isAutor: true);
                popular(lista);
            }

            if (rbEditora.Checked) {
                List<LivroModel> lista = controller.Buscar(busca, isEditora: true);
                popular(lista);
            }

        }

        private void popular(List<LivroModel> lista) {
            LvLivros.Items.Clear();
            if (lista.Count > 0) {
                foreach (LivroModel livro in lista) {
                    ListViewItem item = new ListViewItem(livro.getId().ToString());
                    item.SubItems.Add(livro.Nome);
                    item.SubItems.Add(livro.Autor);
                    item.SubItems.Add(livro.Fornecedor);
                    item.SubItems.Add(livro.Edicao);
                    item.SubItems.Add(livro.AnoPublicacao);
                    item.SubItems.Add(livro.DataAquisicao.ToString());

                    LvLivros.Items.Add(item);
                }
            }
        }

        private void LivrosBuscarView_Load(object sender, EventArgs e) {
            List<LivroModel> lista = controller.ListarTodos();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            List<LivroModel> lista = controller.ListarTodos();
            popular(lista);
        }

        private void LvLivros_MouseClick(object sender, MouseEventArgs e) {
            ListViewItem item = LvLivros.Items[LvLivros.FocusedItem.Index];
            LivroModel livro = new LivroModel(
                int.Parse(item.SubItems[0].Text),
                item.SubItems[1].Text,
                item.SubItems[2].Text,
                item.SubItems[4].Text,
                item.SubItems[5].Text,
                DateTime.Parse(item.SubItems[6].Text),
                item.SubItems[3].Text
            );

            LivrosEditarView editar = new LivrosEditarView(livro);

            Rectangle bounds = this.Bounds;
            editar.SetBounds(bounds.X, bounds.Y, editar.Bounds.Width, editar.Bounds.Height);
            editar.StartPosition = FormStartPosition.Manual;
            editar.Location = new Point(-2, 63);
            editar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
