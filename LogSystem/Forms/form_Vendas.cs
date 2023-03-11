using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Security.Tokens;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogSystem.DAO;
using LogSystem.Estruturas;

namespace LogSystem.Forms
{
    public partial class form_Vendas : Form
    {
        private NotasFiscaisDAO nfDAO = new NotasFiscaisDAO();
        private VendaDAO vendaDAO = new VendaDAO();
        private Conexao conexao = new Conexao();
        private SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public void Alerta(string msg, form_Alertas.enmType type)
        {
            form_Alertas form = new form_Alertas();
            form.showAlert(msg, type);
        }

        public form_Vendas()
        {
            InitializeComponent();
            CarregarCombobox();
            CarregarTextboxFormatoMoeda();
            txt_Data.Text = DateTime.Now.ToShortDateString();

            //   PreencherGridView();
        }

        private void PreencherGridView()
        {
            // Create a new row first as it will include the columns you've created at design-time.

            int rowId = grid_Vendas.Rows.Add();

            // Grab the new row!
            DataGridViewRow row = grid_Vendas.Rows[rowId];
            txt_QuantidadeItens.Text = (grid_Vendas.Rows.Count - 1).ToString();
            // Add the data
            row.Cells["Codigo"].Value = lbl_Codigo.Text;
            // row.Cells["CodigoBarras"].Value = txt_CodigoBarras.Text;
            row.Cells["Descricao"].Value = cmb_Produto.Text;
            row.Cells["UN"].Value = txt_Unidade.Text;
            row.Cells["Qtde"].Value = txt_Quantidade.Text;
            row.Cells["PrecoUnitario"].Value = txt_PrecoVenda.Text;
            //  row.Cells["PorcentagemDesconto"].Value = txt_Desconto.Text;
            //  row.Cells["ValorDesconto"].Value = txt_Desconto.Text;
            row.Cells["TotalBruto"].Value = CalcularTotalBrutoCadaProduto();
            // PegarTotalBruto();
            SomarTotalBrutoGridView();
            //row.Cells["TotalLiquido"].Value = txt_TotalLiquido.Text;
        }

        private void SomarTotalBrutoGridView()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in grid_Vendas.Rows)
            {
                decimal value = Convert.ToDecimal(row.Cells[5].Value);
                total += value;
            }

            txt_TotalBruto.Text = total.ToString();
        }

        private string CalcularTotalBrutoCadaProduto()
        {
            if (!string.IsNullOrWhiteSpace(txt_Quantidade.Text) && !string.IsNullOrWhiteSpace(txt_PrecoVenda.Text))
            {
                decimal quantidade = Convert.ToDecimal(txt_Quantidade.Text);
                decimal precoUnitario = Convert.ToDecimal(txt_PrecoVenda.Text);
                decimal totalBruto = quantidade * precoUnitario;
                return totalBruto.ToString();
            }

            return "";
        }

        private void PegarTotalBruto()
        {
            int total = 0;
            foreach (DataGridViewRow row in grid_Vendas.Rows)
            {
                total += Convert.ToInt32(row.Cells["PrecoUnitario"].Value);
            }

            txt_TotalBruto.Text = total.ToString();
        }

        private void CarregarTextboxFormatoMoeda()
        {
            txt_TotalBruto.Text = string.Format("{0:c}", 0d);
            txt_TotalLiquido.Text = string.Format("{0:c}", 0d);
            txt_TotalPago.Text = string.Format("{0:c}", 0d);
            txt_Troco.Text = string.Format("{0:c}", 0d);
        }

        private void CarregarCombobox()
        {
            CarregarComboboxCliente();
            CarregarComboboxLogin();
            CarregarComboboxNomeProduto();
            // CarregarComboboxCodigoBarrasProduto();
        }

        private void CarregarComboboxCliente()
        {
            List<string> Cliente = vendaDAO.BuscarCliente();
            foreach (string cliente in Cliente)
            {
                cmb_Cliente.Items.Add(cliente);
            }
        }

        private void CarregarComboboxLogin()
        {
            List<string> Login = vendaDAO.BuscarIdLoginUsuario();
            foreach (string login in Login)
            {
                cmb_Vendedor.Items.Add(login);
            }
        }

        private void CarregarComboboxNomeProduto()
        {
            Dictionary<int, string> NomeProduto = vendaDAO.BuscarProduto();

            DataTable dt = new DataTable("Table");
            dt.Columns.Add("ID");
            dt.Columns.Add("Nome");

            foreach (KeyValuePair<int, string> nomeProduto in NomeProduto)
            {
                dt.Rows.Add(new string[]
                {
                    $"{nomeProduto.Key}",
                    $"{nomeProduto.Value}"
                });
            }

            cmb_Produto.DataSource = dt;
            cmb_Produto.DisplayMember = "Nome";
            cmb_Produto.ValueMember = "ID";
            cmb_Produto.SelectedIndex = -1;
        }

        private void PreencherTextboxProduto()
        {
            try
            {
                using (SqlConnection connection = conexao.Conectar())
                {
                    string Querry =
                        "SELECT cl_CodigoBarras,cl_PrecoVenda, cl_Unidade from tb_Produto WHERE cl_Codigo = @ID";
                    SqlCommand cmd = new SqlCommand(Querry, connection);
                    cmd.Parameters.AddWithValue("@ID", cmb_Produto.SelectedValue);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lbl_Codigo.Text = cmb_Produto.SelectedValue.ToString();
                        txt_CodigoBarras.Text = reader["cl_CodigoBarras"].ToString();
                        txt_PrecoVenda.Text = reader["cl_PrecoVenda"].ToString();
                        txt_Unidade.Text = reader["cl_Unidade"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(this.mensagem = "Erro com o Banco de Dados!!! \n\n" + e);
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string CalcularTroco()
        {
            if (!string.IsNullOrWhiteSpace(txt_Troco.Text) && !string.IsNullOrWhiteSpace(txt_TotalPago.Text))
            {
                decimal totalLiquido = Convert.ToDecimal(txt_TotalLiquido.Text.TrimStart('R', '$').Trim());
                decimal totalPago = Convert.ToDecimal(txt_TotalPago.Text.TrimStart('R', '$').Trim());
                decimal troco = totalPago - totalLiquido;
                txt_Troco.Text = troco.ToString();
            }

            return txt_Troco.Text;
        }

        private string CalcularDesconto()
        {
            if (string.IsNullOrWhiteSpace(txt_Desconto.Text))
            {
                txt_TotalLiquido.Text = txt_TotalBruto.Text;
            }

            if (!string.IsNullOrWhiteSpace(txt_TotalBruto.Text) && !string.IsNullOrWhiteSpace(txt_Desconto.Text) && txt_Desconto.Text != "%")
            {
                decimal totalBruto = Convert.ToDecimal(txt_TotalBruto.Text.TrimStart('R', '$').Trim());
                // string descontoTratado = txt_Desconto.Text.Replace('%', ' ').Trim();
                string valor = Regex.Replace(txt_Desconto.Text, "[^0-9,]", "");
                double desconto = Convert.ToDouble(valor);
                decimal descontoLiquido = (totalBruto * (decimal)desconto) / 100;
                txt_TotalLiquido.Text = (totalBruto - descontoLiquido).ToString();
                //decimal totalBruto = Convert.ToDecimal(txt_TotalBruto.Text);
                //double desconto = Convert.ToDouble(txt_Desconto.Text);
                //decimal descontoLiquido = (totalBruto * (decimal)desconto) / 100;
                //txt_TotalLiquido.Text = (totalBruto - descontoLiquido).ToString();
            }

            return txt_TotalLiquido.Text;
        }

        public int GerarNumeroNF()
        {
            NFEstrutura nfEstrutura = new NFEstrutura();

            Random numAleatorio = new Random();

            string valorInteiro = "";
            for (int i = 0; i < 7; i++)
            {
                valorInteiro += numAleatorio.Next(0, 9);
            }

            nfEstrutura.nf_Numero = Convert.ToInt32(valorInteiro);
            return Convert.ToInt32(valorInteiro);
        }

        private void GerandoNF()
        {
            NFEstrutura nfe = new NFEstrutura();
            nfe.nf_Numero = GerarNumeroNF();
            nfe.nf_Data = DateTime.Now;
            int idUltimaVenda = PegandoIdUltimaVendaEfetuada();
            nfDAO.NotaFiscal(nfe, idUltimaVenda);
        }

        private void FinalizarVenda()
        {
            VendaEstrutura vendaEstrutura = new VendaEstrutura();
            //NFEstrutura nfEstrutura = new NFEstrutura();

            try
            {
                int idLogin = vendaDAO.BuscarIdLogin(cmb_Vendedor.SelectedItem.ToString());
                int idCliente = vendaDAO.BuscarIdCliente(cmb_Cliente.SelectedItem.ToString());
                int idProduto = Convert.ToInt32(cmb_Produto.SelectedValue);
                int codigoBarrasProduto = Convert.ToInt32(txt_CodigoBarras.Text);

                vendaEstrutura.vd_Data = DateTime.Now;
                vendaEstrutura.vd_fk_codProduto = idProduto;
                vendaEstrutura.vd_CodigoBarrasProduto = codigoBarrasProduto;
                vendaEstrutura.vd_fk_idCliente = idCliente;
                vendaEstrutura.vd_fk_idVendedor = idLogin;
                vendaEstrutura.vd_Item = Convert.ToInt32(txt_QuantidadeItens.Text);
                vendaEstrutura.vd_TotalBruto = Convert.ToDecimal(txt_TotalBruto.Text.TrimStart('R', '$').Trim());
                vendaEstrutura.vd_Desconto = Convert.ToDouble(txt_Desconto.Text.Trim('%'));
                vendaEstrutura.vd_TotalLiquido = Convert.ToDecimal(CalcularDesconto().TrimStart('R', '$').Trim());
                vendaEstrutura.vd_TotalPago = Convert.ToDecimal(txt_TotalPago.Text.TrimStart('R', '$').Trim());
                vendaEstrutura.vd_Troco = Convert.ToDecimal(CalcularTroco().TrimStart('R', '$').Trim());
                vendaEstrutura.vd_Item = Convert.ToInt32(txt_QuantidadeItens.Text);
                this.mensagem = vendaDAO.CadastrarVenda(vendaEstrutura, idProduto.ToString(),
                    idCliente.ToString(), idLogin.ToString());
                if (vendaDAO.tem)
                {
                    MessageBox.Show(mensagem, "Venda Realizada Com Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(vendaDAO.mensagem);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "Erro ao Realizar a venda");
                throw;
            }

            GerandoNF();
        }

        private int PegandoIdUltimaVendaEfetuada()
        {
            int id = 0;
            try
            {
                using (SqlConnection connection = conexao.Conectar())
                {
                    string Querry = "SELECT TOP 1 * FROM tb_Venda ORDER BY vd_Id DESC";
                    SqlCommand cmd = new SqlCommand(Querry, connection);
                    // cmd.Parameters.AddWithValue("@ID", _idUltimaVenda);
                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();
                    id = (int)reader["vd_Id"];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(this.mensagem = "Erro com o Banco de Dados!!! \n\n" + e);
            }
            return id;
        }

        private void btn_GravarProduto_Click(object sender, EventArgs e)
        {
            FinalizarVenda();
        }

        private void cmb_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherTextboxProduto();
        }

        public void TextBoxFormatacaoMoeda(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.ReadOnly == false)
            {
                if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    string w = Regex.Replace(t.Text, "[^0-9]", string.Empty);
                    if (w == string.Empty) w = "00";

                    if (e.KeyChar.Equals((char)Keys.Back)) // if backspace
                        w = w.Substring(0, w.Length - 1); // tira o digito a direita
                    else
                        w += e.KeyChar;

                    t.Text = string.Format("{0:#,##0.00}", Double.Parse(w) / 100);
                    t.Select(t.Text.Length, 0);
                }

                e.Handled = true;
            }
        }

        private void txt_TotalBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxFormatacaoMoeda(sender, e);
            Refresh();
        }

        private void txt_TotalLiquido_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxFormatacaoMoeda(sender, e);
        }

        private void txt_TotalPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxFormatacaoMoeda(sender, e);
        }

        private void txt_Troco_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxFormatacaoMoeda(sender, e);
        }

        private void txt_PrecoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PreencherGridView();
            }
        }

        private void txt_TotalPago_TextChanged(object sender, EventArgs e)
        {
            CalcularTroco();
        }

        private void FormatacaoMoeda(object sender, KeyEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string valor = Regex.Replace(txt.Text, "[^0-9]", "");
            //  valor = valor.PadLeft(3, '0');
            // valor = valor.Insert(valor.Length - 2, ",");
            txt.Text = string.Format("{0:C}", double.Parse(valor));
            txt.Select(txt.Text.Length, 0);
        }

        private void FormatacaoMoedaTotalLiquido(object sender, KeyEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string valor = Regex.Replace(txt.Text, "[^0-9,]", "");
            //  valor = valor.PadLeft(3, '0');
            // valor = valor.Insert(valor.Length - 2, ",");
            txt.Text = string.Format("{0:C}", double.Parse(valor));
            txt.Select(txt.Text.Length, 0);
        }

        private void FormatacaoMoedaDesconto(object sender, KeyEventArgs e)
        {
            //TextBox txt = (TextBox)sender;
            //string valor = Regex.Replace(txt.Text, "[^0-9,]", "");
            ////  valor = valor.PadLeft(3, '0');
            //// valor = valor.Insert(valor.Length - 2, ",");
            //txt.Text = string.Format("{0:##,##%}", double.Parse(valor));
            //txt.Select(txt.Text.Length, 0);

            //TextBox txt = (TextBox)sender;
            //string valor = txt.Text.Replace("%", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            //if (valor.Length == 0)
            //{
            //    txt.Text = "0,00" + valor;
            //}

            //if (valor.Length == 1)
            //{
            //    txt.Text = "0,0" + valor;
            //}

            //if (valor.Length == 2)
            //{
            //    txt.Text = "0," + valor;
            //}
            //else if (valor.Length >= 3)
            //{
            //    if (txt.Text.StartsWith("0,"))
            //    {
            //        txt.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
            //    }
            //    else if (txt.Text.Contains("00,"))
            //    {
            //        txt.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
            //    }
            //    else
            //    {
            //        txt.Text = valor.Insert(valor.Length - 2, ",");
            //    }
            //}

            //valor = txt.Text;
            //txt.Text = $"{Convert.ToDouble(valor)}%";
            //txt.Select(txt.Text.Length, 0);
        }

        private void txt_TotalBruto_KeyUp(object sender, KeyEventArgs e)
        {
            FormatacaoMoeda(sender, e);
        }

        private void txt_TotalLiquido_KeyUp(object sender, KeyEventArgs e)
        {
            FormatacaoMoedaTotalLiquido(sender, e);
        }

        private void txt_TotalPago_KeyUp(object sender, KeyEventArgs e)
        {
            FormatacaoMoedaTotalLiquido(sender, e);
        }

        private void txt_Troco_KeyUp(object sender, KeyEventArgs e)
        {
            FormatacaoMoedaTotalLiquido(sender, e);
        }

        private void txt_Desconto_TextChanged_1(object sender, EventArgs e)
        {
            CalcularDesconto();
            if (!txt_Desconto.Text.EndsWith("%"))
            {
                txt_Desconto.Text = txt_Desconto.Text + "%";
                txt_Desconto.SelectionStart = txt_Desconto.Text.Length - 1;
            }
        }

        private void txt_Desconto_KeyUp(object sender, KeyEventArgs e)
        {
            FormatacaoMoedaDesconto(sender, e);
        }

        private void btn_NovoProduto_Click(object sender, EventArgs e)
        {
            txt_TotalBruto.Text = string.Format("{0:c}", 0d);
            txt_TotalLiquido.Text = string.Format("{0:c}", 0d);
            txt_TotalPago.Text = string.Format("{0:c}", 0d);
            txt_Troco.Text = string.Format("{0:c}", 0d);
            txt_CodigoBarras.Text = "";
            txt_NumeroVenda.Text = "";
            cmb_Cliente.Text = "";
            cmb_Vendedor.Text = "";
            txt_Quantidade.Text = "";
            txt_Unidade.Text = "";
            txt_PrecoVenda.Text = "";
            grid_Vendas.Rows.Clear();
        }

        private void btn_ProcurarProduto_Click(object sender, EventArgs e)
        {
            form_LocalizarVenda form = new form_LocalizarVenda();
            form.ShowDialog();
        }

        //private void CalcularTotalBrutoPorItensAdicionados()
        //{
        //    //if (string.IsNullOrWhiteSpace(txt_Desconto.Text))
        //    //{
        //    //    txt_TotalLiquido.Text = txt_TotalBruto.Text;
        //    //}

        //    if (!string.IsNullOrWhiteSpace(txt_Quantidade.Text) && !string.IsNullOrWhiteSpace(txt_PrecoVenda.Text) && txt_Desconto.Text != "%")
        //    {
        //        int qtde = Convert.ToInt32(txt_Quantidade.Text);
        //        decimal precoVenda = Convert.ToDecimal(txt_PrecoVenda.Text);
        //        decimal totalBruto = qtde * precoVenda;
        //        txt_TotalLiquido.Text = totalBruto.ToString();
        //    }
        //}

        private void AtualizarTotalBruto()
        {
            double quantidade;
            double valorUnitario;

            if (double.TryParse(txt_Quantidade.Text, out quantidade) &&
                double.TryParse(txt_PrecoVenda.Text, out valorUnitario))
            {
                double totalBruto = quantidade * valorUnitario;
                txt_TotalBruto.Text = totalBruto.ToString("N2");
            }
        }

        private void txt_Quantidade_TextChanged(object sender, EventArgs e)
        {
            double quantidade;
            if (double.TryParse(txt_Quantidade.Text, out quantidade))
            {
                AtualizarTotalBruto();
            }
        }

        private void txt_TotalBruto_TextChanged(object sender, EventArgs e)
        {
            txt_TotalLiquido.Text = txt_TotalBruto.Text;
        }

        private void txt_Quantidade_KeyUp(object sender, KeyEventArgs e)
        {
            double valorUnitario;
            if (double.TryParse(txt_Quantidade.Text, out valorUnitario))
            {
                AtualizarTotalBruto();
            }
        }

        private void txt_PrecoVenda_TextChanged(object sender, EventArgs e)
        {
            AtualizarTotalBruto();
        }

        private void btn_ImprimirNF_Click(object sender, EventArgs e)
        {
            form_NotaFiscal formNotaFiscal = new form_NotaFiscal();
            formNotaFiscal.ShowDialog();
            formNotaFiscal.GetNotasFiscais();
        }
    }
}