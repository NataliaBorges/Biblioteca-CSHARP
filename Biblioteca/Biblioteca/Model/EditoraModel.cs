using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    
    public class EditoraModel {

        public int ID;
        public String Nome;
        public String Endereco;
        public String Telefone;
        public String CNPJ;
        public String Email;

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
            this.Nome = Nome;
            this.ID = ID;            
        }

        public int getId() {
            return this.ID;
        }

    }
}
