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

namespace Biblioteca.View.Leitor {
    public partial class LeitorEditarView : Form {

        LeitorModel leitor;
        LeitorController controller = new LeitorController();
        DateTime data;

        public LeitorEditarView(LeitorModel leitor) {
            this.leitor = leitor;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            String nome = tbNome.Text;
            String endereco = $"{tbRua.Text}, {tbNumero.Text}, {tbBairro.Text} - {tbCidade.Text}";
            String telefone = maskedTextBoxTelefone.Text;
            String cpf = maskedTextCPF.Text;
            String email = tbEmail.Text;
            String senha = tbSenha.Text;
            DateTime data = this.data; //.ToString("yyyy-MM-dd");

            if (nome.Length <= 0) {
                MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                tbNome.Focus();
            }
            else if (tbRua.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar uma rua.", "Atenção", MessageBoxButtons.OK);
                tbRua.Focus();
            }
            else if (tbNumero.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar um numero.", "Atenção", MessageBoxButtons.OK);
                tbNumero.Focus();
            }
            else if (tbBairro.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar um bairro.", "Atenção", MessageBoxButtons.OK);
                tbBairro.Focus();
            }
            else if (telefone == "(  )     -") {
                MessageBox.Show("Você precisa digitar um telefone.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxTelefone.Focus();
            }
            else if (tbCidade.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar uma cidade.", "Atenção", MessageBoxButtons.OK);
                tbCidade.Focus();
            }
            else if (Validar.ValidaCpf(cpf) == false) {
                MessageBox.Show("Você precisa digitar um CPF válido.", "Atenção", MessageBoxButtons.OK);
                maskedTextCPF.Focus();
            }
            else if (maskedTextBoxNascimento.Text == "  /  /") {
                MessageBox.Show("Você precisa selecionar uma data.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxNascimento.Focus();
            }
            else if (Validar.ValidarEmail(email) == false) {
                MessageBox.Show("Você precisa digitar um email válido.", "Atenção", MessageBoxButtons.OK);
                tbEmail.Focus();
            }
            else {
                LeitorModel leitor = new LeitorModel(this.leitor.getId(), nome, data, telefone, cpf, endereco, email, senha);
                if (controller.Atualizar(leitor)) {
                    MessageBox.Show("Atualizado com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                else {
                    MessageBox.Show("Não foi possível atualizar.", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void LeitorEditarView_Load(object sender, EventArgs e) {
            if (leitor != null) {
                tbNome.Text = leitor.Nome;

                try {
                    //rua, numero, bairro - cidade
                    string[] cidade = leitor.Endereco.Split('-');
                    string[] endereco = cidade[0].Split(',');

                    tbRua.Text = $"{endereco[0]}";
                    tbNumero.Text = $"{endereco[1]}";
                    tbBairro.Text = $"{endereco[2]}";
                    tbCidade.Text = $"{cidade[1]}";
                }
                catch (Exception) { }

                maskedTextCPF.Text = leitor.CPF;
                maskedTextBoxTelefone.Text = leitor.Telefone;
                maskedTextBoxNascimento.Text = leitor.DataNascimento.ToString("dd/MM/yyyy");
                data = leitor.DataNascimento;
                tbEmail.Text = leitor.Email;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                if (controller.Excluir(leitor)) {
                    MessageBox.Show("Excluído com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                else {
                    MessageBox.Show("Não foi possível excluir", "Atenção", MessageBoxButtons.OK);
                }
            }
        }
        private void calendar_DateChanged_1(object sender, DateRangeEventArgs e) {
            maskedTextBoxNascimento.Text = calendar.SelectionRange.Start.ToString("dd/MM/yyyy");
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
