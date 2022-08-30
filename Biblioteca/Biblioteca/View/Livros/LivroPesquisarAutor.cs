using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Livros
{
    public partial class LivroPesquisarAutor : Form
    {
        public LivroPesquisarAutor()
        {
            InitializeComponent();
        }
        private void popular(List<AutorModel> lista)
        {
            LvAutor.Items.Clear();
            if (lista.Count > 0)
            {
                foreach (AutorModel autor in lista)
                {
                    ListViewItem item = new ListViewItem(autor.getId().ToString());
                    item.SubItems.Add(autor.ToString());


                    LvAutor.Items.Add(item);
                }
            }
        }

        private void LivroPesquisarAutor_Load(object sender, EventArgs e)
        {
            this.menuControl1.setPanel(pnltotal);
        }
    }
}
