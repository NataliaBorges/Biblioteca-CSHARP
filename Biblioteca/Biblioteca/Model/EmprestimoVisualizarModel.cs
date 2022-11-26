﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    public class EmprestimoVisualizarModel
    {
        public int ID_emprestimo { get; set; }
        public string Nome_Livro { get; set; }
        public string ISBN { get; set; }
        public string Nome_Funcionario { get; set; }
        public DateTime Data_emprestimo { get; set; }
        public DateTime Data_devolucao { get; set; }
        public Nullable<DateTime> Data_finalizado { get; set; }
        public string Status_Emprestimo { get; set; }
        public string Status_Exemplar { get; set; }
        public EmprestimoVisualizarModel(int ID_emprestimo, string Nome_Livro, string ISBN, string Nome_Funcionario, DateTime Data_emprestimo, DateTime Data_devolucao, Nullable<DateTime> Data_finalizado, string Status_Emprestimo, string Status_Exemplar)
        {
            this.ID_emprestimo = ID_emprestimo;
            this.Nome_Livro = Nome_Livro;
            this.ISBN = ISBN;
            this.Nome_Funcionario = Nome_Funcionario;
            this.Data_emprestimo = Data_emprestimo;
            this.Data_devolucao = Data_devolucao;
            this.Data_finalizado = Data_finalizado;
            this.Status_Emprestimo = Status_Emprestimo;
            this.Status_Exemplar = Status_Exemplar;
        }
    }
}
