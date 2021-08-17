using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.View.Emprestimo;

namespace Biblioteca.View.Emprestimo {
    public partial class EmprestimoPrincipalView : Form {

        EmprestimoController controller = new EmprestimoController();

        public EmprestimoPrincipalView() {
            InitializeComponent();
        }

        private void EmprestimoPrincipalView_Load(object sender, EventArgs e) {
            List<EmprestimoModel> lista = controller.ListarTodos();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            List<EmprestimoModel> lista = controller.ListarTodos();
            popular(lista);
        }

        private void popular(List<EmprestimoModel> lista) {
            lvEmprestimo.Items.Clear();
            if (lista.Count > 0) {
                foreach (EmprestimoModel emprestimo in lista) {
                    ListViewItem item = new ListViewItem(emprestimo.getId().ToString());
                    item.SubItems.Add(emprestimo.IdFuncionario.ToString());
                    item.SubItems.Add(emprestimo.Funcionario);
                    item.SubItems.Add(emprestimo.IdLeitor.ToString());
                    item.SubItems.Add(emprestimo.Leitor);
                    item.SubItems.Add(emprestimo.DataEmprestimo.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(emprestimo.DataDevolucao.ToString("dd/MM/yyyy"));

                    lvEmprestimo.Items.Add(item);
                }
            }
        }

        private void novaJanela(Form form) {
            Rectangle bounds = this.Bounds;
            form.SetBounds(bounds.X, bounds.Y, form.Bounds.Width, form.Bounds.Height);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e) {
            EmprestimoCadastroView cadastrar = new EmprestimoCadastroView();
            novaJanela(cadastrar);
        }

        private void button2_Click(object sender, EventArgs e) {
            EmprestimoBuscarView buscar = new EmprestimoBuscarView();
            novaJanela(buscar);
        }
    }
}
