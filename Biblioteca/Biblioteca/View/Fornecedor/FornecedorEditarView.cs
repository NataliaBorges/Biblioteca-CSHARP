using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;

namespace Biblioteca.View.Fornecedor {
    public partial class FornecedorEditarView : Form {

        FornecedorModel fornecedor;
        FornecedorController controller = new FornecedorController();

        public FornecedorEditarView(FornecedorModel fornecedor) {
            this.fornecedor = fornecedor;
            InitializeComponent();
        }

        private void FornecedorEditarView_Load(object sender, EventArgs e) {
            if (fornecedor != null) {
                tbNome.Text = fornecedor.Nome;

                try {
                    //rua, numero, bairro - cidade
                    string[] cidade = fornecedor.Endereco.Split('-');
                    string[] endereco = cidade[0].Split(',');

                    tbRua.Text = $"{endereco[0]}";
                    tbNumero.Text = $"{endereco[1]}";
                    tbBairro.Text = $"{endereco[2]}";
                    tbCidade.Text = $"{cidade[1]}";
                }
                catch (Exception) { }
                tbTelefone.Text = fornecedor.Telefone;
                tbCNPJ.Text = fornecedor.CNPJ;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            String nome = tbNome.Text;
            String endereco = $"{tbRua.Text}, {tbNumero.Text}, {tbBairro.Text} - {tbCidade.Text}";
            String telefone = tbTelefone.Text;
            String cnpj = tbCNPJ.Text;

            FornecedorModel fornecedor = new FornecedorModel(this.fornecedor.getId(), nome, endereco, telefone, cnpj);
            if (controller.Atualizar(fornecedor)) {
                MessageBox.Show("Atualizado com sucesso", "Parabéns", MessageBoxButtons.OK);
            }
            else {
                MessageBox.Show("Não foi possível atualizar.", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                if (controller.Excluir(fornecedor)) {
                    MessageBox.Show("Excluído com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                else {
                    MessageBox.Show("Não foi possível excluir", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
