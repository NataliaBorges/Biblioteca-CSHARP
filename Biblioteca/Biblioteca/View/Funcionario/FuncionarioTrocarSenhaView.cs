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
        }

        private void btnBuscarColaborador_Click(object sender, EventArgs e)
        {
            FuncionarioSelecionarColaboradorView funcionarioSelecionarColaboradorView = new FuncionarioSelecionarColaboradorView();
            NovaJanela.novaJanela(funcionarioSelecionarColaboradorView, Bounds);
        }
    }
}
