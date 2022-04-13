using Biblioteca.Util;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Biblioteca.Model;
using System.Globalization;
using System.Collections.Generic;

namespace Biblioteca.Controller {
    class LivroController {

        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set;  }

        Singleton singleton = Singleton.GetInstancia();

        public LivroController() {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }

        public bool Insercao(LivroModel livro) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"INSERT INTO Livro Values (@ID_Fornecedor, @Nome_Livro, @Autor_Livro, @Edicao, @Ano_publicacao, @Data_aquisicao, @Quantidade, @ISBN)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID_Fornecedor", livro.IdFornecedor);
            Cmd.Parameters.AddWithValue("@Nome_Livro", livro.Nome);
            Cmd.Parameters.AddWithValue("@Autor_Livro", livro.Autor);
            Cmd.Parameters.AddWithValue("@Edicao", livro.Edicao);
            Cmd.Parameters.AddWithValue("@Ano_publicacao", livro.AnoPublicacao);
            Cmd.Parameters.AddWithValue("@Data_aquisicao", livro.DataAquisicao);
            Cmd.Parameters.AddWithValue("@Quantidade", "1");
            Cmd.Parameters.AddWithValue("@ISBN", livro.ISBN);

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            } else {
                return false;
            }
        }

        public bool Atualizar(LivroModel livro) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Livro SET ID_fornecedor = @ID_Fornecedor, Nome_Livro = @Nome_Livro, Autor_Livro = @Autor_livro,
                                Edicao = @Edicao, Ano_publicacao = @Ano_publicacao, Data_aquisicao = @Data_aquisicao, ISBN = @ISBN
                                WHERE ID_livro = @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", livro.getId());
            Cmd.Parameters.AddWithValue("@ID_Fornecedor", livro.IdFornecedor);
            Cmd.Parameters.AddWithValue("@Nome_Livro", livro.Nome);
            Cmd.Parameters.AddWithValue("@Autor_Livro", livro.Autor);
            Cmd.Parameters.AddWithValue("@Edicao", livro.Edicao);
            Cmd.Parameters.AddWithValue("@Ano_publicacao", livro.AnoPublicacao);
            Cmd.Parameters.AddWithValue("@Data_aquisicao", livro.DataAquisicao.ToString("yyyy-MM-dd"));
            Cmd.Parameters.AddWithValue("@ISBN", livro.ISBN);



            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        public List<LivroModel> ListarTodos() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"
            SELECT L.*, F.Nome_fornecedor as Fornecedor 
            FROM Livro AS L
            INNER JOIN Fornecedor AS F ON (F.ID_fornecedor = L.ID_fornecedor)
            ";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LivroModel> lista = new List<LivroModel>();

            while (reader.Read()) {
                LivroModel livro = new LivroModel(
                    (int)reader["ID_livro"],
                    (int)reader["ID_fornecedor"],
                    (String)reader["Nome_Livro"],
                    (String)reader["Autor_Livro"],
                    (String)reader["Edicao"],
                    (String)reader["Ano_publicacao"],
                    (DateTime)reader["Data_aquisicao"],
                    (String)reader["ISBN"],
                    (String)reader["Fornecedor"]
                ); 
                lista.Add(livro);
            }
            reader.Close();

            return lista;
        }

        public List<LivroModel> Buscar(string busca, bool isNome = false, bool isAutor = false, bool isEditora = false) {
            Cmd.Connection = connection.RetornaConexao();

            if (isNome) {
                Cmd.CommandText = @"
                SELECT L.*, F.Nome_fornecedor as Fornecedor 
                FROM Livro AS L
                INNER JOIN Fornecedor AS F ON (F.ID_fornecedor = L.ID_fornecedor)
                WHERE L.Nome_Livro LIKE '"+busca+"%'";
            }

            if (isAutor) {
                Cmd.CommandText = @"
                SELECT L.*, F.Nome_fornecedor as Fornecedor 
                FROM Livro AS L
                INNER JOIN Fornecedor AS F ON (F.ID_fornecedor = L.ID_fornecedor)
                WHERE L.Autor_Livro LIKE '" + busca + "%'";
            }

            if (isEditora) {
                Cmd.CommandText = @"
                SELECT L.*, F.Nome_fornecedor as Fornecedor 
                FROM Livro AS L
                INNER JOIN Fornecedor AS F ON (F.ID_fornecedor = L.ID_fornecedor)
                WHERE F.Nome_fornecedor LIKE '" + busca + "%'";
            }

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LivroModel> lista = new List<LivroModel>();

            while (reader.Read()) {
                LivroModel livro = new LivroModel(
                    (int)reader["ID_livro"],
                    (int)reader["ID_fornecedor"],
                    (String)reader["Nome_Livro"],
                    (String)reader["Autor_Livro"],
                    (String)reader["Edicao"],
                    (String)reader["Ano_publicacao"],
                    (DateTime)reader["Data_aquisicao"],
                    (String)reader["Fornecedor"],
                    (String)reader["ISBN"]
                );
                lista.Add(livro);
            }
            reader.Close();

            return lista;
        }

        public List<EditoraModel> ListarFornecedores() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Fornecedor";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EditoraModel> lista = new List<EditoraModel>();

            while (reader.Read()) {
                EditoraModel fornecedor = new EditoraModel(
                    (int)reader["ID_fornecedor"],
                    (String)reader["Nome_fornecedor"],
                    (String)reader["Endereco"],
                    (String)reader["Telefone"],
                    (String)reader["CNPJ"],
                    (String)reader["EMail"]
                );
                lista.Add(fornecedor);
            }
            reader.Close();

            return lista;
        }

        public bool Excluir(LivroModel livro) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"DELETE FROM Livro WHERE ID_livro = @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", livro.getId());

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        public List<LivroModel> Relatorio(DateTime inicio, DateTime fim) {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"SELECT L.*, F.Nome_fornecedor AS 'Fornecedor', IE.ID_emprestimo AS 'Emprestimo'
                                FROM Livro AS L
                                INNER JOIN Fornecedor AS F ON (F.ID_fornecedor = L.ID_fornecedor)
                                INNER JOIN Item_emprestimo AS IE ON (IE.ID_livro = L.ID_livro)
                                WHERE EXISTS (
	                                SELECT * 
	                                FROM Item_emprestimo AS IE
	                                INNER JOIN Emprestimo AS E ON (E.ID_emprestimo = IE.ID_emprestimo)
	                                WHERE IE.ID_livro = L.ID_Livro AND E.Data_emprestimo BETWEEN @inicio AND @fim
                                )";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@inicio", inicio);
            Cmd.Parameters.AddWithValue("@fim", fim);

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LivroModel> lista = new List<LivroModel>();

            while (reader.Read()) {
                LivroModel livro = new LivroModel(
                    (int)reader["ID_livro"],
                    (int)reader["ID_fornecedor"],
                    (String)reader["Nome_Livro"],
                    (String)reader["Autor_Livro"],
                    (String)reader["Edicao"],
                    (String)reader["Ano_publicacao"],
                    (DateTime)reader["Data_aquisicao"],
                    (String)reader["Fornecedor"],
                    (string) reader["ISBN"]
                );
                livro.Id_emprestimo = (int)reader["Emprestimo"];
                lista.Add(livro);
            }
            reader.Close();

            return lista;
        }

    }
}
