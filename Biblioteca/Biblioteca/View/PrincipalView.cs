using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.View.Livros;
using Biblioteca.View.Leitor;
using Biblioteca.View.Emprestimo;
using Biblioteca.View.Funcionario;
using Biblioteca.View.Fornecedor;
using Biblioteca.View.Relatorio;
using Biblioteca.View.Reserva;
using Biblioteca.Util;

namespace Biblioteca.View {
    public partial class PrincipalView : Form {

        Singleton singleton = Singleton.GetInstancia();

        public PrincipalView() {
            InitializeComponent();
        }

       private void PrincipalView_Load(object sender, EventArgs e) {
            if(singleton.getFuncionario().Funcao != "Administrador") {
                funcionáriosToolStripMenuItem.Visible = false;
                fornecedoresToolStripMenuItem.Visible = false;
                relatóriosToolStripMenuItem.Visible = false;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void novaJanela(Form form) {
            Rectangle bounds = this.Bounds;
            form.SetBounds(bounds.X, bounds.Y, form.Bounds.Width, form.Bounds.Height);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void leitorToolStripMenuItem_Click(object sender, EventArgs e) {
            LeitorPrincipalView leitorPrincipalView = new LeitorPrincipalView();
            novaJanela(leitorPrincipalView);
        }

        private void empréstimosToolStripMenuItem_Click(object sender, EventArgs e) {
            EmprestimoPrincipalView emprestimoPrincipalView = new EmprestimoPrincipalView();
            novaJanela(emprestimoPrincipalView);
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e) {
            FuncionarioPrincipalView funcionarioPrincipalView = new FuncionarioPrincipalView();
            novaJanela(funcionarioPrincipalView);
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e) {
            ForcecedorPrincipalView forcecedorPrincipalView = new ForcecedorPrincipalView();
            novaJanela(forcecedorPrincipalView);
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e) {
            RelatorioPrincipalView relatorios = new RelatorioPrincipalView();
            novaJanela(relatorios);
        }

        private void ReservatoolStripMenuItem1_Click(object sender, EventArgs e) {
            ReservaPrincipalView reservaPrincipalView = new ReservaPrincipalView();
            novaJanela(reservaPrincipalView);
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e) {
            LivrosPrincipalView livrosPrincipalView = new LivrosPrincipalView();
            novaJanela(livrosPrincipalView);
        }
    }
}
