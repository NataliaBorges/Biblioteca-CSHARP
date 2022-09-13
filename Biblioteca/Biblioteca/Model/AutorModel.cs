using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class AutorModel {
        public int Id_autor { get; set; }
        public String Nome_Autor { get; set; }

        public AutorModel(int Id_autor, String nome_autor) {
            this.Id_autor = Id_autor;
            this.Nome_Autor = nome_autor;
        }
        public int getId() {
            return this.Id_autor;
        }
    }
}
