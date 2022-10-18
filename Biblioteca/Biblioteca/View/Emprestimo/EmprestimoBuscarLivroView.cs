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
            if (singleton.getAddExemplar() == true) {
                this.Close();
            }
            List<LivroModel> lista = controller.ListarTodosLivros();
            popular(lista);
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

        private void button1_Click(object sender, EventArgs e) {
            String busca = tbBuscar.Text;

            List<LivroModel> lista = controller.BuscarLivros(busca);
            popular(lista);
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            LivrosCadastrarView livrosCadastrarView = new LivrosCadastrarView();
            NovaJanela.novaJanela(livrosCadastrarView, Bounds);
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {

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
            this.Close();
        }
    }
}
