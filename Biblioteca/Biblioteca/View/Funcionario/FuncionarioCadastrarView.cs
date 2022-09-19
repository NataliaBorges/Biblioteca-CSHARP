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

namespace Biblioteca.View.Funcionario {
    public partial class FuncionarioCadastrarView : Form {
        FuncaoController funcaoController = new FuncaoController();
        List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
        FuncionarioController funcionarioController = new FuncionarioController();
        DateTime data;

        public FuncionarioCadastrarView() {
            InitializeComponent();
        }

        private void ClearForm() {
            this.tbNome.Clear();
            this.tbRua.Clear();
            this.tbNumero.Clear();
            this.tbBairro.Clear();
            this.tbCidade.Clear();
            this.maskedTextBoxTelefone.Clear();
            this.maskedTextBoxCPF.Clear();
            this.maskedTextBoxNascimento.Clear();
            this.tbSenha.Clear();
            this.tbEmail.Clear();
            this.cbFuncao.SelectedIndex = -1;
        }


        private void button1_Click(object sender, EventArgs e) {
            String nome = tbNome.Text;
            String endereco = $"{tbRua.Text}, {tbNumero.Text}, {tbBairro.Text} - {tbCidade.Text}";
            String telefone = maskedTextBoxTelefone.Text;
            String cpf = maskedTextBoxCPF.Text;
            String senha = tbSenha.Text;
            String email = tbEmail.Text;
            DateTime data = this.data; //.ToString("yyyy-MM-dd");
            String funcao = this.cbFuncao.Text;


            if (nome.Length <= 0) {
                MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                tbNome.Focus();
            }
            else if (tbRua.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar uma Rua.", "Atenção", MessageBoxButtons.OK);
                tbRua.Focus();
            }
            else if (tbNumero.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar um número.", "Atenção", MessageBoxButtons.OK);
                tbNumero.Focus();
            }
            else if (tbBairro.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar um bairro.", "Atenção", MessageBoxButtons.OK);
                tbBairro.Focus();
            }
            else if (telefone == "(  )     -") {
                MessageBox.Show("Você precisa digitar um telefone.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxTelefone.Focus();
            }
            else if (tbCidade.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar uma cidade.", "Atenção", MessageBoxButtons.OK);
                tbCidade.Focus();
            }
            else if (Validar.ValidaCpf(cpf) == false) {
                MessageBox.Show("Você precisa digitar uma CPF.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxCPF.Focus();
            }
            else if (Validar.ValidarEmail(email) == false) {
                MessageBox.Show("Você precisa digitar um email.", "Atenção", MessageBoxButtons.OK);
                tbEmail.Focus();
            }
            else if (tbSenha.Text.Length <= 0) {
                MessageBox.Show("Você precisa digitar uma senha.", "Atenção", MessageBoxButtons.OK);
                tbSenha.Focus();
            }
            else if (maskedTextBoxNascimento.Text == "  /  /") {
                MessageBox.Show("Você precisa digitar uma data de Nascimento.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxNascimento.Focus();
            }
            else if (cbFuncao == null) {
                MessageBox.Show("Você selecionar uma editora.", "Atenção", MessageBoxButtons.OK);
                cbFuncao.Focus();
            }
            else {
                FuncionarioModel funcionario = new FuncionarioModel(nome, cpf, data, email, endereco, telefone, senha, funcao);
                if (funcionarioController.Insercao(funcionario)) {
                    MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
                    ClearForm();
                }
                else {
                    MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
                }
                this.Close();
            }

        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e) {
            maskedTextBoxNascimento.Text = calendar.SelectionRange.Start.ToString("dd/MM/yyyy");
            int ano = int.Parse(calendar.SelectionRange.Start.ToString("yyyy"));
            int mes = int.Parse(calendar.SelectionRange.Start.ToString("MM"));
            int dia = int.Parse(calendar.SelectionRange.Start.ToString("dd"));
            data = new DateTime(ano, mes, dia);
        }

        private void LinkBuscarFuncionario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FuncionarioBuscarView funcionarioBuscarView = new FuncionarioBuscarView();
            NovaJanela.novaJanela(funcionarioBuscarView, this.Bounds);
        }

        private void FuncionarioCadastrarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setPanel(pnltotal);
            this.cbFuncao.Items.Clear();
            List<FuncaoModel> funcoes = funcaoController.ListarTodos();
            if (funcoes.Count > 0)
            {
                foreach (FuncaoModel funcao in funcoes)
                {
                    ComboBoxItem item = new ComboBoxItem(funcao.Nome, funcao.Id.ToString());
                    cbFuncao.Items.Add(item);
                    comboBoxItems.Add(item);
                }

                cbFuncao.ValueMember = "Value";
                cbFuncao.DisplayMember = "Text";
                cbFuncao.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void icbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
