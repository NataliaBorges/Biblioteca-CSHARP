using Biblioteca.Model;
using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Biblioteca.Controller
{
    internal class GeneroController
    {
        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set; }

        Singleton singleton = Singleton.GetInstancia();

        public GeneroController()
        {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }
        public List<GeneroModel> ListarTodos()
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Genero";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<GeneroModel> list = new List<GeneroModel>();

            while (reader.Read())
            {
                GeneroModel genero = new GeneroModel(
                    (int)reader["ID"],
                    (String)reader["Nome_Genero"]
                );
                list.Add(genero);
            }
            reader.Close();

            return list;
        }
        public List<GeneroModel> ListarPrimeira(String Nome)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Genero where Nome_Genero Like '" + Nome + "'";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<GeneroModel> list = new List<GeneroModel>();

            while (reader.Read())
            {
                GeneroModel genero = new GeneroModel(
                    (int)reader["ID"],
                    (String)reader["Nome_Genero"]
                );
                list.Add(genero);
            }
            reader.Close();

            return list;
        }
        public bool Insercao(GeneroModel genero)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"INSERT INTO Genero Values (@Nome_Genero)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Nome_Genero", genero.Nome_genero);

            if (Cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
