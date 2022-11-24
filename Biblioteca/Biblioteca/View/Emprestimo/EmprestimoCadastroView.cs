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
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            this.singleton.clearEmprestimo();
            popularExemplar(controller.PegarExemplarEmprestimo());
            popularLeitor(controller.PegarLeitorEmprestimo());
            CalendarDevolucap.Value = (DateTime.UtcNow.ToLocalTime()).AddDays(15);
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
        }

        private void btnBuscarLeitor_Click(object sender, EventArgs e)
        {
            EmprestimoBuscarLeitorView leitor = new EmprestimoBuscarLeitorView();
            NovaJanela.novaJanela(leitor, this.Bounds);
        }

        private void btnBuscarLivros_Click(object sender, EventArgs e)
        {
            if(controller.QuantidadeDeExemplar() < 5)
            {
                EmprestimoBuscarLivroView livros = new EmprestimoBuscarLivroView();
                NovaJanela.novaJanela(livros, this.Bounds);
            }
            else
            {
                MessageBox.Show("Você só pode emprestar 5 exemplares.", "Atenção", MessageBoxButtons.OK);
            }
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DateTime emprestimo = CalendarEmprestimo.Value.Date;
            DateTime devolucao = CalendarDevolucap.Value.Date;
            DateTime hojeMais15 = (DateTime.UtcNow.ToLocalTime()).AddDays(15);
            String obs = TextObservacao.Text;

            if ((DateTime.UtcNow.ToLocalTime()).Date != emprestimo.Date)
            {
                MessageBox.Show("A data do empréstimo não pode ser diferente de hoje.", "Ateção", MessageBoxButtons.OK);
            }
            else if(devolucao.Date > hojeMais15.Date)
            {
                MessageBox.Show("Prazo máximo de devolução é de 15 dias.", "Ateção", MessageBoxButtons.OK);
            }
            else if (devolucao < emprestimo)
            {
                MessageBox.Show("Data de devolução não pode ser menor que a data de empréstimo.", "Ateção", MessageBoxButtons.OK);
            }
            else if (dtGridViewExemplares.Rows.Count <= 0)
            {
                MessageBox.Show("É necessário selecionar ao menos um exemplar.", "Ateção", MessageBoxButtons.OK);
            }
            else if (controller.PegarLeitorEmprestimo() == null)
            {
                MessageBox.Show("É necessário selecionar um leitor.", "Ateção", MessageBoxButtons.OK);
            }
            else
            {
                foreach (ExemplarModel exemplar in this.singleton.getExemplar())
                {
                    if(controller.Insercao(emprestimo, devolucao, obs))
                    {
                        int idEmprestimo = controller.BuscarUltimoEmprestimo();
                        controller.RelacionarLivrosEmprestimo(idEmprestimo, exemplar);
                    }
                }

                this.singleton.clearEmprestimo();

                MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
                this.Close();
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
