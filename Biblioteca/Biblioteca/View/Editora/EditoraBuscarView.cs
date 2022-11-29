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

namespace Biblioteca.View.Editora
{
    public partial class EditoraBuscarView : Form
    {

        EditoraController controller = new EditoraController();
        EditoraModel editora;

        public EditoraBuscarView()
        {
            InitializeComponent();
        }
        private void FornecedorBuscarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            CbEstado.Text = "Ambos";
        }

        private void popular(List<EditoraModel> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Endereço", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("CNPJ", typeof(string));
            table.Columns.Add("Telefone", typeof(string));
            table.Columns.Add("Status", typeof(string));
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
                                   editoras.Telefone, 
                                   editoras.getEstado());
                }
                dtGridViewEditora.DataSource = table;
            }
            int index = dtGridViewEditora.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewEditora.Rows[index].Selected = false;
            }
        }
        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PrincipalTelaView telaPrincipal = new PrincipalTelaView();
                NovaJanela.novaJanela(telaPrincipal, this.Bounds);
                this.Close();
            }
        }

        private void btnCadastrarEditora_Click(object sender, EventArgs e)
        {
            EditoraCadastrarView editoraCadastrarView = new EditoraCadastrarView();
            NovaJanela.novaJanela(editoraCadastrarView, this.Bounds);
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            this.editora = null;
            String status = CbEstado.Text;
            String busca = tbBuscar.Text;

            if (rbNome.Checked)
            {
                List<EditoraModel> lista = controller.Buscar(busca, isNome: true, status:status);
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

            if (rbCNPJ.Checked)
            {
                List<EditoraModel> lista = controller.Buscar(busca, isCNPJ: true, status: status);
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
            if(rbNome.Checked == false && rbCNPJ.Checked == false)
            {
                List<EditoraModel> lista = controller.Buscar(busca, isNome: true, status: status);
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
        }

        private void CbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewEditora.DataSource = null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (editora != null)
            {
                EditoraEditarView editoraEditarView = new EditoraEditarView(editora);
                NovaJanela.novaJanela(editoraEditarView, Bounds);
            }
            else
            {
                MessageBox.Show("Você precisa selecionar uma editora", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void dtGridViewEditora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewEditora.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                String  nome = row.Cells[1].Value.ToString();
                String  endereco = row.Cells[2].Value.ToString();
                String email = row.Cells[3].Value.ToString();
                String  cnpj = row.Cells[4].Value.ToString();
                String  telefone = row.Cells[5].Value.ToString();

                int estado = 0;

                if (row.Cells[6].Value.ToString() == "Ativo")
                {
                    estado = 1;
                }

                this.editora = new EditoraModel(id, nome, endereco, telefone, cnpj, email, estado);
            }
        }

        private void rbNome_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewEditora.DataSource = null;
        }

        private void rbCNPJ_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewEditora.DataSource = null;
        }

        private void EditoraBuscarView_Activated(object sender, EventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewEditora.DataSource = null;
        }
    }
}
