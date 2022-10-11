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
using Tulpep.NotificationWindow;

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

            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);
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
            int index = dtGridViewAutor.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewAutor.Rows[index].Selected = false;
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

            List<AutorModel> lista = controller.SelecionarAutor(busca);

            if(tbBuscar.Text.Length > 0 && lista.Count > 0)
            {
                lblNotFound.Visible = false;
                popular(lista);
            } 
            else if(tbBuscar.Text.Length == 0)
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

        private void dtGridViewAutor_CellClick(object sender, DataGridViewCellEventArgs e)
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
