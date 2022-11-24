using Biblioteca.View.Funcionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.Util
{
    public partial class UsuarioControl : UserControl
    {
        public UsuarioControl()
        {
            InitializeComponent();
        }

        private void btnTrocarSenha_Click(object sender, EventArgs e)
        {
            FuncionarioTrocarSenhaView funcionarioTrocarSenhaView = new FuncionarioTrocarSenhaView();
            NovaJanela.novaJanela(funcionarioTrocarSenhaView, Bounds);
        }
    }
}
