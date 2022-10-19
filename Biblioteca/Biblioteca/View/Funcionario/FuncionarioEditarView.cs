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

namespace Biblioteca.View.Funcionario
{
    public partial class FuncionarioEditarView : Form
    {

        FuncionarioModel funcionario;
        FuncionarioController controller = new FuncionarioController();
        FuncaoController funcaoController = new FuncaoController();
        List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
        DateTime data;
        public FuncionarioEditarView(FuncionarioModel funcionario)
        {
            this.funcionario = funcionario;
            InitializeComponent();
        }

        private void FuncionarioEditarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            this.cbFuncao.Items.Clear();
            List<FuncaoModel> funcoes = funcaoController.ListarTodos();
            if (funcoes.Count > 0)
            {
                foreach (FuncaoModel funcao in funcoes)
                {
                    ComboBoxItem item = new ComboBoxItem(funcao.Nome, funcao.Id.ToString());
                    cbFuncao.Items.Add(item);
                    comboBoxItems.Add(item);
                }

                cbFuncao.ValueMember = "Value";
                cbFuncao.DisplayMember = "Text";
                cbFuncao.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            if (funcionario != null)
            {
                tbNome.Text = funcionario.Nome_funcionario;

                try
                {
                    //rua, numero, bairro - cidade
                    string[] cidade = funcionario.Endereco.Split('-');
                    string[] endereco = cidade[0].Split(',');

                    tbRua.Text = $"{endereco[0]}";
                    tbNumero.Text = $"{endereco[1]}";
                    tbBairro.Text = $"{endereco[2]}";
                    tbCidade.Text = $"{cidade[1]}";
                }
                catch (Exception) { }

                tbEmail.Text = funcionario.Email;
                maskedTextBoxCPF.Text = funcionario.CPF;
                maskedTextBoxTelefone.Text = funcionario.Telefone;
                CalendarFuncionario.Text = funcionario.Data_Nascimento.ToString("dd/MM/yyyy");
                data = funcionario.Data_Nascimento;
                cbEditarStatus.Text = funcionario.getEstado();
                foreach (FuncaoModel funcao in funcoes)
                {
                    if (funcao.Nome == funcionario.Funcao)
                    {
                        cbFuncao.Text = funcao.Nome;
                    }
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string nome = tbNome.Text;
            string endereco = $"{tbRua.Text}, {tbNumero.Text}, {tbBairro.Text} - {tbCidade.Text}";
            string telefone = maskedTextBoxTelefone.Text;
            string cpf = maskedTextBoxCPF.Text;
            string email = tbEmail.Text;
            DateTime data = this.CalendarFuncionario.Value.Date; //.ToString("yyyy-MM-dd");
            int funcao = 0;


            foreach (ComboBoxItem item in comboBoxItems)
            {
                if (cbFuncao.Text == item.Text)
                {
                    funcao = int.Parse(item.Value);
                }
            }

            if (nome.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                tbNome.Focus();
            }
            else if (tbRua.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar uma Rua.", "Atenção", MessageBoxButtons.OK);
                tbRua.Focus();
            }
            else if (tbNumero.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um número.", "Atenção", MessageBoxButtons.OK);
                tbNumero.Focus();
            }
            else if (tbBairro.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um bairro.", "Atenção", MessageBoxButtons.OK);
                tbBairro.Focus();
            }
            else if (telefone == "(  )     -")
            {
                MessageBox.Show("Você precisa digitar um telefone.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxTelefone.Focus();
            }
            else if (tbCidade.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar uma cidade.", "Atenção", MessageBoxButtons.OK);
                tbCidade.Focus();
            }
            else if (Validar.ValidaCpf(cpf) == false)
            {
                MessageBox.Show("Você precisa digitar uma CPF.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxCPF.Focus();
            }
            else if (Validar.ValidarEmail(email) == false)
            {
                MessageBox.Show("Você precisa digitar um email.", "Atenção", MessageBoxButtons.OK);
                tbEmail.Focus();
            }
            else
            {
                int estado = 0;

                if (cbEditarStatus.Text == "Ativo")
                {
                    estado = 1;
                }
                FuncionarioModel funcionario = new FuncionarioModel(this.funcionario.getId(), nome, data, cpf, endereco, telefone, email, funcao, estado);
                if (controller.Atualizar(funcionario))
                {
                    MessageBox.Show("Atualizado com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar.", "Atenção", MessageBoxButtons.OK);
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
    }
}
