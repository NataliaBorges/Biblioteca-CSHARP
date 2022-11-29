using Biblioteca.Controller;
using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Emprestimo
{
    public partial class EmprestimoVisualizarView : Form
    {
        EmprestimoPesquisaExemplarModel exemplar;
        EmprestimoPesquisaLeitorModel leitor;
        EmprestimoController controller = new EmprestimoController();
        List<int> listaItemId = new List<int>();
        public EmprestimoVisualizarView(EmprestimoPesquisaExemplarModel exemplar = null, EmprestimoPesquisaLeitorModel leitor = null)
        {
            this.exemplar = exemplar;
            this.leitor = leitor;
            InitializeComponent();
        }

        private void buscarDadosPopularTela(bool atualizado = false)
        {
            pnlPunicao.Visible = false;
            dtGridViewLivrosEmprestimo.Columns.Clear();
            dtGridViewLivrosEmprestimo.DataSource = null;
            if (exemplar != null)
            {
                EmprestimoModel emprestimoModel = controller.BuscaEmprestimoPorId(exemplar.ID_emprestimo);
                popularLeitor(controller.BuscaLeitorEmprestimoPorId(emprestimoModel.IdLeitor));
                popular(controller.EmprestimoVisualizarPorId(idEmprestimo: exemplar.ID_emprestimo));
                punicaoLeitor(emprestimoModel.IdLeitor);
            }
            else
            {
                popularLeitor(controller.BuscaLeitorEmprestimoPorId(leitor.Id_Leitor));
                if (atualizado == false)
                {
                    popular(controller.EmprestimoVisualizarPorId(idLeitor: leitor.Id_Leitor, status: leitor.Status_Emprestimo));
                }
                else
                {
                    popular(controller.EmprestimoVisualizarPorId(idLeitor: leitor.Id_Leitor, listaItemId: listaItemId));
                }
                punicaoLeitor(leitor.Id_Leitor);
            }
            
        }

        private void punicaoLeitor(int id)
        {
            LeitorModel leitor = controller.BuscaLeitorEmprestimoPorId(id);
            int quantidadeExtraviado = controller.leitorPossuiExtraviadoPendente(id);
            int quantidadeAtrasados = controller.leitorPossuiEmprestimoAtrasado(id);
            int totalDias = 2 * controller.leitorPossuiMulta(id);
            Nullable<DateTime> finalizado = controller.BuscarUltimoEmprestimoComAtraso(id);

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
            else
            {
                pnlPunicao.Visible = false;
            }
        }

        private void EmprestimoVisualizarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            buscarDadosPopularTela();
        }

        private void popular(List<EmprestimoVisualizarModel> lista)
        {
            listaItemId.Clear();

            dtGridViewLivrosEmprestimo.Columns.Add(new DataGridViewCheckBoxColumn { Name = "Renovar", HeaderText = "Renovar" });
            dtGridViewLivrosEmprestimo.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID", HeaderText = "ID", DataPropertyName = "ID_emprestimo", ReadOnly = true });
            dtGridViewLivrosEmprestimo.Columns.Add(new DataGridViewTextBoxColumn { Name = "Título", HeaderText = "Título", DataPropertyName = "Nome_Livro", ReadOnly = true });
            dtGridViewLivrosEmprestimo.Columns.Add(new DataGridViewTextBoxColumn { Name = "ISBN", HeaderText = "ISBN", DataPropertyName = "ISBN", ReadOnly = true });
            dtGridViewLivrosEmprestimo.Columns.Add(new DataGridViewTextBoxColumn { Name = "Funcionário", HeaderText = "Funcionário", DataPropertyName = "Nome_Funcionario", ReadOnly = true });
            dtGridViewLivrosEmprestimo.Columns.Add(new DataGridViewTextBoxColumn { Name = "Empréstimo", HeaderText = "Empréstimo", DataPropertyName = "Data_emprestimo", ReadOnly = true });
            dtGridViewLivrosEmprestimo.Columns.Add(new DataGridViewTextBoxColumn { Name = "Previsto", HeaderText = "Previsto", DataPropertyName = "Data_devolucao", ReadOnly = true });
            dtGridViewLivrosEmprestimo.Columns.Add(new DataGridViewTextBoxColumn { Name = "Devolução", HeaderText = "Devolução", DataPropertyName = "Data_finalizado", ReadOnly = true });
            dtGridViewLivrosEmprestimo.Columns.Add(comboBoxColumnEmprestimo());
            dtGridViewLivrosEmprestimo.Columns.Add(comboBoxColumnExemplar());

            if (lista.Count > 0)
            {

                foreach(EmprestimoVisualizarModel emprestimo in lista)
                {
                    listaItemId.Add(emprestimo.getItemEmprestimoId());
                }

                dtGridViewLivrosEmprestimo.DataSource = lista;

                int index = dtGridViewLivrosEmprestimo.SelectedRows[0].Index;

                if (index >= 0)
                {
                    dtGridViewLivrosEmprestimo.Rows[index].Selected = false;
                }

                dtGridViewLivrosEmprestimo.Columns[0].Width = 80;
                dtGridViewLivrosEmprestimo.Columns[1].Width = 50;
                dtGridViewLivrosEmprestimo.Columns[2].Width = 180;
                dtGridViewLivrosEmprestimo.Columns[8].Width = 200;
                dtGridViewLivrosEmprestimo.Columns[9].Width = 150;
            }
        }

        private DataGridViewComboBoxColumn comboBoxColumnEmprestimo()
        {
            DataTable dtStatusEmprestimo = new DataTable();
            dtStatusEmprestimo.Columns.Add("Status", typeof(string));
            dtStatusEmprestimo.Rows.Add("Em Aberto");
            dtStatusEmprestimo.Rows.Add("Pendente");
            dtStatusEmprestimo.Rows.Add("Finalizado");
            dtStatusEmprestimo.Rows.Add("Cancelado");

            DataGridViewComboBoxColumn cbColumn = new DataGridViewComboBoxColumn();
            cbColumn.Name = "cbEmprestimo";
            cbColumn.HeaderText = "Status Empréstimo";
            cbColumn.DataPropertyName = "Status_Emprestimo";
            cbColumn.ValueMember = "Status";
            cbColumn.DisplayMember = "Status";
            cbColumn.FlatStyle = FlatStyle.Flat;
            cbColumn.DataSource = dtStatusEmprestimo;
            return cbColumn;
        }

        private DataGridViewComboBoxColumn comboBoxColumnExemplar()
        {
            DataTable dtStatusEmprestimo = new DataTable();
            dtStatusEmprestimo.Columns.Add("Status", typeof(string));
            dtStatusEmprestimo.Rows.Add("Devolvido");
            dtStatusEmprestimo.Rows.Add("Extraviado");
            dtStatusEmprestimo.Rows.Add("Emprestado");

            DataGridViewComboBoxColumn cbColumn = new DataGridViewComboBoxColumn();
            cbColumn.Name = "cbExemplar";
            cbColumn.HeaderText = "Status Exemplar";
            cbColumn.DataPropertyName = "Status_Exemplar";
            cbColumn.ValueMember = "Status";
            cbColumn.DisplayMember = "Status";
            cbColumn.FlatStyle = FlatStyle.Flat;
            cbColumn.DataSource = dtStatusEmprestimo;
            return cbColumn;
        }

        private void popularLeitor(LeitorModel leitor)
        {
            lbNome.Text = leitor.Nome;
            lbCPF.Text = leitor.CPF;
            lbTelefone.Text = leitor.Telefone;
            lbEmail.Text = leitor.Email;
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dtGridViewLivrosEmprestimo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String mensagemErro = "";
            List<EmprestimoVisualizarModel> emprestimos = new List<EmprestimoVisualizarModel>();
            foreach (DataGridViewRow row in dtGridViewLivrosEmprestimo.Rows)
            {
                Nullable<DateTime> finalizado = null;
                if ($"{row.Cells["Previsto"].Value}" != "")
                {
                    finalizado = (DateTime)row.Cells["Previsto"].Value;
                }
                EmprestimoVisualizarModel emprestimo = new EmprestimoVisualizarModel(
                    (int)row.Cells["ID"].Value,
                    (String)row.Cells["Título"].Value,
                    (String)row.Cells["ISBN"].Value,
                    (String)row.Cells["Funcionário"].Value,
                    (DateTime)row.Cells["Empréstimo"].Value,
                    (DateTime)row.Cells["Previsto"].Value,
                    finalizado,
                    (String)row.Cells["cbEmprestimo"].Value,
                    (String)row.Cells["cbExemplar"].Value
                );
                emprestimo.setItemEmprestimoId(listaItemId[row.Index]);
                emprestimos.Add(emprestimo);

                if (emprestimo.Status_Emprestimo == "Em Aberto" && emprestimo.Status_Exemplar != "Emprestado")
                {
                    mensagemErro += "Empréstimo ID: " + emprestimo.ID_emprestimo + ".\n";
                }

                else if (emprestimo.Status_Emprestimo == "Pendente" && emprestimo.Status_Exemplar != "Extraviado")
                {
                    mensagemErro += "Empréstimo ID: " + emprestimo.ID_emprestimo + ".\n";
                }

                else if (emprestimo.Status_Emprestimo == "Finalizado" && emprestimo.Status_Exemplar == "Emprestado")
                {
                    mensagemErro += "Empréstimo ID: " + emprestimo.ID_emprestimo + ".\n";
                }

                else if (emprestimo.Status_Emprestimo == "Cancelado" && emprestimo.Status_Exemplar != "Devolvido")
                {
                    mensagemErro += "Empréstimo ID: " + emprestimo.ID_emprestimo + ".\n";
                }

            }

            if (!mensagemErro.Equals(""))
            {
                mensagemErro = "                                                 ERRO DE FLUXO\n\n" + mensagemErro;
                mensagemErro += "\nIMPORTANTE: Fluxo do status empréstimo e status exemplar incorretos.\nPor favor, verifique as instruções.";
                emprestimos.Clear();
                MessageBox.Show(mensagemErro, "Atenção", MessageBoxButtons.OK);
            }
            else
            {
                bool error = false;
                foreach (EmprestimoVisualizarModel emprestimo in emprestimos)
                {
                    if (controller.AtualizarStatusEmprestimo(emprestimo))
                    {
                        if (!controller.AtualizarStatusExemplar(emprestimo))
                        {
                            error = true;
                        }
                    }
                    else
                    {
                        error = true;
                    }
                }

                if(error)
                {
                    MessageBox.Show("Encontramos um problema ao atualizar um empréstimo.", "Atenção", MessageBoxButtons.OK);
                }
                else
                {
                    buscarDadosPopularTela(atualizado: true);
                    MessageBox.Show("Atualizado(s) com sucesso.", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void icInfo_Click(object sender, EventArgs e)
        {
            pnlFluxo.Visible = true;
        }

        private void icnFluxoEmprestimo_Click(object sender, EventArgs e)
        {
            pnlFluxo.Visible = false;
        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            String mensagemErro = "";
            bool nenhumSelecionado = true;
            List<EmprestimoVisualizarModel> emprestimos = new List<EmprestimoVisualizarModel>();
            foreach (DataGridViewRow row in dtGridViewLivrosEmprestimo.Rows)
            {
                Nullable<DateTime> finalizado = null;
                if (row.Cells["Previsto"].Value.ToString() != "")
                {
                    finalizado = (DateTime)row.Cells["Previsto"].Value;
                }
                EmprestimoVisualizarModel emprestimo = new EmprestimoVisualizarModel(
                    (int)row.Cells["ID"].Value,
                    (String)row.Cells["Título"].Value,
                    (String)row.Cells["ISBN"].Value,
                    (String)row.Cells["Funcionário"].Value,
                    (DateTime)row.Cells["Empréstimo"].Value,
                    (DateTime)row.Cells["Previsto"].Value,
                    finalizado,
                    (String)row.Cells["cbEmprestimo"].Value,
                    (String)row.Cells["cbExemplar"].Value
                );
                emprestimo.setItemEmprestimoId(listaItemId[row.Index]);

                DataGridViewCheckBoxCell renovar = row.Cells[0] as DataGridViewCheckBoxCell;
                bool renovarValor = Convert.ToBoolean(renovar.Value);
                if (renovarValor == true)
                {
                    nenhumSelecionado = false;
                }
                emprestimo.setRenovar(renovarValor);
                emprestimos.Add(emprestimo);

                if (renovarValor && (emprestimo.Status_Emprestimo != "Em Aberto" || emprestimo.Status_Exemplar != "Emprestado") || DateTime.Now > emprestimo.Data_devolucao)
                {
                    mensagemErro += "Empréstimo ID: " + emprestimo.ID_emprestimo + ".\n";
                }
            }

            if(nenhumSelecionado)
            {
                MessageBox.Show("Nenhum empréstimo selecionado para renovação.", "Atenção", MessageBoxButtons.OK);
            }
            else
            {
                if (!mensagemErro.Equals(""))
                {
                    mensagemErro = "                                                 ERRO DE FLUXO\n\n" + mensagemErro;
                    mensagemErro += "\nIMPORTANTE: Apenas os exemplares em aberto sem atraso podem ser renovados.";
                    emprestimos.Clear();
                    MessageBox.Show(mensagemErro, "Atenção", MessageBoxButtons.OK);
                }
                else
                {
                    bool error = false;
                    foreach (EmprestimoVisualizarModel emprestimo in emprestimos)
                    {
                        if (emprestimo.getRenovar())
                        {
                            if (!controller.RenovarEmprestimo(emprestimo))
                            {
                                error = true;
                            }
                        }
                    }

                    if (error)
                    {
                        MessageBox.Show("Encontramos um problema ao renovar um empréstimo.", "Atenção", MessageBoxButtons.OK);
                    }
                    else
                    {
                        buscarDadosPopularTela(atualizado: true);
                        MessageBox.Show("Renovado(s) com sucesso.", "Atenção", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
