using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.View.Funcionario;

namespace Biblioteca.View.Funcionario {
    public partial class FuncionarioPrincipalView : Form {

        FuncionarioController controller = new FuncionarioController();

        public FuncionarioPrincipalView() {
            InitializeComponent();
        }

        private void popular(List<FuncionarioModel> lista) {
            Lvfuncionario.Items.Clear();
            if (lista.Count > 0) {
                foreach (FuncionarioModel funcionario in lista) {
                    ListViewItem item = new ListViewItem(funcionario.getId().ToString());
                    item.SubItems.Add(funcionario.Nome_funcionario);
                    item.SubItems.Add(funcionario.Data_Nascimento.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(funcionario.Telefone);
                    item.SubItems.Add(funcionario.CPF);
                    item.SubItems.Add(funcionario.Endereco);
                    item.SubItems.Add(funcionario.Email);

                    Lvfuncionario.Items.Add(item);
                }
            }
        }

        private void funcionarioPrincipalView_Load(object sender, EventArgs e) {
            List<FuncionarioModel> lista = controller.ListarTodos();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            List<FuncionarioModel> lista = controller.ListarTodos();
            popular(lista);
        }

        private void novaJanela(Form form) {
            Rectangle bounds = this.Bounds;
            form.SetBounds(bounds.X, bounds.Y, form.Bounds.Width, form.Bounds.Height);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            FuncionarioBuscarView buscar = new FuncionarioBuscarView();
            novaJanela(buscar);
        }

        private void button2_Click(object sender, EventArgs e) {
            FuncionarioCadastrarView cadastrar = new FuncionarioCadastrarView();
            novaJanela(cadastrar);
        }
    }
}
