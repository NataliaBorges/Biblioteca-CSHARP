using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;

namespace Biblioteca.View.Relatorio {
    public partial class RelatorioLivroView : Form {

        LivroController controller = new LivroController();
        public RelatorioLivroView() {
            InitializeComponent();
        }

        private void RelatórioLivroView_Load(object sender, EventArgs e) {

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
                    item.SubItems.Add(livro.DataAquisicao.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(livro.Id_emprestimo.ToString());

                    LvLivros.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            DateTime inicio = DateTime.Parse(tbInicio.Text);
            DateTime fim = DateTime.Parse(tbFim.Text);
            List<LivroModel> lista = controller.Relatorio(inicio, fim);
            popular(lista);
        }
    }
}
