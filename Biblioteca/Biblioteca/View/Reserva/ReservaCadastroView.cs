﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.View.Reserva;
using Biblioteca.Util;

namespace Biblioteca.View.Reserva {
    public partial class ReservaCadastroView : Form {

        DateTime dataReserva;
        DateTime dataDevolucao;
        ReservaController controller = new ReservaController();
        Singleton singleton = Singleton.GetInstancia();

        public ReservaCadastroView() {
            InitializeComponent();
        }

        private void calendarReserva_DateChanged(object sender, DateRangeEventArgs e) {
            tbReserva.Text = calendarReserva.SelectionRange.Start.ToString("dd/MM/yyyy");
            int ano = int.Parse(calendarReserva.SelectionRange.Start.ToString("yyyy"));
            int mes = int.Parse(calendarReserva.SelectionRange.Start.ToString("MM"));
            int dia = int.Parse(calendarReserva.SelectionRange.Start.ToString("dd"));
            dataReserva = new DateTime(ano, mes, dia);
        }

        private void novaJanela(Form form) {
            Rectangle bounds = this.Bounds;
            form.SetBounds(bounds.X, bounds.Y, form.Bounds.Width, form.Bounds.Height);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            ReservaBuscarLivroView livros = new ReservaBuscarLivroView();
            novaJanela(livros);
        }

        private void ReservaCadastroView_Load(object sender, EventArgs e) {
            popularLivros(controller.PegarLivrosReserva());
            popularLeitor(controller.PegarLeitorReserva());
        }

        protected override void OnActivated(EventArgs e) {
            popularLivros(controller.PegarLivrosReserva());
            popularLeitor(controller.PegarLeitorReserva());
        }

        private void popularLivros(List<LivroModel> lista) {
            lvLivros.Items.Clear();
            if (lista.Count > 0) {
                foreach (LivroModel livro in lista) {
                    ListViewItem item = new ListViewItem(livro.getId().ToString());
                    item.SubItems.Add(livro.Nome);
                    item.SubItems.Add(livro.Autor);
                    item.SubItems.Add(livro.Fornecedor);
                    item.SubItems.Add(livro.Edicao);
                    item.SubItems.Add(livro.AnoPublicacao);
                    item.SubItems.Add(livro.DataAquisicao.ToString());

                    lvLivros.Items.Add(item);
                }
            }
        }

        private void popularLeitor(List<LeitorModel> lista) {
            lvLeitor.Items.Clear();
            if (lista.Count > 0) {
                foreach (LeitorModel leitor in lista) {
                    if (leitor != null) {
                        ListViewItem item = new ListViewItem(leitor.getId().ToString());
                        item.SubItems.Add(leitor.Nome);
                        item.SubItems.Add(leitor.DataNascimento.ToString());
                        item.SubItems.Add(leitor.Telefone);
                        item.SubItems.Add(leitor.CPF);
                        item.SubItems.Add(leitor.Endereco);

                        lvLeitor.Items.Add(item);
                    }
                }
            }
        }

        private void lvLivros_MouseClick(object sender, MouseEventArgs e) {
            ListViewItem item = lvLivros.Items[lvLivros.FocusedItem.Index];
            LivroModel livro = new LivroModel(
                int.Parse(item.SubItems[0].Text),
                item.SubItems[1].Text,
                item.SubItems[2].Text,
                item.SubItems[4].Text,
                item.SubItems[5].Text,
                DateTime.Parse(item.SubItems[6].Text),
                item.SubItems[3].Text
            );


            DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                controller.RemoverLivroReserva(livro);
                popularLivros(controller.PegarLivrosReserva());
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            ReservaBuscarLeitorView leitor = new ReservaBuscarLeitorView();
            novaJanela(leitor);
        }

        private void lvLeitor_MouseClick(object sender, MouseEventArgs e) {
            ListViewItem item = lvLeitor.Items[lvLeitor.FocusedItem.Index];
            LeitorModel leitor = new LeitorModel(
                int.Parse(item.SubItems[0].Text),
                item.SubItems[1].Text,
                DateTime.Parse(item.SubItems[2].Text),
                item.SubItems[3].Text,
                item.SubItems[4].Text,
                item.SubItems[5].Text
            );

            DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                controller.RemoverLeitorReserva();
                popularLeitor(controller.PegarLeitorReserva());
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            String Reserva = tbReserva.Text;
            String obs = tbObs.Text;

            // Cadastra Reserva
            controller.Insercao(Reserva, obs);

            // Pega o ID do Reserva cadastrado
            int idReserva = controller.BuscarUltimoReserva();

            // Cadastra no Item_Reserva cada livro relacionando com o Reserva
            foreach (LivroModel livro in this.singleton.getLivros()) {
                controller.RelacionarLivrosReserva(idReserva, livro);
            }

            this.singleton.clearReserva();

            MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
            this.Close();
        }

        private void tbObs_TextChanged(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }


        private void tbReserva_TextChanged(object sender, EventArgs e) {

        }
    }
}