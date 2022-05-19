using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class AutorModel {
        int Id_autor { get; set; }
        String Nome { get; set; }

        public AutorModel(int Id_autor, String nome) {
            this.Id_autor = Id_autor;
            this.Nome = nome;
        }
        public int getId() {
            return this.Id_autor;
        }
    }
}
