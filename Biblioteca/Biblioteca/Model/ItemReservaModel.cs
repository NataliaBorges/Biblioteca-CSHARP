﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class ItemReservaModel {
        int ID { get; set; }
        public int IdExemplar { get; set; }
        public int IdReserva { get; set; }
        public string Obs { get; set; }

        public ItemReservaModel(int ID, int IdLivro, int IdReserva, string Obs) {
            this.ID = ID;
            this.IdExemplar = IdLivro;
            this.IdReserva = IdReserva;
            this.Obs = Obs;
        }
        public ItemReservaModel(int ID, int IdLivro, int IdReserva) {
            this.ID = ID;
            this.IdExemplar = IdLivro;
            this.IdReserva = IdReserva;
        }
        public int getId() {
            return this.ID;
        }
    }
}
