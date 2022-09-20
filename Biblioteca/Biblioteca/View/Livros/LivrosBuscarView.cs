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
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Quantidade", typeof(int));
            table.Columns.Add("Título", typeof(string));
            table.Columns.Add("Edição", typeof(string));
            table.Columns.Add("Ano de Publicação", typeof(string));
            table.Columns.Add("ISBN", typeof(string));
            table.Columns.Add("Autor", typeof(string));
            table.Columns.Add("Editora", typeof(string));
            table.Columns.Add("Gênero", typeof(string));

            dtGridViewLivros.DataSource = lista;
            if (lista.Count > 0)
            {
                foreach (LivroModel livros in lista)
                {

                    table.Rows.Add(livros.getId(),
                                   livros.Quantidade,
                                   livros.Titulo,
                                   livros.Edicao,
                                   livros.AnoPublicacao,
                                   livros.ISBN,
                                   livros.NomeAutor,
                                   livros.NomeEditora,
                                   livros.NomeGenero);
                }
                dtGridViewLivros.DataSource = table;
            }
        }

        private void LivrosBuscarView_Load(object sender, EventArgs e) {
            this.menuControl1.setPanel(pnltotal);
            List<LivroModel> lista = controller.ListarTodos();
            popular(lista);
        }
        private void LivrosBuscarView_Activated(object sender, EventArgs e)
        {
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

        private void linklablCadastrarLivro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LivrosCadastrarView livrosCadastrarView = new LivrosCadastrarView();
            NovaJanela.novaJanela(livrosCadastrarView, this.Bounds);
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGridViewLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtGridViewLivros.Rows[0].Cells[0].Value.ToString();
            String Quantidade = dtGridViewLivros.Rows[0].Cells[1].Value.ToString();
            String Titulo = dtGridViewLivros.Rows[0].Cells[1].Value.ToString();
            String Edicao = dtGridViewLivros.Rows[0].Cells[1].Value.ToString();
            String anoPublicacao = dtGridViewLivros.Rows[0].Cells[1].Value.ToString();
            String ISBN = dtGridViewLivros.Rows[0].Cells[1].Value.ToString();
            String Autor = dtGridViewLivros.Rows[0].Cells[1].Value.ToString();
            String Editora = dtGridViewLivros.Rows[0].Cells[1].Value.ToString();
            String Genero = dtGridViewLivros.Rows[0].Cells[1].Value.ToString();

            LivrosEditarView livrosEditarView = new LivrosEditarView();
            NovaJanela.novaJanela(livrosEditarView, this.Bounds);
        }
    }
}
