using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogSystem.DAO;

namespace LogSystem.Forms
{
    public partial class form_ProcurarGastos : Form
    {
        private Conexao conexao = new Conexao();
        private form_Gastos formGastos;

        public form_ProcurarGastos(form_Gastos _formGastos)
        {
            InitializeComponent();
            formGastos = _formGastos;
        }

        public void Alerta(string msg, form_Alertas.enmType type)
        {
            form_Alertas form = new form_Alertas();
            form.showAlert(msg, type);
        }

        private void PreencherGridGastos()
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Código");
            //dt.Columns.Add("Categoria");
            //dt.Columns.Add("Título");
            //dt.Columns.Add("Tipo");
            //dt.Columns.Add("Descrição");
            //dt.Columns.Add("Emissão");
            //dt.Columns.Add("Vencimento");
            //dt.Columns.Add("Frequência");
            //dt.Columns.Add("Valor");

            SqlConnection connection = conexao.Conectar();

            var sqlQuerry = "SELECT gst_Codigo,gst_Categoria,gst_Titulo,gst_Tipo,gst_Descricao,gst_Emissao,gst_Vencimento,gst_Frequencia,gst_Valor from tb_Gastos";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    grid_BuscarGastos.DataSource = dt;
                }
            }
        }

        private void CarregarTabelaPorBusca()
        {
            SqlConnection connection = conexao.Conectar();

            string sqlQuerry = "SELECT * FROM tb_Gastos";

            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    {
                        grid_BuscarGastos.DataSource = dt;
                    }
                }
            }
        }

        private void CarregarTabelaBuscaPorCodigo(string _Codigo)
        {
            SqlConnection connection = conexao.Conectar();

            string sqlQuerry = $"SELECT * FROM tb_Gastos WHERE gst_Codigo LIKE '%{_Codigo}%'";

            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    {
                        grid_BuscarGastos.DataSource = dt;
                    }
                }
            }
        }

        private void CarregarTabelaBuscaPorCategoria(string _Categoria)
        {
            SqlConnection connection = conexao.Conectar();

            string sqlQuerry = $"SELECT * FROM tb_Gastos WHERE gst_Categoria LIKE '%{_Categoria}%'";

            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    {
                        grid_BuscarGastos.DataSource = dt;
                    }
                }
            }
        }

        private void CarregarTabelaBuscaPorTitulo(string _Titulo)
        {
            SqlConnection connection = conexao.Conectar();

            string sqlQuerry = $"SELECT * FROM tb_Gastos WHERE gst_Titulo LIKE '%{_Titulo}%'";

            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    {
                        grid_BuscarGastos.DataSource = dt;
                    }
                }
            }
        }

        private void CarregarTabelaBuscaPorTipo(string _Tipo)
        {
            SqlConnection connection = conexao.Conectar();

            string sqlQuerry = $"SELECT * FROM tb_Gastos WHERE gst_Tipo LIKE '%{_Tipo}%'";

            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    {
                        grid_BuscarGastos.DataSource = dt;
                    }
                }
            }
        }

        private void PreencherFormAoClicarDuasVezesNoGrid()
        {
            formGastos.lbl_Teste.Text       = grid_BuscarGastos.SelectedCells[0].Value.ToString();
            formGastos.txt_Codigo.Text      = grid_BuscarGastos.SelectedCells[0].Value.ToString();
            formGastos.ckb_Despesa.Checked  = grid_BuscarGastos.SelectedCells[1].Value.ToString() == "Despesa" ? true : false;
            formGastos.ckb_Custo.Checked    = grid_BuscarGastos.SelectedCells[1].Value.ToString() == "Custo" ? true : false;
            formGastos.txt_Titulo.Text      = grid_BuscarGastos.SelectedCells[2].Value.ToString();
            formGastos.cmb_Tipo.Text        = grid_BuscarGastos.SelectedCells[3].Value.ToString();
            formGastos.txt_Descricao.Text   = grid_BuscarGastos.SelectedCells[4].Value.ToString();
            formGastos.dtp_Emissao.Text     = grid_BuscarGastos.SelectedCells[5].Value.ToString();
            formGastos.dtp_Vencimento.Text  = grid_BuscarGastos.SelectedCells[6].Value.ToString();
            formGastos.cmb_Frenquencia.Text = grid_BuscarGastos.SelectedCells[7].Value.ToString();
            formGastos.txt_Valor.Text       = grid_BuscarGastos.SelectedCells[8].Value.ToString();
            this.Close();
            formGastos.btn_Alterar.Enabled = true;
            formGastos.btn_Excluir.Enabled = true;
            formGastos.btn_Nova.Enabled    = true;
            formGastos.btn_Salvar.Enabled  = false;
        }

        private void txt_BuscaPorCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            CarregarTabelaBuscaPorCodigo(txt_BuscaPorCodigo.Text);
        }

        private void form_ProcurarGastos_Load(object sender, EventArgs e)
        {
            CarregarTabelaPorBusca();
        }

        private void txt_BuscaPorCategoria_KeyUp(object sender, KeyEventArgs e)
        {
            CarregarTabelaBuscaPorCategoria(txt_BuscaPorCategoria.Text);
        }

        private void txt_BuscaPorTitulo_KeyUp(object sender, KeyEventArgs e)
        {
            CarregarTabelaBuscaPorTitulo(txt_BuscaPorTitulo.Text);
        }

        private void txt_BuscaPorTipo_KeyUp(object sender, KeyEventArgs e)
        {
            CarregarTabelaBuscaPorTipo(txt_BuscaPorTipo.Text);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid_BuscarGastos_DoubleClick(object sender, EventArgs e)
        {
            PreencherFormAoClicarDuasVezesNoGrid();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}