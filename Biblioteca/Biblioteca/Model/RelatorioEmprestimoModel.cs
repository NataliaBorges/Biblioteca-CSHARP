using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    public class RelatorioEmprestimoModel {

        public int ID_exemplar { get; set; }
        public string Nome_Livro { get; set; }
        public string ISBN { get; set; }
        public string Nome_Leitor { get; set; }
        public int Total { get; set; }
        public RelatorioEmprestimoModel(int ID_exemplar, string Nome_Livro, string ISBN, string Nome_Leitor, int Total) {
            this.ID_exemplar = ID_exemplar;
            this.Nome_Livro = Nome_Livro;
            this.ISBN = ISBN;
            this.Nome_Leitor = Nome_Leitor;
            this.Total = Total;
        }

    }
}
