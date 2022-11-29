using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class ReservaModel {
        int ID { get; set; }
        public int IdFuncionario { get; set; }
        public int IdLeitor { get; set; }
        public DateTime DataPrevista { get; set; }
        public DateTime DataReserva { get; set; }
        public string Obs { get; set; }
        public string Leitor { get; set; }
        public string Funcionario { get; set; }
        public Nullable<DateTime> DataRetirada { get; set; }
        public int Status { get; set; }

        public ReservaModel(int ID, DateTime dataPrevista, DateTime dataReserva, int idLeitor, int idFuncionario, int idStatus, Nullable<DateTime> dataRetirada)
        {
            this.ID = ID;
            this.DataPrevista = dataPrevista;
            this.DataReserva = dataReserva;
            this.IdLeitor = idLeitor;
            this.IdFuncionario = idFuncionario;
            this.Status = idStatus;
            this.DataRetirada = dataRetirada;
        }

        public ReservaModel(int ID, int IdFuncionario, int IdLeitor, DateTime DataReserva, string Obs) {
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
        public ReservaModel(int ID, int IdFuncionario, int IdLeitor, DateTime DataReserva, string Leitor, string Funcionario) {
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
