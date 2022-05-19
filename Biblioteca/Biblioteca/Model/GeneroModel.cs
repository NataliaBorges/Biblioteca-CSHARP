using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class GeneroModel {
        int Id_genero { get; set; }
        String genero { get; set; }

        public GeneroModel(int Id_genero, String genero) {
            this.Id_genero = Id_genero;
            this.genero = genero;
        }
        public int getId() {
            return this.Id_genero;
        }
    }
}
