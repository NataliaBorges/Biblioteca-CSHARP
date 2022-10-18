using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;
using Biblioteca.View.Livros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Exemplar
{
    public partial class ExemplarBuscarLivroView : Form
    {
        LivroController controller = new LivroController();
        LivroModel livro;
        public ExemplarBuscarLivroView()
        {
            InitializeComponent();
        }
        private void ExemplarBuscarLivroView_Load(object sender, EventArgs e)
        {
            this.dtGridViewLivros.DefaultCellStyle.Font = new Font("Book Antiqua", 12);

            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);
        }
        private void popular(List<LivroModel> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Título", typeof(string));
            table.Columns.Add("Autor", typeof(string));
            table.Columns.Add("Editora", typeof(string));
            table.Columns.Add("Gênero", typeof(string));
            table.Columns.Add("Quantidade", typeof(int));

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
            int index = dtGridViewLivros.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewLivros.Rows[index].Selected = false;
            }
        }
        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (livro != null)
            {
                ExemplarCadastrarView exemplarCadastrarView = new ExemplarCadastrarView(livro);
                NovaJanela.novaJanela(exemplarCadastrarView, Bounds);
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um livro", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            this.livro = null;
            String busca = tbBuscar.Text;

            if (tbBuscar.Text.Length > 0)
            {
                lblNotFound.Visible = false;
                
                List<LivroModel> lista = controller.Buscar(busca, isNome: true, status: "Ativo");
                if (lista.Count > 0)
                {
                    lblNotFound.Visible = false;
                    popular(lista);
                }
                else
                {
                    lblNotFound.Visible = true;
                    dtGridViewLivros.DataSource = null;
                }
            }
            else if (tbBuscar.Text.Length == 0)
            {
                lblNotFound.Visible = false;
                dtGridViewLivros.DataSource = null;
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewLivros.DataSource = null;
            }
        }

        private void dtGridViewLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewLivros.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                String titulo = row.Cells[1].Value.ToString();
                String autor = row.Cells[2].Value.ToString();
                String editora = row.Cells[3].Value.ToString();
                String genero = row.Cells[4].Value.ToString();
                int quantidade = int.Parse(row.Cells[5].Value.ToString());

                this.livro = new LivroModel(id, titulo, editora, autor, genero, quantidade);
            }
        }

        private void ExemplarBuscarLivroView_Activated(object sender, EventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewLivros.DataSource = null;
        }
    }
}
