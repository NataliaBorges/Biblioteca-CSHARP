using Biblioteca.Model;
using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Biblioteca.Controller
{
    internal class FuncaoController
    {
        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set; }

        Singleton singleton = Singleton.GetInstancia();

        public FuncaoController()
        {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }
        public List<FuncaoModel> ListarTodos()
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Funcao";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<FuncaoModel> list = new List<FuncaoModel>();

            while (reader.Read())
            {
                FuncaoModel funcao = new FuncaoModel(
                    (int)reader["ID"],
                    (String)reader["Nome_funcao"]
                );
                list.Add(funcao);
            }
            reader.Close();

            return list;
        }
    }
}
