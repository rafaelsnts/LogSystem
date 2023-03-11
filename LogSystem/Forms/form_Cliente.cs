using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class form_Cliente : Form
    {
        public string mensagem = "";

        public void Alerta(string msg, form_Alertas.enmType type)
        {
            form_Alertas form = new form_Alertas();
            form.showAlert(msg, type);
        }

        public form_Cliente()
        {
            InitializeComponent();
            txt_DataCadastro.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparTextBox()
        {
            txt_Codigo.Text = "";
            txt_Nome.Text = "";
            txt_Celular.Text = "";
            txt_TelefoneResidencial.Text = "";
            cmb_Tipo.Text = "";
            txt_Cpf_Cnpj.Text = "";
            txt_Rg.Text = "";
            txt_Emissor.Text = "";
            txt_DataEmissao.Text = "";
            cmb_EstadoCivil.Text = "";
            txt_InscricaoEstadual.Text = "";
            txt_Cep.Text = "";
            txt_Endereco.Text = "";
            txt_Complemento.Text = "";
            txt_Bairro.Text = "";
            txt_Cidade.Text = "";
            txt_Uf.Text = "";
            txt_Naturalidade.Text = "";
            txt_DataNascimento.Text = "";
            txt_Credito.Text = "";
            txt_Debito.Text = "";
            txt_Saldo.Text = "";
            cmb_Bloqueio.Text = "";
            txt_Email.Text = "";
        }

        private decimal[] ValidarCamposValor()
        {
            decimal valorCredito;
            decimal valorDebito;
            decimal valorSaldo;
            if (txt_Credito.Text.Length <= 0 & txt_Debito.Text.Length <= 0 & txt_Saldo.Text.Length <= 0)
            {
                valorCredito = 0;
                valorDebito = 0;
                valorSaldo = 0;
            }
            else
            {
                valorCredito = txt_Credito.Text.Length <= 0 ? 0 : Convert.ToDecimal(txt_Credito.Text.Replace(".", ","));
                valorDebito = txt_Debito.Text.Length <= 0 ? 0 : Convert.ToDecimal(txt_Debito.Text.Replace(".", ","));
                valorSaldo = txt_Saldo.Text.Length <= 0 ? 0 : Convert.ToDecimal(txt_Saldo.Text.Replace(".", ","));
            }

            return new[] { valorCredito, valorDebito, valorSaldo };
        }

        private void CadastroCliente()
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            ClienteEstrutura clienteEstrutura = new ClienteEstrutura();
            EnderecoEstrutura enderecoEstrutura = new EnderecoEstrutura();
            ContaEstrutura contaEstrutura = new ContaEstrutura();

            decimal saldo = ValidarCamposValor()[0] - ValidarCamposValor()[1];
            decimal valorCredito = ValidarCamposValor()[0];
            decimal valorDebito = ValidarCamposValor()[1];

            clienteEstrutura.cl_Data_Cadastro = Convert.ToDateTime(txt_DataCadastro.Text);
            clienteEstrutura.cl_Nome = txt_Nome.Text;
            clienteEstrutura.cl_Telefone = txt_Celular.Text;
            clienteEstrutura.cl_Telefone_Residencial = txt_TelefoneResidencial.Text;
            clienteEstrutura.cl_Tipo = cmb_Tipo.Text;
            clienteEstrutura.cl_Cpf_Cnpj = txt_Cpf_Cnpj.Text;
            clienteEstrutura.cl_Rg = txt_Rg.Text;
            clienteEstrutura.cl_Emissor = txt_Emissor.Text;
            clienteEstrutura.cl_Data_Emissao = Convert.ToDateTime(txt_DataEmissao.Text);
            clienteEstrutura.cl_Estado_Civil = cmb_EstadoCivil.Text;
            clienteEstrutura.cl_Inscricao_Estadual = txt_InscricaoEstadual.Text;
            enderecoEstrutura.cl_Cep = txt_Cep.Text;
            enderecoEstrutura.cl_Endereco = txt_Endereco.Text;
            enderecoEstrutura.cl_Complemento = txt_Complemento.Text;
            enderecoEstrutura.cl_Bairro = txt_Bairro.Text;
            enderecoEstrutura.cl_Cidade = txt_Cidade.Text;
            enderecoEstrutura.cl_Uf = txt_Uf.Text;
            enderecoEstrutura.cl_Naturalidade = txt_Naturalidade.Text;
            clienteEstrutura.cl_Data_Nascimento = Convert.ToDateTime(txt_DataNascimento.Text);
            contaEstrutura.cl_Credito = valorCredito;
            contaEstrutura.cl_Debito = valorDebito;
            contaEstrutura.cl_Saldo = saldo;
            contaEstrutura.cl_Bloqueio = Convert.ToBoolean(cmb_Bloqueio.Text);
            contaEstrutura.cl_Email = txt_Email.Text;
            this.mensagem = clienteDAO.CadastrarCliente(clienteEstrutura, enderecoEstrutura, contaEstrutura);
            if (clienteDAO.tem)
                {
                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Alerta("Cliente Cadastrado", form_Alertas.enmType.Success);
            }
            else
            {
                MessageBox.Show(clienteDAO.mensagem);
            }
        }

        private void AlterarInformacoesCliente()
        {
            // form_Cliente cliente = new form_Cliente();
            ClienteDAO clienteDAO = new ClienteDAO();
            ClienteEstrutura clienteEstrutura = new ClienteEstrutura();
            EnderecoEstrutura enderecoEstrutura = new EnderecoEstrutura();
            ContaEstrutura contaEstrutura = new ContaEstrutura();

            decimal saldo = ValidarCamposValor()[0] - ValidarCamposValor()[1];
            decimal valorCredito = ValidarCamposValor()[0];
            decimal valorDebito = ValidarCamposValor()[1];

            clienteEstrutura.cl_Nome = txt_Nome.Text;
            clienteEstrutura.cl_Telefone = txt_Celular.Text;
            clienteEstrutura.cl_Telefone_Residencial = txt_TelefoneResidencial.Text;
            clienteEstrutura.cl_Tipo = cmb_Tipo.Text;
            clienteEstrutura.cl_Cpf_Cnpj = txt_Cpf_Cnpj.Text;
            clienteEstrutura.cl_Rg = txt_Rg.Text;
            clienteEstrutura.cl_Emissor = txt_Emissor.Text;
            clienteEstrutura.cl_Data_Emissao = Convert.ToDateTime(txt_DataEmissao.Text);
            clienteEstrutura.cl_Estado_Civil = cmb_EstadoCivil.Text;
            clienteEstrutura.cl_Inscricao_Estadual = txt_InscricaoEstadual.Text;
            enderecoEstrutura.cl_Cep = txt_Cep.Text;
            enderecoEstrutura.cl_Endereco = txt_Endereco.Text;
            enderecoEstrutura.cl_Complemento = txt_Complemento.Text;
            enderecoEstrutura.cl_Bairro = txt_Bairro.Text;
            enderecoEstrutura.cl_Cidade = txt_Cidade.Text;
            enderecoEstrutura.cl_Uf = txt_Uf.Text;
            enderecoEstrutura.cl_Naturalidade = txt_Naturalidade.Text;
            clienteEstrutura.cl_Data_Nascimento = Convert.ToDateTime(txt_DataNascimento.Text);
            contaEstrutura.cl_Credito = valorCredito;
            contaEstrutura.cl_Debito = valorDebito;
            contaEstrutura.cl_Saldo = saldo;
            contaEstrutura.cl_Bloqueio = Convert.ToBoolean(cmb_Bloqueio.Text);
            contaEstrutura.cl_Email = txt_Email.Text;
            this.mensagem = clienteDAO.AlterarCliente(clienteEstrutura, enderecoEstrutura, contaEstrutura);
            if (clienteDAO.tem)
            {
                MessageBox.Show(mensagem, "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(clienteDAO.mensagem);
            }
        }

        private void btn_GravarCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente();
            LimparTextBox();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            LimparTextBox();
            btn_AlterarCliente.Enabled = false;
            btn_ProcurarCliente.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        private void btn_AlterarCliente_Click(object sender, EventArgs e)
        {
            AlterarInformacoesCliente();

            btn_Novo.Enabled = false;
            btn_GravarCliente.Enabled = false;
        }

        private void btn_ProcurarCliente_Click(object sender, EventArgs e)
        {
            form_ProcurarCliente formulario = new form_ProcurarCliente();
            formulario.ShowDialog();
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

        public void ValidarData(object sender, KeyPressEventArgs e)
        {
            TextBox Data = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                Data.SelectionStart = Data.Text.Length + 1;

                if (Data.Text.Length == 2 || Data.Text.Length == 5)
                    Data.Text += "/";
                else if (Data.Text.Length == 10)
                    Data.Text += "";
                Data.SelectionStart = Data.Text.Length + 1;
            }
        }

        private void txt_DataCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarData(sender, e);
            ApenasNumeros(e);
        }

        private void txt_DataEmissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarData(sender, e);
            ApenasNumeros(e);
        }

        private void txt_DataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarData(sender, e);
            ApenasNumeros(e);
        }

        public void ValidandoCnpjCpf(object sender, KeyPressEventArgs e)
        {
            Regex pattern = new Regex("[./-]");
            string cpfApenasDigitos = pattern.Replace(txt_Cpf_Cnpj.Text, "");
            int contadorCNPJ = 0;
            int contadorCPF = 0;
            if (cpfApenasDigitos.Length <= 12)
            {
                if (contadorCPF == 0)
                {
                    FormatarCampos.FormatarTodaStringParaCpf(sender, txt_Cpf_Cnpj);
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
                    FormatarCampos.FormatarTodaStringParaCnpj(sender, txt_Cpf_Cnpj);
                    contadorCNPJ++;
                }
                else
                {
                    FormatarCampos.FormatandoEmTempoRealParaCnpj(sender, e);
                }
            }
        }

        public void LocalizarCEP()
        {
            var service = new CorreiosApi();
            var dados = service.consultaCEP(txt_Cep.Text);

            txt_Endereco.Text = dados.end;
            txt_Complemento.Text = dados.complemento;
            txt_Bairro.Text = dados.bairro;
            txt_Cidade.Text = dados.cidade;
            txt_Uf.Text = dados.uf;
        }

        private void txt_Celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTelefone(sender, e);
        }

        private void txt_TelefoneResidencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTelefone(sender, e);
        }

        private void txt_Rg_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumeros(e);
        }

        private void txt_Credito_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumeros(e);
        }

        private void txt_Debito_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumeros(e);
        }

        private void txt_Saldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumeros(e);
        }

        private void cmb_Tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasLestras(e);
        }

        private void txt_Emissor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasLestras(e);
        }

        private void txt_InscricaoEstadual_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumeros(e);
        }

        private void txt_Uf_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasLestras(e);
        }

        private void cmb_EstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasLestras(e);
        }

        private void ExcluirCliente()
        {
            if (MessageBox.Show("Tem certeza?", "CERTEZA", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int codigoCliente = Convert.ToInt32(txt_Codigo.Text);
                ClienteDAO clienteDAO = new ClienteDAO();

                clienteDAO.DeletarCliente(codigoCliente);
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            ExcluirCliente();
            LimparTextBox();
        }

        private void txt_Cep_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumeros(e);
        }

        private void txt_Naturalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasLestras(e);
        }

        private void txt_Cpf_Cnpj_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidandoCnpjCpf(sender, e);
        }

        private void txt_Cep_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }
    }
}