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

namespace Biblioteca.View.Leitor {
    public partial class LeitorBuscarView : Form {

        LeitorController controller = new LeitorController();
        public LeitorBuscarView() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            String busca = tbBuscar.Text;

            if (rbNome.Checked) {
                List<LeitorModel> lista = controller.Buscar(busca, isNome: true);
                popular(lista);
            }

            if (rbCPF.Checked) {
                List<LeitorModel> lista = controller.Buscar(busca, isCPF: true);
                popular(lista);
            }
        }

        private void popular(List<LeitorModel> lista) {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Telefone", typeof(string));
            table.Columns.Add("Nascimento", typeof(DateTime));
            table.Columns.Add("CPF", typeof(string));
            table.Columns.Add("Endereço", typeof(string));
            table.Columns.Add("Status", typeof(string));
            dtGridViewLeitor.DataSource = lista;
            if (lista.Count > 0)
            {
                foreach (LeitorModel leitor in lista)
                {

                    table.Rows.Add(leitor.getId(), 
                                   leitor.Nome,
                                   leitor.Email,
                                   leitor.Telefone,
                                   leitor.DataNascimento,
                                   leitor.CPF,
                                   leitor.Endereco,
                                   leitor.Estado);
                }
                dtGridViewLeitor.DataSource = table;
            }
        }

        private void LeitorBuscarView_Load(object sender, EventArgs e) {
            this.menuControl1.setPanel(pnltotal);

            List<LeitorModel> lista = controller.ListarTodos();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            List<LeitorModel> lista = controller.ListarTodos();
            popular(lista);
        }

        //private void LvLeitor_MouseClick(object sender, MouseEventArgs e) {
        //    ListViewItem item = dtGridViewLeitor.Items[dtGridViewLeitor.FocusedItem.Index];
        //    LeitorModel leitor = new LeitorModel(
        //        int.Parse(item.SubItems[0].Text),
        //        item.SubItems[1].Text,
        //        DateTime.Parse(item.SubItems[2].Text),
        //        item.SubItems[3].Text,
        //        item.SubItems[4].Text,
        //        item.SubItems[5].Text,
        //        item.SubItems[6].Text
        //    );

        //    LeitorEditarView editar = new LeitorEditarView(leitor);
        //    NovaJanela.novaJanela(editar, this.Bounds);
        //}
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            LeitorCadastrarView leitorCadastrarView = new LeitorCadastrarView();
            NovaJanela.novaJanela(leitorCadastrarView, this.Bounds);
        }
        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
