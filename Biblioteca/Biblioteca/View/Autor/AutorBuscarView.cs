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
        List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
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

            cbStatus.Text = "Ambos";

        }
        private void popular(List<AutorModel> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Status", typeof(string));
            dtGridViewAutor.DataSource = lista;
            if (lista.Count > 0)
            {
                foreach (AutorModel autor in lista)
                {
                    table.Rows.Add(autor.getId(), autor.Nome_Autor, autor.getEstado());
                }
                dtGridViewAutor.DataSource = table;
            }
            int index = dtGridViewAutor.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewAutor.Rows[index].Selected = false;
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
                cbEditarStatus.Text = this.autor.getEstado();
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
                int estado = 0;

                if (cbEditarStatus.Text == "Ativo")
                {
                    estado = 1;
                }
                AutorModel livroAutor = new AutorModel(autor.Id_autor, autorLivro, estado);
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
                PrincipalTelaView telaPrincipal = new PrincipalTelaView();
                NovaJanela.novaJanela(telaPrincipal, this.Bounds);
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
            String status = cbStatus.Text;

            List<AutorModel> lista = controller.BuscarAutor(busca, status);

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
                int estado = 0;

                if (row.Cells[2].Value.ToString() == "Ativo")
                {
                    estado = 1;
                }

                this.autor = new AutorModel(id, Nome, estado);
            }
        }

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewAutor.DataSource = null;
        }
    }
}
