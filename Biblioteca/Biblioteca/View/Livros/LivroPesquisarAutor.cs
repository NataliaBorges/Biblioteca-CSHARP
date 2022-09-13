using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Util;

namespace Biblioteca.View.Livros
{
    public partial class LivroPesquisarAutor : Form
    {
        AutorController controller = new AutorController();
        Singleton singleton = Singleton.GetInstancia();
        public LivroPesquisarAutor()
        {
            InitializeComponent();
        }
        private void LivroPesquisarAutor_Load(object sender, EventArgs e)
        {
            if (singleton.getAddAutor() == true)
            {
                singleton.setAddAutor(false);
            }
            List<AutorModel> lista = controller.ListarTodos();
            popular(lista);

            this.menuControl1.setPanel(pnltotal);
        }
        private void popular(List<AutorModel> lista)
        {
            LvAutor.Items.Clear();
            if (lista.Count > 0)
            {
                foreach (AutorModel autor in lista)
                {
                    ListViewItem item = new ListViewItem(autor.getId().ToString());
                    item.SubItems.Add(autor.Nome_Autor);


                    LvAutor.Items.Add(item);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void LvAutor_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = LvAutor.Items[LvAutor.FocusedItem.Index];
            AutorModel autor = new AutorModel(
                int.Parse(item.SubItems[0].Text),
                item.SubItems[1].Text
            );

            controller.InserirAutorLivro(autor);
            this.Close();
        }

    }
}
