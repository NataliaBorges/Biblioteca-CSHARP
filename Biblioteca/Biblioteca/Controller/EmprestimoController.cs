using Biblioteca.Util;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Biblioteca.Model;
using System.Globalization;
using System.Collections.Generic;

namespace Biblioteca.Controller {
    class EmprestimoController {

        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set; }

        Singleton singleton = Singleton.GetInstancia();

        public EmprestimoController() {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }

        // CADASTRAR NOVO EMPRESTIMO
        public bool Insercao(String dataEmprestimo, String dataDevolucao, String obs) {
            try {
                Cmd.Connection = connection.RetornaConexao();

                Cmd.CommandText = @"INSERT INTO Emprestimo Values (@ID_funcionario, @ID_leitor, @Data_emprestimo, @Data_devolucao, @Obs_emprestimo, @Status)";

                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID_funcionario", 4);//this.singleton.getFuncionario().getId());
                Cmd.Parameters.AddWithValue("@ID_leitor", this.singleton.getLeitor().getId());
                Cmd.Parameters.AddWithValue("@Data_emprestimo", dataEmprestimo);
                Cmd.Parameters.AddWithValue("@Data_devolucao", dataDevolucao);
                Cmd.Parameters.AddWithValue("@Obs_emprestimo", obs);
                Cmd.Parameters.AddWithValue("@Status", "EMPRESTADO");

                if (Cmd.ExecuteNonQuery() == 1) {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (Exception e) {
                return false;
            }

        }

        // BUSCAR ÚLTIMO EMPRESTIMO CADASTRADO PARA PODER PEGAR O ID DO MESMO
        public int BuscarUltimoEmprestimo() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Emprestimo ORDER BY ID_emprestimo DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            while (reader.Read()) {
                int idEmprestimo = (int)reader["ID_emprestimo"];
                reader.Close();
                return idEmprestimo;
            }


            return 0;
        }

        // RELACIONAR EXEMPLARES SELECIONADO NO EMPRESTIMO
        public bool RelacionarLivrosEmprestimo(int idEmprestimo, ExemplarModel exemplar) {
            Cmd.Connection = connection.RetornaConexao();

            if (Cmd.Connection.State != System.Data.ConnectionState.Open)
                Cmd.Connection.Open();

            Cmd.CommandText = @"INSERT INTO Item_emprestimo Values (@ID_emprestimo, @ID_IL)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID_IL", exemplar.getId());
            Cmd.Parameters.AddWithValue("@ID_emprestimo", idEmprestimo);

            if (Cmd.ExecuteNonQuery() == 1) {
                Cmd.Connection.Close();
                return true;
            }
            else {
                Cmd.Connection.Close();
                return false;
            }

        }

        public List<EmprestimoModel> ListarTodos() {
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

            while (reader.Read()) {
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

        public List<EmprestimoModel> ListarEmprestimo(int id) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"
            SELECT E.*, F.Nome_Funcionario AS 'Funcionario', L.Nome_Leitor AS 'Leitor'
            FROM Emprestimo as E
            INNER JOIN Funcionario AS F ON (F.ID_funcionario = E.ID_funcionario)
            INNER JOIN Leitor as L ON (L.ID_leitor = E.ID_leitor)
            WHERE E.ID_emprestimo = '" + id + "'";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EmprestimoModel> lista = new List<EmprestimoModel>();

            while (reader.Read()) {
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
                leitor.Obs = (String)reader["Obs_emprestimo"];
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

        public List<EmprestimoPesquisaModel> ListarTodosBusca() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT E.ID_emprestimo, L.Nome_Leitor, Li.Nome_Livro, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.status
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.ID_funcionario = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.ID_leitor = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.ID_emprestimo)
			                        INNER JOIN Item_livro AS IL ON (IL.ID_IL = IE.ID_IL)
			                        INNER JOIN Livro AS Li ON (Li.ID_livro = IL.ID_livro)";
                                    //SELECT E.ID_emprestimo, L.Nome_Leitor, Li.Nome_Livro, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.status
                                    //FROM Emprestimo as E
                                    //INNER JOIN Funcionario AS F ON (F.ID_funcionario = E.ID_funcionario)
                                    //INNER JOIN Leitor as L ON (L.ID_leitor = E.ID_leitor)
                                    //INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.ID_emprestimo)
                                    //INNER JOIN Livro as Li ON (Li.ID_livro = IE.ID_livro)
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<EmprestimoPesquisaModel> lista = new List<EmprestimoPesquisaModel>();

            while (reader.Read()) {
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

        private int quantidadeDisponiveis(int idLivro, int quantidade) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT COUNT(E.ID_emprestimo) AS Emprestimos
            FROM Item_livro AS IL
            INNER JOIN Item_emprestimo AS IE ON (IE.ID_IL= IL.ID_IL)
            INNER JOIN Emprestimo AS E ON (E.ID_emprestimo = IE.ID_emprestimo)
			inner join Livro as L ON (IL.ID_livro = L.ID_livro)
            WHERE E.Status='EMPRESTADO' AND L.ID_livro = '" + idLivro + "'";

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            while (reader.Read()) {
                int emprestimos = (int)reader["Emprestimos"];
                reader.Close();
                return quantidade - emprestimos;
            }
            return 0;
        }

        public List<LivroModel> ListarTodosLivros() {
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
                    //(int)reader["ID_livro"],
                    //(int)reader["ID_fornecedor"],
                    (int)reader["ID_Autor"],
                    (String)reader["Autor_Livro"],
                    (String)reader["Edicao"],
                    (String)reader["Ano_publicacao"],
                    (String)reader["ISBN"]
                    //(String)reader["Fornecedor"],
                    //(int)reader["Quantidade"]
                );
                lista.Add(livro);
            }
            reader.Close();

            for (int i = 0; i < lista.Count; i++) {
                int disponiveis = quantidadeDisponiveis(lista[i].getId(), lista[i].Quantidade);
                lista[i].Disponiveis = disponiveis;
            }

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
		                            F.Nome_fornecedor AS Fornecedor
                                From Item_livro AS IL
                                INNER JOIN Livro AS L ON (IL.ID_livro = L.ID_livro) 
                                INNER JOIN Fornecedor AS F ON (F.ID_fornecedor = L.ID_fornecedor)
                                WHERE IL.ID_livro = '" + idLivro + "'";
                                Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<ExemplarModel> lista = new List<ExemplarModel>();

            while (reader.Read()) {
                ExemplarModel exemplar = new ExemplarModel(
                    //int ID, String nome, String autor, String Edicao, String AnoPublicacao, String ISBN, String Fornecedor
                    (int)reader["ID"],
                    (String)reader["Nome"],
                    (String)reader["Autor"],
                    (String)reader["Edicao"],
                    (String)reader["AnoPublicacao"],
                    (String)reader["ISBN"],
                    (String)reader["Fornecedor"]
                );
                lista.Add(exemplar);
            }
            reader.Close();

            return lista;
        }

        public List<ExemplarModel> ListarTodosLivrosEmprestimo(int id) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT	IL.ID_IL AS ID,
                                L.Nome_Livro AS Nome,
	                            L.Autor_Livro AS Autor,
	                            L.Edicao,
	                            L.Ano_publicacao AS AnoPublicacao,
	                            L.ISBN,
	                            F.Nome_fornecedor AS Fornecedor
                            From Item_livro AS IL
                            INNER JOIN Livro AS L ON (IL.ID_livro = L.ID_livro) 
                            INNER JOIN Fornecedor AS F ON (F.ID_fornecedor = L.ID_fornecedor)
                            INNER JOIN Item_emprestimo AS IE ON (IE.ID_IL = IL.ID_IL)
                            INNER JOIN Emprestimo AS E ON (E.ID_emprestimo = IE.ID_emprestimo)
                            WHERE E.ID_emprestimo = '" + id + "'";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<ExemplarModel> lista = new List<ExemplarModel>();

            while (reader.Read()) {
                ExemplarModel exemplar = new ExemplarModel(
                    (int)reader["ID"],
                    (String)reader["Nome"],
                    (String)reader["Autor"],
                    (String)reader["Edicao"],
                    (String)reader["Anopublicacao"],
                    (String)reader["ISBN"],
                    (String)reader["Fornecedor"]
                );
                lista.Add(exemplar);
            }
            reader.Close();

            return lista;
        }

        public List<LivroModel> BuscarLivros(string busca) {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"
                SELECT L.*, F.Nome_fornecedor as Fornecedor 
                FROM Livro AS L
                INNER JOIN Fornecedor AS F ON (F.ID_fornecedor = L.ID_fornecedor)
                WHERE L.Nome_Livro LIKE '" + busca + "%'";

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LivroModel> lista = new List<LivroModel>();

            while (reader.Read()) {
                LivroModel livro = new LivroModel(
                    (int)reader["Id"],
                    (String)reader["Titulo"],
                    //(String)reader["Edicao"],
                    //(String)reader["Ano_publicacao"],
                    //(String)reader["ISBN"],
                    //(int)reader["Quantidade"],
                    (String)reader["Nome_Editora"],
                    (String)reader["Nome_Autor"],
                    (String)reader["Nome_Genero"]
                );
                lista.Add(livro);
            }
            reader.Close();

            return lista;
        }

        public void InserirExemplarEmprestimo(ExemplarModel exemplar) {
            this.singleton.setExemplar(exemplar);
            this.singleton.setAddExemplar(true);
        }

        public List<ExemplarModel> PegarExemplarEmprestimo() {
            return this.singleton.getExemplar();
        }

        public void RemoverExemplarEmprestimo(ExemplarModel exemplar) {
            this.singleton.removerExemplarLista(exemplar);
        }

        public void InserirLeitorEmprestimo(LeitorModel leitor) {
            this.singleton.setLeitor(leitor);
        }

        public void RemoverLeitorEmprestimo() {
            this.singleton.setLeitor(null);
        }

        public List<LeitorModel> PegarLeitorEmprestimo() {
            List<LeitorModel> lista = new List<LeitorModel>();
            lista.Add(this.singleton.getLeitor());
            return lista;
        }

        public List<LeitorModel> ListarTodosLeitores() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Leitor";
            Cmd.Parameters.Clear();

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
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

        public List<LeitorModel> BuscarLeitor(string busca) {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"SELECT * FROM LEITOR WHERE Nome_Leitor LIKE '" + busca + "%'";

            Cmd.Parameters.Clear();

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
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }
        public List<LeitorModel> BuscarLeitor(string busca, bool isNome = false, bool isCPF = false) {
            Cmd.Connection = connection.RetornaConexao();

            if (isNome) {
                Cmd.CommandText = @"SELECT * FROM LEITOR WHERE Nome_Leitor LIKE '" + busca + "%'";
            }

            if (isCPF) {
                Cmd.CommandText = @"SELECT * FROM LEITOR WHERE CPF LIKE '" + busca + "%'";
            }

            Cmd.Parameters.Clear();

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
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }
        public List<EmprestimoPesquisaModel> BuscarCodigo(string busca, bool isCodigo = false) {
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

            while (reader.Read()) {
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
        public List<EmprestimoPesquisaModel> Buscar(string busca, bool isLivro = false, bool isLeitor = false, bool isCodigo = false) {
            Cmd.Connection = connection.RetornaConexao();

            if (isLivro) {
                Cmd.CommandText = @"SELECT E.ID_emprestimo, L.Nome_Leitor, Li.Nome_Livro, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Status
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.ID_funcionario = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.ID_leitor = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.ID_emprestimo)
                                    INNER JOIN Livro as Li ON (Li.ID_livro = IE.ID_livro)
                                    WHERE Li.Nome_Livro LIKE '" + busca + "%'";
            }

            if (isLeitor) {
                Cmd.CommandText = @"SELECT E.ID_emprestimo, L.Nome_Leitor, Li.Nome_Livro, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao, E.Status
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.ID_funcionario = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.ID_leitor = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.ID_emprestimo)
                                    INNER JOIN Livro as Li ON (Li.ID_livro = IE.ID_livro)
                                    WHERE L.Nome_Leitor LIKE '" + busca + "%'";
            }
            if (isCodigo) {
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

            while (reader.Read()) {
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

        public bool Excluir(EmprestimoPesquisaModel emprestimo) {
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

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        public bool Devolucao(EmprestimoPesquisaModel emprestimo) {
            // mudar status emprestimo
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Emprestimo SET Status = @Status
                                WHERE ID_emprestimo = @ID";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Status", "DEVOLVIDO");
            Cmd.Parameters.AddWithValue("@ID", emprestimo.ID_emprestimo);

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        public List<EmprestimoModel> Relatorio(DateTime inicio, DateTime fim) {
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

            while (reader.Read()) {
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
