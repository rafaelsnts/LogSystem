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
using LogSystem.DAO;

namespace LogSystem.Forms
{
    public partial class form_NotaFiscal : Form
    {
        public bool tem = false;
        private Conexao conexao = new Conexao();
        private SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public form_NotaFiscal()
        {
            InitializeComponent();
        }

        public void GetNotasFiscais()
        {
            using (SqlConnection connection = conexao.Conectar())
            {
                string sql = "SELECT nf_Numero,vd_Data,cl_Descricao,cl_Nome,cl_Usuario,vd_Item,vd_TotalBruto,vd_Desconto,vd_TotalLiquido " +
                             "FROM tb_Venda " +
                             "INNER JOIN tb_Cliente AS cliente " +
                             "ON cliente.cl_Codigo = vd_fk_idCliente " +
                             "INNER JOIN tb_Produto AS produto " +
                             "ON produto.cl_Codigo = vd_fk_codProduto " +
                             "INNER JOIN tb_Login " +
                             "ON cl_Id = vd_fk_idVendedor " +
                             "INNER JOIN tb_NotasFiscais " +
                             "ON tb_Venda.vd_Id = tb_NotasFiscais.nf_fk_idVenda ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                // pnl_NotasFiscais.Controls.Clear();

                int linha = 0;
                while (reader.Read())
                {
                    lbl_Codigo.Text = reader["vd_Data"].ToString();
                    //pnl_NotasFiscais.Controls.Add(lbl_Codigo);

                    //Label lblCodigo = new Label();
                    lbl_Data.Text = reader["vd_Data"].ToString();
                    // lbl_Codigo.Location = new System.Drawing.Point(10, linha * 20);
                    //pnl_NotasFiscais.Controls.Add(lbl_Data);

                    // Label lblData = new Label();
                    lbl_Descricao.Text = reader["cl_Descricao"].ToString();
                    // lbl_Data.Location = new System.Drawing.Point(100, linha * 20);
                    //pnl_NotasFiscais.Controls.Add(lbl_Descricao);

                    lbl_Nome.Text = reader["cl_Nome"].ToString();
                    //pnl_NotasFiscais.Controls.Add(lbl_Nome);

                    lbl_Usuario.Text = reader["cl_Usuario"].ToString();
                    //pnl_NotasFiscais.Controls.Add(lbl_Usuario);

                    lbl_QtdItem.Text = reader["vd_Item"].ToString();
                    //pnl_NotasFiscais.Controls.Add(lbl_QtdItem);

                    lbl_TotalBruto.Text = reader["vd_TotalBruto"].ToString();
                    //pnl_NotasFiscais.Controls.Add(lbl_TotalBruto);

                    lbl_Desconto.Text = reader["vd_Desconto"].ToString();
                    //pnl_NotasFiscais.Controls.Add(lbl_Desconto);

                    lbl_TotalLiquido.Text = reader["vd_TotalLiquido"].ToString();
                    //pnl_NotasFiscais.Controls.Add(lbl_TotalLiquido);

                    // Label lblNumero = new Label();
                    lbl_Numero.Text = reader["nf_Numero"].ToString();
                    //  lbl_Numero.Location = new System.Drawing.Point(200, linha * 20);
                    //pnl_NotasFiscais.Controls.Add(lbl_Numero);

                    linha++;
                }
            }
        }

        //public void ShowNotasFiscais()
        //{
        //    GetNotasFiscais();
        //    //lbl_teste.Text = GetNotasFiscais();
        //    //lbl_teste.Refresh();
        //}

        private void form_NotaFiscal_Load(object sender, EventArgs e)
        {
            GetNotasFiscais();
        }
    }
}