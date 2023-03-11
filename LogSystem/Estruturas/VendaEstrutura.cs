using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogSystem.Estruturas
{
    public class VendaEstrutura
    {
        public int vd_Id { get; set; }
        public DateTime vd_Data { get; set; }
        public int vd_CodigoBarrasProduto { get; set; }
        public int vd_fk_codProduto { get; set; }
        public int vd_fk_idCliente { get; set; }
        public int vd_fk_idVendedor { get; set; }
        public int vd_Item { get; set; }
        public decimal vd_TotalBruto { get; set; }
        public double vd_Desconto { get; set; }
        public decimal vd_TotalLiquido { get; set; }
        public decimal vd_TotalPago { get; set; }
        public decimal vd_Troco { get; set; }

        public VendaEstrutura(int _vd_Id, DateTime _vd_Data, int _vd_CodigoBarrasProduto, int _vd_fk_codProduto, int _vd_fk_idCliente, int _vd_fk_idVendedor, int _vd_Item, decimal _vd_TotalBruto, double _vd_Desconto, decimal _vd_TotalLiquido, decimal _vd_TotalPago, decimal _vd_Troco)
        {
            vd_Id = _vd_Id;
            vd_Data = _vd_Data;
            vd_CodigoBarrasProduto = _vd_CodigoBarrasProduto;
            vd_fk_codProduto = _vd_fk_codProduto;
            vd_fk_idCliente = _vd_fk_idCliente;
            vd_fk_idVendedor = _vd_fk_idVendedor;
            vd_Item = _vd_Item;
            vd_TotalBruto = _vd_TotalBruto;
            vd_Desconto = _vd_Desconto;
            vd_TotalLiquido = _vd_TotalLiquido;
            vd_TotalPago = _vd_TotalPago;
            vd_Troco = _vd_Troco;
        }

        public VendaEstrutura()
        {
        }
    }
}