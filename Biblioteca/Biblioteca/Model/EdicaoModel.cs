using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    internal class EdicaoModel
    {
        public int Id { get; set; }
        public String Nome_Edicao { get; set; }

        public EdicaoModel(int Id, String nome)
        {
            this.Id = Id;
            this.Nome_Edicao = nome;
        }
        public EdicaoModel(String nome)
        {
            this.Nome_Edicao = nome;
        }
        public int getId()
        {
            return this.Id;
        }
    }
}
