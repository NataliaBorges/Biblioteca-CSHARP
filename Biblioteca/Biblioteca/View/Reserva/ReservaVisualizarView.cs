using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;
using Biblioteca.View.Emprestimo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Reserva
{
    public partial class ReservaVisualizarView : Form
    {
        ReservaPesquisaExemplarModel exemplar;
        ReservaPesquisaLeitorModel leitor;
        LeitorModel leitorTela;
        ReservaController controller = new ReservaController();
        List<int> listaItemId = new List<int>();
        public ReservaVisualizarView(ReservaPesquisaExemplarModel exemplar = null, ReservaPesquisaLeitorModel leitor = null)
        {
            this.exemplar = exemplar;
            this.leitor = leitor;
            InitializeComponent();
        }

        private void buscarDadosPopularTela(bool atualizado = false)
        {
            pnlPunicao.Visible = false;
            dtGridViewLivrosReserva.Columns.Clear();
            dtGridViewLivrosReserva.DataSource = null;
            if (exemplar != null)
            {
                ReservaModel reservaModel = controller.BuscaReservaPorId(exemplar.ID_reserva);
                popularLeitor(controller.BuscaLeitorReservaPorId(reservaModel.IdLeitor));
                popular(controller.ReservaVisualizarPorId(idReserva: exemplar.ID_reserva));
                punicaoLeitor(reservaModel.IdLeitor);
            }
            else
            {
                popularLeitor(controller.BuscaLeitorReservaPorId(leitor.Id_Leitor));
                if (atualizado == false)
                {
                    popular(controller.ReservaVisualizarPorId(idLeitor: leitor.Id_Leitor, status: leitor.Status_Reserva));
                }
                else
                {
                    popular(controller.ReservaVisualizarPorId(idLeitor: leitor.Id_Leitor, listaItemId: listaItemId));
                }
                punicaoLeitor(leitor.Id_Leitor);
            }

        }

        private void punicaoLeitor(int id)
        {
            LeitorModel leitor = controller.BuscaLeitorReservaPorId(id);
            int quantidadeExtraviado = controller.leitorPossuiExtraviadoPendente(id);
            int quantidadeAtrasados = controller.leitorPossuiEmprestimoAtrasado(id);
            int totalDias = 2 * controller.leitorPossuiMulta(id);
            Nullable<DateTime> finalizado = controller.BuscarUltimoEmprestimoComAtraso(id);
            int totalDiasReserva = 2 * controller.leitorPossuiMultaReserva(leitor.getId());
            Nullable<DateTime> finalizadoReserva = controller.BuscarUltimoEmprestimoComAtrasoReserva(leitor.getId());

            lbMensagem.MaximumSize = new Size(750, 0);
            lbMensagem.AutoSize = true;


            if (quantidadeExtraviado > 0)
            {
                pnlPunicao.Visible = true;
                lbMensagem.Text = leitor.Nome + " está impossibilitado(a) de realizar empréstimos até que a situação do(s) exemplar(es) extraviado(s) seja(m) regularizada(s).";
            }
            else if (quantidadeAtrasados > 0)
            {
                pnlPunicao.Visible = true;
                lbMensagem.Text = leitor.Nome + " não pode realizar empréstimo, pois possui " + quantidadeAtrasados + " emprestimo(s) não devolvido(s).";
            }
            else if (totalDias > 0 && finalizado.Value.AddDays(totalDias) > DateTime.Now)
            {
                pnlPunicao.Visible = true;
                lbMensagem.Text = leitor.Nome + " está com punição de " + totalDias + " dia(s) por atraso de devolução/devoluções de empréstimo(s).";
            }
            else if (totalDiasReserva > 0 && finalizadoReserva.Value.AddDays(totalDias) > DateTime.Now)
            {
                pnlPunicao.Visible = true;
                lbMensagem.Text = leitor.Nome + ", está em punição por reserva atrasada.\n\nSó podera fazer reserva a partir de " + finalizadoReserva.Value.AddDays(totalDias).ToString("dd/MM/yyyy") + ".";
            }
            else
            {
                pnlPunicao.Visible = false;
            }
        }

        private DataGridViewComboBoxColumn comboBoxColumnReserva()
        {
            DataTable dtStatusReserva = new DataTable();
            dtStatusReserva.Columns.Add("Status", typeof(string));
            dtStatusReserva.Rows.Add("Em Aberto");
            dtStatusReserva.Rows.Add("Cancelada");
            dtStatusReserva.Rows.Add("Finalizada");

            DataGridViewComboBoxColumn cbColumn = new DataGridViewComboBoxColumn();
            cbColumn.Name = "cbReserva";
            cbColumn.HeaderText = "Status Reserva";
            cbColumn.DataPropertyName = "Status_Reserva";
            cbColumn.ValueMember = "Status";
            cbColumn.DisplayMember = "Status";
            cbColumn.FlatStyle = FlatStyle.Flat;
            cbColumn.DataSource = dtStatusReserva;
            return cbColumn;
        }

        private DataGridViewComboBoxColumn comboBoxColumnExemplar()
        {
            DataTable dtStatusReserva = new DataTable();
            dtStatusReserva.Columns.Add("Status", typeof(string));
            dtStatusReserva.Rows.Add("Reservado");
            dtStatusReserva.Rows.Add("Disponível");
            dtStatusReserva.Rows.Add("Emprestado");

            DataGridViewComboBoxColumn cbColumn = new DataGridViewComboBoxColumn();
            cbColumn.Name = "cbExemplar";
            cbColumn.HeaderText = "Status Exemplar";
            cbColumn.DataPropertyName = "Status_Exemplar";
            cbColumn.ValueMember = "Status";
            cbColumn.DisplayMember = "Status";
            cbColumn.FlatStyle = FlatStyle.Flat;
            cbColumn.DataSource = dtStatusReserva;
            return cbColumn;
        }

        private void popular(List<ReservaVisualizarModel> lista)
        {
            listaItemId.Clear();

            dtGridViewLivrosReserva.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID", HeaderText = "ID", DataPropertyName = "ID_reserva", ReadOnly = true });
            dtGridViewLivrosReserva.Columns.Add(new DataGridViewTextBoxColumn { Name = "Título", HeaderText = "Título", DataPropertyName = "Nome_Livro", ReadOnly = true });
            dtGridViewLivrosReserva.Columns.Add(new DataGridViewTextBoxColumn { Name = "ISBN", HeaderText = "ISBN", DataPropertyName = "ISBN", ReadOnly = true });
            dtGridViewLivrosReserva.Columns.Add(new DataGridViewTextBoxColumn { Name = "Funcionário", HeaderText = "Funcionário", DataPropertyName = "Nome_Funcionario", ReadOnly = true });
            dtGridViewLivrosReserva.Columns.Add(new DataGridViewTextBoxColumn { Name = "Reserva", HeaderText = "Reserva", DataPropertyName = "Data_Reserva", ReadOnly = true });
            dtGridViewLivrosReserva.Columns.Add(new DataGridViewTextBoxColumn { Name = "Previsto", HeaderText = "Previsto", DataPropertyName = "Data_PegarLivro", ReadOnly = true });
            dtGridViewLivrosReserva.Columns.Add(new DataGridViewTextBoxColumn { Name = "Retirada", HeaderText = "Retirada", DataPropertyName = "Data_Retirada", ReadOnly = true });
            dtGridViewLivrosReserva.Columns.Add(comboBoxColumnReserva());
            dtGridViewLivrosReserva.Columns.Add(comboBoxColumnExemplar());

            if (lista.Count > 0)
            {

                foreach (ReservaVisualizarModel reserva in lista)
                {
                    listaItemId.Add(reserva.getItemReservaId());
                }

                dtGridViewLivrosReserva.DataSource = lista;

                int index = dtGridViewLivrosReserva.SelectedRows[0].Index;

                if (index >= 0)
                {
                    dtGridViewLivrosReserva.Rows[index].Selected = false;
                }

                dtGridViewLivrosReserva.Columns[0].Width = 50;
                dtGridViewLivrosReserva.Columns[1].Width = 180;
                dtGridViewLivrosReserva.Columns[7].Width = 200;
                dtGridViewLivrosReserva.Columns[8].Width = 150;
            }
        }

        private void popularLeitor(LeitorModel leitor)
        {
            leitorTela = leitor;
            lbNome.Text = leitor.Nome;
            lbCPF.Text = leitor.CPF;
            lbTelefone.Text = leitor.Telefone;
            lbEmail.Text = leitor.Email;
        }

        private void ReservaVisualizarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            buscarDadosPopularTela();
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dtGridViewLivrosReserva_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            String mensagemErro = "";
            List<ReservaVisualizarModel> reservas = new List<ReservaVisualizarModel>();
            foreach (DataGridViewRow row in dtGridViewLivrosReserva.Rows)
            {
                Nullable<DateTime> finalizado = null;
                if ($"{row.Cells["Retirada"].Value}" != "")
                {
                    finalizado = (DateTime)row.Cells["Retirada"].Value;
                }
                ReservaVisualizarModel reserva = new ReservaVisualizarModel(
                    (int)row.Cells["ID"].Value,
                    (String)row.Cells["Título"].Value,
                    (String)row.Cells["ISBN"].Value,
                    (String)row.Cells["Funcionário"].Value,
                    (DateTime)row.Cells["Reserva"].Value,
                    (DateTime)row.Cells["Previsto"].Value,
                    finalizado,
                    (String)row.Cells["cbReserva"].Value,
                    (String)row.Cells["cbExemplar"].Value
                );
                reserva.setItemReservaId(listaItemId[row.Index]);
                reservas.Add(reserva);

                if (reserva.Status_Reserva == "Em Aberto" && reserva.Status_Exemplar != "Reservado")
                {
                    mensagemErro += "Reserva ID: " + reserva.ID_reserva + ".\n";
                }

                else if (reserva.Status_Reserva == "Finalizada" && reserva.Status_Exemplar != "Emprestado")
                {
                    mensagemErro += "Reserva ID: " + reserva.ID_reserva + ".\n";
                }

                else if (reserva.Status_Reserva == "Cancelada" && reserva.Status_Exemplar != "Disponível")
                {
                    mensagemErro += "Reserva ID: " + reserva.ID_reserva + ".\n";
                }

            }

            if (!mensagemErro.Equals(""))
            {
                mensagemErro = "                                                 ERRO DE FLUXO\n\n" + mensagemErro;
                mensagemErro += "\nIMPORTANTE: Fluxo do status reserva e status exemplar incorretos.\nPor favor, verifique as instruções.";
                reservas.Clear();
                MessageBox.Show(mensagemErro, "Atenção", MessageBoxButtons.OK);
            }
            else
            {
                bool error = false;
                List<ReservaVisualizarModel> reservasFinalizadas = new List<ReservaVisualizarModel>();
                foreach (ReservaVisualizarModel reserva in reservas)
                {
                    if (controller.AtualizarStatusReserva(reserva))
                    {
                        if (!controller.AtualizarStatusExemplar(reserva))
                        {
                            error = true;
                        }
                        if(reserva.Status_Reserva == "Finalizada" && reserva.Status_Exemplar == "Emprestado")
                        {
                            reservasFinalizadas.Add(reserva);
                        }
                    }
                    else
                    {
                        error = true;
                    }
                }

                if (error)
                {
                    MessageBox.Show("Encontramos um problema ao atualizar uma reserva.", "Atenção", MessageBoxButtons.OK);
                }
                else
                {
                    string mensagemAtrasado = "";
                    foreach (ReservaVisualizarModel reserva in reservas)
                    {
                        if((DateTime.Now > reserva.Data_PegarLivro.AddDays(7)) && reserva.Status_Reserva == "Em Aberto")
                        {
                            mensagemAtrasado += $"{reserva.Nome_Livro}\n";
                        }
                    }

                    if(mensagemAtrasado != "")
                    {
                        MessageBox.Show("Não é possível atualizar o status, pois o(s) exemplar(es) está ou estão atrasado(s):\n\n"+mensagemAtrasado, "Atenção", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (reservasFinalizadas.Count > 0)
                        {
                            buscarDadosPopularTela(atualizado: true);
                            controller.InserirLeitorReserva(leitorTela);

                            string mensagem = "Você será redirecionado(a) para cadastro de empréstimo com os seguintes livros:\n\n";
                            foreach (ReservaVisualizarModel reserva in reservasFinalizadas)
                            {
                                mensagem += $"{reserva.Nome_Livro}\n";
                                controller.InserirExemplarReserva(controller.ListarExemplarPorIdItem(reserva.getItemReservaId()));
                            }

                            DialogResult dialogResult = MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK);
                            if (dialogResult == DialogResult.OK)
                            {
                                EmprestimoCadastroView emprestimo = new EmprestimoCadastroView(emprestarDeReserva: true);
                                NovaJanela.novaJanela(emprestimo, this.Bounds);
                            }
                        }
                        else
                        {
                            buscarDadosPopularTela(atualizado: true);
                            MessageBox.Show("Atualizada(s) com sucesso.", "Atenção", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }
    }
}
