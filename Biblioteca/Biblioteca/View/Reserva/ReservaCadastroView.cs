using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.View.Reserva;
using Biblioteca.Util;

namespace Biblioteca.View.Reserva {
    public partial class ReservaCadastroView : Form {

        DateTime dataReserva;
        ReservaController controller = new ReservaController();
        Singleton singleton = Singleton.GetInstancia();

        public ReservaCadastroView() {
            InitializeComponent(); 
        }


        private void ReservaCadastroView_Load(object sender, EventArgs e) {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);


            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            //popularExemplar(controller.PegarExemplarReserva());
            //popularLeitor(controller.PegarLeitorReserva());
        }
        //private void cbLeitor_TextChanged(object sender, EventArgs e)
        //{
        //    if (cbLeitor.SelectedIndex < 0)
        //    {
        //        cbLeitor.Text = "Digite aqui";
        //    }
        //    else
        //    {
        //        cbLeitor.Text = cbLeitor.SelectedText;
        //    }
        //}


        //protected override void OnActivated(EventArgs e) {
        //    popularExemplar(controller.PegarExemplarReserva());
        //    popularLeitor(controller.PegarLeitorReserva());
        //}

        //private void popularExemplar(List<ExemplarModel> lista) {
        //    lvLivros.Items.Clear();
        //    if (lista.Count > 0) {
        //        foreach (ExemplarModel exemplar in lista) {
        //            ListViewItem item = new ListViewItem(exemplar.getId().ToString());
        //            item.SubItems.Add(exemplar.Titulo);
        //            //item.SubItems.Add(exemplar.Edicao);
        //            item.SubItems.Add(exemplar.AnoPublicacao);
        //            item.SubItems.Add(exemplar.ISBN);
        //            item.SubItems.Add(exemplar.Aquisicao.ToString("dd/MM/yyyy"));
        //            item.SubItems.Add(exemplar.Nome_Autor);
        //            item.SubItems.Add(exemplar.Nome_Editora);
        //            item.SubItems.Add(exemplar.Nome_Genero);

        //            lvLivros.Items.Add(item);
        //        }
        //    }
        //}

        //private void popularLeitor(List<LeitorModel> lista) {
        //    lvLeitor.Items.Clear();
        //    if (lista.Count > 0) {
        //        foreach (LeitorModel leitor in lista) {
        //            if (leitor != null) {
        //                ListViewItem item = new ListViewItem(leitor.getId().ToString());
        //                item.SubItems.Add(leitor.Nome);
        //                item.SubItems.Add(leitor.DataNascimento.ToString());
        //                item.SubItems.Add(leitor.Telefone);
        //                item.SubItems.Add(leitor.CPF);
        //                item.SubItems.Add(leitor.Endereco);

        //                lvLeitor.Items.Add(item);
        //            }
        //        }
        //    }
        //}

        //private void lvLivros_MouseClick(object sender, MouseEventArgs e) {
        //    ListViewItem item = lvLivros.Items[lvLivros.FocusedItem.Index];
        //    //LivroModel livro = new LivroModel(
        //        //int.Parse(item.SubItems[0].Text),
        //        //item.SubItems[1].Text,
        //        //item.SubItems[2].Text,
        //        //item.SubItems[4].Text,
        //        //item.SubItems[5].Text,
        //        //item.SubItems[3].Text
        //    //);


        //    DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
        //    if (dialogResult == DialogResult.Yes) {
        //        //controller.RemoverExemplarReserva(exemplar);
        //        popularExemplar(controller.PegarExemplarReserva());
        //    }
        //}

        //private void button1_Click(object sender, EventArgs e) {
        //    ReservaBuscarLeitorView leitor = new ReservaBuscarLeitorView();
        //    novaJanela(leitor);
        //}

        //private void lvLeitor_MouseClick(object sender, MouseEventArgs e) {
        //    ListViewItem item = lvLeitor.Items[lvLeitor.FocusedItem.Index];
        //    LeitorModel leitor = new LeitorModel(
        //        int.Parse(item.SubItems[0].Text),
        //        item.SubItems[1].Text,
        //        DateTime.Parse(item.SubItems[2].Text),
        //        item.SubItems[3].Text,
        //        item.SubItems[4].Text,
        //        item.SubItems[5].Text
        //    );

        //    DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
        //    if (dialogResult == DialogResult.Yes) {
        //        controller.RemoverLeitorReserva();
        //        popularLeitor(controller.PegarLeitorReserva());
        //    }
        //}

        //private void button3_Click(object sender, EventArgs e) {
        //    String Reserva = tbReserva.Text;
        //    String obs = tbObs.Text;

        //    // Cadastra Reserva
        //    controller.Insercao(Reserva, obs);

        //    // Pega o ID do Reserva cadastrado
        //    int idReserva = controller.BuscarUltimoReserva();

        //    // Cadastra no Item_Reserva cada livro relacionando com o Reserva
        //    foreach (ExemplarModel exemplar in this.singleton.getExemplar()) {
        //        controller.RelacionarExemplarReserva(idReserva, exemplar);
        //    }

        //    this.singleton.clearReserva();

        //    MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
        //    this.Close();
        //}
    }
}
