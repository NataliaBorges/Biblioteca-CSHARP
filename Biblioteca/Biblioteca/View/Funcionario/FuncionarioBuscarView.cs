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

namespace Biblioteca.View.Funcionario {
    public partial class FuncionarioBuscarView : Form {

        FuncionarioController controller = new FuncionarioController();
        FuncionarioModel  funcionario;

        public FuncionarioBuscarView() {
            InitializeComponent();
        }
        private void FuncionarioBuscarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            cbStatus.Text = "Ambos";
        }
        private void popular(List<FuncionarioModel> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Nascimento", typeof(DateTime));
            table.Columns.Add("CPF", typeof(string));
            table.Columns.Add("Endereço", typeof(string));
            table.Columns.Add("Telefone", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Função", typeof(string));
            table.Columns.Add("Status", typeof(string));
            if (lista.Count > 0)
            {
                foreach (FuncionarioModel funcionario in lista)
                {

                    table.Rows.Add(funcionario.getId(),
                                   funcionario.Nome_funcionario,
                                   funcionario.Data_Nascimento,
                                   funcionario.CPF,
                                   funcionario.Endereco,
                                   funcionario.Telefone,
                                   funcionario.Email,
                                   funcionario.Funcao,
                                   funcionario.getEstado());
                }
                dtGridViewFuncionario.DataSource = table;
            }
            int index = dtGridViewFuncionario.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewFuncionario.Rows[index].Selected = false;
            }
        }
        private void button1_Click(object sender, EventArgs e) {
            String busca = tbBuscar.Text;

            if (rbNome.Checked) {
                List<FuncionarioModel> lista = controller.Buscar(busca, isNome: true);
                popular(lista);
            }

            if (rbEmail.Checked) {
                List<FuncionarioModel> lista = controller.Buscar(busca, isEmail: true);
                popular(lista);
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
            this.funcionario = null;
            String status = cbStatus.Text;
            String busca = tbBuscar.Text;

            if (rbNome.Checked)
            {
                List<FuncionarioModel> lista = controller.Buscar(busca, isNome: true, status: status);
                if (tbBuscar.Text.Length > 0 && lista.Count > 0)
                {
                    lblNotFound.Visible = false;
                    popular(lista);
                }
                else if (tbBuscar.Text.Length == 0)
                {
                    lblNotFound.Visible = false;
                    dtGridViewFuncionario.DataSource = null;
                }
                else
                {
                    lblNotFound.Visible = true;
                    dtGridViewFuncionario.DataSource = null;
                }
            }

            if (rbEmail.Checked)
            {
                List<FuncionarioModel> lista = controller.Buscar(busca, isEmail: true, status: status);
                if (tbBuscar.Text.Length > 0 && lista.Count > 0)
                {
                    lblNotFound.Visible = false;
                    popular(lista);
                }
                else if (tbBuscar.Text.Length == 0)
                {
                    lblNotFound.Visible = false;
                    dtGridViewFuncionario.DataSource = null;
                }
                else
                {
                    lblNotFound.Visible = true;
                    dtGridViewFuncionario.DataSource = null;
                }
            }
            if (rbNome.Checked == false && rbEmail.Checked == false)
            {
                List<FuncionarioModel> lista = controller.Buscar(busca, isNome: true, status: status);
                if (tbBuscar.Text.Length > 0 && lista.Count > 0)
                {
                    lblNotFound.Visible = false;
                    popular(lista);
                }
                else if (tbBuscar.Text.Length == 0)
                {
                    lblNotFound.Visible = false;
                    dtGridViewFuncionario.DataSource = null;
                }
                else
                {
                    lblNotFound.Visible = true;
                    dtGridViewFuncionario.DataSource = null;
                }
            }
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            FuncionarioCadastrarView funcionarioCadastrarView = new FuncionarioCadastrarView();
            NovaJanela.novaJanela(funcionarioCadastrarView, this.Bounds);
        }

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewFuncionario.DataSource = null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (funcionario != null)
            {
                FuncionarioEditarView funcionarioEditarView = new FuncionarioEditarView(funcionario);
                NovaJanela.novaJanela(funcionarioEditarView, Bounds);
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um funcionário", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void dtGridViewFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewFuncionario.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                String nome = row.Cells[1].Value.ToString();
                DateTime nascimento = DateTime.Parse(row.Cells[2].Value.ToString());
                String cpf = row.Cells[3].Value.ToString();
                String endereco = row.Cells[4].Value.ToString();
                String telefone = row.Cells[5].Value.ToString();
                String email = row.Cells[6].Value.ToString();
                String funcao = row.Cells[7].Value.ToString();

                int estado = 0;

                if (row.Cells[8].Value.ToString() == "Ativo")
                {
                    estado = 1;
                }

                this.funcionario = new FuncionarioModel(id, nome, nascimento, cpf, endereco, telefone, email, funcao, estado);
            }
        }

        private void rbNome_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewFuncionario.DataSource = null;
        }

        private void rbEmail_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewFuncionario.DataSource = null;
        }

        private void FuncionarioBuscarView_Activated(object sender, EventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewFuncionario.DataSource = null;
            rbNome.Checked = false;
            rbEmail.Checked = false;
        }
    }
}
