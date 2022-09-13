using Biblioteca.Controller;
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
    public partial class LivroPesquisarGenero : Form
    {
        GeneroController controller = new GeneroController();
        public LivroPesquisarGenero()
        {
            InitializeComponent();
        }

        private void LivroPesquisarGenero_Load(object sender, EventArgs e)
        {
            List<GeneroModel> lista = controller.ListarTodos();
            popular(lista);

            this.menuControl1.setPanel(pnltotal);
        }
        private void popular(List<GeneroModel> lista)
        {
            LvGenero.Items.Clear();
            if (lista.Count > 0)
            {
                foreach (GeneroModel genero in lista)
                {
                    ListViewItem item = new ListViewItem(genero.getId().ToString());
                    item.SubItems.Add(genero.Nome_genero);


                    LvGenero.Items.Add(item);
                }
            }
        }
    }
}
