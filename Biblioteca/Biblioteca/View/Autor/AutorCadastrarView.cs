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

namespace Biblioteca.View.Autor
{
    public partial class AutorCadastrarView : Form
    {
        AutorController controller = new AutorController();
        public AutorCadastrarView()
        {
            InitializeComponent();
        }
        private void AutorCadastrarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            List<AutorModel> lista = controller.ListarUltimosDez();
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
                int index = dtGridViewAutor.SelectedRows[0].Index;

                if (index >= 0)
                {
                    dtGridViewAutor.Rows[index].Selected = false;
                }
            }
        }
        private void ClearForm()
        {
            this.tbNome.Clear();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String nome = tbNome.Text;
            

            if (nome.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar um autor.", "Atenção", MessageBoxButtons.OK);
                tbNome.Focus();
            }
            else
            {
                AutorModel autor = new AutorModel(nome);
                if (controller.Insercao(autor))
                {
                    List<AutorModel> lista = controller.ListarUltimosDez();
                    popular(lista);

                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar", "Atenção", MessageBoxButtons.OK);
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

        
    }
}
