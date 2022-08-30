using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Model;
using Biblioteca.Controller;

namespace Biblioteca.View.Reserva {
    public partial class ReservaExcluirView : Form {

        ReservaPesquisaModel reserva;
        ReservaController controller = new ReservaController();

        public ReservaExcluirView(ReservaPesquisaModel reserva) {
            this.reserva = reserva;
            InitializeComponent();
        }

        private void popular(List<ReservaModel> lista) {
            lvReserva.Items.Clear();
            if (lista.Count > 0) {
                foreach (ReservaModel reserva in lista) {
                    ListViewItem item = new ListViewItem(reserva.getId().ToString());
                    item.SubItems.Add(reserva.IdFuncionario.ToString());
                    item.SubItems.Add(reserva.Funcionario);
                    item.SubItems.Add(reserva.IdLeitor.ToString());
                    item.SubItems.Add(reserva.Leitor);
                    item.SubItems.Add(reserva.DataReserva.ToString("dd/MM/yyyy"));

                    lvReserva.Items.Add(item);

                    ObsText.Text = reserva.Obs;
                }
            }
        }

        private void popular(List<LivroModel> lista) {
            LvLivros.Items.Clear();
            if (lista.Count > 0) {
                foreach (LivroModel livro in lista) {
                    ListViewItem item = new ListViewItem(livro.getId().ToString());
                    //item.SubItems.Add(livro.Nome);
                    //item.SubItems.Add(livro.Autor);
                    //item.SubItems.Add(livro.Editora);
                    //item.SubItems.Add(livro.Edicao);
                    //item.SubItems.Add(livro.AnoPublicacao);

                    LvLivros.Items.Add(item);
                }
            }
        }

        private void Excluir_Load(object sender, EventArgs e) {
            if (reserva != null) {
                List<ReservaModel> dados = controller.ListarReserva(reserva.ID_reserva);
                popular(dados);

                List<LivroModel> livros = controller.ListarTodosLivrosReserva(reserva.ID_reserva);
                popular(livros);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                if (controller.Excluir(reserva)) {
                    MessageBox.Show("Excluído com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                else {
                    MessageBox.Show("Não foi possível excluir", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("O livro está nas mesmas condições de quando saiu?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                if (controller.Devolucao(reserva)) {
                    MessageBox.Show("Devolvido com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                else {
                    MessageBox.Show("Não foi possível devolver o livro.", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e) {
            this.Close();
        }
    }
}
