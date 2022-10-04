using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class GeneroModel {
        public int Id_genero { get; set; }
        public string Nome_genero { get; set; }

        public GeneroModel(int Id_genero, string nomeGenero) {
            this.Id_genero = Id_genero;
            this.Nome_genero = nomeGenero;
        }
        public GeneroModel(string nomeGenero)
        {
            this.Nome_genero = nomeGenero;
        }
        public int getId() {
            return this.Id_genero;
        }
    }
}
