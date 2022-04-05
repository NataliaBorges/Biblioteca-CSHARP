using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.View.Reserva;

namespace Biblioteca.View.Reserva {
    public partial class ReservaBuscarView : Form {

        ReservaController controller = new ReservaController();

        public ReservaBuscarView() {
            InitializeComponent();
        }

        private void EmpretimoBuscarView_Load(object sender, EventArgs e) {
            List<ReservaPesquisaModel> lista = controller.ListarTodosBusca();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            List<ReservaPesquisaModel> lista = controller.ListarTodosBusca();
            popular(lista);
        }

        private void popular(List<ReservaPesquisaModel> lista) {
            lvReserva.Items.Clear();
            if (lista.Count > 0) {
                foreach (ReservaPesquisaModel Reserva in lista) {
                    ListViewItem item = new ListViewItem(Reserva.ID_reserva.ToString());
                    item.SubItems.Add(Reserva.Nome_Leitor);
                    item.SubItems.Add(Reserva.Nome_Livro);
                    item.SubItems.Add(Reserva.Nome_funcionario);
                    item.SubItems.Add(Reserva.Data_reserva.ToString("dd/MM/yyyy"));
                    lvReserva.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            String busca = tbBuscar.Text;

            if (rbLivro.Checked) {
                List<ReservaPesquisaModel> lista = controller.Buscar(busca, isLivro: true);
                popular(lista);
            }

            if (rbLeitor.Checked) {
                List<ReservaPesquisaModel> lista = controller.Buscar(busca, isLeitor: true);
                popular(lista);
            }
        }

        private void lvReserva_MouseClick(object sender, MouseEventArgs e) {
            ListViewItem item = lvReserva.Items[lvReserva.FocusedItem.Index];
            ReservaPesquisaModel pesquisa = new ReservaPesquisaModel(
                    int.Parse(item.SubItems[0].Text),
                    item.SubItems[1].Text,
                    item.SubItems[2].Text,
                    item.SubItems[3].Text,
                    DateTime.Parse(item.SubItems[4].Text)
                );

            ReservaExcluirView editar = new ReservaExcluirView(pesquisa);

            Rectangle bounds = this.Bounds;
            editar.SetBounds(bounds.X, bounds.Y, editar.Bounds.Width, editar.Bounds.Height);
            editar.StartPosition = FormStartPosition.Manual;
            editar.Location = new Point(-2, 63);
            editar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
