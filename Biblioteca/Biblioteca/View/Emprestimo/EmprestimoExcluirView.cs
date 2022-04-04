using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Model;
using Biblioteca.Controller;

namespace Biblioteca.View.Emprestimo {
    public partial class EmprestimoExcluirView : Form {

        EmprestimoPesquisaModel emprestimo;
        EmprestimoController controller = new EmprestimoController();

        public EmprestimoExcluirView(EmprestimoPesquisaModel emprestimo) {
            this.emprestimo = emprestimo;
            InitializeComponent();
        }

        private void popular(List<EmprestimoModel> lista) {
            lvEmprestimo.Items.Clear();
            if (lista.Count > 0) {
                foreach (EmprestimoModel emprestimo in lista) {
                    ListViewItem item = new ListViewItem(emprestimo.getId().ToString());
                    item.SubItems.Add(emprestimo.IdFuncionario.ToString());
                    item.SubItems.Add(emprestimo.Funcionario);
                    item.SubItems.Add(emprestimo.IdLeitor.ToString());
                    item.SubItems.Add(emprestimo.Leitor);
                    item.SubItems.Add(emprestimo.DataEmprestimo.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(emprestimo.DataDevolucao.ToString("dd/MM/yyyy"));

                    lvEmprestimo.Items.Add(item);

                    ObsText.Text = emprestimo.Obs;

                    button4.Visible = false;
                    button4.Enabled = false;
                    if (emprestimo.Status == "DEVOLVIDO") {
                        button2.Visible = false;
                        button4.Visible = true;
                    }
                }
            }
        }

        private void popular(List<LivroModel> lista) {
            LvLivros.Items.Clear();
            if (lista.Count > 0) {
                foreach (LivroModel livro in lista) {
                    ListViewItem item = new ListViewItem(livro.getId().ToString());
                    item.SubItems.Add(livro.Nome);
                    item.SubItems.Add(livro.Autor);
                    item.SubItems.Add(livro.Fornecedor);
                    item.SubItems.Add(livro.Edicao);
                    item.SubItems.Add(livro.AnoPublicacao);
                    item.SubItems.Add(livro.DataAquisicao.ToString());

                    LvLivros.Items.Add(item);
                }
            }
        }

        private void Excluir_Load(object sender, EventArgs e) {
            if (emprestimo != null) {
                List<EmprestimoModel> dados = controller.ListarEmprestimo(emprestimo.ID_emprestimo);
                popular(dados);

                List<LivroModel> livros = controller.ListarTodosLivrosEmprestimo(emprestimo.ID_emprestimo);
                popular(livros);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                if (controller.Excluir(emprestimo)) {
                    MessageBox.Show("Excluído com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                else {
                    MessageBox.Show("Não foi possível excluir", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("O livro está nas mesmas condições de quando saiu?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                if (controller.Devolucao(emprestimo)) {
                    MessageBox.Show("Devolvido com sucesso", "Parabéns", MessageBoxButtons.OK);
                    this.Close();
                }
                else {
                    MessageBox.Show("Não foi possível devolver o livro.", "Atenção", MessageBoxButtons.OK);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
