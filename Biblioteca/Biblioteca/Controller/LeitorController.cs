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
            Cmd.CommandText = @"INSERT INTO Leitor Values (@Nome_Leitor, @Data_Nascimento, @CPF, @Telefone, @Endereco, @Email, @Estado)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Nome_Leitor", leitor.Nome);
            Cmd.Parameters.AddWithValue("@Data_Nascimento", leitor.DataNascimento);
            Cmd.Parameters.AddWithValue("@Telefone", leitor.Telefone);
            Cmd.Parameters.AddWithValue("@CPF", leitor.CPF);
            Cmd.Parameters.AddWithValue("@Endereco", leitor.Endereco);
            Cmd.Parameters.AddWithValue("@Email", leitor.Email);
            Cmd.Parameters.AddWithValue("@Estado",  1);

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            } else {
                return false;
            }
        }

        public bool Atualizar(LeitorModel leitor) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Leitor SET Nome_Leitor = @Nome_Leitor, Data_Nascimento = @Data_Nascimento, 
                                Telefone = @Telefone, CPF = @CPF, Endereco = @Endereco, Email = @Email, Estado = @Estado
                                WHERE Id = @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", leitor.getId());
            Cmd.Parameters.AddWithValue("@Nome_Leitor", leitor.Nome);
            Cmd.Parameters.AddWithValue("@Data_Nascimento", leitor.DataNascimento.ToString("yyyy-MM-dd"));
            Cmd.Parameters.AddWithValue("@Telefone", leitor.Telefone);
            Cmd.Parameters.AddWithValue("@CPF", leitor.CPF);
            Cmd.Parameters.AddWithValue("@Endereco", leitor.Endereco);
            Cmd.Parameters.AddWithValue("@Email", leitor.Email);
            Cmd.Parameters.AddWithValue("@Estado", leitor.Estado);

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        public List<LeitorModel> Buscar(string busca, bool isNome = false, bool isCPF = false, string status = "Ambos") {
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

                if (isNome) {
                if (statusNumero == 2)
                {
                    Cmd.CommandText = @"SELECT	*  FROM Leitor
                                        WHERE Nome_Leitor LIKE '%" + busca + "%'";
                }
                else
                {
                    Cmd.CommandText = @"SELECT	* FROM Leitor
                                        WHERE estado = '" + statusNumero + "' AND Nome_Leitor LIKE '%" + busca + "%'";
                }
            }

            if (isCPF) {
                if(statusNumero == 2)
                {
                    Cmd.CommandText = @"SELECT	* FROM Leitor
                                    WHERE CPF LIKE '%" + busca + "%'";
                }
                else
                {
                    Cmd.CommandText = @"SELECT	*  FROM Leitor
                                    WHERE estado = '" + statusNumero + "' AND CPF LIKE '%" + busca + "%'";
                }
                
            }

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LeitorModel> lista = new List<LeitorModel>();

            while (reader.Read()) {
                LeitorModel leitor = new LeitorModel(
                    (int)reader["Id"],
                    (String)reader["Nome_Leitor"],
                    (DateTime)reader["Data_Nascimento"],
                    (String)reader["Telefone"],
                    (String)reader["CPF"],
                    (String)reader["Endereco"],
                    (String)reader["Email"],
                    (int)reader["estado"]
                );
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

        public bool Excluir(LeitorModel leitor) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"DELETE FROM Leitor WHERE Id = @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", leitor.getId());

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        public List<LeitorModel> Relatorio(DateTime inicio, DateTime fim) {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"SELECT COUNT(E.ID_emprestimo) AS Emprestimos, L.* 
                                FROM Leitor AS L
                                INNER JOIN Emprestimo AS E ON (E.ID_leitor = L.ID_leitor)
                                WHERE E.Data_emprestimo BETWEEN @inicio AND @fim
                                GROUP BY L.ID_leitor, L.Nome_Leitor, L.Data_Nascimento, L.Telefone, L.CPF, L.Endereco";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@inicio", inicio);
            Cmd.Parameters.AddWithValue("@fim", fim);

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LeitorModel> lista = new List<LeitorModel>();

            while (reader.Read()) {
                LeitorModel leitor = new LeitorModel(
                    (int)reader["ID_leitor"],
                    (String)reader["Nome_Leitor"],
                    (DateTime)reader["Data_Nascimento"],
                    (String)reader["Telefone"],
                    (String)reader["CPF"],
                    (String)reader["Endereco"],
                    (String)reader["Email"]
                );
                leitor.QuantidadeEmprestimo = (int)reader["Emprestimos"];
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

    }
}
