using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    public class LivroModel {
        int ID { get; set; }
        public int IdEditora{ get; set; }
        public int IdAutor { get; set; }
        public int IdGenero { get; set; }
        public String Titulo { get; set; }
        public String Edicao { get; set; }
        public String AnoPublicacao { get; set; }
        public String ISBN { get; set; }
        public int Quantidade { get; set; }
        public String NomeEditora { get; set; }
        public String NomeAutor { get; set; }
        public String NomeGenero { get; set; }
        public int IdEmprestimo { get; set; }
        public int Disponiveis { get; set; }

        public LivroModel(int ID, string Titulo, String Edicao, String AnoPublicacao, String ISBN, int Quantidade, string Editora, string Autor, string Genero)
        {
            this.ID = ID;
            this.Titulo = Titulo;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.Quantidade = Quantidade;
            this.NomeEditora = Editora;
            this.NomeAutor = Autor;
            this.NomeGenero = Genero;
        }
        public LivroModel(int IdEditora, int IdAutor, int IdGenero, String Titulo, String Edicao, String AnoPublicacao, String ISBN, int Quantidade)
        {
            this.IdEditora = IdEditora;
            this.IdAutor = IdAutor;
            this.IdGenero = IdGenero;
            this.Titulo = Titulo;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.Quantidade = Quantidade;
        }
        public LivroModel(String Titulo, String Edicao, String AnoPublicacao, int Quantidade, String ISBN,  int IdEditora, int IdAutor, int IdGenero)
        {
            this.Titulo = Titulo;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.Quantidade = Quantidade;
            this.ISBN = ISBN;
            this.IdEditora = IdEditora;
            this.IdAutor = IdAutor;
            this.IdGenero = IdGenero;
        }

        public int getId() {
            return this.ID;
        }

    }
}
