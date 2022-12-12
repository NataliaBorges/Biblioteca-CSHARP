using Biblioteca.Util;
using Biblioteca.View;
using Biblioteca.View.Emprestimo;
using Biblioteca.View.Editora;
using Biblioteca.View.Funcionario;
using Biblioteca.View.Leitor;
using Biblioteca.View.Livros;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Biblioteca.View.Reserva;
using Biblioteca.Controller;

namespace Biblioteca.View {
    public partial class PrincipalTelaView : Form {

        Singleton singleton = Singleton.GetInstancia();
        TelaPrincipalController controller = new TelaPrincipalController();

        public PrincipalTelaView() {
            InitializeComponent();
        }
        private void PrincipalTelaView_Load(object sender, EventArgs e) {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);
            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            ReservaBuscarDiaView reservaBuscarDiaView = new ReservaBuscarDiaView(DateTime.Now);
            NovaJanela.novaJanela(reservaBuscarDiaView, Bounds);
        }

        private void PrincipalTelaView_Activated(object sender, EventArgs e)
        {
            lbEmprestimo.Text = controller.quantidadeEmprestados().ToString();
            lbReserva.Text = controller.quantidadeReserva().ToString();
            lbUsuarioQtd.Text = controller.quantidadeLeitor().ToString();
            lbExemplar.Text = controller.quantidadeExemplar().ToString();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            EmprestimoBuscarView emprestimoBuscarView = new EmprestimoBuscarView();
            NovaJanela.novaJanela(emprestimoBuscarView, Bounds);
        }
    }
}
