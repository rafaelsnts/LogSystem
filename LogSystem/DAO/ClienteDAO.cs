using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogSystem.Estruturas;

namespace LogSystem.DAO
{
    internal class ClienteDAO
    {
        public bool tem = false;
        private Conexao conexao = new Conexao();
        private SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public string CadastrarCliente(ClienteEstrutura _clienteEstrutura, EnderecoEstrutura _enderecoEstrutura, ContaEstrutura _contaEstrutura)
        {
            cmd.CommandText = "insert into tb_Cliente values (@dtCadastro,@nome,@telefone,@telefoneResidencial,@tipo,@cpf,@rg,@emissor,@dtEmissao,@estadoCivil,@inscEstadual,@cep,@endereco,@complemento,@bairro,@cidade,@uf,@naturalidade,@dtNascimento,@credito,@debito,@saldo,@bloqueio,@email);";
            cmd.Parameters.AddWithValue("@dtCadastro", _clienteEstrutura.cl_Data_Cadastro);
            cmd.Parameters.AddWithValue("@nome", _clienteEstrutura.cl_Nome);
            cmd.Parameters.AddWithValue("@telefone", _clienteEstrutura.cl_Telefone);
            cmd.Parameters.AddWithValue("@telefoneResidencial", _clienteEstrutura.cl_Telefone_Residencial);
            cmd.Parameters.AddWithValue("@tipo", _clienteEstrutura.cl_Tipo);
            cmd.Parameters.AddWithValue("@cpf", _clienteEstrutura.cl_Cpf_Cnpj);
            cmd.Parameters.AddWithValue("@rg", _clienteEstrutura.cl_Rg);
            cmd.Parameters.AddWithValue("@emissor", _clienteEstrutura.cl_Emissor);
            cmd.Parameters.AddWithValue("@dataEmissao", _clienteEstrutura.cl_Data_Emissao);
            cmd.Parameters.AddWithValue("@estadoCivil", _clienteEstrutura.cl_Estado_Civil);
            cmd.Parameters.AddWithValue("@inscEstadual", _clienteEstrutura.cl_Inscricao_Estadual);
            cmd.Parameters.AddWithValue("@cep", _enderecoEstrutura.cl_Cep);
            cmd.Parameters.AddWithValue("@endereco", _enderecoEstrutura.cl_Endereco);
            cmd.Parameters.AddWithValue("@complemento", _enderecoEstrutura.cl_Complemento);
            cmd.Parameters.AddWithValue("@bairro", _enderecoEstrutura.cl_Bairro);
            cmd.Parameters.AddWithValue("@cidade", _enderecoEstrutura.cl_Cidade);
            cmd.Parameters.AddWithValue("@uf", _enderecoEstrutura.cl_Uf);
            cmd.Parameters.AddWithValue("@naturalidade", _enderecoEstrutura.cl_Naturalidade);
            cmd.Parameters.AddWithValue("@dtNascimento", _clienteEstrutura.cl_Data_Nascimento);
            cmd.Parameters.AddWithValue("@credito", _contaEstrutura.cl_Credito);
            cmd.Parameters.AddWithValue("@debito", _contaEstrutura.cl_Debito);
            cmd.Parameters.AddWithValue("@saldo", _contaEstrutura.cl_Saldo);
            cmd.Parameters.AddWithValue("@bloqueio", _contaEstrutura.cl_Bloqueio);
            cmd.Parameters.AddWithValue("@email", _contaEstrutura.cl_Email);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Cliente Cadastrado com Sucesso!!!";
            }
            catch (SqlException exception)
            {
                this.mensagem = "Erro com o Banco de Dados!!! \n \n" + exception;
            }

            return mensagem;
        }

        public string AlterarCliente(ClienteEstrutura _clienteEstrutura, EnderecoEstrutura _enderecoEstrutura, ContaEstrutura _contaEstrutura)
        {
            //cmd.CommandText = "UPDATE tb_Cliente SET cl_Cliente (@nome,@telefone,@telefoneResidencial,@tipo,@cpf,@rg,@emissor,@dtEmissao,@estadoCivil,@inscEstadual,@cep,@endereco,@complemento,@bairro,@cidade,@uf,@naturalidade,@dtNascimento,@credito,@debito,@saldo,@bloqueio,@email);";
            cmd.CommandText = "UPDATE tb_Cliente SET cl_Nome = (@nome), cl_Telefone = (@telefone), cl_Telefone_Residencial = (@telefoneResidencial), cl_Tipo = (@tipo), cl_Cpf_Cnpj = (@cpf), cl_Rg = (@rg), cl_Emissor = (@emissor), cl_Data_Emissao = (@dtEmissao), cl_Estado_Civil = (@estadoCivil), cl_Inscricao_Estadual = (@inscEstadual), cl_Cep = (@cep), cl_Endereco = (@endereco), cl_Complemento = (@complemento), cl_Bairro = (@bairro), cl_Cidade = (@cidade), cl_Uf = (@uf), cl_Naturalidade = (@naturalidade), cl_Data_Nascimento = (@dtNascimento), cl_Credito = (@credito), cl_Debito = (@debito), cl_Saldo = (@saldo), cl_Bloqueio = (@bloqueio), cl_Email = (@email) WHERE cl_Codigo = (@id)";

            //  cmd.Parameters.AddWithValue("@dataCadastro", _clienteEstrutura.cl_Data_Cadastro);
            cmd.Parameters.AddWithValue("@nome", _clienteEstrutura.cl_Nome);
            cmd.Parameters.AddWithValue("@telefone", _clienteEstrutura.cl_Telefone);
            cmd.Parameters.AddWithValue("@telefoneResidencial", _clienteEstrutura.cl_Telefone_Residencial);
            cmd.Parameters.AddWithValue("@tipo", _clienteEstrutura.cl_Tipo);
            cmd.Parameters.AddWithValue("@cpf", _clienteEstrutura.cl_Cpf_Cnpj);
            cmd.Parameters.AddWithValue("@rg", _clienteEstrutura.cl_Rg);
            cmd.Parameters.AddWithValue("@emissor", _clienteEstrutura.cl_Emissor);
            cmd.Parameters.AddWithValue("@dtEmissao", _clienteEstrutura.cl_Data_Emissao);
            cmd.Parameters.AddWithValue("@estadoCivil", _clienteEstrutura.cl_Estado_Civil);
            cmd.Parameters.AddWithValue("@inscEstadual", _clienteEstrutura.cl_Inscricao_Estadual);
            cmd.Parameters.AddWithValue("@cep", _enderecoEstrutura.cl_Cep);
            cmd.Parameters.AddWithValue("@endereco", _enderecoEstrutura.cl_Endereco);
            cmd.Parameters.AddWithValue("@complemento", _enderecoEstrutura.cl_Complemento);
            cmd.Parameters.AddWithValue("@bairro", _enderecoEstrutura.cl_Bairro);
            cmd.Parameters.AddWithValue("@cidade", _enderecoEstrutura.cl_Cidade);
            cmd.Parameters.AddWithValue("@uf", _enderecoEstrutura.cl_Uf);
            cmd.Parameters.AddWithValue("@naturalidade", _enderecoEstrutura.cl_Naturalidade);
            cmd.Parameters.AddWithValue("@dtNascimento", _clienteEstrutura.cl_Data_Nascimento);
            cmd.Parameters.AddWithValue("@credito", _contaEstrutura.cl_Credito);
            cmd.Parameters.AddWithValue("@debito", _contaEstrutura.cl_Debito);
            cmd.Parameters.AddWithValue("@saldo", _contaEstrutura.cl_Saldo);
            cmd.Parameters.AddWithValue("@bloqueio", _contaEstrutura.cl_Bloqueio);
            cmd.Parameters.AddWithValue("@email", _contaEstrutura.cl_Email);
            cmd.Parameters.AddWithValue("@id", _clienteEstrutura.cl_Codigo);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Informações Alteradas com Sucesso!!!";
            }
            catch (SqlException exception)
            {
                this.mensagem = "Erro com o Banco de Dados!!! \n \n" + exception;
            }

            return mensagem;
        }

        public string DeletarCliente(int id)
        {
            cmd.CommandText = "DELETE FROM tb_Cliente WHERE cl_Codigo = (@id)";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Jogador Deletado com Sucesso!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro com o Banco de Dados! \n\n" + e;
            }

            return mensagem;
        }
    }
}