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

namespace Biblioteca.View.Autor
{
    public partial class AutorBuscarView : Form
    {
        AutorController controller = new AutorController();
        public AutorBuscarView()
        {
            InitializeComponent();
        }

        private void AutorBuscarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setPanel(pnltotal);
            List<AutorModel> lista = controller.ListarTodos();
            popular(lista);
        }
        private void popular(List<AutorModel> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            dtGridViewAutor.DataSource = lista;
            if (lista.Count > 0)
            {
                foreach (AutorModel autor in lista)
                {
                    
                    table.Rows.Add(autor.getId(), autor.Nome_Autor);
                    
                }
                dtGridViewAutor.DataSource = table;
            }
        }

        private void linkLblCadastrarAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AutorCadastrarView autorCadastrarView = new AutorCadastrarView();
            NovaJanela.novaJanela(autorCadastrarView, this.Bounds);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void dtGridViewAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //DataGridViewRow row = dataGridView_Busca.Rows[e.RowIndex];
                   // tbNome.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            { 

            }
        }
    }
}
