using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Biblioteca.Controller
{
    class TelaPrincipalController
    {
        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set; }

        public TelaPrincipalController()
        {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }

        public int quantidadeEmprestados()
        {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"SELECT COUNT(Emprestimo.ID) AS Quantidade
                                FROM Emprestimo";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            int quantidade = 0;

            while (reader.Read())
            {
                quantidade = (int)reader["Quantidade"];
            }
            reader.Close();

            return quantidade;
        }
        public int quantidadeReserva()
        {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"SELECT COUNT(Reserva.Id) AS Quantidade
                                FROM Reserva";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            int quantidade = 0;

            while (reader.Read())
            {
                quantidade = (int)reader["Quantidade"];
            }
            reader.Close();

            return quantidade;
        }
        public int quantidadeLeitor()
        {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"SELECT COUNT(Leitor.Id) AS Quantidade
                                FROM Leitor";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            int quantidade = 0;

            while (reader.Read())
            {
                quantidade = (int)reader["Quantidade"];
            }
            reader.Close();

            return quantidade;
        }
        public int quantidadeExemplar()
        {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"SELECT COUNT(Exemplar.Id) AS Quantidade
                                FROM Exemplar";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            int quantidade = 0;

            while (reader.Read())
            {
                quantidade = (int)reader["Quantidade"];
            }
            reader.Close();

            return quantidade;
        }
    }
}
