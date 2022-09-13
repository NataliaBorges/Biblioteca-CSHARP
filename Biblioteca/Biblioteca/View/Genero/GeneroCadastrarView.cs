using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Genero
{
    public partial class GeneroCadastrarView : Form
    {
        public GeneroCadastrarView()
        {
            InitializeComponent();
        }

        private void GeneroCadastrarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setPanel(pnltotal);
        }
    }
}
