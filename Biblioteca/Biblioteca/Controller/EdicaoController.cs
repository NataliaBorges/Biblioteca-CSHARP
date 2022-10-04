﻿using Biblioteca.Model;
using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Biblioteca.Controller
{
    internal class EdicaoController
    {
        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set; }

        Singleton singleton = Singleton.GetInstancia();

        public EdicaoController()
        {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }
        public List<EdicaoModel> ListarTodos()
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Edicao";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EdicaoModel> list = new List<EdicaoModel>();

            while (reader.Read())
            {
                EdicaoModel edicao = new EdicaoModel(
                    (int)reader["Id"],
                    (String)reader["Nome_Edicao"]
                );
                list.Add(edicao);
            }
            reader.Close();

            return list;
        }
        public bool Insercao(EdicaoModel edicao)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"INSERT INTO edicao Values (@Nome_Edicao)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Nome_Edicao", edicao.Nome_Edicao);

            if (Cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<EdicaoModel> BuscarEdicao(string busca)
        {
            Cmd.Connection = connection.RetornaConexao();


            Cmd.CommandText = @"SELECT  * from Edicao
                                WHERE Edicao.NOme_Edicao LIKE '" + busca + "%'";

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EdicaoModel> lista = new List<EdicaoModel>();

            while (reader.Read())
            {
                EdicaoModel edicao = new EdicaoModel(
                    (int)reader["Id"],
                    (String)reader["Nome_Edicao"]
                );
                lista.Add(edicao);
            }
            reader.Close();

            return lista;

        }
        public bool Excluir(EdicaoModel edicao)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"DELETE FROM Edicao WHERE Id = @Id";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Id", edicao.getId());

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
