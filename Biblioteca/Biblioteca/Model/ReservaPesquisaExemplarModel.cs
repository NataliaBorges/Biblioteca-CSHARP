using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    public class ReservaPesquisaExemplarModel {

        public int ID_reserva { get; set; }
        public string Status_Reserva { get; set; }
        public string Nome_Livro { get; set; }
        public string ISBN { get; set; }
        public string Nome_Leitor { get; set; }
        public string Nome_Funcionario { get; set; }
        public DateTime Data_reserva { get; set; }
        public DateTime Data_prevista { get; set; }
        public Nullable<DateTime> Data_retirada { get; set; }
        public string Status_Exemplar { get; set; }
        public ReservaPesquisaExemplarModel(int ID_reserva, string Status_Reserva, string Nome_Livro, string ISBN, string Nome_Leitor, string Nome_Funcionario, DateTime Data_reserva, DateTime Data_prevista, Nullable<DateTime> Data_retirada, string Status_Exemplar) {
            this.ID_reserva = ID_reserva;
            this.Status_Reserva = Status_Reserva;
            this.Nome_Livro = Nome_Livro;
            this.ISBN = ISBN;
            this.Nome_Leitor = Nome_Leitor;
            this.Nome_Funcionario = Nome_Funcionario;
            this.Data_reserva = Data_reserva;
            this.Data_prevista = Data_prevista;
            this.Data_retirada = Data_retirada;
            this.Status_Exemplar = Status_Exemplar;
        }

    }
}
