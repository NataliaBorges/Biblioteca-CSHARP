using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    internal class EstadoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public EstadoModel(int Id, string nome)
        {
            this.Id = Id;
            this.Nome = nome;
        }
        public int getId()
        {
            return this.Id;
        }
    }
}
