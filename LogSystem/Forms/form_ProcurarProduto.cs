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
    public partial class form_ProcurarProduto : Form
    {
        private Conexao conexao = new Conexao();

        public form_ProcurarProduto()
        {
            InitializeComponent();
        }

        private void CarregarTabelaPorBuscaProduto()
        {
            SqlConnection connection = conexao.Conectar();

            //var sqlQuerry = "SELECT cl_Codigo, cl_CodigoBarras, cl_Descricao, cl_Unidade, cl_PrecoCompra, cl_Margem, cl_Lucro, cl_PrecoVenda, cl_PrecoAPrazo, fk_cl_Id_Grupo, fk_cl_Id_Subgrupo, cl_Fornecedor, cl_EstoqueMinimo, cl_Garantia, cl_Marca, cl_Referencia, cl_DataValidade, cl_Comissao, cl_Observacoes, cl_EstoqueAtual, cl_Imagem FROM tb_Produto";
            var sqlQuerry = "SELECT cl_Codigo,cl_CodigoBarras,cl_Descricao,cl_Unidade,cl_PrecoCompra,cl_Margem,cl_Lucro,cl_Grupo,cl_SubGrupo,cl_PrecoAPrazo,cl_Fornecedor,cl_EstoqueMinimo,cl_Garantia,cl_Marca,cl_Referencia,cl_DataValidade,cl_Comissao,cl_Observacoes,cl_EstoqueAtual,cl_Imagem FROM tb_Produto INNER JOIN tb_GrupoProduto ON tb_Produto.fk_cl_Id_Grupo = tb_GrupoProduto.cl_Id INNER JOIN tb_SubGrupoProduto ON tb_Produto.fk_cl_Id_Subgrupo = tb_SubGrupoProduto.cl_Id";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    grid_PesquisarProduto.DataSource = dt;
                }
            }
        }

        private void CarregarTabelaPorBuscaCodigoProduto(string _codigoProduto)
        {
            SqlConnection connection = conexao.Conectar();

            var sqlQuerry = $"SELECT cl_Codigo, cl_CodigoBarras, cl_Descricao, cl_Unidade, cl_PrecoCompra, cl_Margem, cl_Lucro, cl_PrecoVenda, cl_PrecoAPrazo, fk_cl_Id_Grupo, fk_cl_Id_Subgrupo, cl_Fornecedor, cl_EstoqueMinimo, cl_Garantia, cl_Marca, cl_Referencia, cl_DataValidade, cl_Comissao, cl_Observacoes, cl_EstoqueAtual, cl_Imagem FROM tb_Produto WHERE cl_Codigo LIKE'%{_codigoProduto}%' ";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    grid_PesquisarProduto.DataSource = dt;
                }
            }
        }

        private void CarregarTabelaPorBuscaReferenciaProduto(string _referenciaProduto)
        {
            SqlConnection connection = conexao.Conectar();

            var sqlQuerry = $"SELECT cl_Codigo, cl_CodigoBarras, cl_Descricao, cl_Unidade, cl_PrecoCompra, cl_Margem, cl_Lucro, cl_PrecoVenda, cl_PrecoAPrazo, fk_cl_Id_Grupo, fk_cl_Id_Subgrupo, cl_Fornecedor, cl_EstoqueMinimo, cl_Garantia, cl_Marca, cl_Referencia, cl_DataValidade, cl_Comissao, cl_Observacoes, cl_EstoqueAtual, cl_Imagem FROM tb_Produto WHERE cl_Referencia LIKE'%{_referenciaProduto}%' ";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    grid_PesquisarProduto.DataSource = dt;
                }
            }
        }

        private void CarregarTabelaPorBuscaDescricaoProduto(string _descricaoProduto)
        {
            SqlConnection connection = conexao.Conectar();

            var sqlQuerry = $"SELECT cl_Codigo, cl_CodigoBarras, cl_Descricao, cl_Unidade, cl_PrecoCompra, cl_Margem, cl_Lucro, cl_PrecoVenda, cl_PrecoAPrazo, fk_cl_Id_Grupo, fk_cl_Id_Subgrupo, cl_Fornecedor, cl_EstoqueMinimo, cl_Garantia, cl_Marca, cl_Referencia, cl_DataValidade, cl_Comissao, cl_Observacoes, cl_EstoqueAtual, cl_Imagem FROM tb_Produto WHERE cl_Descricao LIKE'%{_descricaoProduto}%' ";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    grid_PesquisarProduto.DataSource = dt;
                }
            }
        }

        private void CarregarTabelaPorBuscaMarcaProduto(string _marcaProduto)
        {
            SqlConnection connection = conexao.Conectar();

            var sqlQuerry = $"SELECT cl_Codigo, cl_CodigoBarras, cl_Descricao, cl_Unidade, cl_PrecoCompra, cl_Margem, cl_Lucro, cl_PrecoVenda, cl_PrecoAPrazo, fk_cl_Id_Grupo, fk_cl_Id_Subgrupo, cl_Fornecedor, cl_EstoqueMinimo, cl_Garantia, cl_Marca, cl_Referencia, cl_DataValidade, cl_Comissao, cl_Observacoes, cl_EstoqueAtual, cl_Imagem FROM tb_Produto WHERE cl_Marca LIKE'%{_marcaProduto}%' ";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    grid_PesquisarProduto.DataSource = dt;
                }
            }
        }

        private void PreencherFormAoClicarDuasVezes()
        {
            form_Fornecedor formFornecedor = new form_Fornecedor();
            form_Produto formProduto = new form_Produto();
            formProduto.lbl_Codigo.Text = grid_PesquisarProduto.SelectedCells[0].Value.ToString();
            formProduto.txt_CodigoProduto.Text = grid_PesquisarProduto.SelectedCells[0].Value.ToString();
            formProduto.txt_CodigoBarras.Text = grid_PesquisarProduto.SelectedCells[1].Value.ToString();
            formProduto.txt_Descricao.Text = grid_PesquisarProduto.SelectedCells[2].Value.ToString();
            formProduto.cmb_Unidade.Text = grid_PesquisarProduto.SelectedCells[3].Value.ToString();
            formProduto.txt_PrecoCompra.Text = grid_PesquisarProduto.SelectedCells[4].Value.ToString();
            formProduto.txt_Margem.Text = grid_PesquisarProduto.SelectedCells[5].Value.ToString();
            formProduto.txt_Lucro.Text = grid_PesquisarProduto.SelectedCells[6].Value.ToString();
            formProduto.txt_PrecoVenda.Text = grid_PesquisarProduto.SelectedCells[7].Value.ToString();
            formProduto.txt_PrecoAPrazo.Text = grid_PesquisarProduto.SelectedCells[8].Value.ToString();
            formProduto.cmb_Grupo.Text = grid_PesquisarProduto.SelectedCells[9].Value.ToString();
            formProduto.cmb_SubGrupo.Text = grid_PesquisarProduto.SelectedCells[10].Value.ToString();
            formProduto.cmb_Fornecedor.Text = grid_PesquisarProduto.SelectedCells[11].Value.ToString();
            formProduto.txt_EstoqueMinimo.Text = grid_PesquisarProduto.SelectedCells[12].Value.ToString();
            formProduto.txt_Garantia.Text = grid_PesquisarProduto.SelectedCells[13].Value.ToString();
            formProduto.txt_Marca.Text = grid_PesquisarProduto.SelectedCells[14].Value.ToString();
            formProduto.txt_Referencia.Text = grid_PesquisarProduto.SelectedCells[15].Value.ToString();
            formProduto.txt_Validade.Text = grid_PesquisarProduto.SelectedCells[16].Value.ToString();
            formProduto.txt_Comissao.Text = grid_PesquisarProduto.SelectedCells[17].Value.ToString();
            formProduto.txt_Observacao.Text = grid_PesquisarProduto.SelectedCells[18].Value.ToString();
            formProduto.txt_EstoqueAtual.Text = grid_PesquisarProduto.SelectedCells[19].Value.ToString();
            object imagemObject = grid_PesquisarProduto.SelectedCells[20].Value;
            if (!string.IsNullOrEmpty(imagemObject.ToString()))
            {
                byte[] imagemBytes = (byte[])imagemObject;
                formProduto.pbx_ImagemProduto.Image = formFornecedor.ConverterByteArrayEmImagem(imagemBytes);
            }

            formProduto.btn_GravarProduto.Enabled = false;
            formProduto.btn_GerarCodigoBarras.Enabled = false;
            formProduto.ShowDialog();
            Application.Exit();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_BuscaCodigoProduto_KeyUp(object sender, KeyEventArgs e)
        {
            CarregarTabelaPorBuscaCodigoProduto(txt_BuscaCodigoProduto.Text);
        }

        private void txt_BuscarReferencia_KeyUp(object sender, KeyEventArgs e)
        {
            CarregarTabelaPorBuscaReferenciaProduto(txt_BuscarReferencia.Text);
        }

        private void txt_BuscarDescricao_KeyUp(object sender, KeyEventArgs e)
        {
            CarregarTabelaPorBuscaDescricaoProduto(txt_BuscarDescricao.Text);
        }

        private void txt_BuscarMarca_KeyUp(object sender, KeyEventArgs e)
        {
            CarregarTabelaPorBuscaMarcaProduto(txt_BuscarMarca.Text);
        }

        private void form_ProcurarProduto_Load(object sender, EventArgs e)
        {
            CarregarTabelaPorBuscaProduto();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid_PesquisarProduto_DoubleClick(object sender, EventArgs e)
        {
            PreencherFormAoClicarDuasVezes();
        }

        private void btn_AbrirCadastroProdutos_Click(object sender, EventArgs e)
        {
            form_Produto formProduto = new form_Produto();
            formProduto.ShowDialog();
        }
    }
}