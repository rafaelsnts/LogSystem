using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.Estruturas
{
    public class FornecedorEstrutura
    {
        public int cl_Codigo { get; set; }
        public string cl_NomeFantasia { get; set; }
        public string cl_RazaoSocial { get; set; }
        public string cl_Cep { get; set; }
        public string cl_Endereco { get; set; }
        public string cl_Cidade { get; set; }
        public string cl_CnpjCpf { get; set; }
        public string cl_InscricaoEstadual { get; set; }
        public string cl_InscricaoMunicipal { get; set; }
        public string cl_Telefone { get; set; }
        public string cl_Email { get; set; }
        public byte[] cl_Imagem { get; set; }

        public FornecedorEstrutura(int _cl_Codigo, string _cl_NomeFantasia, string _cl_RazaoSocial, string _cl_Cep,
            string _cl_Endereco, string _cl_Cidade, string _cl_CnpjCpf, string _cl_InscricaoEstadual,
            string _cl_InscricaoMunicipal, string _cl_Telefone, string _cl_Email, byte[] _cl_Imagem)
        {
            cl_Codigo = _cl_Codigo;
            cl_NomeFantasia = _cl_NomeFantasia;
            cl_RazaoSocial = _cl_RazaoSocial;
            cl_Cep = _cl_Cep;
            cl_Endereco = _cl_Endereco;
            cl_Cidade = _cl_Cidade;
            cl_CnpjCpf = _cl_CnpjCpf;
            cl_InscricaoEstadual = _cl_InscricaoEstadual;
            cl_InscricaoMunicipal = _cl_InscricaoMunicipal;
            cl_Telefone = _cl_Telefone;
            cl_Email = _cl_Email;
            cl_Imagem = _cl_Imagem;
        }

        public FornecedorEstrutura()
        {
        }
    }
}