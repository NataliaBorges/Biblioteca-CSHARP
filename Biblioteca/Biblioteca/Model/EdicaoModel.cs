using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    internal class EdicaoModel
    {
        public int Id { get; set; }
        public string Nome_Edicao { get; set; }

        public EdicaoModel(int Id, string nome)
        {
            this.Id = Id;
            this.Nome_Edicao = nome;
        }
        public EdicaoModel(string nome)
        {
            this.Nome_Edicao = nome;
        }
        public int getId()
        {
            return this.Id;
        }
    }
}
