using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;
using Biblioteca.View.Livros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Edicao
{
    public partial class EdicaoCadastrarView : Form
    {
        EdicaoController controller = new EdicaoController();
        public EdicaoCadastrarView()
        {
            InitializeComponent();
        }

        private void EdicaoCadastrarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            String nome = tbEdicao.Text.Substring(0, tbEdicao.Text.Length);

            List<EdicaoModel> lista = controller.ListarUltimosDez();
            popular(lista);
        }

        private void popular(List<EdicaoModel> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Edição", typeof(string));
            dtGridViewEdicao.DataSource = lista;
            if (lista.Count > 0)
            {
                foreach (EdicaoModel edicao in lista)
                {

                    table.Rows.Add(edicao.getId(), edicao.Nome_Edicao);

                }
                dtGridViewEdicao.DataSource = table;
            }
            int index = dtGridViewEdicao.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewEdicao.Rows[index].Selected = false;
            }
        }

        private void IcnBtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void ClearForm()
        {
            this.tbEdicao.Clear();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String nome = tbEdicao.Text;

            if (nome.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                tbEdicao.Focus();
            }
            else
            {
                EdicaoModel edicao = new EdicaoModel(nome);
                if (controller.Insercao(edicao))
                {
                    List<EdicaoModel> lista = controller.ListarUltimosDez();
                    popular(lista);

                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
                }
            }
        }
    }
}
