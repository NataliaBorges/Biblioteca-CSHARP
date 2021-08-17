using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Model;
using Biblioteca.Controller;

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
            String telefone = tbTelefone.Text;
            String cpf = tbCPF.Text;
            DateTime data = this.data; //.ToString("yyyy-MM-dd");
            LeitorModel leitor = new LeitorModel(this.leitor.getId(), nome, data, telefone, cpf, endereco);
            if (controller.Atualizar(leitor)) {
                MessageBox.Show("Atualizado com sucesso", "Parabéns", MessageBoxButtons.OK);
            }
            else {
                MessageBox.Show("Não foi possível atualizar.", "Atenção", MessageBoxButtons.OK);
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
                }catch (Exception) { }

                tbCPF.Text = leitor.CPF;
                tbTelefone.Text = leitor.Telefone;
                tbNascimento.Text = leitor.DataNascimento.ToString("dd/MM/yyyy");
                data = leitor.DataNascimento;
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

        private void calendar_DateChanged(object sender, DateRangeEventArgs e) {
            tbNascimento.Text = calendar.SelectionRange.Start.ToString("dd/MM/yyyy");
            int ano = int.Parse(calendar.SelectionRange.Start.ToString("yyyy"));
            int mes = int.Parse(calendar.SelectionRange.Start.ToString("MM"));
            int dia = int.Parse(calendar.SelectionRange.Start.ToString("dd"));
            data = new DateTime(ano, mes, dia);
        }
    }
}
