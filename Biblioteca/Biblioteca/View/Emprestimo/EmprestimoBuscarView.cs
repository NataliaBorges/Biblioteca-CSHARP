using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;
using Biblioteca.View.Emprestimo;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Biblioteca.View.Emprestimo {
    public partial class EmprestimoBuscarView : Form {

        EmprestimoController controller = new EmprestimoController();
        EmprestimoPesquisaExemplarModel exemplarPesquisa;
        EmprestimoPesquisaLeitorModel leitorPesquisa;

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

            dtInicial.Value = (DateTime.UtcNow.ToLocalTime()).AddDays(-15);
        }

        private void popular(List<EmprestimoPesquisaExemplarModel> listaExemplar = null, List<EmprestimoPesquisaLeitorModel> listaLeitor = null) {
            DataTable table = new DataTable();

            if(rbCPF.Checked || rbLeitor.Checked)
            {
                table.Columns.Add("Leitor", typeof(string));
                table.Columns.Add("CPF", typeof(string));
                table.Columns.Add("Total", typeof(int));

                if (listaLeitor.Count > 0)
                {
                    foreach (EmprestimoPesquisaLeitorModel emprestimo in listaLeitor)
                    {
                        table.Rows.Add(emprestimo.Nome_Leitor, emprestimo.CPF, emprestimo.Total);
                    }
                    dtGridViewEmprestimo.DataSource = table;
                    int index = dtGridViewEmprestimo.SelectedRows[0].Index;

                    if (index >= 0)
                    {
                        dtGridViewEmprestimo.Rows[index].Selected = false;
                    }
                }
            }
            else
            {
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Status Empréstimo", typeof(string));
                table.Columns.Add("Título", typeof(string));
                table.Columns.Add("ISBN", typeof(string));
                table.Columns.Add("Leitor", typeof(string));
                table.Columns.Add("Funcionário", typeof(string));
                table.Columns.Add("Empréstimo", typeof(string));
                table.Columns.Add("Previsto", typeof(string));
                table.Columns.Add("Devolução", typeof(string));
                table.Columns.Add("Status Exemplar", typeof(string));

                if (listaExemplar.Count > 0)
                {
                    foreach (EmprestimoPesquisaExemplarModel emprestimo in listaExemplar)
                    {
                        String finalizado = "          -";
                        if (emprestimo.Data_finalizado.HasValue)
                        {
                            finalizado = emprestimo.Data_finalizado?.ToString("dd/MM/yyyy");
                        }
                        table.Rows.Add(emprestimo.ID_emprestimo,
                                        emprestimo.Status_Emprestimo,
                                        emprestimo.Nome_Livro,
                                        emprestimo.ISBN,
                                        emprestimo.Nome_Leitor,
                                        emprestimo.Nome_Funcionario,
                                        emprestimo.Data_emprestimo.ToString("dd/MM/yyyy"),
                                        emprestimo.Data_devolucao.ToString("dd/MM/yyyy"),
                                        finalizado,
                                        emprestimo.Status_Exemplar);
                    }
                    dtGridViewEmprestimo.DataSource = table;
                    int index = dtGridViewEmprestimo.SelectedRows[0].Index;

                    if (index >= 0)
                    {
                        dtGridViewEmprestimo.Rows[index].Selected = false;
                    }
                }
            }
        }

        private void dtGridViewEmprestimo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewRow row in dtGridViewEmprestimo.SelectedRows)
            {
                if(rbLeitor.Checked || rbCPF.Checked)
                {
                    string nome = row.Cells[0].Value.ToString();
                    string cpf = row.Cells[1].Value.ToString();
                    int total = int.Parse(row.Cells[2].Value.ToString());
                    leitorPesquisa = new EmprestimoPesquisaLeitorModel(nome, cpf, total);
                }
                else
                {
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    string statusEmprestimo = row.Cells[1].Value.ToString();
                    string livro = row.Cells[2].Value.ToString();
                    string ISBN = row.Cells[3].Value.ToString();
                    string leitor = row.Cells[4].Value.ToString();
                    string funcionario = row.Cells[5].Value.ToString();
                    DateTime emprestimo = DateTime.Parse(row.Cells[6].Value.ToString());
                    DateTime devolucao = DateTime.Parse(row.Cells[7].Value.ToString());
                    Nullable<DateTime> finalizado = null;
                    if (row.Cells[8].Value.ToString() != "          -")
                    {
                        finalizado = DateTime.Parse(row.Cells[8].Value.ToString());
                    }
                    string statusExemplar = row.Cells[9].Value.ToString();

                    exemplarPesquisa = new EmprestimoPesquisaExemplarModel(id, statusEmprestimo, livro, ISBN, leitor, funcionario, emprestimo, devolucao, finalizado, statusExemplar);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var doc = new Document(PageSize.A6);
            //    PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\User\Desktop\MeuArquivo\meuarquivo.pdf", FileMode.Create));
            //    doc.Open();
            //    doc.Add(new Paragraph("Hello word"));
            //    doc.Close();
            //    var p = new Process();
            //    p.StartInfo = new ProcessStartInfo(@"C:\Users\User\Desktop\MeuArquivo\meuarquivo.pdf")
            //    {
            //        UseShellExecute = true
            //    };
            //    p.Start();
            //}
            //catch(Exception)
            //{
            //    MessageBox.Show("Não foi possível gerar o relatório. Feche-o se estiver aberto.");
            //}

            EmprestimoVisualizarView emprestimoVisualizarView = new EmprestimoVisualizarView(exemplar: exemplarPesquisa, leitor: leitorPesquisa);
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

        private void buscar(List<EmprestimoPesquisaExemplarModel> listaExemplar = null, List<EmprestimoPesquisaLeitorModel> listaLeitor = null)
        {

            if (listaExemplar != null && listaExemplar.Count > 0 || listaLeitor != null && listaLeitor.Count > 0)
            {
                lblNotFound.Visible = false;
                popular(listaExemplar, listaLeitor);
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewEmprestimo.DataSource = null;
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            this.exemplarPesquisa = null;
            this.leitorPesquisa = null;
            String busca = tbBuscar.Text;

            if (busca.Length > 0)
            {
                lblNotFound.Visible = false;

                if(rbCodigo.Checked)
                {
                    List<EmprestimoPesquisaExemplarModel> lista = controller.BuscarExemplar(busca, dtInicial.Value, dtFinalizado.Value, cbStatusEmprestimo.Text, cbStatusExemplar.Text, isCodigo: true);
                    buscar(listaExemplar: lista);
                }

                if(rbLivro.Checked)
                {
                    List<EmprestimoPesquisaExemplarModel> lista = controller.BuscarExemplar(busca, dtInicial.Value, dtFinalizado.Value, cbStatusEmprestimo.Text, cbStatusExemplar.Text, isExemplar: true);
                    buscar(listaExemplar: lista);
                }

                if(rbISBN.Checked)
                {
                    List<EmprestimoPesquisaExemplarModel> lista = controller.BuscarExemplar(busca, dtInicial.Value, dtFinalizado.Value, cbStatusEmprestimo.Text, cbStatusExemplar.Text, isISBN: true);
                    buscar(listaExemplar: lista);
                }

                if (rbLeitor.Checked)
                {
                    List<EmprestimoPesquisaLeitorModel> lista = controller.BuscarLeitor(busca, dtInicial.Value, dtFinalizado.Value, cbStatusEmprestimo.Text, isLeitor: true);
                    buscar(listaLeitor: lista);
                }

                if (rbCPF.Checked)
                {
                    List<EmprestimoPesquisaLeitorModel> lista = controller.BuscarLeitor(busca, dtInicial.Value, dtFinalizado.Value, cbStatusEmprestimo.Text, isCPF: true);
                    buscar(listaLeitor: lista);
                }

                if (!rbCodigo.Checked && !rbLivro.Checked && !rbISBN.Checked && !rbLeitor.Checked && !rbCPF.Checked)
                {
                    MessageBox.Show("É necessário selecionar um tipo de busca.", "Atenção", MessageBoxButtons.OK);
                    tbBuscar.Text = null;
                    lblNotFound.Visible = false;
                    dtGridViewEmprestimo.DataSource = null;
                }
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

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            cbStatusExemplar.Enabled = true;
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void rbLivro_CheckedChanged(object sender, EventArgs e)
        {
            cbStatusExemplar.Enabled = true;
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void rbISBN_CheckedChanged(object sender, EventArgs e)
        {
            cbStatusExemplar.Enabled = true;
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            cbStatusExemplar.Enabled = false;
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void rbLeitor_CheckedChanged(object sender, EventArgs e)
        {
            cbStatusExemplar.Enabled = false;
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void dtInicial_ValueChanged(object sender, EventArgs e)
        {
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void dtFinalizado_ValueChanged(object sender, EventArgs e)
        {
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void cbStatusEmprestimo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void cbStatusExemplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }
    }
}
