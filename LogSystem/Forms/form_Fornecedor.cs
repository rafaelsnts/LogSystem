using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;

using LogSystem.DAO;
using LogSystem.Estruturas;

namespace LogSystem.Forms
{
    public partial class form_Fornecedor : Form
    {
        private Conexao conexao = new Conexao();
        public string mensagem = "";
        private int contadorCNPJ = 0;
        private int contadorCPF = 0;

        public form_Fornecedor()
        {
            InitializeComponent();
        }

        public void CarregandoBotoes()
        {
            btn_AlterarFornecedor.Enabled = false;
            btn_ExcluirFornecedor.Enabled = false;
        }

        private void LimparTextBox()
        {
            txt_Codigo.Text = "";
            txt_NomeFantasia.Text = "";
            txt_RazaoSocial.Text = "";
            txt_Cep.Text = "";
            txt_Endereco.Text = "";
            txt_Cidade.Text = "";
            txt_InscEstadual.Text = "";
            txt_InscMunicipal.Text = "";
            txt_CnpjCpf.Text = "";
            txt_Telefone.Text = "";
            txt_Email.Text = "";
        }

        private void ExcluirFornecedor()
        {
            if (MessageBox.Show("Tem certeza?", "CERTEZA", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int codigoFornecedor = Convert.ToInt32(txt_Codigo.Text);
                FornecedorDAO fornecedorDao = new FornecedorDAO();
                fornecedorDao.ExcluirFornecedor(codigoFornecedor);
            }
        }

        private void AlterarInformacoesFornecedor()
        {
            FornecedorDAO fornecedorDao = new FornecedorDAO();
            FornecedorEstrutura fornecedorEstrutura = new FornecedorEstrutura();

            fornecedorEstrutura.cl_Codigo = Convert.ToInt32(txt_Codigo.Text);
            fornecedorEstrutura.cl_NomeFantasia = txt_NomeFantasia.Text;
            fornecedorEstrutura.cl_RazaoSocial = txt_RazaoSocial.Text;
            fornecedorEstrutura.cl_Cep = txt_Cep.Text;
            fornecedorEstrutura.cl_Endereco = txt_Endereco.Text;
            fornecedorEstrutura.cl_Cidade = txt_Cidade.Text;
            fornecedorEstrutura.cl_CnpjCpf = txt_CnpjCpf.Text;
            fornecedorEstrutura.cl_InscricaoEstadual = txt_InscEstadual.Text;
            fornecedorEstrutura.cl_InscricaoMunicipal = txt_InscMunicipal.Text;
            fornecedorEstrutura.cl_Telefone = txt_Telefone.Text;
            fornecedorEstrutura.cl_Email = txt_Email.Text;
            fornecedorEstrutura.cl_Imagem = ConverterImagemEmBytes(pbx_FotoCliente.Image);

            this.mensagem = fornecedorDao.AlterarFornecedor(fornecedorEstrutura);
            if (fornecedorDao.tem)
            {
                MessageBox.Show(mensagem, "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(fornecedorDao.mensagem);
            }
        }

        private void CadastrarFornecedor()
        {
            FornecedorDAO fornecedorDao = new FornecedorDAO();
            FornecedorEstrutura fornecedorEstrutura = new FornecedorEstrutura();

            fornecedorEstrutura.cl_NomeFantasia = txt_NomeFantasia.Text;
            fornecedorEstrutura.cl_RazaoSocial = txt_RazaoSocial.Text;
            fornecedorEstrutura.cl_Cep = txt_Cep.Text;
            fornecedorEstrutura.cl_Endereco = txt_Endereco.Text;
            fornecedorEstrutura.cl_Cidade = txt_Cidade.Text;
            fornecedorEstrutura.cl_CnpjCpf = txt_CnpjCpf.Text;
            fornecedorEstrutura.cl_InscricaoEstadual = txt_InscEstadual.Text;
            fornecedorEstrutura.cl_InscricaoMunicipal = txt_InscMunicipal.Text;
            fornecedorEstrutura.cl_Telefone = txt_Telefone.Text;
            fornecedorEstrutura.cl_Email = txt_Email.Text;
            fornecedorEstrutura.cl_Imagem = ConverterImagemEmBytes(pbx_FotoCliente.Image);
            this.mensagem = fornecedorDao.CadastrarFornecedor(fornecedorEstrutura);

            if (fornecedorDao.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(fornecedorDao.mensagem);
            }
        }

        private void btn_GravarFornecedor_Click(object sender, EventArgs e)
        {
            CadastrarFornecedor();
        }

        private void btn_AlterarFornecedor_Click(object sender, EventArgs e)
        {
            AlterarInformacoesFornecedor();
            btn_NovoFornecedor.Enabled = true;
            btn_GravarFornecedor.Enabled = false;
            btn_AlterarFornecedor.Enabled = true;
            btn_ExcluirFornecedor.Enabled = true;
        }

        private void btn_NovoFornecedor_Click(object sender, EventArgs e)
        {
            LimparTextBox();
            btn_AlterarFornecedor.Enabled = false;
            btn_ExcluirFornecedor.Enabled = false;
            btn_ProcurarFornecedor.Enabled = false;
            btn_GravarFornecedor.Enabled = true;
        }

        private void btn_ExcluirFornecedor_Click(object sender, EventArgs e)
        {
            ExcluirFornecedor();
            LimparTextBox();
        }

        private void btn_ProcurarFornecedor_Click(object sender, EventArgs e)
        {
            form_ProcurarFornecedor formulario = new form_ProcurarFornecedor();
            formulario.ShowDialog();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ValidandoCnpjCpf(object sender, KeyPressEventArgs e)
        {
            Regex pattern = new Regex("[./-]");
            string cpfApenasDigitos = pattern.Replace(txt_CnpjCpf.Text, "");

            if (cpfApenasDigitos.Length <= 12)
            {
                if (contadorCPF == 0)
                {
                    FormatarCampos.FormatarTodaStringParaCpf(sender, txt_CnpjCpf);
                    contadorCPF++;
                }
                else
                {
                    FormatarCampos.FormatandoEmTempoRealParaCpf(sender, e);
                }
            }
            else
            {
                if (contadorCNPJ == 0)
                {
                    FormatarCampos.FormatarTodaStringParaCnpj(sender, txt_CnpjCpf);
                    contadorCNPJ++;
                }
                else
                {
                    FormatarCampos.FormatandoEmTempoRealParaCnpj(sender, e);
                }
            }
        }

        private void ValidarTelefone(object sender, KeyPressEventArgs e)
        {
            TextBox Tel = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                Tel.SelectionStart = Tel.Text.Length + 1;

                if (Tel.Text.Length == 0 || Tel.Text.Length == 1)
                    Tel.Text += "(";
                else if (Tel.Text.Length == 3)
                    Tel.Text += ")";
                else if (Tel.Text.Length == 9)
                    Tel.Text += "-";
                Tel.SelectionStart = Tel.Text.Length + 1;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void ApenasNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void ApenasLestras(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        public void LocalizarCEP()
        {
            var service = new CorreiosApi();
            var dados = service.consultaCEP(txt_Cep.Text);

            // lendo o bairro do objeto
            txt_Endereco.Text = dados.end;
            txt_Cidade.Text = dados.cidade;
        }

        public byte[] ConverterImagemEmBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ConverterByteArrayEmImagem(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void InserirImagemFornecedor()
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            { Filter = "Image files (*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbx_FotoCliente.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void txt_Cpf_Cnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidandoCnpjCpf(sender, e);
        }

        private void btn_InserirFoto_Click(object sender, EventArgs e)
        {
            InserirImagemFornecedor();
        }

        private void txt_Cep_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumeros(e);
        }

        private void txt_Cep_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        private void txt_Cidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasLestras(e);
        }

        private void txt_Telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTelefone(sender, e);
        }

        private void txt_InscEstadual_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasLestras(e);
        }

        private void txt_InscMunicipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasLestras(e);
        }
    }
}