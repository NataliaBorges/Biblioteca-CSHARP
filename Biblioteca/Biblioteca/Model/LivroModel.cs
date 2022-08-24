using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    public class LivroModel {
        int ID { get; set; }
        public int IdEditora{ get; set; }
        public String Nome { get; set; }
        public String Autor { get; set; }
        public String Edicao { get; set; }
        public String AnoPublicacao { get; set; }
        public DateTime DataAquisicao { get; set; }
        public String ISBN { get; set; }
        public String Editora { get; set; }
        public int Id_emprestimo { get; set; }
        public int Quantidade { get; set; }
        public int Disponiveis { get; set; }

        public LivroModel(int ID, int IdEditora, String Nome, String Autor, String Edicao, String AnoPublicacao, DateTime DataAquisicao, String ISBN) {
            this.ID = ID;
            this.IdEditora = IdEditora;
            this.Nome = Nome;
            this.Autor = Autor;
            this.Edicao = Edicao; 
            this.AnoPublicacao = AnoPublicacao;
            this.DataAquisicao = DataAquisicao;
            this.ISBN = ISBN;
        }
        public LivroModel(int ID, String Nome, String Autor, String Edicao, String AnoPublicacao, String ISBN, String Editora) {
            this.ID = ID;
            this.Nome = Nome;
            this.Autor = Autor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
        }
        public LivroModel(int IdEditora, String Nome, String Autor, String Edicao, String AnoPublicacao, DateTime DataAquisicao, String ISBN) {
            this.IdEditora = IdEditora;
            this.Nome = Nome;
            this.Autor = Autor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.DataAquisicao = DataAquisicao;
            this.ISBN = ISBN;
        }

        public LivroModel(int ID, int IdEditora, String Nome, String Autor, String Edicao, String AnoPublicacao, DateTime DataAquisicao, String ISBN, String Editora) {
            this.ID = ID;
            this.IdEditora = IdEditora;
            this.Nome = Nome;
            this.Autor = Autor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.DataAquisicao = DataAquisicao;
            this.ISBN = ISBN;
            this.Editora = Editora;
        }

        public LivroModel(int ID, int IdEditora, String Nome, String Autor, String Edicao, String AnoPublicacao, DateTime DataAquisicao, String ISBN, String Fornecedor, int Quantidade) {
            this.ID = ID;
            this.IdEditora = IdEditora;
            this.Nome = Nome;
            this.Autor = Autor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.DataAquisicao = DataAquisicao;
            this.ISBN = ISBN;
            this.Editora = Editora;
            this.Quantidade = Quantidade;
        }

        public LivroModel(int ID, String Nome, String Autor, String Edicao, String AnoPublicacao, DateTime DataAquisicao, String Editora, String ISBN) {
            this.ID = ID;
            this.Nome = Nome;
            this.Autor = Autor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.DataAquisicao = DataAquisicao;
            this.Editora = Editora;
            this.ISBN = ISBN;
        }

        public LivroModel(string nome, string autor, string edicao, string ano, DateTime data, string iSBN)
        {
            Nome = nome;
            Autor = autor;
            Edicao = edicao;
            ISBN = iSBN;
        }

        public int getId() {
            return this.ID;
        }

    }
}
