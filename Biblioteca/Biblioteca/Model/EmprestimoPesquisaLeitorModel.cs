using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    public class EmprestimoPesquisaLeitorModel
    {
        public int Id_Leitor { get; set; }
        public string Nome_Leitor { get; set; }
        public string CPF { get; set; }
        public int Total { get; set; }
        public string Status_Emprestimo { get; set; }
        public EmprestimoPesquisaLeitorModel(int Id_Leitor, string Nome_Leitor, string CPF, int Total)
        {
            this.Id_Leitor = Id_Leitor;
            this.Nome_Leitor = Nome_Leitor;
            this.CPF = CPF;
            this.Total = Total;
        }
    }
}
