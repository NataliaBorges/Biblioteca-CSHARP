using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;

namespace Biblioteca.View.Fornecedor {
    public partial class EditoraBuscarView : Form {

        EditoraController controller = new EditoraController();

        public EditoraBuscarView() {
            InitializeComponent();
        }

        //private void LvFornecedor_MouseClick(object sender, MouseEventArgs e) {
        //    ListViewItem item = LvFornecedor.Items[LvFornecedor.FocusedItem.Index];
        //    EditoraModel fornecedor = new EditoraModel(
        //        int.Parse(item.SubItems[0].Text),
        //        item.SubItems[1].Text,
        //        item.SubItems[2].Text,
        //        item.SubItems[3].Text,
        //        item.SubItems[4].Text,
        //        item.SubItems[5].Text
        //    );

        //    EditoraEditarView editar = new EditoraEditarView(fornecedor);

        //    Rectangle bounds = this.Bounds;
        //    editar.SetBounds(bounds.X, bounds.Y, editar.Bounds.Width, editar.Bounds.Height);
        //    editar.StartPosition = FormStartPosition.Manual;
        //    editar.Location = new Point(-2, 63);
        //    editar.ShowDialog();
        //}

        private void popular(List<EditoraModel> lista) {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Endereço", typeof(string));
            table.Columns.Add("CNPJ", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Telefone", typeof(string));
            dtGridViewEditora.DataSource = lista;
            if (lista.Count > 0)
            {
                foreach (EditoraModel editoras in lista)
                {

                    table.Rows.Add(editoras.getId(),
                                   editoras.Nome,
                                   editoras.Endereco,
                                   editoras.Email,
                                   editoras.CNPJ,
                                   editoras.Telefone);
                }
                dtGridViewEditora.DataSource = table;
            }
        }

        private void FornecedorBuscarView_Load(object sender, EventArgs e) {
            List<EditoraModel> lista = controller.ListarTodos();
            popular(lista);
        }

        private void button1_Click(object sender, EventArgs e) {
            String busca = tbBuscar.Text;

            if (rbNome.Checked) {
                List<EditoraModel> lista = controller.Buscar(busca, isNome: true);
                popular(lista);
            }

            if (rbCNPJ.Checked) {
                List<EditoraModel> lista = controller.Buscar(busca, isCNPJ: true);
                popular(lista);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            EditoraCadastrarView editoraCadastrarView = new EditoraCadastrarView();
            NovaJanela.novaJanela(editoraCadastrarView, this.Bounds);
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditoraBuscarView_Activated(object sender, EventArgs e)
        {
            List<EditoraModel> lista = controller.ListarTodos();
            popular(lista);
        }
    }
}
