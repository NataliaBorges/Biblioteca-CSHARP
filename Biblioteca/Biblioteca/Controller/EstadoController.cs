using Biblioteca.Model;
using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Biblioteca.Controller
{
    internal class EstadoController
    {
        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set; }

        Singleton singleton = Singleton.GetInstancia();

        public EstadoController()
        {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }
        public List<EstadoModel> ListarTodos()
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Estado";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EstadoModel> list = new List<EstadoModel>();

            while (reader.Read())
            {
                EstadoModel funcao = new EstadoModel(
                    (int)reader["ID"],
                    (String)reader["Nome_Estado"]
                );
                list.Add(funcao);
            }
            reader.Close();

            return list;
        }
    }
}
