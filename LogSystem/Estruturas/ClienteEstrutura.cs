using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.Estruturas
{
    public class ClienteEstrutura
    {
        public int cl_Codigo { get; set; }
        public DateTime cl_Data_Cadastro { get; set; }
        public string cl_Nome { get; set; }
        public string cl_Telefone { get; set; }
        public string cl_Telefone_Residencial { get; set; }
        public string cl_Tipo { get; set; }
        public string cl_Cpf_Cnpj { get; set; }
        public string cl_Rg { get; set; }
        public string cl_Emissor { get; set; }
        public DateTime cl_Data_Emissao { get; set; }
        public DateTime cl_Data_Nascimento { get; set; }
        public string cl_Estado_Civil { get; set; }
        public string cl_Inscricao_Estadual { get; set; }

        public ClienteEstrutura(int _cl_Codigo, DateTime _cl_Data_Cadastro, string _cl_Nome, string _cl_Telefone,
            string _cl_Telefone_Residencial, string _cl_Tipo, string _cl_Cpf_Cnpj, string _cl_Rg, string _cl_Emissor, DateTime _cl_Data_Emissao,
            DateTime _cl_Data_Nascimento, string _cl_Estado_Civil, string _cl_Inscricao_Estadual)
        {
            cl_Codigo = _cl_Codigo;
            cl_Data_Cadastro = _cl_Data_Cadastro;
            cl_Nome = _cl_Nome;
            cl_Telefone = _cl_Telefone;
            cl_Telefone_Residencial = _cl_Telefone_Residencial;
            cl_Tipo = _cl_Tipo;
            cl_Cpf_Cnpj = _cl_Cpf_Cnpj;
            cl_Rg = _cl_Rg;
            cl_Emissor = _cl_Emissor;
            cl_Data_Emissao = _cl_Data_Emissao;
            cl_Data_Nascimento = _cl_Data_Nascimento;
            cl_Estado_Civil = _cl_Estado_Civil;
            cl_Inscricao_Estadual = _cl_Inscricao_Estadual;
        }

        public ClienteEstrutura()
        {
        }
    }
}