using Biblioteca.Controller;
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

        FuncionarioController controller = new FuncionarioController();
        public FuncionarioTrocarSenhaView()
        {
            InitializeComponent();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string antiga = tbSenhaAtual.Text;
            string nova = tbNSenha.Text;
            string novaNovamente = tbCSenha.Text;

            if (nova == null || nova == "")
            {
                MessageBox.Show("Digite sua nova senha.", "Atenção", MessageBoxButtons.OK);
            }
            else if (novaNovamente == null || novaNovamente == "")
            {
                MessageBox.Show("Digite sua nova senha novamente.", "Atenção", MessageBoxButtons.OK);
            }
            else if (nova != novaNovamente)
            {
                MessageBox.Show("As senhas não se coincidem.", "Atenção", MessageBoxButtons.OK);
            }
            else if(antiga == null || antiga == "")
            {
                MessageBox.Show("Digite sua senha atual.", "Atenção", MessageBoxButtons.OK);
            }
            else
            {
                if(controller.AtualizarSenha(nova, antiga) == false)
                {
                    MessageBox.Show("Senha atual inválida.", "Atenção", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Senha atualizada com sucesso.", "Atenção", MessageBoxButtons.OK);
                }
            }
        }
    }
}
