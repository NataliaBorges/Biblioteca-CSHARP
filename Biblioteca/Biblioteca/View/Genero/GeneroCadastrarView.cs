using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;
using Biblioteca.View.Livros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Genero
{
    public partial class GeneroCadastrarView : Form
    {
        GeneroController controller = new GeneroController();
        public GeneroCadastrarView()
        {
            InitializeComponent();
        }

        private void GeneroCadastrarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setPanel(pnltotal);
            List<GeneroModel> lista = controller.ListarTodos();
            popular(lista);
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void linkLbBuscarGenero_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GeneroBuscarView generoBuscarView = new GeneroBuscarView();
            NovaJanela.novaJanela(generoBuscarView, this.Bounds);
        }

        private void linkLbCadastrarLivro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LivrosCadastrarView livrosCadastrarView = new LivrosCadastrarView();
            NovaJanela.novaJanela(livrosCadastrarView, this.Bounds);
        }
    }
}
