﻿using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Emprestimo
{
    public partial class EmprestimoVisualizarView : Form
    {
        EmprestimoPesquisaExemplarModel exemplar;
        EmprestimoPesquisaLeitorModel leitor;
        public EmprestimoVisualizarView(EmprestimoPesquisaExemplarModel exemplar = null, EmprestimoPesquisaLeitorModel leitor = null)
        {
            exemplar = exemplar;
            leitor = leitor;
            InitializeComponent();
        }

        private void EmprestimoVisualizarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);
        }
    }
}
