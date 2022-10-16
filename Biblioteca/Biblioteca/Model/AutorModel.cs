using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class AutorModel {
        public int Id_autor { get; set; }
        public string Nome_Autor { get; set; }
        public int Estado { get; set; }

        public AutorModel(int Id_autor, string nome_autor) {
            this.Id_autor = Id_autor;
            this.Nome_Autor = nome_autor;
        }
        public AutorModel(int Id_autor, string nome_autor, int estado)
        {
            this.Id_autor = Id_autor;
            this.Nome_Autor = nome_autor;
            this.Estado = estado;
        }
        public AutorModel(string nome_autor)
        {
            this.Nome_Autor = nome_autor;
        }
        public int getId() {
            return this.Id_autor;
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
