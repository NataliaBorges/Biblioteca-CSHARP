using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Exemplar
{
    public partial class ExemplarEditarView : Form
    {
        ExemplarModel exemplar;
        public ExemplarEditarView(ExemplarModel exemplar)
        {
            this.exemplar = exemplar;

            InitializeComponent();
        }
    }
}
