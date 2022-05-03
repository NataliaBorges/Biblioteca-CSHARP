using Biblioteca.Util;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Biblioteca.Model;
using System.Globalization;
using System.Collections.Generic;

namespace Biblioteca.Controller {
    class FuncionarioController {

        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set;  }

        Singleton singleton = Singleton.GetInstancia();

        public FuncionarioController() {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }

        public bool Login(String email, String senha) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Funcionario WHERE email=@email AND senha=@senha";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@email", email);
            Cmd.Parameters.AddWithValue("@senha", senha);

            SqlDataReader reader = Cmd.ExecuteReader();

            if (reader.HasRows) {

                while (reader.Read()) {
                    FuncionarioModel funcionario = new FuncionarioModel(
                        (int)reader["ID_funcionario"],
                        (String)reader["Nome_funcionario"],
                        (String)reader["CPF"],
                        (DateTime)reader["Data_Nascimento"],
                        (String)reader["Email"],
                        (String)reader["Endereco"],
                        (String)reader["Telefone"]
                    );
                    funcionario.Funcao = (String)reader["Funcao"];
                    singleton.setFuncionario(funcionario);
                }

                reader.Close();

                return true;
            } else {
                reader.Close();
                return false;
            }
        }

        public List<FuncionarioModel> ListarTodos() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Funcionario";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<FuncionarioModel> lista = new List<FuncionarioModel>();

            while (reader.Read()) {
                FuncionarioModel funcionario = new FuncionarioModel(
                    (int)reader["ID_funcionario"],
                    (String)reader["Nome_funcionario"],
                    (String)reader["CPF"],
                    (DateTime)reader["Data_Nascimento"],
                    (String)reader["Email"],
                    (String)reader["Endereco"], 
                    (String)reader["Telefone"],
                    (String)reader["Senha"]
                );
                lista.Add(funcionario);
            }
            reader.Close();

            return lista;
        }


        public bool Insercao(FuncionarioModel funcionario) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"INSERT INTO Funcionario Values (@CPF, @Data_Nascimento, @Telefone, @Nome_funcionario, @Endereco, @Email, @Senha, @Funcao)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@CPF", funcionario.CPF);
            Cmd.Parameters.AddWithValue("@Data_Nascimento", funcionario.Data_Nascimento);
            Cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
            Cmd.Parameters.AddWithValue("@Nome_funcionario", funcionario.Nome_funcionario);
            Cmd.Parameters.AddWithValue("@Endereco", funcionario.Endereco);
            Cmd.Parameters.AddWithValue("@Email", funcionario.Email);
            Cmd.Parameters.AddWithValue("@Senha", funcionario.Senha);
            Cmd.Parameters.AddWithValue("@Funcao", funcionario.Funcao);

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        public List<FuncionarioModel> Buscar(string busca, bool isNome = false, bool isEmail = false) {
            Cmd.Connection = connection.RetornaConexao();

            if (isNome) {
                Cmd.CommandText = @"SELECT * FROM Funcionario WHERE Nome_funcionario LIKE '" + busca + "%'";
            }

            if (isEmail) {
                Cmd.CommandText = @"SELECT * FROM Funcionario WHERE Email LIKE '" + busca + "%'";
            }

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<FuncionarioModel> lista = new List<FuncionarioModel>();

            while (reader.Read()) {
                FuncionarioModel funcionario = new FuncionarioModel(
                    (int)reader["ID_funcionario"],
                    (String)reader["Nome_funcionario"],
                    (String)reader["CPF"],
                    (DateTime)reader["Data_Nascimento"],
                    (String)reader["Email"],
                    (String)reader["Endereco"],
                    (String)reader["Telefone"],
                    (String)reader["Senha"]
                );
                lista.Add(funcionario);
            }
            reader.Close();

            return lista;
        }

        public bool Atualizar(FuncionarioModel funcionario) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Funcionario SET CPF = @CPF, Data_Nascimento = @Data_Nascimento, 
                                Telefone = @Telefone, Nome_funcionario = @Nome_funcionario, Endereco = @Endereco,
                                Email = @Email, Senha = @Senha, Funcao = @funcao
                                WHERE ID_funcionario = @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", funcionario.getId());
            Cmd.Parameters.AddWithValue("@CPF", funcionario.CPF);
            Cmd.Parameters.AddWithValue("@Data_Nascimento", funcionario.Data_Nascimento);
            Cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
            Cmd.Parameters.AddWithValue("@Nome_funcionario", funcionario.Nome_funcionario);
            Cmd.Parameters.AddWithValue("@Endereco", funcionario.Endereco);
            Cmd.Parameters.AddWithValue("@Email", funcionario.Email);
            Cmd.Parameters.AddWithValue("@Senha", funcionario.Senha);
            Cmd.Parameters.AddWithValue("@Senha", funcionario.Funcao); 


            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        public bool Excluir(FuncionarioModel funcionario) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"DELETE FROM Funcionario WHERE ID_funcionario = @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", funcionario.getId());

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

    }
}
