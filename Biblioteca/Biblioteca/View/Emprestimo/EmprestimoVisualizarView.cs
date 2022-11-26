using Biblioteca.Controller;
using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Emprestimo
{
    public partial class EmprestimoVisualizarView : Form
    {
        EmprestimoPesquisaExemplarModel exemplar;
        EmprestimoPesquisaLeitorModel leitor;
        EmprestimoController controller = new EmprestimoController();
        public EmprestimoVisualizarView(EmprestimoPesquisaExemplarModel exemplar = null, EmprestimoPesquisaLeitorModel leitor = null)
        {
            this.exemplar = exemplar;
            this.leitor = leitor;
            InitializeComponent();
        }

        private void EmprestimoVisualizarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            if(exemplar != null)
            {
                EmprestimoModel emprestimoModel = controller.BuscaEmprestimoPorId(exemplar.ID_emprestimo);
                popularLeitor(controller.BuscaLeitorEmprestimoPorId(emprestimoModel.IdLeitor));
                popular(controller.EmprestimoVisualizarPorId(idEmprestimo: exemplar.ID_emprestimo));
            }
            else
            {
                popularLeitor(controller.BuscaLeitorEmprestimoPorId(leitor.Id_Leitor));
                popular(controller.EmprestimoVisualizarPorId(idLeitor: leitor.Id_Leitor));
            }
        }

        private void popular(List<EmprestimoVisualizarModel> lista)
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Título", typeof(string));
            table.Columns.Add("ISBN", typeof(string));
            table.Columns.Add("Funcionário", typeof(string));
            table.Columns.Add("Empréstimo", typeof(string));
            table.Columns.Add("Previsto", typeof(string));
            table.Columns.Add("Devolução", typeof(string));
            table.Columns.Add("Status Empréstimo", typeof(string));
            table.Columns.Add("Status Exemplar", typeof(string));

            if (lista.Count > 0)
            {
                foreach (EmprestimoVisualizarModel emprestimo in lista)
                {
                    //var dtStatusEmprestimo = new DataTable();
                    //dtStatusEmprestimo.Columns.Add();
                    //dtStatusEmprestimo.Rows.Add(emprestimo.Status_Emprestimo);
                    //dtStatusEmprestimo.Rows.Add("Em Aberto");
                    //dtStatusEmprestimo.Rows.Add("Pendente");
                    //dtStatusEmprestimo.Rows.Add("Finalizado");
                    //dtStatusEmprestimo.Rows.Add("Cancelado");

                    String finalizado = "          -";
                    if (emprestimo.Data_finalizado.HasValue)
                    {
                        finalizado = emprestimo.Data_finalizado?.ToString("dd/MM/yyyy");
                    }
                    table.Rows.Add(emprestimo.ID_emprestimo,
                                    emprestimo.Nome_Livro,
                                    emprestimo.ISBN,
                                    emprestimo.Nome_Funcionario,
                                    emprestimo.Data_emprestimo.ToString("dd/MM/yyyy"),
                                    emprestimo.Data_devolucao.ToString("dd/MM/yyyy"),
                                    finalizado,
                                    emprestimo.Status_Emprestimo,
                                    emprestimo.Status_Exemplar);
                }
                dtGridViewLivrosEmprestimo.DataSource = table;
                int index = dtGridViewLivrosEmprestimo.SelectedRows[0].Index;

                if (index >= 0)
                {
                    dtGridViewLivrosEmprestimo.Rows[index].Selected = false;
                }

                dtGridViewLivrosEmprestimo.Columns[0].Width = 50;
                dtGridViewLivrosEmprestimo.Columns[1].Width = 180;
                dtGridViewLivrosEmprestimo.Columns[7].Width = 200;
                dtGridViewLivrosEmprestimo.Columns[8].Width = 150;
            }
        }

        private void popularLeitor(LeitorModel leitor)
        {
            lbNome.Text = leitor.Nome;
            lbCPF.Text = leitor.CPF;
            lbTelefone.Text = leitor.Telefone;
            lbEmail.Text = leitor.Email;
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
