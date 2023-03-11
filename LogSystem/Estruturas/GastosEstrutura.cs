using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.Estruturas
{
    public class GastosEstrutura
    {
        public int gst_Codigo { get; set; }
        public string gst_Categoria { get; set; }
        public string gst_Titulo { get; set; }
        public string gst_Tipo { get; set; }
        public string gst_Descricao { get; set; }
        public DateTime gst_Emissao { get; set; }
        public DateTime gst_Vencimento { get; set; }
        public string gst_Frequencia { get; set; }
        public decimal gst_Valor { get; set; }

        public GastosEstrutura(int _gst_Codigo, string _gst_Categoria, string _gst_Titulo, string _gst_Tipo, string _gst_Descricao, DateTime _gst_Emissao, DateTime _gst_Vencimento, string _gst_Frequencia, decimal _gst_Valor)
        {
            gst_Codigo     = _gst_Codigo;
            gst_Categoria  = _gst_Categoria;
            gst_Titulo     = _gst_Titulo;
            gst_Tipo       = _gst_Tipo;
            gst_Descricao  = _gst_Descricao;
            gst_Emissao    = _gst_Emissao;
            gst_Vencimento = _gst_Vencimento;
            gst_Frequencia = _gst_Frequencia;
            gst_Valor      = _gst_Valor;
        }

        public GastosEstrutura()
        {
        }
    }
}