using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;
using Biblioteca.View.Emprestimo;

namespace Biblioteca.View.Emprestimo {
    public partial class EmprestimoBuscarView : Form {

        EmprestimoController controller = new EmprestimoController();

        public EmprestimoBuscarView() {
            InitializeComponent();
        }

        private void EmpretimoBuscarView_Load(object sender, EventArgs e) {
            this.menuControl1.setPanel(pnltotal);

            List<EmprestimoPesquisaModel> lista = controller.ListarTodosBusca();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            List<EmprestimoPesquisaModel> lista = controller.ListarTodosBusca();
            popular(lista);
        }

        private void popular(List<EmprestimoPesquisaModel> lista) {
            //lvEmprestimo.Items.Clear();
            //if (lista.Count > 0) {
            //    foreach (EmprestimoPesquisaModel emprestimo in lista) {
            //        ListViewItem item = new ListViewItem(emprestimo.ID_emprestimo.ToString());
            //        item.SubItems.Add(emprestimo.Nome_Leitor);
            //        item.SubItems.Add(emprestimo.Nome_Livro);
            //        item.SubItems.Add(emprestimo.Nome_funcionario);
            //        item.SubItems.Add(emprestimo.Data_emprestimo.ToString("dd/MM/yyyy"));
            //        item.SubItems.Add(emprestimo.Data_devolucao.ToString("dd/MM/yyyy"));
            //        item.SubItems.Add(emprestimo.Status);
            //        lvEmprestimo.Items.Add(item);
            //    //}
            //}
        }

        //private void btnSalvar_Click(object sender, EventArgs e) {
        //    String busca = tbBuscar.Text;

        //    if (rbLivro.Checked) {
        //        List<EmprestimoPesquisaModel> lista = controller.Buscar(busca, isLivro: true);
        //        popular(lista);
        //    }

        //    if (rbLeitor.Checked) {
        //        List<EmprestimoPesquisaModel> lista = controller.Buscar(busca, isLeitor: true);
        //        popular(lista);
        //    }
        //    if (rbCodigo.Checked) {
        //        List<EmprestimoPesquisaModel> lista = controller.Buscar(busca, isCodigo: true);
        //        popular(lista);
        //    }
        //}

        //private void lvEmprestimo_MouseClick(object sender, MouseEventArgs e) {
        //    ListViewItem item = lvEmprestimo.Items[lvEmprestimo.FocusedItem.Index];
        //    EmprestimoPesquisaModel pesquisa = new EmprestimoPesquisaModel(
        //            int.Parse(item.SubItems[0].Text),
        //            item.SubItems[1].Text,
        //            item.SubItems[2].Text,
        //            item.SubItems[3].Text,
        //            DateTime.Parse(item.SubItems[4].Text),
        //            DateTime.Parse(item.SubItems[5].Text),
        //            item.SubItems[6].Text
        //        );

        //    EmprestimoExcluirView editar = new EmprestimoExcluirView(pesquisa);
        //    NovaJanela.novaJanela(editar, this.Bounds);
        //}

        //private void btnExcluir_Click(object sender, EventArgs e) {
        //    this.Close();
        //}
    }
}
