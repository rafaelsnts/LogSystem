using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogSystem.Estruturas;

namespace LogSystem.DAO
{
    public class NotasFiscaisDAO
    {
        public bool tem = false;
        private Conexao conexao = new Conexao();
        private SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public string NotaFiscal(NFEstrutura _nfEstrutura, int _idVenda)
        {
            cmd.CommandText = "INSERT INTO tb_NotasFiscais VALUES (@numeroNf,@dataNF,@idVenda)";
            cmd.Parameters.AddWithValue("@numeroNf", _nfEstrutura.nf_Numero);
            cmd.Parameters.AddWithValue("@dataNF", _nfEstrutura.nf_Data);
            cmd.Parameters.AddWithValue("@idVenda", _idVenda);
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro com o Banco de Dados  \n\n\n" + e;
            }

            return mensagem;
        }
    }
}