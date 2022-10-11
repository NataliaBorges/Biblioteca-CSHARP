using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class ExemplarModel{
        int ID { get; set; }
        public int IdLivro{ get; set; }
        public string Titulo { get; set; }
        public int IdEdicao { get; set; }
        public string AnoPublicacao { get; set; }
        public string ISBN { get; set; }
        public float Valor { get; set; }
        public DateTime Aquisicao { get; set; }
        public string Nome_Editora { get; set; }
        public string Nome_Autor { get; set; }
        public string Nome_Genero { get; set; }
        public string Nome_Edicao { get; set; }

        public ExemplarModel(int ID, int IdExemplar) {
            this.ID = ID;
            this.IdLivro = IdExemplar;
        }
        public ExemplarModel(int ID, string titulo,  string Edicao, string AnoPublicacao, string ISBN, DateTime aquisicao, string nomeEditora, string nomeAutor,  string nomeGenero)
        {
            this.ID = ID;
            this.Titulo = titulo;
            this.Nome_Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.Aquisicao = aquisicao;
            this.Nome_Editora = nomeEditora;
            this.Nome_Autor = nomeAutor;
            this.Nome_Genero = nomeGenero;

        }
        public ExemplarModel(int ID, string titulo, string autor, string Edicao, string AnoPublicacao, string ISBN, string Editora) {
            this.ID = ID;
            this.Titulo = titulo;
            this.Nome_Autor = autor;
            this.Nome_Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.Nome_Editora = Editora;
        }
        public ExemplarModel(int Id, string titulo, string Edicao,DateTime Aquisicao,  string AnoPublicacao, string ISBN, string Editora, string autor, string Genero) 
        {
            this.ID = ID;
            this.Titulo = titulo;
            this.Nome_Edicao = Edicao;
            this.Aquisicao = Aquisicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.Nome_Editora = Editora;
            this.Nome_Autor = autor;
            this.Nome_Genero = Genero;
        }
        public int getId() {
            return this.ID;
        }
    }
}
