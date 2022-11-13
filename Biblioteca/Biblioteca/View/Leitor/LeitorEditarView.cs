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
        LeitorController leitorController = new LeitorController();
        DateTime data;

        public LeitorEditarView(LeitorModel leitor) {
            this.leitor = leitor;
            InitializeComponent();
        }
        private void LeitorEditarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            if (leitor != null)
            {
                tbNome.Text = leitor.Nome;

                try
                {
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
                CalendarLeitor.Text = leitor.DataNascimento.ToString("dd/MM/yyyy");
                data = leitor.DataNascimento;
                tbEmail.Text = leitor.Email;
                cbEditarStatus.Text = this.leitor.getEstado();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            String nome = tbNome.Text;
            String endereco = $"{tbRua.Text}, {tbNumero.Text}, {tbBairro.Text} - {tbCidade.Text}";
            String telefone = maskedTextBoxTelefone.Text;
            String cpf = maskedTextCPF.Text;
            String email = tbEmail.Text;
            DateTime data = this.CalendarLeitor.Value.Date;

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
            else if (Validar.ValidarEmail(email) == false) {
                MessageBox.Show("Você precisa digitar um email válido.", "Atenção", MessageBoxButtons.OK);
                tbEmail.Focus();
            }
            else {
                int estado = 0;

                if (cbEditarStatus.Text == "Ativo")
                {
                    estado = 1;
                }
                LeitorModel leitor = new LeitorModel(this.leitor.getId(), nome, data, telefone, cpf, endereco, email, estado);
                if (leitorController.Atualizar(leitor)) {
                    MessageBox.Show("Atualizado com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                else {
                    MessageBox.Show("Não foi possível atualizar.", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                if (leitorController.Excluir(leitor)) {
                    MessageBox.Show("Excluído com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                else {
                    MessageBox.Show("Não foi possível excluir", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
