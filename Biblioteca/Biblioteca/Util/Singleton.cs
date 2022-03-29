using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca.Model;

namespace Biblioteca.Util {
    class Singleton {
        private Singleton() { }
        private static Singleton instancia;
        private FuncionarioModel funcionarioModel { get; set; }

        private List<LivroModel> livros = new List<LivroModel>();
        private LeitorModel leitor;

        public static Singleton GetInstancia() {
            if (instancia == null) {
                instancia = new Singleton();
            }
            return instancia;
        }
        public FuncionarioModel getFuncionario() {
            return this.funcionarioModel;
        }
        public void setFuncionario(FuncionarioModel funcionarioModel) {
            this.funcionarioModel = funcionarioModel;
        }
        public List<LivroModel> getLivros() {
            return this.livros;
        }
        public void setLivro(LivroModel livro) {
            this.livros.Add(livro);
        }
        public LeitorModel getLeitor() {
            return this.leitor;
        }
        public void setLeitor(LeitorModel leitor) {
            this.leitor = leitor;
        }
        public void removerLivroLista(LivroModel livro) {
            int posicao = this.livros.FindIndex(item => item.getId() == livro.getId());
            this.livros.RemoveAt(posicao);
        }
        public void clearEmprestimo() {
            this.livros = new List<LivroModel>();
            this.leitor = null;
        }

        public void clearReserva() {
            this.livros = new List<LivroModel>();
            this.leitor = null;
        }
    }
}
