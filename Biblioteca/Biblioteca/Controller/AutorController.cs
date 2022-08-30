using Biblioteca.Model;
using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Biblioteca.Controller
{
    internal class AutorController
    {
        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set; }

        Singleton singleton = Singleton.GetInstancia();

        public AutorController()
        {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }
        public List<AutorModel> ListarTodos(List<AutorModel> lista)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Autor";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<AutorModel> list = new List<AutorModel>();

            while (reader.Read())
            {
                AutorModel autor = new AutorModel(
                    (int)reader["ID"],
                    (String)reader["Nome"]
                );
                list.Add(autor);
            }
            reader.Close();

            return list;
        }
    }
}
