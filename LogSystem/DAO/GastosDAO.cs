using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogSystem.Estruturas;

namespace LogSystem.DAO
{
    public class GastosDAO
    {
        public bool tem = false;
        private Conexao conexao = new Conexao();
        private SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public string CadastrarGastos(GastosEstrutura _gastosEstrutura)
        {
            cmd.CommandText = "INSERT INTO tb_Gastos VALUES (@categoria,@titulo,@tipo)";
            cmd.Parameters.AddWithValue("@categoria", _gastosEstrutura.gst_Categoria);
            cmd.Parameters.AddWithValue("@titulo", _gastosEstrutura.gst_Titulo);
            cmd.Parameters.AddWithValue("@tipo", _gastosEstrutura.gst_Tipo);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Cadastrado com  Sucesso!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro com o Banco de Dados  \n\n\n" + e;
            }

            return mensagem;
        }

        public string AlterarGastos(GastosEstrutura _gastosEstrutura)
        {
            cmd.CommandText = "UPDATE tb_Gastos SET  gst_Categoria = @categoria, gst_Titulo = @titulo, gst_Tipo = @tipo WHERE gst_Codigo = @id";
            cmd.Parameters.AddWithValue("@categoria", _gastosEstrutura.gst_Categoria);
            cmd.Parameters.AddWithValue("@titulo", _gastosEstrutura.gst_Titulo);
            cmd.Parameters.AddWithValue("@tipo", _gastosEstrutura.gst_Tipo);
            cmd.Parameters.AddWithValue("@id", _gastosEstrutura.gst_Codigo);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Alterado com Sucesso!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro com o Banco de Dados \n\n\n " + e;
            }

            return mensagem;
        }

        public string DeletarGastos(int id)
        {
            cmd.CommandText = "DELETE FROM tb_Gastos WHERE gst_Codigo = @id";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Gastos Deletado com Sucesso!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro com o Banco de Dados! \n\n" + e;
            }

            return mensagem;
        }
    }
}