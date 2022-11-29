using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    public class ReservaVisualizarModel
    {
        public int ID_reserva { get; set; }
        public string Nome_Livro { get; set; }
        public string ISBN { get; set; }
        public string Nome_Funcionario { get; set; }
        public DateTime Data_Reserva { get; set; }
        public DateTime Data_PegarLivro { get; set; }
        public Nullable<DateTime> Data_Retirada { get; set; }
        public string Status_Reserva { get; set; }
        public string Status_Exemplar { get; set; }

        private int ID_Item_Reserva;
        public ReservaVisualizarModel(int ID_reserva, string Nome_Livro, string ISBN, string Nome_Funcionario, DateTime Data_Reserva, DateTime Data_PegarLivro, Nullable<DateTime> Data_Retirada, string Status_Reserva, string Status_Exemplar)
        {
            this.ID_reserva = ID_reserva;
            this.Nome_Livro = Nome_Livro;
            this.ISBN = ISBN;
            this.Nome_Funcionario = Nome_Funcionario;
            this.Data_Reserva = Data_Reserva;
            this.Data_PegarLivro = Data_PegarLivro;
            this.Data_Retirada = Data_Retirada;
            this.Status_Reserva = Status_Reserva;
            this.Status_Exemplar = Status_Exemplar;
        }
        public void setItemReservaId(int id)
        {
            this.ID_Item_Reserva = id;
        }
        public int getItemReservaId()
        {
            return this.ID_Item_Reserva;
        }
    }
}
