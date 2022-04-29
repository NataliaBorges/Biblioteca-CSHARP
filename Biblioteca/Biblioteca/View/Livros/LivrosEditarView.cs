using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Model;
using Biblioteca.Controller;
using Biblioteca.Util;

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

            List<EditoraModel> fornecedores = controller.ListarFornecedores();
            if (fornecedores.Count > 0) {
                foreach (EditoraModel fornecedor in fornecedores) {
                    ComboBoxItem item = new ComboBoxItem(fornecedor.Nome, fornecedor.ID.ToString());
                    cbEditora.Items.Add(item);
                    comboBoxItems.Add(item);
                }

                cbEditora.ValueMember = "Value";
                cbEditora.DisplayMember = "Text";
                cbEditora.DropDownStyle = ComboBoxStyle.DropDownList;
            }

            if (livro != null) {
                tbNome.Text = livro.Nome;
                tbAutor.Text = livro.Autor;
                maskedTextBoxAno.Text = livro.AnoPublicacao;
                cbEditora.SelectedIndex = comboBoxItems.FindIndex(item => item.Text == livro.Fornecedor);
                tbEdicao.Text = livro.Edicao;
                maskedTextBoxAquisição.Text = livro.DataAquisicao.ToString();
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
            if (cbEditora.SelectedItem == null) {
                MessageBox.Show("Você selecionar uma editora.", "Atenção", MessageBoxButtons.OK);
                cbEditora.Focus();
            }
            else {
                int posicao = comboBoxItems.FindIndex(item => item.Text == cbEditora.SelectedItem.ToString());
                int IdFornecedor = int.Parse(comboBoxItems[posicao].Value);
                String nome = tbNome.Text;
                String autor = tbAutor.Text;
                String edicao = tbEdicao.Text;
                String ano = maskedTextBoxAno.Text;
                DateTime data = this.data; //.ToString("yyyy-MM-dd");
                String ISBN = tbISBN.Text;

                if (nome.Length <= 0) {
                    MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                    tbNome.Focus();
                }
                else if (cbEditora == null) {
                    MessageBox.Show("Você selecionar uma editora.", "Atenção", MessageBoxButtons.OK);
                    cbEditora.Focus();
                }
                else if (autor.Length <= 0) {
                    MessageBox.Show("Você precisa digitar um Autor.", "Atenção", MessageBoxButtons.OK);
                    tbAutor.Focus();
                }
                else if (edicao.Length <= 0) {
                    MessageBox.Show("Você precisa digitar uma Edição.", "Atenção", MessageBoxButtons.OK);
                    tbEdicao.Focus();
                }
                else if (ano == "") {
                    MessageBox.Show("Você precisa digitar um ano.", "Atenção", MessageBoxButtons.OK);
                    maskedTextBoxAno.Focus();
                }
                else if (maskedTextBoxAquisição.Text == "  /  /") {
                    MessageBox.Show("Você precisa digitar uma data de aquisição.", "Atenção", MessageBoxButtons.OK);
                    maskedTextBoxAquisição.Focus();
                }
                else if (tbISBN.Text.Length < 13) {
                    MessageBox.Show("Você precisa digitar um ISBN Válido.", "Atenção", MessageBoxButtons.OK);
                }
                //else if (Validar.ValidaISBN13(ISBN)) {
                //    MessageBox.Show("Você precisa digitar um ISBN Válido.", "Atenção", MessageBoxButtons.OK);
                //    tbISBN.Focus();
                //}
                else {
                    LivroModel livro = new LivroModel(this.livro.getId(),IdFornecedor, nome, autor, edicao, ano, data, ISBN);
                    if (controller.Atualizar(livro)) {
                        MessageBox.Show("Atualizado com sucesso", "Parabéns", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Não foi possível atualizar.", "Atenção", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void calendar_DateChanged_1(object sender, DateRangeEventArgs e) {
            maskedTextBoxAquisição.Text = calendar.SelectionRange.Start.ToString("dd/MM/yyyy");
            int ano = int.Parse(calendar.SelectionRange.Start.ToString("yyyy"));
            int mes = int.Parse(calendar.SelectionRange.Start.ToString("MM"));
            int dia = int.Parse(calendar.SelectionRange.Start.ToString("dd"));
            data = new DateTime(ano, mes, dia);
        }
    }
}
