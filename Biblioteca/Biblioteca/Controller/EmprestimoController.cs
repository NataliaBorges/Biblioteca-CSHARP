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
        private SqlCommand Cmd { get; set;  }

        Singleton singleton = Singleton.GetInstancia();

        public EmprestimoController() {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }

        // CADASTRAR NOVO EMPRESTIMO
        public bool Insercao(String dataEmprestimo, String dataDevolucao, String obs) {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"INSERT INTO Emprestimo Values (@ID_funcionario, @ID_leitor, @Data_emprestimo, @Data_devolucao, @Obs_emprestimo)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID_funcionario", this.singleton.getFuncionario().getId());
            Cmd.Parameters.AddWithValue("@ID_leitor", this.singleton.getLeitor().getId());
            Cmd.Parameters.AddWithValue("@Data_emprestimo", dataEmprestimo);
            Cmd.Parameters.AddWithValue("@Data_devolucao", dataDevolucao);
            Cmd.Parameters.AddWithValue("@Obs_emprestimo", obs);

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            } else {
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

        // RELACIONAR LIVROS SELECIONADO NO EMPRESTIMO
        public bool RelacionarLivrosEmprestimo(int idEmprestimo, LivroModel livro) {
            Cmd.Connection = connection.RetornaConexao();

            if(Cmd.Connection.State != System.Data.ConnectionState.Open)
                Cmd.Connection.Open();

            Cmd.CommandText = @"INSERT INTO Item_emprestimo Values (@ID_livro, @ID_emprestimo)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID_livro", livro.getId());
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
                    (String)reader["Funcionario"]
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
            WHERE E.ID_emprestimo = '"+id+"'";
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
                    (String)reader["Funcionario"]
                );
                leitor.Obs = (String)reader["Obs_emprestimo"];
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

        public List<EmprestimoPesquisaModel> ListarTodosBusca() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"
            SELECT E.ID_emprestimo, L.Nome_Leitor, Li.Nome_Livro, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao
            FROM Emprestimo as E
            INNER JOIN Funcionario AS F ON (F.ID_funcionario = E.ID_funcionario)
            INNER JOIN Leitor as L ON (L.ID_leitor = E.ID_leitor)
            INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.ID_emprestimo)
            INNER JOIN Livro as Li ON (Li.ID_livro = IE.ID_livro)
            ";
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
                    (DateTime)reader["Data_emprestimo"]
                );
                lista.Add(pesquisa);
            }
            reader.Close();

            return lista;
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
                    (int)reader["ID_livro"],
                    (int)reader["ID_fornecedor"],
                    (String)reader["Nome_Livro"],
                    (String)reader["Autor_Livro"],
                    (String)reader["Edicao"],
                    (String)reader["Ano_publicacao"],
                    (DateTime)reader["Data_aquisicao"],
                    (String)reader["Fornecedor"]
                );
                lista.Add(livro);
            }
            reader.Close();

            return lista;
        }

        public List<LivroModel> ListarTodosLivrosEmprestimo(int id) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"
            SELECT L.*, F.Nome_fornecedor as Fornecedor 
            FROM Livro AS L
            INNER JOIN Fornecedor AS F ON (F.ID_fornecedor = L.ID_fornecedor)
            INNER JOIN Item_emprestimo AS IE ON (IE.ID_livro = L.ID_livro)
            INNER JOIN Emprestimo AS E ON (E.ID_emprestimo = IE.ID_emprestimo)
            WHERE E.ID_emprestimo = '"+id+"'";
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
                    (String)reader["Fornecedor"]
                );
                lista.Add(livro);
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
                    (int)reader["ID_livro"],
                    (int)reader["ID_fornecedor"],
                    (String)reader["Nome_Livro"],
                    (String)reader["Autor_Livro"],
                    (String)reader["Edicao"],
                    (String)reader["Ano_publicacao"],
                    (DateTime)reader["Data_aquisicao"],
                    (String)reader["Fornecedor"]
                );
                lista.Add(livro);
            }
            reader.Close();

            return lista;
        }

        public void InserirLivroEmprestimo(LivroModel livro) {
            this.singleton.setLivro(livro);
        }

        public List<LivroModel> PegarLivrosEmprestimo() {
            return this.singleton.getLivros();
        }

        public void RemoverLivroEmprestimo(LivroModel livro) {
            this.singleton.removerLivroLista(livro);
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
                    (String)reader["Endereco"]
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
                    (String)reader["Endereco"]
                );
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

        public List<EmprestimoPesquisaModel> Buscar(string busca, bool isLivro = false, bool isLeitor = false) {
            Cmd.Connection = connection.RetornaConexao();

            if (isLivro) {
                Cmd.CommandText = @"SELECT E.ID_emprestimo, L.Nome_Leitor, Li.Nome_Livro, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.ID_funcionario = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.ID_leitor = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.ID_emprestimo)
                                    INNER JOIN Livro as Li ON (Li.ID_livro = IE.ID_livro)
                                    WHERE Li.Nome_Livro LIKE '" + busca + "%'";
            }

            if (isLeitor) {
                Cmd.CommandText = @"SELECT E.ID_emprestimo, L.Nome_Leitor, Li.Nome_Livro, F.Nome_funcionario, E.Data_emprestimo, E.Data_devolucao
                                    FROM Emprestimo as E
                                    INNER JOIN Funcionario AS F ON (F.ID_funcionario = E.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.ID_leitor = E.ID_leitor)
                                    INNER JOIN Item_emprestimo AS IE ON (IE.ID_emprestimo = E.ID_emprestimo)
                                    INNER JOIN Livro as Li ON (Li.ID_livro = IE.ID_livro)
                                    WHERE L.Nome_Leitor LIKE '" + busca + "%'";
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
                    (DateTime)reader["Data_emprestimo"]
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

    }
}
