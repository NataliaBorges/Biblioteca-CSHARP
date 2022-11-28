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

namespace Biblioteca.View.Reserva
{
    public partial class ReservaBuscarLivroView : Form
    {

        ReservaController controller = new ReservaController();
        LivroModel livro;
        Singleton singleton = Singleton.GetInstancia();

        public ReservaBuscarLivroView()
        {
            InitializeComponent();
        }

        private void ReservaBuscarLivroView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);
        }

        private void popular(List<LivroModel> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Disponíveis", typeof(int));
            table.Columns.Add("Título", typeof(string));
            table.Columns.Add("Autor", typeof(string));
            table.Columns.Add("Editora", typeof(string));
            table.Columns.Add("Gênero", typeof(string));

            if (lista.Count > 0)
            {
                foreach (LivroModel livros in lista)
                {

                    table.Rows.Add(livros.getId(),
                                   livros.Disponiveis,
                                   livros.Titulo,
                                   livros.NomeAutor,
                                   livros.NomeEditora,
                                   livros.NomeGenero);
                }
                dtGridViewLivros.DataSource = table;
                int index = dtGridViewLivros.SelectedRows[0].Index;

                if (index >= 0)
                {
                    dtGridViewLivros.Rows[index].Selected = false;
                }
            }
        }

        private void IcnBtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ReservaBuscarLivroView_Activated(object sender, EventArgs e)
        {
            if (singleton.getAddExemplar() == true)
            {
                this.Close();
            }
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

        private void tbPesquisar_TextChanged(object sender, EventArgs e)
        {
            this.livro = null;
            String busca = tbPesquisar.Text;

            if (tbPesquisar.Text.Length > 0)
            {
                lblNotFound.Visible = false;

                List<LivroModel> lista = controller.BuscarLivros(busca);
                buscar(lista);
            }
            else if (tbPesquisar.Text.Length == 0)
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

                ReservaBuscarExemplarView livros = new ReservaBuscarExemplarView(id);
                NovaJanela.novaJanela(livros, this.Bounds);
            }
        }
    }
}
