using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Funcionario
{
    public partial class FuncionarioSelecionarColaboradorView : Form
    {
        FuncionarioController controller = new FuncionarioController();
        Singleton singleton = Singleton.GetInstancia();
        public FuncionarioSelecionarColaboradorView()
        {
            InitializeComponent();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FuncionarioSelecionarColaboradorView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            String busca = tbBuscar.Text;

            List<FuncionarioModel> lista = controller.Buscar(busca, isNome: true);
            if (tbBuscar.Text.Length > 0 && lista.Count > 0)
            {
                lblNotFound.Visible = false;
                popular(lista);
            }
        }

        private void popular(List<FuncionarioModel> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("nome", typeof(string));
            table.Columns.Add("Nascimento", typeof(DateTime));
            table.Columns.Add("CPF", typeof(string));
            table.Columns.Add("Telefone", typeof(string));
            table.Columns.Add("Função", typeof(string));
            table.Columns.Add("Email", typeof(string));


            if (lista.Count > 0)
            {
                foreach (FuncionarioModel funcionario in lista)
                {

                    table.Rows.Add( funcionario.getId(), 
                                    funcionario.Nome_funcionario,
                                    funcionario.Data_Nascimento,
                                    funcionario.CPF,
                                    funcionario.Telefone,
                                    funcionario.Funcao,
                                    funcionario.Email);

                }
                dtGridViewColaborador.DataSource = table;
            }
            int index = dtGridViewColaborador.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewColaborador.Rows[index].Selected = false;
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            //String busca = tbBuscar.Text;

            //List<EditoraModel> lista = controller.SelecionarEditora(busca);

            //if (tbBuscar.Text.Length > 0 && lista.Count > 0)
            //{
            //    lblNotFound.Visible = false;
            //    popular(lista);
            //}
            //else if (tbBuscar.Text.Length == 0)
            //{
            //    lblNotFound.Visible = false;
            //    dtGridViewEditora.DataSource = null;
            //}
            //else
            //{
            //    lblNotFound.Visible = true;
            //    dtGridViewEditora.DataSource = null;
            //}
        }

        private void dtGridViewAutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //foreach (DataGridViewRow row in dtGridViewEditora.SelectedRows)
            //{
            //    int id = int.Parse(row.Cells[0].Value.ToString());
            //    string nome = row.Cells[1].Value.ToString();

            //    EditoraModel editoraSelecionada = new EditoraModel(id, nome);

            //    singleton.setEditoraBusca(editoraSelecionada);
            //    this.Close();
            //}
        }
    }
}
