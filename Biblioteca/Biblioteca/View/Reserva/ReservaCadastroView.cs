using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.View.Reserva;
using Biblioteca.Util;

namespace Biblioteca.View.Reserva {
    public partial class ReservaCadastroView : Form {

        ReservaController controller = new ReservaController();
        Singleton singleton = Singleton.GetInstancia();

        public ReservaCadastroView() {
            InitializeComponent();
            lbNome.Text = "";
            lbTelefone.Text = "";
            lbCpf.Text = "";
            lbEmail.Text = "";
            dtGridViewExemplares.DataSource = null;
        }


        private void ReservaCadastroView_Load(object sender, EventArgs e) {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            this.singleton.clearReserva();
            popularExemplar(controller.PegarExemplarReserva());
            popularLeitor(controller.PegarLeitorReserva());
            CalendarRetirar.Value = (DateTime.UtcNow.ToLocalTime()).AddDays(30);
            this.dtGridViewExemplares.DefaultCellStyle.Font = new System.Drawing.Font("Book Antiqua", 12);
            this.dtGridViewExemplares.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Book Antiqua", 12);
        }

        private void popularExemplar(List<ExemplarModel> lista)
        {
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
        private void popularLeitor(LeitorModel leitor)
        {
            if (leitor != null)
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
            }
        }
        private void btnBuscarLeitor_Click(object sender, EventArgs e)
        {
            ReservaBuscarLeitorView leitor = new ReservaBuscarLeitorView();
            NovaJanela.novaJanela(leitor, this.Bounds);
        }

        private void btnBuscarLivros_Click(object sender, EventArgs e)
        {
            if (this.singleton.getLeitor() == null)
            {
                MessageBox.Show("Selecione um leitor antes.", "Atenção", MessageBoxButtons.OK);
            }
            else
            {
                if (controller.QuantidadeDeExemplar() < 5)
                {
                    ReservaBuscarLivroView livros = new ReservaBuscarLivroView();
                    NovaJanela.novaJanela(livros, this.Bounds);
                }
                else
                {
                    MessageBox.Show("Você só pode reservar 5 exemplares.", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DateTime reserva = CalendarReserva.Value.Date;
            DateTime retirar = CalendarRetirar.Value.Date;
            DateTime hojeMais30 = (DateTime.UtcNow.ToLocalTime()).AddDays(30);
            string mensagemError = "";

            foreach (ExemplarModel exemplar in this.singleton.getExemplar())
            {
                Nullable<DateTime> data = controller.BuscarDataPrevistaEmprestimoPorExemplar(exemplar.getId());
                if (data.HasValue)
                {
                    if(data.Value > retirar)
                    {
                        mensagemError += $"{data.Value.ToString("dd/MM/yyyy")} | {exemplar.Titulo}\n";
                    }
                }
            }

            if(mensagemError != "")
            {
                mensagemError = "Existe(m) exemplar(es) que está ou estão emprestado(s).\n\nO(s) exemplar(es) selecionado(s) só poderá ou poderão ser retirados a partir de:.\n\n" + mensagemError;
                MessageBox.Show(mensagemError, "Ateção", MessageBoxButtons.OK);
            }
            else
            {
                if ((DateTime.UtcNow.ToLocalTime()).Date != reserva.Date)
                {
                    MessageBox.Show("A data da reserva não pode ser diferente de hoje.", "Ateção", MessageBoxButtons.OK);
                }
                else if (retirar.Date > hojeMais30.Date)
                {
                    MessageBox.Show("Prazo máximo de retirada é de 30 dias.", "Ateção", MessageBoxButtons.OK);
                }
                else if (retirar < reserva)
                {
                    MessageBox.Show("Data de retirada não pode ser menor que a data de reserva.", "Ateção", MessageBoxButtons.OK);
                }
                else if (dtGridViewExemplares.Rows.Count <= 0)
                {
                    MessageBox.Show("É necessário selecionar ao menos um exemplar.", "Ateção", MessageBoxButtons.OK);
                }
                else if (controller.PegarLeitorReserva() == null)
                {
                    MessageBox.Show("É necessário selecionar um leitor.", "Ateção", MessageBoxButtons.OK);
                }
                else
                {
                    foreach (ExemplarModel exemplar in this.singleton.getExemplar())
                    {
                        if (controller.Insercao(reserva, retirar))
                        {
                            int idReserva = controller.BuscarUltimoReserva();
                            controller.RelacionarExemplarReserva(idReserva, exemplar);
                        }
                    }

                    this.singleton.clearReserva();
                    popularLeitor(null);
                    MessageBox.Show("Reservado com sucesso", "Parabéns", MessageBoxButtons.OK);
                    //this.Close();
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

        private void ReservaCadastroView_Activated(object sender, EventArgs e)
        {
            popularExemplar(controller.PegarExemplarReserva());
            popularLeitor(controller.PegarLeitorReserva());
            if (singleton.getAddExemplar() == true)
            {
                singleton.setAddExemplar(false);
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
                    controller.RemoverExemplarReserva(exemplar);
                    popularExemplar(controller.PegarExemplarReserva());
                }
            }
        }
    }
}
