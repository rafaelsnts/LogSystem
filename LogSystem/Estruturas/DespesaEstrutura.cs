using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.Estruturas
{
    internal class DespesaEstrutura
    {
        public int des_Codigo { get; set; }
        public int fk_Cl_Id_Gastos { get; set; }
        public string des_Titulo { get; set; }
        public string des_Descricao { get; set; }
        public DateTime des_Emissao { get; set; }
        public DateTime des_Vencimento { get; set; }
        public string des_Frequencia { get; set; }
        public decimal des_Valor { get; set; }

        public DespesaEstrutura(int _des_Codigo, int _fk_Cl_Id_Gastos, string _des_Titulo, string _des_Descricao, DateTime _des_Emissao, DateTime _des_Vencimento, string _des_Frequencia, decimal _des_Valor)
        {
            des_Codigo      = _des_Codigo;
            fk_Cl_Id_Gastos = _fk_Cl_Id_Gastos;
            des_Titulo      = _des_Titulo;
            des_Descricao   = _des_Descricao;
            des_Emissao     = _des_Emissao;
            des_Vencimento  = _des_Vencimento;
            des_Frequencia  = _des_Frequencia;
            des_Valor       = _des_Valor;
        }

        public DespesaEstrutura()
        {
        }
    }
}