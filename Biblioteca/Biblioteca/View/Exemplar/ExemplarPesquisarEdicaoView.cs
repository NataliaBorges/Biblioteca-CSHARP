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

namespace Biblioteca.View.Exemplar
{
    public partial class ExemplarPesquisarEdicaoView : Form
    {
        EdicaoController controller = new EdicaoController();
        Singleton singleton = Singleton.GetInstancia();

        public ExemplarPesquisarEdicaoView()
        {
            InitializeComponent();
        }

        private void ExemplarPesquisarEdicaoView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);
        }
        private void popular(List<EdicaoModel> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Edição", typeof(string));
            if (lista.Count > 0)
            {
                foreach (EdicaoModel edicao in lista)
                {
                    table.Rows.Add(edicao.getId(),
                                   edicao.Nome_Edicao);
                }
                dtGridViewEdicao.DataSource = table;
            }
            int index = dtGridViewEdicao.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewEdicao.Rows[index].Selected = false;
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

            List<EdicaoModel> lista = controller.BuscarEdicao(busca, status: "Ativo");

            if (tbBuscar.Text.Length > 0 && lista.Count > 0)
            {
                lblNotFound.Visible = false;
                popular(lista);
            }
            else if (tbBuscar.Text.Length == 0)
            {
                lblNotFound.Visible = false;
                dtGridViewEdicao.DataSource = null;
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewEdicao.DataSource = null;
            }
        }

        private void dtGridViewEdicao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewEdicao.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                string nome = row.Cells[1].Value.ToString();


                EdicaoModel edicaoSelecionado = new EdicaoModel(id, nome);

                singleton.setEdicaoBusca(edicaoSelecionado);
                this.Close();
            }
        }
    }
}
