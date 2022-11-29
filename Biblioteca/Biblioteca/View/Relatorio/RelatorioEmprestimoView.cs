using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static iTextSharp.text.Font;

namespace Biblioteca.View.Relatorio {
    public partial class RelatorioEmprestimoView : Form {

        EmprestimoController controller = new EmprestimoController();
        List<EmprestimoPesquisaExemplarModel> listaEmprestimoExemplar = null;
        List<EmprestimoPesquisaLeitorModel> listaEmprestimoLeitor = null;
        List<RelatorioEmprestimoModel> listaExemplar = null;

        public RelatorioEmprestimoView() {
            InitializeComponent();
        }

        private void RelatorioEmprestimoView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            cbStatusEmprestimo.Text = "Todos";
            cbStatusExemplarEmprestimo.Text = "Todos";
            dtInicialEmprestimo.Value = (DateTime.UtcNow.ToLocalTime()).AddDays(-30);
            buscarEmprestimo();

            cbStatusExemplar.Text = "Todos";
            cbExemplarExemplar.Text = "Todos";
            dtInicialExemplar.Value = (DateTime.UtcNow.ToLocalTime()).AddDays(-30);
            buscarExemplar();
        }

        private void popularEmprestimo(List<EmprestimoPesquisaExemplarModel> listaExemplar = null, List<EmprestimoPesquisaLeitorModel> listaLeitor = null)
        {
            DataTable table = new DataTable();

            if (rbLeitorEmprestimo.Checked)
            {
                listaEmprestimoLeitor = listaLeitor;
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Leitor", typeof(string));
                table.Columns.Add("CPF", typeof(string));
                table.Columns.Add("Total", typeof(int));

                if (listaLeitor.Count > 0)
                {
                    foreach (EmprestimoPesquisaLeitorModel emprestimo in listaLeitor)
                    {
                        table.Rows.Add(emprestimo.Id_Leitor, emprestimo.Nome_Leitor, emprestimo.CPF, emprestimo.Total);
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
                listaEmprestimoExemplar = listaExemplar;
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

                    dtGridViewEmprestimo.Columns[0].Width = 80;
                    dtGridViewEmprestimo.Columns[1].Width = 50;
                    dtGridViewEmprestimo.Columns[2].Width = 180;
                    dtGridViewEmprestimo.Columns[8].Width = 200;
                    dtGridViewEmprestimo.Columns[9].Width = 150;

                    if (index >= 0)
                    {
                        dtGridViewEmprestimo.Rows[index].Selected = false;
                    }
                }
            }
        }

        private void buscarEmprestimo()
        {
            listaEmprestimoExemplar = null;
            listaEmprestimoLeitor = null;
            String busca = tbBuscarEmprestimo.Text;

            if (busca.Length > 0)
            {
                if (rbCodigoEmprestimo.Checked)
                {
                    List<EmprestimoPesquisaExemplarModel> lista = controller.BuscarExemplar(busca, dtInicialEmprestimo.Value, dtFinalEmprestimo.Value, cbStatusEmprestimo.Text, cbStatusExemplarEmprestimo.Text, isCodigo: true);
                    if (lista.Count > 0)
                    {
                        popularEmprestimo(listaExemplar: lista);
                    }
                    else
                    {
                        dtGridViewEmprestimo.DataSource = null;
                    }
                }

                if (rbLeitorEmprestimo.Checked)
                {
                    List<EmprestimoPesquisaLeitorModel> lista = controller.BuscarLeitor(busca, dtInicialEmprestimo.Value, dtFinalEmprestimo.Value, cbStatusEmprestimo.Text, isLeitor: true);
                    if (lista.Count > 0)
                    {
                        popularEmprestimo(listaLeitor: lista);
                    }
                    else
                    {
                        dtGridViewEmprestimo.DataSource = null;
                    }
                }
            }
            else if (tbBuscarEmprestimo.Text.Length == 0)
            {
                dtGridViewEmprestimo.DataSource = null;

                if (!rbCodigoEmprestimo.Checked && !rbLeitorEmprestimo.Checked)
                {
                    List<EmprestimoPesquisaExemplarModel> lista = controller.BuscarExemplar("%", dtInicialEmprestimo.Value, dtFinalEmprestimo.Value, cbStatusEmprestimo.Text, cbStatusExemplarEmprestimo.Text, isCodigo: true);
                    if (lista.Count > 0)
                    {
                        popularEmprestimo(listaExemplar: lista);
                    }
                    else
                    {
                        dtGridViewEmprestimo.DataSource = null;
                    }
                }
            }
            else
            {
                dtGridViewEmprestimo.DataSource = null;
            }
        }

        private void tbBuscarEmprestimo_TextChanged(object sender, EventArgs e)
        {
            buscarEmprestimo();
        }

        private void rbLeitorEmprestimo_CheckedChanged(object sender, EventArgs e)
        {
            cbStatusExemplarEmprestimo.Enabled = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscarEmprestimo.Text = null;
            listaEmprestimoExemplar = null;
            listaEmprestimoLeitor = null;
        }

        private void rbCodigoEmprestimo_CheckedChanged(object sender, EventArgs e)
        {
            cbStatusExemplarEmprestimo.Enabled = true;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscarEmprestimo.Text = null;
            listaEmprestimoExemplar = null;
            listaEmprestimoLeitor = null;
        }

        private void cbStatusEmprestimo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtGridViewEmprestimo.DataSource = null;
            tbBuscarEmprestimo.Text = null;
            listaEmprestimoExemplar = null;
            listaEmprestimoLeitor = null;
        }

        private void cbStatusExemplarEmprestimo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtGridViewEmprestimo.DataSource = null;
            tbBuscarEmprestimo.Text = null;
            listaEmprestimoExemplar = null;
            listaEmprestimoLeitor = null;
        }

        private void btnImprimirEmprestimo_Click(object sender, EventArgs e)
        {
            try
            {
                string nome_arquivo = "relatorio_emprestimo_" + DateTime.Now.ToString("ddMMyyyyHm");
                var doc = new Document(PageSize.A4);
                doc.SetPageSize(PageSize.A4.Rotate());
                string data_atual = DateTime.Now.ToString("ddMMyyyy");

                if (!Directory.Exists(@"C:\Users\User\Desktop\MeuArquivo\relatorios"))
                {
                    Directory.CreateDirectory(@"C:\Users\User\Desktop\MeuArquivo\relatorios");
                }

                if (!Directory.Exists(@"C:\Users\User\Desktop\MeuArquivo\relatorios\" + data_atual))
                {
                    Directory.CreateDirectory(@"C:\Users\User\Desktop\MeuArquivo\relatorios\" + data_atual);
                }

                string local = string.Concat(@"C:\Users\User\Desktop\MeuArquivo\contratos\", data_atual, @"\", nome_arquivo, ".pdf");
                PdfWriter.GetInstance(doc, new FileStream(local, FileMode.Create));
                doc.Open();

                Font timesBold = new Font(FontFamily.TIMES_ROMAN, 16f, BOLD);
                Font timesNormal = new Font(FontFamily.TIMES_ROMAN, 10f, NORMAL);

                Paragraph title = new Paragraph(new Chunk("RELATÓRIO DE EMPRÉSTIMO", timesBold));
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                doc.Add(new Chunk("\n"));

                //List<EmprestimoPesquisaExemplarModel> listaEmprestimoExemplar = null;
                //List<EmprestimoPesquisaLeitorModel> listaEmprestimoLeitor = null;

                if (listaEmprestimoExemplar != null)
                {
                    PdfPTable table = new PdfPTable(10);

                    table.AddCell(new PdfPCell(new Paragraph($"ID", timesNormal)));
                    table.AddCell(new PdfPCell(new Paragraph($"Status Empréstimo", timesNormal)));
                    table.AddCell(new PdfPCell(new Paragraph($"Título", timesNormal)));
                    table.AddCell(new PdfPCell(new Paragraph($"ISBN", timesNormal)));
                    table.AddCell(new PdfPCell(new Paragraph($"Leitor", timesNormal)));
                    table.AddCell(new PdfPCell(new Paragraph($"Funcionário", timesNormal)));
                    table.AddCell(new PdfPCell(new Paragraph($"Empréstimo", timesNormal)));
                    table.AddCell(new PdfPCell(new Paragraph($"Previsto", timesNormal)));
                    table.AddCell(new PdfPCell(new Paragraph($"Devolução", timesNormal)));
                    table.AddCell(new PdfPCell(new Paragraph($"Status Exemplar", timesNormal)));

                    if(listaEmprestimoExemplar.Count > 0)
                    {
                        foreach (EmprestimoPesquisaExemplarModel emprestimo in listaEmprestimoExemplar)
                        {
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.ID_emprestimo}", timesNormal)));
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.Status_Emprestimo}", timesNormal)));
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.Nome_Livro}", timesNormal)));
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.ISBN}", timesNormal)));
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.Nome_Leitor}", timesNormal)));
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.Nome_Funcionario}", timesNormal)));
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.Data_emprestimo}", timesNormal)));
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.Data_devolucao}", timesNormal)));
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.Data_finalizado}", timesNormal)));
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.Status_Exemplar}", timesNormal)));
                        }
                    }
                    
                    doc.Add(table);
                }
                else
                {
                    PdfPTable table = new PdfPTable(4);

                    table.AddCell(new PdfPCell(new Paragraph($"ID", timesNormal)));
                    table.AddCell(new PdfPCell(new Paragraph($"Leitor", timesNormal)));
                    table.AddCell(new PdfPCell(new Paragraph($"CPF", timesNormal)));
                    table.AddCell(new PdfPCell(new Paragraph($"Total", timesNormal)));

                    if(listaEmprestimoLeitor != null && listaEmprestimoLeitor.Count > 0)
                    {
                        foreach (EmprestimoPesquisaLeitorModel emprestimo in listaEmprestimoLeitor)
                        {
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.Id_Leitor}", timesNormal)));
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.Nome_Leitor}", timesNormal)));
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.CPF}", timesNormal)));
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.Total}", timesNormal)));
                        }
                    }
                    
                    doc.Add(table);
                }

                doc.Add(new Chunk("\n"));

                Paragraph data = new Paragraph(new Chunk("Data: " + DateTime.Now.ToString("dd/MM/yyyy"), timesNormal));
                data.Alignment = Element.ALIGN_RIGHT;
                doc.Add(data);

                doc.Close();
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(local)
                {
                    UseShellExecute = true
                };
                p.Start();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível gerar o relatório. Feche-o se estiver aberto.", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void popularExemplar(List<RelatorioEmprestimoModel> lista)
        {
            listaExemplar = lista;
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Livro", typeof(string));
            table.Columns.Add("ISBN", typeof(string));
            table.Columns.Add("Leitor", typeof(string));
            table.Columns.Add("Total", typeof(int));

            if (lista.Count > 0)
            {
                foreach (RelatorioEmprestimoModel emprestimo in lista)
                {
                    table.Rows.Add(emprestimo.ID_exemplar, emprestimo.Nome_Livro, emprestimo.ISBN, emprestimo.Nome_Leitor, emprestimo.Total);
                }
                dtGridViewExemplar.DataSource = table;

                if(dtGridViewExemplar.SelectedRows.Count > 0)
                {
                    int index = dtGridViewExemplar.SelectedRows[0].Index;

                    if (index >= 0)
                    {
                        dtGridViewExemplar.Rows[index].Selected = false;
                    }
                }
            }
        }

        private void buscarExemplar()
        {
            listaEmprestimoExemplar = null;
            listaEmprestimoLeitor = null;
            String busca = tbBuscarExemplar.Text;

            if (busca.Length > 0)
            {
                if (rbCodigoExemplar.Checked)
                {
                    List<RelatorioEmprestimoModel> lista = controller.BuscarExemplarRelatorio(busca, dtInicialExemplar.Value, dtFinalExemplar.Value, cbStatusExemplar.Text, cbExemplarExemplar.Text, isCodigo: true);
                    if (lista.Count > 0)
                    {
                        popularExemplar(lista);
                    }
                    else
                    {
                        dtGridViewExemplar.DataSource = null;
                    }
                }

                if (rbLeitorExemplar.Checked)
                {
                    List<RelatorioEmprestimoModel> lista = controller.BuscarExemplarRelatorio(busca, dtInicialExemplar.Value, dtFinalExemplar.Value, cbStatusExemplar.Text, cbExemplarExemplar.Text, isLeitor: true);
                    if (lista.Count > 0)
                    {
                        popularExemplar(lista);
                    }
                    else
                    {
                        dtGridViewExemplar.DataSource = null;
                    }
                }

                if (rbExemplarExemplar.Checked)
                {
                    List<RelatorioEmprestimoModel> lista = controller.BuscarExemplarRelatorio(busca, dtInicialExemplar.Value, dtFinalExemplar.Value, cbStatusExemplar.Text, cbExemplarExemplar.Text, isExemplar: true);
                    if (lista.Count > 0)
                    {
                        popularExemplar(lista);
                    }
                    else
                    {
                        dtGridViewExemplar.DataSource = null;
                    }
                }
            }
            else if (tbBuscarEmprestimo.Text.Length == 0)
            {
                dtGridViewExemplar.DataSource = null;

                if (!rbCodigoExemplar.Checked && !rbLeitorExemplar.Checked && !rbExemplarExemplar.Checked)
                {
                    List<RelatorioEmprestimoModel> lista = controller.BuscarExemplarRelatorio("%", dtInicialExemplar.Value, dtFinalExemplar.Value, cbStatusExemplar.Text, cbExemplarExemplar.Text, isCodigo: true);
                    if (lista.Count > 0)
                    {
                        popularExemplar(lista);
                    }
                    else
                    {
                        dtGridViewExemplar.DataSource = null;
                    }
                }
            }
            else
            {
                dtGridViewExemplar.DataSource = null;
            }
        }

        private void rbLeitorExemplar_CheckedChanged(object sender, EventArgs e)
        {
            dtGridViewExemplar.DataSource = null;
            tbBuscarExemplar.Text = null;
            listaExemplar = null;
        }

        private void rbExemplarExemplar_CheckedChanged(object sender, EventArgs e)
        {
            dtGridViewExemplar.DataSource = null;
            tbBuscarExemplar.Text = null;
            listaExemplar = null;
        }

        private void rbCodigoExemplar_CheckedChanged(object sender, EventArgs e)
        {
            dtGridViewExemplar.DataSource = null;
            tbBuscarExemplar.Text = null;
            listaExemplar = null;
        }

        private void tbBuscarExemplar_TextChanged(object sender, EventArgs e)
        {
            buscarExemplar();
        }

        private void dtInicialExemplar_ValueChanged(object sender, EventArgs e)
        {
            dtGridViewExemplar.DataSource = null;
            tbBuscarExemplar.Text = null;
            listaExemplar = null;
        }

        private void dtFinalExemplar_ValueChanged(object sender, EventArgs e)
        {
            dtGridViewExemplar.DataSource = null;
            tbBuscarExemplar.Text = null;
            listaExemplar = null;
        }

        private void cbStatusExemplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtGridViewExemplar.DataSource = null;
            tbBuscarExemplar.Text = null;
            listaExemplar = null;
        }

        private void cbExemplarExemplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtGridViewExemplar.DataSource = null;
            tbBuscarExemplar.Text = null;
            listaExemplar = null;
        }

        private void btnImprimirExemplar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome_arquivo = "relatorio_exemplar_" + DateTime.Now.ToString("ddMMyyyyHm");
                var doc = new Document(PageSize.A4);
                doc.SetPageSize(PageSize.A4.Rotate());
                string data_atual = DateTime.Now.ToString("ddMMyyyy");

                if (!Directory.Exists(@"C:\Users\User\Desktop\MeuArquivo\relatorios"))
                {
                    Directory.CreateDirectory(@"C:\Users\User\Desktop\MeuArquivo\relatorios");
                }

                if (!Directory.Exists(@"C:\Users\User\Desktop\MeuArquivo\relatorios\" + data_atual))
                {
                    Directory.CreateDirectory(@"C:\Users\User\Desktop\MeuArquivo\relatorios\" + data_atual);
                }

                string local = string.Concat(@"C:\Users\User\Desktop\MeuArquivo\contratos\", data_atual, @"\", nome_arquivo, ".pdf");
                PdfWriter.GetInstance(doc, new FileStream(local, FileMode.Create));
                doc.Open();

                Font timesBold = new Font(FontFamily.TIMES_ROMAN, 16f, BOLD);
                Font timesNormal = new Font(FontFamily.TIMES_ROMAN, 10f, NORMAL);

                Paragraph title = new Paragraph(new Chunk("RELATÓRIO DE EXEMPLARES", timesBold));
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                doc.Add(new Chunk("\n"));

                // List<RelatorioEmprestimoModel> listaExemplar;

                if (listaExemplar != null)
                {
                    PdfPTable table = new PdfPTable(5);

                    table.AddCell(new PdfPCell(new Paragraph($"ID", timesNormal)));
                    table.AddCell(new PdfPCell(new Paragraph($"Titulo", timesNormal)));
                    table.AddCell(new PdfPCell(new Paragraph($"ISBN", timesNormal)));
                    table.AddCell(new PdfPCell(new Paragraph($"Leitor", timesNormal)));
                    table.AddCell(new PdfPCell(new Paragraph($"Total", timesNormal)));

                    if (listaExemplar.Count > 0)
                    {
                        foreach (RelatorioEmprestimoModel emprestimo in listaExemplar)
                        {
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.ID_exemplar}", timesNormal)));
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.Nome_Livro}", timesNormal)));
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.ISBN}", timesNormal)));
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.Nome_Leitor}", timesNormal)));
                            table.AddCell(new PdfPCell(new Paragraph($"{emprestimo.Total}", timesNormal)));
                        }
                    }

                    doc.Add(table);
                }

                doc.Add(new Chunk("\n"));

                Paragraph data = new Paragraph(new Chunk("Data: " + DateTime.Now.ToString("dd/MM/yyyy"), timesNormal));
                data.Alignment = Element.ALIGN_RIGHT;
                doc.Add(data);

                doc.Close();
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(local)
                {
                    UseShellExecute = true
                };
                p.Start();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível gerar o relatório. Feche-o se estiver aberto.", "Atenção", MessageBoxButtons.OK);
            }
        }
    }
}
