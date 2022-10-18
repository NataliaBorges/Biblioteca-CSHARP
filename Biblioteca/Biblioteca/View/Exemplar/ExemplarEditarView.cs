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
    public partial class ExemplarEditarView : Form
    {
        ExemplarModel exemplar;
        ExemplarController controller = new ExemplarController();
        Singleton singleton = Singleton.GetInstancia();
        public ExemplarEditarView(ExemplarModel exemplar)
        {

            this.exemplar = exemplar;

            InitializeComponent();
        }

        private void ExemplarEditarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            if (exemplar != null)
            {
                tbValor.Text = this.exemplar.Valor.ToString();
                maskedTextBoxAno.Text = this.exemplar.AnoPublicacao;
                tbISBN.Text = this.exemplar.ISBN;
                tbEdicao.Text = this.exemplar.Nome_Edicao;
                cbEditarStatus.Text = exemplar.getEstado();
                tbNome.Text = this.exemplar.Titulo;
                tbAutor.Text = this.exemplar.Nome_Autor;
                tbEditora.Text = this.exemplar.Nome_Editora;
                tbGenero.Text = this.exemplar.Nome_Genero;

            }

        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair sem Salvar?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string valor = tbValor.Text;
            string ano = maskedTextBoxAno.Text;
            string isbn = tbISBN.Text;
            DateTime aquisicao = this.CalendarExemplar.Value.Date;

            if (tbValor.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um valor.", "Atenção", MessageBoxButtons.OK);
                tbValor.Focus();
            }
            else if (singleton.getEdicaoBusca() == null)
            {
                MessageBox.Show("Você precisa selecionar uma edição válida.", "Atenção", MessageBoxButtons.OK);
                tbEdicao.Focus();
            }
            else if (maskedTextBoxAno.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um ano.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxAno.Focus();
            }
            else if (tbISBN.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um ISBN.", "Atenção", MessageBoxButtons.OK);
                tbISBN.Focus();
            }
            else
            {

                //int edicao = this.exemplar.IdEdicao;
                //if (singleton.getEdicaoBusca() != null)
                //{
                //    edicao = singleton.getEdicaoBusca().Id;
                //}

                //int estado = 0;

                //if (cbEditarStatus.Text == "Ativo")
                //{
                //    estado = 1;
                //}

                //ExemplarModel exemplar = new ExemplarModel();
                //try
                //{
                //    controller.Insercao(exemplar);
                //    MessageBox.Show("Atualizado com Sucesso!", "Parabéns", MessageBoxButtons.OK);
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
                //}

                MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
            }
        }
    }
}
