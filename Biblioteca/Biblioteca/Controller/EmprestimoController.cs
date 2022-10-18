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

                Cmd.CommandText = @"INSERT INTO Emprestimo Values (@Emprestimo, @Devolucao, @Obs, @Leitor, @Funcionario, @Status, @Estado)";

                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Emprestimo", dataEmprestimo.ToString("yyyy-MM-dd"));
                Cmd.Parameters.AddWithValue("@Devolucao", dataDevolucao.ToString("yyyy-MM-dd"));
                Cmd.Parameters.AddWithValue("@Obs", obs);
                Cmd.Parameters.AddWithValue("@Leitor", this.singleton.getLeitor().getId());
                Cmd.Parameters.AddWithValue("@Funcionario", 1);//this.singleton.getFuncionario().getId());
                Cmd.Parameters.AddWithValue("@Status", 6);
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

            while (reader.Read())
            {
                int idEmprestimo = (int)reader["Id"];
                reader.Close();
                return idEmprestimo;
            }

            return 0;
        }

        // RELACIONAR EXEMPLARES SELECIONADO NO EMPRESTIMO
        public bool RelacionarLivrosEmprestimo(int idEmprestimo, ExemplarModel exemplar)
        {
            Cmd.Connection = connection.RetornaConexao();

            if (Cmd.Connection.State != System.Data.ConnectionState.Open)
                Cmd.Connection.Open();

            Cmd.CommandText = @"INSERT INTO Item_emprestimo Values (@Exemplar, @Emprestimo)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Exemplar", exemplar.getId());
            Cmd.Parameters.AddWithValue("@Emprestimo", idEmprestimo);

            if (Cmd.ExecuteNonQuery() == 1)
            {
                Cmd.Connection.Close();
                return true;
            }
            else
            {
                Cmd.Connection.Close();
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

        public List<EmprestimoPesquisaModel> ListarTodosBusca()
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT E.Id, L.Nome_Leitor, Li.Titulo, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, SE.Nome_Status
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.Id = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.Id = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.Id)
			                        INNER JOIN Exemplar AS EX ON (EX.Id = IE.Id_exemplar)
			                        INNER JOIN Livro AS Li ON (Li.Id = EX.Id_livro)
									INNER JOIN Status_Emprestimo AS SE ON (SE.Id = E.Id_emprestimoStatus)";
            //SELECT E.ID_emprestimo, L.Nome_Leitor, Li.Nome_Livro, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.status
            //FROM Emprestimo as E
            //INNER JOIN Funcionario AS F ON (F.ID_funcionario = E.ID_funcionario)
            //INNER JOIN Leitor as L ON (L.ID_leitor = E.ID_leitor)
            //INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.ID_emprestimo)
            //INNER JOIN Livro as Li ON (Li.ID_livro = IE.ID_livro)
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EmprestimoPesquisaModel> lista = new List<EmprestimoPesquisaModel>();

            while (reader.Read())
            {
                EmprestimoPesquisaModel pesquisa = new EmprestimoPesquisaModel(
                    (int)reader["Id"],
                    (String)reader["Nome_Leitor"],
                    (String)reader["Titulo"],
                    (String)reader["Nome_funcionario"],
                    (DateTime)reader["Data_emprestimo"],
                    (DateTime)reader["Data_devolucao"],
                    (String)reader["Nome_Status"]
                );
                lista.Add(pesquisa);
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

            while (reader.Read())
            {
                int emprestimos = (int)reader["Emprestimos"];
                reader.Close();
                return quantidade - emprestimos;
            }
            return 0;
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
        public List<ExemplarModel> ListarTodosExemplares(int idLivro)
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
                                WHERE Exemplar.estado = 1 AND Exemplar.ID_livro = '" + idLivro + "'";
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

            Cmd.CommandText = @"
                SELECT L.*, F.Nome_fornecedor as Editora 
                FROM Livro AS L
                INNER JOIN Editora AS F ON (F.ID_fornecedor = L.ID_fornecedor)
                WHERE L.Nome_Livro LIKE '" + busca + "%'";

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LivroModel> lista = new List<LivroModel>();

            //while (reader.Read()) {
            //    LivroModel livro = new LivroModel(
            //        //(int)reader["Id"],
            //        //(String)reader["Titulo"],
            //        ////(String)reader["Edicao"],
            //        ////(String)reader["Ano_publicacao"],
            //        ////(String)reader["ISBN"],
            //        ////(int)reader["Quantidade"],
            //        //(String)reader["Nome_Editora"],
            //        //(String)reader["Nome_Autor"],
            //        //(String)reader["Nome_Genero"]
            //    );
            //    lista.Add(livro);
            //}
            //reader.Close();

            return lista;
        }

        public void InserirExemplarEmprestimo(ExemplarModel exemplar)
        {
            this.singleton.setExemplar(exemplar);
            this.singleton.setAddExemplar(true);
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

        public List<LeitorModel> PegarLeitorEmprestimo()
        {
            List<LeitorModel> lista = new List<LeitorModel>();
            lista.Add(this.singleton.getLeitor());
            return lista;
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
        public List<EmprestimoPesquisaModel> BuscarCodigo(string busca, bool isCodigo = false)
        {
            Cmd.CommandText = @"SELECT E.ID_emprestimo, L.Nome_Leitor, Li.Nome_Livro, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Status
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.ID_funcionario = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.ID_leitor = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.ID_emprestimo)
                                    INNER JOIN Livro as Li ON (Li.ID_livro = IE.ID_livro)
                                    WHERE E.ID_emprestimo LIKE '" + busca + "%'";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EmprestimoPesquisaModel> lista = new List<EmprestimoPesquisaModel>();

            while (reader.Read())
            {
                EmprestimoPesquisaModel pesquisa = new EmprestimoPesquisaModel(
                    (int)reader["ID_emprestimo"],
                    (String)reader["Nome_Leitor"],
                    (String)reader["Nome_Livro"],
                    (String)reader["Nome_funcionario"],
                    (DateTime)reader["Data_devolucao"],
                    (DateTime)reader["Data_emprestimo"],
                    (String)reader["Status"]
                );
                lista.Add(pesquisa);
            }
            reader.Close();

            return lista;
        }
        public List<EmprestimoPesquisaModel> Buscar(string busca, bool isLivro = false, bool isLeitor = false, bool isCodigo = false)
        {
            Cmd.Connection = connection.RetornaConexao();

            if (isLivro)
            {
                Cmd.CommandText = @"SELECT E.ID_emprestimo, L.Nome_Leitor, Li.Nome_Livro, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Status
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.ID_funcionario = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.ID_leitor = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.ID_emprestimo)
                                    INNER JOIN Livro as Li ON (Li.ID_livro = IE.ID_livro)
                                    WHERE Li.Nome_Livro LIKE '" + busca + "%'";
            }

            if (isLeitor)
            {
                Cmd.CommandText = @"SELECT E.ID_emprestimo, L.Nome_Leitor, Li.Nome_Livro, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Status
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.ID_funcionario = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.ID_leitor = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.ID_emprestimo)
                                    INNER JOIN Livro as Li ON (Li.ID_livro = IE.ID_livro)
                                    WHERE L.Nome_Leitor LIKE '" + busca + "%'";
            }
            if (isCodigo)
            {
                Cmd.CommandText = @"SELECT E.ID_emprestimo, L.Nome_Leitor, Li.Nome_Livro, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Status
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.ID_funcionario = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.ID_leitor = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.ID_emprestimo)
                                    INNER JOIN Livro as Li ON (Li.ID_livro = IE.ID_livro)
                                    WHERE E.ID_emprestimo LIKE '" + busca + "%'";
            }

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EmprestimoPesquisaModel> lista = new List<EmprestimoPesquisaModel>();

            while (reader.Read())
            {
                EmprestimoPesquisaModel pesquisa = new EmprestimoPesquisaModel(
                    (int)reader["ID_emprestimo"],
                    (String)reader["Nome_Leitor"],
                    (String)reader["Nome_Livro"],
                    (String)reader["Nome_funcionario"],
                    (DateTime)reader["Data_devolucao"],
                    (DateTime)reader["Data_emprestimo"],
                    (String)reader["Status"]
                );
                lista.Add(pesquisa);
            }
            reader.Close();

            return lista;
        }

        public bool Excluir(EmprestimoPesquisaModel emprestimo)
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

        public bool Devolucao(EmprestimoPesquisaModel emprestimo)
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

    }
}
