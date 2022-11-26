using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    public class EmprestimoPesquisaLeitorModel
    {
        public string Nome_Leitor { get; set; }
        public string CPF { get; set; }
        public int Total { get; set; }
        public EmprestimoPesquisaLeitorModel(string Nome_Leitor, string CPF, int Total)
        {
            this.Nome_Leitor = Nome_Leitor;
            this.CPF = CPF;
            this.Total = Total;
        }
    }
}
