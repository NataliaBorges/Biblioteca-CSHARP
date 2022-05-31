using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View {
    public partial class TelaLoginView : Form {

        FuncionarioController controller = new FuncionarioController();
        Singleton singleton = Singleton.GetInstancia();
        public TelaLoginView() {
            InitializeComponent();
            this.ibtSenhaAberta.Visible = false;
            this.ibtSenha.Visible = true;
        }

        private void btLogar_Click(object sender, EventArgs e) {
            String email = tbEmail.Texts;
            String senha = tbSenha.Texts;

            if (controller.Login(email, senha)) {
                FuncionarioModel funcionarioModel = singleton.getFuncionario();

                MessageBox.Show("Seja bem-vinda " + funcionarioModel.Nome_funcionario, "", MessageBoxButtons.OK);
                PrincipalTelaView principalTelaView = new PrincipalTelaView();

                this.Hide();

                Rectangle bounds = this.Bounds;
                principalTelaView.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
                principalTelaView.StartPosition = FormStartPosition.CenterScreen;
                principalTelaView.ShowDialog();
            }
            else {
                singleton.setFuncionario(null);
                MessageBox.Show("E-mail ou senha incorretos.", "", MessageBoxButtons.OK);
            }
        }
        private void lbCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Application.Exit();
        }

        private void ibtSenha_Click(object sender, EventArgs e) {
            if (tbSenha.PasswordChar == true) {
                tbSenha.PasswordChar = false;
                this.ibtSenhaAberta.Visible = true;
                this.ibtSenha.Visible = false;
            }
        }
        private void ibtSenhaAberta_Click(object sender, EventArgs e) {
            if (tbSenha.PasswordChar == false) {
                tbSenha.PasswordChar = true;
                this.ibtSenha.Visible = true;
                this.ibtSenhaAberta.Visible = false;
            }
        }

        private void IbMinimizar_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IbFechar_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
