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
    public partial class RelatorioLeitorView : Form {

        LeitorController controller = new LeitorController();

        public RelatorioLeitorView() {
            InitializeComponent();
        }

        private void popular(List<LeitorModel> lista) {
            LvLeitor.Items.Clear();
            if (lista.Count > 0) {
                foreach (LeitorModel leitor in lista) {
                    ListViewItem item = new ListViewItem(leitor.getId().ToString());
                    item.SubItems.Add(leitor.Nome);
                    item.SubItems.Add(leitor.DataNascimento.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(leitor.Telefone);
                    item.SubItems.Add(leitor.CPF);
                    item.SubItems.Add(leitor.Endereco);
                    item.SubItems.Add(leitor.QuantidadeEmprestimo.ToString());

                    LvLeitor.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            DateTime inicio = DateTime.Parse(tbInicio.Text);
            DateTime fim = DateTime.Parse(tbFim.Text);
            List<LeitorModel> lista = controller.Relatorio(inicio, fim);
            popular(lista);
        }
    }
}
