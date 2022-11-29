using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.View.Emprestimo;
using Biblioteca.Util;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using System.Diagnostics;
using static iTextSharp.text.Font;

namespace Biblioteca.View.Emprestimo {
    public partial class EmprestimoCadastroView : Form {

        EmprestimoController controller = new EmprestimoController();
        Singleton singleton = Singleton.GetInstancia();
        bool gerouContrato = false;
        bool emprestarDeReserva = false;

        public EmprestimoCadastroView(bool emprestarDeReserva = false) {
            this.emprestarDeReserva = emprestarDeReserva;
            InitializeComponent();
            lbNome.Text = "";
            lbTelefone.Text = "";
            lbCpf.Text = "";
            lbEmail.Text = "";
            dtGridViewExemplares.DataSource = null;
            TextObservacao.Text = "";
        }

        private void EmprestimoCadastroView_Load(object sender, EventArgs e) {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            if(!emprestarDeReserva)
            {
                this.singleton.clearEmprestimo();
            }
            popularExemplar(controller.PegarExemplarEmprestimo());
            popularLeitor(controller.PegarLeitorEmprestimo());
            CalendarDevolucap.Value = (DateTime.UtcNow.ToLocalTime()).AddDays(14);
            this.dtGridViewExemplares.DefaultCellStyle.Font = new System.Drawing.Font("Book Antiqua", 12);
            this.dtGridViewExemplares.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Book Antiqua", 12);
        }
        private void EmprestimoCadastroView_Activated(object sender, EventArgs e)
        {
            popularExemplar(controller.PegarExemplarEmprestimo());
            popularLeitor(controller.PegarLeitorEmprestimo());
            if (singleton.getAddExemplar() == true)
            {
                singleton.setAddExemplar(false);
            }
        }
        private void popularExemplar(List<ExemplarModel> lista) {
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
                dtGridViewExemplares.DataSource = table;

                dtGridViewExemplares.Columns[0].Width = 50;
                dtGridViewExemplares.Columns[1].Width = 200;

                int index = dtGridViewExemplares.SelectedRows[0].Index;

                if (index >= 0)
                {
                    dtGridViewExemplares.Rows[index].Selected = false;
                }
            }
            else
            {
                dtGridViewExemplares.DataSource = null;
            }
        }

        private void popularLeitor(LeitorModel leitor) {
            if(leitor != null)
            {
                lbNome.Text = leitor.Nome;
                lbTelefone.Text = leitor.Telefone;
                lbCpf.Text = leitor.CPF;
                lbEmail.Text = leitor.Email;
            }
            else
            {
                lbNome.Text = null;
                lbTelefone.Text = null;
                lbCpf.Text = null;
                lbEmail.Text = null;
                TextObservacao.Text = "";
            }
        }

        private void btnBuscarLeitor_Click(object sender, EventArgs e)
        {
            EmprestimoBuscarLeitorView leitor = new EmprestimoBuscarLeitorView();
            NovaJanela.novaJanela(leitor, this.Bounds);
        }

        private void btnBuscarLivros_Click(object sender, EventArgs e)
        {
            if(this.singleton.getLeitor() == null)
            {
                MessageBox.Show("Selecione um leitor antes.", "Atenção", MessageBoxButtons.OK);
            }
            else
            {
                if (controller.QuantidadeDeExemplar() < 5)
                {
                    EmprestimoBuscarLivroView livros = new EmprestimoBuscarLivroView();
                    NovaJanela.novaJanela(livros, this.Bounds);
                }
                else
                {
                    MessageBox.Show("Você só pode emprestar 5 exemplares.", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void btnGerarContrato_Click(object sender, EventArgs e)
        {
            gerarContrato();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(gerouContrato)
            {
                DateTime emprestimo = CalendarEmprestimo.Value.Date;
                DateTime devolucao = CalendarDevolucap.Value.Date;
                DateTime hojeMais14 = (DateTime.UtcNow.ToLocalTime()).AddDays(14);
                String obs = TextObservacao.Text;
                int quantidadeEmprestados = controller.quantidadeEmprestadosLeitor(this.singleton.getLeitor().getId());
                string mensagemErro = "";

                foreach (ExemplarModel exemplar in this.singleton.getExemplar())
                {
                    if (controller.ExemplarNaoFoiDevolvido(exemplar.getId()))
                    {
                        mensagemErro += $"{exemplar.Titulo}\n";
                    }
                }

                if (mensagemErro != "")
                {
                    MessageBox.Show("Os exemplares selecionados ainda não foram devolvidos:\n\n"+mensagemErro, "Atenção", MessageBoxButtons.OK);
                }
                else
                {
                    if ((DateTime.UtcNow.ToLocalTime()).Date != emprestimo.Date)
                    {
                        MessageBox.Show("A data do empréstimo não pode ser diferente de hoje.", "Atenção", MessageBoxButtons.OK);
                    }
                    else if (devolucao.Date > hojeMais14.Date)
                    {
                        MessageBox.Show("Prazo máximo de devolução é de 14 dias.", "Atenção", MessageBoxButtons.OK);
                    }
                    else if (devolucao < emprestimo)
                    {
                        MessageBox.Show("Data de devolução não pode ser menor que a data de empréstimo.", "Atenção", MessageBoxButtons.OK);
                    }
                    else if (dtGridViewExemplares.Rows.Count <= 0)
                    {
                        MessageBox.Show("É necessário selecionar ao menos um exemplar.", "Atenção", MessageBoxButtons.OK);
                    }
                    else if (controller.PegarLeitorEmprestimo() == null)
                    {
                        MessageBox.Show("É necessário selecionar um leitor.", "Atenção", MessageBoxButtons.OK);
                    }
                    else if ((controller.QuantidadeDeExemplar() + quantidadeEmprestados) > 5)
                    {
                        MessageBox.Show($"O leitor só pode emprestar 5 exemplares.\n\nEmpréstimos: {quantidadeEmprestados}\nTentando emprestar: {controller.QuantidadeDeExemplar()}", "Atenção", MessageBoxButtons.OK);
                    }
                    else
                    {
                        foreach (ExemplarModel exemplar in this.singleton.getExemplar())
                        {
                            if (controller.Insercao(emprestimo, devolucao, obs))
                            {
                                int idEmprestimo = controller.BuscarUltimoEmprestimo();
                                controller.RelacionarLivrosEmprestimo(idEmprestimo, exemplar);
                            }
                        }

                        this.singleton.clearEmprestimo();
                        popularLeitor(null);
                        MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
                        //this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Para salvar o empréstimo você precisa gerar o contrato.", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void gerarContrato()
        {
            try
            {
                LeitorModel leitor = controller.PegarLeitorEmprestimo();
                List<ExemplarModel> lista = controller.PegarExemplarEmprestimo();
                if (leitor != null && lista.Count > 0)
                {
                    string nome_arquivo = "contrato_" + leitor.Nome + "_" + DateTime.Now.ToString("ddMMyyyyHm");
                    var doc = new Document(PageSize.A4);
                    string data_atual = DateTime.Now.ToString("ddMMyyyy");

                    if (!Directory.Exists(@"C:\Users\User\Desktop\MeuArquivo\contratos"))
                    {
                        Directory.CreateDirectory(@"C:\Users\User\Desktop\MeuArquivo\contratos");
                    }

                    if (!Directory.Exists(@"C:\Users\User\Desktop\MeuArquivo\contratos\"+ data_atual))
                    {
                        Directory.CreateDirectory(@"C:\Users\User\Desktop\MeuArquivo\contratos\"+ data_atual);
                    }

                    string local = string.Concat(@"C:\Users\User\Desktop\MeuArquivo\contratos\", data_atual, @"\", nome_arquivo, ".pdf");
                    PdfWriter.GetInstance(doc, new FileStream(local, FileMode.Create));
                    doc.Open();

                    Font timesBold = new Font(FontFamily.TIMES_ROMAN, 16f, BOLD);
                    Font timesNormal = new Font(FontFamily.TIMES_ROMAN, 12f, NORMAL);

                    Paragraph title = new Paragraph(new Chunk("CONTRATO DE EMPRÉSTIMO", timesBold));
                    title.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title);

                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));

                    String exemplares = "";
                    foreach(ExemplarModel exemplar in lista)
                    {
                        float valor = controller.PegarValorExemplarPorId(exemplar.getId());
                        if (exemplar == lista[lista.Count-1])
                        {
                            exemplares += exemplar.Titulo + " com o valor de R$ " + valor + "";
                        }
                        else
                        {
                            exemplares += exemplar.Titulo + " com o valor de R$ " + valor + ", ";
                        }
                    }

                    Paragraph conteudo = new Paragraph(new Chunk(leitor.Nome + " portador do CPF " + leitor.CPF + ", residente no endereço " + leitor.Endereco + " confirma o empréstimo do(s) livro(s) " + exemplares + " e afirma arcar com o custo de reposição do(s) mesmo(s) em caso de perda total, averiguando o custo atual de cada um. O valor será entregue ao administrador da biblioteca.", timesNormal));
                    conteudo.Alignment = Element.ALIGN_JUSTIFIED;
                    doc.Add(conteudo);

                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));

                    Paragraph data = new Paragraph(new Chunk("Data: " + DateTime.Now.ToString("dd/MM/yyyy"), timesNormal));
                    data.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(data);

                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));

                    Paragraph leitorNome = new Paragraph(new Chunk(leitor.Nome, timesNormal));
                    leitorNome.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(leitorNome);
                    doc.Add(new Chunk("\n"));

                    Paragraph line = new Paragraph(new Chunk("_____________________________", timesNormal));
                    line.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(line);

                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));

                    Paragraph bibliotecario = new Paragraph(new Chunk(singleton.getFuncionario().Nome_funcionario, timesNormal));
                    bibliotecario.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(bibliotecario);

                    doc.Add(new Chunk("\n"));

                    doc.Add(line);


                    doc.Close();
                    var p = new Process();
                    p.StartInfo = new ProcessStartInfo(local)
                    {
                        UseShellExecute = true
                    };
                    p.Start();

                    gerouContrato = true;
                }
                else
                {
                    MessageBox.Show("É necessário selecionar o leitor e o exemplar.", "Atenção", MessageBoxButtons.OK);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível gerar o contrato. Feche-o se estiver aberto.", "Atenção", MessageBoxButtons.OK);
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

        private void dtGridViewExemplares_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewExemplares.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                string titulo = row.Cells[1].Value.ToString();
                string autor = row.Cells[2].Value.ToString();
                string edicao = row.Cells[3].Value.ToString();
                string ano = row.Cells[4].Value.ToString();
                string isbn = row.Cells[5].Value.ToString();
                string editora = row.Cells[6].Value.ToString();

                ExemplarModel exemplar = new ExemplarModel(id, titulo, autor, edicao, ano, isbn, editora);

                DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    controller.RemoverExemplarEmprestimo(exemplar);
                    popularExemplar(controller.PegarExemplarEmprestimo());
                }
            }
        }
        
    }
}
