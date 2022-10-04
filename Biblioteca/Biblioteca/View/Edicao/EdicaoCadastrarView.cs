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

        private void EdicaoCadastrarView_Activated(object sender, EventArgs e)
        {
            List<EdicaoModel> lista = controller.ListarTodos();
            popular(lista);
        }

        private void EdicaoCadastrarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            String nome = tbNome.Text.Substring(0, tbNome.Text.Length);

            List<EdicaoModel> lista = controller.ListarTodos();
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
        }

        private void IcnBtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLbBuscarEdicao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLbCadastrarLivro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LivrosCadastrarView livrosCadastrarView = new LivrosCadastrarView();
            NovaJanela.novaJanela(livrosCadastrarView, this.Bounds);
        }
        private void ClearForm()
        {
            this.tbNome.Clear();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String nome = tbNome.Text;


            if (nome.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                tbNome.Focus();
            }
            else
            {
                EdicaoModel edicao = new EdicaoModel(nome);
                if (controller.Insercao(edicao))
                {
                    MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
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
