using Biblioteca.Model;
using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    }
}
