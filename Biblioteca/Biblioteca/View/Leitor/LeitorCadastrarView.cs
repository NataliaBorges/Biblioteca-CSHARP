using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;

namespace Biblioteca.View.Leitor {
    public partial class LeitorCadastrarView : Form {

        LeitorController controller = new LeitorController();
        DateTime data;

        public LeitorCadastrarView() {
            InitializeComponent();
        }

        private void ClearForm() {
            this.tbNome.Clear();
            this.tbRua.Clear();
            this.tbNumero.Clear();
            this.tbBairro.Clear();
            this.tbCidade.Clear();
            this.tbTelefone.Clear();
            this.maskedTextCPF.Clear();
            this.tbNascimento.Clear();
            this.tbEmail.Clear();
            this.tbSenha.Clear();
        }

        private void button1_Click(object sender, EventArgs e) {
            String nome = tbNome.Text;
            String endereco = $"{tbRua.Text}, {tbNumero.Text}, {tbBairro.Text} - {tbCidade.Text}";
            String telefone = tbTelefone.Text;
            String cpf = maskedTextCPF.Text;
            DateTime data = this.data; //.ToString("yyyy-MM-dd");
            String email = tbEmail.Text;
            String senha = tbSenha.Text;
            LeitorModel leitor = new LeitorModel(nome, data, telefone, cpf, endereco, email, senha);
            if (controller.Insercao(leitor)) {
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

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }
        private void maskedTextBox1_TextChanged(object sender, MaskInputRejectedEventArgs e) {
            //Validar.maskedTextCPF.Text;
        }
    }
}
