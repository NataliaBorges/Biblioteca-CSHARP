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

namespace Biblioteca.View.Funcionario {
    public partial class FuncionarioBuscarView : Form {

        FuncionarioController controller = new FuncionarioController();

        public FuncionarioBuscarView() {
            InitializeComponent();
        }
        //private void Lvfuncionario_MouseClick(object sender, MouseEventArgs e) {
        //    ListViewItem item = Lvfuncionario.Items[Lvfuncionario.FocusedItem.Index];
        //    FuncionarioModel funcionario = new FuncionarioModel(
        //        int.Parse(item.SubItems[0].Text),
        //        item.SubItems[1].Text,
        //        item.SubItems[4].Text,
        //        DateTime.Parse(item.SubItems[2].Text),
        //        item.SubItems[6].Text,
        //        item.SubItems[5].Text,
        //        item.SubItems[3].Text
        //    );

        //    FuncionarioEditarView editar = new FuncionarioEditarView(funcionario);
        //    NovaJanela.novaJanela(editar, this.Bounds);
        //}

        private void button1_Click(object sender, EventArgs e) {
            String busca = tbBuscar.Text;

            if (rbNome.Checked) {
                List<FuncionarioModel> lista = controller.Buscar(busca, isNome: true);
                popular(lista);
            }

            if (rbEmail.Checked) {
                List<FuncionarioModel> lista = controller.Buscar(busca, isEmail: true);
                popular(lista);
            }
        }

        private void popular(List<FuncionarioModel> lista) {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("CPF", typeof(string));
            table.Columns.Add("Nascimento", typeof(DateTime));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Endereço", typeof(string));
            table.Columns.Add("Telefone", typeof(string));
            table.Columns.Add("Função", typeof(string));
            table.Columns.Add("Status", typeof(string));
            dtGridViewFuncionario.DataSource = lista;
            if (lista.Count > 0)
            {
                foreach (FuncionarioModel funcionario in lista)
                {

                    table.Rows.Add(funcionario.getId(),
                                   funcionario.Nome_funcionario,
                                   funcionario.CPF,
                                   funcionario.Data_Nascimento,
                                   funcionario.Email,
                                   funcionario.Endereco,
                                   funcionario.Telefone,
                                   funcionario.Funcao,
                                   funcionario.Estado);
                }
                dtGridViewFuncionario.DataSource = table;
            }
        }

        private void FuncionarioBuscarView_Load(object sender, EventArgs e) {
            this.menuControl1.setPanel(pnltotal);
            List<FuncionarioModel> lista = controller.ListarTodos();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            List<FuncionarioModel> lista = controller.ListarTodos();
            popular(lista);
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void LinkCadastrarFuncionario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            FuncionarioCadastrarView funcionarioCadastrarView = new FuncionarioCadastrarView();
            NovaJanela.novaJanela(funcionarioCadastrarView, this.Bounds);
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
