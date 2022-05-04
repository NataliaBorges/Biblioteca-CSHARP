using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    public class LivroModel {
        int ID { get; set; }
        public int IdFornecedor { get; set; }
        public String Nome { get; set; }
        public String Autor { get; set; }
        public String Edicao { get; set; }
        public String AnoPublicacao { get; set; }
        public DateTime DataAquisicao { get; set; }
        public String ISBN { get; set; }
        public String Fornecedor { get; set; }
        public int Id_emprestimo { get; set; }
        public int Quantidade { get; set; }
        public int Disponiveis { get; set; }

        public LivroModel(int ID, int IdFornecedor, String Nome, String Autor, String Edicao, String AnoPublicacao, DateTime DataAquisicao, String ISBN) {
            this.ID = ID;
            this.IdFornecedor = IdFornecedor;
            this.Nome = Nome;
            this.Autor = Autor;
            this.Edicao = Edicao; 
            this.AnoPublicacao = AnoPublicacao;
            this.DataAquisicao = DataAquisicao;
            this.ISBN = ISBN;
        }
        public LivroModel(int ID, String Nome, String Autor, String Edicao, String AnoPublicacao, String ISBN, String fornecedor) {
            this.ID = ID;
            this.Nome = Nome;
            this.Autor = Autor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.ISBN = ISBN;
        }
        public LivroModel(int IdFornecedor, String Nome, String Autor, String Edicao, String AnoPublicacao, DateTime DataAquisicao, String ISBN) {
            this.IdFornecedor = IdFornecedor;
            this.Nome = Nome;
            this.Autor = Autor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.DataAquisicao = DataAquisicao;
            this.ISBN = ISBN;
        }

        public LivroModel(int ID, int IdFornecedor, String Nome, String Autor, String Edicao, String AnoPublicacao, DateTime DataAquisicao, String ISBN, String Fornecedor) {
            this.ID = ID;
            this.IdFornecedor = IdFornecedor;
            this.Nome = Nome;
            this.Autor = Autor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.DataAquisicao = DataAquisicao;
            this.ISBN = ISBN;
            this.Fornecedor = Fornecedor;
        }

        public LivroModel(int ID, int IdFornecedor, String Nome, String Autor, String Edicao, String AnoPublicacao, DateTime DataAquisicao, String ISBN, String Fornecedor, int Quantidade) {
            this.ID = ID;
            this.IdFornecedor = IdFornecedor;
            this.Nome = Nome;
            this.Autor = Autor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.DataAquisicao = DataAquisicao;
            this.ISBN = ISBN;
            this.Fornecedor = Fornecedor;
            this.Quantidade = Quantidade;
        }

        public LivroModel(int ID, String Nome, String Autor, String Edicao, String AnoPublicacao, DateTime DataAquisicao, String Fornecedor, String ISBN) {
            this.ID = ID;
            this.Nome = Nome;
            this.Autor = Autor;
            this.Edicao = Edicao;
            this.AnoPublicacao = AnoPublicacao;
            this.DataAquisicao = DataAquisicao;
            this.Fornecedor = Fornecedor;
            this.ISBN = ISBN;
        }

        public int getId() {
            return this.ID;
        }

    }
}
