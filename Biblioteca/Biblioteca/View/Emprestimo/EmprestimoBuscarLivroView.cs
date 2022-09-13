using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.View.Livros;
using Biblioteca.Util;

namespace Biblioteca.View.Emprestimo {
    public partial class EmprestimoBuscarLivroView : Form {

        EmprestimoController controller = new EmprestimoController();
        Singleton singleton = Singleton.GetInstancia();

        public EmprestimoBuscarLivroView() {
            InitializeComponent();
        }

        private void EmprestimoBuscarLivroView_Load(object sender, EventArgs e) {
            this.menuControl1.setPanel(pnltotal);

            List<LivroModel> lista = controller.ListarTodosLivros();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            if (singleton.getAddAutor() == true) {
                this.Close();
            }
            List<LivroModel> lista = controller.ListarTodosLivros();
            popular(lista);
        }

        private void popular(List<LivroModel> lista) {
            LvLivros.Items.Clear();
            if (lista.Count > 0) {
                foreach (LivroModel livro in lista) {
                    ListViewItem item = new ListViewItem(livro.getId().ToString());
                    //item.SubItems.Add(livro.Disponiveis.ToString());
                    //item.SubItems.Add(livro.Nome);
                    //item.SubItems.Add(livro.Autor);
                    //item.SubItems.Add(livro.Editora);
                    //item.SubItems.Add(livro.ISBN);
                    //item.SubItems.Add(livro.Edicao);
                    //item.SubItems.Add(livro.AnoPublicacao);
                    //item.SubItems.Add(livro.DataAquisicao.ToString());
                    

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
            if (int.Parse(item.SubItems[1].Text) == 0) {
                MessageBox.Show("Este livro está indisponível no momento.", "", MessageBoxButtons.OK);
            }
            else {
                //LivroModel livro = new LivroModel(
                    //int.Parse(item.SubItems[0].Text),
                    //item.SubItems[2].Text,
                    //item.SubItems[3].Text,
                    //item.SubItems[6].Text,
                    //item.SubItems[7].Text,
                    //item.SubItems[4].Text,
                    //item.SubItems[5].Text
                //);

                EmprestimoBuscarExemplarView livros = new EmprestimoBuscarExemplarView(int.Parse(item.SubItems[0].Text));
                NovaJanela.novaJanela(livros, this.Bounds);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            LivrosCadastrarView livrosCadastrarView = new LivrosCadastrarView();
            NovaJanela.novaJanela(livrosCadastrarView, Bounds);
        }
    }
}
