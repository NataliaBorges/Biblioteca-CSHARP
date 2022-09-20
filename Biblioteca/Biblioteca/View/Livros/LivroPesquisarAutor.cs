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
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            if (lista.Count > 0)
            {
                foreach (AutorModel autor in lista)
                {

                    table.Rows.Add(autor.getId(),
                                   autor.Nome_Autor);
                }
                dtGridViewAutor.DataSource = table;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGridViewAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewAutor.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                string nome = row.Cells[1].Value.ToString();
                AutorModel autorSelecionado = new AutorModel(id, nome);
                singleton.setAutorBusca(autorSelecionado);
                this.Close();
            }
        }
    }
}
