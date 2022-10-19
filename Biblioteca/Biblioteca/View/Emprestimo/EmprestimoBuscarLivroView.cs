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
        LivroModel livro;
        Singleton singleton = Singleton.GetInstancia();

        public EmprestimoBuscarLivroView() {
            InitializeComponent();
        }

        private void EmprestimoBuscarLivroView_Load(object sender, EventArgs e) {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

        }
        private void EmprestimoBuscarLivroView_Activated(object sender, EventArgs e)
        {
            if (singleton.getAddExemplar() == true)
            {
                this.Close();
            }
        }

        private void popular(List<LivroModel> lista) {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Título", typeof(string));
            table.Columns.Add("Autor", typeof(string));
            table.Columns.Add("Editora", typeof(string));
            table.Columns.Add("Gênero", typeof(string));

            if (lista.Count > 0)
            {
                foreach (LivroModel livros in lista)
                {

                    table.Rows.Add(livros.getId(),
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

            if (tbBuscar.Text.Length > 0)
            {
                lblNotFound.Visible = false;

                List<LivroModel> lista = controller.BuscarLivros(busca);
                buscar(lista);
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
                //    ListViewItem item = LvLivros.Items[LvLivros.FocusedItem.Index];
                //    if (int.Parse(item.SubItems[1].Text) == 0) {
                //        MessageBox.Show("Este livro está indisponível no momento.", "", MessageBoxButtons.OK);
                //    }

                int id = int.Parse(row.Cells[0].Value.ToString());

                EmprestimoBuscarExemplarView livros = new EmprestimoBuscarExemplarView(id);
                NovaJanela.novaJanela(livros, this.Bounds);
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
        
    }
}
