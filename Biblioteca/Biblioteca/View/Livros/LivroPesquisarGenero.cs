using Biblioteca.Controller;
using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Util;

namespace Biblioteca.View.Livros
{
    public partial class LivroPesquisarGenero : Form
    {
        GeneroController controller = new GeneroController();
        Singleton singleton = Singleton.GetInstancia();
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
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            if (lista.Count > 0)
            {
                foreach (GeneroModel autor in lista)
                {

                    table.Rows.Add(autor.getId(),
                                   autor.Nome_genero);
                }
                dtGridViewGenero.DataSource = table;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGridViewGenero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewGenero.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                string nome = row.Cells[1].Value.ToString();
                GeneroModel generoSelecionado = new GeneroModel(id, nome);
                singleton.setGeneroBusca(generoSelecionado);
                this.Close();
            }
        }
    }
}
