using LogSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogSystem.Forms
{
    public partial class form_LocalizarVenda : Form
    {
        private Conexao conexao = new Conexao();

        public form_LocalizarVenda()
        {
            InitializeComponent();
        }

        private void CarregarTabelaVendaPorBusca()
        {
            SqlConnection connection = conexao.Conectar();

            string sqlQuerry = "SELECT vd_Id, vd_Data, vd_CodigoBarrasProduto,cl_Descricao,cl_Nome,cl_Usuario,vd_Item,vd_TotalBruto,vd_Desconto,vd_TotalLiquido,vd_TotalPago,vd_Troco " +
                               "FROM tb_Venda " +
                               "INNER JOIN tb_Cliente AS cliente " +
                               "ON cliente.cl_Codigo = vd_fk_idCliente " +
                               "INNER JOIN tb_Produto AS produto " +
                               "ON produto.cl_Codigo = vd_fk_codProduto " +
                               "INNER JOIN tb_Login " +
                               "ON cl_Id = vd_fk_idVendedor";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    grid_LocalizarVenda.DataSource = dt;
                }
            }
        }

        private void CarregarTabelaVendaPorBuscaCliente(string _nomeCliente)
        {
            SqlConnection connection = conexao.Conectar();

            string sqlQuerry = "SELECT vd_Id, vd_Data, vd_CodigoBarrasProduto,cl_Descricao,cl_Nome,cl_Usuario,vd_Item,vd_TotalBruto,vd_Desconto,vd_TotalLiquido,vd_TotalPago,vd_Troco " +
                               "FROM tb_Venda " +
                               "INNER JOIN tb_Cliente AS cliente " +
                               "ON cliente.cl_Codigo = vd_fk_idCliente " +
                               "INNER JOIN tb_Produto AS produto " +
                               "ON produto.cl_Codigo = vd_fk_codProduto " +
                               "INNER JOIN tb_Login " +
                               "ON cl_Id = vd_fk_idVendedor " +
                               $"WHERE cliente.cl_Nome LIKE '%{_nomeCliente}%'";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    grid_LocalizarVenda.DataSource = dt;
                }
            }
        }

        private void CarregarTabelaVendaPorBuscaProduto(string _Produto)
        {
            SqlConnection connection = conexao.Conectar();

            string sqlQuerry = "SELECT vd_Id, vd_Data, vd_CodigoBarrasProduto,cl_Descricao,cl_Nome,cl_Usuario,vd_Item,vd_TotalBruto,vd_Desconto,vd_TotalLiquido,vd_TotalPago,vd_Troco " +
                               "FROM tb_Venda " +
                               "INNER JOIN tb_Cliente AS cliente " +
                               "ON cliente.cl_Codigo = vd_fk_idCliente " +
                               "INNER JOIN tb_Produto AS produto " +
                               "ON produto.cl_Codigo = vd_fk_codProduto " +
                               "INNER JOIN tb_Login " +
                               "ON cl_Id = vd_fk_idVendedor " +
                               $"WHERE produto.cl_Descricao LIKE '%{_Produto}%'";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    grid_LocalizarVenda.DataSource = dt;
                }
            }
        }

        private void CarregarTabelaVendaPorBuscaVendedor(string _Vendedor)
        {
            SqlConnection connection = conexao.Conectar();

            string sqlQuerry = "SELECT vd_Id, vd_Data, vd_CodigoBarrasProduto,cl_Descricao,cl_Nome,cl_Usuario,vd_Item,vd_TotalBruto,vd_Desconto,vd_TotalLiquido,vd_TotalPago,vd_Troco " +
                               "FROM tb_Venda " +
                               "INNER JOIN tb_Cliente AS cliente " +
                               "ON cliente.cl_Codigo = vd_fk_idCliente " +
                               "INNER JOIN tb_Produto AS produto " +
                               "ON produto.cl_Codigo = vd_fk_codProduto " +
                               "INNER JOIN tb_Login " +
                               "ON cl_Id = vd_fk_idVendedor " +
                               $"WHERE cl_Usuario LIKE '%{_Vendedor}%'";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    grid_LocalizarVenda.DataSource = dt;
                }
            }
        }

        private void txt_BuscarVendaPorCliente_KeyUp(object sender, KeyEventArgs e)
        {
            CarregarTabelaVendaPorBuscaCliente(txt_BuscarVendaPorCliente.Text);
        }

        private void txt_BuscarVendaPorProduto_KeyUp(object sender, KeyEventArgs e)
        {
            CarregarTabelaVendaPorBuscaProduto(txt_BuscarVendaPorProduto.Text);
        }

        private void txt_BuscarVendaPorVendedor_KeyUp(object sender, KeyEventArgs e)
        {
            CarregarTabelaVendaPorBuscaVendedor(txt_BuscarVendaPorVendedor.Text);
        }

        private void form_LocalizarVenda_Load(object sender, EventArgs e)
        {
            CarregarTabelaVendaPorBusca();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}