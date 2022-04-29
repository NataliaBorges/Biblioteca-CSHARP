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

namespace Biblioteca.View.Emprestimo {
    public partial class EmprestimoBuscarExemplarView : Form {

        EmprestimoController controller = new EmprestimoController();
        public EmprestimoBuscarExemplarView() {
            InitializeComponent();
        }
        //private void EmprestimoBuscarExemplarView_Load(object sender, EventArgs e) {
        //    List<LivroModel> lista = controller.ListarTodosLivros();
        //    popular(lista);
        //}

        //private void popular(List<LivroModel> lista) {
        //    LvLivros.Items.Clear();
        //    if (lista.Count > 0) {
        //        foreach (LivroModel livro in lista) {
        //            ListViewItem item = new ListViewItem(livro.getId().ToString());
        //            item.SubItems.Add(livro.Disponiveis.ToString());
        //            item.SubItems.Add(livro.Nome);
        //            item.SubItems.Add(livro.Autor);
        //            item.SubItems.Add(livro.Fornecedor);
        //            item.SubItems.Add(livro.ISBN);
        //            item.SubItems.Add(livro.Edicao);
        //            item.SubItems.Add(livro.AnoPublicacao);
        //            item.SubItems.Add(livro.DataAquisicao.ToString());


        //            LvLivros.Items.Add(item);
        //        }
        //    }
        //}

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
