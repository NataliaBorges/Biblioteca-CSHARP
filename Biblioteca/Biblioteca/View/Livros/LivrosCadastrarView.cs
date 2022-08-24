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
            this.maskedTextBoxAquisição.Clear();
            this.tbISBN.Clear();
        }

        private void button1_Click(object sender, EventArgs e) {
            if(tbGenero == null) {
                MessageBox.Show("você selecionar uma editora.", "atenção", MessageBoxButtons.OK);
                tbGenero.Focus();
            }
            else {
                //int posicao = comboBoxItems.FindIndex(item => item.Text == cbEditora.SelectedItem.ToString());
                //int IdEditora = int.Parse(comboBoxItems[posicao].Value);
                String nome = tbNome.Text;
                String autor = tbAutor.Text;
                String edicao = tbEdicao.Text;
                String ano = maskedTextBoxAno.Text;
                DateTime data = this.data; //.ToString("yyyy-MM-dd");
                String ISBN = tbISBN.Text;
                int Quantidade = int.Parse(tbQuantidade.Text);

                if (nome.Length <= 0) {
                    MessageBox.Show("Você precisa digitar um nome.", "Atenção", MessageBoxButtons.OK);
                    tbNome.Focus();
                }
                //else if (cbEditora == null) {
                //    MessageBox.Show("Você selecionar uma editora.", "Atenção", MessageBoxButtons.OK);
                //    cbEditora.Focus();
                //}
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
                else if (maskedTextBoxAquisição.Text == "  /  /") {
                    MessageBox.Show("Você precisa digitar uma data de aquisição.", "Atenção", MessageBoxButtons.OK);
                    maskedTextBoxAquisição.Focus();
                }
                else if(tbISBN.Text.Length < 13) {
                    MessageBox.Show("Você precisa digitar um ISBN Válido.", "Atenção", MessageBoxButtons.OK);
                }
                else {
                    LivroModel livro = new LivroModel(nome, autor, edicao, ano, data, ISBN);
                    livro.Quantidade = Quantidade;
                    if (controller.Insercao(livro)) {
                        MessageBox.Show("Cadastrado com sucesso", "Parabéns", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Não foi possível cadastrar.", "Atenção", MessageBoxButtons.OK);
                    }
                }
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e) {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            EditoraCadastrarView editoraCadastrarView = new EditoraCadastrarView();
            NovaJanela.novaJanela(editoraCadastrarView, this.Bounds);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnPesqAutor_Click(object sender, EventArgs e)
        {
            LivroPesquisarAutor livroPesquisarAutor = new LivroPesquisarAutor();
            NovaJanela.novaJanela(livroPesquisarAutor, this.Bounds);
        }
    }
}
