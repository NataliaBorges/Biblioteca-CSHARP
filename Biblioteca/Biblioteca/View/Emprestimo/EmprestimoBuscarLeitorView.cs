using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;

namespace Biblioteca.View.Emprestimo {
    public partial class EmprestimoBuscarLeitorView : Form {

        EmprestimoController controller = new EmprestimoController();

        public EmprestimoBuscarLeitorView() {
            InitializeComponent();
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

        private void EmprestimoBuscarLeitorView_Load(object sender, EventArgs e) {
            List<LeitorModel> lista = controller.ListarTodosLeitores();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            List<LeitorModel> lista = controller.ListarTodosLeitores();
            popular(lista);
        }

        private void button1_Click(object sender, EventArgs e) {
            String busca = tbBuscar.Text;
            List<LeitorModel> lista = controller.BuscarLeitor(busca);
            popular(lista);
        }

        private void LvLeitor_MouseClick(object sender, MouseEventArgs e) {
            ListViewItem item = LvLeitor.Items[LvLeitor.FocusedItem.Index];
            LeitorModel leitor = new LeitorModel(
                int.Parse(item.SubItems[0].Text),
                item.SubItems[1].Text,
                DateTime.Parse(item.SubItems[2].Text),
                item.SubItems[3].Text,
                item.SubItems[4].Text,
                item.SubItems[5].Text
            );

            controller.InserirLeitorEmprestimo(leitor);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
