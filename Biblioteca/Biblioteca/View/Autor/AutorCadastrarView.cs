using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Autor
{
    public partial class AutorCadastrarView : Form
    {
        public AutorCadastrarView()
        {
            InitializeComponent();
        }

        private void AutorCadastrarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setPanel(pnltotal);
        }
    }
}
