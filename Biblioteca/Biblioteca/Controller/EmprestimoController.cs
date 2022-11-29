using Biblioteca.Util;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Biblioteca.Model;
using System.Globalization;
using System.Collections.Generic;

namespace Biblioteca.Controller
{
    class EmprestimoController
    {

        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set; }

        Singleton singleton = Singleton.GetInstancia();

        public EmprestimoController()
        {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }

        // CADASTRAR NOVO EMPRESTIMO
        public bool Insercao(DateTime dataEmprestimo, DateTime dataDevolucao, String obs)
        {
            try
            {
                Cmd.Connection = connection.RetornaConexao();

                Cmd.CommandText = @"INSERT INTO Emprestimo Values (@Emprestimo, @Devolucao, @Obs, @Leitor, @Funcionario, @Status, @Finalizado)";

                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Emprestimo", dataEmprestimo.ToString("yyyy-MM-dd"));
                Cmd.Parameters.AddWithValue("@Devolucao", dataDevolucao.ToString("yyyy-MM-dd"));
                Cmd.Parameters.AddWithValue("@Obs", obs);
                Cmd.Parameters.AddWithValue("@Leitor", this.singleton.getLeitor().getId());
                Cmd.Parameters.AddWithValue("@Funcionario", this.singleton.getFuncionario().getId());
                Cmd.Parameters.AddWithValue("@Status", 1);
                Cmd.Parameters.AddWithValue("@Finalizado", DBNull.Value);

                if (Cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }

        }

        // BUSCAR ÚLTIMO EMPRESTIMO CADASTRADO PARA PODER PEGAR O ID DO MESMO
        public int BuscarUltimoEmprestimo()
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Emprestimo ORDER BY Id DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();
            int idEmprestimo = 0;

            while (reader.Read())
            {
                idEmprestimo = (int)reader["Id"];
            }
            reader.Close();
            return idEmprestimo;
        }

        // RELACIONAR EXEMPLARES SELECIONADO NO EMPRESTIMO
        public bool RelacionarLivrosEmprestimo(int idEmprestimo, ExemplarModel exemplar)
        {
            Cmd.Connection = connection.RetornaConexao();

            if (Cmd.Connection.State != System.Data.ConnectionState.Open)
                Cmd.Connection.Open();

            Cmd.CommandText = @"INSERT INTO Item_emprestimo Values (@Exemplar, @Emprestimo, @Status)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Exemplar", exemplar.getId());
            Cmd.Parameters.AddWithValue("@Emprestimo", idEmprestimo);
            Cmd.Parameters.AddWithValue("@Status", 7);

            if (Cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<EmprestimoModel> ListarTodos()
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"
            SELECT E.*, F.Nome_Funcionario AS 'Funcionario', L.Nome_Leitor AS 'Leitor'
            FROM Emprestimo as E
            INNER JOIN Funcionario AS F ON (F.ID_funcionario = E.ID_funcionario)
            INNER JOIN Leitor as L ON (L.ID_leitor = E.ID_leitor)
            ";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EmprestimoModel> lista = new List<EmprestimoModel>();

            while (reader.Read())
            {
                EmprestimoModel leitor = new EmprestimoModel(
                    (int)reader["ID_emprestimo"],
                    (int)reader["ID_funcionario"],
                    (int)reader["ID_leitor"],
                    (DateTime)reader["Data_devolucao"],
                    (DateTime)reader["Data_emprestimo"],
                    (String)reader["Leitor"],
                    (String)reader["Funcionario"],
                    (String)reader["Status"]
                );
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

        public List<EmprestimoModel> ListarEmprestimo(int id)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"
            SELECT E.*, F.Nome_Funcionario AS 'Funcionario', L.Nome_Leitor AS 'Leitor', SE.Nome_Status AS 'Status'
            FROM Emprestimo as E
            INNER JOIN Funcionario AS F ON (F.Id = E.Id_funcionario)
            INNER JOIN Leitor as L ON (L.Id = E.Id_leitor)
			INNER JOIN Status_Emprestimo AS SE ON (SE.Id = E.Id_emprestimoStatus)
            WHERE E.Id = '" + id + "'";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EmprestimoModel> lista = new List<EmprestimoModel>();

            while (reader.Read())
            {
                EmprestimoModel leitor = new EmprestimoModel(
                    (int)reader["Id"],
                    (int)reader["Id_funcionario"],
                    (int)reader["Id_leitor"],
                    (DateTime)reader["Data_Devolucao"],
                    (DateTime)reader["Data_Emprestimo"],
                    (String)reader["Leitor"],
                    (String)reader["Funcionario"],
                    (String)reader["Status"]
                );
                leitor.Obs = (String)reader["Obs_emprestimo"];
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

        private int quantidadeDisponiveis(int idLivro, int quantidade)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT COUNT(E.ID_emprestimo) AS Emprestimos
            FROM Item_livro AS IL
            INNER JOIN Item_emprestimo AS IE ON (IE.ID_IL= IL.ID_IL)
            INNER JOIN Emprestimo AS E ON (E.ID_emprestimo = IE.ID_emprestimo)
			inner join Livro as L ON (IL.ID_livro = L.ID_livro)
            WHERE E.Status='EMPRESTADO' AND L.ID_livro = '" + idLivro + "'";

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            int emprestimos = 0;

            while (reader.Read())
            {
                emprestimos = (int)reader["Emprestimos"];
            }
            reader.Close();
            return quantidade - emprestimos;
        }

        public List<LivroModel> ListarTodosLivros()
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"
            SELECT	Livro. *,
		            Editora.Nome_Editora,
		            Autor.Nome_Autor,
		            Genero.Nome_Genero
            FROM Livro
            INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
            INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
            INNER JOIN Genero ON (Genero.Id = Livro.Id_Genero)
            WHERE Livro.Estado = 1 AND EXISTS (SELECT * FROM Exemplar WHERE Livro.id = Exemplar.Id_livro)
            ";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LivroModel> lista = new List<LivroModel>();

            while (reader.Read())
            {
                LivroModel livro = new LivroModel(
                    (int)reader["Id"],
                    (String)reader["Titulo"],
                    (String)reader["Nome_Editora"],
                    (String)reader["Nome_Autor"],
                    (String)reader["Nome_genero"]
                );
                lista.Add(livro);
            }
            reader.Close();

            /*for (int i = 0; i < lista.Count; i++)
            {
                int disponiveis = quantidadeDisponiveis(lista[i].getId(), lista[i].Quantidade);
                lista[i].Disponiveis = disponiveis;
            }*/

            return lista;
        }
        public List<ExemplarModel> ListarTodosExemplares(int idLivro) //string busca, 
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT	Exemplar.Id,
                                    L.Titulo AS Nome,
		                            A.Nome_Autor AS Autor,
		                            E.Nome_Edicao AS Edicao,
		                            Exemplar.Ano AS AnoPublicacao,
		                            Exemplar.ISBN,
		                            F.Nome_Editora AS Editora
                                From Exemplar
                                INNER JOIN Livro AS L ON (Exemplar.Id_livro = L.Id) 
								INNER JOIN Autor AS A ON (A.Id = L.Id_autor) 
								INNER JOIN Edicao AS E ON (E.Id = Exemplar.Id_Edicao) 
                                INNER JOIN Editora AS F ON (F.Id = L.Id_editora)
                                WHERE Exemplar.estado = 1 AND Exemplar.ID_livro = '" + idLivro + "' AND " +
                                "Exemplar.Id NOT IN ( " +
                                    "SELECT Item_reserva.Id_exemplar " +
                                    "FROM Reserva " +
                                    "INNER JOIN Item_reserva ON(Item_reserva.Id_reserva = Reserva.Id) " +
                                    "WHERE Reserva.Id_reservaStatus = 1) AND " +
                                "Exemplar.Id NOT IN (" +
                                    "SELECT Item_Emprestimo.Id_exemplar " +
                                    "FROM Emprestimo " +
                                    "INNER JOIN Item_Emprestimo ON(Item_Emprestimo.Id_emprestimo = Emprestimo.Id)" +
                                    "WHERE(Emprestimo.Id_emprestimoStatus = 1 OR Emprestimo.Id_emprestimoStatus = 2) AND" +
                                    "(Item_Emprestimo.Id_Status = 6 OR Item_Emprestimo.Id_Status = 7)" +
                                ") ORDER BY Exemplar.Id ASC";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<ExemplarModel> lista = new List<ExemplarModel>();

            while (reader.Read())
            {
                ExemplarModel exemplar = new ExemplarModel(
                    (int)reader["ID"],
                    (String)reader["Nome"],
                    (String)reader["Autor"],
                    (String)reader["Edicao"],
                    (String)reader["AnoPublicacao"],
                    (String)reader["ISBN"],
                    (String)reader["Editora"]
                );
                lista.Add(exemplar);
            }
            reader.Close();

            return lista;
        }

        public List<ExemplarModel> ListarTodosLivrosEmprestimo(int id)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT	IL.Id AS ID,
                                L.Titulo AS Nome,
	                            Autor.Nome_Autor AS Autor,
	                            Edicao.Nome_Edicao AS Edicao,
	                            IL.Ano AS AnoPublicacao,
	                            IL.ISBN,
	                            F.Nome_Editora AS Editora
                            From Exemplar AS IL
                            INNER JOIN Livro AS L ON (IL.Id_livro = L.Id) 
                            INNER JOIN Editora AS F ON (F.Id = L.Id_editora)
                            INNER JOIN Item_Emprestimo AS IE ON (IE.Id_exemplar = IL.Id)
                            INNER JOIN Emprestimo AS E ON (E.Id = IE.Id_emprestimo)
							INNER JOIN Autor ON (Autor.Id = L.Id_autor)
							INNER JOIN Edicao ON (Edicao.Id = IL.Id_Edicao)
                            WHERE E.id = '" + id + "'";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<ExemplarModel> lista = new List<ExemplarModel>();

            while (reader.Read())
            {
                ExemplarModel exemplar = new ExemplarModel(
                    (int)reader["ID"],
                    (String)reader["Nome"],
                    (String)reader["Autor"],
                    (String)reader["Edicao"],
                    (String)reader["AnoPublicacao"],
                    (String)reader["ISBN"],
                    (String)reader["Editora"]
                );
                lista.Add(exemplar);
            }
            reader.Close();

            return lista;
        }

        public List<LivroModel> BuscarLivros(string busca)
        {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"SELECT	Livro.Id,
		                                Livro.Titulo,
		                                Editora.Nome_Editora,
		                                Autor.Nome_Autor,
		                                Genero.Nome_Genero,
		                                COUNT(Exemplar.Id) AS Disponivel
                                FROM Livro
                                INNER JOIN Editora ON (Editora.Id = Livro.Id_editora)
                                INNER JOIN Autor ON (Autor.Id = Livro.Id_autor)
                                INNER JOIN Genero ON (Genero.Id = Livro.Id_Genero)
                                INNER JOIN Exemplar ON (Exemplar.Id_livro = Livro.Id)
                                WHERE Livro.Titulo LIKE '%" + busca + "%' AND Livro.Estado = 1 AND " +
                                "EXISTS(SELECT* FROM Exemplar WHERE Livro.id = Exemplar.Id_livro) AND " +
                                "Exemplar.Id NOT IN (" +
                                    "SELECT Item_Emprestimo.Id_exemplar " +
                                    "FROM Emprestimo " +
                                    "INNER JOIN Item_Emprestimo ON (Item_Emprestimo.Id_emprestimo = Emprestimo.Id) " +
                                    "WHERE (Emprestimo.Id_emprestimoStatus = 1 OR Emprestimo.Id_emprestimoStatus = 2) AND " +
                                    "(Item_Emprestimo.Id_Status = 6 OR Item_Emprestimo.Id_Status = 7)) AND " +
                                "Exemplar.Id NOT IN ( " +
                                    "SELECT Item_reserva.Id_exemplar " +
                                    "FROM Reserva " +
                                    "INNER JOIN Item_reserva ON(Item_reserva.Id_reserva = Reserva.Id) " +
                                    "WHERE Reserva.Id_reservaStatus = 1)" +
                                "GROUP BY Livro.Id, Livro.Titulo, Editora.Nome_Editora, Autor.Nome_Autor, Genero.Nome_Genero";



            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LivroModel> lista = new List<LivroModel>();

            while (reader.Read())
            {
                LivroModel livro = new LivroModel(
                    (int)reader["Id"],
                    (String)reader["Titulo"],
                    (String)reader["Nome_Editora"],
                    (String)reader["Nome_Autor"],
                    (String)reader["Nome_Genero"]
                );
                livro.Disponiveis = (int)reader["Disponivel"];
                lista.Add(livro);
            }
            reader.Close();

            return lista;
        }

        public int QuantidadeDeExemplar()
        {
            return this.singleton.getExemplar().Count;
        }

        public bool InserirExemplarEmprestimo(ExemplarModel exemplar)
        {
            bool inseriu = false;
            List<ExemplarModel> exemplares = this.singleton.getExemplar();
            for (int i = 0; i < exemplares.Count; i++)
            {
                if (exemplares[i].getId() == exemplar.getId())
                {
                    inseriu = true;
                    break;
                }
            }
            if (inseriu)
            {
                return false;
            }
            else
            {
                this.singleton.setExemplar(exemplar);
                this.singleton.setAddExemplar(true);
                return true;
            }
        }

        public List<ExemplarModel> PegarExemplarEmprestimo()
        {
            return this.singleton.getExemplar();
        }

        public void RemoverExemplarEmprestimo(ExemplarModel exemplar)
        {
            this.singleton.removerExemplarLista(exemplar);
        }

        public void InserirLeitorEmprestimo(LeitorModel leitor)
        {
            this.singleton.setLeitor(leitor);
        }

        public void RemoverLeitorEmprestimo()
        {
            this.singleton.setLeitor(null);
        }

        public LeitorModel PegarLeitorEmprestimo()
        {
            return this.singleton.getLeitor();
        }

        public List<LeitorModel> ListarTodosLeitores()
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Leitor Where Estado = 1";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LeitorModel> lista = new List<LeitorModel>();

            while (reader.Read())
            {
                LeitorModel leitor = new LeitorModel(
                    (int)reader["Id"],
                    (String)reader["Nome_Leitor"],
                    (DateTime)reader["Data_Nascimento"],
                    (String)reader["Telefone"],
                    (String)reader["CPF"],
                    (String)reader["Endereco"],
                    (String)reader["Email"]
                );
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

        public List<LeitorModel> BuscarLeitor(string busca)
        {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"SELECT * FROM LEITOR WHERE Nome_Leitor LIKE '" + busca + "%'";

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LeitorModel> lista = new List<LeitorModel>();

            while (reader.Read())
            {
                LeitorModel leitor = new LeitorModel(
                    (int)reader["ID_leitor"],
                    (String)reader["Nome_Leitor"],
                    (DateTime)reader["Data_Nascimento"],
                    (String)reader["Telefone"],
                    (String)reader["CPF"],
                    (String)reader["Endereco"],
                    (String)reader["Email"]
                );
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }
        public List<LeitorModel> BuscarLeitor(string busca, bool isNome = false, bool isCPF = false)
        {
            Cmd.Connection = connection.RetornaConexao();


            if (isNome)
            {
                Cmd.CommandText = @"SELECT * FROM LEITOR WHERE estado = 1 AND Nome_Leitor LIKE '%" + busca + "%'";
            }

            if (isCPF)
            {
                Cmd.CommandText = @"SELECT * FROM LEITOR WHERE estado = 1 AND CPF LIKE '%" + busca + "%'";
            }


            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LeitorModel> lista = new List<LeitorModel>();

            while (reader.Read())
            {
                LeitorModel leitor = new LeitorModel(
                    (int)reader["Id"],
                    (String)reader["Nome_Leitor"],
                    (DateTime)reader["Data_Nascimento"],
                    (String)reader["Telefone"],
                    (String)reader["CPF"],
                    (String)reader["Endereco"],
                    (String)reader["Email"]
                );
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }
        public List<EmprestimoPesquisaExemplarModel> BuscarExemplar(string busca, DateTime dataInicial, DateTime dataFinal, String statusEmprestimo, String statusExemplar, bool isCodigo = false, bool isExemplar = false, bool isISBN = false)
        {
            Cmd.Connection = connection.RetornaConexao();

            int statusExemplarCod = 0;
            switch (statusExemplar)
            {
                case "Devolvido":
                    statusExemplarCod = 5;
                    break;
                case "Extraviado":
                    statusExemplarCod = 6;
                    break;
                case "Emprestado":
                    statusExemplarCod = 7;
                    break;
            }

            if (isCodigo)
            {
                if (statusEmprestimo == "Todos" && statusExemplar == "Todos")
                {
                    Cmd.CommandText = @"SELECT E.Id, SE.Nome_Status AS Status_Emprestimo, Li.Titulo, EX.ISBN, L.Nome_Leitor, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Data_Finalizado, (SELECT Nome_Status FROM Status_Emprestimo WHERE Id = IE.Id_Status) AS Status_Exemplar
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.Id = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.Id = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.Id)
                                    INNER JOIN Exemplar AS EX ON (EX.Id = IE.Id_exemplar)
                                    INNER JOIN Livro AS Li ON (Li.Id = EX.Id_livro)
                                    INNER JOIN Status_Emprestimo AS SE ON (SE.Id = E.Id_emprestimoStatus)
                                    WHERE E.Id LIKE '%" + busca + "%' AND E.Data_emprestimo BETWEEN '" + dataInicial + "' AND '" + dataFinal + "'";
                }
                if (statusEmprestimo != "Todos" && statusExemplar == "Todos")
                {
                    Cmd.CommandText = @"SELECT E.Id, SE.Nome_Status AS Status_Emprestimo, Li.Titulo, EX.ISBN, L.Nome_Leitor, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Data_Finalizado, (SELECT Nome_Status FROM Status_Emprestimo WHERE Id = IE.Id_Status) AS Status_Exemplar
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.Id = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.Id = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.Id)
                                    INNER JOIN Exemplar AS EX ON (EX.Id = IE.Id_exemplar)
                                    INNER JOIN Livro AS Li ON (Li.Id = EX.Id_livro)
                                    INNER JOIN Status_Emprestimo AS SE ON (SE.Id = E.Id_emprestimoStatus)
                                    WHERE SE.Nome_Status = '" + statusEmprestimo + "' AND E.Id LIKE '%" + busca + "%' AND E.Data_emprestimo BETWEEN '" + dataInicial + "' AND '" + dataFinal + "'";
                }
                if (statusEmprestimo == "Todos" && statusExemplar != "Todos")
                {
                    Cmd.CommandText = @"SELECT E.Id, SE.Nome_Status AS Status_Emprestimo, Li.Titulo, EX.ISBN, L.Nome_Leitor, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Data_Finalizado, (SELECT Nome_Status FROM Status_Emprestimo WHERE Id = IE.Id_Status) AS Status_Exemplar
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.Id = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.Id = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.Id)
                                    INNER JOIN Exemplar AS EX ON (EX.Id = IE.Id_exemplar)
                                    INNER JOIN Livro AS Li ON (Li.Id = EX.Id_livro)
                                    INNER JOIN Status_Emprestimo AS SE ON (SE.Id = E.Id_emprestimoStatus)
                                    WHERE IE.Id_status = '" + statusExemplarCod + "' AND E.Id LIKE '%" + busca + "%' AND E.Data_emprestimo BETWEEN '" + dataInicial + "' AND '" + dataFinal + "'";
                }
                if (statusEmprestimo != "Todos" && statusExemplar != "Todos")
                {
                    Cmd.CommandText = @"SELECT E.Id, SE.Nome_Status AS Status_Emprestimo, Li.Titulo, EX.ISBN, L.Nome_Leitor, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Data_Finalizado, (SELECT Nome_Status FROM Status_Emprestimo WHERE Id = IE.Id_Status) AS Status_Exemplar
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.Id = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.Id = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.Id)
                                    INNER JOIN Exemplar AS EX ON (EX.Id = IE.Id_exemplar)
                                    INNER JOIN Livro AS Li ON (Li.Id = EX.Id_livro)
                                    INNER JOIN Status_Emprestimo AS SE ON (SE.Id = E.Id_emprestimoStatus)
                                    WHERE SE.Nome_Status = '" + statusEmprestimo + "' AND IE.Id_status = '" + statusExemplarCod + "' AND E.Id LIKE '%" + busca + "%' AND E.Data_emprestimo BETWEEN '" + dataInicial + "' AND '" + dataFinal + "'";
                }
            }

            if (isExemplar)
            {
                if (statusEmprestimo == "Todos" && statusExemplar == "Todos")
                {
                    Cmd.CommandText = @"SELECT E.Id, SE.Nome_Status AS Status_Emprestimo, Li.Titulo, EX.ISBN, L.Nome_Leitor, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Data_Finalizado, (SELECT Nome_Status FROM Status_Emprestimo WHERE Id = IE.Id_Status) AS Status_Exemplar
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.Id = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.Id = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.Id)
                                    INNER JOIN Exemplar AS EX ON (EX.Id = IE.Id_exemplar)
                                    INNER JOIN Livro AS Li ON (Li.Id = EX.Id_livro)
                                    INNER JOIN Status_Emprestimo AS SE ON (SE.Id = E.Id_emprestimoStatus)
                                    WHERE Li.Titulo LIKE '%" + busca + "%' AND E.Data_emprestimo BETWEEN '" + dataInicial + "' AND '" + dataFinal + "'";
                }
                if (statusEmprestimo != "Todos" && statusExemplar == "Todos")
                {
                    Cmd.CommandText = @"SELECT E.Id, SE.Nome_Status AS Status_Emprestimo, Li.Titulo, EX.ISBN, L.Nome_Leitor, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Data_Finalizado, (SELECT Nome_Status FROM Status_Emprestimo WHERE Id = IE.Id_Status) AS Status_Exemplar
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.Id = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.Id = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.Id)
                                    INNER JOIN Exemplar AS EX ON (EX.Id = IE.Id_exemplar)
                                    INNER JOIN Livro AS Li ON (Li.Id = EX.Id_livro)
                                    INNER JOIN Status_Emprestimo AS SE ON (SE.Id = E.Id_emprestimoStatus)
                                    WHERE SE.Nome_Status = '" + statusEmprestimo + "' AND Li.Titulo LIKE '%" + busca + "%' AND E.Data_emprestimo BETWEEN '" + dataInicial + "' AND '" + dataFinal + "'";
                }
                if (statusEmprestimo == "Todos" && statusExemplar != "Todos")
                {
                    Cmd.CommandText = @"SELECT E.Id, SE.Nome_Status AS Status_Emprestimo, Li.Titulo, EX.ISBN, L.Nome_Leitor, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Data_Finalizado, (SELECT Nome_Status FROM Status_Emprestimo WHERE Id = IE.Id_Status) AS Status_Exemplar
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.Id = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.Id = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.Id)
                                    INNER JOIN Exemplar AS EX ON (EX.Id = IE.Id_exemplar)
                                    INNER JOIN Livro AS Li ON (Li.Id = EX.Id_livro)
                                    INNER JOIN Status_Emprestimo AS SE ON (SE.Id = E.Id_emprestimoStatus)
                                    WHERE IE.Id_status = '" + statusExemplarCod + "' AND Li.Titulo LIKE '%" + busca + "%' AND E.Data_emprestimo BETWEEN '" + dataInicial + "' AND '" + dataFinal + "'";
                }
                if (statusEmprestimo != "Todos" && statusExemplar != "Todos")
                {
                    Cmd.CommandText = @"SELECT E.Id, SE.Nome_Status AS Status_Emprestimo, Li.Titulo, EX.ISBN, L.Nome_Leitor, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Data_Finalizado, (SELECT Nome_Status FROM Status_Emprestimo WHERE Id = IE.Id_Status) AS Status_Exemplar
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.Id = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.Id = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.Id)
                                    INNER JOIN Exemplar AS EX ON (EX.Id = IE.Id_exemplar)
                                    INNER JOIN Livro AS Li ON (Li.Id = EX.Id_livro)
                                    INNER JOIN Status_Emprestimo AS SE ON (SE.Id = E.Id_emprestimoStatus)
                                    WHERE SE.Nome_Status = '" + statusEmprestimo + "' AND IE.Id_status = '" + statusExemplarCod + "' AND Li.Titulo LIKE '%" + busca + "%' AND E.Data_emprestimo BETWEEN '" + dataInicial + "' AND '" + dataFinal + "'";
                }
            }

            if (isISBN)
            {
                if (statusEmprestimo == "Todos" && statusExemplar == "Todos")
                {
                    Cmd.CommandText = @"SELECT E.Id, SE.Nome_Status AS Status_Emprestimo, Li.Titulo, EX.ISBN, L.Nome_Leitor, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Data_Finalizado, (SELECT Nome_Status FROM Status_Emprestimo WHERE Id = IE.Id_Status) AS Status_Exemplar
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.Id = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.Id = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.Id)
                                    INNER JOIN Exemplar AS EX ON (EX.Id = IE.Id_exemplar)
                                    INNER JOIN Livro AS Li ON (Li.Id = EX.Id_livro)
                                    INNER JOIN Status_Emprestimo AS SE ON (SE.Id = E.Id_emprestimoStatus)
                                    WHERE EX.ISBN LIKE '%" + busca + "%' AND E.Data_emprestimo BETWEEN '" + dataInicial + "' AND '" + dataFinal + "'";
                }
                if (statusEmprestimo != "Todos" && statusExemplar == "Todos")
                {
                    Cmd.CommandText = @"SELECT E.Id, SE.Nome_Status AS Status_Emprestimo, Li.Titulo, EX.ISBN, L.Nome_Leitor, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Data_Finalizado, (SELECT Nome_Status FROM Status_Emprestimo WHERE Id = IE.Id_Status) AS Status_Exemplar
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.Id = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.Id = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.Id)
                                    INNER JOIN Exemplar AS EX ON (EX.Id = IE.Id_exemplar)
                                    INNER JOIN Livro AS Li ON (Li.Id = EX.Id_livro)
                                    INNER JOIN Status_Emprestimo AS SE ON (SE.Id = E.Id_emprestimoStatus)
                                    WHERE SE.Nome_Status = '" + statusEmprestimo + "' AND EX.ISBN LIKE '%" + busca + "%' AND E.Data_emprestimo BETWEEN '" + dataInicial + "' AND '" + dataFinal + "'";
                }
                if (statusEmprestimo == "Todos" && statusExemplar != "Todos")
                {
                    Cmd.CommandText = @"SELECT E.Id, SE.Nome_Status AS Status_Emprestimo, Li.Titulo, EX.ISBN, L.Nome_Leitor, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Data_Finalizado, (SELECT Nome_Status FROM Status_Emprestimo WHERE Id = IE.Id_Status) AS Status_Exemplar
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.Id = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.Id = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.Id)
                                    INNER JOIN Exemplar AS EX ON (EX.Id = IE.Id_exemplar)
                                    INNER JOIN Livro AS Li ON (Li.Id = EX.Id_livro)
                                    INNER JOIN Status_Emprestimo AS SE ON (SE.Id = E.Id_emprestimoStatus)
                                    WHERE IE.Id_status = '" + statusExemplarCod + "' AND EX.ISBN LIKE '%" + busca + "%' AND E.Data_emprestimo BETWEEN '" + dataInicial + "' AND '" + dataFinal + "'";
                }
                if (statusEmprestimo != "Todos" && statusExemplar != "Todos")
                {
                    Cmd.CommandText = @"SELECT E.Id, SE.Nome_Status AS Status_Emprestimo, Li.Titulo, EX.ISBN, L.Nome_Leitor, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Data_Finalizado, (SELECT Nome_Status FROM Status_Emprestimo WHERE Id = IE.Id_Status) AS Status_Exemplar
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.Id = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.Id = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.Id)
                                    INNER JOIN Exemplar AS EX ON (EX.Id = IE.Id_exemplar)
                                    INNER JOIN Livro AS Li ON (Li.Id = EX.Id_livro)
                                    INNER JOIN Status_Emprestimo AS SE ON (SE.Id = E.Id_emprestimoStatus)
                                    WHERE SE.Nome_Status = '" + statusEmprestimo + "' AND IE.Id_status = '" + statusExemplarCod + "' AND EX.ISBN LIKE '%" + busca + "%' AND E.Data_emprestimo BETWEEN '" + dataInicial + "' AND '" + dataFinal + "'";
                }
            }

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EmprestimoPesquisaExemplarModel> lista = new List<EmprestimoPesquisaExemplarModel>();

            while (reader.Read())
            {
                Nullable<DateTime> finalizado = null;
                if (!reader.IsDBNull(8))
                {
                    finalizado = (DateTime)reader["Data_Finalizado"];
                }
                EmprestimoPesquisaExemplarModel pesquisa = new EmprestimoPesquisaExemplarModel(
                    (int)reader["Id"],
                    (String)reader["Status_Emprestimo"],
                    (String)reader["Titulo"],
                    (String)reader["ISBN"],
                    (String)reader["Nome_Leitor"],
                    (String)reader["Nome_funcionario"],
                    (DateTime)reader["Data_emprestimo"],
                    (DateTime)reader["Data_devolucao"],
                    finalizado,
                    (String)reader["Status_Exemplar"]
                );
                lista.Add(pesquisa);
            }
            reader.Close();

            return lista;
        }

        public List<EmprestimoPesquisaLeitorModel> BuscarLeitor(string busca, DateTime dataInicial, DateTime dataFinal, String statusEmprestimo, bool isLeitor = false, bool isCPF = false)
        {
            Cmd.Connection = connection.RetornaConexao();


            if (isLeitor)
            {
                if (statusEmprestimo == "Todos")
                {
                    Cmd.CommandText = @"SELECT Leitor.Id,
                                           Leitor.Nome_Leitor,
	                                       Leitor.CPF,
	                                       COUNT(Emprestimo.Id) AS Total
                                    FROM Leitor
                                    INNER JOIN Emprestimo ON (Emprestimo.Id_leitor = Leitor.Id)
                                    INNER JOIN Status_Emprestimo ON (Status_Emprestimo.Id = Emprestimo.Id_emprestimoStatus)
                                    WHERE Leitor.Nome_Leitor LIKE '%" + busca + "%' AND Emprestimo.Data_emprestimo BETWEEN '" + dataInicial + "' AND '" + dataFinal + "' " +
                                    "GROUP BY Leitor.Id, Leitor.Nome_Leitor, Leitor.CPF";
                }
                else
                {
                    Cmd.CommandText = @"SELECT Leitor.Id,
                                           Leitor.Nome_Leitor,
	                                       Leitor.CPF,
	                                       COUNT(Emprestimo.Id) AS Total
                                    FROM Leitor
                                    INNER JOIN Emprestimo ON (Emprestimo.Id_leitor = Leitor.Id)
                                    INNER JOIN Status_Emprestimo ON (Status_Emprestimo.Id = Emprestimo.Id_emprestimoStatus)
                                    WHERE Status_Emprestimo.Nome_Status = '" + statusEmprestimo + "' AND Leitor.Nome_Leitor LIKE '%" + busca + "%' AND Emprestimo.Data_emprestimo BETWEEN '" + dataInicial + "' AND '" + dataFinal + "' " +
                                    "GROUP BY Leitor.Id, Leitor.Nome_Leitor, Leitor.CPF";
                }
            }

            if (isCPF)
            {
                if (statusEmprestimo == "Todos")
                {
                    Cmd.CommandText = @"SELECT Leitor.Id,
                                           Leitor.Nome_Leitor,
	                                       Leitor.CPF,
	                                       COUNT(Emprestimo.Id) AS Total
                                    FROM Leitor
                                    INNER JOIN Emprestimo ON (Emprestimo.Id_leitor = Leitor.Id)
                                    INNER JOIN Status_Emprestimo ON (Status_Emprestimo.Id = Emprestimo.Id_emprestimoStatus)
                                    WHERE Leitor.CPF LIKE '%" + busca + "%' AND Emprestimo.Data_emprestimo BETWEEN '" + dataInicial + "' AND '" + dataFinal + "' " +
                                    "GROUP BY Leitor.Id, Leitor.Nome_Leitor, Leitor.CPF";
                }
                else
                {
                    Cmd.CommandText = @"SELECT Leitor.Id,
                                           Leitor.Nome_Leitor,
	                                       Leitor.CPF,
	                                       COUNT(Emprestimo.Id) AS Total
                                    FROM Leitor
                                    INNER JOIN Emprestimo ON (Emprestimo.Id_leitor = Leitor.Id)
                                    INNER JOIN Status_Emprestimo ON (Status_Emprestimo.Id = Emprestimo.Id_emprestimoStatus)
                                    WHERE Status_Emprestimo.Nome_Status = '" + statusEmprestimo + "' AND Leitor.CPF LIKE '%" + busca + "%' AND Emprestimo.Data_emprestimo BETWEEN '" + dataInicial + "' AND '" + dataFinal + "' " +
                                    "GROUP BY Leitor.Id, Leitor.Nome_Leitor, Leitor.CPF";
                }
            }

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EmprestimoPesquisaLeitorModel> lista = new List<EmprestimoPesquisaLeitorModel>();

            while (reader.Read())
            {
                EmprestimoPesquisaLeitorModel pesquisa = new EmprestimoPesquisaLeitorModel(
                    (int)reader["Id"],
                    (String)reader["Nome_Leitor"],
                    (String)reader["CPF"],
                    (int)reader["Total"]
                );
                lista.Add(pesquisa);
            }
            reader.Close();

            return lista;
        }

        public bool Excluir(EmprestimoPesquisaExemplarModel emprestimo)
        {
            // excluir itens em item_emprestimo
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"DELETE FROM Item_emprestimo WHERE ID_emprestimo = @ID";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", emprestimo.ID_emprestimo);
            Cmd.ExecuteNonQuery();

            // excluir emprestimo
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"DELETE FROM Emprestimo WHERE ID_emprestimo = @ID";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", emprestimo.ID_emprestimo);

            if (Cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Devolucao(EmprestimoPesquisaExemplarModel emprestimo)
        {
            // mudar status emprestimo
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Emprestimo SET Id_emprestimoStatus = @Status
                                WHERE Id = @ID";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Status", 7);
            Cmd.Parameters.AddWithValue("@ID", emprestimo.ID_emprestimo);

            if (Cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<EmprestimoModel> Relatorio(DateTime inicio, DateTime fim)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"
            SELECT E.*, F.Nome_Funcionario AS 'Funcionario', L.Nome_Leitor AS 'Leitor'
            FROM Emprestimo as E
            INNER JOIN Funcionario AS F ON (F.ID_funcionario = E.ID_funcionario)
            INNER JOIN Leitor as L ON (L.ID_leitor = E.ID_leitor)
            WHERE E.Data_emprestimo BETWEEN @inicio AND @fim
            ";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@inicio", inicio);
            Cmd.Parameters.AddWithValue("@fim", fim);

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EmprestimoModel> lista = new List<EmprestimoModel>();

            while (reader.Read())
            {
                EmprestimoModel leitor = new EmprestimoModel(
                    (int)reader["ID_emprestimo"],
                    (int)reader["ID_funcionario"],
                    (int)reader["ID_leitor"],
                    (DateTime)reader["Data_devolucao"],
                    (DateTime)reader["Data_emprestimo"],
                    (String)reader["Leitor"],
                    (String)reader["Funcionario"],
                    (String)reader["Status"]
                );
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

        public int BuscarPrimeiroExemplar(int id)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Exemplar WHERE Id_livro = '" + id + "' AND Estado = 1 ORDER BY Id ASC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            int idExemplar = 0;

            while (reader.Read())
            {
                idExemplar = (int)reader["Id"];
            }

            reader.Close();

            return idExemplar;
        }

        public List<ExemplarModel> BuscarExemplar(int idLivro, string busca, bool isCodigo = false, bool isAno = false, bool isIsbn = false, bool isEdicao = false)
        {
            Cmd.Connection = connection.RetornaConexao();

            if (isCodigo)
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
                                        WHERE Livro.Id = '" + idLivro + "' AND Exemplar.Id LIKE '%" + busca + "%' AND " +
                                        "Exemplar.Id NOT IN ( " +
                                        "SELECT Item_reserva.Id_exemplar " +
                                        "FROM Reserva " +
                                        "INNER JOIN Item_reserva ON(Item_reserva.Id_reserva = Reserva.Id) " +
                                        "WHERE Reserva.Id_reservaStatus = 1) AND " +
                                        "Exemplar.Id NOT IN (" +
                                            "SELECT Item_Emprestimo.Id_exemplar " +
                                            "FROM Emprestimo " +
                                            "INNER JOIN Item_Emprestimo ON(Item_Emprestimo.Id_emprestimo = Emprestimo.Id)" +
                                            "WHERE(Emprestimo.Id_emprestimoStatus = 1 OR Emprestimo.Id_emprestimoStatus = 2) AND" +
                                            "(Item_Emprestimo.Id_Status = 6 OR Item_Emprestimo.Id_Status = 7)" +
                                        ")";
            }

            if (isAno)
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
                                        WHERE Livro.Id = '" + idLivro + "' AND Exemplar.Ano LIKE '%" + busca + "%' AND " +
                                        "Exemplar.Id NOT IN ( " +
                                        "SELECT Item_reserva.Id_exemplar " +
                                        "FROM Reserva " +
                                        "INNER JOIN Item_reserva ON(Item_reserva.Id_reserva = Reserva.Id) " +
                                        "WHERE Reserva.Id_reservaStatus = 1) AND " +
                                        "Exemplar.Id NOT IN (" +
                                            "SELECT Item_Emprestimo.Id_exemplar " +
                                            "FROM Emprestimo " +
                                            "INNER JOIN Item_Emprestimo ON(Item_Emprestimo.Id_emprestimo = Emprestimo.Id)" +
                                            "WHERE(Emprestimo.Id_emprestimoStatus = 1 OR Emprestimo.Id_emprestimoStatus = 2) AND" +
                                            "(Item_Emprestimo.Id_Status = 6 OR Item_Emprestimo.Id_Status = 7)" +
                                        ")";
            }

            if (isIsbn)
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
                                        WHERE Livro.Id = '" + idLivro + "' AND Exemplar.ISBN LIKE '%" + busca + "%' AND " +
                                        "Exemplar.Id NOT IN ( " +
                                        "SELECT Item_reserva.Id_exemplar " +
                                        "FROM Reserva " +
                                        "INNER JOIN Item_reserva ON(Item_reserva.Id_reserva = Reserva.Id) " +
                                        "WHERE Reserva.Id_reservaStatus = 1) AND " +
                                        "Exemplar.Id NOT IN (" +
                                            "SELECT Item_Emprestimo.Id_exemplar " +
                                            "FROM Emprestimo " +
                                            "INNER JOIN Item_Emprestimo ON(Item_Emprestimo.Id_emprestimo = Emprestimo.Id)" +
                                            "WHERE(Emprestimo.Id_emprestimoStatus = 1 OR Emprestimo.Id_emprestimoStatus = 2) AND" +
                                            "(Item_Emprestimo.Id_Status = 6 OR Item_Emprestimo.Id_Status = 7)" +
                                        ")";
            }
            if (isEdicao)
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
                                        WHERE Livro.Id = '" + idLivro + "' AND Edicao.Nome_Edicao LIKE '%" + busca + "%' AND " +
                                        "Exemplar.Id NOT IN ( " +
                                        "SELECT Item_reserva.Id_exemplar " +
                                        "FROM Reserva " +
                                        "INNER JOIN Item_reserva ON(Item_reserva.Id_reserva = Reserva.Id) " +
                                        "WHERE Reserva.Id_reservaStatus = 1) AND " +
                                        "Exemplar.Id NOT IN (" +
                                            "SELECT Item_Emprestimo.Id_exemplar " +
                                            "FROM Emprestimo " +
                                            "INNER JOIN Item_Emprestimo ON(Item_Emprestimo.Id_emprestimo = Emprestimo.Id)" +
                                            "WHERE(Emprestimo.Id_emprestimoStatus = 1 OR Emprestimo.Id_emprestimoStatus = 2) AND" +
                                            "(Item_Emprestimo.Id_Status = 6 OR Item_Emprestimo.Id_Status = 7)" +
                                        ")";


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

        public LeitorModel BuscaLeitorEmprestimoPorId(int id)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Leitor Where Id = '" + id + "'";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            LeitorModel leitor = null;

            while (reader.Read())
            {
                leitor = new LeitorModel(
                    (int)reader["Id"],
                    (String)reader["Nome_Leitor"],
                    (DateTime)reader["Data_Nascimento"],
                    (String)reader["Telefone"],
                    (String)reader["CPF"],
                    (String)reader["Endereco"],
                    (String)reader["Email"]
                );
            }
            reader.Close();

            return leitor;
        }

        public EmprestimoModel BuscaEmprestimoPorId(int id)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Emprestimo Where Id = '" + id + "'";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            EmprestimoModel emprestimo = null;

            while (reader.Read())
            {
                Nullable<DateTime> finalizado = null;
                if (!reader.IsDBNull(7))
                {
                    finalizado = (DateTime)reader["Data_Finalizado"];
                }
                emprestimo = new EmprestimoModel(
                    (int)reader["Id"],
                    (DateTime)reader["Data_Emprestimo"],
                    (DateTime)reader["Data_Devolucao"],
                    (String)reader["Obs_Emprestimo"],
                    (int)reader["Id_leitor"],
                    (int)reader["Id_funcionario"],
                    (int)reader["id_emprestimoStatus"],
                    finalizado
                );
            }
            reader.Close();

            return emprestimo;
        }

        public List<EmprestimoVisualizarModel> EmprestimoVisualizarPorId(int idEmprestimo = 0, int idLeitor = 0, string status = "", List<int> listaItemId = null)
        {
            Cmd.Connection = connection.RetornaConexao();

            if (idEmprestimo != 0)
            {
                Cmd.CommandText = @"SELECT Emprestimo.Id,
	                                   Livro.Titulo,
	                                   Exemplar.ISBN,
	                                   Funcionario.Nome_Funcionario,
	                                   Emprestimo.Data_Emprestimo,
	                                   Emprestimo.Data_Devolucao,
	                                   Emprestimo.Data_Finalizado,
	                                   Status_Emprestimo.Nome_Status AS Status_Emprestimo,
                                       Item_Emprestimo.Id AS ItemEmprestimoId,
	                                   (SELECT Nome_Status FROM Status_Emprestimo INNER JOIN Item_Emprestimo AS IE ON (IE.Id_Status = Status_Emprestimo.Id) WHERE IE.Id = Item_Emprestimo.Id) AS Status_Exemplar
                                FROM Emprestimo
                                INNER JOIN Item_Emprestimo ON (Item_Emprestimo.Id_emprestimo = Emprestimo.Id)
                                INNER JOIN Exemplar ON (Exemplar.Id = Item_Emprestimo.Id_exemplar)
                                INNER JOIN Livro ON (Livro.Id = Exemplar.Id_livro)
                                INNER JOIN Funcionario ON (Funcionario.Id = Emprestimo.Id_funcionario)
                                INNER JOIN Status_Emprestimo ON (Status_Emprestimo.Id = Emprestimo.Id_emprestimoStatus)
                                WHERE Emprestimo.Id = '" + idEmprestimo + "'";
            }
            else
            {
                if (listaItemId == null)
                {
                    Cmd.CommandText = @"SELECT Emprestimo.Id,
	                                   Livro.Titulo,
	                                   Exemplar.ISBN,
	                                   Funcionario.Nome_Funcionario,
	                                   Emprestimo.Data_Emprestimo,
	                                   Emprestimo.Data_Devolucao,
	                                   Emprestimo.Data_Finalizado,
	                                   Status_Emprestimo.Nome_Status AS Status_Emprestimo,
                                       Item_Emprestimo.Id AS ItemEmprestimoId,
	                                   (SELECT Nome_Status FROM Status_Emprestimo INNER JOIN Item_Emprestimo AS IE ON (IE.Id_Status = Status_Emprestimo.Id) WHERE IE.Id = Item_Emprestimo.Id) AS Status_Exemplar
                                FROM Emprestimo
                                INNER JOIN Item_Emprestimo ON (Item_Emprestimo.Id_emprestimo = Emprestimo.Id)
                                INNER JOIN Exemplar ON (Exemplar.Id = Item_Emprestimo.Id_exemplar)
                                INNER JOIN Livro ON (Livro.Id = Exemplar.Id_livro)
                                INNER JOIN Funcionario ON (Funcionario.Id = Emprestimo.Id_funcionario)
                                INNER JOIN Status_Emprestimo ON (Status_Emprestimo.Id = Emprestimo.Id_emprestimoStatus)
                                WHERE Emprestimo.Id_leitor = '" + idLeitor + "' AND Status_Emprestimo.Nome_Status = '" + status + "'";
                }
                else
                {
                    Cmd.CommandText = @"SELECT Emprestimo.Id,
	                                   Livro.Titulo,
	                                   Exemplar.ISBN,
	                                   Funcionario.Nome_Funcionario,
	                                   Emprestimo.Data_Emprestimo,
	                                   Emprestimo.Data_Devolucao,
	                                   Emprestimo.Data_Finalizado,
	                                   Status_Emprestimo.Nome_Status AS Status_Emprestimo,
                                       Item_Emprestimo.Id AS ItemEmprestimoId,
	                                   (SELECT Nome_Status FROM Status_Emprestimo INNER JOIN Item_Emprestimo AS IE ON (IE.Id_Status = Status_Emprestimo.Id) WHERE IE.Id = Item_Emprestimo.Id) AS Status_Exemplar
                                FROM Emprestimo
                                INNER JOIN Item_Emprestimo ON (Item_Emprestimo.Id_emprestimo = Emprestimo.Id)
                                INNER JOIN Exemplar ON (Exemplar.Id = Item_Emprestimo.Id_exemplar)
                                INNER JOIN Livro ON (Livro.Id = Exemplar.Id_livro)
                                INNER JOIN Funcionario ON (Funcionario.Id = Emprestimo.Id_funcionario)
                                INNER JOIN Status_Emprestimo ON (Status_Emprestimo.Id = Emprestimo.Id_emprestimoStatus)
                                WHERE Item_Emprestimo.Id IN (" + string.Join(",", listaItemId.ToArray()) + ") AND Emprestimo.Id_leitor = '" + idLeitor + "'";
                }

            }

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EmprestimoVisualizarModel> lista = new List<EmprestimoVisualizarModel>();

            while (reader.Read())
            {
                Nullable<DateTime> finalizado = null;
                if (!reader.IsDBNull(6))
                {
                    finalizado = (DateTime)reader["Data_Finalizado"];
                }
                EmprestimoVisualizarModel emprestimo = new EmprestimoVisualizarModel(
                    (int)reader["Id"],
                    (String)reader["Titulo"],
                    (String)reader["ISBN"],
                    (String)reader["Nome_Funcionario"],
                    (DateTime)reader["Data_Emprestimo"],
                    (DateTime)reader["Data_Devolucao"],
                    finalizado,
                    (String)reader["Status_Emprestimo"],
                    (String)reader["Status_Exemplar"]
                );
                emprestimo.setItemEmprestimoId((int)reader["ItemEmprestimoId"]);
                lista.Add(emprestimo);
            }
            reader.Close();

            return lista;
        }

        public bool AtualizarStatusEmprestimo(EmprestimoVisualizarModel emprestimo)
        {
            int statusEmprestimo = 0;

            switch (emprestimo.Status_Emprestimo)
            {
                case "Em Aberto":
                    statusEmprestimo = 1;
                    break;
                case "Pendente":
                    statusEmprestimo = 2;
                    break;
                case "Finalizado":
                    statusEmprestimo = 3;
                    break;
                case "Cancelado":
                    statusEmprestimo = 4;
                    break;
            }

            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Emprestimo SET Data_Finalizado = @Data, Id_emprestimoStatus = @Status WHERE Id = @ID";
            Cmd.Parameters.Clear();

            if (statusEmprestimo == 3 || statusEmprestimo == 4)
            {
                Cmd.Parameters.AddWithValue("@Data", DateTime.Today);
            }
            else
            {
                Cmd.Parameters.AddWithValue("@Data", DBNull.Value);
            }
            Cmd.Parameters.AddWithValue("@Status", statusEmprestimo);
            Cmd.Parameters.AddWithValue("@ID", emprestimo.ID_emprestimo);

            if (Cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AtualizarStatusExemplar(EmprestimoVisualizarModel emprestimo)
        {
            int statusExemplar = 0;

            switch (emprestimo.Status_Exemplar)
            {
                case "Devolvido":
                    statusExemplar = 5;
                    break;
                case "Extraviado":
                    statusExemplar = 6;
                    break;
                case "Emprestado":
                    statusExemplar = 7;
                    break;
            }

            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Item_Emprestimo SET Id_Status = @Status WHERE Id = @ID";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Status", statusExemplar);
            Cmd.Parameters.AddWithValue("@ID", emprestimo.getItemEmprestimoId());

            if (Cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Não emprestar se houver 1 exemplar extraviado com o status pendente
        public int leitorPossuiExtraviadoPendente(int id)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT COUNT(Emprestimo.Id) AS Quantidade
                                FROM Leitor
                                INNER JOIN Emprestimo ON (Emprestimo.Id_leitor = Leitor.Id)
                                INNER JOIN Item_Emprestimo ON (Item_Emprestimo.Id_emprestimo = Emprestimo.Id)
                                INNER JOIN Status_Emprestimo ON (Status_Emprestimo.Id = Emprestimo.Id_emprestimoStatus)
                                WHERE Leitor.Id = '" + id + "' AND Emprestimo.Id_emprestimoStatus = 2 AND Item_Emprestimo.Id_Status = 6";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();
            int quantidade = 0;

            while (reader.Read())
            {
                quantidade = (int)reader["Quantidade"];
            }
            reader.Close();

            return quantidade;
        }

        // Não empresta se houver algum empréstimo com atraso, de status diferentes de finalizado e cancelado
        public int leitorPossuiEmprestimoAtrasado(int id)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT Emprestimo.Data_Devolucao
                                FROM Leitor
                                INNER JOIN Emprestimo ON (Emprestimo.Id_leitor = Leitor.Id)
                                INNER JOIN Status_Emprestimo ON (Status_Emprestimo.Id = Emprestimo.Id_emprestimoStatus)
                                WHERE Leitor.Id = '" + id + "' AND Emprestimo.Id_emprestimoStatus = 1";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            int quantidade = 0;

            while (reader.Read())
            {
                DateTime devolucao = (DateTime)reader["Data_Devolucao"];
                if (DateTime.Now > devolucao)
                {
                    quantidade += 1;
                }
            }

            reader.Close();
            return quantidade;
        }

        // multa de 2 dias por dia por livro, não deixar emprestar
        public int leitorPossuiMulta(int id)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT SUM(DATEDIFF(day, Emprestimo.Data_Devolucao, Emprestimo.Data_Finalizado)) AS Diferenca
                                FROM Leitor
                                INNER JOIN Emprestimo ON (Emprestimo.Id_leitor = Leitor.Id)
                                INNER JOIN Status_Emprestimo ON (Status_Emprestimo.Id = Emprestimo.Id_emprestimoStatus)
                                WHERE Leitor.Id = '" + id + "' AND Emprestimo.Id_emprestimoStatus = 3 AND Emprestimo.Data_Finalizado > Emprestimo.Data_Devolucao";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            int diferenca = 0;

            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    diferenca = (int)reader["Diferenca"];
                }
            }

            reader.Close();

            return diferenca;
        }

        public Nullable<DateTime> BuscarUltimoEmprestimoComAtraso(int id)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Emprestimo WHERE Emprestimo.Id_leitor = '" + id + "' AND Emprestimo.Id_emprestimoStatus = 3 AND Emprestimo.Data_Finalizado > Emprestimo.Data_Devolucao ORDER BY Id DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            DateTime dataFinalizado = DateTime.Now;

            while (reader.Read())
            {
                dataFinalizado = (DateTime)reader["Data_Finalizado"];
            }

            reader.Close();

            return dataFinalizado;
        }

        public float PegarValorExemplarPorId(int id)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Exemplar WHERE Id = '" + id + "'";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            float valor = 0;

            while (reader.Read())
            {
                string valorString = Convert.ToString(reader["Valor"]);
                valorString.Replace(",", ".");
                valor = float.Parse(valorString);
            }
            reader.Close();
            return valor;
        }

        public int quantidadeEmprestadosLeitor(int id)
        {
            Cmd.ExecuteReader().Close();
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT COUNT(Emprestimo.ID) AS Quantidade
                                FROM Leitor
                                INNER JOIN Emprestimo ON (Emprestimo.Id_leitor = Leitor.Id)
                                INNER JOIN Status_Emprestimo ON (Status_Emprestimo.Id = Emprestimo.Id_emprestimoStatus)
                                WHERE Leitor.Id = '" + id + "' AND Emprestimo.Id_emprestimoStatus = 1";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            int quantidade = 0;

            while (reader.Read())
            {
                quantidade = (int)reader["Quantidade"];
            }
            reader.Close();

            return quantidade;
        }

        public bool RenovarEmprestimo(EmprestimoVisualizarModel emprestimo)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Emprestimo SET Data_Devolucao = @Data WHERE Id = @ID";
            Cmd.Parameters.Clear();

            Cmd.Parameters.AddWithValue("@Data", emprestimo.Data_devolucao.AddDays(14));
            Cmd.Parameters.AddWithValue("@ID", emprestimo.ID_emprestimo);

            if (Cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ExemplarNaoFoiDevolvido(int id)
        {
            Cmd.ExecuteReader().Close();
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT Emprestimo.Id
                                FROM Emprestimo
                                INNER JOIN Item_Emprestimo ON (Item_Emprestimo.Id_emprestimo = Emprestimo.Id)
                                INNER JOIN Exemplar ON (Exemplar.Id = Item_Emprestimo.Id_exemplar)
                                WHERE Exemplar.id = '"+id+"' AND Emprestimo.Id_emprestimoStatus = 1 AND Item_Emprestimo.Id_Status = 7 AND Emprestimo.Data_Finalizado IS NULL";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            bool naoFoiDevolvido = false;

            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    naoFoiDevolvido = true;
                }
            }
            reader.Close();

            return naoFoiDevolvido;
        }

    }
}
