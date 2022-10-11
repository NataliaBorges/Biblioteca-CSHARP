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
        public List<GeneroModel> ListarUltimosDez()
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Genero
                                ORDER BY Id desc
                                OFFSET 0 ROWS FETCH NEXT 10 ROWS ONLY";

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<GeneroModel> list = new List<GeneroModel>();

            while (reader.Read())
            {
                GeneroModel genero = new GeneroModel(
                    (int)reader["Id"],
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
        public List<GeneroModel> SelecionarGenero(string busca)
        {
            Cmd.Connection = connection.RetornaConexao();


            Cmd.CommandText = @"SELECT  * from Genero
                                WHERE Genero.Nome_Genero LIKE '%" + busca + "%'";

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<GeneroModel> lista = new List<GeneroModel>();

            while (reader.Read())
            {
                GeneroModel genero = new GeneroModel(
                    (int)reader["Id"],
                    (String)reader["Nome_Genero"]
                );
                lista.Add(genero);
            }
            reader.Close();

            return lista;

        }
        public bool Excluir(GeneroModel genero)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"DELETE FROM Genero WHERE Id = @Id";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Id", genero.getId());

            if (Cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<GeneroModel> BuscarGenero(string busca)
        {
            Cmd.Connection = connection.RetornaConexao();


            Cmd.CommandText = @"SELECT  * from Genero
                                WHERE Genero.Nome_Genero LIKE '%" + busca + "%'";

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<GeneroModel> lista = new List<GeneroModel>();

            while (reader.Read())
            {
                GeneroModel genero = new GeneroModel(
                    (int)reader["Id"],
                    (String)reader["Nome_Genero"]
                );
                lista.Add(genero);
            }
            reader.Close();

            return lista;

        }
        public bool Atualizar(GeneroModel genero)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Genero SET Nome_Genero = @Nome_Genero
                                WHERE Id = @Id";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Id", genero.getId());
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
