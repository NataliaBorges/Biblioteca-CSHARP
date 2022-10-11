using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;
using Biblioteca.View.Fornecedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Livros
{
    public partial class LivroPesquisarEditora : Form
    {
        EditoraController controller = new EditoraController();
        Singleton singleton = Singleton.GetInstancia();
        public LivroPesquisarEditora()
        {
            InitializeComponent();
        }

        private void LivroPesquisarEditora_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

        }
        private void popular(List<EditoraModel> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            if (lista.Count > 0)
            {
                foreach (EditoraModel editora in lista)
                {

                    table.Rows.Add(editora.getId(),
                                   editora.Nome);

                }
                dtGridViewEditora.DataSource = table;
            }
            int index = dtGridViewEditora.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewEditora.Rows[index].Selected = false;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            String busca = tbBuscar.Text;

            List<EditoraModel> lista = controller.SelecionarEditora(busca);

            if (tbBuscar.Text.Length > 0 && lista.Count > 0)
            {
                lblNotFound.Visible = false;
                popular(lista);
            }
            else if (tbBuscar.Text.Length == 0)
            {
                lblNotFound.Visible = false;
                dtGridViewEditora.DataSource = null;
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewEditora.DataSource = null;
            }
        }

        private void dtGridViewEditora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewEditora.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                string nome = row.Cells[1].Value.ToString();
                EditoraModel editoraSelecionada = new EditoraModel(id, nome);
                singleton.setEditoraBusca(editoraSelecionada);
                this.Close();
            }
        }
    }
}
