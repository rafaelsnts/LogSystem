using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.DAO
{
    public class Conexao
    {
        private SqlConnection conexao;
        private string connectionString = @"Server=RAFAEL\SQLEXPRESS;Database=LogSystem;Trusted_Connection=True;";

        public Conexao()
        {
            // conexao.ConnectionString = @"Server=RAFAEL\SQLEXPRESS;Database=LogSystem;Trusted_Connection=True;";
        }

        public SqlConnection Conectar()
        {
            conexao = new SqlConnection(connectionString);
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }

        public void Desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}