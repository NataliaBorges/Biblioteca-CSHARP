using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;

namespace Biblioteca.View.Funcionario {
    public partial class FuncionarioCadastrarView : Form {

        FuncionarioController controller = new FuncionarioController();
        DateTime data;

        public FuncionarioCadastrarView() {
            InitializeComponent();
        }

        private void ClearForm() {
            this.tbNome.Clear();
            this.tbRua.Clear();
            this.tbNumero.Clear();
            this.tbBairro.Clear();
            this.tbCidade.Clear();
            this.tbTelefone.Clear();
            this.tbCPF.Clear();
            this.tbNascimento.Clear();
            this.tbSenha.Clear();
            this.tbEmail.Clear();
        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void FuncionarioCadastrarView_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            String nome = tbNome.Text;
            String endereco = $"{tbRua.Text}, {tbNumero.Text}, {tbBairro.Text} - {tbCidade.Text}";
            String telefone = tbTelefone.Text;
            String cpf = tbCPF.Text;
            String senha = tbSenha.Text;
            String email = tbEmail.Text;
            DateTime data = this.data; //.ToString("yyyy-MM-dd");
            FuncionarioModel funcionario = new FuncionarioModel(nome, cpf, data, email, endereco, telefone, senha);
            if (controller.Insercao(funcionario)) {
                MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
                ClearForm();
            }
            else {
                MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e) {
            tbNascimento.Text = calendar.SelectionRange.Start.ToString("dd/MM/yyyy");
            int ano = int.Parse(calendar.SelectionRange.Start.ToString("yyyy"));
            int mes = int.Parse(calendar.SelectionRange.Start.ToString("MM"));
            int dia = int.Parse(calendar.SelectionRange.Start.ToString("dd"));
            data = new DateTime(ano, mes, dia);
        }
    }
}
