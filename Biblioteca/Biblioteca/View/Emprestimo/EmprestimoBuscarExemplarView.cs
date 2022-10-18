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
        int idLivro;
        public EmprestimoBuscarExemplarView(int idLivro) {
            this.idLivro = idLivro;
            InitializeComponent();
        }
        private void EmprestimoBuscarExemplarView_Load(object sender, EventArgs e) {
            this.menuControl1.setPanel(pnltotal);

            List<ExemplarModel> lista = controller.ListarTodosExemplares(idLivro);
            popular(lista);
        }
        protected override void OnActivated(EventArgs e) {
            List<ExemplarModel> lista = controller.ListarTodosExemplares(idLivro);
            popular(lista);
        }
        private void popular(List<ExemplarModel> lista) {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Título", typeof(string));
            table.Columns.Add("Autor", typeof(string));
            table.Columns.Add("Edição", typeof(string));
            table.Columns.Add("Ano", typeof(string));
            table.Columns.Add("ISBN", typeof(string));
            table.Columns.Add("Editora", typeof(string));

            if (lista.Count > 0)
            {
                foreach (ExemplarModel exemplar in lista)
                {

                    table.Rows.Add(exemplar.getId(),
                                   exemplar.Titulo,
                                   exemplar.Nome_Autor,
                                   exemplar.Nome_Edicao,
                                   exemplar.AnoPublicacao,
                                   exemplar.ISBN,
                                   exemplar.Nome_Editora);
                }
                dtGridViewExemplar.DataSource = table;
                int index = dtGridViewExemplar.SelectedRows[0].Index;

                if (index >= 0)
                {
                    dtGridViewExemplar.Rows[index].Selected = false;
                }
            }
        }

        private void dtGridViewExemplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewExemplar.SelectedRows)
            {
                //    ListViewItem item = LvLivros.Items[LvLivros.FocusedItem.Index];
                //    if (int.Parse(item.SubItems[1].Text) == 0) {
                //        MessageBox.Show("Este livro está indisponível no momento.", "", MessageBoxButtons.OK);
                //    }

                int id = int.Parse(row.Cells[0].Value.ToString());
                string titulo = row.Cells[1].Value.ToString();
                string autor = row.Cells[2].Value.ToString();
                string edicao = row.Cells[3].Value.ToString();
                string ano = row.Cells[4].Value.ToString();
                string isbn = row.Cells[5].Value.ToString();
                string editora = row.Cells[6].Value.ToString();

                ExemplarModel exemplar = new ExemplarModel(id, titulo, autor, edicao, ano, isbn,editora);
                controller.InserirExemplarEmprestimo(exemplar);
                this.Close();
            }
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}