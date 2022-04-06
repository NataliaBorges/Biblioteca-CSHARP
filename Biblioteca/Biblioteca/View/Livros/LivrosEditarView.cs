using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Model;
using Biblioteca.Controller;

namespace Biblioteca.View.Livros {
    public partial class LivrosEditarView : Form {
        LivroModel livro;
        LivroController controller = new LivroController();
        List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
        DateTime data;
        public LivrosEditarView(LivroModel livro) {
            this.livro = livro;
            InitializeComponent();
        }

        private void LivrosItemView_Load(object sender, EventArgs e) {

            List<FornecedorModel> fornecedores = controller.ListarFornecedores();
            if (fornecedores.Count > 0) {
                foreach (FornecedorModel fornecedor in fornecedores) {
                    ComboBoxItem item = new ComboBoxItem(fornecedor.Nome, fornecedor.ID.ToString());
                    cbFornecedor.Items.Add(item);
                    comboBoxItems.Add(item);
                }

                cbFornecedor.ValueMember = "Value";
                cbFornecedor.DisplayMember = "Text";
                cbFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            }

            if (livro != null) {
                tbNome.Text = livro.Nome;
                tbAutor.Text = livro.Autor;
                tbAno.Text = livro.AnoPublicacao;
                cbFornecedor.SelectedIndex = comboBoxItems.FindIndex(item => item.Text == livro.Fornecedor);
                tbEdicao.Text = livro.Edicao;
                tbAquisicao.Text = livro.DataAquisicao.ToString();
                data = livro.DataAquisicao;
                tbISBN.Text = livro.ISBN;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                if (controller.Excluir(livro)) {
                    MessageBox.Show("Excluído com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                } else {
                    MessageBox.Show("Não foi possível excluir", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            int posicao = comboBoxItems.FindIndex(item => item.Text == cbFornecedor.SelectedItem.ToString());
            int IdFornecedor = int.Parse(comboBoxItems[posicao].Value);
            String nome = tbNome.Text;
            String autor = tbAutor.Text;
            String edicao = tbEdicao.Text;
            String ano = tbAno.Text;
            String ISBN = tbISBN.Text;
            DateTime data = this.data; //.ToString("yyyy-MM-dd");
            LivroModel livro = new LivroModel(this.livro.getId(), IdFornecedor, nome, autor, edicao, ano, data , ISBN);
            if (controller.Atualizar(livro)) {
                MessageBox.Show("Atualizado com sucesso", "Parabéns", MessageBoxButtons.OK);
            }
            else {
                MessageBox.Show("Não foi possível atualizar.", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e) {
            tbAquisicao.Text = calendar.SelectionRange.Start.ToString("dd/MM/yyyy");
            int ano = int.Parse(calendar.SelectionRange.Start.ToString("yyyy"));
            int mes = int.Parse(calendar.SelectionRange.Start.ToString("MM"));
            int dia = int.Parse(calendar.SelectionRange.Start.ToString("dd"));
            data = new DateTime(ano, mes, dia);
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
