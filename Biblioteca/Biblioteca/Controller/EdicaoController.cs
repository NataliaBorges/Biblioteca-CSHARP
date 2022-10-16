using Biblioteca.Model;
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
        public List<EdicaoModel> ListarUltimosDez()
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Edicao
                                WHERE Estado = 1
                                ORDER BY Id desc
                                OFFSET 0 ROWS FETCH NEXT 10 ROWS ONLY";

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
            Cmd.CommandText = @"INSERT INTO edicao Values (@Nome_Edicao, @Estado)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Nome_Edicao", edicao.Nome_Edicao);
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
        public List<EdicaoModel> BuscarEdicao(string busca, string status = "Ambos")
        {
            Cmd.Connection = connection.RetornaConexao();

            int statusNumero = 2; // Ambos

            if (status == "Ativo")
            {
                statusNumero = 1;
            }

            if (status == "Inativo")
            {
                statusNumero = 0;
            }

            if (statusNumero == 2)
            {
                Cmd.CommandText = @"SELECT  * from Edicao
                                WHERE Edicao.Nome_Edicao LIKE '%" + busca + "%'";
            }
            else
            {
                Cmd.CommandText = @"SELECT  * from Edicao
                                WHERE Edicao.Estado = '" + statusNumero + "' AND Edicao.Nome_Edicao LIKE '%" + busca + "%'";
            }

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EdicaoModel> lista = new List<EdicaoModel>();

            while (reader.Read())
            {
                EdicaoModel edicao = new EdicaoModel(
                    (int)reader["Id"],
                    (String)reader["Nome_Edicao"],
                    (int)reader["Estado"]
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
        public bool Atualizar(EdicaoModel edicao)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Edicao SET Nome_Edicao = @Nome_Edicao, Estado = @Estado
                                WHERE Id = @Id";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Id", edicao.getId());
            Cmd.Parameters.AddWithValue("@Nome_Edicao", edicao.Nome_Edicao);
            Cmd.Parameters.AddWithValue("@Estado", edicao.Estado);

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
