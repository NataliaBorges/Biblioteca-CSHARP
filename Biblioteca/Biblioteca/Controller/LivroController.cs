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
            Cmd.CommandText = @"INSERT INTO Livro Values (@Titulo, @Id_genero, @Id_autor, @Id_Editora, @Estado)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Titulo", livro.Titulo);
            Cmd.Parameters.AddWithValue("@Id_genero", livro.IdGenero);
            Cmd.Parameters.AddWithValue("@Id_autor", livro.IdAutor);
            Cmd.Parameters.AddWithValue("@Id_editora", livro.IdEditora);
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

        public bool Atualizar(LivroModel livro) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Livro SET Titulo = @Titulo, Id_genero = @Id_genero, 
                                Id_autor = @Id_autor, Id_editora = @Id_editora, Estado = @Estado
                                WHERE Id = @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", livro.getId());
            Cmd.Parameters.AddWithValue("@Titulo", livro.Titulo);
            Cmd.Parameters.AddWithValue("@Id_Editora", livro.IdEditora);
            Cmd.Parameters.AddWithValue("@Id_Autor", livro.IdAutor);
            Cmd.Parameters.AddWithValue("@Id_Genero", livro.IdGenero);
            Cmd.Parameters.AddWithValue("@Estado", livro.Estado);



            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        public LivroModel BuscarLivroId(int id) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT	Livro. *,
		                                Editora.Nome_Editora,
		                                Autor.Nome_Autor,
		                                Genero.Nome_Genero,
		                                COUNT(Exemplar.Id_livro) as Quantidade
                                FROM Livro
                                INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                INNER JOIN Genero ON (Genero.Id = Livro.Id_Genero)
                                LEFT JOIN Exemplar ON (Exemplar.Id_livro = Livro.Id)
                                WHERE Livro.Id = '"+id+"'"+
                                "GROUP BY Livro.Id, Livro.Titulo, Editora.Nome_Editora, Autor.Nome_Autor, Genero.Nome_Genero, Livro.Id_genero, Livro.Id_autor, Livro.Id_editora, Livro.Estado";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            while (reader.Read()) {
                LivroModel livro = new LivroModel(
                    (int)reader["Id"],
                    (String)reader["Titulo"],
                    (String)reader["Nome_Editora"],
                    (String)reader["Nome_Autor"],
                    (String)reader["Nome_Genero"],
                    (int)reader["Quantidade"], 
                    (int)reader["Id_editora"], 
                    (int)reader["Id_autor"], 
                    (int)reader["Id_genero"],
                    (int)reader["Estado"]
                );
                reader.Close();

                return livro;
            }
            return null;
        }

        public List<LivroModel> Buscar(string busca, bool isNome = false, bool isAutor = false, bool isEditora = false, bool isGenero = false, string status = "Ambos") {
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
                    Cmd.CommandText = @"SELECT	Livro.Id,
		                                Livro.Titulo,
		                                Editora.Nome_Editora,
		                                Autor.Nome_Autor,
		                                Genero.Nome_Genero,
					                    COUNT(Exemplar.Id_livro) as Quantidade,
										Livro.Estado
                                    FROM Livro
                                    INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                    INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                    INNER JOIN Genero ON (Genero.Id = Livro.Id_Genero)
                                    LEFT JOIN Exemplar ON (Exemplar.Id_livro = Livro.Id)
                                    WHERE Livro.Titulo LIKE '%" + busca + "%'" +
                                        "GROUP BY Livro.Id, Livro.Titulo, Editora.Nome_Editora, Autor.Nome_Autor, Genero.Nome_Genero, Livro.Estado";
                }

                if (isAutor)
                {
                    Cmd.CommandText = @"SELECT	Livro.Id,
		                                    Livro.Titulo,
		                                    Editora.Nome_Editora,
		                                    Autor.Nome_Autor,
		                                    Genero.Nome_Genero,
					                        COUNT(Exemplar.Id_livro) as Quantidade,
										    Livro.Estado
                                        FROM Livro
                                        INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                        INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                        INNER JOIN Genero ON (Genero.Id = Livro.Id_Genero)
                                        LEFT JOIN Exemplar ON (Exemplar.Id_livro = Livro.Id)
                                        WHERE Autor.Nome_Autor LIKE '%" + busca + "%'" +
                                        "GROUP BY Livro.Id, Livro.Titulo, Editora.Nome_Editora, Autor.Nome_Autor, Genero.Nome_Genero, Livro.Estado";
                }

                if (isEditora)
                {
                    Cmd.CommandText =
                    Cmd.CommandText = @"SELECT	Livro.Id,
		                                    Livro.Titulo,
		                                    Editora.Nome_Editora,
		                                    Autor.Nome_Autor,
		                                    Genero.Nome_Genero,
					                        COUNT(Exemplar.Id_livro) as Quantidade,
										    Livro.Estado
                                        FROM Livro
                                        INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                        INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                        INNER JOIN Genero ON (Genero.Id = Livro.Id_Genero)
                                        LEFT JOIN Exemplar ON (Exemplar.Id_livro = Livro.Id)
                                        WHERE Editora.Nome_Editora LIKE '%" + busca + "%'" +
                                        "GROUP BY Livro.Id, Livro.Titulo, Editora.Nome_Editora, Autor.Nome_Autor, Genero.Nome_Genero, Livro.Estado";
                }
                if (isGenero)
                {
                    Cmd.CommandText =
                    Cmd.CommandText = @"SELECT	Livro.Id,
		                                    Livro.Titulo,
		                                    Editora.Nome_Editora,
		                                    Autor.Nome_Autor,
		                                    Genero.Nome_Genero,
					                        COUNT(Exemplar.Id_livro) as Quantidade,
										    Livro.Estado
                                        FROM Livro
                                        INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                        INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                        INNER JOIN Genero ON (Genero.Id = Livro.Id_Genero)
                                        LEFT JOIN Exemplar ON (Exemplar.Id_livro = Livro.Id)
                                        WHERE Genero.Nome_Genero LIKE '%" + busca + "%'" +
                                        "GROUP BY Livro.Id, Livro.Titulo, Editora.Nome_Editora, Autor.Nome_Autor, Genero.Nome_Genero, Livro.Estado";


                }
            }
            else
            {
                if (isNome)
                {
                    Cmd.CommandText = @"SELECT	Livro.Id,
		                                Livro.Titulo,
		                                Editora.Nome_Editora,
		                                Autor.Nome_Autor,
		                                Genero.Nome_Genero,
					                    COUNT(Exemplar.Id_livro) as Quantidade,
										Livro.Estado
                                    FROM Livro
                                    INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                    INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                    INNER JOIN Genero ON (Genero.Id = Livro.Id_Genero)
                                    LEFT JOIN Exemplar ON (Exemplar.Id_livro = Livro.Id)
                                    WHERE Livro.Estado = '"+ statusNumero + "' AND Livro.Titulo LIKE '%" + busca + "%'" +
                                    "GROUP BY Livro.Id, Livro.Titulo, Editora.Nome_Editora, Autor.Nome_Autor, Genero.Nome_Genero, Livro.Estado";
                }

                if (isAutor)
                {
                    Cmd.CommandText = @"SELECT	Livro.Id,
		                                    Livro.Titulo,
		                                    Editora.Nome_Editora,
		                                    Autor.Nome_Autor,
		                                    Genero.Nome_Genero,
					                        COUNT(Exemplar.Id_livro) as Quantidade,
										    Livro.Estado
                                        FROM Livro
                                        INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                        INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                        INNER JOIN Genero ON (Genero.Id = Livro.Id_Genero)
                                        LEFT JOIN Exemplar ON (Exemplar.Id_livro = Livro.Id)
                                        WHERE Livro.Estado = '" + statusNumero + "' AND Autor.Nome_Autor LIKE '%" + busca + "%'" +
                                        "GROUP BY Livro.Id, Livro.Titulo, Editora.Nome_Editora, Autor.Nome_Autor, Genero.Nome_Genero, Livro.Estado";
                }

                if (isEditora)
                {
                    Cmd.CommandText =
                    Cmd.CommandText = @"SELECT	Livro.Id,
		                                    Livro.Titulo,
		                                    Editora.Nome_Editora,
		                                    Autor.Nome_Autor,
		                                    Genero.Nome_Genero,
					                        COUNT(Exemplar.Id_livro) as Quantidade,
										    Livro.Estado
                                        FROM Livro
                                        INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                        INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                        INNER JOIN Genero ON (Genero.Id = Livro.Id_Genero)
                                        LEFT JOIN Exemplar ON (Exemplar.Id_livro = Livro.Id)
                                        WHERE Livro.Estado = '" + statusNumero + "' AND Editora.Nome_Editora LIKE '%" + busca + "%'" +
                                        "GROUP BY Livro.Id, Livro.Titulo, Editora.Nome_Editora, Autor.Nome_Autor, Genero.Nome_Genero, Livro.Estado";
                }
                if (isGenero)
                {
                    Cmd.CommandText =
                    Cmd.CommandText = @"SELECT	Livro.Id,
		                                    Livro.Titulo,
		                                    Editora.Nome_Editora,
		                                    Autor.Nome_Autor,
		                                    Genero.Nome_Genero,
					                        COUNT(Exemplar.Id_livro) as Quantidade,
										    Livro.Estado
                                        FROM Livro
                                        INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                        INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                        INNER JOIN Genero ON (Genero.Id = Livro.Id_Genero)
                                        LEFT JOIN Exemplar ON (Exemplar.Id_livro = Livro.Id)
                                        WHERE Livro.Estado = '" + statusNumero + "' AND Genero.Nome_Genero LIKE '%" + busca + "%'" +
                                        "GROUP BY Livro.Id, Livro.Titulo, Editora.Nome_Editora, Autor.Nome_Autor, Genero.Nome_Genero, Livro.Estado";


                }
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
                    (int)reader["Quantidade"],
                    (int)reader["Estado"]

                );
                lista.Add(livro);
            }
            reader.Close();

            return lista;
        }

        public List<LivroModel> Relatorio(DateTime inicio, DateTime fim) {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"SELECT L.*, F.Nome_fornecedor AS 'Editora', IE.ID_emprestimo AS 'Emprestimo'
                                FROM Livro AS L
                                INNER JOIN Editora AS F ON (F.ID_fornecedor = L.ID_fornecedor)
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

            //while (reader.Read()) {
            //    LivroModel livro = new LivroModel(
            //        (int)reader["Id"],
            //        (String)reader["Titulo"]
            //        /*(int)reader["Quantidade"]*/,
            //        (String)reader["Nome_Editora"],
            //        (String)reader["Nome_Autor"],
            //        (String)reader["Nome_Genero"]
            //    );
            //    livro.IdEmprestimo = (int)reader["Emprestimo"];
            //    lista.Add(livro);
            //}
            reader.Close();

            return lista;
        }
    }
}
