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

namespace Biblioteca.View.Livros
{
    public partial class LivrosBuscarView : Form
    {

        LivroController controller = new LivroController();
        LivroModel livro;
        Singleton singleton = Singleton.GetInstancia();

        public LivrosBuscarView()
        {
            InitializeComponent();
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
            table.Columns.Add("Status", typeof(string));

            if (lista.Count > 0)
            {
                foreach (LivroModel livros in lista)
                {

                    table.Rows.Add(livros.getId(),
                                   livros.Titulo,
                                   livros.NomeAutor,
                                   livros.NomeEditora,
                                   livros.NomeGenero,
                                   livros.Quantidade,
                                   livros.getEstado());
                }
                dtGridViewLivros.DataSource = table;
            }
            int index = dtGridViewLivros.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewLivros.Rows[index].Selected = false;
            }
        }

        private void LivrosBuscarView_Load(object sender, EventArgs e)
        {
            this.dtGridViewLivros.DefaultCellStyle.Font = new Font("Book Antiqua", 12);

            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            CbEstado.Text = "Ambos";
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            LivrosCadastrarView livrosCadastrarView = new LivrosCadastrarView();
            NovaJanela.novaJanela(livrosCadastrarView, this.Bounds);
        }
        private void buscar(List<LivroModel> lista)
        {

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
        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            this.livro = null;
            String busca = tbBuscar.Text;
            String status = CbEstado.Text;

            if (tbBuscar.Text.Length > 0)
            {
                lblNotFound.Visible = false;

                if (rbNome.Checked)
                {
                    List<LivroModel> nome = controller.Buscar(busca, isNome: true, status: status);
                    buscar(nome);
                }
                else if (rbAutor.Checked)
                {
                    List<LivroModel> autor = controller.Buscar(busca, isAutor: true, status: status);
                    buscar(autor);
                }
                else if (rbEditora.Checked)
                {
                    List<LivroModel> editora = controller.Buscar(busca, isEditora: true, status: status);
                    buscar(editora);
                }
                else if (rbGenero.Checked)
                {
                    List<LivroModel> genero = controller.Buscar(busca, isGenero: true, status: status);
                    buscar(genero);
                }
                else
                {
                    List<LivroModel> nome = controller.Buscar(busca, isNome: true, status: status);
                    buscar(nome);
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

        private void rbNome_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewLivros.DataSource = null;
        }

        private void rbAutor_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewLivros.DataSource = null;
        }

        private void rbEditora_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewLivros.DataSource = null;
        }

        private void rbGenero_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewLivros.DataSource = null;
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

                int estado = 0;

                if (row.Cells[6].Value.ToString() == "Ativo")
                {
                    estado = 1;
                }

                this.livro = new LivroModel(id, titulo, editora, autor, genero, quantidade, estado);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (livro != null)
            {
                singleton.setLivroExemplar(livro);
                LivrosEditarView livroEditarView = new LivrosEditarView();
                NovaJanela.novaJanela(livroEditarView, Bounds);
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um livro", "Atenção", MessageBoxButtons.OK);
            }

        }

        private void LivrosBuscarView_Activated(object sender, EventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewLivros.DataSource = null;
        }

        private void CbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewLivros.DataSource = null;
        }
    }
}
