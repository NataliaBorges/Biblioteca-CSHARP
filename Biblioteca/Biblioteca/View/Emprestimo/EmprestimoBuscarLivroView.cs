﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.View.Livros;

namespace Biblioteca.View.Emprestimo {
    public partial class EmprestimoBuscarLivroView : Form {

        EmprestimoController controller = new EmprestimoController();

        public EmprestimoBuscarLivroView() {
            InitializeComponent();
        }

        private void EmprestimoBuscarLivroView_Load(object sender, EventArgs e) {
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
                    item.SubItems.Add(livro.Disponiveis.ToString());
                    item.SubItems.Add(livro.Nome);
                    item.SubItems.Add(livro.Autor);
                    item.SubItems.Add(livro.Fornecedor);
                    item.SubItems.Add(livro.ISBN);
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
        private void novaJanela(Form form) {
            Rectangle bounds = this.Bounds;
            form.SetBounds(bounds.X, bounds.Y, form.Bounds.Width, form.Bounds.Height);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(-2, 63);
            form.ShowDialog();
        }

        private void LvLivros_MouseClick(object sender, MouseEventArgs e) {
            ListViewItem item = LvLivros.Items[LvLivros.FocusedItem.Index];
            if (int.Parse(item.SubItems[1].Text) == 0) {
                MessageBox.Show("Este livro está indisponível no momento.", "", MessageBoxButtons.OK);
            }
            else {
                LivroModel livro = new LivroModel(
                    int.Parse(item.SubItems[0].Text),
                    item.SubItems[2].Text,
                    item.SubItems[3].Text,
                    item.SubItems[6].Text,
                    item.SubItems[7].Text,
                    DateTime.Parse(item.SubItems[8].Text),
                    item.SubItems[4].Text,
                    item.SubItems[5].Text
                );

                EmprestimoBuscarExemplarView livros = new EmprestimoBuscarExemplarView();
                novaJanela(livros);

                //controller.InserirLivroEmprestimo(livro);
                //this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            LivrosCadastrarView livrosCadastrarView = new LivrosCadastrarView();
            novaJanela(livrosCadastrarView);
        }
    }
}
