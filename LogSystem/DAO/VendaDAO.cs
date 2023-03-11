using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogSystem.Estruturas;
using LogSystem.Forms;

namespace LogSystem.DAO
{
    public class VendaDAO
    {
        public bool tem = false;
        private Conexao conexao = new Conexao();
        private SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public void Alerta(string msg, form_Alertas.enmType type)
        {
            form_Alertas form = new form_Alertas();
            form.showAlert(msg, type);
        }

        public string CadastrarVenda(VendaEstrutura _vendaEstrutura, string _codProduto, string _cliente, string _vendedor)
        {
            cmd.CommandText = "INSERT INTO tb_Venda values (@data,@codBarras,@codProduto,@idCliente,@idVendedor,@qtdItens,@totalBruto,@desconto,@totalLiquido,@totalPago,@troco)";
            cmd.Parameters.AddWithValue("@data", _vendaEstrutura.vd_Data);
            cmd.Parameters.AddWithValue("@codBarras", _codProduto);
            cmd.Parameters.AddWithValue("@codProduto", _codProduto);
            cmd.Parameters.AddWithValue("@idCliente", _cliente);
            cmd.Parameters.AddWithValue("@idVendedor", _vendedor);
            cmd.Parameters.AddWithValue("@qtdItens", _vendaEstrutura.vd_Item);
            cmd.Parameters.AddWithValue("@totalBruto", _vendaEstrutura.vd_TotalBruto);
            cmd.Parameters.AddWithValue("@desconto", _vendaEstrutura.vd_Desconto);
            cmd.Parameters.AddWithValue("@totalLiquido", _vendaEstrutura.vd_TotalLiquido);
            cmd.Parameters.AddWithValue("@totalPago", _vendaEstrutura.vd_TotalPago);
            cmd.Parameters.AddWithValue("@troco", _vendaEstrutura.vd_Troco);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Venda Efetuada com Sucesso!!";
                Alerta("Venda Realizada", form_Alertas.enmType.Success);
            }
            catch (SqlException exception)
            {
                this.mensagem = "Erro com o Banco de Dados!!! \n\n" + exception;
            }

            return mensagem;
        }

        public List<string> BuscarCliente()
        {
            List<string> IdCliente = new List<string>();

            using (SqlConnection connection = conexao.Conectar())
            {
                string        Querry = "SELECT cl_Nome from tb_Cliente ORDER BY cl_Nome ASC";
                SqlCommand    cmd    = new SqlCommand(Querry, connection);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    IdCliente.Add(dr.GetString(0));
                }

                return IdCliente;
            }
        }

        public List<string> BuscarIdLoginUsuario()
        {
            List<string> IdLogin = new List<string>();
            using (SqlConnection connection = conexao.Conectar())
            {
                string        Querry = "SELECT cl_Usuario from tb_Login ORDER BY cl_Usuario ASC";
                SqlCommand    cmd    = new SqlCommand(Querry, connection);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    IdLogin.Add(dr.GetString(0));
                }

                return IdLogin;
            }
        }

        public int BuscarIdLogin(string loginVendedor)
        {
            using (SqlConnection cn = conexao.Conectar())
            {
                string     sqlQuerry = "select cl_id from tb_Login where cl_Usuario = @loginVendedor";
                SqlCommand cmd       = new SqlCommand(sqlQuerry, cn);
                cmd.Parameters.AddWithValue("@loginVendedor", loginVendedor);
                SqlDataReader dr;

                dr = cmd.ExecuteReader();
                dr.Read();

                return dr.GetInt32(0);
            }
        }

        public int BuscarIdCliente(string idCliente)
        {
            using (SqlConnection cn = conexao.Conectar())
            {
                string     sqlQuerry = "select cl_Codigo from tb_Cliente where cl_Nome = @idCliente";
                SqlCommand cmd       = new SqlCommand(sqlQuerry, cn);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                dr.Read();

                return dr.GetInt32(0);
            }
        }

        public int BuscarIdProduto(string idProduto)
        {
            using (SqlConnection cn = conexao.Conectar())
            {
                string     sqlQuerry = "select cl_Codigo from tb_Produto where cl_Descricao = @idProduto";
                SqlCommand cmd       = new SqlCommand(sqlQuerry, cn);
                cmd.Parameters.AddWithValue("@idCliente", idProduto);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                dr.Read();

                return dr.GetInt32(0);
            }
        }

        public Dictionary<int, string> BuscarProduto()
        {
            // List<string> nomeProduto = new List<string>();
            Dictionary<int, string> nomeProduto = new Dictionary<int, string>();
            using (SqlConnection connection = conexao.Conectar())
            {
                string        Querry = "SELECT cl_Codigo, cl_Descricao from tb_Produto ORDER BY cl_Descricao ASC";
                SqlCommand    cmd    = new SqlCommand(Querry, connection);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //nomeProduto.Add(dr.GetString(0));
                    nomeProduto.Add(dr.GetInt32(0), dr.GetString(1));
                }

                return nomeProduto;
            }
        }

        //public int BuscarCodigoBarrasProduto()
        //{
        //    form_Vendas formVendas = new form_Vendas();

        //    try
        //    {
        //        using (SqlConnection connection = conexao.Conectar())
        //        {
        //            string Querry = "SELECT cl_Codigo,cl_CodigoBarras from tb_Produto ORDER BY cl_Codigo ASC";
        //            SqlCommand cmd = new SqlCommand(Querry, connection);
        //            SqlDataReader myReader = cmd.ExecuteReader();

        //            while (myReader.Read())
        //            {
        //                //comboEditPlayerPos.Items.Add(myReader[1]);
        //                formVendas.txt_CodigoBarras.Text = myReader[0].ToString();
        //                //txtEditPlayerSecond.Text = myReader[3].ToString();
        //                //comboEditPlayerStatus.Items.Add(myReader[4]);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex + "Erro");
        //    }

        //    return 1;
        //}
    }
}