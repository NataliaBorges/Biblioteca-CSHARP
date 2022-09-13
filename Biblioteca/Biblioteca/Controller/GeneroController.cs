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
    }
}
