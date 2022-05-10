using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class ExemplarModel{
        int ID { get; set; }
        public int IdLivro{ get; set; }
        public String Nome { get; set; }
        public String Autor { get; set; }
        public String Edicao { get; set; }
        public String AnoPublicacao { get; set; }
        public String ISBN { get; set; }
        public String Fornecedor { get; set; }
        public DateTime Aquisicao { get; set; }
        public String Estado { get; set; }

        public ExemplarModel(int ID, int IdExemplar) {
            this.ID = ID;
            this.IdLivro = IdExemplar;
        }
        public ExemplarModel(int ID, String nome, String autor, String Edicao, String AnoPublicacao, String ISBN, String Fornecedor) {
            this.ID = ID;
            this.Nome = nome;
            this.Autor = autor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.Fornecedor = Fornecedor;
        }
        public ExemplarModel(int ID, String nome, String autor, String Edicao, String AnoPublicacao, String ISBN, String Fornecedor, DateTime Aquisicao, String Estado) {
            this.ID = ID;
            this.Nome = nome;
            this.Autor = autor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
            this.Fornecedor = Fornecedor;
            this.Aquisicao = Aquisicao;
            this.Estado = Estado;
        }
        public int getId() {
            return this.ID;
        }
    }
}
