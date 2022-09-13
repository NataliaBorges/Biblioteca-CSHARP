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
    public partial class LivroPesquisarEditora : Form
    {
        EditoraController controller = new EditoraController();
        public LivroPesquisarEditora()
        {
            InitializeComponent();
        }

        private void LivroPesquisarEditora_Load(object sender, EventArgs e)
        {
            this.menuControl1.setPanel(pnltotal);

            List<EditoraModel> lista = controller.ListarPesquisaAutor();
            popular(lista);
        }
        private void popular(List<EditoraModel> lista)
        {
            LvEditora.Items.Clear();
            if (lista.Count > 0)
            {
                foreach (EditoraModel editora in lista)
                {
                    ListViewItem item = new ListViewItem(editora.getId().ToString());
                    item.SubItems.Add(editora.Nome);
                    item.SubItems.Add(editora.CNPJ);


                    LvEditora.Items.Add(item);
                }
            }
        }
    }
}
