using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;

namespace Biblioteca.View.Relatorio {
    public partial class RelatorioEmprestimoView : Form {

        EmprestimoController controller = new EmprestimoController();

        public RelatorioEmprestimoView() {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e) {
        //    DateTime inicio = DateTime.Parse(tbInicio.Text);
        //    DateTime fim = DateTime.Parse(tbFim.Text);
        //    List<EmprestimoModel> lista = controller.Relatorio(inicio, fim);
        //    popular(lista);
        //}


        //private void button2_Click(object sender, EventArgs e) {
        //    this.Close();
        //}
    }
}
