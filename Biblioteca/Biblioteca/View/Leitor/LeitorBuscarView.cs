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

namespace Biblioteca.View.Leitor {
    public partial class LeitorBuscarView : Form {

        LeitorController controller = new LeitorController();
        EstadoController controllerEstado = new EstadoController();
        List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
        public LeitorBuscarView() {
            InitializeComponent();
        }

        private void popular(List<LeitorModel> lista) {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Telefone", typeof(string));
            table.Columns.Add("Nascimento", typeof(DateTime));
            table.Columns.Add("CPF", typeof(string));
            table.Columns.Add("Endereço", typeof(string));
            table.Columns.Add("Status", typeof(string));
            dtGridViewLeitor.DataSource = lista;
            if (lista.Count > 0)
            {
                foreach (LeitorModel leitor in lista)
                {

                    table.Rows.Add(leitor.getId(), 
                                   leitor.Nome,
                                   leitor.Email,
                                   leitor.Telefone,
                                   leitor.DataNascimento,
                                   leitor.CPF,
                                   leitor.Endereco,
                                   leitor.Estado);
                }
                dtGridViewLeitor.DataSource = table;
            }
        }

        private void LeitorBuscarView_Load(object sender, EventArgs e) {
            this.menuControl1.setPanel(pnltotal);

            this.cbStatus.Items.Clear();
            List<EstadoModel> status = controllerEstado.ListarTodos();
            if (status.Count > 0)
            {
                foreach (EstadoModel estado in status)
                {
                    ComboBoxItem item = new ComboBoxItem(estado.Nome, estado.Id.ToString());
                    cbStatus.Items.Add(item);
                    comboBoxItems.Add(item);
                }

                cbStatus.ValueMember = "Value";
                cbStatus.DisplayMember = "Text";
                cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            }

            int statusLeitor = 0;
            foreach (ComboBoxItem item in comboBoxItems)
            {
                if (cbStatus.Text == item.Text)
                {
                    statusLeitor = int.Parse(item.Value);
                }
            }

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            LeitorCadastrarView leitorCadastrarView = new LeitorCadastrarView();
            NovaJanela.novaJanela(leitorCadastrarView, this.Bounds);
        }
        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            String busca = tbBuscar.Text;


            if (tbBuscar.Text.Length > 0 /*&& lista.Count > 0*/)
            {
                lblNotFound.Visible = false;

                if (rbNome.Checked)
                {
                    List<LeitorModel> autor = controller.Buscar(busca, isNome: true);
                    popular(autor);
                }

                if (rbCPF.Checked)
                {
                    List<LeitorModel> cpf = controller.Buscar(busca, isCPF: true);
                    popular(cpf);
                }
            }
            else if (tbBuscar.Text.Length == 0)
            {
                lblNotFound.Visible = false;
                dtGridViewLeitor.DataSource = null;
            }
            else
            {
                lblNotFound.Visible = true;
                dtGridViewLeitor.DataSource = null;
            }
        }
    }
}
