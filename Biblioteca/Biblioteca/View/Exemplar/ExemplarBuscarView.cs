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

namespace Biblioteca.View.Exemplar
{
    public partial class ExemplarBuscarView : Form
    {
        ExemplarController controller = new ExemplarController();
        ExemplarModel exemplar;
        public ExemplarBuscarView()
        {
            InitializeComponent();
        }
        private void ExemplarBuscarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            CbEstado.Text = "Ambos";
        }
        private void popular(List<ExemplarModel> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Título", typeof(string));
            table.Columns.Add("Autor", typeof(string));
            table.Columns.Add("Edição", typeof(string));
            table.Columns.Add("Editora", typeof(string));
            table.Columns.Add("Gênero", typeof(string));
            table.Columns.Add("Aquisição", typeof(DateTime));
            table.Columns.Add("ISBN", typeof(string));
            table.Columns.Add("Ano", typeof(string));
            table.Columns.Add("Valor", typeof(float));
            table.Columns.Add("Estado", typeof(string));

            if (lista.Count > 0)
            {
                foreach (ExemplarModel exemplar in lista)
                {

                    table.Rows.Add(exemplar.getId(),
                                   exemplar.Titulo,
                                   exemplar.Nome_Autor,
                                   exemplar.Nome_Edicao,
                                   exemplar.Nome_Editora,
                                   exemplar.Nome_Genero,
                                   exemplar.Aquisicao,
                                   exemplar.ISBN,
                                   exemplar.AnoPublicacao,
                                   exemplar.Valor,
                                   exemplar.getEstado());
                }
                dtGridViewExemplar.DataSource = table;
            }
            int index = dtGridViewExemplar.SelectedRows[0].Index;

            if (index >= 0)
            {
                dtGridViewExemplar.Rows[index].Selected = false;
            }
        }
        private void dtGridViewExemplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtGridViewExemplar.SelectedRows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                String titulo = row.Cells[1].Value.ToString();
                String autor = row.Cells[2].Value.ToString();
                String edicao = row.Cells[3].Value.ToString();
                String editora = row.Cells[4].Value.ToString();
                String genero = row.Cells[5].Value.ToString();
                DateTime aquisicao = DateTime.Parse(row.Cells[6].Value.ToString());
                string isbn = row.Cells[7].Value.ToString();
                string ano = row.Cells[8].Value.ToString();
                float valor = float.Parse(row.Cells[9].Value.ToString());

                int estado = 0;

                if (row.Cells[10].Value.ToString() == "Ativo")
                {
                    estado = 1;
                }
                this.exemplar = new ExemplarModel(id, titulo, edicao, aquisicao, ano, isbn, editora, autor,   genero, valor,  estado);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (exemplar != null)
            {
                ExemplarEditarView exemplarEditarView = new ExemplarEditarView(exemplar);
                NovaJanela.novaJanela(exemplarEditarView, Bounds);
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um livro", "Atenção", MessageBoxButtons.OK);
            }
        }
        private void buscar(List<ExemplarModel> lista)
        {

            if (lista.Count > 0)
            {
                lblNotFound.Visible = false;
                popular(lista);
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewExemplar.DataSource = null;
            }
        }
        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            this.exemplar = null;
            String busca = tbBuscar.Text;
            String status = CbEstado.Text;

            if (tbBuscar.Text.Length > 0)
            {
                lblNotFound.Visible = false;

                if (rbNome.Checked)
                {
                    List<ExemplarModel> nome = controller.Buscar(busca, isNome: true, status: status);
                    buscar(nome);
                }
                else if (rbCodigo.Checked)
                {
                    List<ExemplarModel> codigo = controller.Buscar(busca, isCodigo: true, status: status);
                    buscar(codigo);
                }
                else if (rbAutor.Checked)
                {
                    List<ExemplarModel> autor = controller.Buscar(busca, isAutor: true, status: status);
                    buscar(autor);
                }
                else if (rbEditora.Checked)
                {
                    List<ExemplarModel> editora = controller.Buscar(busca, isEditora: true, status: status);
                    buscar(editora);
                }
                else if (rbGenero.Checked)
                {
                    List<ExemplarModel> genero = controller.Buscar(busca, isGenero: true, status: status);
                    buscar(genero);
                }
                else
                {
                    List<ExemplarModel> nome = controller.Buscar(busca, isNome: true, status: status);
                    buscar(nome);
                }
            }
            else if (tbBuscar.Text.Length == 0)
            {
                lblNotFound.Visible = false;
                dtGridViewExemplar.DataSource = null;
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewExemplar.DataSource = null;
            }
        }

        private void btnCadastrarExemplar_Click(object sender, EventArgs e)
        {
            ExemplarBuscarLivroView exemplarBuscarLivroView = new ExemplarBuscarLivroView();
            NovaJanela.novaJanela(exemplarBuscarLivroView, Bounds);
        }

        private void clear()
        {
            tbBuscar.Text = null;
            dtGridViewExemplar.DataSource = null;
            rbNome.Checked = false;
            rbCodigo.Checked = false;
            rbAutor.Checked = false;
            rbEditora.Checked = false;
            rbGenero.Checked = false;
        }

        private void CbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            clear();
        }

        private void rbCodigo_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewExemplar.DataSource = null;
        }

        private void rbNome_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewExemplar.DataSource = null;
        }

        private void rbAutor_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewExemplar.DataSource = null;
        }

        private void rbEditora_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewExemplar.DataSource = null;
        }

        private void rbGenero_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscar.Text = null;
            dtGridViewExemplar.DataSource = null;
        }

        private void ExemplarBuscarView_Activated(object sender, EventArgs e)
        {
            clear();
        }
    }
}
