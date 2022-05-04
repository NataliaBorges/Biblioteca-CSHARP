using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.View.Livros;

namespace Biblioteca.View.Emprestimo {
    public partial class EmprestimoBuscarExemplarView : Form {

        EmprestimoController controller = new EmprestimoController();
        int idLivro;
        public EmprestimoBuscarExemplarView(int idLivro) {
            this.idLivro = idLivro;
            InitializeComponent();
        }
        private void EmprestimoBuscarExemplarView_Load(object sender, EventArgs e) {
            List<ExemplarModel> lista = controller.ListarTodosExemplares(idLivro);
            popular(lista);
        }
        protected override void OnActivated(EventArgs e) {
            List<ExemplarModel> lista = controller.ListarTodosExemplares(idLivro);
            popular(lista);
        }
        private void novaJanela(Form form) {
            Rectangle bounds = this.Bounds;
            form.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(-2, 63);
            form.ShowDialog();
        }

        private void popular(List<ExemplarModel> lista) {
            LvExemplar.Items.Clear();
            if (lista.Count > 0) {
                foreach (ExemplarModel exemplar in lista) {
                    ListViewItem item = new ListViewItem(exemplar.getId().ToString());
                    item.SubItems.Add(exemplar.Nome);
                    item.SubItems.Add(exemplar.Autor);
                    item.SubItems.Add(exemplar.Edicao);
                    item.SubItems.Add(exemplar.AnoPublicacao);
                    item.SubItems.Add(exemplar.ISBN);
                    item.SubItems.Add(exemplar.Fornecedor);

                    LvExemplar.Items.Add(item);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void LvExemplar_MouseClick(object sender, MouseEventArgs e) {
            ListViewItem item = LvExemplar.Items[LvExemplar.FocusedItem.Index];
            ExemplarModel exemplar = new ExemplarModel(
                //int ID, String nome, String autor, String Edicao, String AnoPublicacao, String ISBN, String Fornecedor)
                int.Parse(item.SubItems[0].Text),
                item.SubItems[1].Text,
                item.SubItems[2].Text,
                item.SubItems[6].Text,
                item.SubItems[5].Text,
                item.SubItems[3].Text,
                item.SubItems[4].Text
            );

            controller.InserirExemplarEmprestimo(exemplar);
            this.Close();
        }
    }
}
