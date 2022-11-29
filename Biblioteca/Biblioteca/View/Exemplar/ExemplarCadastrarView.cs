using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Exemplar
{
    public partial class ExemplarCadastrarView : Form
    {
        LivroModel livro;
        Singleton singleton = Singleton.GetInstancia();
        ExemplarController controller = new ExemplarController();
        public ExemplarCadastrarView(LivroModel livro)
        {
            this.livro = livro;
            InitializeComponent();
        }

        private void ExemplarCadastrarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            if (livro != null)
            {
                tbNome.Text = this.livro.Titulo;
                tbAutor.Text = this.livro.NomeAutor;
                tbEditora.Text = this.livro.NomeEditora;
                tbGenero.Text = this.livro.NomeGenero;
            }
        }

        private void btnPesquisarEdicao_Click(object sender, EventArgs e)
        {
            singleton.setBuscarEdicao(true);
            ExemplarPesquisarEdicaoView exemplarPesquisarEdicaoView = new ExemplarPesquisarEdicaoView();
            NovaJanela.novaJanela(exemplarPesquisarEdicaoView, Bounds);
        }

        private void ExemplarCadastrarView_Activated(object sender, EventArgs e)
        {
            if (singleton.getBuscarEdicao() && singleton.getEdicaoBusca() != null)
            {
                singleton.setBuscarEdicao(false);
                tbEdicao.Text = singleton.getEdicaoBusca().Nome_Edicao;
            }
        }
        private void ClearForm()
        {
            this.tbValor.Clear();
            this.maskedTextBoxAno.Clear();
            this.tbQuantidade.Clear();
            this.tbISBN.Clear();
            this.tbEdicao.Clear();
            singleton.setEdicaoBusca(null);
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string valor = tbValor.Text;
            string ano = maskedTextBoxAno.Text;
            string quantidade = tbQuantidade.Text;
            string isbn = tbISBN.Text;
            DateTime aquisicao = this.CalendarExemplar.Value.Date;
            int edicao = 0;

            
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
            else if ((new DateTime(int.Parse(ano), DateTime.Now.Month, DateTime.Now.Day)).Year > DateTime.Now.Year)
            {
                MessageBox.Show("O ano não pode ser maior que o ano atual.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxAno.Focus();
            }
            else if (aquisicao > DateTime.Now)
            {
                MessageBox.Show("Data de aquisição não pode ser maior que hoje.", "Atenção", MessageBoxButtons.OK);
            }
            else if(quantidade == null || quantidade == "")
            {
                MessageBox.Show("Você precisa digitar uma quantidade.", "Atenção", MessageBoxButtons.OK);
            }
            else if (int.Parse(quantidade) <= 0)
            {
                MessageBox.Show("Quantidade precisa ser maior que 0.", "Atenção", MessageBoxButtons.OK);
            }
            else if (tbQuantidade.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar uma quantidade.", "Atenção", MessageBoxButtons.OK);
                tbQuantidade.Focus();
            }
            else if (tbISBN.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um ISBN.", "Atenção", MessageBoxButtons.OK);
                tbISBN.Focus();
            }
            else
            {
                edicao = singleton.getEdicaoBusca().Id;

                DialogResult dialogResult = MessageBox.Show("Você realmente deseja cadastrar "+quantidade+" exemplare(s)?", "Atenção", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ExemplarModel exemplar = new ExemplarModel(livro.getId(), edicao, ano, isbn, aquisicao, float.Parse(valor), int.Parse(quantidade));
                    try
                    {
                        controller.Insercao(exemplar);
                        MessageBox.Show("Cadastrado com Sucesso!", "Parabéns", MessageBoxButtons.OK);
                        ClearForm();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
                    }
                }
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
    }
}
