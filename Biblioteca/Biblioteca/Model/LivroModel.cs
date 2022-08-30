using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    public class LivroModel {
        int ID { get; set; }
        public int IdEditora{ get; set; }
        public int IdAutor { get; set; }
        public int IdGenero { get; set; }
        public String Nome { get; set; }
        public String Edicao { get; set; }
        public String AnoPublicacao { get; set; }
        public String ISBN { get; set; }
        public int Quantidade { get; set; }
        public String Editora { get; set; }
        public int Id_emprestimo { get; set; }
        public int Disponiveis { get; set; }

        public LivroModel(int ID, int IdEditora,  int IdAutor, int IdGenero,  String Nome, String Edicao, String AnoPublicacao, String ISBN, int Quantidade)
        {
            this.ID = ID;
            this.IdEditora = IdEditora;
            this.IdAutor = IdAutor;
            this.IdGenero = IdGenero;
            this.Nome = Nome;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.Quantidade = Quantidade;
        }
        public LivroModel(int IdEditora, int IdAutor, int IdGenero, String Nome, String Edicao, String AnoPublicacao, String ISBN, int Quantidade)
        {
            this.IdEditora = IdEditora;
            this.IdAutor = IdAutor;
            this.IdGenero = IdGenero;
            this.Nome = Nome;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.Quantidade = Quantidade;
        }
        public LivroModel(int ID, int IdEditora, String Nome, int IdAutor, String Edicao, String AnoPublicacao, String ISBN) {
            this.ID = ID;
            this.IdEditora = IdEditora;
            this.Nome = Nome;
            this.IdAutor = IdAutor;
            this.Edicao = Edicao; 
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
        }
        public LivroModel(int ID, String Nome, int IdAutor, String Edicao, String AnoPublicacao, String ISBN, String Editora) {
            this.ID = ID;
            this.Nome = Nome;
            this.IdAutor = IdAutor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
        }
        public LivroModel(int IdEditora, String Nome, int IdAutor, String Edicao, String AnoPublicacao, String ISBN) {
            this.IdEditora = IdEditora;
            this.Nome = Nome;
            this.IdAutor = IdAutor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
        }

        public LivroModel(int ID, int IdEditora, String Nome, int IdAutor, String Edicao, String AnoPublicacao, DateTime DataAquisicao, String ISBN, String Editora) {
            this.ID = ID;
            this.IdEditora = IdEditora;
            this.Nome = Nome;
            this.IdAutor = IdAutor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.Editora = Editora;
        }

        public LivroModel(int ID, int IdEditora, String Nome, int Autor, String Edicao, String AnoPublicacao, DateTime DataAquisicao, String ISBN, String Fornecedor, int Quantidade) {
            this.ID = ID;
            this.IdEditora = IdEditora;
            this.Nome = Nome;
            this.IdAutor = IdAutor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.Editora = Editora;
            this.Quantidade = Quantidade;
        }

        public LivroModel(int ID, String Nome, int IdAutor, String Edicao, String AnoPublicacao, DateTime DataAquisicao, String Editora, String ISBN) {
            this.ID = ID;
            this.Nome = Nome;
            this.IdAutor = IdAutor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.Editora = Editora;
            this.ISBN = ISBN;
        }

        public int getId() {
            return this.ID;
        }

    }
}
