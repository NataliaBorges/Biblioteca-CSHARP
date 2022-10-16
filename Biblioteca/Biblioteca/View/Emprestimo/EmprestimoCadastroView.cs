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

        //private void calendarEmprestimo_DateChanged(object sender, DateRangeEventArgs e) {
        //    tbEmprestimo.Text = calendarEmprestimo.SelectionRange.Start.ToString("dd/MM/yyyy");
        //    int ano = int.Parse(calendarEmprestimo.SelectionRange.Start.ToString("yyyy"));
        //    int mes = int.Parse(calendarEmprestimo.SelectionRange.Start.ToString("MM"));
        //    int dia = int.Parse(calendarEmprestimo.SelectionRange.Start.ToString("dd"));
        //    dataEmprestimo = new DateTime(ano, mes, dia);
        //}

        //private void calendarDevolucao_DateChanged(object sender, DateRangeEventArgs e) {
        //    tbDevolucao.Text = calendarDevolucao.SelectionRange.Start.ToString("dd/MM/yyyy");
        //    int ano = int.Parse(calendarDevolucao.SelectionRange.Start.ToString("yyyy"));
        //    int mes = int.Parse(calendarDevolucao.SelectionRange.Start.ToString("MM"));
        //    int dia = int.Parse(calendarDevolucao.SelectionRange.Start.ToString("dd"));
        //    dataDevolucao = new DateTime(ano, mes, dia);
        //}
        private void button2_Click(object sender, EventArgs e) {
            EmprestimoBuscarLivroView livros = new EmprestimoBuscarLivroView();
            NovaJanela.novaJanela(livros, this.Bounds);
        }

        private void EmprestimoCadastroView_Load(object sender, EventArgs e) {
            this.menuControl1.setPanel(pnltotal);

            popularExemplar(controller.PegarExemplarEmprestimo());
            popularLeitor(controller.PegarLeitorEmprestimo());
        }

        protected override void OnActivated(EventArgs e) {
            popularExemplar(controller.PegarExemplarEmprestimo());
            popularLeitor(controller.PegarLeitorEmprestimo());
            if (singleton.getAddAutor() == true) {
                singleton.setAddExemplar(false);
            }
        }

        private void popularExemplar(List<ExemplarModel> lista) {
            //lvLivros.Items.Clear();
            if (lista.Count > 0) {
                foreach (ExemplarModel exemplar in lista) {
                    ListViewItem item = new ListViewItem(exemplar.getId().ToString());
                    item.SubItems.Add(exemplar.Titulo);
                    //item.SubItems.Add(exemplar.Edicao);
                    item.SubItems.Add(exemplar.AnoPublicacao);
                    item.SubItems.Add(exemplar.ISBN);
                    item.SubItems.Add(exemplar.Aquisicao.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(exemplar.Nome_Autor);
                    item.SubItems.Add(exemplar.Nome_Editora);
                    item.SubItems.Add(exemplar.Nome_Genero);

                    //lvLivros.Items.Add(item);
                }
            }
        }

        private void popularLeitor(List<LeitorModel> lista) {
            //lvLeitor.Items.Clear();
            //if (lista.Count > 0) {
            //    foreach (LeitorModel leitor in lista) {
            //        if (leitor != null) {
            //            ListViewItem item = new ListViewItem(leitor.getId().ToString());
            //            item.SubItems.Add(leitor.Nome);
            //            item.SubItems.Add(leitor.DataNascimento.ToString());
            //            item.SubItems.Add(leitor.Telefone);
            //            item.SubItems.Add(leitor.CPF);
            //            item.SubItems.Add(leitor.Endereco);

            //            lvLeitor.Items.Add(item);
            //        }
            //    }
            }
        }

    //    private void lvLivros_MouseClick(object sender, MouseEventArgs e) {
    //        ListViewItem item = lvLivros.Items[lvLivros.FocusedItem.Index];
    //        ExemplarModel exempar = new ExemplarModel(
    //            int.Parse(item.SubItems[0].Text),
    //            item.SubItems[1].Text,
    //            item.SubItems[2].Text,
    //            item.SubItems[5].Text,
    //            item.SubItems[6].Text,
    //            item.SubItems[3].Text,
    //            item.SubItems[4].Text
    //        );


    //        DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
    //        if (dialogResult == DialogResult.Yes) {
    //            controller.RemoverExemplarEmprestimo(exempar);
    //            popularExemplar(controller.PegarExemplarEmprestimo());
    //        }
    //    }

    //    private void button1_Click(object sender, EventArgs e) {
    //        EmprestimoBuscarLeitorView leitor = new EmprestimoBuscarLeitorView();
    //        NovaJanela.novaJanela(leitor, this.Bounds);
    //    }

    //    private void lvLeitor_MouseClick(object sender, MouseEventArgs e) {
    //        ListViewItem item = lvLeitor.Items[lvLeitor.FocusedItem.Index];
    //        LeitorModel leitor = new LeitorModel(
    //            int.Parse(item.SubItems[0].Text),
    //            item.SubItems[1].Text,
    //            DateTime.Parse(item.SubItems[2].Text),
    //            item.SubItems[3].Text,
    //            item.SubItems[4].Text,
    //            item.SubItems[5].Text
    //        );

    //        DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
    //        if (dialogResult == DialogResult.Yes) {
    //            controller.RemoverLeitorEmprestimo();
    //            popularLeitor(controller.PegarLeitorEmprestimo());
    //        }
    //    }

    //    private void button3_Click(object sender, EventArgs e) {
    //        String emprestimo = tbEmprestimo.Text;
    //        String devolucao = tbDevolucao.Text;
    //        String obs = tbObs.Text;


    //        if (lvLivros.Items.Count > 5) {
    //            MessageBox.Show("Você só pode emprestar 5 obras", "Atenção", MessageBoxButtons.OK);
    //            lvLivros.Focus();
    //        }
    //        else if (lvLeitor.Items.Count > 1) {
    //            MessageBox.Show("Apenas 1 leitor por vez.", "Atenção", MessageBoxButtons.OK);
    //            lvLeitor.Focus();
    //        }
    //        else {
    //            // Cadastra emprestimo
    //            if (controller.Insercao(emprestimo, devolucao, obs)) {
    //                // Pega o ID do emprestimo cadastrado
    //                int idEmprestimo = controller.BuscarUltimoEmprestimo();

    //                // Cadastra no Item_emprestimo cada livro relacionando com o emprestimo
    //                foreach (ExemplarModel exemplar in this.singleton.getExemplar()) {
    //                    controller.RelacionarLivrosEmprestimo(idEmprestimo, exemplar);
    //                }

    //                this.singleton.clearEmprestimo();

    //                MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
    //                this.Close();
    //            } else {
    //                MessageBox.Show("Não foi possível realizar o empréstimo.", "Ateção", MessageBoxButtons.OK);
    //            }
    //        }
           
    //    }

    //    private void button4_Click(object sender, EventArgs e) {
    //        this.Close();
    //    }
    //}
}
