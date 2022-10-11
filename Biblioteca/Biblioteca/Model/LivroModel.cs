using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    public class LivroModel {
        int ID { get; set; }
        public int IdEditora{ get; set; }
        public int IdAutor { get; set; }
        public int IdGenero { get; set; }
        public string Titulo { get; set; }
        public int Quantidade { get; set; }
        public string NomeEditora { get; set; }
        public string NomeAutor { get; set; }
        public string NomeGenero { get; set; }
        public string NomeEdicao { get; set; }
        public int IdEmprestimo { get; set; }
        public int Disponiveis { get; set; }

        public LivroModel(int ID, string Titulo, string Editora, string Autor, string Genero)
        {
            this.ID = ID;
            this.Titulo = Titulo;
            this.NomeEditora = Editora;
            this.NomeAutor = Autor;
            this.NomeGenero = Genero;
        }
        public LivroModel(int ID, string Titulo, string Editora, string Autor, string Genero, int Quantidade)
        {
            this.ID = ID;
            this.Titulo = Titulo;
            this.NomeEditora = Editora;
            this.NomeAutor = Autor;
            this.NomeGenero = Genero;
            this.Quantidade = Quantidade;
        }
        public LivroModel(int ID, string Titulo, string Editora, string Autor, string Genero, int Quantidade, int IdEditora, int IdAutor, int IdGenero)
        {
            this.ID = ID;
            this.Titulo = Titulo;
            this.NomeEditora = Editora;
            this.NomeAutor = Autor;
            this.NomeGenero = Genero;
            this.Quantidade = Quantidade;
            this.IdEditora = IdEditora;
            this.IdAutor = IdAutor;
            this.IdGenero = IdGenero;
        }
        public LivroModel(string Titulo, int IdEditora, int IdAutor, int IdGenero)
        {
            this.Titulo = Titulo;
            this.IdEditora = IdEditora;
            this.IdAutor = IdAutor;
            this.IdGenero = IdGenero;
        }
        public LivroModel(int Id, string Titulo, int IdEditora, int IdAutor, int IdGenero)
        {
            this.ID = Id;
            this.Titulo = Titulo;
            this.IdEditora = IdEditora;
            this.IdAutor = IdAutor;
            this.IdGenero = IdGenero;
        }

        public int getId() {
            return this.ID;
        }

    }
}
