using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    internal class FuncaoModel
    {
        public int Id { get; set; }
        public String Nome { get; set; }

        public FuncaoModel(int Id, String nome)
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
