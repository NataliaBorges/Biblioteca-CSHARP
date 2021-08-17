using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class ItemReservaModel {
        int ID { get; set; }
        public int IdLivro { get; set; }
        public int IdReserva { get; set; }
        public String Obs { get; set; }

        public ItemReservaModel(int ID, int IdLivro, int IdReserva, String Obs) {
            this.ID = ID;
            this.IdLivro = IdLivro;
            this.IdReserva = IdReserva;
            this.Obs = Obs;
        }
        public ItemReservaModel(int ID, int IdLivro, int IdReserva) {
            this.ID = ID;
            this.IdLivro = IdLivro;
            this.IdReserva = IdReserva;
        }
        public int getId() {
            return this.ID;
        }
    }
}
