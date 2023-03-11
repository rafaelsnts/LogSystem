using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using LogSystem.Estruturas;

namespace LogSystem.DAO
{
    internal class ProdutoDAO
    {
        public bool tem = false;
        private Conexao conexao = new Conexao();
        private SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public string CadastrarGrupoProduto(GrupoProdutoEstrutura _grupoProdutoEstrutura)
        {
            cmd.CommandText = "insert into tb_GrupoProduto values (@grupo)";

            cmd.Parameters.AddWithValue("@grupo", _grupoProdutoEstrutura.cl_Grupo);
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Grupo cadastrado com sucesso!!!";
            }
            catch (SqlException exception)
            {
                this.mensagem = "Erro com o Banco de Dados!!! \n\n" + exception;
            }

            return mensagem;
        }

        public List<string> BuscarIdGrupoProdutos()
        {
            List<string> GrupoProdutos = new List<string>();

            using (SqlConnection connection = conexao.Conectar())
            {
                string Querry = "SELECT cl_Grupo from tb_GrupoProduto ORDER BY cl_Grupo ASC";

                SqlCommand    cmd = new SqlCommand(Querry, connection);
                SqlDataReader dr;

                dr = cmd.ExecuteReader();

                //dr.Read();

                while (dr.Read())
                {
                    GrupoProdutos.Add(dr.GetString(0));
                }

                return GrupoProdutos;
            }
        }

        public List<string> BuscarIdSubGrupoProdutos()
        {
            List<string> SubGrupoProdutos = new List<string>();

            using (SqlConnection connection = conexao.Conectar())
            {
                string Querry = "SELECT cl_SubGrupo from tb_SubGrupoProduto ORDER BY cl_SubGrupo ASC";

                SqlCommand    cmd = new SqlCommand(Querry, connection);
                SqlDataReader dr;

                dr = cmd.ExecuteReader();

                //dr.Read();

                while (dr.Read())
                {
                    SubGrupoProdutos.Add(dr.GetString(0));
                }

                return SubGrupoProdutos;
            }
        }

        public string CadastrarSubGrupoProduto(SubGrupoProdutoEstrutura _subGrupoProdutoEstrutura)
        {
            cmd.CommandText = "insert into tb_SubGrupoProduto values (@subGrupo)";

            cmd.Parameters.AddWithValue("@subGrupo", _subGrupoProdutoEstrutura.cl_SubGrupo);
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "SubGrupo cadastrado com sucesso!!!";
            }
            catch (SqlException exception)
            {
                this.mensagem = "Erro com o Banco de Dados!!! \n\n" + exception;
            }

            return mensagem;
        }

        public int BuscarIdGrupoProduto(string nomeGrupoProduto)
        {
            using (SqlConnection cn = conexao.Conectar())
            {
                string     sqlQuerry = "select cl_id from tb_GrupoProduto where cl_Grupo = @nomeGrupoProduto";
                SqlCommand cmd       = new SqlCommand(sqlQuerry, cn);
                cmd.Parameters.AddWithValue("@nomeGrupoProduto", nomeGrupoProduto);
                SqlDataReader dr;

                dr = cmd.ExecuteReader();
                dr.Read();

                return dr.GetInt32(0);
            }
        }

        public int BuscarIdSubGrupoProduto(string nomeSubGrupoProduto)
        {
            using (SqlConnection cn = conexao.Conectar())
            {
                string     sqlQuerry = "select cl_id from tb_SubGrupoProduto where cl_SubGrupo = @nomeSubGrupoProduto";
                SqlCommand cmd       = new SqlCommand(sqlQuerry, cn);
                cmd.Parameters.AddWithValue("@nomeSubGrupoProduto", nomeSubGrupoProduto);
                SqlDataReader dr;

                dr = cmd.ExecuteReader();
                dr.Read();

                return dr.GetInt32(0);
            }
        }

        public string CadastrarProduto(ProdutoEstrutura _produtoEstrutura, GrupoProdutoEstrutura _grupoProdutoEstrutura, SubGrupoProdutoEstrutura _subGrupoProdutoEstrutura)
        {
            cmd.CommandText = "insert into tb_Produto values (" + "@codBarras," + "@descricao," + "@unidade," + "@precoCompra," + "@margem," + "@lucro," + "@precoVenda," + "@precoPrazo," + "@idGrupo," + "@idSubGrupo," + "@fornecedor," + "@estoqueMinimo," + "@garantia," + "@marca," + "@referencia," + "@dataValidade," + "@comissao," + "@observacoes," + "@estoqueAtual," + "@imagem)";
            cmd.Parameters.AddWithValue("@codBarras", _produtoEstrutura.cl_CodigoBarras);
            cmd.Parameters.AddWithValue("@descricao", _produtoEstrutura.cl_Descricao);
            cmd.Parameters.AddWithValue("@unidade", _produtoEstrutura.cl_Unidade);
            cmd.Parameters.AddWithValue("@precoCompra", _produtoEstrutura.cl_PrecoCompra);
            cmd.Parameters.AddWithValue("@margem", _produtoEstrutura.cl_Margem);
            cmd.Parameters.AddWithValue("@lucro", _produtoEstrutura.cl_Lucro);
            cmd.Parameters.AddWithValue("@precoVenda", _produtoEstrutura.cl_PrecoVenda);
            cmd.Parameters.AddWithValue("@precoPrazo", _produtoEstrutura.cl_PrecoAPrazo);
            cmd.Parameters.AddWithValue("@idGrupo", _grupoProdutoEstrutura.cl_Grupo);
            cmd.Parameters.AddWithValue("@idSubGrupo", _subGrupoProdutoEstrutura.cl_SubGrupo);
            cmd.Parameters.AddWithValue("@fornecedor", _produtoEstrutura.cl_Fornecedor);
            cmd.Parameters.AddWithValue("@estoqueMinimo", _produtoEstrutura.cl_EstoqueMinimo);
            cmd.Parameters.AddWithValue("@garantia", _produtoEstrutura.cl_Garantia);
            cmd.Parameters.AddWithValue("@marca", _produtoEstrutura.cl_Marca);
            cmd.Parameters.AddWithValue("@referencia", _produtoEstrutura.cl_Referencia);
            cmd.Parameters.AddWithValue("@dataValidade", _produtoEstrutura.cl_DataValidade);
            cmd.Parameters.AddWithValue("@comissao", _produtoEstrutura.cl_Comissao);
            cmd.Parameters.AddWithValue("@observacoes", _produtoEstrutura.cl_Observacoes);
            cmd.Parameters.AddWithValue("@estoqueAtual", _produtoEstrutura.cl_EstoqueAtual);
            cmd.Parameters.AddWithValue("@imagem", _produtoEstrutura.cl_Imagem);
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Produto cadastrado com sucesso!!!";
            }
            catch (SqlException exception)
            {
                this.mensagem = "Erro com o Banco de Dados!!! \n\n" + exception;
            }

            return mensagem;
        }
    }
}