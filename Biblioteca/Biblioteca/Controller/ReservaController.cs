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
        public bool Insercao(DateTime dataReserva, DateTime dataRetirada) {
            try
            {
                Cmd.Connection = connection.RetornaConexao();

                Cmd.CommandText = @"INSERT INTO Reserva Values (@Retirada, @Reserva, @Leitor, @Funcionario, @Status, @Finalizado)";

                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Retirada", dataRetirada.ToString("yyyy-MM-dd"));
                Cmd.Parameters.AddWithValue("@Reserva", dataReserva.ToString("yyyy-MM-dd"));
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

        // BUSCAR ÚLTIMO RESERVA CADASTRADO PARA PODER PEGAR O ID DO MESMO
        public int BuscarUltimoReserva() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Reserva ORDER BY Id DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            int idReserva = 0;

            while (reader.Read()) {
                idReserva = (int)reader["Id"];
            }
            reader.Close();
            return idReserva;
        }

        // RELACIONAR LIVROS SELECIONADO NO EMPRESTIMO
        public bool RelacionarExemplarReserva(int idReserva, ExemplarModel exemplar) {
            Cmd.Connection = connection.RetornaConexao();

            if (Cmd.Connection.State != System.Data.ConnectionState.Open)
                Cmd.Connection.Open();

            Cmd.CommandText = @"INSERT INTO Item_reserva Values (@Exemplar, @Reserva, @Status)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Exemplar", exemplar.getId());
            Cmd.Parameters.AddWithValue("@Reserva", idReserva);
            Cmd.Parameters.AddWithValue("@Status", 4);

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
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

        //public List<ReservaPesquisaModel> ListarTodosBusca() {
            //Cmd.Connection = connection.RetornaConexao();
            //Cmd.CommandText = @"
            //SELECT R.ID_reserva, L.Nome_Leitor, Li.Nome_Livro, F.Nome_funcionario, R.Data_reserva
            //FROM Reserva as R
            //INNER JOIN Funcionario AS F ON (F.ID_funcionario = R.ID_funcionario)
            //INNER JOIN Leitor as L ON (L.ID_leitor = R.ID_leitor)
            //INNER JOIN Item_reserva AS IE ON (IE.ID_reserva = R.ID_reserva)
            //INNER JOIN Livro as Li ON (Li.ID_livro = IE.ID_livro)
            //";
            //Cmd.Parameters.Clear();

            //SqlDataReader reader = Cmd.ExecuteReader();

            //List<ReservaPesquisaModel> lista = new List<ReservaPesquisaModel>();

            //while (reader.Read()) {
            //    ReservaPesquisaModel pesquisa = new ReservaPesquisaModel(
            //        (int)reader["ID_reserva"],
            //        (String)reader["Nome_Leitor"],
            //        (String)reader["Nome_Livro"],
            //        (String)reader["Nome_funcionario"],
            //        (DateTime)reader["Data_reserva"]
            //    );
            //    lista.Add(pesquisa);
            //}
            //reader.Close();

            //return lista;
       //}

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

        public bool InserirExemplarReserva(ExemplarModel exemplar)
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

        public LeitorModel PegarLeitorReserva() {
            return this.singleton.getLeitor();
        }

        public List<LeitorModel> ListarTodosLeitores() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Leitor";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<LeitorModel> lista = new List<LeitorModel>();

            while (reader.Read()) {
                LeitorModel leitor = new LeitorModel(
                    (int)reader["Id"],
                    (String)reader["Nome_Leitor"],
                    (DateTime)reader["Data_Nascimento"],
                    (String)reader["CPF"],
                    (String)reader["Telefone"],
                    (String)reader["Endereco"],
                    (String)reader["Email"],
                    (int)reader["Estado"]
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

        public int QuantidadeDeExemplar()
        {
            return this.singleton.getExemplar().Count;
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

        public int quantidadeReservadosLeitor(int id)
        {
            Cmd.ExecuteReader().Close();
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT COUNT(Reserva.ID) AS Quantidade
                                FROM Leitor
                                INNER JOIN Reserva ON (Reserva.Id_leitor = Leitor.Id)
                                INNER JOIN Status_Emprestimo ON (Status_Emprestimo.Id = Reserva.Id_reservaStatus)
                                WHERE Leitor.Id = '" + id + "' AND Reserva.Id_reservaStatus = 1";
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

        // multa de 2 dias por livro, não deixar reservar
        public int leitorPossuiMultaReserva(int id)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @$"SELECT SUM(DATEDIFF(day, Reserva.Data_PegarLivro, '{DateTime.Now.ToString("yyyy-MM-dd")}')) AS Diferenca
                                FROM Leitor
                                INNER JOIN Reserva ON (Reserva.Id_leitor = Leitor.Id)
                                INNER JOIN Status_Reserva ON (Status_Reserva.Id = Reserva.Id_reservaStatus)
                                WHERE Leitor.Id = '{id}' AND Reserva.Id_reservaStatus = 1 AND Reserva.Data_PegarLivro > '{DateTime.Now.AddDays(7)}'";
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

        public Nullable<DateTime> BuscarUltimoEmprestimoComAtrasoReserva(int id)
        {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @$"SELECT * FROM Reserva WHERE Reserva.Id_leitor = '{id}' AND Reserva.Id_reservaStatus = 1 AND Reserva.Data_PegarLivro > '{DateTime.Now.AddDays(7)}' ORDER BY Id DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            DateTime dataFinalizado = DateTime.Now;

            while (reader.Read())
            {
                dataFinalizado = (DateTime)reader["Data_PegarLivro"];
            }

            reader.Close();

            return dataFinalizado;
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

    }
}
