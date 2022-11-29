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
using System.Windows.Forms.VisualStyles;
using Biblioteca.Util;

namespace Biblioteca.View.Reserva {
    public partial class ReservaBuscarView : Form {

        ReservaController controller = new ReservaController();
        ReservaPesquisaExemplarModel exemplarPesquisa;
        ReservaPesquisaLeitorModel leitorPesquisa;

        public ReservaBuscarView() {
            InitializeComponent();
        }

        private void EmpretimoBuscarView_Load(object sender, EventArgs e) {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            cbReserva.Text = "Todos";
            cbExemplar.Text = "Todos";

            dtInicial.Value = (DateTime.UtcNow.ToLocalTime()).AddDays(-30);
        }

        private void dtGridViewEmprestimo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewEmprestimo.SelectedRows)
            {
                if (rbLeitor.Checked || rbCPF.Checked)
                {
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    string nome = row.Cells[1].Value.ToString();
                    string cpf = row.Cells[2].Value.ToString();
                    int total = int.Parse(row.Cells[3].Value.ToString());
                    leitorPesquisa = new ReservaPesquisaLeitorModel(id, nome, cpf, total);
                    leitorPesquisa.Status_Reserva = cbReserva.Text;
                }
                else
                {
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    string statusReserva = row.Cells[1].Value.ToString();
                    string livro = row.Cells[2].Value.ToString();
                    string ISBN = row.Cells[3].Value.ToString();
                    string leitor = row.Cells[4].Value.ToString();
                    string funcionario = row.Cells[5].Value.ToString();
                    DateTime reserva = DateTime.Parse(row.Cells[6].Value.ToString());
                    DateTime pegarLivro = DateTime.Parse(row.Cells[7].Value.ToString());
                    Nullable<DateTime> finalizado = null;
                    if (row.Cells[8].Value.ToString() != "          -")
                    {
                        finalizado = DateTime.Parse(row.Cells[8].Value.ToString());
                    }
                    string statusExemplar = row.Cells[9].Value.ToString();

                    exemplarPesquisa = new ReservaPesquisaExemplarModel(id, statusReserva, livro, ISBN, leitor, funcionario, reserva, pegarLivro, finalizado, statusExemplar);
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if ((rbCPF.Checked || rbLeitor.Checked) && cbReserva.Text == "Todos")
            {
                MessageBox.Show("Você precisa selecionar um status de reserva diferente de \"Todos\".", "Atenção", MessageBoxButtons.OK);
            }
            else if (exemplarPesquisa != null || leitorPesquisa != null)
            {
                ReservaVisualizarView reservaVisualizarView = new ReservaVisualizarView(exemplar: exemplarPesquisa, leitor: leitorPesquisa);
                NovaJanela.novaJanela(reservaVisualizarView, Bounds);
            }
            else
            {
                MessageBox.Show("Você precisa selecionar uma reserva para visualizar.", "Atenção", MessageBoxButtons.OK);
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

        private void ReservaBuscarView_Activated(object sender, EventArgs e)
        {
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
            cbReserva.Text = "Todos";
            cbExemplar.Text = "Todos";
            rbCodigo.Checked = false;
            rbCPF.Checked = false;
            rbLeitor.Checked = false;
            rbLivro.Checked = false;
            rbISBN.Checked = false;
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            cbExemplar.Enabled = true;
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            cbExemplar.Enabled = false;
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void rbLivro_CheckedChanged(object sender, EventArgs e)
        {
            cbExemplar.Enabled = true;
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void rbLeitor_CheckedChanged(object sender, EventArgs e)
        {
            cbExemplar.Enabled = false;
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void rbISBN_CheckedChanged(object sender, EventArgs e)
        {
            cbExemplar.Enabled = true;
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void cbReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void cbExemplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void dtFinal_ValueChanged(object sender, EventArgs e)
        {
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void dtInicial_ValueChanged(object sender, EventArgs e)
        {
            lblNotFound.Visible = false;
            dtGridViewEmprestimo.DataSource = null;
            tbBuscar.Text = null;
        }

        private void popular(List<ReservaPesquisaExemplarModel> listaExemplar = null, List<ReservaPesquisaLeitorModel> listaLeitor = null)
        {
            DataTable table = new DataTable();

            if (rbCPF.Checked || rbLeitor.Checked)
            {
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Leitor", typeof(string));
                table.Columns.Add("CPF", typeof(string));
                table.Columns.Add("Total", typeof(int));

                if (listaLeitor.Count > 0)
                {
                    foreach (ReservaPesquisaLeitorModel reserva in listaLeitor)
                    {
                        table.Rows.Add(reserva.Id_Leitor, reserva.Nome_Leitor, reserva.CPF, reserva.Total);
                    }
                    dtGridViewEmprestimo.DataSource = table;
                    int index = dtGridViewEmprestimo.SelectedRows[0].Index;

                    if (index >= 0)
                    {
                        dtGridViewEmprestimo.Rows[index].Selected = false;
                    }
                }
            }
            else
            {
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Status Reserva", typeof(string));
                table.Columns.Add("Título", typeof(string));
                table.Columns.Add("ISBN", typeof(string));
                table.Columns.Add("Leitor", typeof(string));
                table.Columns.Add("Funcionário", typeof(string));
                table.Columns.Add("Reservado", typeof(string));
                table.Columns.Add("Previsto", typeof(string));
                table.Columns.Add("Retirado", typeof(string));
                table.Columns.Add("Status Exemplar", typeof(string));

                if (listaExemplar.Count > 0)
                {
                    foreach (ReservaPesquisaExemplarModel reserva in listaExemplar)
                    {
                        String finalizado = "          -";
                        if (reserva.Data_retirada.HasValue)
                        {
                            finalizado = reserva.Data_retirada?.ToString("dd/MM/yyyy");
                        }
                        table.Rows.Add(reserva.ID_reserva,
                                        reserva.Status_Reserva,
                                        reserva.Nome_Livro,
                                        reserva.ISBN,
                                        reserva.Nome_Leitor,
                                        reserva.Nome_Funcionario,
                                        reserva.Data_reserva.ToString("dd/MM/yyyy"),
                                        reserva.Data_prevista.ToString("dd/MM/yyyy"),
                                        finalizado,
                                        reserva.Status_Exemplar);
                    }
                    dtGridViewEmprestimo.DataSource = table;
                    int index = dtGridViewEmprestimo.SelectedRows[0].Index;
                    dtGridViewEmprestimo.Columns[0].Width = 50;
                    dtGridViewEmprestimo.Columns[1].Width = 150;
                    dtGridViewEmprestimo.Columns[9].Width = 150;

                    if (index >= 0)
                    {
                        dtGridViewEmprestimo.Rows[index].Selected = false;
                    }
                }
            }
        }

        private void buscar(List<ReservaPesquisaExemplarModel> listaExemplar = null, List<ReservaPesquisaLeitorModel> listaLeitor = null)
        {

            if (listaExemplar != null && listaExemplar.Count > 0 || listaLeitor != null && listaLeitor.Count > 0)
            {
                lblNotFound.Visible = false;
                popular(listaExemplar, listaLeitor);
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewEmprestimo.DataSource = null;
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            this.exemplarPesquisa = null;
            this.leitorPesquisa = null;
            String busca = tbBuscar.Text;

            if (busca.Length > 0)
            {
                lblNotFound.Visible = false;

                if (rbCodigo.Checked)
                {
                    List<ReservaPesquisaExemplarModel> lista = controller.BuscarExemplarVisualizar(busca, dtInicial.Value, dtFinal.Value, cbReserva.Text, cbExemplar.Text, isCodigo: true);
                    buscar(listaExemplar: lista);
                }

                if (rbLivro.Checked)
                {
                    List<ReservaPesquisaExemplarModel> lista = controller.BuscarExemplarVisualizar(busca, dtInicial.Value, dtFinal.Value, cbReserva.Text, cbExemplar.Text, isExemplar: true);
                    buscar(listaExemplar: lista);
                }

                if (rbISBN.Checked)
                {
                    List<ReservaPesquisaExemplarModel> lista = controller.BuscarExemplarVisualizar(busca, dtInicial.Value, dtFinal.Value, cbReserva.Text, cbExemplar.Text, isISBN: true);
                    buscar(listaExemplar: lista);
                }

                if (rbLeitor.Checked)
                {
                    List<ReservaPesquisaLeitorModel> lista = controller.BuscarLeitorVisualizar(busca, dtInicial.Value, dtFinal.Value, cbReserva.Text, isLeitor: true);
                    buscar(listaLeitor: lista);
                }

                if (rbCPF.Checked)
                {
                    List<ReservaPesquisaLeitorModel> lista = controller.BuscarLeitorVisualizar(busca, dtInicial.Value, dtFinal.Value, cbReserva.Text, isCPF: true);
                    buscar(listaLeitor: lista);
                }

                if (!rbCodigo.Checked && !rbLivro.Checked && !rbISBN.Checked && !rbLeitor.Checked && !rbCPF.Checked)
                {
                    MessageBox.Show("É necessário selecionar um tipo de busca.", "Atenção", MessageBoxButtons.OK);
                    tbBuscar.Text = null;
                    lblNotFound.Visible = false;
                    dtGridViewEmprestimo.DataSource = null;
                }
            }
            else if (tbBuscar.Text.Length == 0)
            {
                lblNotFound.Visible = false;
                dtGridViewEmprestimo.DataSource = null;
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewEmprestimo.DataSource = null;
            }
        }
    }
}
