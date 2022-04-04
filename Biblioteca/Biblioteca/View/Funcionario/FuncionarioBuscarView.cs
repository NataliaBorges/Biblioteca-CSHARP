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
    public partial class FuncionarioBuscarView : Form {

        FuncionarioController controller = new FuncionarioController();

        public FuncionarioBuscarView() {
            InitializeComponent();
        }

        private void Lvfuncionario_MouseClick(object sender, MouseEventArgs e) {
            ListViewItem item = Lvfuncionario.Items[Lvfuncionario.FocusedItem.Index];
            FuncionarioModel funcionario = new FuncionarioModel(
                int.Parse(item.SubItems[0].Text),
                item.SubItems[1].Text,
                item.SubItems[4].Text,
                DateTime.Parse(item.SubItems[2].Text),
                item.SubItems[6].Text,
                item.SubItems[5].Text,
                item.SubItems[3].Text
            );

            FuncionarioEditarView editar = new FuncionarioEditarView(funcionario);

            Rectangle bounds = this.Bounds;
            editar.SetBounds(bounds.X, bounds.Y, editar.Bounds.Width, editar.Bounds.Height);
            editar.StartPosition = FormStartPosition.CenterScreen;
            editar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            String busca = tbBuscar.Text;

            if (rbNome.Checked) {
                List<FuncionarioModel> lista = controller.Buscar(busca, isNome: true);
                popular(lista);
            }

            if (rbEmail.Checked) {
                List<FuncionarioModel> lista = controller.Buscar(busca, isEmail: true);
                popular(lista);
            }
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

        private void FuncionarioBuscarView_Load(object sender, EventArgs e) {
            List<FuncionarioModel> lista = controller.ListarTodos();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            List<FuncionarioModel> lista = controller.ListarTodos();
            popular(lista);
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
