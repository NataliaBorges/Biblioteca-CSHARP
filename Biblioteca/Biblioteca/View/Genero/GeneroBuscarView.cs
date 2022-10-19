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
        GeneroModel genero;
        public GeneroBuscarView()
        {
            InitializeComponent();
            TbGenero.Enabled = false;
        }

        private void GeneroBuscarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            cbStatus.Text = "Ambos";
        }
        private void popular(List<GeneroModel> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Status", typeof(string));
            dtGridViewGenero.DataSource = lista;
            if (lista.Count > 0)
            {
                foreach (GeneroModel genero in lista)
                {

                    table.Rows.Add(genero.getId(), genero.Nome_genero, genero.getEstado());

                }
                dtGridViewGenero.DataSource = table;
            }
            int index = dtGridViewGenero.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewGenero.Rows[index].Selected = false;
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

        private void btnCadastrarGenero_Click(object sender, EventArgs e)
        {
            GeneroCadastrarView generoCadastrarView = new GeneroCadastrarView();
            NovaJanela.novaJanela(generoCadastrarView, this.Bounds);
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            TbGenero.Text = "";
            TbGenero.Enabled = false;
            this.genero = null;
            String busca = tbBuscar.Text;
            String status = cbStatus.Text;

            List<GeneroModel> lista = controller.BuscarGenero(busca, status);

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
                String Nome = row.Cells[1].Value.ToString();
                int estado = 0;

                if (row.Cells[2].Value.ToString() == "Ativo")
                {
                    estado = 1;
                }

                this.genero = new GeneroModel(id, Nome, estado);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (genero != null)
                {
                    TbGenero.Enabled = true;
                }
                TbGenero.Text = this.genero.Nome_genero;
                cbEditarStatus.Text = this.genero.getEstado();
            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar um gênero", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string generoLivro = TbGenero.Text;

            if (TbGenero.Text.Length <= 0 || genero == null)
            {
                TbGenero.Enabled = false;
                MessageBox.Show("Você precisa selecionar um gênero", "Atenção", MessageBoxButtons.OK);
                TbGenero.Focus();
            }
            else
            {
                TbGenero.Enabled = true;
                int estado = 0;

                if (cbEditarStatus.Text == "Ativo")
                {
                    estado = 1;
                }
                GeneroModel livroGenero = new GeneroModel(genero.Id_genero, generoLivro, estado);
                if (controller.Atualizar(livroGenero))
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

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewGenero.DataSource = null;
        }
    }
}
