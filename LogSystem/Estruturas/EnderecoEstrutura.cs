using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.Estruturas
{
    public class EnderecoEstrutura
    {
        public string cl_Cep { get; set; }
        public string cl_Endereco { get; set; }
        public string cl_Complemento { get; set; }
        public string cl_Bairro { get; set; }
        public string cl_Cidade { get; set; }
        public string cl_Uf { get; set; }
        public string cl_Naturalidade { get; set; }

        public EnderecoEstrutura(string _cl_Cep, string _cl_Endereco, string _cl_Complemento, string _cl_Bairro, string _cl_Cidade, string _cl_Uf, string _cl_Naturalidade)
        {
            cl_Cep = _cl_Cep;
            cl_Endereco = _cl_Endereco;
            cl_Complemento = _cl_Complemento;
            cl_Bairro = _cl_Bairro;
            cl_Cidade = _cl_Cidade;
            cl_Uf = _cl_Uf;
            cl_Naturalidade = _cl_Naturalidade;
        }

        public EnderecoEstrutura()
        {
        }
    }
}