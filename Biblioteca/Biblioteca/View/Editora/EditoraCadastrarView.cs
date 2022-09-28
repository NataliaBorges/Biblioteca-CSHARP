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

namespace Biblioteca.View.Fornecedor {
    public partial class EditoraCadastrarView : Form {

        EditoraController controller = new EditoraController();
        public EditoraCadastrarView() {
            //button = false;
            //this.icBtnVoltar = button;
            InitializeComponent();
        }

        private void ClearForm() {
            this.tbNome.Clear();
            this.tbRua.Clear();
            this.tbNumero.Clear();
            this.tbBairro.Clear();
            this.tbCidade.Clear();
            this.maskedTextBoxCNPJ.Clear();
            this.maskedTextBoxTelefone.Clear();
            this.tbEmail.Clear();
        }

        private void button1_Click(object sender, EventArgs e) {
            String nome = tbNome.Text;
            String endereco = $"{tbRua.Text}, {tbNumero.Text}, {tbBairro.Text} - {tbCidade.Text}";
            String telefone = maskedTextBoxTelefone.Text;
            String cnpj = maskedTextBoxCNPJ.Text;
            String Email = tbEmail.Text;
            

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
            else if (tbCidade.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar uma cidade.", "Atenção", MessageBoxButtons.OK);
                tbCidade.Focus();
            }
            else if (Validar.ValidaCNPJ(cnpj) == false){
                MessageBox.Show("Você precisa digitar um CNPJ.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxCNPJ.Focus();
            }
            else if (telefone == "(  )     -") {
                MessageBox.Show("Você precisa digitar um Telefone.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxTelefone.Focus();
            }
            else if (Validar.ValidarEmail(Email) == false) {
                MessageBox.Show("Você precisa digitar um Email.", "Atenção", MessageBoxButtons.OK);
                tbEmail.Focus();
            }
            else {
                EditoraModel editora = new EditoraModel(nome, endereco, telefone, cnpj, Email);
                if (controller.Insercao(editora)) {
                    MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
                    ClearForm();
                }
                else {
                    MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
                }
            } 
        }
        private void EditoraCadastrarView_Load(object sender, EventArgs e)
        {
            //this.icBtnVoltar.Visible = this.btnVoltar;
            this.menuControl1.setPanel(pnltotal);
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLbBuscarEditora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditoraBuscarView editoraBuscarView = new EditoraBuscarView();
            NovaJanela.novaJanela(editoraBuscarView, this.Bounds);
        }
    }
}
