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
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            List<GeneroModel> lista = controller.ListarUltimosDez();
            popular(lista);
        }
        private void ClearForm()
        {
            this.tbNome.Clear();
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

                int index = dtGridViewGenero.SelectedRows[0].Index;

                if (index >= 0)
                {
                    dtGridViewGenero.Rows[index].Selected = false;
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String nome = tbNome.Text;


            if (nome.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                tbNome.Focus();
            }
            else
            {
                GeneroModel genero = new GeneroModel(nome);
                if (controller.Insercao(genero))
                {
                    List<GeneroModel> lista = controller.ListarUltimosDez();
                    popular(lista);

                    ClearForm();            }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
                }
            }
        }
    }
}
