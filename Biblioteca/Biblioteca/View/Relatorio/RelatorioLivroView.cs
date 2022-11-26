using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;

namespace Biblioteca.View.Relatorio {
    public partial class RelatorioLivroView : Form {

        LivroController controller = new LivroController();
        public RelatorioLivroView() {
            InitializeComponent();
        }

        private void RelatórioLivroView_Load(object sender, EventArgs e) {
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
        }

        private void popular(List<LivroModel> lista) {
            //LvLivros.Items.Clear();
            //if (lista.Count > 0) {
            //    foreach (LivroModel livro in lista) {
            //        ListViewItem item = new ListViewItem(livro.getId().ToString());
            //        //item.SubItems.Add(livro.Nome);
            //        //item.SubItems.Add(livro.Autor);
            //        //item.SubItems.Add(livro.Editora);
            //        //item.SubItems.Add(livro.Edicao);
            //        //item.SubItems.Add(livro.AnoPublicacao);
            //        //item.SubItems.Add(livro.Id_emprestimo.ToString());

            //        LvLivros.Items.Add(item);
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e) {
            //DateTime inicio = DateTime.Parse(tbInicio.Text);
            //DateTime fim = DateTime.Parse(tbFim.Text);
            //List<LivroModel> lista = controller.Relatorio(inicio, fim);
            //popular(lista);
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
