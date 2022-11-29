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

namespace Biblioteca.View {
    public partial class PrincipalTelaView : Form {

        Singleton singleton = Singleton.GetInstancia();

        public PrincipalTelaView() {
            InitializeComponent();
        }
        private void PrincipalTelaView_Load(object sender, EventArgs e) {
            this.menuControl1.setPanel(pnltotal);
            this.menuControl1.setForm(this);
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            ReservaBuscarDiaView reservaBuscarDiaView = new ReservaBuscarDiaView(DateTime.Now);
            NovaJanela.novaJanela(reservaBuscarDiaView, Bounds);
        }
    }
}
