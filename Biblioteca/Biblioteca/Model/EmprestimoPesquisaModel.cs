using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    public class EmprestimoPesquisaModel {

        public int ID_emprestimo { get; set; }
        public string Nome_Leitor { get; set; }
        public string Nome_Livro { get; set; }
        public string Nome_funcionario { get; set; }
        public DateTime Data_emprestimo { get; set; }
        public DateTime Data_devolucao { get; set; }
        public Nullable<DateTime> Data_finalizado { get; set; }
        public string Status { get; set; }

        public EmprestimoPesquisaModel(int ID, string Leitor, string Livro, string funcionario, DateTime emprestimo, DateTime devolucao, Nullable<DateTime> finalizado, string Status) {
            this.ID_emprestimo = ID;
            this.Nome_Leitor = Leitor;
            this.Nome_Livro = Livro;
            this.Nome_funcionario = funcionario;
            this.Data_emprestimo = emprestimo;
            this.Data_devolucao = devolucao;
            this.Data_finalizado = finalizado;
            this.Status = Status;
        }

    }
}
