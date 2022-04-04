using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;

namespace Biblioteca.View.Fornecedor {
    public partial class FornecedorBuscarView : Form {

        FornecedorController controller = new FornecedorController();

        public FornecedorBuscarView() {
            InitializeComponent();
        }

        private void LvFornecedor_MouseClick(object sender, MouseEventArgs e) {
            ListViewItem item = LvFornecedor.Items[LvFornecedor.FocusedItem.Index];
            FornecedorModel fornecedor = new FornecedorModel(
                int.Parse(item.SubItems[0].Text),
                item.SubItems[1].Text,
                item.SubItems[2].Text,
                item.SubItems[3].Text,
                item.SubItems[4].Text
            );

            FornecedorEditarView editar = new FornecedorEditarView(fornecedor);

            Rectangle bounds = this.Bounds;
            editar.SetBounds(bounds.X, bounds.Y, editar.Bounds.Width, editar.Bounds.Height);
            editar.StartPosition = FormStartPosition.CenterScreen;
            editar.ShowDialog();
        }

        private void popular(List<FornecedorModel> lista) {
            LvFornecedor.Items.Clear();
            if (lista.Count > 0) {
                foreach (FornecedorModel fornecedor in lista) {
                    ListViewItem item = new ListViewItem(fornecedor.getId().ToString());
                    item.SubItems.Add(fornecedor.Nome);
                    item.SubItems.Add(fornecedor.Endereco);
                    item.SubItems.Add(fornecedor.Telefone);
                    item.SubItems.Add(fornecedor.CNPJ);

                    LvFornecedor.Items.Add(item);
                }
            }
        }

        private void FornecedorBuscarView_Load(object sender, EventArgs e) {
            List<FornecedorModel> lista = controller.ListarTodos();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            List<FornecedorModel> lista = controller.ListarTodos();
            popular(lista);
        }

        private void button1_Click(object sender, EventArgs e) {
            String busca = tbBuscar.Text;

            if (rbNome.Checked) {
                List<FornecedorModel> lista = controller.Buscar(busca, isNome: true);
                popular(lista);
            }

            if (rbCNPJ.Checked) {
                List<FornecedorModel> lista = controller.Buscar(busca, isCNPJ: true);
                popular(lista);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
