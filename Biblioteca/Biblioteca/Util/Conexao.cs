﻿using System;
using System.Data.SqlClient;
namespace Biblioteca.Util
{
    class Conexao
    {

        private SqlConnection connection;

        public Conexao()
        {
            string cadeiaConexao = @"Data Source=" + Environment.MachineName + @"\SQLEXPRESS;Initial Catalog=Biblioteca_Livros;Integrated Security=true";
            connection = new SqlConnection(cadeiaConexao);
            connection.Open();
        }

        public void Desconectar()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection RetornaConexao()
        {
            return connection;
        }

    }
}

