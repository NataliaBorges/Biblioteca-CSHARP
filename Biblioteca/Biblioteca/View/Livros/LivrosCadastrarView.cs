using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Model;
using Biblioteca.Util;
using Biblioteca.View.Autor;
using Biblioteca.View.Emprestimo;
using Biblioteca.View.Fornecedor;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Biblioteca.View.Livros {
    public partial class LivrosCadastrarView : Form {

        LivroController controller = new LivroController();
        List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
        DateTime data;

        public LivrosCadastrarView() {
            InitializeComponent();
        }
        private void LivrosCadastrarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);
            //this.cbEditora.Items.Clear();
            //List<EditoraModel> editoras = controller.ListarEditora();
            //if (editoras.Count > 0)
            //{
            //    foreach (EditoraModel editora in editoras)
            //    {
            //        ComboBoxItem item = new ComboBoxItem(editora.Nome, editora.ID.ToString());
            //        cbEditora.Items.Add(item);
            //        comboBoxItems.Add(item);
            //    }

            //    cbEditora.ValueMember = "Value";
            //    cbEditora.DisplayMember = "Text";
            //    cbEditora.DropDownStyle = ComboBoxStyle.DropDownList;
            //}
        }

        private void ClearForm() {
            this.tbNome.Clear();
            this.tbAutor.Clear();
            this.tbEdicao.Clear();
            this.maskedTextBoxAno.Clear();
            this.tbISBN.Clear();
            this.tbEditora.Clear();
            this.tbGenero.Clear();
            this.tbQuantidade.Clear();
        }

        private void button1_Click(object sender, EventArgs e) {
            String nome = tbNome.Text;
            String autor = tbAutor.Text;
            String edicao = tbEdicao.Text;
            String ano = maskedTextBoxAno.Text;
            String ISBN = tbISBN.Text;
            String Editora = tbEditora.Text;
            String Genero = tbGenero.Text;
            String Quantidade = tbQuantidade.Text;

            if (nome.Length <= 0) {
                MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                tbNome.Focus();
            }
            else if (autor.Length <= 0) {
                MessageBox.Show("Você precisa digitar um Autor.", "Atenção", MessageBoxButtons.OK);
                tbAutor.Focus();
            }
            else if (edicao.Length <= 0) {
                MessageBox.Show("Você precisa digitar uma Edição.", "Atenção", MessageBoxButtons.OK);
                tbEdicao.Focus();
            }
            else if (ano == "" ) {
                MessageBox.Show("Você precisa digitar um ano.", "Atenção", MessageBoxButtons.OK);
                maskedTextBoxAno.Focus();
            }
            else if(tbISBN.Text.Length < 13) {
                MessageBox.Show("Você precisa digitar um ISBN Válido.", "Atenção", MessageBoxButtons.OK);
                tbISBN.Focus();
            }
            else if(tbEditora.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa selecionar uma Editora Válida.", "Atenção", MessageBoxButtons.OK);
                tbEditora.Focus();
            }
            else if (tbGenero.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa selecionar um Gênero Válido.", "Atenção", MessageBoxButtons.OK);
                tbGenero.Focus();
            }
            else if (tbQuantidade.Text.Length <= 0)
            {
                MessageBox.Show("Você precisa digitar uma quantidade válida.", "Atenção", MessageBoxButtons.OK);
                tbQuantidade.Focus();
            }
            //else {
            //    //LivroModel livro = new LivroModel(nome, Editora, autor, ano, edicao, ISBN, Genero, Quantidade);
            //    if (controller.Insercao(livro)) {
            //        MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
            //        this.Close();
            //    }
            //    else {
            //        MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
            //    }
            //}   
            
        }
        private void btnPesqAutor_Click_1(object sender, EventArgs e)
        {
            LivroPesquisarAutor livroPesquisarAutor = new LivroPesquisarAutor();
            NovaJanela.novaJanela(livroPesquisarAutor, this.Bounds);
        }

        private void btlPesqEditora_Click(object sender, EventArgs e)
        {
            EditoraCadastrarView editoraCadastrarView = new EditoraCadastrarView();
            NovaJanela.novaJanela(editoraCadastrarView, this.Bounds);
        }

        private void btnPesqGenero_Click(object sender, EventArgs e)
        {

        }

        private void LivrosCadastrarView_Load_1(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);
        }

        private void btnPesqAutor_Click(object sender, EventArgs e)
        {
            LivroPesquisarAutor livroPesquisarAutor = new LivroPesquisarAutor();
            NovaJanela.novaJanela(livroPesquisarAutor, this.Bounds);
        }

        private void btlPesqEditora_Click_1(object sender, EventArgs e)
        {
            LivroPesquisarEditora livroPesquisarEditora= new LivroPesquisarEditora();
            NovaJanela.novaJanela(livroPesquisarEditora, this.Bounds);
        }

        private void btnPesqGenero_Click_1(object sender, EventArgs e)
        {
            LivroPesquisarGenero livroPesquisarGenero = new LivroPesquisarGenero();
            NovaJanela.novaJanela(livroPesquisarGenero, this.Bounds);
        }

        private void LinkLblCadastroEmprestimo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditoraCadastrarView editoraCadastrarView = new EditoraCadastrarView();
            NovaJanela.novaJanela(editoraCadastrarView, this.Bounds);
        }

        private void linklblCadastrarAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AutorCadastrarView autorCadastrarView = new AutorCadastrarView();
            NovaJanela.novaJanela(autorCadastrarView, this.Bounds);
        }
    }
}
