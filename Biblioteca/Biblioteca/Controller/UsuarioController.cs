using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Biblioteca.Controller
{
    class UsuarioController
    {
        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set; }

        Singleton singleton = Singleton.GetInstancia();

        public UsuarioController()
        {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }

        public String RetornarSenha(string email)
        {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"SELECT Senha FROM Funcionario WHERE Email = '"+email+"'";

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            while (reader.Read())
            {
                return (String)reader["Senha"];
            }
            reader.Close();

            return null;
        }
    }
}
