using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;

namespace Biblioteca.View.Reserva {
    public partial class ReservaBuscarLivroView : Form {

        ReservaController controller = new ReservaController();

        public ReservaBuscarLivroView() {
            InitializeComponent();
        }

        private void ReservaBuscarLivroView_Load(object sender, EventArgs e) {
            List<LivroModel> lista = controller.ListarTodosLivros();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            List<LivroModel> lista = controller.ListarTodosLivros();
            popular(lista);
        }

        private void popular(List<LivroModel> lista) {
            LvLivros.Items.Clear();
            if (lista.Count > 0) {
                foreach (LivroModel livro in lista) {
                    ListViewItem item = new ListViewItem(livro.getId().ToString());
                    item.SubItems.Add(livro.Nome);
                    item.SubItems.Add(livro.Autor);
                    item.SubItems.Add(livro.Fornecedor);
                    item.SubItems.Add(livro.Edicao);
                    item.SubItems.Add(livro.AnoPublicacao);
                    item.SubItems.Add(livro.DataAquisicao.ToString());

                    LvLivros.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            String busca = tbBuscar.Text;

            List<LivroModel> lista = controller.BuscarLivros(busca);
            popular(lista);
        }

        private void LvLivros_MouseClick(object sender, MouseEventArgs e) {
            ListViewItem item = LvLivros.Items[LvLivros.FocusedItem.Index];
            ExemplarModel exemplar = new ExemplarModel(
                int.Parse(item.SubItems[0].Text),
                item.SubItems[1].Text,
                item.SubItems[2].Text,
                item.SubItems[4].Text,
                item.SubItems[5].Text,
                item.SubItems[3].Text, 
                item.SubItems[6].Text
            );

            controller.InserirExemplarReserva(exemplar);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
