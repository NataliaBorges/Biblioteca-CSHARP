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
            LvExemplar.Items.Clear();
            if (lista.Count > 0) {
                foreach (ExemplarModel exemplar in lista) {
                    ListViewItem item = new ListViewItem(exemplar.getId().ToString());
                    item.SubItems.Add(exemplar.Nome);
                    item.SubItems.Add(exemplar.Autor);
                    item.SubItems.Add(exemplar.Edicao);
                    item.SubItems.Add(exemplar.AnoPublicacao);
                    item.SubItems.Add(exemplar.ISBN);
                    item.SubItems.Add(exemplar.Fornecedor);
                    item.SubItems.Add(exemplar.Aquisicao.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(exemplar.Estado);

                    LvExemplar.Items.Add(item);
                }
            }
        }

        private void LvExemplar_MouseClick_1(object sender, MouseEventArgs e) {
            ListViewItem item = LvExemplar.Items[LvExemplar.FocusedItem.Index];
            ExemplarModel exemplar = new ExemplarModel(
                int.Parse(item.SubItems[0].Text),
                item.SubItems[1].Text,
                item.SubItems[2].Text,
                item.SubItems[6].Text,
                item.SubItems[5].Text,
                item.SubItems[3].Text,
                item.SubItems[4].Text,
                DateTime.Parse(item.SubItems[7].Text),
                item.SubItems[8].Text
            );
            //DialogResult dialogResult = MessageBox.Show("Você realmente deseja inativar?", "Atenção", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes) {
            //    controller.RemoverExemplarEmprestimo(exempar);
            //    popularExemplar(controller.PegarExemplarEmprestimo());
            //}
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            EmprestimoCadastroView emprestimoCadastrarView = new EmprestimoCadastroView();
            NovaJanela.novaJanela(emprestimoCadastrarView, this.Bounds);
        }

        private void LvExemplar_MouseDoubleClick(object sender, MouseEventArgs e) {
            ListViewItem item = LvExemplar.Items[LvExemplar.FocusedItem.Index];
            ExemplarModel exemplar = new ExemplarModel(
                int.Parse(item.SubItems[0].Text),
                item.SubItems[1].Text,
                item.SubItems[2].Text,
                item.SubItems[6].Text,
                item.SubItems[5].Text,
                item.SubItems[3].Text,
                item.SubItems[4].Text,
                DateTime.Parse(item.SubItems[7].Text),
                item.SubItems[8].Text

            );
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja inativar?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                controller.InativarExemplar(exemplar.getId());
                popular(controller.PegarExemplar());
            }
        }
    }
}
