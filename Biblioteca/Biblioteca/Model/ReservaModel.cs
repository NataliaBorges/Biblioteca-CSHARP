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

        public String Leitor { get; set; }

        public String Funcionario { get; set;  }

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
        public ReservaModel(int ID, int IdFuncionario, int IdLeitor, DateTime DataReserva, String Leitor, String Funcionario) {
            this.ID = ID;
            this.IdFuncionario = IdFuncionario;
            this.IdLeitor = IdLeitor;
            this.DataReserva = DataReserva;
            this.Leitor = Leitor;
            this.Funcionario = Funcionario;
        }
        public int getId() {
            return this.ID;
        }
    }
}
