using Biblioteca.Controller;
using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Login
{
    public partial class RecuperarSenhaView : Form
    {
        UsuarioController controller = new UsuarioController();
        public RecuperarSenhaView()
        {
            InitializeComponent();
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string senha = controller.RetornarSenha(tbEmail.Texts);
            if (senha != null)
            {
                string mensagem = "Sua senha é " + senha;

                if (Email.Enviar(tbEmail.Texts, "Recuperar Senha", mensagem))
                {
                    MessageBox.Show("EMAIL ENVIADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK);
                    pnEnviado.Visible = true;
                    tbEmail.Texts = null;
                }
                else
                {
                    MessageBox.Show("ERRO AO ENVIAR EMAIL!", "ERRO", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("EMAIL NÃO ENCONTRADO!", "ERRO", MessageBoxButtons.OK);
            }

        }

        private void lbCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja cancelar?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
