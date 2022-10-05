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
        AutorModel autorSelecionado;
        public AutorBuscarView()
        {
            InitializeComponent();
        }

        private void AutorBuscarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setPanel(pnltotal);
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.TbAutor.Text = this.autorSelecionado.Nome_Autor;
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (controller.Excluir(autorSelecionado))
                {
                    MessageBox.Show("Excluído com sucesso", "Parabéns", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            TbAutor.Text = this.autorSelecionado.Nome_Autor;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void dtGridViewAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewAutor.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                String Nome = row.Cells[1].Value.ToString();
                if (id != null && Nome != null)
                {
                    this.autorSelecionado = new AutorModel(id, Nome);
                }
            }
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarAutor_Click(object sender, EventArgs e)
        {
            AutorCadastrarView autorCadastrarView = new AutorCadastrarView();
            NovaJanela.novaJanela(autorCadastrarView, this.Bounds);
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            String busca = tbBuscar.Text;

            List<AutorModel> lista = controller.BuscarAutor(busca);

            if (tbBuscar.Text.Length > 0 && lista.Count > 0)
            {
                lblNotFound.Visible = false;
                popular(lista);
            }
            else if (tbBuscar.Text.Length == 0)
            {
                lblNotFound.Visible = false;
                dtGridViewAutor.DataSource = null;
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewAutor.DataSource = null;
            }
        }
    }
}
