using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Relatorio {
    public partial class RelatorioPrincipalView : Form {
        public RelatorioPrincipalView() {
            InitializeComponent();
        }

        private void RelatorioPrincipalView_Load(object sender, EventArgs e) {

        }

        private void novaJanela(Form form) {
            Rectangle bounds = this.Bounds;
            form.SetBounds(bounds.X, bounds.Y, form.Bounds.Width, form.Bounds.Height);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) {
            RelatorioEmprestimoView emprestimo = new RelatorioEmprestimoView();
            novaJanela(emprestimo);
        }
    }
}
