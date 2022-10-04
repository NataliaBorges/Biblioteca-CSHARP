using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    
    public class EditoraModel {

        public int ID;
        public string Nome;
        public string Endereco;
        public string Telefone;
        public string CNPJ;
        public string Email;

        public EditoraModel(int ID, string Nome, string Endereco, string Telefone, string CNPJ, string Email) {
            this.ID = ID;
            this.Nome = Nome;
            this.Endereco = Endereco;
            this.Telefone = Telefone;
            this.CNPJ = CNPJ;
            this.Email = Email;
        }

        public EditoraModel(string Nome, string Endereco, string Telefone, string CNPJ, string Email) {
            this.Nome = Nome;
            this.Endereco = Endereco;
            this.Telefone = Telefone;
            this.CNPJ = CNPJ;
            this.Email = Email;
        }
        public EditoraModel(int ID, string Nome)
        {
            this.ID = ID;
            this.Nome = Nome;

        }

        public int getId() {
            return this.ID;
        }

    }
}
