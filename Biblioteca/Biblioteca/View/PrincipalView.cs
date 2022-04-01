﻿using System;
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

            menuStrip1.Renderer = new MyRenderer();
        }
        private class MyRenderer : ToolStripProfessionalRenderer {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable {
            // Ficar com cor sólida
            public override Color MenuItemSelected {
                get { return Color.BurlyWood; }
            }

            // Ficar com cor gradiente/degradê no começo
            public override Color MenuItemSelectedGradientBegin {
                get { return Color.Chocolate; }
            }

            // Ficar com cor gradiente/degradê no final
            public override Color MenuItemSelectedGradientEnd {
                get { return Color.BurlyWood; }
            }
            public override Color MenuBorder {
                get {
                    return Color.Chocolate;
                }
            }
            public override Color MenuItemBorder {
                get {
                    return Color.Chocolate;
                }
            }
            public override Color MenuItemPressedGradientBegin {
                get {
                    return Color.BurlyWood;
                }
            }
            public override Color MenuItemPressedGradientMiddle {
                get {
                    return Color.BurlyWood;
                }
            }
            public override Color MenuItemPressedGradientEnd {
                get {
                    return Color.BurlyWood;
                }
            }


        }
        private void PrincipalView_Load(object sender, EventArgs e) {
            if (singleton.getFuncionario().Funcao != "Administrador") {
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e) {
            LivrosCadastrarView livrosCadastrarlView = new LivrosCadastrarView();
            novaJanela(livrosCadastrarlView);
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e) {
            LivrosBuscarView livrosBuscarView = new LivrosBuscarView();
            novaJanela(livrosBuscarView);
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e) {
            LeitorCadastrarView leitorCadastrarView = new LeitorCadastrarView();
            novaJanela(leitorCadastrarView);
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e) {
            LeitorBuscarView leitorBuscarView = new LeitorBuscarView();
            novaJanela(leitorBuscarView);
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e) {
            FuncionarioCadastrarView funcionarioCadastrarView = new FuncionarioCadastrarView();
            novaJanela(funcionarioCadastrarView);
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e) {
            FuncionarioBuscarView funcionarioBuscarView = new FuncionarioBuscarView();
            novaJanela(funcionarioBuscarView);
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e) {
            FornecedorCadastrarView fornecedorCadastrarView = new FornecedorCadastrarView();
            novaJanela(fornecedorCadastrarView);
        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e) {
            FornecedorBuscarView fornecedorBuscarView = new FornecedorBuscarView();
            novaJanela(fornecedorBuscarView);
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e) {
            EmprestimoCadastroView emprestimoCadastroView = new EmprestimoCadastroView();
            novaJanela(emprestimoCadastroView);
        }

        private void buscarToolStripMenuItem3_Click(object sender, EventArgs e) {
            EmprestimoBuscarView emprestimoBuscarView = new EmprestimoBuscarView();
            novaJanela(emprestimoBuscarView);

        }

        private void cadastrarToolStripMenuItem4_Click(object sender, EventArgs e) {
            ReservaCadastroView reservaCadastroView = new ReservaCadastroView();
            novaJanela(reservaCadastroView);
        }

        private void buscarToolStripMenuItem4_Click(object sender, EventArgs e) {
            ReservaBuscarView reservaBuscarView = new ReservaBuscarView();
            novaJanela(reservaBuscarView);
        }

        private void livrotoolStripMenuItem3_Click(object sender, EventArgs e) {
            RelatorioLivroView relatorioLivroView = new RelatorioLivroView();
            novaJanela(relatorioLivroView);
        }

        private void leitorToolStripMenuItem1_Click(object sender, EventArgs e) {
            RelatorioLeitorView relatorioLeitorView = new RelatorioLeitorView();
            novaJanela(relatorioLeitorView);
        }

        private void empréstimoToolStripMenuItem_Click(object sender, EventArgs e) {
            RelatorioEmprestimoView relatorioEmprestimoView = new RelatorioEmprestimoView();
            novaJanela(relatorioEmprestimoView);
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e) {
            RelatorioReservaView relatorioReservaView = new RelatorioReservaView();
            novaJanela(relatorioReservaView);
        }
    }
}

