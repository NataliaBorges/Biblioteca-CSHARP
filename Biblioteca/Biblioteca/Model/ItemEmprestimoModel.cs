using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class ItemEmprestimoModel {
        int ID { get; set; }

        public int IdEmprestimo { get; set; }
        public int IdExemplar { get; set; }

        public ItemEmprestimoModel(int ID, int IdEmprestimo, int IdExemplar) {
            this.ID = ID;
            this.IdEmprestimo = IdEmprestimo;
            this.IdExemplar = IdExemplar;
        }
        public int getId() {
            return this.ID;
        }
    }
}
