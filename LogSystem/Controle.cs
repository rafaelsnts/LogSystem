using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogSystem.DAO;

namespace LogSystem
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";

        public bool logar(string login, string senha)
        {
            CadastrarUsuarioDAO cadastrarUsuario = new CadastrarUsuarioDAO();
            tem = cadastrarUsuario.verificarLogin(login, senha);
            if (!cadastrarUsuario.mensagem.Equals(""))
            {
                this.mensagem = cadastrarUsuario.mensagem;
            }
            return tem;
        }

        public string cadastrarUsuario(string usuario, string email, string senha, string confSenha)
        {
            CadastrarUsuarioDAO cadastrarUsuario = new CadastrarUsuarioDAO();
            this.mensagem = cadastrarUsuario.CadastrarUsuario(usuario, email, senha, confSenha);
            if (cadastrarUsuario.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}