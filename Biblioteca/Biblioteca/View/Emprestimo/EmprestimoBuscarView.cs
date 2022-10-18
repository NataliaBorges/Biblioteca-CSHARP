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

        public EmprestimoBuscarView() {
            InitializeComponent();
        }

        private void EmpretimoBuscarView_Load(object sender, EventArgs e) {
            this.menuControl1.setPanel(pnltotal);

            List<EmprestimoPesquisaModel> lista = controller.ListarTodosBusca();
            popular(lista);
        }

        private void popular(List<EmprestimoPesquisaModel> lista) {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Leitor", typeof(string));
            table.Columns.Add("Livro", typeof(string));
            table.Columns.Add("Funcionário", typeof(string));
            table.Columns.Add("Emprestimo", typeof(string));
            table.Columns.Add("Devolução", typeof(string));
            table.Columns.Add("Status", typeof(string));

            if (lista.Count > 0)
            {
                foreach (EmprestimoPesquisaModel emprestimo in lista)
                {

                    table.Rows.Add(emprestimo.ID_emprestimo,
                                    emprestimo.Nome_Leitor,
                                    emprestimo.Nome_Livro,
                                    emprestimo.Nome_funcionario,
                                    emprestimo.Data_emprestimo.ToString("dd/MM/yyyy"),
                                    emprestimo.Data_devolucao.ToString("dd/MM/yyyy"),
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
                string status = row.Cells[6].Value.ToString();

                EmprestimoPesquisaModel pesquisa = new EmprestimoPesquisaModel(id,leitor,livro,funcionario,emprestimo,devolucao,status);

                EmprestimoExcluirView editar = new EmprestimoExcluirView(pesquisa);
                NovaJanela.novaJanela(editar, this.Bounds);
            }
        }

        //private void btnSalvar_Click(object sender, EventArgs e) {
        //    String busca = tbBuscar.Text;

        //    if (rbLivro.Checked) {
        //        List<EmprestimoPesquisaModel> lista = controller.Buscar(busca, isLivro: true);
        //        popular(lista);
        //    }

        //    if (rbLeitor.Checked) {
        //        List<EmprestimoPesquisaModel> lista = controller.Buscar(busca, isLeitor: true);
        //        popular(lista);
        //    }
        //    if (rbCodigo.Checked) {
        //        List<EmprestimoPesquisaModel> lista = controller.Buscar(busca, isCodigo: true);
        //        popular(lista);
        //    }
        //}

        //private void lvEmprestimo_MouseClick(object sender, MouseEventArgs e) {
        //    ListViewItem item = lvEmprestimo.Items[lvEmprestimo.FocusedItem.Index];
        //    EmprestimoPesquisaModel pesquisa = new EmprestimoPesquisaModel(
        //            int.Parse(item.SubItems[0].Text),
        //            item.SubItems[1].Text,
        //            item.SubItems[2].Text,
        //            item.SubItems[3].Text,
        //            DateTime.Parse(item.SubItems[4].Text),
        //            DateTime.Parse(item.SubItems[5].Text),
        //            item.SubItems[6].Text
        //        );

        //    EmprestimoExcluirView editar = new EmprestimoExcluirView(pesquisa);
        //    NovaJanela.novaJanela(editar, this.Bounds);
        //}

        //private void btnExcluir_Click(object sender, EventArgs e) {
        //    this.Close();
        //}
    }
}
