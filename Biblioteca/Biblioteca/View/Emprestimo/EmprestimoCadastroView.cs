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
            lbNome.Text = "";
            lbTelefone.Text = "";
            lbCpf.Text = "";
            lbEmail.Text = "";
            dtGridViewExemplares.DataSource = null;
            TextObservacao.Text = "";
        }

        private void EmprestimoCadastroView_Load(object sender, EventArgs e) {
            this.menuControl1.setPanel(pnltotal);

            popularExemplar(controller.PegarExemplarEmprestimo());
            popularLeitor(controller.PegarLeitorEmprestimo());
        }

        protected override void OnActivated(EventArgs e) {
            popularExemplar(controller.PegarExemplarEmprestimo());
            popularLeitor(controller.PegarLeitorEmprestimo());
            if (singleton.getAddExemplar() == true) {
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

                int index = dtGridViewExemplares.SelectedRows[0].Index;

                if (index >= 0)
                {
                    dtGridViewExemplares.Rows[index].Selected = false;
                }
            }
        }

        private void popularLeitor(List<LeitorModel> lista) {
            if(lista.Count > 0 && lista[0] != null)
            {
                LeitorModel leitor = lista[0];
                lbNome.Text = leitor.Nome;
                lbTelefone.Text = leitor.Telefone;
                lbCpf.Text = leitor.CPF;
                lbEmail.Text = leitor.Email;
            }
        }

        private void btnBuscarLeitor_Click(object sender, EventArgs e)
        {
            EmprestimoBuscarLeitorView leitor = new EmprestimoBuscarLeitorView();
            NovaJanela.novaJanela(leitor, this.Bounds);
        }

        private void btnBuscarLivros_Click(object sender, EventArgs e)
        {
            EmprestimoBuscarLivroView livros = new EmprestimoBuscarLivroView();
            NovaJanela.novaJanela(livros, this.Bounds);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DateTime emprestimo = CalendarEmprestimo.Value.Date;
            DateTime devolucao = CalendarDevolucap.Value.Date;
            String obs = TextObservacao.Text;


            //if (dtGridViewExemplares.DataSource. > 5)
            //{
            //    Messagebox.show("você só pode emprestar 5 obras", "atenção", messageboxbuttons.ok);
            //    lvlivros.focus();
            //}
            //else
            //{
            // Cadastra emprestimo
            if (controller.Insercao(emprestimo, devolucao, obs))
                {
                    // Pega o ID do emprestimo cadastrado
                    int idEmprestimo = controller.BuscarUltimoEmprestimo();

                    // Cadastra no Item_emprestimo cada livro relacionando com o emprestimo
                    foreach (ExemplarModel exemplar in this.singleton.getExemplar())
                    {
                        controller.RelacionarLivrosEmprestimo(idEmprestimo, exemplar);
                    }

                    this.singleton.clearEmprestimo();

                    MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o empréstimo.", "Ateção", MessageBoxButtons.OK);
                }
            //}
        }

        private void IcnBtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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

    //    private void button4_Click(object sender, EventArgs e) {
    //        this.Close();
    //    }
    //}
}
