using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;

namespace Biblioteca.View.Reserva {
    public partial class ReservaBuscarLeitorView : Form {

        ReservaController controller = new ReservaController();
        LeitorModel leitor;

        public ReservaBuscarLeitorView() {
            InitializeComponent();
        }

        private void ReservaBuscarLeitorView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);
        }

        private void popular(List<LeitorModel> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Nascimento", typeof(DateTime));
            table.Columns.Add("CPF", typeof(string));
            table.Columns.Add("Telefone", typeof(string));
            table.Columns.Add("Endereço", typeof(string));
            table.Columns.Add("Email", typeof(string));

            if (lista.Count > 0)
            {
                foreach (LeitorModel leitor in lista)
                {

                    table.Rows.Add(leitor.getId(),
                                   leitor.Nome,
                                   leitor.DataNascimento,
                                   leitor.CPF,
                                   leitor.Telefone,
                                   leitor.Endereco,
                                   leitor.Email);
                }
                dtGridViewLeitor.DataSource = table;
                int index = dtGridViewLeitor.SelectedRows[0].Index;

                if (index >= 0)
                {
                    dtGridViewLeitor.Rows[index].Selected = false;
                }
            }
        }

        private void dtGridViewLeitor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewLeitor.SelectedRows)
            {

                int id = int.Parse(row.Cells[0].Value.ToString());
                string nome = row.Cells[1].Value.ToString();
                DateTime nascimento = DateTime.Parse(row.Cells[2].Value.ToString());
                string cpf = row.Cells[3].Value.ToString();
                string telefone = row.Cells[4].Value.ToString();
                string endereco = row.Cells[5].Value.ToString();
                string email = row.Cells[6].Value.ToString();

                LeitorModel leitor = new LeitorModel(id, nome, nascimento, telefone, cpf, endereco, email);

                int quantidadeExtraviado = controller.leitorPossuiExtraviadoPendente(leitor.getId());
                int quantidadeAtrasados = controller.leitorPossuiEmprestimoAtrasado(leitor.getId());
                int totalDias = 2 * controller.leitorPossuiMulta(leitor.getId());
                int quantidadeReservados = controller.quantidadeReservadosLeitor(leitor.getId());
                Nullable<DateTime> finalizado = controller.BuscarUltimoEmprestimoComAtraso(leitor.getId());

                int totalDiasReserva = 2 * controller.leitorPossuiMultaReserva(leitor.getId());
                Nullable<DateTime> finalizadoReserva = controller.BuscarUltimoEmprestimoComAtrasoReserva(leitor.getId());

                if (quantidadeExtraviado > 0)
                {
                    MessageBox.Show(leitor.Nome + ", possui " + quantidadeExtraviado + " exemplar(es) extraviado(s).\n\nNão podemos realizar a reserva.", "Atenção", MessageBoxButtons.OK);
                }
                else if (quantidadeAtrasados > 0)
                {
                    MessageBox.Show(leitor.Nome + ", possui " + quantidadeAtrasados + " exemplar(es) atrasado(s).\n\nNão podemos realizar a reserva.", "Atenção", MessageBoxButtons.OK);
                }
                else if (totalDias > 0 && finalizado.Value.AddDays(totalDias) > DateTime.Now)
                {
                    MessageBox.Show(leitor.Nome + ", está em punição.\n\nSó podera fazer reserva a partir de " + finalizado.Value.AddDays(totalDias).ToString("dd/MM/yyyy") + ".", "Atenção", MessageBoxButtons.OK);
                }
                else if (totalDiasReserva > 0 && finalizadoReserva.Value.AddDays(totalDias) > DateTime.Now)
                {
                    MessageBox.Show(leitor.Nome + ", está em punição por reserva atrasada.\n\nSó podera fazer reserva a partir de " + finalizadoReserva.Value.AddDays(totalDias).ToString("dd/MM/yyyy") + ".", "Atenção", MessageBoxButtons.OK);
                }
                else if (quantidadeReservados == 5)
                {
                    MessageBox.Show("O leitor só pode reservar 5 exemplares.", "Atenção", MessageBoxButtons.OK);
                }
                else
                {
                    controller.InserirLeitorReserva(leitor);
                    this.Close();
                }
            }
        }

        private void buscar(List<LeitorModel> lista)
        {
            if (lista.Count > 0)
            {
                lblNotFound.Visible = false;
                popular(lista);
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewLeitor.DataSource = null;
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            this.leitor = null;
            String busca = tbBuscar.Text;

            if (tbBuscar.Text.Length > 0)
            {
                lblNotFound.Visible = false;

                if (rbNome.Checked)
                {
                    List<LeitorModel> lista = controller.BuscarLeitor(busca, isNome: true);
                    buscar(lista);
                }
                else if (rbCPF.Checked)
                {
                    List<LeitorModel> lista = controller.BuscarLeitor(busca, isCPF: true);
                    buscar(lista);
                }
                else
                {
                    List<LeitorModel> lista = controller.BuscarLeitor(busca, isNome: true);
                    buscar(lista);
                }
            }
            else if (tbBuscar.Text.Length == 0)
            {
                lblNotFound.Visible = false;
                dtGridViewLeitor.DataSource = null;
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewLeitor.DataSource = null;
            }
        }

        private void rbNome_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewLeitor.DataSource = null;
        }

        private void rbCPF_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewLeitor.DataSource = null;
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
