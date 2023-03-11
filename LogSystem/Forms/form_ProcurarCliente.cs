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
    public partial class form_ProcurarCliente : Form
    {
        private Conexao conexao = new Conexao();

        public form_ProcurarCliente()
        {
            InitializeComponent();
        }

        private void CarregarTabelaBuscaCliente()
        {
            SqlConnection connection = conexao.Conectar();

            var sqlQuerry = "SELECT cl_Codigo, cl_Data_Cadastro, cl_Nome, cl_Telefone, cl_Telefone_Residencial, cl_Tipo, cl_Cpf_Cnpj, cl_Rg, cl_Emissor, cl_Data_Emissao, cl_Estado_Civil, cl_Inscricao_Estadual, cl_Cep, cl_Endereco, cl_Complemento, cl_Bairro, cl_Cidade, cl_Uf, cl_Naturalidade,cl_Data_Nascimento, cl_Credito, cl_Debito, cl_Saldo, cl_Bloqueio, cl_Email FROM tb_Cliente";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    grid_PesquisarCliente.DataSource = dt;
                }
            }
        }

        private void CarregarTabelaBuscaCodigoCliente(string _codigoCliente)
        {
            SqlConnection connection = conexao.Conectar();

            string sqlQuerry = $"SELECT cl_Codigo, cl_Data_Cadastro, cl_Nome, cl_Telefone, cl_Telefone_Residencial, cl_Tipo, cl_Cpf_Cnpj, cl_Rg, cl_Emissor, cl_Data_Emissao, cl_Estado_Civil, cl_Inscricao_Estadual, cl_Cep, cl_Endereco, cl_Complemento, cl_Bairro, cl_Cidade, cl_Uf, cl_Naturalidade,cl_Data_Nascimento, cl_Credito, cl_Debito, cl_Saldo, cl_Bloqueio, cl_Email FROM tb_Cliente WHERE cl_Codigo LIKE '%{_codigoCliente}%'";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    grid_PesquisarCliente.DataSource = dt;
                }
            }
        }

        private void CarregarTabelaBuscaNomeCliente(string _nomeCliente)
        {
            SqlConnection connection = conexao.Conectar();

            string sqlQuerry = $"SELECT cl_Codigo, cl_Data_Cadastro, cl_Nome, cl_Telefone, cl_Telefone_Residencial, cl_Tipo, cl_Cpf_Cnpj, cl_Rg, cl_Emissor, cl_Data_Emissao, cl_Estado_Civil, cl_Inscricao_Estadual, cl_Cep, cl_Endereco, cl_Complemento, cl_Bairro, cl_Cidade, cl_Uf, cl_Naturalidade,cl_Data_Nascimento, cl_Credito, cl_Debito, cl_Saldo, cl_Bloqueio, cl_Email FROM tb_Cliente WHERE cl_Nome LIKE '%{_nomeCliente}%'";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    grid_PesquisarCliente.DataSource = dt;
                }
            }
        }

        private void form_ProcurarCliente_Load(object sender, EventArgs e)
        {
            CarregarTabelaBuscaCliente();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            CarregarTabelaBuscaCodigoCliente(txt_BuscaCodigoCliente.Text);
        }

        private void txt_BuscarNomeCliente_KeyUp_1(object sender, KeyEventArgs e)
        {
            CarregarTabelaBuscaNomeCliente(txt_BuscarNomeCliente.Text);
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreencherFormAoClicarDuasVezes()
        {
            form_Cliente formulario = new form_Cliente();
            formulario.lbl_Codigo.Text = grid_PesquisarCliente.SelectedCells[0].Value.ToString();
            formulario.txt_Codigo.Text = grid_PesquisarCliente.SelectedCells[0].Value.ToString();
            formulario.txt_DataCadastro.Text = grid_PesquisarCliente.SelectedCells[1].Value.ToString();
            formulario.txt_Nome.Text = grid_PesquisarCliente.SelectedCells[2].Value.ToString();
            formulario.txt_Celular.Text = grid_PesquisarCliente.SelectedCells[3].Value.ToString();
            formulario.txt_TelefoneResidencial.Text = grid_PesquisarCliente.SelectedCells[4].Value.ToString();
            formulario.cmb_Tipo.Text = grid_PesquisarCliente.SelectedCells[5].Value.ToString();
            formulario.txt_Cpf_Cnpj.Text = grid_PesquisarCliente.SelectedCells[6].Value.ToString();
            formulario.txt_Rg.Text = grid_PesquisarCliente.SelectedCells[7].Value.ToString();
            formulario.txt_Emissor.Text = grid_PesquisarCliente.SelectedCells[8].Value.ToString();
            formulario.txt_DataEmissao.Text = grid_PesquisarCliente.SelectedCells[9].Value.ToString();
            formulario.cmb_EstadoCivil.Text = grid_PesquisarCliente.SelectedCells[10].Value.ToString();
            formulario.txt_InscricaoEstadual.Text = grid_PesquisarCliente.SelectedCells[11].Value.ToString();
            formulario.txt_Cep.Text = grid_PesquisarCliente.SelectedCells[12].Value.ToString();
            formulario.txt_Endereco.Text = grid_PesquisarCliente.SelectedCells[13].Value.ToString();
            formulario.txt_Complemento.Text = grid_PesquisarCliente.SelectedCells[14].Value.ToString();
            formulario.txt_Bairro.Text = grid_PesquisarCliente.SelectedCells[15].Value.ToString();
            formulario.txt_Cidade.Text = grid_PesquisarCliente.SelectedCells[16].Value.ToString();
            formulario.txt_Uf.Text = grid_PesquisarCliente.SelectedCells[17].Value.ToString();
            formulario.txt_Naturalidade.Text = grid_PesquisarCliente.SelectedCells[18].Value.ToString();
            formulario.txt_DataNascimento.Text = grid_PesquisarCliente.SelectedCells[19].Value.ToString();
            formulario.txt_Credito.Text = grid_PesquisarCliente.SelectedCells[20].Value.ToString();
            formulario.txt_Debito.Text = grid_PesquisarCliente.SelectedCells[21].Value.ToString();
            formulario.txt_Saldo.Text = grid_PesquisarCliente.SelectedCells[22].Value.ToString();
            formulario.cmb_Bloqueio.Text = grid_PesquisarCliente.SelectedCells[23].Value.ToString();
            formulario.txt_Email.Text = grid_PesquisarCliente.SelectedCells[24].Value.ToString();
            formulario.btn_GravarCliente.Enabled = false;
            formulario.ShowDialog();

            Application.Exit();
        }

        private void grid_PesquisarCliente_DoubleClick(object sender, EventArgs e)
        {
            PreencherFormAoClicarDuasVezes();
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

        private void txt_BuscaCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumeros(e);
        }

        private void txt_BuscarNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasLestras(e);
        }
    }
}