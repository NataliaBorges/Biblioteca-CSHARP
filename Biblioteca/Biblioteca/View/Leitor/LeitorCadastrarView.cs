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
using Biblioteca.Util;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static iTextSharp.text.Font;

namespace Biblioteca.View.Leitor {
    public partial class LeitorCadastrarView : Form {

        LeitorController controller = new LeitorController();
        DateTime data;
        bool gerouContrato = false;
        Singleton singleton = Singleton.GetInstancia();

        public LeitorCadastrarView() {
            InitializeComponent();
        }
        private void LeitorCadastrarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);
        }
        private void ClearForm() {
            this.tbNome.Clear();
            this.tbRua.Clear();
            this.tbNumero.Clear();
            this.tbBairro.Clear();
            this.tbCidade.Clear();
            this.maskedTextBoxTelefone.Clear();
            this.maskedTextCPF.Clear();
            this.CalendarLeitor.Controls.Clear();
            this.tbEmail.Clear();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (gerouContrato == false)
            {
                MessageBox.Show("Você precisa gerar o contrato antes de salvar.", "Atenção", MessageBoxButtons.OK);
            }
            else
            {
                String nome = tbNome.Text;
                String endereco = $"{tbRua.Text}, {tbNumero.Text}, {tbBairro.Text} - {tbCidade.Text}";
                String telefone = maskedTextBoxTelefone.Text;
                String cpf = maskedTextCPF.Text;
                DateTime data = this.CalendarLeitor.Value.Date;
                String email = tbEmail.Text;
                int years = DateTime.Now.Year - data.Year;

                if (years < 18)
                {
                    MessageBox.Show("Leitor não pode ter menos de 18 anos.", "Atenção", MessageBoxButtons.OK);
                }
                else if (nome.Length <= 0)
                {
                    MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                    tbNome.Focus();
                }
                else if (tbRua.Text.Length <= 0)
                {
                    MessageBox.Show("Você precisa digitar uma rua.", "Atenção", MessageBoxButtons.OK);
                    tbRua.Focus();
                }
                else if (tbNumero.Text.Length <= 0)
                {
                    MessageBox.Show("Você precisa digitar um numero.", "Atenção", MessageBoxButtons.OK);
                    tbNumero.Focus();
                }
                else if (tbBairro.Text.Length <= 0)
                {
                    MessageBox.Show("Você precisa digitar um bairro.", "Atenção", MessageBoxButtons.OK);
                    tbBairro.Focus();
                }
                else if (telefone == "(  )     -")
                {
                    MessageBox.Show("Você precisa digitar um telefone.", "Atenção", MessageBoxButtons.OK);
                    maskedTextBoxTelefone.Focus();
                }
                else if (tbCidade.Text.Length <= 0)
                {
                    MessageBox.Show("Você precisa digitar uma cidade.", "Atenção", MessageBoxButtons.OK);
                    tbCidade.Focus();
                }
                else if (Validar.ValidaCpf(cpf) == false)
                {
                    MessageBox.Show("Você precisa digitar um CPF válido.", "Atenção", MessageBoxButtons.OK);
                }
                else if (Validar.ValidarEmail(email) == false)
                {
                    MessageBox.Show("Você precisa digitar um email válido.", "Atenção", MessageBoxButtons.OK);
                    tbEmail.Focus();
                }
                else
                {
                    LeitorModel leitor = new LeitorModel(nome, data, telefone, cpf, endereco, email);
                    if (controller.Insercao(leitor))
                    {
                        MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PrincipalTelaView telaPrincipal = new PrincipalTelaView();
                NovaJanela.novaJanela(telaPrincipal, this.Bounds);
                this.Close();
            }
        }

        private void btnGerarContrato_Click(object sender, EventArgs e)
        {
            String nome = tbNome.Text;
            String endereco = $"{tbRua.Text}, {tbNumero.Text}, {tbBairro.Text} - {tbCidade.Text}";
            String telefone = maskedTextBoxTelefone.Text;
            String cpf = maskedTextCPF.Text;
            DateTime data = this.CalendarLeitor.Value.Date;
            String email = tbEmail.Text;

            if (nome.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                tbNome.Focus();
            }
            else if (tbRua.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar uma rua.", "Atenção", MessageBoxButtons.OK);
                tbRua.Focus();
            }
            else if (tbNumero.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um numero.", "Atenção", MessageBoxButtons.OK);
                tbNumero.Focus();
            }
            else if (tbBairro.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um bairro.", "Atenção", MessageBoxButtons.OK);
                tbBairro.Focus();
            }
            else if (telefone == "(  )     -")
            {
                MessageBox.Show("Você precisa digitar um telefone.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxTelefone.Focus();
            }
            else if (tbCidade.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar uma cidade.", "Atenção", MessageBoxButtons.OK);
                tbCidade.Focus();
            }
            else if (Validar.ValidaCpf(cpf) == false)
            {
                MessageBox.Show("Você precisa digitar um CPF válido.", "Atenção", MessageBoxButtons.OK);
            }
            else if (Validar.ValidarEmail(email) == false)
            {
                MessageBox.Show("Você precisa digitar um email válido.", "Atenção", MessageBoxButtons.OK);
                tbEmail.Focus();
            }
            else
            {
                LeitorModel leitor = new LeitorModel(nome, data, telefone, cpf, endereco, email);
                try
                {
                    string nome_arquivo = "contrato_" + leitor.Nome + "_" + DateTime.Now.ToString("ddMMyyyyHm");
                    var doc = new Document(PageSize.A4);
                    string data_atual = DateTime.Now.ToString("ddMMyyyy");

                    if (!Directory.Exists(@"C:\Users\User\Desktop\MeuArquivo\contratos"))
                    {
                        Directory.CreateDirectory(@"C:\Users\User\Desktop\MeuArquivo\contratos");
                    }

                    if (!Directory.Exists(@"C:\Users\User\Desktop\MeuArquivo\contratos\" + data_atual))
                    {
                        Directory.CreateDirectory(@"C:\Users\User\Desktop\MeuArquivo\contratos\" + data_atual);
                    }

                    string local = string.Concat(@"C:\Users\User\Desktop\MeuArquivo\contratos\", data_atual, @"\", nome_arquivo, ".pdf");
                    PdfWriter.GetInstance(doc, new FileStream(local, FileMode.Create));
                    doc.Open();

                    Font timesBold = new Font(FontFamily.TIMES_ROMAN, 16f, BOLD);
                    Font timesNormal = new Font(FontFamily.TIMES_ROMAN, 12f, NORMAL);

                    Paragraph title = new Paragraph(new Chunk("CONTRATO COM LEITOR", timesBold));
                    title.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title);

                    doc.Add(new Chunk("\n"));

                    string conteudo = leitor.Nome + " portador do CPF " + leitor.CPF + ", residente no endereço " + leitor.Endereco + ", afirma estar ciente que:";

                    Paragraph conteudoParagraph = new Paragraph(new Chunk(conteudo, timesNormal));
                    conteudoParagraph.Alignment = Element.ALIGN_JUSTIFIED;
                    doc.Add(conteudoParagraph);

                    doc.Add(new Chunk("\n"));

                    Paragraph conteudo2 = new Paragraph(new Chunk("- Os empréstimos terão a duração de no máximo 14 dias.", timesNormal));
                    conteudo2.Alignment = Element.ALIGN_JUSTIFIED;
                    doc.Add(conteudo2);

                    doc.Add(new Chunk("\n"));

                    Paragraph conteudo3 = new Paragraph(new Chunk("- Para cada dia de atraso na devolução, serão aplicados 2 dias de punição, por livro.", timesNormal));
                    conteudo3.Alignment = Element.ALIGN_JUSTIFIED;
                    doc.Add(conteudo3);

                    doc.Add(new Chunk("\n"));

                    Paragraph conteudo4 = new Paragraph(new Chunk("- Se o livro não for devolvido, ou for devolvido estragado, ele terá que arcar com o custo de reposição.", timesNormal));
                    conteudo4.Alignment = Element.ALIGN_JUSTIFIED;
                    doc.Add(conteudo4);

                    doc.Add(new Chunk("\n"));

                    Paragraph conteudo5 = new Paragraph(new Chunk("- Ele poderá emprestar no máximo 5 livros por vez.", timesNormal));
                    conteudo5.Alignment = Element.ALIGN_JUSTIFIED;
                    doc.Add(conteudo5);

                    doc.Add(new Chunk("\n"));

                    Paragraph conteudo6 = new Paragraph(new Chunk("- As reservas poderão ser feitas com o prazo máximo de 30 dias.", timesNormal));
                    conteudo6.Alignment = Element.ALIGN_JUSTIFIED;
                    doc.Add(conteudo6);

                    doc.Add(new Chunk("\n"));

                    Paragraph conteudo7 = new Paragraph(new Chunk("- Se o leitor não retirar o livro na data certa, ele sofrerá a punição de 2 dias por dia de atraso, por livro.", timesNormal));
                    conteudo7.Alignment = Element.ALIGN_JUSTIFIED;
                    doc.Add(conteudo7);

                    doc.Add(new Chunk("\n"));

                    Paragraph dataAtual = new Paragraph(new Chunk("Data: " + DateTime.Now.ToString("dd/MM/yyyy"), timesNormal));
                    dataAtual.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(dataAtual);

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
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível gerar o contrato. Feche-o se estiver aberto.", "Atenção", MessageBoxButtons.OK);
                }
            }
        }
    }
}
