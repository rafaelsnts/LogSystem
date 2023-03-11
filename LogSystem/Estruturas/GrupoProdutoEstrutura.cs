using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.Estruturas
{
    public class GrupoProdutoEstrutura
    {
        public int cl_Id { get; set; }
        public string cl_Grupo { get; set; }

        public GrupoProdutoEstrutura(int _cl_Id, string _cl_Grupo)
        {
            cl_Id = _cl_Id;
            cl_Grupo = _cl_Grupo;
        }

        public GrupoProdutoEstrutura()
        {
        }
    }
}