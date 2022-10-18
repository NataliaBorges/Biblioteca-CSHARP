using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    public class LeitorModel {
        int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public int QuantidadeEmprestimo { get; set; }
        public int Estado{get; set; }

        public LeitorModel(int ID, string Nome, DateTime DataNascimento, string Telefone, string CPF, string Endereco) {
            this.ID = ID;
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
            this.Telefone = Telefone;
            this.CPF = CPF;
            this.Endereco = Endereco;
        }

        public LeitorModel(int ID, string Nome, DateTime DataNascimento, string Telefone, string CPF, string Endereco, string Email) {
            this.ID = ID;
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
            this.Telefone = Telefone;
            this.CPF = CPF;
            this.Endereco = Endereco;
            this.Email = Email;
        }
        public LeitorModel(int ID, string Nome, DateTime DataNascimento, string Telefone, string CPF, string Endereco, string Email, int Estado)
        {
            this.ID = ID;
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
            this.Telefone = Telefone;
            this.CPF = CPF;
            this.Endereco = Endereco;
            this.Email = Email;
            this.Estado = Estado;
        }

        public LeitorModel(string Nome, DateTime DataNascimento, string Telefone, string CPF, string Endereco,  string Email) {
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
            this.Telefone = Telefone;
            this.CPF = CPF;
            this.Endereco = Endereco;
            this.Email = Email;
        }

        public int getId() {
            return this.ID;
        }
        public string getEstado()
        {
            if (this.Estado == 0)
            {
                return "Inativo";
            }
            else
            {
                return "Ativo";
            }
        }
    }
}

