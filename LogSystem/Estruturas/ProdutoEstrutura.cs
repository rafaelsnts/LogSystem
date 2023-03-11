using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.Estruturas
{
    public class ProdutoEstrutura
    {
        public int cl_Codigo { get; set; }
        public int cl_CodigoBarras { get; set; }
        public string cl_Descricao { get; set; }
        public string cl_Unidade { get; set; }
        public decimal cl_PrecoCompra { get; set; }
        public decimal cl_Margem { get; set; }
        public decimal cl_Lucro { get; set; }
        public decimal cl_PrecoVenda { get; set; }
        public decimal cl_PrecoAPrazo { get; set; }
        public string cl_Grupo { get; set; }
        public string cl_SubGrupo { get; set; }
        public string cl_Fornecedor { get; set; }
        public int cl_EstoqueMinimo { get; set; }
        public string cl_Garantia { get; set; }
        public string cl_Marca { get; set; }
        public string cl_Referencia { get; set; }
        public DateTime cl_DataValidade { get; set; }
        public decimal cl_Comissao { get; set; }
        public string cl_Observacoes { get; set; }
        public int cl_EstoqueAtual { get; set; }
        public byte[] cl_Imagem { get; set; }

        public ProdutoEstrutura(int _cl_Codigo, int _cl_CodigoBarras, string _cl_Descricao, string _cl_Unidade, decimal _cl_PrecoCompra, decimal _cl_Margem, decimal _cl_Lucro, decimal _cl_PrecoVenda,
            decimal _cl_PrecoAPrazo, string _cl_Grupo, string _cl_SubGrupo, string _cl_Fornecedor, int _cl_EstoqueMinimo, string _cl_Garantia, string _cl_Marca, string _cl_Referencia, DateTime _cl_DataValidade, decimal _cl_Comissao,
            string _cl_Observacoes, int _cl_EstoqueAtual, byte[] _cl_Imagem)
        {
            cl_Codigo = _cl_Codigo;
            cl_CodigoBarras = _cl_CodigoBarras;
            cl_Descricao = _cl_Descricao;
            cl_Unidade = _cl_Unidade;
            cl_PrecoCompra = _cl_PrecoCompra;
            cl_Margem = _cl_Margem;
            cl_Lucro = _cl_Lucro;
            cl_PrecoVenda = _cl_PrecoVenda;
            cl_PrecoAPrazo = _cl_PrecoAPrazo;
            cl_Grupo = _cl_Grupo;
            cl_SubGrupo = _cl_SubGrupo;
            cl_Fornecedor = _cl_Fornecedor;
            cl_EstoqueMinimo = _cl_EstoqueMinimo;
            cl_Garantia = _cl_Garantia;
            cl_Marca = _cl_Marca;
            cl_Referencia = _cl_Referencia;
            cl_DataValidade = _cl_DataValidade;
            cl_Comissao = _cl_Comissao;
            cl_Observacoes = _cl_Observacoes;
            cl_EstoqueAtual = _cl_EstoqueAtual;
            cl_Imagem = _cl_Imagem;
        }

        public ProdutoEstrutura()
        {
        }
    }
}