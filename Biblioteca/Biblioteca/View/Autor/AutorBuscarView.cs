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
        AutorModel autor;
        public AutorBuscarView()
        {
            InitializeComponent();
            TbAutor.Enabled = false;
        }

        private void AutorBuscarView_Load(object sender, EventArgs e)
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
            dtGridViewAutor.DataSource = lista;
            if (lista.Count > 0)
            {
                foreach (AutorModel autor in lista)
                {
                    
                    table.Rows.Add(autor.getId(), autor.Nome_Autor);
                    
                }
                dtGridViewAutor.DataSource = table;
            }
            int index = dtGridViewAutor.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewAutor.Rows[index].Selected = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (TbAutor.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa selecionar um Autor", "Atenção", MessageBoxButtons.OK);
                TbAutor.Focus();
            }
            else
            {
                this.TbAutor.Text = this.autor.Nome_Autor;
                DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (controller.Excluir(autor))
                    {
                        MessageBox.Show("Excluído com sucesso", "Parabéns", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir", "Atenção", MessageBoxButtons.OK);
                    }
                }
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if(autor != null)
                {
                    TbAutor.Enabled = true;
                }
                TbAutor.Text = this.autor.Nome_Autor;
            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar um Autor", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string autorLivro = TbAutor.Text;

            if (TbAutor.Text.Length <= 0 || autor == null)
            {
                TbAutor.Enabled = false;
                MessageBox.Show("Você precisa selecionar um autor", "Atenção", MessageBoxButtons.OK);
                TbAutor.Focus();
            }
            else
            {
                TbAutor.Enabled = true;
                AutorModel livroAutor = new AutorModel(autor.Id_autor, autorLivro);
                if (controller.Atualizar(livroAutor))
                {
                    MessageBox.Show("Atualizado com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCadastrarAutor_Click(object sender, EventArgs e)
        {
            AutorCadastrarView autorCadastrarView = new AutorCadastrarView();
            NovaJanela.novaJanela(autorCadastrarView, this.Bounds);
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            TbAutor.Text = "";
            TbAutor.Enabled = false;
            this.autor = null;
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

        private void dtGridViewAutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewAutor.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                String Nome = row.Cells[1].Value.ToString();

                this.autor = new AutorModel(id, Nome);
            }
        }
    }
}
