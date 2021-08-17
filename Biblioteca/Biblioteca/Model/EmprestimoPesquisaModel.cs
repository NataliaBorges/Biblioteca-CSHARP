using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    public class EmprestimoPesquisaModel {

        public int ID_emprestimo { get; set; }
        public String Nome_Leitor { get; set; }
        public String Nome_Livro { get; set; }
        public String Nome_funcionario { get; set; }
        public DateTime Data_emprestimo { get; set; }
        public DateTime Data_devolucao { get; set; }

        public EmprestimoPesquisaModel(int ID, String Leitor, String Livro, String funcionario, DateTime emprestimo, DateTime devolucao) {
            this.ID_emprestimo = ID;
            this.Nome_Leitor = Leitor;
            this.Nome_Livro = Livro;
            this.Nome_funcionario = funcionario;
            this.Data_emprestimo = emprestimo;
            this.Data_devolucao = devolucao;
        }

    }
}
