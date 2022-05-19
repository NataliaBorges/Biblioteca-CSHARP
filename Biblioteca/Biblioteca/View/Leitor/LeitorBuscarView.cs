﻿using System;
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
        public LeitorBuscarView() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            String busca = tbBuscar.Text;

            if (rbNome.Checked) {
                List<LeitorModel> lista = controller.Buscar(busca, isNome: true);
                popular(lista);
            }

            if (rbCPF.Checked) {
                List<LeitorModel> lista = controller.Buscar(busca, isCPF: true);
                popular(lista);
            }
        }

        private void popular(List<LeitorModel> lista) {
            LvLeitor.Items.Clear();
            if (lista.Count > 0) {
                foreach (LeitorModel leitor in lista) {
                    ListViewItem item = new ListViewItem(leitor.getId().ToString());
                    item.SubItems.Add(leitor.Nome);
                    item.SubItems.Add(leitor.DataNascimento.ToString());
                    item.SubItems.Add(leitor.Telefone);
                    item.SubItems.Add(leitor.CPF);
                    item.SubItems.Add(leitor.Endereco);
                    item.SubItems.Add(leitor.Email);

                    LvLeitor.Items.Add(item);
                }
            }
        }

        private void LeitorBuscarView_Load(object sender, EventArgs e) {
            List<LeitorModel> lista = controller.ListarTodos();
            popular(lista);
        }

        protected override void OnActivated(EventArgs e) {
            List<LeitorModel> lista = controller.ListarTodos();
            popular(lista);
        }

        private void LvLeitor_MouseClick(object sender, MouseEventArgs e) {
            ListViewItem item = LvLeitor.Items[LvLeitor.FocusedItem.Index];
            LeitorModel leitor = new LeitorModel(
                int.Parse(item.SubItems[0].Text),
                item.SubItems[1].Text,
                DateTime.Parse(item.SubItems[2].Text),
                item.SubItems[3].Text,
                item.SubItems[4].Text,
                item.SubItems[5].Text,
                item.SubItems[6].Text
            );

            LeitorEditarView editar = new LeitorEditarView(leitor);
            NovaJanela.novaJanela(editar, this.Bounds);
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            LeitorCadastrarView leitorCadastrarView = new LeitorCadastrarView();
            NovaJanela.novaJanela(leitorCadastrarView, this.Bounds);

        }
    }
}
