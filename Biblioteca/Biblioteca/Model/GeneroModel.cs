using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class GeneroModel {
        public int Id_genero { get; set; }
        public string Nome_genero { get; set; }
        public int Estado { get; set; }


        public GeneroModel(int Id_genero, string nomeGenero) {
            this.Id_genero = Id_genero;
            this.Nome_genero = nomeGenero;
        }
        public GeneroModel(int Id_genero, string nomeGenero, int estado)
        {
            this.Id_genero = Id_genero;
            this.Nome_genero = nomeGenero;
            this.Estado = estado;
        }
        public GeneroModel(string nomeGenero)
        {
            this.Nome_genero = nomeGenero;
        }
        public int getId() {
            return this.Id_genero;
        }
        public string getEstado()
        {
            if (this.Estado == 0)
            {
                return "Inativo";
            }
            else
            {
                return "Ativo";
            }
        }
    }
}
