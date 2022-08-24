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
        public List<ExemplarModel> PegarExemplar() {
            return this.singleton.getExemplar();
        }
        public int BuscarUltimoLivro() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Livro ORDER BY ID_livro DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            while (reader.Read()) {
                int idLivro = (int)reader["ID_livro"];
                reader.Close();
                return idLivro;
            }


            return 0;
        }
        public bool Insercao(LivroModel livro) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"INSERT INTO Livro Values (@ID_Fornecedor, @Nome_Livro, @Autor_Livro, @Edicao, @Ano_publicacao, @Data_aquisicao, @Quantidade, @ISBN)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID_Fornecedor", livro.IdEditora);
            Cmd.Parameters.AddWithValue("@Nome_Livro", livro.Nome);
            Cmd.Parameters.AddWithValue("@Autor_Livro", livro.Autor);
            Cmd.Parameters.AddWithValue("@Edicao", livro.Edicao);
            Cmd.Parameters.AddWithValue("@Ano_publicacao", livro.AnoPublicacao);
            Cmd.Parameters.AddWithValue("@Data_aquisicao", livro.DataAquisicao);
            Cmd.Parameters.AddWithValue("@Quantidade", livro.Quantidade);
            Cmd.Parameters.AddWithValue("@ISBN", livro.ISBN);

            if (Cmd.ExecuteNonQuery() == 1) {
                int ultimoLivroId = BuscarUltimoLivro();
                for(int i=0; i< livro.Quantidade; i++) {
                    Cmd.Connection = connection.RetornaConexao();
                    Cmd.CommandText = @"INSERT INTO Item_livro Values (@Id_Livro)";

                    Cmd.Parameters.Clear();
                    Cmd.Parameters.AddWithValue("@Id_Livro", ultimoLivroId);
                    Cmd.ExecuteNonQuery();
                }
                
                return true;
            } else {
                return false;
            }
        }
        public bool InativarExemplar(int id) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Item_livro SET Estado = 'Inativado'
                                WHERE ID_IL = '" + id + "'";
            Cmd.Parameters.Clear();

            Cmd.ExecuteNonQuery();
            return true;
        }

        public int BuscarLivroPegarQuantidade(int id) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Livro WHERE ID_livro = '" + id + "'";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            int quantidadeAntiga = 0;

            while (reader.Read()) {
                quantidadeAntiga = (int)reader["Quantidade"];
            }

            reader.Close();

            return quantidadeAntiga;
        }

        public bool AtualizarQuantidade(int id, int quantidadeAntiga, int quantidade) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Livro SET Quantidade = @Quantidade
                            WHERE ID_livro = @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", id);
            Cmd.Parameters.AddWithValue("@Quantidade", quantidadeAntiga + quantidade);

            Cmd.ExecuteNonQuery();
            return true;
        }
        public bool InserirMaisExmplares(int quantidade, int id) {
            try {
                DateTime today = DateTime.Today;
                for (int i = 0; i < quantidade; i++) {
                    Cmd.Connection = connection.RetornaConexao();
                    Cmd.CommandText = @"INSERT INTO Item_livro Values (@Id_Livro, @Estado, @DataAquisicao)";

                    Cmd.Parameters.Clear();
                    Cmd.Parameters.AddWithValue("@Id_Livro", id);
                    Cmd.Parameters.AddWithValue("@Estado", "Ativado");
                    Cmd.Parameters.AddWithValue("@DataAquisicao", today.ToString("yyyy-MM-dd"));
                    Cmd.ExecuteNonQuery();
                }

                int quantidadeAntiga = BuscarLivroPegarQuantidade(id);
                AtualizarQuantidade(id, quantidadeAntiga, quantidade);

                return true;
            } catch(Exception e) {
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
            Cmd.Parameters.AddWithValue("@ID_Fornecedor", livro.IdEditora);
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

        public List<EditoraModel> ListarEditora() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Editora";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EditoraModel> lista = new List<EditoraModel>();

            while (reader.Read()) {
                EditoraModel Editora = new EditoraModel(
                    (int)reader["ID"],
                    (String)reader["Nome_Editora"],
                    (String)reader["Endereco"],
                    (String)reader["Telefone"],
                    (String)reader["CNPJ"],
                    (String)reader["Email"]
                );
                lista.Add(Editora);
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
        public List<ExemplarModel> ListarTodosExemplares(int idLivro) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT	IL.ID_IL AS ID,
                                        L.Nome_Livro AS Nome,
		                                L.Autor_Livro AS Autor,
		                                L.Edicao,
		                                L.Ano_publicacao AS AnoPublicacao,
		                                L.ISBN,
		                                F.Nome_fornecedor AS Fornecedor,
                                        IL.dataAquisicao AS Aquisicao,
                                        IL.Estado
                                    FROM Item_livro AS IL
                                    INNER JOIN Livro AS L ON (IL.ID_livro = L.ID_livro) 
                                    INNER JOIN Fornecedor AS F ON (F.ID_fornecedor = L.ID_fornecedor)
                                    WHERE IL.ID_livro = '" + idLivro + "'";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<ExemplarModel> lista = new List<ExemplarModel>();

            while (reader.Read()) {
                ExemplarModel exemplar = new ExemplarModel(
                    (int)reader["ID"],
                    (String)reader["Nome"],
                    (String)reader["Autor"],
                    (String)reader["Edicao"],
                    (String)reader["AnoPublicacao"],
                    (String)reader["ISBN"],
                    (String)reader["Fornecedor"],
                    (DateTime)reader["Aquisicao"],
                    (String) reader["Estado"]
                );
                lista.Add(exemplar);
            }
            reader.Close();

            return lista;
        }

    }
}
