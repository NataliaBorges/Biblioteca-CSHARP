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
            this.exemplar = controller.BuscarExemplarId(exemplar.getId());
            InitializeComponent();
        }
        private void ExemplarEditarView_Activated(object sender, EventArgs e)
        {
            if (singleton.getBuscarEdicao() && singleton.getEdicaoBusca() != null)
            {
                singleton.setBuscarEdicao(false);
                tbEdicao.Text = singleton.getEdicaoBusca().Nome_Edicao;
            }
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
                CalendarExemplar.Text = exemplar.Aquisicao.ToString("dd/MM/yyyy");

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
            float valor = float.Parse(tbValor.Text);
            string ano = maskedTextBoxAno.Text;
            string isbn = tbISBN.Text;
            DateTime aquisicao = this.CalendarExemplar.Value.Date;

            if (tbValor.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um valor.", "Atenção", MessageBoxButtons.OK);
                tbValor.Focus();
            }
            else if (tbEdicao.Text.Length <= 0)
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

                int edicao = this.exemplar.IdEdicao;
                if (singleton.getEdicaoBusca() != null)
                {
                    edicao = singleton.getEdicaoBusca().Id;
                }

                int estado = 0;

                if (cbEditarStatus.Text == "Ativo")
                {
                    estado = 1;
                }

                ExemplarModel exemplar = new ExemplarModel(this.exemplar.getId(),  aquisicao,  ano,  isbn,  edicao,  valor, estado);
                try
                {
                    controller.Atualizar(exemplar);
                    MessageBox.Show("Atualizado com Sucesso!", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void icBtnSelecionarEdicao_Click(object sender, EventArgs e)
        {
            singleton.setBuscarEdicao(true);
            ExemplarPesquisarEdicaoView exemplarPesquisarEdicaoView = new ExemplarPesquisarEdicaoView();
            NovaJanela.novaJanela(exemplarPesquisarEdicaoView, Bounds);
        }

        
    }
}
