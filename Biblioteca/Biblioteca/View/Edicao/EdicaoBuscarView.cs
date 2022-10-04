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

namespace Biblioteca.View.Edicao
{
    public partial class EdicaoBuscarView : Form
    {
        EdicaoController controller = new EdicaoController();
        EdicaoModel edicaoSelecionada;
        public EdicaoBuscarView()
        {
            InitializeComponent();
        }

        private void btnCadastrarEdicao_Click(object sender, EventArgs e)
        {
            EdicaoCadastrarView edicaoCadastrarView = new EdicaoCadastrarView();
            NovaJanela.novaJanela(edicaoCadastrarView, Bounds);
        }

        private void EdicaoBuscarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setPanel(pnltotal);
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
        }
        private void TbPesquisar_TextChanged(object sender, EventArgs e)
        {
            String busca = TbPesquisar.Text;

            List<EdicaoModel> lista = controller.BuscarEdicao(busca);

            if (TbPesquisar.Text.Length > 0 && lista.Count > 0)
            {
                lblNotFound.Visible = false;
                popular(lista);
            }
            else if (TbPesquisar.Text.Length == 0)
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

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void dtGridViewEdicao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewEdicao.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                String Edicao = row.Cells[1].Value.ToString();

                this.edicaoSelecionada = new EdicaoModel(id, Edicao);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            tbEdicao.Text = this.edicaoSelecionada.Nome_Edicao;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (controller.Excluir(edicaoSelecionada))
                {
                    MessageBox.Show("Excluído com sucesso", "Parabéns", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir", "Atenção", MessageBoxButtons.OK);
                }
            }
        }
    }
}
