using Biblioteca.Util;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Biblioteca.Model;
using System.Globalization;
using System.Collections.Generic;

namespace Biblioteca.Controller {
    class LeitorController {

        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set;  }

        Singleton singleton = Singleton.GetInstancia();

        public LeitorController() {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }

        public bool Insercao(LeitorModel leitor) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"INSERT INTO Leitor Values (@Nome_Leitor, @Data_Nascimento, @Telefone, @CPF, @Endereco)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Nome_Leitor", leitor.Nome);
            Cmd.Parameters.AddWithValue("@Data_Nascimento", leitor.DataNascimento);
            Cmd.Parameters.AddWithValue("@Telefone", leitor.Telefone);
            Cmd.Parameters.AddWithValue("@CPF", leitor.CPF);
            Cmd.Parameters.AddWithValue("@Endereco", leitor.Endereco);

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            } else {
                return false;
            }
        }

        public bool Atualizar(LeitorModel leitor) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Leitor SET Nome_Leitor = @Nome_Leitor, Data_Nascimento = @Data_Nascimento, 
                                Telefone = @Telefone, CPF = @CPF, Endereco = @Endereco
                                WHERE ID_leitor = @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", leitor.getId());
            Cmd.Parameters.AddWithValue("@Nome_Leitor", leitor.Nome);
            Cmd.Parameters.AddWithValue("@Data_Nascimento", leitor.DataNascimento.ToString("yyyy-MM-dd"));
            Cmd.Parameters.AddWithValue("@Telefone", leitor.Telefone);
            Cmd.Parameters.AddWithValue("@CPF", leitor.CPF);
            Cmd.Parameters.AddWithValue("@Endereco", leitor.Endereco);

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        public List<LeitorModel> ListarTodos() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Leitor";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LeitorModel> lista = new List<LeitorModel>();

            while (reader.Read()) {
                LeitorModel leitor = new LeitorModel(
                    (int)reader["ID_leitor"],
                    (String)reader["Nome_Leitor"],
                    (DateTime)reader["Data_Nascimento"],
                    (String)reader["Telefone"],
                    (String)reader["CPF"],
                    (String)reader["Endereco"]
                );
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

        public List<LeitorModel> Buscar(string busca, bool isNome = false, bool isCPF = false) {
            Cmd.Connection = connection.RetornaConexao();

            if (isNome) {
                Cmd.CommandText = @"SELECT * FROM LEITOR WHERE Nome_Leitor LIKE '"+busca+"%'";
            }

            if (isCPF) {
                Cmd.CommandText = @"SELECT * FROM LEITOR WHERE CPF LIKE '"+busca+"%'";
            }

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LeitorModel> lista = new List<LeitorModel>();

            while (reader.Read()) {
                LeitorModel leitor = new LeitorModel(
                    (int)reader["ID_leitor"],
                    (String)reader["Nome_Leitor"],
                    (DateTime)reader["Data_Nascimento"],
                    (String)reader["Telefone"],
                    (String)reader["CPF"],
                    (String)reader["Endereco"]
                );
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

        public bool Excluir(LeitorModel leitor) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"DELETE FROM Leitor WHERE ID_leitor = @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", leitor.getId());

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

    }
}
