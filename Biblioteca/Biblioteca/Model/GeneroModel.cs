﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class GeneroModel {
        public int Id_genero { get; set; }
        public String Nome_genero { get; set; }

        public GeneroModel(int Id_genero, String nomeGenero) {
            this.Id_genero = Id_genero;
            this.Nome_genero = nomeGenero;
        }
        public GeneroModel(String nomeGenero)
        {
            this.Nome_genero = nomeGenero;
        }
        public int getId() {
            return this.Id_genero;
        }
    }
}
