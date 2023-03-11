using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.Estruturas
{
    public class NFEstrutura
    {
        public int nf_Id { get; set; }

        public int nf_Numero { get; set; }
        public DateTime nf_Data { get; set; }

        public NFEstrutura(int _nf_Id, int _nf_Numero, DateTime _nf_Data)
        {
            nf_Id = _nf_Id;
            nf_Numero = _nf_Numero;
            nf_Data = _nf_Data;
        }

        public NFEstrutura()
        {
        }
    }
}