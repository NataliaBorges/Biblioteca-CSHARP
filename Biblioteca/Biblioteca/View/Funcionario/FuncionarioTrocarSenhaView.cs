using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Funcionario
{
    public partial class FuncionarioTrocarSenhaView : Form
    {
        public FuncionarioTrocarSenhaView()
        {
            InitializeComponent();
            lbNome.Visible = false;
            lbCpf.Visible = false;
            lbEmail.Visible = false;
            lbTelefone.Visible = false;
            lbFuncao.Visible = false;
        }

        private void btnBuscarColaborador_Click(object sender, EventArgs e)
        {
            FuncionarioSelecionarColaboradorView funcionarioSelecionarColaboradorView = new FuncionarioSelecionarColaboradorView();
            NovaJanela.novaJanela(funcionarioSelecionarColaboradorView, Bounds);
        }

        private void FuncionarioTrocarSenhaView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);
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
