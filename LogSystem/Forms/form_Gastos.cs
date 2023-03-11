using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LogSystem.DAO;
using LogSystem.Estruturas;
using LogSystem.Forms;

namespace LogSystem
{
    public partial class form_Gastos : Form
    {
        private SqlCommand cmd = new SqlCommand();
        private readonly Conexao conexao = new Conexao();
        public string mensagem = "";
        form_DesignAlertas formdesingAlertas = new form_DesignAlertas();

        public form_Gastos()
        {
            InitializeComponent();
            CarregarComboboxTipo();
        }

        public void Alerta(string msg, form_Alertas.enmType type)
        {
            var form = new form_Alertas();
            form.showAlert(msg, type);
        }

        private void LimparTextCadastroGastos()
        {
            ckb_Despesa.Checked = false;
            ckb_Custo.Checked   = false;
            txt_Codigo.Text     = "";
            txt_Titulo.Text     = "";
            cmb_Tipo.Text       = "";
            btn_Alterar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_Salvar.Enabled  = true;
        }

        private void DeletarGastos()
        {
            if (MessageBox.Show("Tem certeza?", "CERTEZA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int       codigoGastos = Convert.ToInt32(txt_Codigo.Text);
                GastosDAO gastosDao    = new GastosDAO();

                gastosDao.DeletarGastos(codigoGastos);
                Alerta("Exclusão Realizada \nCom Sucesso!!!", form_Alertas.enmType.Success);
            }
        }

        private void CarregarComboboxTipo()
        {
            try
            {
                var cmd = new SqlCommand("SELECT DISTINCT gst_Tipo FROM tb_Gastos ORDER BY gst_Tipo ASC");
                cmd.Connection = conexao.Conectar();
                var table = new DataTable();

                table.Load(cmd.ExecuteReader());
                var row = table.NewRow();
                row["gst_Tipo"] = "";
                table.Rows.InsertAt(row, 0);

                cmb_Tipo.DataSource  = table;
                cmb_Tipo.ValueMember = "gst_Tipo";

                cmd.ExecuteReader().Close();
                cmd.ExecuteReader().Dispose();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Não foi possível preencher o Combobox \n\nErro:" + e, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        private void CadastrarGastos()
        {
            var gastosDAO       = new GastosDAO();
            var gastosEstrutura = new GastosEstrutura();

            gastosEstrutura.gst_Categoria  = ckb_Custo.Text;
            gastosEstrutura.gst_Categoria  = ckb_Despesa.Text;
            gastosEstrutura.gst_Titulo     = txt_Titulo.Text;
            gastosEstrutura.gst_Tipo       = cmb_Tipo.Text;
            gastosEstrutura.gst_Descricao  = txt_Descricao.Text;
            gastosEstrutura.gst_Emissao    = Convert.ToDateTime(dtp_Emissao.Text);
            gastosEstrutura.gst_Vencimento = Convert.ToDateTime(dtp_Vencimento.Text);
            gastosEstrutura.gst_Frequencia = cmb_Frenquencia.Text;
            gastosEstrutura.gst_Valor      = Convert.ToDecimal(txt_Valor.Text);

            mensagem = gastosDAO.CadastrarGastos(gastosEstrutura);
            if (gastosDAO.tem)
            {
                Alerta("Inclusão Realizada \nCom Sucesso!!!", form_Alertas.enmType.Success);

                // MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(gastosDAO.mensagem);
            }

            btn_Nova.Enabled = true;
        }

        private void AlterarGastos()
        {
            var gastosDAO       = new GastosDAO();
            var gastosEstrutura = new GastosEstrutura();

            gastosEstrutura.gst_Categoria  = ckb_Custo.Text;
            gastosEstrutura.gst_Categoria  = ckb_Despesa.Text;
            gastosEstrutura.gst_Titulo     = txt_Titulo.Text;
            gastosEstrutura.gst_Tipo       = cmb_Tipo.Text;
            gastosEstrutura.gst_Descricao  = txt_Descricao.Text;
            gastosEstrutura.gst_Emissao    = Convert.ToDateTime(dtp_Emissao.Text);
            gastosEstrutura.gst_Vencimento = Convert.ToDateTime(dtp_Vencimento.Text);
            gastosEstrutura.gst_Frequencia = cmb_Frenquencia.Text;
            gastosEstrutura.gst_Valor      = Convert.ToDecimal(txt_Valor.Text);
            gastosEstrutura.gst_Codigo     = Convert.ToInt32(txt_Codigo.Text);

            mensagem = gastosDAO.AlterarGastos(gastosEstrutura);
            if (gastosDAO.tem)
            {
                // MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alerta("Inclusão Realizada\nCom Sucesso!!!", form_Alertas.enmType.Success);
            }
            else
            {
                MessageBox.Show(gastosDAO.mensagem);
            }

            btn_Salvar.Enabled = false;
            btn_Nova.Enabled   = true;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            CadastrarGastos();
        }

        private void ckb_Despesa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Despesa.Checked)
            {
                ckb_Custo.Checked = false;
            }
        }

        private void ckb_Custo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Custo.Checked)
            {
                ckb_Despesa.Checked = false;
            }
        }

        private void btn_Nova_Click(object sender, EventArgs e)
        {
            LimparTextCadastroGastos();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            AlterarGastos();
        }

        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            form_ProcurarGastos formProcurarGastos = new form_ProcurarGastos(this);
            formProcurarGastos.ShowDialog();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DeletarGastos();
            LimparTextCadastroGastos();
        }

        private void PegarDatasEmissaoEVencimento()
        {
            try
            {
                SqlConnection connection = conexao.Conectar();

                string sqlQuerry = "SELECT gst_Emissao, gst_Vencimento FROM tb_Gastos";
                using (SqlCommand command = new SqlCommand(sqlQuerry, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        DateTime dataEmissao    = reader.GetDateTime(0);
                        DateTime dataVencimento = reader.GetDateTime(1);
                        TimeSpan diferencaDias  = dataVencimento - dataEmissao;
                        if (diferencaDias.Days > 5)
                        {
                            // MessageBox.Show("Test");

                            Alerta("Faltam 5 dias\npara a data de vencimento", form_Alertas.enmType.Warning);
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro com o Banco de Dados \n\n" + e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PegarDatasEmissaoEVencimento();
        }

        private void form_Gastos_Load(object sender, EventArgs e)
        {
            formdesingAlertas.CentralizarLabels();
        }
    }
}