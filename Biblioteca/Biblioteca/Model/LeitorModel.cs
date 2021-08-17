using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    public class LeitorModel {
        int ID { get; set; }
        public String Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public String Telefone { get; set; }
        public String CPF { get; set; }
        public String Endereco { get; set; }

        public int QuantidadeEmprestimo { get; set; }

        public LeitorModel(int ID, String Nome, DateTime DataNascimento, String Telefone, String CPF, String Endereco) {
            this.ID = ID;
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
            this.Telefone = Telefone;
            this.CPF = CPF;
            this.Endereco = Endereco;
        }

        public LeitorModel(String Nome, DateTime DataNascimento, String Telefone, String CPF, String Endereco) {
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
            this.Telefone = Telefone;
            this.CPF = CPF;
            this.Endereco = Endereco;
        }

        public int getId() {
            return this.ID;
        }
    }
}

