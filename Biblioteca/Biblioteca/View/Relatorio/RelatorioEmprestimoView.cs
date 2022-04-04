using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;

namespace Biblioteca.View.Relatorio {
    public partial class RelatorioEmprestimoView : Form {

        EmprestimoController controller = new EmprestimoController();

        public RelatorioEmprestimoView() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            DateTime inicio = DateTime.Parse(tbInicio.Text);
            DateTime fim = DateTime.Parse(tbFim.Text);
            List<EmprestimoModel> lista = controller.Relatorio(inicio, fim);
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

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
