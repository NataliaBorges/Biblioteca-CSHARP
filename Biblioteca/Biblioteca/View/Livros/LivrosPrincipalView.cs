using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.View;

namespace Biblioteca.View.Livros {
    public partial class LivrosPrincipalView : Form {

        LivroController controller = new LivroController();
        public LivrosPrincipalView() {
            InitializeComponent();
        }

        private void LivrosPrincipalView_Load(object sender, EventArgs e) {
            List<LivroModel> lista = controller.ListarTodos();
            popular(lista);
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

        protected override void OnActivated(EventArgs e) {
            List<LivroModel> lista = controller.ListarTodos();
            popular(lista);
        }

        private void novaJanela(Form form) {
            Rectangle bounds = this.Bounds;
            form.SetBounds(bounds.X, bounds.Y, form.Bounds.Width, form.Bounds.Height);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            LivrosCadastrarView cadastrar = new LivrosCadastrarView();
            novaJanela(cadastrar);
        }

        private void button2_Click(object sender, EventArgs e) {
            LivrosBuscarView buscar = new LivrosBuscarView();
            novaJanela(buscar);
        }
    }
}
