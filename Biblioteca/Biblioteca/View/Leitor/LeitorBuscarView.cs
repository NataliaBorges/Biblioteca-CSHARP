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
        EstadoController controllerEstado = new EstadoController();
        List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
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
            dtGridViewLeitor.DataSource = lista;
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
                                   leitor.Estado);
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

            this.cbStatus.Items.Clear();

            List<EstadoModel> status = controllerEstado.ListarTodos();
            if (status.Count > 0)
            {
                status.Add(new EstadoModel(0, "Ambos"));
                foreach (EstadoModel estado in status)
                {
                    ComboBoxItem item = new ComboBoxItem(estado.Nome, estado.Id.ToString());
                    cbStatus.Items.Add(item);
                    comboBoxItems.Add(item);
                }

                cbStatus.ValueMember = "Value";
                cbStatus.DisplayMember = "Text";
                cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
                cbStatus.Text = status[status.Count - 1].Nome;
            }

            int statusLeitor = 0;
            foreach (ComboBoxItem item in comboBoxItems)
            {
                if (cbStatus.Text == item.Text)
                {
                    statusLeitor = int.Parse(item.Value);
                }
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

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            String busca = tbBuscar.Text;


            if (tbBuscar.Text.Length > 0)
            {
                lblNotFound.Visible = false;
                int status = 0;
                foreach (ComboBoxItem item in comboBoxItems)
                {
                    if (cbStatus.Text == item.Text)
                    {
                        status = int.Parse(item.Value);
                    }
                }

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
                string status = row.Cells[7].Value.ToString();

                //this.leitor = new LeitorModel(id, nome, email, nascimento,telefone, cpf, endereco, status);
            }
        }
    }
}
