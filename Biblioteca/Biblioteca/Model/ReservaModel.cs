using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class ReservaModel {
        int ID { get; set; }
        public int IdFuncionario { get; set; }
        public int IdLeitor { get; set; }
        public DateTime DataReserva { get; set; }
        public String Obs { get; set; }

        public ReservaModel(int ID, int IdFuncionario, int IdLeitor, DateTime DataReserva, String Obs) {
            this.ID = ID;
            this.IdFuncionario = IdFuncionario;
            this.IdLeitor = IdLeitor;
            this.DataReserva = DataReserva;
            this.Obs = Obs;
        }
        public ReservaModel(int ID, int IdFuncionario, int IdLeitor, DateTime DataReserva) {
            this.ID = ID;
            this.IdFuncionario = IdFuncionario;
            this.IdLeitor = IdLeitor;
            this.DataReserva = DataReserva;  
        }
        public int getId() {
            return this.ID;
        }
    }
}
