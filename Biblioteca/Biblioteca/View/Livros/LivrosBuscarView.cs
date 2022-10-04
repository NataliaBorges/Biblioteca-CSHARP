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
            table.Columns.Add("Título", typeof(string));
            table.Columns.Add("Autor", typeof(string));
            table.Columns.Add("Editora", typeof(string));
            table.Columns.Add("Gênero", typeof(string));
            table.Columns.Add("Quantidade", typeof(int));

            dtGridViewLivros.DataSource = lista;
            if (lista.Count > 0)
            {
                foreach (LivroModel livros in lista)
                {

                    table.Rows.Add(livros.getId(),
                                   livros.Titulo,
                                   livros.NomeAutor,
                                   livros.NomeEditora,
                                   livros.NomeGenero,
                                   livros.Quantidade);
                }
                dtGridViewLivros.DataSource = table;
            }
        }

        private void LivrosBuscarView_Load(object sender, EventArgs e) {
            this.dtGridViewLivros.DefaultCellStyle.Font = new Font("Book Antiqua", 12);
            this.menuControl1.setPanel(pnltotal);

            //List<LivroModel> lista = controller.ListarTodos();
            //popular(lista);
        }
        private void LivrosBuscarView_Activated(object sender, EventArgs e)
        {
            //List<LivroModel> lista = controller.ListarTodos();
            //popular(lista);
        }
        private void BtnPesquisar_Click(object sender, EventArgs e)
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
            if (rbGenero.Checked)
            {
                List<LivroModel> lista = controller.Buscar(busca, isGenero: true);
                popular(lista);
            }
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            LivrosCadastrarView livrosCadastrarView = new LivrosCadastrarView();
            NovaJanela.novaJanela(livrosCadastrarView, this.Bounds);
        }

        private void dtGridViewLivros_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewLivros.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                int quantidade = int.Parse(row.Cells[1].Value.ToString());
                String Titulo = row.Cells[2].Value.ToString();
                String Autor = row.Cells[6].Value.ToString();
                String Editora = row.Cells[7].Value.ToString();
                String Genero = row.Cells[8].Value.ToString();

                LivroModel livroSelecionado = new LivroModel(id, Titulo, Editora, Autor, Genero, quantidade);

                LivrosEditarView livrosEditarView = new LivrosEditarView(livroSelecionado);
                NovaJanela.novaJanela(livrosEditarView, this.Bounds);

            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            String busca = tbBuscar.Text;

            List<LivroModel> lista = controller.Buscar(busca);

            if (tbBuscar.Text.Length > 0 && lista.Count > 0)
            {
                lblNotFound.Visible = false;

                if (rbNome.Checked)
                {
                    List<LivroModel> nome = controller.Buscar(busca, isNome: true);
                    popular(lista);
                }

                if (rbAutor.Checked)
                {
                    List<LivroModel> autor = controller.Buscar(busca, isAutor: true);
                    popular(lista);
                }

                if (rbEditora.Checked)
                {
                    List<LivroModel> editora = controller.Buscar(busca, isEditora: true);
                    popular(lista);
                }
                if (rbGenero.Checked)
                {
                    List<LivroModel> genero = controller.Buscar(busca, isGenero: true);
                    popular(lista);
                }
            }
            else if (tbBuscar.Text.Length == 0)
            {
                lblNotFound.Visible = false;
                dtGridViewLivro.DataSource = null;
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewLivro.DataSource = null;
            }
        }
    }
}
