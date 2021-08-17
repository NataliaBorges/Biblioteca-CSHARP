using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class ItemEmprestimoModel {
        int ID { get; set; }
        public int IdLivro { get; set; }
        public int IdEmprestimo { get; set; }
        public String Obs { get; set; }

        public ItemEmprestimoModel(int ID, int IdLivro, int IdEmprestimo, String Obs) {
            this.ID = ID;
            this.IdLivro = IdLivro;
            this.IdEmprestimo = IdEmprestimo;
            this.Obs = Obs;
        }
        public ItemEmprestimoModel(int ID, int IdLivro, int IdEmprestimo) {
            this.ID = ID;
            this.IdLivro = IdLivro;
            this.IdEmprestimo = IdEmprestimo;
        }
        public int getId() {
            return this.ID;
        }
    }
}
