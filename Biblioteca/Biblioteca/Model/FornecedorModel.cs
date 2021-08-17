using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    public class FornecedorModel {

        public int ID;
        public String Nome;
        public String Endereco;
        public String Telefone;
        public String CNPJ;

        public FornecedorModel(int ID, string Nome, string Endereco, string Telefone, string CNPJ) {
            this.ID = ID;
            this.Nome = Nome;
            this.Endereco = Endereco;
            this.Telefone = Telefone;
            this.CNPJ = CNPJ;
        }

        public FornecedorModel(string Nome, string Endereco, string Telefone, string CNPJ) {
            this.Nome = Nome;
            this.Endereco = Endereco;
            this.Telefone = Telefone;
            this.CNPJ = CNPJ;
        }

        public int getId() {
            return this.ID;
        }

    }
}
