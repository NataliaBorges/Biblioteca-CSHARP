using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Biblioteca.View.Leitor {
    public partial class LeitorCadastrarView : Form {

        LeitorController controller = new LeitorController();
        DateTime data;

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
            String nome = tbNome.Text;
            String endereco = $"{tbRua.Text}, {tbNumero.Text}, {tbBairro.Text} - {tbCidade.Text}";
            String telefone = maskedTextBoxTelefone.Text;
            String cpf = maskedTextCPF.Text;
            DateTime data = this.CalendarLeitor.Value.Date;
            String email = tbEmail.Text;

            if(nome.Length <= 0) {
                MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                tbNome.Focus();
            }
            else if (tbRua.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar uma rua.", "Atenção", MessageBoxButtons.OK);
                tbRua.Focus();
            }
            else if (tbNumero.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar um numero.", "Atenção", MessageBoxButtons.OK);
                tbNumero.Focus();
            }
            else if (tbBairro.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar um bairro.", "Atenção", MessageBoxButtons.OK);
                tbBairro.Focus();
            }
            else if (telefone == "(  )     -") {
                MessageBox.Show("Você precisa digitar um telefone.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxTelefone.Focus();
            }
            else if (tbCidade.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar uma cidade.", "Atenção", MessageBoxButtons.OK);
                tbCidade.Focus();
            }
            else if (Validar.ValidaCpf(cpf) == false) {
                MessageBox.Show("Você precisa digitar um CPF válido.", "Atenção", MessageBoxButtons.OK);
            }
            else if (Validar.ValidarEmail(email) == false){
                MessageBox.Show("Você precisa digitar um email válido.", "Atenção", MessageBoxButtons.OK);
                tbEmail.Focus();
            }
            else {
                LeitorModel leitor = new LeitorModel(nome, data, telefone, cpf, endereco, email);
                if (controller.Insercao(leitor)) {
                    MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
                    ClearForm();
                }
                else {
                    MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

//        private void btnGerarContrato_Click(object sender, EventArgs e)
//        {
//            if (leitor != null && lista.Count > 0)
//            {
//                string nome_arquivo = "contrato_" + leitor.Nome + "_" + DateTime.Now.ToString("ddMMyyyyHm");
//                var doc = new Document(PageSize.A4);
//                string data_atual = DateTime.Now.ToString("ddMMyyyy");

//                if (!Directory.Exists(@"C:\Users\User\Desktop\MeuArquivo\contratos"))
//                {
//                    Directory.CreateDirectory(@"C:\Users\User\Desktop\MeuArquivo\contratos");
//                }

//                if (!Directory.Exists(@"C:\Users\User\Desktop\MeuArquivo\contratos\" + data_atual))
//                {
//                    Directory.CreateDirectory(@"C:\Users\User\Desktop\MeuArquivo\contratos\" + data_atual);
//                }

//                string local = string.Concat(@"C:\Users\User\Desktop\MeuArquivo\contratos\", data_atual, @"\", nome_arquivo, ".pdf");
//                PdfWriter.GetInstance(doc, new FileStream(local, FileMode.Create));
//                doc.Open();

//                iTextSharp.text.Font timesBold = new iTextSharp.text.Font(FontFamily.TIMES_ROMAN, 16f, BOLD);
//                iTextSharp.text.Font timesNormal = new iTextSharp.text.Font(FontFamily.TIMES_ROMAN, 12f, NORMAL);

//                Paragraph title = new Paragraph(new Chunk("CONTRATO DE EMPRÉSTIMO", timesBold));
//                title.Alignment = Element.ALIGN_CENTER;
//                doc.Add(title);

//                doc.Add(new Chunk("\n"));
//                doc.Add(new Chunk("\n"));
//                doc.Add(new Chunk("\n"));
//                doc.Add(new Chunk("\n"));
//                doc.Add(new Chunk("\n"));
//                doc.Add(new Chunk("\n"));
//                doc.Add(new Chunk("\n"));
//                doc.Add(new Chunk("\n"));

//                String exemplares = "";
//                foreach (ExemplarModel exemplar in lista)
//                {
//                    float valor = controller.PegarValorExemplarPorId(exemplar.getId());
//                    if (exemplar == lista[lista.Count - 1])
//                    {
//                        exemplares += exemplar.Titulo + " com o valor de R$ " + valor + "";
//                    }
//                    else
//                    {
//                        exemplares += exemplar.Titulo + " com o valor de R$ " + valor + ", ";
//                    }
//                }

//                Paragraph conteudo = new Paragraph(new Chunk(leitor.Nome + " portador do CPF " + leitor.CPF + ", residente no endereço " + leitor.Endereco + " confirma o empréstimo do(s) livro(s) " + exemplares + " e afirma arcar com o custo de reposição do(s) mesmo(s) em caso de perda total, averiguando o custo atual de cada um. O valor será entregue ao administrador da biblioteca.", timesNormal));
//                conteudo.Alignment = Element.ALIGN_JUSTIFIED;
//                doc.Add(conteudo);

//                doc.Add(new Chunk("\n"));
//                doc.Add(new Chunk("\n"));
//                doc.Add(new Chunk("\n"));
//                doc.Add(new Chunk("\n"));

//                Paragraph data = new Paragraph(new Chunk("Data: " + DateTime.Now.ToString("dd/MM/yyyy"), timesNormal));
//                data.Alignment = Element.ALIGN_RIGHT;
//                doc.Add(data);

//                doc.Add(new Chunk("\n"));
//                doc.Add(new Chunk("\n"));
//                doc.Add(new Chunk("\n"));
//                doc.Add(new Chunk("\n"));

//                Paragraph leitorNome = new Paragraph(new Chunk(leitor.Nome, timesNormal));
//                leitorNome.Alignment = Element.ALIGN_RIGHT;
//                doc.Add(leitorNome);
//                doc.Add(new Chunk("\n"));

//                Paragraph line = new Paragraph(new Chunk("_____________________________", timesNormal));
//                line.Alignment = Element.ALIGN_RIGHT;
//                doc.Add(line);

//                doc.Add(new Chunk("\n"));
//                doc.Add(new Chunk("\n"));

//                Paragraph bibliotecario = new Paragraph(new Chunk(singleton.getFuncionario().Nome_funcionario, timesNormal));
//                bibliotecario.Alignment = Element.ALIGN_RIGHT;
//                doc.Add(bibliotecario);

//                doc.Add(new Chunk("\n"));

//                doc.Add(line);


//                doc.Close();
//                var p = new Process();
//                p.StartInfo = new ProcessStartInfo(local)
//                {
//                    UseShellExecute = true
//                };
//                p.Start();

//                gerouContrato = true;
//            }
//            else
//            {
//                MessageBox.Show("É necessário selecionar o leitor e o exemplar.", "Atenção", MessageBoxButtons.OK);
//            }
//        }
//            catch (Exception e)
//            {
//                MessageBox.Show("Não foi possível gerar o contrato. Feche-o se estiver aberto.", "Atenção", MessageBoxButtons.OK);
//            }
//}
    }
}
