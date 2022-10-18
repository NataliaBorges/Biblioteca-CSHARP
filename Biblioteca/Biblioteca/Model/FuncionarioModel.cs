using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    public class FuncionarioModel
    {
        int ID_funcionario { get; set; }
        public string Nome_funcionario { get; set; }
        public string CPF { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public int Id_funcao { get; set; }
        public string Funcao { get; set; }
        public int Estado { get; set; }

        public FuncionarioModel(string nome, DateTime nascimento, string cpf, string endereco, string telefone, string email, string senha, int Id_funcao)
        {
            this.Nome_funcionario = nome;
            this.Data_Nascimento = nascimento;
            this.CPF = cpf;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Senha = senha;
            this.Id_funcao = Id_funcao;
        }
        public FuncionarioModel(int ID, string nome, DateTime nascimento, string cpf, string endereco, string telefone, string email, string funcao, int estado)
        {
            this.ID_funcionario = ID;
            this.Nome_funcionario = nome;
            this.Data_Nascimento = nascimento;
            this.CPF = cpf;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Funcao = funcao;
            this.Estado = estado;
        }
        public FuncionarioModel(int ID, string nome, DateTime nascimento, string cpf, string endereco, string telefone, string email, int funcao, int estado)
        {
            this.ID_funcionario = ID;
            this.Nome_funcionario = nome;
            this.Data_Nascimento = nascimento;
            this.CPF = cpf;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Id_funcao = funcao;
            this.Estado = estado;
        }
        public FuncionarioModel(int id, string nome, DateTime nascimento, string cpf, string endereco, string telefone, string email, string senha, int Id_funcao, int estado)
        {
            this.ID_funcionario = id;
            this.Nome_funcionario = nome;
            this.Data_Nascimento = nascimento;
            this.CPF = cpf;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Senha = senha;
            this.Id_funcao = Id_funcao;
            this.Estado = estado;
        }
        public FuncionarioModel(string nome, string cpf, DateTime nascimento, string email, string endereco, string telefone, string Senha, string funcao)
        {
            this.Nome_funcionario = nome;
            this.CPF = cpf;
            this.Data_Nascimento = nascimento;
            this.Email = email;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Senha = Senha;
            this.Funcao = funcao;
        }
        public int getId()
        {
            return this.ID_funcionario;
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
