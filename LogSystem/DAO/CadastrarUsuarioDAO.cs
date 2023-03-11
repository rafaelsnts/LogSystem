using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.DAO
{
    internal class CadastrarUsuarioDAO
    {
        public bool tem;
        public string mensagem = "";
        private SqlCommand cmd = new SqlCommand();
        private Conexao conexao = new Conexao();
        private SqlDataReader dr;

        public bool verificarLogin(string usuario, string senha)
        {
            cmd.CommandText = "SELECT * FROM tb_Login where cl_Usuario = @usuario and cl_Senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                conexao.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com  Banco de Dados!";
            }
            return tem;
        }

        public string CadastrarUsuario(string usuario, string email, string senha, string confSenha)
        {
            tem = false;
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "INSERT INTO tb_Login values (@usuario,@email, @senha);";
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    cmd.Connection = conexao.Conectar();
                    cmd.ExecuteNonQuery();
                    conexao.Desconectar();
                    this.mensagem = "Usuario Cadastrado com Sucesso!!";
                    tem = true;
                }
                catch (SqlException)

                {
                    this.mensagem = "Erro com o Banco de Dados";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }

            return mensagem;
        }
    }
}