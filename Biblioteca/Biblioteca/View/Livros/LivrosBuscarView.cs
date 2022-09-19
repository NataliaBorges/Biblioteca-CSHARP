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

namespace Biblioteca.View.Livros {
    public partial class LivrosBuscarView : Form {

        LivroController controller = new LivroController();

        public LivrosBuscarView() {
            InitializeComponent();
        }

        private void popular(List<LivroModel> lista) {
            //DataTable table = new DataTable();
            //table.Columns.Add("ID", typeof(int));
            //table.Columns.Add("NAME", typeof(string));
            //drGrViewLivro.DataSource = lista;
            //LvLivros.Items.Clear();
            if (lista.Count > 0) {
                foreach (LivroModel livro in lista) {
                    //table.Rows.Add(livro.getId(), livro.Titulo);
                    ListViewItem item = new ListViewItem(livro.getId().ToString());
                    item.SubItems.Add(livro.Titulo);
                    item.SubItems.Add(livro.Edicao);
                    item.SubItems.Add(livro.AnoPublicacao);
                    item.SubItems.Add(livro.ISBN);
                    item.SubItems.Add(livro.Quantidade.ToString());
                    item.SubItems.Add(livro.NomeAutor);
                    item.SubItems.Add(livro.NomeEditora);
                    item.SubItems.Add(livro.NomeGenero);

                   // LvLivros.Items.Add(item);
                }
                //drGrViewLivro.DataSource = table;
            }
        }

        private void LivrosBuscarView_Load(object sender, EventArgs e) {
            this.menuControl1.setPanel(pnltotal);
            List<LivroModel> lista = controller.ListarTodos();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            List<LivroModel> lista = controller.ListarTodos();
            popular(lista);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String busca = tbBuscar.Text;

            if (rbNome.Checked)
            {
                List<LivroModel> lista = controller.Buscar(busca, isNome: true);
                popular(lista);
            }

            if (rbAutor.Checked)
            {
                List<LivroModel> lista = controller.Buscar(busca, isAutor: true);
                popular(lista);
            }

            if (rbEditora.Checked)
            {
                List<LivroModel> lista = controller.Buscar(busca, isEditora: true);
                popular(lista);
            }
        }

        //private void LvLivros_MouseClick_1(object sender, MouseEventArgs e)
        //{
        //    //ListViewItem item = LvLivros.Items[LvLivros.FocusedItem.Index];
        //    //LivroModel livro = new LivroModel(
        //        //int.Parse(item.SubItems[0].Text),
        //        //item.SubItems[1].Text,
        //        //item.SubItems[2].Text,
        //        //item.SubItems[3].Text,
        //        //item.SubItems[4].Text,
        //        //int.Parse(item.SubItems[5].Text),
        //        //item.SubItems[6].Text,
        //        //item.SubItems[7].Text,
        //        //item.SubItems[8].Text
        //    );

        //    LivroBuscarExemplarView livroBuscarExemplarView = new LivroBuscarExemplarView(livro.getId());
        //    NovaJanela.novaJanela(livroBuscarExemplarView, this.Bounds);
        //}

        private void linklablCadastrarLivro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LivrosCadastrarView livrosCadastrarView = new LivrosCadastrarView();
            NovaJanela.novaJanela(livrosCadastrarView, this.Bounds);
        }
    }
}
