using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Livros
{
    public partial class LivroPesquisarEditora : Form
    {
        public LivroPesquisarEditora()
        {
            InitializeComponent();
        }

        private void LivroPesquisarEditora_Load(object sender, EventArgs e)
        {
            this.menuControl1.setPanel(pnltotal);
        }
    }
}
