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
        ExemplarModel exemplar;
        public EmprestimoBuscarExemplarView(int idLivro) {
            this.idLivro = idLivro;
            InitializeComponent();
        }
        private void EmprestimoBuscarExemplarView_Load_1(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            List<ExemplarModel> lista = controller.ListarTodosExemplares(idLivro);
            popular(lista);
        }
        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
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
                if (int.Parse(row.Cells[0].Value.ToString()) == controller.BuscarPrimeiroExemplar(idLivro))
                {
                    MessageBox.Show("Este exemplar não pode ser retirado.", "Atenção", MessageBoxButtons.OK);
                } 
                else
                {
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    string titulo = row.Cells[1].Value.ToString();
                    string autor = row.Cells[2].Value.ToString();
                    string edicao = row.Cells[3].Value.ToString();
                    string ano = row.Cells[4].Value.ToString();
                    string isbn = row.Cells[5].Value.ToString();
                    string editora = row.Cells[6].Value.ToString();

                    ExemplarModel exemplar = new ExemplarModel(id, titulo, autor, edicao, ano, isbn, editora);
                    if (controller.InserirExemplarEmprestimo(exemplar) == false)
                    {
                        MessageBox.Show("Você já adicionou este exemplar.", "Atenção", MessageBoxButtons.OK);
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }

        private void buscar(List<ExemplarModel> lista)
        {

            if (lista.Count > 0)
            {
                lblNotFound.Visible = false;
                popular(lista);
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewExemplar.DataSource = null;
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            this.exemplar = null;
            String busca = tbBuscar.Text;

            if (tbBuscar.Text.Length > 0)
            {
                lblNotFound.Visible = false;

                if (rbCodigo.Checked)
                {
                    List<ExemplarModel> codigo = controller.BuscarExemplar(idLivro, busca, isCodigo: true);
                    buscar(codigo);
                }
                else if (rbAno.Checked)
                {
                    List<ExemplarModel> ano = controller.BuscarExemplar(idLivro, busca, isAno: true);
                    buscar(ano);
                }
                else if (rbIsbn.Checked)
                {
                    List<ExemplarModel> isbn = controller.BuscarExemplar(idLivro, busca, isIsbn: true);
                    buscar(isbn);
                }
                else if (rbEdicao.Checked)
                {
                    List<ExemplarModel> edicao = controller.BuscarExemplar(idLivro, busca, isEdicao: true);
                    buscar(edicao);
                }
                else
                {
                    MessageBox.Show("Selecione um tipo de busca.", "Atenção", MessageBoxButtons.OK);
                    tbBuscar.Text = null;
                }
            }
            else if (tbBuscar.Text.Length == 0)
            {
                lblNotFound.Visible = false;
                dtGridViewExemplar.DataSource = null;
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewExemplar.DataSource = null;
            }
        }

        
    }
}