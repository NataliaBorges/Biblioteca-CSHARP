using Biblioteca.Util;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Biblioteca.Model;
using System.Globalization;
using System.Collections.Generic;

namespace Biblioteca.Controller {
    class EditoraController {

        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set;  }

        Singleton singleton = Singleton.GetInstancia();

        public EditoraController() {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }

        public bool Insercao(EditoraModel editora) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"INSERT INTO Editora Values (@Nome_Editora, @Endereco, @Telefone, @CNPJ, @Email)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Nome_Editora", editora.Nome);
            Cmd.Parameters.AddWithValue("@Endereco", editora.Endereco);
            Cmd.Parameters.AddWithValue("@Telefone", editora.Telefone);
            Cmd.Parameters.AddWithValue("@CNPJ", editora.CNPJ);
            Cmd.Parameters.AddWithValue("@Email", editora.Email);

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            } else {
                return false;
            }
        }

        public bool Atualizar(EditoraModel editora) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Editora SET Nome_Editora = @Nome_Editor,  
                                Endereco = @Endereco, Telefone = @Telefone, CNPJ = @CNPJ, Email = @Email
                                WHERE ID = @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", editora.getId());
            Cmd.Parameters.AddWithValue("@Nome_Editora", editora.Nome);
            Cmd.Parameters.AddWithValue("@Endereco", editora.Endereco);
            Cmd.Parameters.AddWithValue("@Telefone", editora.Telefone);
            Cmd.Parameters.AddWithValue("@CNPJ", editora.CNPJ);
            Cmd.Parameters.AddWithValue("@Email", editora.Email);


            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        public List<EditoraModel> ListarTodos() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Editora";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EditoraModel> lista = new List<EditoraModel>();

            while (reader.Read()) {
                EditoraModel editora = new EditoraModel(
                    (int)reader["ID"],
                    (String)reader["Nome_Editora"],
                    (String)reader["Endereco"],
                    (String)reader["CNPJ"],
                    (String)reader["Email"],
                    (String)reader["Telefone"]
                );
                lista.Add(editora);
            }
            reader.Close();

            return lista;
        }
        public List<EditoraModel> PesquisarEditora()
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT	Id,
		                                Nome_Editora,
		                                CNPJ
                                FROM Editora";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EditoraModel> lista = new List<EditoraModel>();

            while (reader.Read())
            {
                EditoraModel editora = new EditoraModel(
                    (int)reader["ID"],
                    (String)reader["Nome_Editora"]
                );
                lista.Add(editora);
            }
            reader.Close();

            return lista;
        }

        public List<EditoraModel> Buscar(string busca, bool isNome = false, bool isCNPJ = false) {
            Cmd.Connection = connection.RetornaConexao();

            if (isNome) {
                Cmd.CommandText = @"SELECT * FROM Editora WHERE Nome_Editra LIKE '"+busca+"%'";
            }
            if (isCNPJ) {
                Cmd.CommandText = @"SELECT * FROM Editora WHERE CNPJ LIKE '" + busca+"%'";
            }

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EditoraModel> lista = new List<EditoraModel>();

            while (reader.Read()) {
                EditoraModel leitor = new EditoraModel(
                    (int)reader["ID"],
                    (String)reader["Nome_Editora"],
                    (String)reader["Endereco"],
                    (String)reader["CNPJ"],
                    (String)reader["Email"],
                    (String)reader["Telefone"]
                );
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

        public bool Excluir(EditoraModel editora) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"DELETE FROM Editora WHERE ID = @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", editora.getId());

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        public List<EditoraModel> SelecionarEditora(string busca)
        {
            Cmd.Connection = connection.RetornaConexao();


            Cmd.CommandText = @"SELECT  * from Editora
                                WHERE Editora.Nome_Editora LIKE '" + busca + "%'";

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EditoraModel> lista = new List<EditoraModel>();

            while (reader.Read())
            {
                EditoraModel editora = new EditoraModel(
                    (int)reader["Id"],
                    (String)reader["Nome_Editora"]
                );
                lista.Add(editora);
            }
            reader.Close();

            return lista;

        }

    }
}
