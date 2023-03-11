using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.Estruturas
{
    public class ContaEstrutura
    {
        public decimal cl_Credito { get; set; }
        public decimal cl_Debito { get; set; }
        public decimal cl_Saldo { get; set; }
        public bool cl_Bloqueio { get; set; }
        public string cl_Email { get; set; }

        public ContaEstrutura(decimal _cl_Credito, decimal _cl_Debito, decimal _cl_Saldo, bool _cl_Bloqueio,
            string _cl_Email)
        {
            cl_Credito = _cl_Credito;
            cl_Debito = _cl_Debito;
            cl_Saldo = _cl_Saldo;
            cl_Bloqueio = _cl_Bloqueio;
            cl_Email = _cl_Email;
        }

        public ContaEstrutura()
        {
        }
    }
}