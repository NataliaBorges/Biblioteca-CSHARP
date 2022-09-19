using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Genero
{
    public partial class GeneroBuscarView : Form
    {
        GeneroController controller = new GeneroController();
        public GeneroBuscarView()
        {
            InitializeComponent();
        }

        

        private void GeneroBuscarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setPanel(pnltotal);
            List<GeneroModel> lista = controller.ListarTodos();
            popular(lista);
        }
        private void popular(List<GeneroModel> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            dtGridViewGenero.DataSource = lista;
            if (lista.Count > 0)
            {
                foreach (GeneroModel genero in lista)
                {

                    table.Rows.Add(genero.getId(), genero.Nome_genero);

                }
                dtGridViewGenero.DataSource = table;
            }
        }
        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLblCadastrarGenero_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GeneroCadastrarView generoCadastrarView = new GeneroCadastrarView();
            NovaJanela.novaJanela(generoCadastrarView, this.Bounds);
        }

        private void dtGridViewGenero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
