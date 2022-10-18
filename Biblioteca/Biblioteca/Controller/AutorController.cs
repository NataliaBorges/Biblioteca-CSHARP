﻿using Biblioteca.Model;
using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows;

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
        public List<AutorModel> ListarUltimosDez()
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Autor
                                ORDER BY Id desc
                                OFFSET 0 ROWS FETCH NEXT 10 ROWS ONLY";

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<AutorModel> list = new List<AutorModel>();

            while (reader.Read())
            {
                AutorModel autor = new AutorModel(
                    (int)reader["ID"],
                    (String)reader["Nome_Autor"]
                );
                list.Add(autor);
            }
            reader.Close();

            return list;
        }
        public bool Insercao(AutorModel autor)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"INSERT INTO Autor Values (@Nome_Autor, @Estado)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Nome_Autor", autor.Nome_Autor);
            Cmd.Parameters.AddWithValue("@Estado", 1);

            if (Cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<AutorModel> SelecionarAutor(string busca)
        {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"SELECT  * from Autor WHERE estado = 1 AND Autor.Nome_Autor LIKE '%"+ busca +"%'";

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<AutorModel> lista = new List<AutorModel>();

            while (reader.Read())
            {
                AutorModel autor = new AutorModel(
                    (int)reader["Id"],
                    (String)reader["Nome_Autor"]
                );
                lista.Add(autor);
            }
            reader.Close();

            return lista;

        }
        public List<AutorModel> BuscarAutor(string busca, string status = "Ambos")
        {
            Cmd.Connection = connection.RetornaConexao();

            int statusNumero = 2; // Ambos

            if(status == "Ativo")
            {
                statusNumero = 1;
            } 
            
            if(status == "Inativo")
            {
                statusNumero = 0;
            }

            if(statusNumero == 2)
            {
                Cmd.CommandText = @"SELECT  * from Autor
                            WHERE Autor.Nome_Autor LIKE '%" + busca + "%'";
            } 
            else
            {
                Cmd.CommandText = @"SELECT  * from Autor
                            WHERE Autor.Estado = '"+ statusNumero + "' AND Autor.Nome_Autor LIKE '%" + busca + "%'";
            }

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<AutorModel> lista = new List<AutorModel>();

            while (reader.Read())
            {
                AutorModel autor = new AutorModel(
                    (int)reader["Id"],
                    (String)reader["Nome_Autor"],
                    (int)reader["Estado"]
                );
                lista.Add(autor);
            }
            reader.Close();

            return lista;

        }
        public bool Excluir(AutorModel autor)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"DELETE FROM Autor WHERE Id = @Id";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Id", autor.getId());

            if (Cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Atualizar(AutorModel autor)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Autor SET Nome_Autor = @Nome_Autor, Estado = @Estado
                                WHERE Id = @Id";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Id", autor.getId());
            Cmd.Parameters.AddWithValue("@Nome_Autor", autor.Nome_Autor);
            Cmd.Parameters.AddWithValue("@Estado", autor.Estado);


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
