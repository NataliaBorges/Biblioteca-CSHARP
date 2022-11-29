using Biblioteca.Util;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Biblioteca.Model;
using System.Globalization;
using System.Collections.Generic;

namespace Biblioteca.Controller
{
    class FuncionarioController
    {

        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set; }

        Singleton singleton = Singleton.GetInstancia();

        public FuncionarioController()
        {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }

        public bool Login(String email, String senha)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT Funcionario.*,
                                       Funcao.Nome_funcao AS Funcao
                                FROM Funcionario
                                INNER JOIN Funcao ON (Funcao.Id = Funcionario.Id_funcao)
                                WHERE Email=@Email AND Senha=@Senha";
            Cmd.Parameters.Clear();
            email = "najimbtsarmy@gmail.com";
            senha = "1234";
            Cmd.Parameters.AddWithValue("@Email", email);
            Cmd.Parameters.AddWithValue("@Senha", senha);

            SqlDataReader reader = Cmd.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    FuncionarioModel funcionario = new FuncionarioModel(
                        (int)reader["Id"],
                        (String)reader["Nome_Funcionario"],
                        (DateTime)reader["Data_Nascimento"],
                        (String)reader["CPF"],
                        (String)reader["Email"],
                        (String)reader["Endereco"],
                        (String)reader["Telefone"],
                        (String)reader["Email"],
                        (int)reader["Id_funcao"],
                        (int)reader["Estado"]
                    );
                    funcionario.Funcao = (String)reader["Funcao"];
                    singleton.setFuncionario(funcionario);
                }

                reader.Close();

                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }


        public bool Insercao(FuncionarioModel funcionario)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"INSERT INTO Funcionario Values (@Nome_Funcionario, @Data_Nascimento, @CPF, @Endereco, @Telefone,  @Email, @Senha, @Id_funcao, @Estado)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Nome_funcionario", funcionario.Nome_funcionario);
            Cmd.Parameters.AddWithValue("@Data_Nascimento", funcionario.Data_Nascimento.ToString("yyyy-MM-dd"));
            Cmd.Parameters.AddWithValue("@CPF", funcionario.CPF);
            Cmd.Parameters.AddWithValue("@Endereco", funcionario.Endereco);
            Cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
            Cmd.Parameters.AddWithValue("@Email", funcionario.Email);
            Cmd.Parameters.AddWithValue("@Senha", funcionario.Senha);
            Cmd.Parameters.AddWithValue("@Id_funcao", funcionario.Id_funcao);
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

        public List<FuncionarioModel> Buscar(string busca, bool isNome = false, bool isEmail = false, string status = "Ambos")
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
                if (isNome)
                {
                    Cmd.CommandText = @"SELECT  f.Id,
                                                f.Nome_Funcionario, 
		                                        f.Data_Nascimento, 
		                                        f.CPF, 
		                                        f.Endereco, 
		                                        f.Telefone,
		                                        f.Email,
		                                        Funcao.Nome_funcao,
		                                        f.Estado
                                        FROM Funcionario as f
                                        INNER JOIN Funcao ON(f.Id_funcao = Funcao.Id) 
                                        WHERE Nome_funcionario LIKE '%" + busca + "%'";
                }
                if (isEmail)
                {
                    Cmd.CommandText = @"SELECT  f.Id,
                                                f.Nome_Funcionario,  
		                                        f.Data_Nascimento, 
		                                        f.CPF, 
		                                        f.Endereco, 
		                                        f.Telefone,
		                                        f.Email,
		                                        Funcao.Nome_funcao,
		                                        f.Estado
                                        FROM Funcionario as f
                                        INNER JOIN Funcao ON(f.Id_funcao = Funcao.Id) 
                                        WHERE Email LIKE '%" + busca + "%'";
                }
            }
            else
            {
                if (isNome)
                {
                    Cmd.CommandText = @"SELECT  f.Id,
                                                f.Nome_Funcionario,  
		                                        f.Data_Nascimento, 
		                                        f.CPF, 
		                                        f.Endereco, 
		                                        f.Telefone,
		                                        f.Email,
		                                        Funcao.Nome_funcao,
		                                        f.Estado
                                        FROM Funcionario as f
                                        INNER JOIN Funcao ON(f.Id_funcao = Funcao.Id) 
                                        WHERE Estado = '" + statusNumero + "' AND Nome_funcionario LIKE '%" + busca + "%'";
                }
                if (isEmail)
                {
                    Cmd.CommandText = @"SELECT  f.Id,
                                                f.Nome_Funcionario,  
		                                        f.Data_Nascimento, 
		                                        f.CPF, 
		                                        f.Endereco, 
		                                        f.Telefone,
		                                        f.Email,
		                                        Funcao.Nome_funcao,
		                                        f.Estado
                                        FROM Funcionario as f
                                        INNER JOIN Funcao ON(f.Id_funcao = Funcao.Id) 
                                        WHERE Estado = '" + statusNumero + "' AND Email LIKE '%" + busca + "%'";
                }
            }

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<FuncionarioModel> lista = new List<FuncionarioModel>();

            while (reader.Read())
            {
                FuncionarioModel funcionario = new FuncionarioModel(
                    (int)reader["Id"],
                    (String)reader["Nome_funcionario"],
                    (DateTime)reader["Data_Nascimento"],
                    (String)reader["CPF"],
                    (String)reader["Endereco"],
                    (String)reader["Telefone"],
                    (String)reader["Email"],
                    (String)reader["Nome_Funcao"],
                    (int)reader["Estado"]
                );
                lista.Add(funcionario);
            }
            reader.Close();

            return lista;
        }

        public bool Atualizar(FuncionarioModel funcionario)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Funcionario SET  Nome_funcionario = @Nome_funcionario, CPF = @CPF, Data_Nascimento = @Data_Nascimento, 
                                Telefone = @Telefone, Endereco = @Endereco,
                                Id_funcao = @funcao, Estado = @Estado
                                WHERE Id = @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", funcionario.getId());
            Cmd.Parameters.AddWithValue("@Nome_funcionario", funcionario.Nome_funcionario);
            Cmd.Parameters.AddWithValue("@CPF", funcionario.CPF);
            Cmd.Parameters.AddWithValue("@Data_Nascimento", funcionario.Data_Nascimento.ToString("yyyy-MM-dd"));
            Cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
            Cmd.Parameters.AddWithValue("@Endereco", funcionario.Endereco);
            Cmd.Parameters.AddWithValue("@funcao", funcionario.Id_funcao);
            Cmd.Parameters.AddWithValue("@Estado", funcionario.Estado);


            if (Cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AtualizarSenha(string novaSenha, string antiga)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Funcionario SET  Senha = @Senha WHERE Id = @ID AND Senha = @Antiga";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", singleton.getFuncionario().getId());
            Cmd.Parameters.AddWithValue("@Senha", novaSenha);
            Cmd.Parameters.AddWithValue("@Antiga", antiga);


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
