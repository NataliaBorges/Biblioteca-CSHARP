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
            this.menuControl1.setPanel(pnltotal);

            List<EditoraModel> lista = controller.PesquisarEditora();
            popular(lista);
        }
        private void popular(List<EditoraModel> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("CNPJ", typeof(string));
            if (lista.Count > 0)
            {
                foreach (EditoraModel editora in lista)
                {

                    table.Rows.Add(editora.getId(),
                                   editora.Nome,
                                   editora.CNPJ);

                }
                dtGridViewEditora.DataSource = table;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLblCadastrarEditora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditoraCadastrarView editoraCadastrarView = new EditoraCadastrarView();
            NovaJanela.novaJanela(editoraCadastrarView, Bounds);
        }

        private void dtGridViewEditora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewEditora.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                string nome = row.Cells[1].Value.ToString();
                string cnpj = row.Cells[2].Value.ToString();
                EditoraModel editoraSelecionada = new EditoraModel(id, nome, cnpj);
                singleton.setEditoraBusca(editoraSelecionada);
                this.Close();
            }
        }
    }
}
