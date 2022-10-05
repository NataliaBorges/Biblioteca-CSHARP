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
            int index = dtGridViewEdicao.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewEdicao.Rows[index].Selected = false;
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
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                tbEdicao.Text = this.edicao.Nome_Edicao;
            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma Edição", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbEdicao.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa selecionar uma edição.", "Atenção", MessageBoxButtons.OK);
                tbEdicao.Focus();
            }
            else { 
                this.tbEdicao.Text = this.edicao.Nome_Edicao;
                DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (controller.Excluir(edicao))
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string edicaoLivro = tbEdicao.Text;


            if (tbEdicao.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa selecionar uma edição.", "Atenção", MessageBoxButtons.OK);
                tbEdicao.Focus();
            }
            else
            {
                EdicaoModel livroEdicao= new EdicaoModel(edicao.Id, edicaoLivro);
                if (controller.Atualizar(livroEdicao))
                {
                    MessageBox.Show("Atualizado com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar.", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void dtGridViewEdicao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewEdicao.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                String Edicao = row.Cells[1].Value.ToString();

                this.edicao = new EdicaoModel(id, Edicao);
                //if (id != null && Edicao != null)
                //{
                //    this.edicaoSelecionada = new EdicaoModel(id, Edicao);
                //}
            }
        }
    }
}
