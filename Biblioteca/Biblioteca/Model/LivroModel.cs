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

        public LivroModel(int ID, int IdEditora,  int IdAutor, int IdGenero,  String Titulo, String Edicao, String AnoPublicacao, String ISBN, int Quantidade)
        {
            this.ID = ID;
            this.IdEditora = IdEditora;
            this.IdAutor = IdAutor;
            this.IdGenero = IdGenero;
            this.Titulo = Titulo;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.Quantidade = Quantidade;
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
        public LivroModel(int Id, String Titulo, String Edicao, String AnoPublicacao, String ISBN, int Quantidade, String Nome_Editora, String Nome_Autor, String Nome_Genero)
        {
            this.Titulo = Titulo;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.Quantidade = Quantidade;
            this.NomeEditora = Nome_Editora;
            this.NomeAutor = Nome_Autor;
            this.NomeGenero = Nome_Genero;

        }
        public LivroModel(int ID, int IdEditora, String Titulo, int IdAutor, String Edicao, String AnoPublicacao, String ISBN) {
            this.ID = ID;
            this.IdEditora = IdEditora;
            this.Titulo = Titulo;
            this.IdAutor = IdAutor;
            this.Edicao = Edicao; 
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
        }
        public LivroModel(int ID, String Titulo, int IdAutor, String Edicao, String AnoPublicacao, String ISBN, String Editora) {
            this.ID = ID;
            this.Titulo = Titulo;
            this.IdAutor = IdAutor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
        }
        public LivroModel(int IdEditora, String Titulo, int IdAutor, String Edicao, String AnoPublicacao, String ISBN) {
            this.IdEditora = IdEditora;
            this.Titulo = Titulo;
            this.IdAutor = IdAutor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
        }

        public LivroModel(int ID, int IdEditora, String Titulo, int IdAutor, String Edicao, String AnoPublicacao,  String ISBN, int Id_Editora) {
            this.ID = ID;
            this.IdEditora = IdEditora;
            this.Titulo = Titulo;
            this.IdAutor = IdAutor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.IdEditora = Id_Editora;
        }

        public LivroModel(int ID, int IdEditora, String Titulo, int Autor, String Edicao, String AnoPublicacao, DateTime DataAquisicao, String ISBN, int Id_Editora, int Quantidade) {
            this.ID = ID;
            this.IdEditora = IdEditora;
            this.Titulo = Titulo;
            this.IdAutor = IdAutor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.IdEditora = Id_Editora;
            this.Quantidade = Quantidade;
        }

        public LivroModel(int ID, String Titulo, int IdAutor, String Edicao, String AnoPublicacao, DateTime DataAquisicao, int Id_Editora, String ISBN) {
            this.ID = ID;
            this.Titulo = Titulo;
            this.IdAutor = IdAutor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.IdEditora = Id_Editora;
            this.ISBN = ISBN;
        }

        public int getId() {
            return this.ID;
        }

    }
}
