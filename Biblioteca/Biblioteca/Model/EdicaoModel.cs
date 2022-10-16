using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    internal class EdicaoModel
    {
        public int Id { get; set; }
        public string Nome_Edicao { get; set; }
        public int Estado { get; set; }

        public EdicaoModel(int Id, string nome)
        {
            this.Id = Id;
            this.Nome_Edicao = nome;
        }
        public EdicaoModel(int Id, string nome, int estado)
        {
            this.Id = Id;
            this.Nome_Edicao = nome;
            this.Estado = estado;
        }
        public EdicaoModel(string nome)
        {
            this.Nome_Edicao = nome;
        }
        public int getId()
        {
            return this.Id;
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
