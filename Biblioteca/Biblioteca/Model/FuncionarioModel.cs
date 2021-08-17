﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    public class FuncionarioModel {
        int ID_funcionario { get; set; }
        public String Nome_funcionario { get; set; }
        public String CPF { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public String Email { get; set; }
        public String Endereco { get; set; }
        public String Telefone { get; set; }
        public String Senha { get; set; }
        public FuncionarioModel(int ID, String nome, String cpf, DateTime nascimento, String email, String endereco, String telefone) {
            this.ID_funcionario = ID;
            this.Nome_funcionario = nome;
            this.CPF = cpf;
            this.Data_Nascimento = nascimento;
            this.Email = email;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }
        public FuncionarioModel(int ID, String nome, String cpf, DateTime nascimento, String email, String endereco, String telefone, String Senha) {
            this.ID_funcionario = ID;
            this.Nome_funcionario = nome;
            this.CPF = cpf;
            this.Data_Nascimento = nascimento;
            this.Email = email;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Senha = Senha;
        }
        public FuncionarioModel(String nome, String cpf, DateTime nascimento, String email, String endereco, String telefone, String Senha) {
            this.Nome_funcionario = nome;
            this.CPF = cpf;
            this.Data_Nascimento = nascimento;
            this.Email = email;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Senha = Senha;
        }
        public int getId() {
            return this.ID_funcionario;
        }

    }
}
