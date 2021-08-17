using Biblioteca.Controller;
using System;
using System.Windows.Forms;
using Biblioteca.Util;
using Biblioteca.Model;
using Biblioteca.View;
using System.Drawing;

namespace Biblioteca {
    public partial class LoginView : Form {

        FuncionarioController controller = new FuncionarioController();
        Singleton singleton = Singleton.GetInstancia();

        public LoginView() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            String email = TextEmail.Text;
            String senha = TextSenha.Text;

            if(controller.Login(email, senha)) {
                FuncionarioModel funcionarioModel = singleton.getFuncionario();
                MessageBox.Show("Seja bem-vindo "+ funcionarioModel.Nome_funcionario, "", MessageBoxButtons.OK);
                PrincipalView principalView = new PrincipalView();
                this.Hide();
                Rectangle bounds = this.Bounds;
                principalView.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
                principalView.StartPosition = FormStartPosition.CenterScreen;
                principalView.ShowDialog();
            } else {
                singleton.setFuncionario(null);
                MessageBox.Show("E-mail ou senha incorretos.", "", MessageBoxButtons.OK);
            }

        }
    }
}
