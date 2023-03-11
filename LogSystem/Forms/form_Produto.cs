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
using LogSystem.Estruturas;

namespace LogSystem.Forms
{
    public partial class form_Produto : Form
    {
        public string mensagem = "";
        private Conexao conexao = new Conexao();
        private ProdutoDAO produtoDAO = new ProdutoDAO();

        public void Alerta(string msg, form_Alertas.enmType type)
        {
            form_Alertas form = new form_Alertas();
            form.showAlert(msg, type);
        }

        public form_Produto()
        {
            InitializeComponent();
            CarregandoCombobox();
        }

        private void CarregandoCombobox()
        {
            CarregarComboboxFornecedor();
            CarregarComboboxGrupoProduto();
            CarregarComboboxSubGrupoProduto();
        }

        private decimal[] CalcularValorMargem()
        {
            decimal valorCompra;
            decimal valorMargem;
            decimal valorLucro;
            decimal valorVenda;
            decimal valorVendaPrazo;

            if (txt_PrecoCompra.Text.Length <= 0 & txt_Margem.Text.Length <= 0 & txt_Lucro.Text.Length <= 0 & txt_PrecoVenda.Text.Length <= 0 & txt_PrecoAPrazo.Text.Length <= 0)
            {
                valorCompra = 0;
                valorMargem = 0;
                valorLucro = 0;
                valorVenda = 0;
                valorVendaPrazo = 0;
            }
            else
            {
                valorCompra = txt_PrecoCompra.Text.Length <= 0 ? 0 : Convert.ToDecimal(txt_PrecoCompra.Text.Replace(".", ","));
                valorMargem = txt_Margem.Text.Length <= 0 ? 0 : Convert.ToDecimal(txt_Margem.Text.Replace(".", ","));
                valorLucro = txt_Lucro.Text.Length <= 0 ? 0 : Convert.ToDecimal(txt_Lucro.Text.Replace(".", ","));
                valorVenda = txt_PrecoVenda.Text.Length <= 0 ? 0 : Convert.ToDecimal(txt_PrecoVenda.Text.Replace(".", ","));
                valorVendaPrazo = txt_PrecoAPrazo.Text.Length <= 0 ? 0 : Convert.ToDecimal(txt_PrecoAPrazo.Text.Replace(".", ","));
            }

            return new[] { valorCompra, valorMargem, valorLucro, valorVenda, valorVendaPrazo };
        }

        private void LimparTextBox()
        {
            txt_CodigoProduto.Text = "";
            txt_CodigoBarras.Text = "";
            txt_Descricao.Text = "";
            cmb_Unidade.Text = "";
            txt_PrecoCompra.Text = "";
            txt_Margem.Text = "";
            txt_Lucro.Text = "";
            txt_PrecoVenda.Text = "";
            txt_PrecoAPrazo.Text = "";
            cmb_Grupo.Text = "";
            cmb_SubGrupo.Text = "";
            cmb_Fornecedor.Text = "";
            txt_EstoqueMinimo.Text = "";
            txt_Garantia.Text = "";
            txt_Marca.Text = "";
            txt_Referencia.Text = "";
            txt_Validade.Text = "";
            txt_Comissao.Text = "";
            txt_Observacao.Text = "";
            txt_EstoqueAtual.Text = "";
        }

        private void CadastrarGrupoProduto()
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            GrupoProdutoEstrutura grupoProdutoEstrutura = new GrupoProdutoEstrutura();

            grupoProdutoEstrutura.cl_Grupo = cmb_Grupo.Text;
            this.mensagem = produtoDAO.CadastrarGrupoProduto(grupoProdutoEstrutura);
            if (produtoDAO.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(produtoDAO.mensagem);
            }
        }

        private void CadastrarSubGrupoProduto()
        {
            SubGrupoProdutoEstrutura subGrupoProdutoEstrutura = new SubGrupoProdutoEstrutura();

            subGrupoProdutoEstrutura.cl_SubGrupo = cmb_SubGrupo.Text;
            this.mensagem = produtoDAO.CadastrarSubGrupoProduto(subGrupoProdutoEstrutura);
            if (produtoDAO.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(produtoDAO.mensagem);
            }
        }

        private void CadastroProduto()
        {
            ProdutoEstrutura produtoEstrutura = new ProdutoEstrutura();
            GrupoProdutoEstrutura grupoProdutoEstrutura = new GrupoProdutoEstrutura();
            SubGrupoProdutoEstrutura subGrupoProdutoEstrutura = new SubGrupoProdutoEstrutura();
            form_Fornecedor formFornecedor = new form_Fornecedor();
            decimal lucro = CalcularValorMargem()[3] - CalcularValorMargem()[0];
            decimal valorCompra = CalcularValorMargem()[0];
            decimal margem = (lucro * 100) / valorCompra;

            int idGrupoProduto = produtoDAO.BuscarIdGrupoProduto(cmb_Grupo.SelectedItem.ToString());
            int idSubGrupoProduto = produtoDAO.BuscarIdSubGrupoProduto(cmb_SubGrupo.SelectedItem.ToString());

            produtoEstrutura.cl_CodigoBarras = Convert.ToInt32(txt_CodigoBarras.Text);
            produtoEstrutura.cl_Descricao = txt_Descricao.Text;
            produtoEstrutura.cl_Unidade = cmb_Unidade.Text;
            produtoEstrutura.cl_PrecoCompra = Convert.ToDecimal(txt_PrecoCompra.Text);
            produtoEstrutura.cl_Margem = margem;
            produtoEstrutura.cl_Lucro = lucro;
            produtoEstrutura.cl_PrecoVenda = Convert.ToDecimal(txt_PrecoVenda.Text);
            produtoEstrutura.cl_PrecoAPrazo = Convert.ToDecimal(txt_PrecoAPrazo.Text);
            grupoProdutoEstrutura.cl_Grupo = idGrupoProduto.ToString();
            subGrupoProdutoEstrutura.cl_SubGrupo = idSubGrupoProduto.ToString();
            produtoEstrutura.cl_Fornecedor = cmb_Fornecedor.Text;
            produtoEstrutura.cl_EstoqueMinimo = Convert.ToInt32(txt_EstoqueMinimo.Text);
            produtoEstrutura.cl_Garantia = txt_Garantia.Text;
            produtoEstrutura.cl_Marca = txt_Marca.Text;
            produtoEstrutura.cl_Referencia = txt_Referencia.Text;
            produtoEstrutura.cl_DataValidade = Convert.ToDateTime(txt_Validade.Text);
            produtoEstrutura.cl_Comissao = Convert.ToDecimal(txt_Comissao.Text);
            produtoEstrutura.cl_Observacoes = txt_Observacao.Text;
            produtoEstrutura.cl_EstoqueAtual = Convert.ToInt32(txt_EstoqueAtual.Text);
            produtoEstrutura.cl_Imagem = formFornecedor.ConverterImagemEmBytes(pbx_ImagemProduto.Image);
            this.mensagem = produtoDAO.CadastrarProduto(produtoEstrutura, grupoProdutoEstrutura, subGrupoProdutoEstrutura);
            if (produtoDAO.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alerta("Produto Cadastrado", form_Alertas.enmType.Success);
            }
            else
            {
                MessageBox.Show(produtoDAO.mensagem);
            }
        }

        private void btn_GravarProduto_Click(object sender, EventArgs e)
        {
            CadastroProduto();
            LimparTextBox();
        }

        private void GerarCodigoDeBarras()
        {
            Random numAleatorio = new Random();

            string valorInteiro = "";
            for (int i = 0; i < 13; i++)
            {
                valorInteiro += numAleatorio.Next(0, 9);
            }

            txt_CodigoBarras.Text = valorInteiro.ToString();
        }

        private void btn_GerarCodigoBarras_Click(object sender, EventArgs e)
        {
            GerarCodigoDeBarras();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_NovoProduto_Click(object sender, EventArgs e)
        {
            LimparTextBox();
        }

        private void btn_ProcurarProduto_Click(object sender, EventArgs e)
        {
            form_ProcurarProduto formProcurarProduto = new form_ProcurarProduto();
            formProcurarProduto.ShowDialog();
        }

        //private void CarregarComboboxSubGrupoProduto()
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("SELECT cl_SubGrupo from tb_SubGrupoProduto ORDER BY cl_SubGrupo ASC");
        //        // SqlCommand cmd = new SqlCommand("SELECT cl_SubGrupo from tb_SubGrupoProduto INNER JOIN tb_Produto ON tb_SubGrupoProduto.cl_Id = tb_Produto.fk_cl_Id_Subgrupo ORDER BY cl_SubGrupo ASC");
        //        //SqlCommand cmd = new SqlCommand("SELECT cl_SubGrupo FROM tb_Produto INNER JOIN tb_SubGrupoProduto ON tb_Produto.fk_cl_Id_Subgrupo = tb_SubGrupoProduto.cl_Id");
        //        cmd.Connection = conexao.Conectar();
        //        DataTable table = new DataTable();

        //        table.Load(cmd.ExecuteReader());
        //        DataRow row = table.NewRow();
        //        row["cl_SubGrupo"] = "";
        //        table.Rows.InsertAt(row, 0);

        //        this.cmb_SubGrupo.DataSource = table;
        //        this.cmb_SubGrupo.ValueMember = "cl_SubGrupo";

        //        cmd.ExecuteReader().Close();
        //        cmd.ExecuteReader().Dispose();
        //    }
        //    catch (SqlException e)
        //    {
        //        MessageBox.Show("Não foi possível preencher o Combobox \n\nErro:" + e, "Erro", MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        conexao.Desconectar();
        //    }
        //}
        private void CarregarComboboxSubGrupoProduto()
        {
            List<string> SubGrupoFornecedores = produtoDAO.BuscarIdSubGrupoProdutos();
            foreach (string subGrupoFornecedor in SubGrupoFornecedores)
            {
                cmb_SubGrupo.Items.Add(subGrupoFornecedor);
            }
        }

        private void CarregarComboboxGrupoProduto()
        {
            List<string> GrupoFornecedores = produtoDAO.BuscarIdGrupoProdutos();
            foreach (string grupoFornecedor in GrupoFornecedores)
            {
                cmb_Grupo.Items.Add(grupoFornecedor);
            }
        }

        //private void CarregarComboboxGrupoFornecedor()
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("SELECT cl_Grupo from tb_GrupoProduto ORDER BY cl_Grupo ASC");
        //        cmd.Connection = conexao.Conectar();
        //        DataTable table = new DataTable();

        //        table.Load(cmd.ExecuteReader());
        //        DataRow row = table.NewRow();
        //        row["cl_Grupo"] = "";
        //        table.Rows.InsertAt(row, 0);

        //        this.cmb_Grupo.DataSource = table;
        //        this.cmb_Grupo.ValueMember = "cl_Grupo";

        //        cmd.ExecuteReader().Close();
        //        cmd.ExecuteReader().Dispose();
        //    }
        //    catch (SqlException e)
        //    {
        //        MessageBox.Show("Não foi possível preencher o Combobox \n\nErro:" + e, "Erro", MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        conexao.Desconectar();
        //    }
        //}

        private void InserirImagemProduto()
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            { Filter = "Image files (*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbx_ImagemProduto.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void CarregarComboboxFornecedor()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT cl_NomeFantasia from tb_Fornecedor ORDER BY cl_NomeFantasia ASC");
                cmd.Connection = conexao.Conectar();
                DataTable table = new DataTable();

                table.Load(cmd.ExecuteReader());
                DataRow row = table.NewRow();
                row["cl_NomeFantasia"] = "";
                table.Rows.InsertAt(row, 0);

                this.cmb_Fornecedor.DataSource = table;
                this.cmb_Fornecedor.ValueMember = "cl_NomeFantasia";

                cmd.ExecuteReader().Close();
                cmd.ExecuteReader().Dispose();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Não foi possível preencher o Combobox \n\nErro:" + e, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        private void btn_InserirFoto_Click(object sender, EventArgs e)
        {
            InserirImagemProduto();
        }

        private void btn_CadastrarGrupo_Click(object sender, EventArgs e)
        {
            CadastrarGrupoProduto();
        }

        private void btn_CadastrarSubGrupo_Click(object sender, EventArgs e)
        {
            CadastrarSubGrupoProduto();
        }

        private void txt_Validade_KeyPress(object sender, KeyPressEventArgs e)
        {
            form_Cliente form = new form_Cliente();
            form.ValidarData(sender, e);
        }
    }
}