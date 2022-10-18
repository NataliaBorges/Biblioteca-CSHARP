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

namespace Biblioteca.View.Editora {
    public partial class EditoraEditarView : Form {

        EditoraModel editora;
        EditoraController controller = new EditoraController();

        public EditoraEditarView(EditoraModel editora) {
            this.editora = editora;
            InitializeComponent();
        }

        private void EditoraEditarView_Load(object sender, EventArgs e) {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            if (editora != null) {
                tbNome.Text = editora.Nome;

                try {
                    //rua, numero, bairro - cidade
                    string[] cidade = editora.Endereco.Split('-');
                    string[] endereco = cidade[0].Split(',');

                    tbRua.Text = $"{endereco[0]}";
                    tbNumero.Text = $"{endereco[1]}";
                    tbBairro.Text = $"{endereco[2]}";
                    tbCidade.Text = $"{cidade[1]}";
                }
                catch (Exception) { }
                maskedTextBoxTelefone.Text = editora.Telefone;
                maskedTextBoxCNPJ.Text = editora.CNPJ;
                tbEmail.Text = editora.Email;
                cbEditarStatus.Text = this.editora.getEstado();
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            String nome = tbNome.Text;
            String endereco = $"{tbRua.Text},{tbNumero.Text},{tbBairro.Text}-{tbCidade.Text}";
            String telefone = maskedTextBoxTelefone.Text;
            String cnpj = maskedTextBoxCNPJ.Text;
            String email = tbEmail.Text;

            if (nome.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                tbNome.Focus();
            }
            else if (tbRua.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar uma rua.", "Atenção", MessageBoxButtons.OK);
                tbRua.Focus();
            }
            else if (tbNumero.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um numero.", "Atenção", MessageBoxButtons.OK);
                tbNumero.Focus();
            }
            else if (tbBairro.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um bairro.", "Atenção", MessageBoxButtons.OK);
                tbBairro.Focus();
            }
            else if (Validar.ValidaCNPJ(cnpj) == false)
            {
                MessageBox.Show("Você precisa digitar um CNPJ.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxCNPJ.Focus();
            }
            else if (tbCidade.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar uma cidade.", "Atenção", MessageBoxButtons.OK);
                tbCidade.Focus();
            }
            else if (telefone == "(  )     -")
            {
                MessageBox.Show("Você precisa digitar um Telefone.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxTelefone.Focus();
            }
            else if (Validar.ValidarEmail(email) == false)
            {
                MessageBox.Show("Você precisa digitar um Email.", "Atenção", MessageBoxButtons.OK);
                tbEmail.Focus();
            }
            else
            {
                int estado = 0;

                if (cbEditarStatus.Text == "Ativo")
                {
                    estado = 1;
                }
                EditoraModel editora = new EditoraModel(this.editora.getId(), nome, endereco, telefone, cnpj, email, estado);
                if (controller.Atualizar(editora))
                {
                    MessageBox.Show("Atualizado com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar.", "Atenção", MessageBoxButtons.OK);
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
