using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    
    public class EditoraModel {

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public int Estado { get; set; }

        public EditoraModel(int ID, string Nome, string Endereco, string Telefone, string CNPJ, string Email) {
            this.ID = ID;
            this.Nome = Nome;
            this.Endereco = Endereco;
            this.Telefone = Telefone;
            this.CNPJ = CNPJ;
            this.Email = Email;

        }
        public EditoraModel(int ID, string Nome, string Endereco, string Telefone, string CNPJ, string Email, int estado)
        {
            this.ID = ID;
            this.Nome = Nome;
            this.Endereco = Endereco;
            this.Telefone = Telefone;
            this.CNPJ = CNPJ;
            this.Email = Email;
            this.Estado = estado;
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
