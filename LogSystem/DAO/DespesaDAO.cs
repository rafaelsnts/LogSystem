using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogSystem.Estruturas;

namespace LogSystem.DAO
{
    internal class DespesaDAO
    {
        public bool tem = false;
        private Conexao conexao = new Conexao();
        private SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public Dictionary<int, string> BuscarTipoDespesa()
        {
            Dictionary<int, string> idTipo = new Dictionary<int, string>();
            using (SqlConnection cn = conexao.Conectar())
            {
                string        sqlQuerry = "SELECT DISTINCT des_Codigo, gst_Tipo from tb_Despesa INNER JOIN tb_Gastos ON tb_Gastos.gst_Codigo = fk_cl_Id_Gastos";
                SqlCommand    cmd       = new SqlCommand(sqlQuerry, cn);
                SqlDataReader dr;

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idTipo.Add(dr.GetInt32(0), dr.GetString(1));
                }

                return idTipo;
            }
        }

        public List<string> BuscarTipos()
        {
            List<string> idTipo = new List<string>();
            using (SqlConnection cn = conexao.Conectar())
            {
                string        sqlQuerry = "SELECT DISTINCT gst_Tipo from tb_Gastos";
                SqlCommand    cmd       = new SqlCommand(sqlQuerry, cn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idTipo.Add(dr.GetString(0));
                }

                return idTipo;
            }
        }

        public int BuscarIdTipo(string idTipo)
        {
            // List<string> idTipo = new List<string>();
            using (SqlConnection cn = conexao.Conectar())
            {
                string     sqlQuerry = "SELECT DISTINCT gst_Tipo from tb_Despesa INNER JOIN tb_Gastos ON tb_Gastos.gst_Codigo = @idTipo";
                SqlCommand cmd       = new SqlCommand(sqlQuerry, cn);
                cmd.Parameters.AddWithValue("@idTipo", idTipo);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                dr.Read();


                return dr.GetInt32(0);
            }
        }

        public int BuscarIdTipoDespesa(string idTipoDespesa)
        {
            // List<string> idTipo = new List<string>();
            using (SqlConnection cn = conexao.Conectar())
            {
                string     sqlQuerry = "SELECT DISTINCT gst_Tipo from tb_Despesa INNER JOIN tb_Gastos ON tb_Gastos.gst_Codigo = fk_cl_Id_Gastos";
                SqlCommand cmd       = new SqlCommand(sqlQuerry, cn);
                cmd.Parameters.AddWithValue("@idTipoDespesa", idTipoDespesa);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetInt32(0);
            }
        }

        public List<string> BuscarIdTituloDespesa()
        {
            List<string> idTitulo = new List<string>();
            using (SqlConnection cn = conexao.Conectar())
            {
                string        sqlQuerry = "SELECT DISTINCT gst_Titulo FROM tb_Gastos ORDER BY gst_Titulo ASC";
                SqlCommand    cmd       = new SqlCommand(sqlQuerry, cn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idTitulo.Add(dr.GetString(0));
                }
            }

            return idTitulo;
        }

        public List<string> BuscarDataVencimento()
        {
            List<string> dataVencimento = new List<string>();
            using (SqlConnection cn = conexao.Conectar())
            {
                string        sqlQuerry = "SELECT des_Vencimento FROM tb_Despesa ORDER BY des_Vencimento ASC";
                SqlCommand    cmd       = new SqlCommand(sqlQuerry, cn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataVencimento.Add(dr.GetString(0));
                }
            }

            return dataVencimento;
        }

        public string CadastrarDespesa(DespesaEstrutura _despesaEstrutura)
        {
            cmd.CommandText = "insert into tb_Despesa values (@tipo,@titulo,@descricao,@emissao,@vencimento,@frequencia,@valor)";
            cmd.Parameters.AddWithValue("@tipo", _despesaEstrutura.fk_Cl_Id_Gastos);
            cmd.Parameters.AddWithValue("@titulo", _despesaEstrutura.des_Titulo);
            cmd.Parameters.AddWithValue("@descricao", _despesaEstrutura.des_Descricao);
            cmd.Parameters.AddWithValue("@emissao", _despesaEstrutura.des_Emissao);
            cmd.Parameters.AddWithValue("@vencimento", _despesaEstrutura.des_Vencimento);
            cmd.Parameters.AddWithValue("@frequencia", _despesaEstrutura.des_Frequencia);
            cmd.Parameters.AddWithValue("@valor", _despesaEstrutura.des_Valor);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Cadastro Efetuado com Sucesso!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro com o Banco de Dados \n\n" + e;
            }

            return mensagem;
        }
    }
}