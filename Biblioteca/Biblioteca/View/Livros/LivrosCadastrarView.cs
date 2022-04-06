using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;

namespace Biblioteca.View.Livros {
    public partial class LivrosCadastrarView : Form {

        LivroController controller = new LivroController();
        List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
        DateTime data;

        public LivrosCadastrarView() {
            InitializeComponent();
        }

        private void ClearForm() {
            this.tbNome.Clear();
            this.tbAutor.Clear();
            this.tbEdicao.Clear();
            this.tbAno.Clear();
            this.tbAquisicao.Clear();
            this.cbFornecedor.SelectedIndex = -1;
            this.tbISBN.Clear();
        }

        private void button1_Click(object sender, EventArgs e) {
            int posicao = comboBoxItems.FindIndex(item => item.Text == cbFornecedor.SelectedItem.ToString());
            int IdFornecedor = int.Parse(comboBoxItems[posicao].Value);
            String nome = tbNome.Text;
            String autor = tbAutor.Text;
            String edicao = tbEdicao.Text;
            String ano = tbAno.Text;
            DateTime data = this.data; //.ToString("yyyy-MM-dd");
            String ISBN = tbISBN.Text;
            LivroModel livro = new LivroModel(IdFornecedor, nome, autor, edicao, ano, data, ISBN);
            if (controller.Insercao(livro)) {
                MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
                ClearForm();
            }
            else {
                MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void LivrosCadastrarView_Load(object sender, EventArgs e) {
            List<FornecedorModel> fornecedores = controller.ListarFornecedores();
            if(fornecedores.Count > 0) {
                foreach (FornecedorModel fornecedor in fornecedores) {
                    ComboBoxItem item = new ComboBoxItem(fornecedor.Nome, fornecedor.ID.ToString());
                    cbFornecedor.Items.Add(item);
                    comboBoxItems.Add(item);
                }

                cbFornecedor.ValueMember = "Value";
                cbFornecedor.DisplayMember = "Text";
                cbFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e) {
            tbAquisicao.Text = calendar.SelectionRange.Start.ToString("dd/MM/yyyy");
            int ano = int.Parse(calendar.SelectionRange.Start.ToString("yyyy"));
            int mes = int.Parse(calendar.SelectionRange.Start.ToString("MM"));
            int dia = int.Parse(calendar.SelectionRange.Start.ToString("dd"));
            data = new DateTime(ano, mes, dia);
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e) {
            this.Close();
        }
    }
}
