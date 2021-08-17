using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;

namespace Biblioteca.View.Leitor {
    public partial class LeitorPrincipalView : Form {

        LeitorController controller = new LeitorController();

        public LeitorPrincipalView() {
            InitializeComponent();
        }

        private void novaJanela(Form form) {
            Rectangle bounds = this.Bounds;
            form.SetBounds(bounds.X, bounds.Y, form.Bounds.Width, form.Bounds.Height);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            LeitorCadastrarView cadastrar = new LeitorCadastrarView();
            novaJanela(cadastrar);
        }

        private void LeitorPrincipalView_Load(object sender, EventArgs e) {
            List<LeitorModel> lista = controller.ListarTodos();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            List<LeitorModel> lista = controller.ListarTodos();
            popular(lista);
        }

        private void popular(List<LeitorModel> lista) {
            LvLeitor.Items.Clear();
            if (lista.Count > 0) {
                foreach (LeitorModel leitor in lista) {
                    ListViewItem item = new ListViewItem(leitor.getId().ToString());
                    item.SubItems.Add(leitor.Nome);
                    item.SubItems.Add(leitor.DataNascimento.ToString());
                    item.SubItems.Add(leitor.Telefone);
                    item.SubItems.Add(leitor.CPF);
                    item.SubItems.Add(leitor.Endereco);

                    LvLeitor.Items.Add(item);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            LeitorBuscarView buscar = new LeitorBuscarView();
            novaJanela(buscar);
        }
    }
}
