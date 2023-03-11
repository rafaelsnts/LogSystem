using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogSystem.DAO;

namespace LogSystem.Forms
{
    public partial class form_ProcurarFornecedor : Form
    {
        private Conexao conexao = new Conexao();

        public form_ProcurarFornecedor()
        {
            InitializeComponent();
        }

        public void CarregarTabelaPorBuscaFornecedor()
        {
            SqlConnection connection = conexao.Conectar();

            var sqlQuerry = "SELECT cl_Codigo, cl_NomeFantasia, cl_RazaoSocial, cl_Cep, cl_Endereco, cl_Cidade, cl_CnpjCpf, cl_InscricaoEstadual, cl_InscricaoMunicipal, cl_Telefone, cl_Email, cl_Imagem FROM tb_Fornecedor";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    grid_PesquisarFornecedor.DataSource = dt;
                }
            }
        }

        private void CarregarTabelaPorBuscaCodigoFornecedor(string _codigoFornecedor)
        {
            SqlConnection connection = conexao.Conectar();

            var sqlQuerry = $"SELECT cl_Codigo, cl_NomeFantasia, cl_RazaoSocial, cl_Cep, cl_Endereco, cl_Cidade, cl_CnpjCpf, cl_InscricaoEstadual, cl_InscricaoMunicipal, cl_Telefone, cl_Email, cl_Imagem FROM tb_Fornecedor WHERE cl_Codigo LIKE'%{_codigoFornecedor}%'";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    grid_PesquisarFornecedor.DataSource = dt;
                }
            }
        }

        private void CarregarTabelaPorBuscaNomeFornecedor(string _nomeFornecedor)
        {
            SqlConnection connection = conexao.Conectar();

            var sqlQuerry = $"SELECT cl_Codigo, cl_NomeFantasia, cl_RazaoSocial, cl_Cep, cl_Endereco, cl_Cidade, cl_CnpjCpf, cl_InscricaoEstadual, cl_InscricaoMunicipal, cl_Telefone, cl_Email, cl_Imagem FROM tb_Fornecedor WHERE cl_NomeFantasia LIKE '%{_nomeFornecedor}%'";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    grid_PesquisarFornecedor.DataSource = dt;
                }
            }
        }

        private void PreencherFormAoClicarDuasVezes()
        {
            form_Fornecedor formFornecedor = new form_Fornecedor();
            formFornecedor.lbl_Codigo.Text = grid_PesquisarFornecedor.SelectedCells[0].Value.ToString();
            formFornecedor.txt_Codigo.Text = grid_PesquisarFornecedor.SelectedCells[0].Value.ToString();
            formFornecedor.txt_NomeFantasia.Text = grid_PesquisarFornecedor.SelectedCells[1].Value.ToString();
            formFornecedor.txt_RazaoSocial.Text = grid_PesquisarFornecedor.SelectedCells[2].Value.ToString();
            formFornecedor.txt_Cep.Text = grid_PesquisarFornecedor.SelectedCells[3].Value.ToString();
            formFornecedor.txt_Endereco.Text = grid_PesquisarFornecedor.SelectedCells[4].Value.ToString();
            formFornecedor.txt_Cidade.Text = grid_PesquisarFornecedor.SelectedCells[5].Value.ToString();
            formFornecedor.txt_CnpjCpf.Text = grid_PesquisarFornecedor.SelectedCells[6].Value.ToString();
            formFornecedor.txt_InscEstadual.Text = grid_PesquisarFornecedor.SelectedCells[7].Value.ToString();
            formFornecedor.txt_InscMunicipal.Text = grid_PesquisarFornecedor.SelectedCells[8].Value.ToString();
            formFornecedor.txt_Telefone.Text = grid_PesquisarFornecedor.SelectedCells[9].Value.ToString();
            formFornecedor.txt_Email.Text = grid_PesquisarFornecedor.SelectedCells[10].Value.ToString();
            // byte[] imagemBytes = Encoding.ASCII.GetBytes(grid_PesquisarFornecedor.SelectedCells[11].Value.ToString());
            object imagemObject = grid_PesquisarFornecedor.SelectedCells[11].Value;
            if (!string.IsNullOrEmpty(imagemObject.ToString()))
            {
                byte[] imagemBytes = (byte[])imagemObject;
                formFornecedor.pbx_FotoCliente.Image = formFornecedor.ConverterByteArrayEmImagem(imagemBytes);
            }

            formFornecedor.btn_GravarFornecedor.Enabled = false;
            formFornecedor.ShowDialog();

            Application.Exit();
        }

        private void form_ProcurarFornecedor_Load(object sender, EventArgs e)
        {
            CarregarTabelaPorBuscaFornecedor();
        }

        private void txt_BuscaCodigoFornecedor_KeyUp(object sender, KeyEventArgs e)
        {
            CarregarTabelaPorBuscaCodigoFornecedor(txt_BuscaCodigoFornecedor.Text);
        }

        private void txt_BuscarNomeFornecedor_KeyUp(object sender, KeyEventArgs e)
        {
            CarregarTabelaPorBuscaNomeFornecedor(txt_BuscarNomeFornecedor.Text);
        }

        private void grid_PesquisarFornecedor_DoubleClick(object sender, EventArgs e)
        {
            PreencherFormAoClicarDuasVezes();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}