using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;

namespace Biblioteca.View.Leitor {
    public partial class LeitorBuscarView : Form {

        LeitorController controller = new LeitorController();
        LeitorModel leitor;
        public LeitorBuscarView() {
            InitializeComponent();
            lblNotFound.Visible = false;    
        }

        private void popular(List<LeitorModel> lista) {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Telefone", typeof(string));
            table.Columns.Add("Nascimento", typeof(DateTime));
            table.Columns.Add("CPF", typeof(string));
            table.Columns.Add("Endereço", typeof(string));
            table.Columns.Add("Status", typeof(string));
            if (lista.Count > 0)
            {
                foreach (LeitorModel leitor in lista)
                {

                    table.Rows.Add(leitor.getId(), 
                                   leitor.Nome,
                                   leitor.Email,
                                   leitor.Telefone,
                                   leitor.DataNascimento,
                                   leitor.CPF,
                                   leitor.Endereco,
                                   leitor.getEstado());
                }
                dtGridViewLeitor.DataSource = table;
            }
            int index = dtGridViewLeitor.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewLeitor.Rows[index].Selected = false;
            }
        }

        private void LeitorBuscarView_Load(object sender, EventArgs e) {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            cbStatus.Text = "Ambos";

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

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            String busca = tbBuscar.Text;
            String status = cbStatus.Text;


            if (tbBuscar.Text.Length > 0)
            {
                lblNotFound.Visible = false;
                

                if (rbNome.Checked)
                {
                    List<LeitorModel> leitor = controller.Buscar(busca, isNome: true, status: status);
                    if(leitor.Count > 0)
                    {
                        popular(leitor);
                    }
                    else
                    {
                        lblNotFound.Visible = true;
                        dtGridViewLeitor.DataSource = null;
                    }
                }

                if (rbCPF.Checked)
                {
                    List<LeitorModel> cpf = controller.Buscar(busca, isCPF: true, status: status);
                    if (cpf.Count > 0)
                    {
                        popular(cpf);
                    }
                    else
                    {
                        lblNotFound.Visible = true;
                        dtGridViewLeitor.DataSource = null;
                    }
                }

                if(rbNome.Checked== false && rbCPF.Checked == false)
                {
                    List<LeitorModel> leitor = controller.Buscar(busca, isNome: true, status: status);
                    if (leitor.Count > 0)
                    {
                        popular(leitor);
                    }
                    else
                    {
                        lblNotFound.Visible = true;
                        dtGridViewLeitor.DataSource = null;
                    }
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

        private void btnCadastrarLeitor_Click(object sender, EventArgs e)
        {
            LeitorCadastrarView leitorCadastrarView = new LeitorCadastrarView();
            NovaJanela.novaJanela(leitorCadastrarView, this.Bounds);
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

        private void dtGridViewLeitor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewLeitor.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                string nome = row.Cells[1].Value.ToString();
                string email = row.Cells[2].Value.ToString();
                string telefone = row.Cells[3].Value.ToString();
                DateTime nascimento = DateTime.Parse(row.Cells[4].Value.ToString());
                string cpf = row.Cells[5].Value.ToString();
                string endereco = row.Cells[6].Value.ToString();

                int estado = 0;

                if (row.Cells[7].Value.ToString() == "Ativo")
                {
                    estado = 1;
                }

                this.leitor = new LeitorModel(id, nome, nascimento, telefone, cpf, endereco, email, estado);
            }
        }

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewLeitor.DataSource = null;
        }

        private void LeitorBuscarView_Activated(object sender, EventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewLeitor.DataSource = null;
            rbNome.Checked = false;
            rbCPF.Checked = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (leitor != null)
            {
                LeitorEditarView leitorEditarViewEditarView = new LeitorEditarView(leitor);
                NovaJanela.novaJanela(leitorEditarViewEditarView, Bounds);
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um leitor", "Atenção", MessageBoxButtons.OK);
            }
        }
    }
}
