﻿using Biblioteca.Util;
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
            Cmd.CommandText = @"SELECT * FROM Livro ORDER BY Id DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            while (reader.Read()) {
                int idLivro = (int)reader["Id"];
                reader.Close();
                return idLivro;
            }


            return 0;
        }
        public bool Insercao(LivroModel livro) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"INSERT INTO Livro Values (@Titulo, @Id_genero, @Id_autor, @Id_Editora)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Titulo", livro.Titulo);
            Cmd.Parameters.AddWithValue("@Id_genero", livro.IdGenero);
            Cmd.Parameters.AddWithValue("@Id_autor", livro.IdAutor);
            Cmd.Parameters.AddWithValue("@Id_editora", livro.IdEditora);

            if (Cmd.ExecuteNonQuery() == 1)
            {
                int ultimoLivroId = BuscarUltimoLivro();
                for (int i = 0; i < livro.Quantidade; i++)
                {
                    //Cmd.Connection = connection.RetornaConexao();
                    //Cmd.CommandText = @"INSERT INTO Exemplar Values (@Data_Aquisição, @Id_livro)";

                    //Cmd.Parameters.Clear();
                    //Cmd.Parameters.AddWithValue("@Data_Aquisição", "2022-09-19");
                    //Cmd.Parameters.AddWithValue("@Id_livro", ultimoLivroId);
                    //Cmd.ExecuteNonQuery();
                }

                return true;
            }
            else
            {
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
            Cmd.CommandText = @"UPDATE Livro SET Titulo = @Titulo, IdGenero = @Id_genero, 
                                IdAutor = @Id_autor, IdEditora = @Id_editora
                                WHERE ID_livro = @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", livro.getId());
            Cmd.Parameters.AddWithValue("@Titulo", livro.Titulo);
            Cmd.Parameters.AddWithValue("@Id_Editora", livro.IdEditora);
            Cmd.Parameters.AddWithValue("@Id_Autor", livro.IdAutor);
            Cmd.Parameters.AddWithValue("@Id_Genero", livro.IdGenero);



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
                                SELECT	Livro.Id,
		                                Livro.Titulo,
		                                Editora.Nome_Editora,
		                                Autor.Nome_Autor,
		                                Genero.Nome_Genero,
					                    COUNT(Exemplar.Id_livro) as Quantidade
                                FROM Livro
                                INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                INNER JOIN Genero ON (Genero.Id = Livro.Id_Genero)
                                LEFT JOIN Exemplar ON (Exemplar.Id_livro = Livro.Id)
                                GROUP BY Livro.Id, Livro.Titulo, Editora.Nome_Editora, Autor.Nome_Autor, Genero.Nome_Genero
            ";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LivroModel> lista = new List<LivroModel>();

            while (reader.Read()) {
                LivroModel livro = new LivroModel(
                    (int)reader["Id"],
                    (String)reader["Titulo"],
                    (String)reader["Nome_Editora"],
                    (String)reader["Nome_Autor"],
                    (String)reader["Nome_Genero"],
                    (int)reader["Quantidade"]
                ); 
                lista.Add(livro);
            }
            reader.Close();

            return lista;
        }

        public List<LivroModel> Buscar(string busca, bool isNome = false, bool isAutor = false, bool isEditora = false, bool isGenero = false) {
            Cmd.Connection = connection.RetornaConexao();

            if (isNome) {
                Cmd.CommandText = @"SELECT	Livro.Id,
		                                Livro.Titulo,
		                                Editora.Nome_Editora,
		                                Autor.Nome_Autor,
		                                Genero.Nome_Genero,
					                    COUNT(Exemplar.Id_livro) as Quantidade
                                    FROM Livro
                                    INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                    INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                    INNER JOIN Genero ON (Genero.Id = Livro.Id_Genero)
                                    LEFT JOIN Exemplar ON (Exemplar.Id_livro = Livro.Id)
                                    GROUP BY Livro.Id, Livro.Titulo, Editora.Nome_Editora, Autor.Nome_Autor, Genero.Nome_Genero
                                    WHERE Livro.Titulo LIKE '" + busca + "%'";
            }

            if (isAutor) {
                Cmd.CommandText = @"SELECT	Livro.Id,
		                                Livro.Titulo,
		                                Editora.Nome_Editora,
		                                Autor.Nome_Autor,
		                                Genero.Nome_Genero,
					                    COUNT(Exemplar.Id_livro) as Quantidade
                                    FROM Livro
                                    INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                    INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                    INNER JOIN Genero ON (Genero.Id = Livro.Id_Genero)
                                    LEFT JOIN Exemplar ON (Exemplar.Id_livro = Livro.Id)
                                    GROUP BY Livro.Id, Livro.Titulo, Editora.Nome_Editora, Autor.Nome_Autor, Genero.Nome_Genero
                                    WHERE Autor.Nome_Autor LIKE '" + busca + "%'";
            }

            if (isEditora) {
                Cmd.CommandText =
                Cmd.CommandText = @"SELECT	Livro.Id,
		                                Livro.Titulo,
		                                Editora.Nome_Editora,
		                                Autor.Nome_Autor,
		                                Genero.Nome_Genero,
					                    COUNT(Exemplar.Id_livro) as Quantidade
                                    FROM Livro
                                    INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                    INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                    INNER JOIN Genero ON (Genero.Id = Livro.Id_Genero)
                                    LEFT JOIN Exemplar ON (Exemplar.Id_livro = Livro.Id)
                                    GROUP BY Livro.Id, Livro.Titulo, Editora.Nome_Editora, Autor.Nome_Autor, Genero.Nome_Genero
                                    WHERE Editora.Nome_Editora LIKE '" + busca + "%'";
            }
            if (isGenero)
            {
                Cmd.CommandText =
                Cmd.CommandText = @"SELECT	Livro.Id,
		                                Livro.Titulo,
		                                Editora.Nome_Editora,
		                                Autor.Nome_Autor,
		                                Genero.Nome_Genero,
					                    COUNT(Exemplar.Id_livro) as Quantidade
                                    FROM Livro
                                    INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                    INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                    INNER JOIN Genero ON (Genero.Id = Livro.Id_Genero)
                                    LEFT JOIN Exemplar ON (Exemplar.Id_livro = Livro.Id)
                                    GROUP BY Livro.Id, Livro.Titulo, Editora.Nome_Editora, Autor.Nome_Autor, Genero.Nome_Genero
                                    WHERE Genero.Nome_Genero LIKE '" + busca + "%'";
            }
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LivroModel> lista = new List<LivroModel>();

            while (reader.Read()) {
                LivroModel livro = new LivroModel(
                    (int)reader["Id"],
                    (String)reader["Titulo"],
                    (String)reader["Nome_Editora"],
                    (String)reader["Nome_Autor"],
                    (String)reader["Nome_Genero"],
                    (int)reader["Quantidade"]
                );
                lista.Add(livro);
            }
            reader.Close();

            return lista;
        }

        public bool Excluir(LivroModel livro) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"DELETE FROM Livro WHERE Id = @ID";

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
                    (int)reader["Id"],
                    (String)reader["Titulo"]
                    /*(int)reader["Quantidade"]*/,
                    (String)reader["Nome_Editora"],
                    (String)reader["Nome_Autor"],
                    (String)reader["Nome_Genero"]
                );
                livro.IdEmprestimo = (int)reader["Emprestimo"];
                lista.Add(livro);
            }
            reader.Close();

            return lista;
        }
        public List<ExemplarModel> ListarTodosExemplares(int idLivro) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT	Exemplar.Id,
		                                Livro.Titulo,
		                                Livro.Edicao,
		                                Livro.Ano_Publicacao,
		                                Livro.ISBN,
		                                Exemplar.Data_Aquisicao,
		                                Editora.Nome_Editora,
		                                Autor.Nome_Autor,
		                                Genero.Nome_Genero
                                FROM Exemplar
                                LEFT JOIN Livro ON (Livro.Id = Exemplar.Id_livro)
                                INNER JOIN Editora ON (Livro.Id_editora = Editora.Id)
                                INNER JOIN Autor ON (Livro.Id_autor = Autor.Id)
                                INNER JOIN Genero ON (Livro.Id_genero = Genero.Id)
                                WHERE Exemplar.Id_livro =  '" + idLivro + "'";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<ExemplarModel> lista = new List<ExemplarModel>();

            while (reader.Read()) {
                ExemplarModel exemplar = new ExemplarModel(
                    (int)reader["ID"],
                    (String)reader["Titulo"],
                    (String)reader["Edicao"],
                    (String)reader["Ano_Publicacao"],
                    (String)reader["ISBN"],
                    (DateTime)reader["Data_Aquisicao"],
                    (String)reader["Nome_Autor"],
                    (String)reader["Nome_Editora"],
                    (String) reader["Nome_Genero"]
                );
                lista.Add(exemplar);
            }
            reader.Close();

            return lista;
        }

    }
}
