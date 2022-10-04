using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    public class ReservaPesquisaModel {

        public int ID_reserva { get; set; }
        public string Nome_Leitor { get; set; }
        public string Nome_Livro { get; set; }
        public string Nome_funcionario { get; set; }
        public DateTime Data_reserva { get; set; }

        public ReservaPesquisaModel(int ID, string Leitor, string Livro, string funcionario, DateTime Data_reserva) {
            this.ID_reserva = ID;
            this.Nome_Leitor = Leitor;
            this.Nome_Livro = Livro;
            this.Nome_funcionario = funcionario;
            this.Data_reserva = Data_reserva;
        }

    }
}
