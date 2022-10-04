using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    public class FuncionarioModel {
        int ID_funcionario { get; set; }
        public string Nome_funcionario { get; set; }
        public string CPF { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public int Id_funcao { get; set; }
        public int Id_estado { get; set; }
        public string Funcao { get; set; }
        public string Estado { get; set; }
        public FuncionarioModel(int ID, string nome, string cpf, DateTime nascimento, string email, string endereco, string telefone) {
            this.ID_funcionario = ID;
            this.Nome_funcionario = nome;
            this.CPF = cpf;
            this.Data_Nascimento = nascimento;
            this.Email = email;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }
        public FuncionarioModel(int ID, string nome, string cpf, DateTime nascimento, string email, string endereco, string telefone, string funcao, string Estado) {
            this.ID_funcionario = ID;
            this.Nome_funcionario = nome;
            this.CPF = cpf;
            this.Data_Nascimento = nascimento;
            this.Email = email;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Funcao = funcao;
            this.Estado = Estado;
        }
        public FuncionarioModel(string nome, string cpf, DateTime nascimento, string email, string endereco, string telefone, string senha, int Id_funcao)
        {
            this.Nome_funcionario = nome;
            this.CPF = cpf;
            this.Data_Nascimento = nascimento;
            this.Email = email;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Senha = senha;
            this.Id_funcao = Id_funcao;
        }
        public FuncionarioModel(string nome, string cpf, DateTime nascimento, string email, string endereco, string telefone, string Senha, string funcao) {
            this.Nome_funcionario = nome;
            this.CPF = cpf;
            this.Data_Nascimento = nascimento;
            this.Email = email;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Senha = Senha;
            this.Funcao = funcao;
        }
        public int getId() {
            return this.ID_funcionario;
        }

    }
}
