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
    public partial class FornecedorCadastrarView : Form {

        FornecedorController controller = new FornecedorController();
        public FornecedorCadastrarView() {
            InitializeComponent();
        }

        private void ClearForm() {
            this.tbNome.Clear();
            this.tbRua.Clear();
            this.tbNumero.Clear();
            this.tbBairro.Clear();
            this.tbCidade.Clear();
            this.tbTelefone.Clear();
            this.tbCNPJ.Clear();
        }

        private void FornecedorCadastrarView_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            String nome = tbNome.Text;
            String endereco = $"{tbRua.Text}, {tbNumero.Text}, {tbBairro.Text} - {tbCidade.Text}";
            String telefone = tbTelefone.Text;
            String cnpj = tbCNPJ.Text;
            FornecedorModel fornecedor = new FornecedorModel(nome, endereco, telefone, cnpj);
            if (controller.Insercao(fornecedor)) {
                MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
                ClearForm();
            }
            else {
                MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
