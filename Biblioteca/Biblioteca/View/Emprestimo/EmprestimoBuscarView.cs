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
using Biblioteca.View.Emprestimo;

namespace Biblioteca.View.Emprestimo {
    public partial class EmprestimoBuscarView : Form {

        EmprestimoController controller = new EmprestimoController();
        EmprestimoPesquisaModel emprestimo;

        public EmprestimoBuscarView() {
            InitializeComponent();
        }

        private void EmpretimoBuscarView_Load(object sender, EventArgs e) {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            cbStatusEmprestimo.Text = "Todos";
            cbStatusExemplar.Text = "Todos";

            List<EmprestimoPesquisaModel> lista = controller.ListarTodosBusca();
            popular(lista);
        }

        private void popular(List<EmprestimoPesquisaModel> lista) {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Leitor", typeof(string));
            table.Columns.Add("Livro", typeof(string));
            table.Columns.Add("Funcionário", typeof(string));
            table.Columns.Add("Empréstimo", typeof(string));
            table.Columns.Add("Previsto", typeof(string));
            table.Columns.Add("Devolução", typeof(string));
            table.Columns.Add("Status", typeof(string));

            if (lista.Count > 0)
            {
                foreach (EmprestimoPesquisaModel emprestimo in lista)
                {
                    String finalizado = "          -";
                    if (emprestimo.Data_finalizado.HasValue)
                    {
                        finalizado = emprestimo.Data_finalizado?.ToString("dd/MM/yyyy");
                    }
                    table.Rows.Add(emprestimo.ID_emprestimo,
                                    emprestimo.Nome_Leitor,
                                    emprestimo.Nome_Livro,
                                    emprestimo.Nome_funcionario,
                                    emprestimo.Data_emprestimo.ToString("dd/MM/yyyy"),
                                    emprestimo.Data_devolucao.ToString("dd/MM/yyyy"),
                                    finalizado,
                                    emprestimo.Status);
                }
                dtGridViewEmprestimo.DataSource = table;
                int index = dtGridViewEmprestimo.SelectedRows[0].Index;

                if (index >= 0)
                {
                    dtGridViewEmprestimo.Rows[index].Selected = false;
                }
            }
        }

        private void dtGridViewEmprestimo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewRow row in dtGridViewEmprestimo.SelectedRows)
            {

                int id = int.Parse(row.Cells[0].Value.ToString());
                string leitor = row.Cells[1].Value.ToString();
                string livro = row.Cells[2].Value.ToString();
                string funcionario = row.Cells[3].Value.ToString();
                DateTime emprestimo = DateTime.Parse(row.Cells[4].Value.ToString());
                DateTime devolucao = DateTime.Parse(row.Cells[5].Value.ToString());
                Nullable<DateTime> finalizado = null;
                if (row.Cells[6].Value.ToString() != "          -")
                {
                    finalizado = DateTime.Parse(row.Cells[6].Value.ToString());
                }
                string status = row.Cells[7].Value.ToString();

                EmprestimoPesquisaModel pesquisa = new EmprestimoPesquisaModel(id,leitor,livro,funcionario,emprestimo,devolucao,finalizado, status);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EmprestimoVisualizarView emprestimoVisualizarView = new EmprestimoVisualizarView();
            NovaJanela.novaJanela(emprestimoVisualizarView, Bounds);
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buscar(List<EmprestimoPesquisaModel> lista)
        {

            if (lista.Count > 0)
            {
                lblNotFound.Visible = false;
                popular(lista);
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewEmprestimo.DataSource = null;
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            this.emprestimo = null;
            String busca = tbBuscar.Text;

            if (busca.Length > 0)
            {
                lblNotFound.Visible = false;

                List<EmprestimoPesquisaModel> lista = controller.Buscar(busca, isLivro: true);
                buscar(lista);
            }
            else if (tbBuscar.Text.Length == 0)
            {
                lblNotFound.Visible = false;
                dtGridViewEmprestimo.DataSource = null;
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewEmprestimo.DataSource = null;
            }
        }
    }
}
