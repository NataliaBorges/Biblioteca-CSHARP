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
            String telefone = tbTelefone.Text;
            String cpf = tbCPF.Text;
            String senha = tbSenha.Text;
            String email = tbEmail.Text;
            DateTime data = this.data; //.ToString("yyyy-MM-dd");
            FuncionarioModel funcionario = new FuncionarioModel(this.funcionario.getId(), nome, cpf, data, email, endereco, telefone, senha);
            if (controller.Atualizar(funcionario)) {
                MessageBox.Show("Atualizado com sucesso", "Parabéns", MessageBoxButtons.OK);
            }
            else {
                MessageBox.Show("Não foi possível atualizar.", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void FuncionarioEditarView_Load(object sender, EventArgs e) {
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
                tbCPF.Text = funcionario.CPF;
                tbTelefone.Text = funcionario.Telefone;
                tbNascimento.Text = funcionario.Data_Nascimento.ToString("dd/MM/yyyy");
                data = funcionario.Data_Nascimento;
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
