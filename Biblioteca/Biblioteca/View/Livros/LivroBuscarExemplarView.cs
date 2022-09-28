using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.View.Emprestimo;
using Biblioteca.Util;

namespace Biblioteca.View.Livros {
    public partial class LivroBuscarExemplarView : Form {

        LivroController controller = new LivroController();

        int idLivro;
        
        public LivroBuscarExemplarView(int idLivro) {

            this.idLivro = idLivro;
            InitializeComponent();
        }
        private void LivroBuscarExemplarView_Load(object sender, EventArgs e) {

            this.menuControl1.setPanel(pnltotal);
            List<ExemplarModel> lista = controller.ListarTodosExemplares(idLivro);
            popular(lista);
        }
        protected override void OnActivated(EventArgs e) {
            List<ExemplarModel> lista = controller.ListarTodosExemplares(idLivro);
            popular(lista);
        }
        private void popular(List<ExemplarModel> lista) {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Título", typeof(string));
            table.Columns.Add("Edição", typeof(string));
            table.Columns.Add("Aquisição", typeof(string));
            table.Columns.Add("Ano", typeof(string));
            table.Columns.Add("ISBN", typeof(string));
            table.Columns.Add("Autor", typeof(string));
            table.Columns.Add("Editora", typeof(string));
            table.Columns.Add("Gênero", typeof(string));

            dtGridViewExemplar.DataSource = lista;
            if (lista.Count > 0)
            {
                foreach (ExemplarModel exemplar in lista)
                {

                    table.Rows.Add(exemplar.getId(),
                                   exemplar.Titulo,
                                   exemplar.Edicao,
                                   exemplar.Aquisicao,
                                   exemplar.AnoPublicacao,
                                   exemplar.ISBN,
                                   exemplar.Nome_Autor,
                                   exemplar.Nome_Editora,
                                   exemplar.Nome_Genero);
                }
                dtGridViewExemplar.DataSource = table;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            int quantidade = int.Parse(tbQuantidade.Text); 
            if (controller.InserirMaisExmplares(quantidade, idLivro)) {
                MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
                List<ExemplarModel> lista = controller.ListarTodosExemplares(idLivro);
                popular(lista);
            }
            else {
                MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
            }
        }
        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            EmprestimoCadastroView emprestimoCadastrarView = new EmprestimoCadastroView();
            NovaJanela.novaJanela(emprestimoCadastrarView, this.Bounds);
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGridViewExemplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
