using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class ExemplarModel{
        int ID { get; set; }
        public int IdLivro{ get; set; }
        public String Titulo { get; set; }
        public String Edicao { get; set; }
        public String AnoPublicacao { get; set; }
        public String ISBN { get; set; }
        public DateTime Aquisicao { get; set; }
        public String Nome_Editora { get; set; }
        public String Nome_Autor { get; set; }
        public String Nome_Genero { get; set; }

        public ExemplarModel(int ID, int IdExemplar) {
            this.ID = ID;
            this.IdLivro = IdExemplar;
        }
        public ExemplarModel(int ID, String titulo,  String Edicao, String AnoPublicacao, String ISBN, DateTime aquisicao, String nomeEditora, String nomeAutor,  String nomeGenero)
        {
            this.ID = ID;
            this.Titulo = titulo;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.Aquisicao = aquisicao;
            this.Nome_Editora = nomeEditora;
            this.Nome_Autor = nomeAutor;
            this.Nome_Genero = nomeGenero;

        }
        public ExemplarModel(int ID, String titulo, String autor, String Edicao, String AnoPublicacao, String ISBN, String Fornecedor) {
            this.ID = ID;
            this.Titulo = titulo;
            this.Nome_Autor = autor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.Nome_Editora = Fornecedor;
        }
        public ExemplarModel(int ID, String titulo, String autor, String Edicao, String AnoPublicacao, String ISBN, String Fornecedor, DateTime Aquisicao) {
            this.ID = ID;
            this.Titulo = titulo;
            this.Nome_Autor = autor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.Nome_Editora = Fornecedor;
            this.Aquisicao = Aquisicao;
        }
        public int getId() {
            return this.ID;
        }
    }
}
