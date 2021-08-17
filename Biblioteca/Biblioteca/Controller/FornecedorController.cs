using Biblioteca.Util;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Biblioteca.Model;
using System.Globalization;
using System.Collections.Generic;

namespace Biblioteca.Controller {
    class FornecedorController {

        private Conexao connection { get; set; }
        private SqlCommand Cmd { get; set;  }

        Singleton singleton = Singleton.GetInstancia();

        public FornecedorController() {
            connection = new Conexao();
            Cmd = new SqlCommand();
        }

        public bool Insercao(FornecedorModel fornecedor) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"INSERT INTO Fornecedor Values (@Nome_fornecedor, @Endereco, @Telefone, @CNPJ)";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Nome_fornecedor", fornecedor.Nome);
            Cmd.Parameters.AddWithValue("@Endereco", fornecedor.Endereco);
            Cmd.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);
            Cmd.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            } else {
                return false;
            }
        }

        public bool Atualizar(FornecedorModel fornecedor) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"UPDATE Fornecedor SET Nome_fornecedor = @Nome_fornecedor,  
                                Endereco = @Endereco, Telefone = @Telefone, CNPJ = @CNPJ
                                WHERE ID_fornecedor = @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", fornecedor.getId());
            Cmd.Parameters.AddWithValue("@Nome_fornecedor", fornecedor.Nome);
            Cmd.Parameters.AddWithValue("@Endereco", fornecedor.Endereco);
            Cmd.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);
            Cmd.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        public List<FornecedorModel> ListarTodos() {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"SELECT * FROM Fornecedor";
            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<FornecedorModel> lista = new List<FornecedorModel>();

            while (reader.Read()) {
                FornecedorModel leitor = new FornecedorModel(
                    (int)reader["ID_fornecedor"],
                    (String)reader["Nome_fornecedor"],
                    (String)reader["Endereco"],
                    (String)reader["Telefone"],
                    (String)reader["CNPJ"]
                );
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

        public List<FornecedorModel> Buscar(string busca, bool isNome = false, bool isCNPJ = false) {
            Cmd.Connection = connection.RetornaConexao();

            if (isNome) {
                Cmd.CommandText = @"SELECT * FROM Fornecedor WHERE Nome_fornecedor LIKE '"+busca+"%'";
            }

            if (isCNPJ) {
                Cmd.CommandText = @"SELECT * FROM Fornecedor WHERE CNPJ LIKE '" + busca+"%'";
            }

            Cmd.Parameters.Clear();

            SqlDataReader reader = Cmd.ExecuteReader();

            List<FornecedorModel> lista = new List<FornecedorModel>();

            while (reader.Read()) {
                FornecedorModel leitor = new FornecedorModel(
                    (int)reader["ID_fornecedor"],
                    (String)reader["Nome_fornecedor"],
                    (String)reader["Endereco"],
                    (String)reader["Telefone"],
                    (String)reader["CNPJ"]
                );
                lista.Add(leitor);
            }
            reader.Close();

            return lista;
        }

        public bool Excluir(FornecedorModel fornecedor) {
            Cmd.Connection = connection.RetornaConexao();
            Cmd.CommandText = @"DELETE FROM Fornecedor WHERE ID_fornecedor= @ID";

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID", fornecedor.getId());

            if (Cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            else {
                return false;
            }
        }

    }
}
