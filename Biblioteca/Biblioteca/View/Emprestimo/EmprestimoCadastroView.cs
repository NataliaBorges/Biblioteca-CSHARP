using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.View.Emprestimo;
using Biblioteca.Util;

namespace Biblioteca.View.Emprestimo {
    public partial class EmprestimoCadastroView : Form {

        DateTime dataEmprestimo;
        DateTime dataDevolucao;
        EmprestimoController controller = new EmprestimoController();
        Singleton singleton = Singleton.GetInstancia();

        public EmprestimoCadastroView() {
            InitializeComponent();
        }

        private void calendarEmprestimo_DateChanged(object sender, DateRangeEventArgs e) {
            tbEmprestimo.Text = calendarEmprestimo.SelectionRange.Start.ToString("dd/MM/yyyy");
            int ano = int.Parse(calendarEmprestimo.SelectionRange.Start.ToString("yyyy"));
            int mes = int.Parse(calendarEmprestimo.SelectionRange.Start.ToString("MM"));
            int dia = int.Parse(calendarEmprestimo.SelectionRange.Start.ToString("dd"));
            dataEmprestimo = new DateTime(ano, mes, dia);
        }

        private void calendarDevolucao_DateChanged(object sender, DateRangeEventArgs e) {
            tbDevolucao.Text = calendarDevolucao.SelectionRange.Start.ToString("dd/MM/yyyy");
            int ano = int.Parse(calendarDevolucao.SelectionRange.Start.ToString("yyyy"));
            int mes = int.Parse(calendarDevolucao.SelectionRange.Start.ToString("MM"));
            int dia = int.Parse(calendarDevolucao.SelectionRange.Start.ToString("dd"));
            dataDevolucao = new DateTime(ano, mes, dia);
        }

        private void novaJanela(Form form) {
            Rectangle bounds = this.Bounds;
            form.SetBounds(bounds.X, bounds.Y, form.Bounds.Width, form.Bounds.Height);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(-2, 63);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            EmprestimoBuscarLivroView livros = new EmprestimoBuscarLivroView();
            novaJanela(livros);
        }

        private void EmprestimoCadastroView_Load(object sender, EventArgs e) {
            popularLivros(controller.PegarLivrosEmprestimo());
            popularLeitor(controller.PegarLeitorEmprestimo());
        }

        protected override void OnActivated(EventArgs e) {
            popularLivros(controller.PegarLivrosEmprestimo());
            popularLeitor(controller.PegarLeitorEmprestimo());
        }

        private void popularLivros(List<LivroModel> lista) {
            lvLivros.Items.Clear();
            if (lista.Count > 0) {
                foreach (LivroModel livro in lista) {
                    ListViewItem item = new ListViewItem(livro.getId().ToString());
                    item.SubItems.Add(livro.Nome);
                    item.SubItems.Add(livro.Autor);
                    item.SubItems.Add(livro.Fornecedor);
                    item.SubItems.Add(livro.Edicao);
                    item.SubItems.Add(livro.AnoPublicacao);
                    item.SubItems.Add(livro.DataAquisicao.ToString());

                    lvLivros.Items.Add(item);
                }
            }
        }

        private void popularLeitor(List<LeitorModel> lista) {
            lvLeitor.Items.Clear();
            if (lista.Count > 0) {
                foreach (LeitorModel leitor in lista) {
                    if (leitor != null) {
                        ListViewItem item = new ListViewItem(leitor.getId().ToString());
                        item.SubItems.Add(leitor.Nome);
                        item.SubItems.Add(leitor.DataNascimento.ToString());
                        item.SubItems.Add(leitor.Telefone);
                        item.SubItems.Add(leitor.CPF);
                        item.SubItems.Add(leitor.Endereco);

                        lvLeitor.Items.Add(item);
                    }
                }
            }
        }

        private void lvLivros_MouseClick(object sender, MouseEventArgs e) {
            ListViewItem item = lvLivros.Items[lvLivros.FocusedItem.Index];
            LivroModel livro = new LivroModel(
                int.Parse(item.SubItems[0].Text),
                item.SubItems[1].Text,
                item.SubItems[2].Text,
                item.SubItems[4].Text,
                item.SubItems[5].Text,
                DateTime.Parse(item.SubItems[6].Text),
                item.SubItems[3].Text
            );


            DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                controller.RemoverLivroEmprestimo(livro);
                popularLivros(controller.PegarLivrosEmprestimo());
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            EmprestimoBuscarLeitorView leitor = new EmprestimoBuscarLeitorView();
            novaJanela(leitor);
        }

        private void lvLeitor_MouseClick(object sender, MouseEventArgs e) {
            ListViewItem item = lvLeitor.Items[lvLeitor.FocusedItem.Index];
            LeitorModel leitor = new LeitorModel(
                int.Parse(item.SubItems[0].Text),
                item.SubItems[1].Text,
                DateTime.Parse(item.SubItems[2].Text),
                item.SubItems[3].Text,
                item.SubItems[4].Text,
                item.SubItems[5].Text
            );

            DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                controller.RemoverLeitorEmprestimo();
                popularLeitor(controller.PegarLeitorEmprestimo());
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            String emprestimo = tbEmprestimo.Text;
            String devolucao = tbDevolucao.Text;
            String obs = tbObs.Text;

            // Cadastra emprestimo
            controller.Insercao(emprestimo, devolucao, obs);

            // Pega o ID do emprestimo cadastrado
            int idEmprestimo = controller.BuscarUltimoEmprestimo();

            // Cadastra no Item_emprestimo cada livro relacionando com o emprestimo
            foreach (LivroModel livro in this.singleton.getLivros()) {
                controller.RelacionarLivrosEmprestimo(idEmprestimo, livro);
            }

            this.singleton.clearEmprestimo();

            MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
