using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.Estruturas
{
    public class SubGrupoProdutoEstrutura
    {
        public int cl_Id { get; set; }
        public string cl_SubGrupo { get; set; }

        public SubGrupoProdutoEstrutura(int _cl_Id, string _cl_SubGrupo)
        {
            cl_Id = _cl_Id;
            cl_SubGrupo = _cl_SubGrupo;
        }

        public SubGrupoProdutoEstrutura()
        {
        }
    }
}