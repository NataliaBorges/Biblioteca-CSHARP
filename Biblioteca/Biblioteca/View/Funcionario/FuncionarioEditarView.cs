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

namespace Biblioteca.View.Funcionario {
    public partial class FuncionarioEditarView : Form {

        FuncionarioModel funcionario;
        FuncionarioController controller = new FuncionarioController();
        DateTime data;
        public FuncionarioEditarView(FuncionarioModel funcionario) {
            this.funcionario = funcionario;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            String nome = tbNome.Text;
            String endereco = $"{tbRua.Text}, {tbNumero.Text}, {tbBairro.Text} - {tbCidade.Text}";
            String telefone = maskedTextBoxTelefone.Text;
            String cpf = maskedTextBoxCPF.Text;
            String senha = tbSenha.Text;
            String email = tbEmail.Text;
            DateTime data = this.data; //.ToString("yyyy-MM-dd");
            String funcao = this.comboBox1.Text;

            if (nome.Length <= 0) {
                MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                tbNome.Focus();
            }
            else if (tbRua.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar uma Rua.", "Atenção", MessageBoxButtons.OK);
                tbRua.Focus();
            }
            else if (tbNumero.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar um número.", "Atenção", MessageBoxButtons.OK);
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
                MessageBox.Show("Você precisa digitar uma CPF.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxCPF.Focus();
            }
            else if (Validar.ValidarEmail(email) == false) {
                MessageBox.Show("Você precisa digitar um email.", "Atenção", MessageBoxButtons.OK);
                tbEmail.Focus();
            }
            else if (tbSenha.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar uma senha.", "Atenção", MessageBoxButtons.OK);
                tbSenha.Focus();
            }
            else if (maskedTextBoxNascimento.Text == "  /  /") {
                MessageBox.Show("Você precisa digitar uma data de Nascimento.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxNascimento.Focus();
            }
            //else {
            //    FuncionarioModel funcionario = new FuncionarioModel(this.funcionario.getId(), nome, cpf, data, email, endereco, telefone, funcao);
            //    if (controller.Atualizar(funcionario)) {
            //        MessageBox.Show("Atualizado com sucesso", "Parabéns", MessageBoxButtons.OK);
            //        this.Close();
            //    }
            //    else {
            //        MessageBox.Show("Não foi possível atualizar.", "Atenção", MessageBoxButtons.OK);
            //    }
            //}

        }

        private void FuncionarioEditarView_Load(object sender, EventArgs e) {
            this.menuControl1.setPanel(pnltotal);
            if (funcionario != null) {
                tbNome.Text = funcionario.Nome_funcionario;

                try {
                    //rua, numero, bairro - cidade
                    string[] cidade = funcionario.Endereco.Split('-');
                    string[] endereco = cidade[0].Split(',');

                    tbRua.Text = $"{endereco[0]}";
                    tbNumero.Text = $"{endereco[1]}";
                    tbBairro.Text = $"{endereco[2]}";
                    tbCidade.Text = $"{cidade[1]}";
                }
                catch (Exception) { }

                tbEmail.Text = funcionario.Email;
                maskedTextBoxCPF.Text = funcionario.CPF;
                maskedTextBoxTelefone.Text = funcionario.Telefone;
                maskedTextBoxNascimento.Text = funcionario.Data_Nascimento.ToString("dd/MM/yyyy");
                data = funcionario.Data_Nascimento;
            }
        }
        private void Calendar_DateChanged_1(object sender, DateRangeEventArgs e) {
            maskedTextBoxNascimento.Text = Calendar.SelectionRange.Start.ToString("dd/MM/yyyy");
            int ano = int.Parse(Calendar.SelectionRange.Start.ToString("yyyy"));
            int mes = int.Parse(Calendar.SelectionRange.Start.ToString("MM"));
            int dia = int.Parse(Calendar.SelectionRange.Start.ToString("dd"));
            data = new DateTime(ano, mes, dia);
        }


        private void button2_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                if (controller.Excluir(funcionario)) {
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
