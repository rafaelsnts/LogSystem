using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogSystem.Estruturas;

namespace LogSystem.DAO
{
    internal class FornecedorDAO
    {
        public bool tem = false;
        private Conexao conexao = new Conexao();
        private SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public string CadastrarFornecedor(FornecedorEstrutura _fornecedorEstrutura)
        {
            cmd.CommandText = "insert into tb_Fornecedor values (@nomeFantasia,@razaoSocial,@cep,@endereco,@cidade,@cnpjCpf,@inscEstadual,@inscMunicipal,@telefone,@email,@imagem);";
            cmd.Parameters.AddWithValue("@nomeFantasia", _fornecedorEstrutura.cl_NomeFantasia);
            cmd.Parameters.AddWithValue("@razaoSocial", _fornecedorEstrutura.cl_RazaoSocial);
            cmd.Parameters.AddWithValue("@cep", _fornecedorEstrutura.cl_Cep);
            cmd.Parameters.AddWithValue("@endereco", _fornecedorEstrutura.cl_Endereco);
            cmd.Parameters.AddWithValue("@cidade", _fornecedorEstrutura.cl_Cidade);
            cmd.Parameters.AddWithValue("@cnpjCpf", _fornecedorEstrutura.cl_CnpjCpf);
            cmd.Parameters.AddWithValue("@inscEstadual", _fornecedorEstrutura.cl_InscricaoEstadual);
            cmd.Parameters.AddWithValue("@inscMunicipal", _fornecedorEstrutura.cl_InscricaoMunicipal);
            cmd.Parameters.AddWithValue("@telefone", _fornecedorEstrutura.cl_Telefone);
            cmd.Parameters.AddWithValue("@email", _fornecedorEstrutura.cl_Email);
            cmd.Parameters.AddWithValue("@imagem", _fornecedorEstrutura.cl_Imagem);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Fornecedor cadastrado com sucesso!!!";
            }
            catch (SqlException exception)
            {
                this.mensagem = "Erro com o banco de dados \n\n" + exception.Message;
            }
            return mensagem;
        }

        public string AlterarFornecedor(FornecedorEstrutura _fornecedorEstrutura)
        {
            cmd.CommandText = "UPDATE tb_Fornecedor SET " +
                              "cl_NomeFantasia = (@nomeFantasia), " +
                              "cl_RazaoSocial = (@razaoSocial), " +
                              "cl_Cep = (@cep), " +
                              "cl_Endereco = (@endereco), " +
                              "cl_Cidade = (@cidade), " +
                              "cl_CnpjCpf = (@cnpjCpf), " +
                              "cl_InscricaoEstadual = (@inscEst), " +
                              "cl_InscricaoMunicipal = (@inscMun), " +
                              "cl_Telefone = (@telefone), " +
                              "cl_Email = (@email), " +
                              "cl_Imagem = (@imagem) WHERE cl_Codigo = (@id)";

            cmd.Parameters.AddWithValue("@nomeFantasia", _fornecedorEstrutura.cl_NomeFantasia);
            cmd.Parameters.AddWithValue("@razaoSocial", _fornecedorEstrutura.cl_RazaoSocial);
            cmd.Parameters.AddWithValue("@cep", _fornecedorEstrutura.cl_Cep);
            cmd.Parameters.AddWithValue("@endereco", _fornecedorEstrutura.cl_Endereco);
            cmd.Parameters.AddWithValue("@cidade", _fornecedorEstrutura.cl_Cidade);
            cmd.Parameters.AddWithValue("@cnpjCpf", _fornecedorEstrutura.cl_CnpjCpf);
            cmd.Parameters.AddWithValue("@inscEst", _fornecedorEstrutura.cl_InscricaoEstadual);
            cmd.Parameters.AddWithValue("@inscMun", _fornecedorEstrutura.cl_InscricaoMunicipal);
            cmd.Parameters.AddWithValue("@telefone", _fornecedorEstrutura.cl_Telefone);
            cmd.Parameters.AddWithValue("@email", _fornecedorEstrutura.cl_Email);
            cmd.Parameters.AddWithValue("@imagem", _fornecedorEstrutura.cl_Imagem);
            cmd.Parameters.AddWithValue("@id", _fornecedorEstrutura.cl_Codigo);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Informações alteradas com sucesso!!!";
            }
            catch (SqlException exception)
            {
                this.mensagem = "Erro com o banco de dados \n\n" + exception;
            }
            return mensagem;
        }

        public string ExcluirFornecedor(int id)
        {
            cmd.CommandText = "DELETE FROM tb_Fornecedor WHERE cl_Codigo = @id";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Fornecedor deletado com sucesso!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro com o banco de dados! \n\n" + e;
            }

            return mensagem;
        }
    }
}