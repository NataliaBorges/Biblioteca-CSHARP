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
    public partial class ReservaPrincipalView : Form {

        ReservaController controller = new ReservaController();

        public ReservaPrincipalView() {
            InitializeComponent();
        }

        private void ReservaPrincipalView_Load(object sender, EventArgs e) {
            List<ReservaModel> lista = controller.ListarTodos();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            List<ReservaModel> lista = controller.ListarTodos();
            popular(lista);
        }

        private void popular(List<ReservaModel> lista) {
            lvReserva.Items.Clear();
            if (lista.Count > 0) {
                foreach (ReservaModel Reserva in lista) {
                    ListViewItem item = new ListViewItem(Reserva.getId().ToString());
                    item.SubItems.Add(Reserva.IdFuncionario.ToString());
                    item.SubItems.Add(Reserva.Funcionario);
                    item.SubItems.Add(Reserva.IdLeitor.ToString());
                    item.SubItems.Add(Reserva.Leitor);
                    item.SubItems.Add(Reserva.DataReserva.ToString("dd/MM/yyyy"));
                    lvReserva.Items.Add(item);
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
            ReservaCadastroView cadastrar = new ReservaCadastroView();
            novaJanela(cadastrar);
        }

        private void button2_Click(object sender, EventArgs e) {
            ReservaBuscarView buscar = new ReservaBuscarView();
            novaJanela(buscar);
        }
    }
}
