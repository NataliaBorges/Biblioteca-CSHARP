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
    public partial class ForcecedorPrincipalView : Form {

        FornecedorController controller = new FornecedorController();

        public ForcecedorPrincipalView() {
            InitializeComponent();
        }

        private void novaJanela(Form form) {
            Rectangle bounds = this.Bounds;
            form.SetBounds(bounds.X, bounds.Y, form.Bounds.Width, form.Bounds.Height);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
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

        private void ForcecedorPrincipalView_Load(object sender, EventArgs e) {
            List<FornecedorModel> lista = controller.ListarTodos();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            List<FornecedorModel> lista = controller.ListarTodos();
            popular(lista);
        }

        private void button2_Click(object sender, EventArgs e) {
            FornecedorCadastrarView cadastrar = new FornecedorCadastrarView();
            novaJanela(cadastrar);
        }

        private void button3_Click(object sender, EventArgs e) {
            FornecedorBuscarView buscar = new FornecedorBuscarView();
            novaJanela(buscar);
        }
    }
}
