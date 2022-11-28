using Biblioteca.Model;
using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;

namespace Biblioteca.Controller
{
    internal class ExemplarController
    {
        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set; }

        public ExemplarController()
        {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }

        public bool Insercao(ExemplarModel exemplar)
        {
            try
            {
                for (int i = 0; i < exemplar.Quantidade; i++)
                {
                    Cmd.Connection = connection.RetornaConexao();
                    Cmd.CommandText = @"INSERT INTO Exemplar Values (@Data_Aquisição, @Id_livro, @Ano, @ISBN, @Id_Edicao,@Estado, @Valor)";

                    Cmd.Parameters.Clear();
                    Cmd.Parameters.AddWithValue("@Data_Aquisição", exemplar.Aquisicao.ToString("yyyy-MM-dd"));
                    Cmd.Parameters.AddWithValue("@Id_livro", exemplar.IdLivro);
                    Cmd.Parameters.AddWithValue("@Ano", exemplar.AnoPublicacao);
                    Cmd.Parameters.AddWithValue("@ISBN", exemplar.ISBN);
                    Cmd.Parameters.AddWithValue("@Id_Edicao", exemplar.IdEdicao);
                    Cmd.Parameters.AddWithValue("@Valor", Math.Round(exemplar.Valor, 2));
                    Cmd.Parameters.AddWithValue("@Estado", 1);
                    Cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool Atualizar(ExemplarModel exemplar)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Exemplar SET Data_Aquisicao = @Aquisicao, Ano = @Ano, ISBN = @ISBN, Id_Edicao = @Id_Edicao, Estado = @Estado, Valor = @Valor
                                WHERE Id = @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", exemplar.getId());
            Cmd.Parameters.AddWithValue("@Aquisicao", exemplar.Aquisicao);
            Cmd.Parameters.AddWithValue("@Ano", exemplar.AnoPublicacao);
            Cmd.Parameters.AddWithValue("@ISBN", exemplar.ISBN);
            Cmd.Parameters.AddWithValue("@Id_Edicao", exemplar.IdEdicao);
            Cmd.Parameters.AddWithValue("@Estado", exemplar.Estado);
            Cmd.Parameters.AddWithValue("@Valor", exemplar.Valor);



            if (Cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<ExemplarModel> Buscar(string busca, bool isCodigo = false, bool isNome = false, bool isAutor = false, bool isEditora = false, bool isGenero = false, string status = "Ambos")
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
                    Cmd.CommandText = @"SELECT	Exemplar.Id,
		                                        Livro.Titulo,
		                                        Autor.Nome_Autor,
		                                        Edicao.Nome_Edicao,
		                                        Editora.Nome_Editora,
		                                        Genero.Nome_Genero,
		                                        Exemplar.Data_Aquisicao,
		                                        Exemplar.ISBN,
		                                        Exemplar.Ano,
		                                        Exemplar.Valor,
		                                        Exemplar.Estado
                                        From Exemplar
                                        INNER JOIN Livro ON (Livro.Id = Exemplar.Id_livro)
                                        INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                        INNER JOIN Edicao ON (Edicao.Id = Exemplar.Id_Edicao)
                                        INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                        INNER JOIN Genero ON (Genero.Id = Livro.Id_genero)
                                        WHERE Livro.Titulo LIKE '%" + busca + "%'";
                }

                if (isAutor)
                {
                    Cmd.CommandText = @"SELECT	Exemplar.Id,
		                                        Livro.Titulo,
		                                        Autor.Nome_Autor,
		                                        Edicao.Nome_Edicao,
		                                        Editora.Nome_Editora,
		                                        Genero.Nome_Genero,
		                                        Exemplar.Data_Aquisicao,
		                                        Exemplar.ISBN,
		                                        Exemplar.Ano,
		                                        Exemplar.Valor,
		                                        Exemplar.Estado
                                        From Exemplar
                                        INNER JOIN Livro ON (Livro.Id = Exemplar.Id_livro)
                                        INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                        INNER JOIN Edicao ON (Edicao.Id = Exemplar.Id_Edicao)
                                        INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                        INNER JOIN Genero ON (Genero.Id = Livro.Id_genero)
                                        WHERE Autor.Nome_Autor LIKE '%" + busca + "%'";
                }

                if (isEditora)
                {
                    Cmd.CommandText =
                    Cmd.CommandText = @"SELECT	Exemplar.Id,
		                                        Livro.Titulo,
		                                        Autor.Nome_Autor,
		                                        Edicao.Nome_Edicao,
		                                        Editora.Nome_Editora,
		                                        Genero.Nome_Genero,
		                                        Exemplar.Data_Aquisicao,
		                                        Exemplar.ISBN,
		                                        Exemplar.Ano,
		                                        Exemplar.Valor,
		                                        Exemplar.Estado
                                        From Exemplar
                                        INNER JOIN Livro ON (Livro.Id = Exemplar.Id_livro)
                                        INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                        INNER JOIN Edicao ON (Edicao.Id = Exemplar.Id_Edicao)
                                        INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                        INNER JOIN Genero ON (Genero.Id = Livro.Id_genero)
                                        WHERE Editora.Nome_Editora LIKE '%" + busca + "%'";
                }
                if (isGenero)
                {
                    Cmd.CommandText =
                    Cmd.CommandText = @"SELECT	Exemplar.Id,
		                                        Livro.Titulo,
		                                        Autor.Nome_Autor,
		                                        Edicao.Nome_Edicao,
		                                        Editora.Nome_Editora,
		                                        Genero.Nome_Genero,
		                                        Exemplar.Data_Aquisicao,
		                                        Exemplar.ISBN,
		                                        Exemplar.Ano,
		                                        Exemplar.Valor,
		                                        Exemplar.Estado
                                        From Exemplar
                                        INNER JOIN Livro ON (Livro.Id = Exemplar.Id_livro)
                                        INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                        INNER JOIN Edicao ON (Edicao.Id = Exemplar.Id_Edicao)
                                        INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                        INNER JOIN Genero ON (Genero.Id = Livro.Id_genero)
                                        WHERE Genero.Nome_Genero LIKE '%" + busca + "%'";


                }
                if (isCodigo)
                {
                    Cmd.CommandText =
                    Cmd.CommandText = @"SELECT	Exemplar.Id,
		                                        Livro.Titulo,
		                                        Autor.Nome_Autor,
		                                        Edicao.Nome_Edicao,
		                                        Editora.Nome_Editora,
		                                        Genero.Nome_Genero,
		                                        Exemplar.Data_Aquisicao,
		                                        Exemplar.ISBN,
		                                        Exemplar.Ano,
		                                        Exemplar.Valor,
		                                        Exemplar.Estado
                                        From Exemplar
                                        INNER JOIN Livro ON (Livro.Id = Exemplar.Id_livro)
                                        INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                        INNER JOIN Edicao ON (Edicao.Id = Exemplar.Id_Edicao)
                                        INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                        INNER JOIN Genero ON (Genero.Id = Livro.Id_genero)
                                        WHERE Exemplar.Id LIKE '%" + busca + "%'";
                }
            }
            else
            {
                if (isNome)
                {
                    Cmd.CommandText = @"SELECT	Exemplar.Id,
		                                        Livro.Titulo,
		                                        Autor.Nome_Autor,
		                                        Edicao.Nome_Edicao,
		                                        Editora.Nome_Editora,
		                                        Genero.Nome_Genero,
		                                        Exemplar.Data_Aquisicao,
		                                        Exemplar.ISBN,
		                                        Exemplar.Ano,
		                                        Exemplar.Valor,
		                                        Exemplar.Estado
                                        From Exemplar
                                        INNER JOIN Livro ON (Livro.Id = Exemplar.Id_livro)
                                        INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                        INNER JOIN Edicao ON (Edicao.Id = Exemplar.Id_Edicao)
                                        INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                        INNER JOIN Genero ON (Genero.Id = Livro.Id_genero)
                                        WHERE Exemplar.Estado = '" + statusNumero + "' AND Livro.Titulo LIKE '%" + busca + "%'";
                }

                if (isAutor)
                {
                    Cmd.CommandText = @"SELECT	Exemplar.Id,
		                                        Livro.Titulo,
		                                        Autor.Nome_Autor,
		                                        Edicao.Nome_Edicao,
		                                        Editora.Nome_Editora,
		                                        Genero.Nome_Genero,
		                                        Exemplar.Data_Aquisicao,
		                                        Exemplar.ISBN,
		                                        Exemplar.Ano,
		                                        Exemplar.Valor,
		                                        Exemplar.Estado
                                        From Exemplar
                                        INNER JOIN Livro ON (Livro.Id = Exemplar.Id_livro)
                                        INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                        INNER JOIN Edicao ON (Edicao.Id = Exemplar.Id_Edicao)
                                        INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                        INNER JOIN Genero ON (Genero.Id = Livro.Id_genero)
                                        WHERE Exemplar.Estado = '" + statusNumero + "' AND Autor.Nome_Autor LIKE '%" + busca + "%'";
                }

                if (isEditora)
                {
                    Cmd.CommandText =
                    Cmd.CommandText = @"SELECT	Exemplar.Id,
		                                        Livro.Titulo,
		                                        Autor.Nome_Autor,
		                                        Edicao.Nome_Edicao,
		                                        Editora.Nome_Editora,
		                                        Genero.Nome_Genero,
		                                        Exemplar.Data_Aquisicao,
		                                        Exemplar.ISBN,
		                                        Exemplar.Ano,
		                                        Exemplar.Valor,
		                                        Exemplar.Estado
                                        From Exemplar
                                        INNER JOIN Livro ON (Livro.Id = Exemplar.Id_livro)
                                        INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                        INNER JOIN Edicao ON (Edicao.Id = Exemplar.Id_Edicao)
                                        INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                        INNER JOIN Genero ON (Genero.Id = Livro.Id_genero)
                                        WHERE Exemplar.Estado = '" + statusNumero + "' AND Editora.Nome_Editora LIKE '%" + busca + "%'";
                }
                if (isGenero)
                {
                    Cmd.CommandText =
                    Cmd.CommandText = @"SELECT	Exemplar.Id,
		                                        Livro.Titulo,
		                                        Autor.Nome_Autor,
		                                        Edicao.Nome_Edicao,
		                                        Editora.Nome_Editora,
		                                        Genero.Nome_Genero,
		                                        Exemplar.Data_Aquisicao,
		                                        Exemplar.ISBN,
		                                        Exemplar.Ano,
		                                        Exemplar.Valor,
		                                        Exemplar.Estado
                                        From Exemplar
                                        INNER JOIN Livro ON (Livro.Id = Exemplar.Id_livro)
                                        INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                        INNER JOIN Edicao ON (Edicao.Id = Exemplar.Id_Edicao)
                                        INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                        INNER JOIN Genero ON (Genero.Id = Livro.Id_genero)
                                        WHERE Exemplar.Estado = '" + statusNumero + "' AND Genero.Nome_Genero LIKE '%" + busca + "%'";


                }
                if (isCodigo)
                {
                    Cmd.CommandText =
                    Cmd.CommandText = @"SELECT	Exemplar.Id,
		                                        Livro.Titulo,
		                                        Autor.Nome_Autor,
		                                        Edicao.Nome_Edicao,
		                                        Editora.Nome_Editora,
		                                        Genero.Nome_Genero,
		                                        Exemplar.Data_Aquisicao,
		                                        Exemplar.ISBN,
		                                        Exemplar.Ano,
		                                        Exemplar.Valor,
		                                        Exemplar.Estado
                                        From Exemplar
                                        INNER JOIN Livro ON (Livro.Id = Exemplar.Id_livro)
                                        INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                        INNER JOIN Edicao ON (Edicao.Id = Exemplar.Id_Edicao)
                                        INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                        INNER JOIN Genero ON (Genero.Id = Livro.Id_genero)
                                        WHERE Exemplar.Estado = '" + statusNumero + "' AND Exemplar.Id LIKE '%" + busca + "%'";
                }
            }
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<ExemplarModel> lista = new List<ExemplarModel>();

            while (reader.Read())
            {
                string valorString = Convert.ToString(reader["Valor"]);
                valorString.Replace(",", ".");
                float valor = float.Parse(valorString);
                ExemplarModel exemplar = new ExemplarModel(
                    (int)reader["Id"],
                    (string)reader["Titulo"],
                    (string)reader["Nome_Edicao"],
                    (DateTime)reader["Data_Aquisicao"],
                    (string)reader["Ano"],
                    (string)reader["ISBN"],
                    (string)reader["Nome_Editora"],
                    (string)reader["Nome_Autor"],
                    (string)reader["Nome_Genero"],
                    valor,
                    (int)reader["Estado"]

                );
                lista.Add(exemplar);
            }
            reader.Close();

            return lista;
        }

        public ExemplarModel BuscarExemplarId(int id)
        {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"SELECT	Exemplar.Id,
		                                Livro.Titulo,
		                                Autor.Nome_Autor,
		                                Edicao.Nome_Edicao,
                                        Edicao.Id AS Edicao_Id,
		                                Editora.Nome_Editora,
		                                Genero.Nome_Genero,
		                                Exemplar.Data_Aquisicao,
		                                Exemplar.ISBN,
		                                Exemplar.Ano,
		                                Exemplar.Valor,
		                                Exemplar.Estado
                                From Exemplar
                                INNER JOIN Livro ON (Livro.Id = Exemplar.Id_livro)
                                INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                INNER JOIN Edicao ON (Edicao.Id = Exemplar.Id_Edicao)
                                INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                INNER JOIN Genero ON (Genero.Id = Livro.Id_genero)
                                WHERE Exemplar.Id = '" + id + "'";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            ExemplarModel exemplar = null;

            while (reader.Read())
            {
                string valorString = Convert.ToString(reader["Valor"]);
                valorString.Replace(",", ".");
                float valor = float.Parse(valorString);
                exemplar = new ExemplarModel(
                    (int)reader["Id"],
                    (string)reader["Titulo"],
                    (string)reader["Nome_Edicao"],
                    (DateTime)reader["Data_Aquisicao"],
                    (string)reader["Ano"],
                    (string)reader["ISBN"],
                    (string)reader["Nome_Editora"],
                    (string)reader["Nome_Autor"],
                    (string)reader["Nome_Genero"],
                    valor,
                    (int)reader["Estado"]);
                    exemplar.IdEdicao = (int)reader["Edicao_Id"];
            }
            reader.Close();

            return exemplar;
        }

    }
}
