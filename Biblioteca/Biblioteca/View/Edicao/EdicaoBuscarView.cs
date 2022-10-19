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
        EdicaoModel edicao;
        public EdicaoBuscarView()
        {
            InitializeComponent();
            tbEdicao.Enabled = false;
        }

        private void btnCadastrarEdicao_Click(object sender, EventArgs e)
        {
            EdicaoCadastrarView edicaoCadastrarView = new EdicaoCadastrarView();
            NovaJanela.novaJanela(edicaoCadastrarView, Bounds);
        }

        private void EdicaoBuscarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            cbStatus.Text = "Ambos";
        }
        private void popular(List<EdicaoModel> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Edição", typeof(string));
            table.Columns.Add("Status", typeof(string));
            if (lista.Count > 0)
            {
                foreach (EdicaoModel edicao in lista)
                {
                    table.Rows.Add(edicao.getId(),
                                   edicao.Nome_Edicao, 
                                   edicao.getEstado());
                }
                dtGridViewEdicao.DataSource = table;
            }
            int index = dtGridViewEdicao.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewEdicao.Rows[index].Selected = false;
            }
        }
        private void TbPesquisar_TextChanged(object sender, EventArgs e)
        {
            tbEdicao.Text = "";
            tbEdicao.Enabled = false;
            this.edicao = null;
            String status = cbStatus.Text;
            String busca = TbPesquisar.Text;

            List<EdicaoModel> lista = controller.BuscarEdicao(busca, status);

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
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (edicao != null)
                {
                    tbEdicao.Enabled = true;
                }
                tbEdicao.Text = this.edicao.Nome_Edicao;
                cbEditarStatus.Text = this.edicao.getEstado();
            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma edição", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string edicaoLivro = tbEdicao.Text;


            if (tbEdicao.Text.Length <= 0 || edicao == null)
            {
                tbEdicao.Enabled = false;
                MessageBox.Show("Você precisa selecionar uma edição", "Atenção", MessageBoxButtons.OK);
                tbEdicao.Focus();
            }
            else
            {
                tbEdicao.Enabled = true;
                int estado = 0;

                if (cbEditarStatus.Text == "Ativo")
                {
                    estado = 1;
                }
                EdicaoModel livroEdicao= new EdicaoModel(edicao.Id, edicaoLivro, estado);
                if (controller.Atualizar(livroEdicao))
                {
                    MessageBox.Show("Atualizado com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void dtGridViewEdicao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewEdicao.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                String Edicao = row.Cells[1].Value.ToString();
                int estado = 0;

                if (row.Cells[2].Value.ToString() == "Ativo")
                {
                    estado = 1;
                }

                this.edicao = new EdicaoModel(id, Edicao, estado);
            }
        }

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            TbPesquisar.Text = null;
            dtGridViewEdicao.DataSource = null;
        }
    }
}
