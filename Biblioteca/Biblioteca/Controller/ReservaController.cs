using Biblioteca.Util;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Biblioteca.Model;
using System.Globalization;
using System.Collections.Generic;

namespace Biblioteca.Controller {
    class ReservaController {

        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set;  }

        Singleton singleton = Singleton.GetInstancia();

        public ReservaController() {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }

        // CADASTRAR NOVA RESERVA
        public bool Insercao(String dataReserva, String obs) {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"INSERT INTO Reserva Values (@ID_funcionario, @ID_leitor, @Data_reserva, @Obs_reserva)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID_funcionario", this.singleton.getFuncionario().getId());
            Cmd.Parameters.AddWithValue("@ID_leitor", this.singleton.getLeitor().getId());
            Cmd.Parameters.AddWithValue("@Data_reserva", dataReserva);
            Cmd.Parameters.AddWithValue("@Obs_reserva", obs);

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            } else {
                return false;
            }
        }

        // BUSCAR ÚLTIMO RESERVA CADASTRADO PARA PODER PEGAR O ID DO MESMO
        public int BuscarUltimoReserva() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Reserva ORDER BY ID_reserva DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            while (reader.Read()) {
                int idEmprestimo = (int)reader["ID_reserva"];
                reader.Close();
                return idEmprestimo;
            }
            

            return 0; 
        }

        // RELACIONAR LIVROS SELECIONADO NO EMPRESTIMO
        public bool RelacionarExemplarReserva(int idReserva, ExemplarModel exemplar) {
            Cmd.Connection = connection.RetornaConexao();

            if(Cmd.Connection.State != System.Data.ConnectionState.Open)
                Cmd.Connection.Open();

            Cmd.CommandText = @"INSERT INTO Item_reserva Values (@ID_IL, @ID_reserva, @Obs_item)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID_IL", exemplar.getId());
            Cmd.Parameters.AddWithValue("@ID_reserva", idReserva);
            Cmd.Parameters.AddWithValue("@Obs_item", "");

            if (Cmd.ExecuteNonQuery() == 1) {
                Cmd.Connection.Close();
                return true;
            }
            else {
                Cmd.Connection.Close();
                return false;
            }
            
        }

        public List<ReservaModel> ListarTodos() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"
            SELECT R.*, F.Nome_Funcionario AS 'Funcionario', L.Nome_Leitor AS 'Leitor'
            FROM Reserva as R
            INNER JOIN Funcionario AS F ON (F.ID_funcionario = R.ID_funcionario)
            INNER JOIN Leitor as L ON (L.ID_leitor = R.ID_leitor)
            ";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<ReservaModel> lista = new List<ReservaModel>();

            while (reader.Read()) {
                ReservaModel leitor = new ReservaModel(
                    (int)reader["ID_reserva"],
                    (int)reader["ID_funcionario"],
                    (int)reader["ID_leitor"],
                    (DateTime)reader["Data_reserva"],
                    (String)reader["Leitor"],
                    (String)reader["Funcionario"]
                );
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

        public List<ReservaModel> ListarReserva(int id) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"
            SELECT R.*, F.Nome_Funcionario AS 'Funcionario', L.Nome_Leitor AS 'Leitor'
            FROM Reserva as R
            INNER JOIN Funcionario AS F ON (F.ID_funcionario = R.ID_funcionario)
            INNER JOIN Leitor as L ON (L.ID_leitor = R.ID_leitor)
            WHERE R.ID_reserva = '"+id+"'";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<ReservaModel> lista = new List<ReservaModel>();

            while (reader.Read()) {
                ReservaModel leitor = new ReservaModel(
                    (int)reader["ID_reserva"],
                    (int)reader["ID_funcionario"],
                    (int)reader["ID_leitor"],
                    (DateTime)reader["Data_reserva"],
                    (String)reader["Leitor"],
                    (String)reader["Funcionario"]
                );
                leitor.Obs = (String)reader["Obs_reserva"];
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

        public List<ReservaPesquisaModel> ListarTodosBusca() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"
            SELECT R.ID_reserva, L.Nome_Leitor, Li.Nome_Livro, F.Nome_funcionario, R.Data_reserva
            FROM Reserva as R
            INNER JOIN Funcionario AS F ON (F.ID_funcionario = R.ID_funcionario)
            INNER JOIN Leitor as L ON (L.ID_leitor = R.ID_leitor)
            INNER JOIN Item_reserva AS IE ON (IE.ID_reserva = R.ID_reserva)
            INNER JOIN Livro as Li ON (Li.ID_livro = IE.ID_livro)
            ";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<ReservaPesquisaModel> lista = new List<ReservaPesquisaModel>();

            while (reader.Read()) {
                ReservaPesquisaModel pesquisa = new ReservaPesquisaModel(
                    (int)reader["ID_reserva"],
                    (String)reader["Nome_Leitor"],
                    (String)reader["Nome_Livro"],
                    (String)reader["Nome_funcionario"],
                    (DateTime)reader["Data_reserva"]
                );
                lista.Add(pesquisa);
            }
            reader.Close();

            return lista;
        }

        public List<LivroModel> ListarTodosLivros() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"
            SELECT L.*, F.Nome_fornecedor as Editora 
            FROM Livro AS L
            INNER JOIN Editora AS F ON (F.ID_fornecedor = L.ID_fornecedor)
            ";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LivroModel> lista = new List<LivroModel>();

            //while (reader.Read()) {
            //    LivroModel livro = new LivroModel(
            //        //(int)reader["Id"],
            //        //(String)reader["Titulo"],
            //        //(String)reader["Nome_Editora"],
            //        //(String)reader["Nome_Autor"],
            //        //(String)reader["Nome_Genero"]
            //    );
            //    lista.Add(livro);
            //}
            reader.Close();

            return lista;
        }

        public List<LivroModel> ListarTodosLivrosReserva(int id) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"
            SELECT L.*, F.Nome_fornecedor as Editora 
            FROM Livro AS L
            INNER JOIN Editora AS F ON (F.ID_fornecedor = L.ID_fornecedor)
            INNER JOIN Item_reserva AS IE ON (IE.ID_livro = L.ID_livro)
            INNER JOIN Reserva AS E ON (E.ID_reserva = IE.ID_reserva)
            WHERE E.ID_reserva = '" + id+"'";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LivroModel> lista = new List<LivroModel>();

            while (reader.Read()) {
                LivroModel livro = new LivroModel(
                    (int)reader["Id"],
                    (String)reader["Titulo"],
                    (String)reader["Nome_Editora"],
                    (String)reader["Nome_Autor"],
                    (String)reader["Nome_Genero"]
                );
                lista.Add(livro);
            }
            reader.Close();

            return lista;
        }

        public List<LivroModel> BuscarLivros(string busca) {
            Cmd.Connection = connection.RetornaConexao();

            Cmd.CommandText = @"
                SELECT L.*, F.Nome_fornecedor as Editora 
                FROM Livro AS L
                INNER JOIN Editora AS F ON (F.ID_fornecedor = L.ID_fornecedor)
                WHERE L.Nome_Livro LIKE '" + busca + "%'";

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LivroModel> lista = new List<LivroModel>();

            while (reader.Read()) {
                LivroModel livro = new LivroModel(
                    (int)reader["Id"],
                    (String)reader["Titulo"],
                    (String)reader["Nome_Editora"],
                    (String)reader["Nome_Autor"],
                    (String)reader["Nome_Genero"]
                );
                lista.Add(livro);
            }
            reader.Close();

            return lista;
        }

        public void InserirExemplarReserva(ExemplarModel exemplar) {
            this.singleton.setExemplar(exemplar);
        }

        public List<ExemplarModel> PegarExemplarReserva() {
            return this.singleton.getExemplar();
        }

        public void RemoverExemplarReserva(ExemplarModel exemplar) {
            this.singleton.removerExemplarLista(exemplar);
        }

        public void InserirLeitorReserva(LeitorModel leitor) {
            this.singleton.setLeitor(leitor);
        }

        public void RemoverLeitorReserva() {
            this.singleton.setLeitor(null);
        }

        public List<LeitorModel> PegarLeitorReserva() {
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

        public List<ReservaPesquisaModel> Buscar(string busca, bool isLivro = false, bool isLeitor = false) {
            Cmd.Connection = connection.RetornaConexao();

            if (isLivro) {
                Cmd.CommandText = @"SELECT R.ID_reserva, L.Nome_Leitor, Li.Nome_Livro, F.Nome_funcionario, R.Data_reserva
                                    FROM Reserva as R
                                    INNER JOIN Funcionario AS F ON (F.ID_funcionario = R.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.ID_leitor = R.ID_leitor)
                                    INNER JOIN Item_reserva AS IE ON (IE.ID_reserva = R.ID_reserva)
                                    INNER JOIN Livro as Li ON (Li.ID_livro = IE.ID_livro)
                                    WHERE Li.Nome_Livro LIKE '" + busca + "%'";
            }

            if (isLeitor) {
                Cmd.CommandText = @"SELECT R.ID_reserva, L.Nome_Leitor, Li.Nome_Livro, F.Nome_funcionario, R.Data_reserva
                                    FROM Reserva as R
                                    INNER JOIN Funcionario AS F ON (F.ID_funcionario = R.ID_funcionario)
                                    INNER JOIN Leitor as L ON (L.ID_leitor = R.ID_leitor)
                                    INNER JOIN Item_reserva AS IE ON (IE.ID_reserva = R.ID_reserva)
                                    INNER JOIN Livro as Li ON (Li.ID_livro = IE.ID_livro)
                                    WHERE L.Nome_Leitor LIKE '" + busca + "%'";
            }

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<ReservaPesquisaModel> lista = new List<ReservaPesquisaModel>();

            while (reader.Read()) {
                ReservaPesquisaModel pesquisa = new ReservaPesquisaModel(
                    (int)reader["ID_reserva"],
                    (String)reader["Nome_Leitor"],
                    (String)reader["Nome_Livro"],
                    (String)reader["Nome_funcionario"],
                    (DateTime)reader["Data_reserva"]
                );
                lista.Add(pesquisa);
            }
            reader.Close();

            return lista;
        }

        public bool Excluir(ReservaPesquisaModel reserva) {
            // excluir itens em item_emprestimo
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"DELETE FROM Item_reserva WHERE ID_reserva = @ID";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", reserva.ID_reserva);
            Cmd.ExecuteNonQuery();

            // excluir emprestimo
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"DELETE FROM Reserva WHERE ID_reserva = @ID";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", reserva.ID_reserva);

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        public bool Devolucao(ReservaPesquisaModel reserva) {
            // mudar status emprestimo
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Emprestimo SET Status = @Status
                                WHERE ID_emprestimo = @ID";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Status", "DEVOLVIDO");
            Cmd.Parameters.AddWithValue("@ID", reserva.ID_reserva);

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
