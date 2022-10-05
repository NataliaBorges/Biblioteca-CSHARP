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
            int index = dtGridViewGenero.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewGenero.Rows[index].Selected = false;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            String busca = tbBuscar.Text;

            List<GeneroModel> lista = controller.SelecionarGenero(busca);

            if (tbBuscar.Text.Length > 0 && lista.Count > 0)
            {
                lblNotFound.Visible = false;
                popular(lista);
            }
            else if (tbBuscar.Text.Length == 0)
            {
                lblNotFound.Visible = false;
                dtGridViewGenero.DataSource = null;
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewGenero.DataSource = null;
            }
        }

        private void dtGridViewGenero_CellClick(object sender, DataGridViewCellEventArgs e)
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
