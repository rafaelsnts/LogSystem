using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogSystem.DAO;
using LogSystem.Estruturas;

namespace LogSystem.Forms
{
    public partial class form_Despesa : Form
    {
        public string mensagem = "";
        DespesaDAO despesaDAO = new DespesaDAO();

        public form_Despesa()
        {
            InitializeComponent();
            CarregarTextboxFormatoMoeda();
            CarregarCombobox();
        }

        private void CarregarCombobox()
        {
            // CarregarComboboxTipoDespesa();
            CarregarComboboxTipo();
            CarregarComboboxTituloDespesa();
        }

        public void Alerta(string msg, form_Alertas.enmType type)
        {
            form_Alertas form = new form_Alertas();
            form.showAlert(msg, type);
        }

        private void CarregarTextboxFormatoMoeda()
        {
            txt_Valor.Text = string.Format("{0:c}", 0d);
        }

        private void CarregarComboboxTipoDespesa()
        {
            Dictionary<int, string> TipoDespesa = despesaDAO.BuscarTipoDespesa();

            DataTable dt = new DataTable("Table");
            dt.Columns.Add("ID");
            dt.Columns.Add("Nome");

            foreach (KeyValuePair<int, string> tipoDespesa in TipoDespesa)
            {
                dt.Rows.Add(new string[]
                {
                    $"{tipoDespesa.Key}",
                    $"{tipoDespesa.Value}"
                });
            }

            cmb_TipoDespesa.DataSource    = dt;
            cmb_TipoDespesa.DisplayMember = "Nome";
            cmb_TipoDespesa.ValueMember   = "ID";
            cmb_TipoDespesa.SelectedItem  = -1;
        }

        private void CarregarComboboxTipo()
        {
            List<string> TipoDespesa = despesaDAO.BuscarTipos();
            foreach (string tipoDespesa in TipoDespesa)
            {
                cmb_TipoDespesa.Items.Add(tipoDespesa);
            }
        }

        private void CarregarComboboxTituloDespesa()
        {
            List<string> TituloDespesa = despesaDAO.BuscarIdTituloDespesa();
            foreach (string tituloDespesa in TituloDespesa)
            {
                cmb_Titulo.Items.Add(tituloDespesa);
            }
        }

        private void InformarDataVencimentoDespesa()
        {
            DateTime     dtVencimento    = DateTime.Now;
            List<string> DataVencimeento = despesaDAO.BuscarDataVencimento();

            foreach (string dataVencimento in DataVencimeento)
            {
                dtVencimento = Convert.ToDateTime(dataVencimento);
            }


            //TimeSpan diferencaDias = dtp_Emissao.d - dtp_Vencimento

            //if (diferencaDias.Days > 5)
            //{
            //    faz alguma desgraca
            //}


            DateTime dataVencimentoo = dtVencimento; // data de vencimento, neste exemplo é 28 de fevereiro de 2023
            DateTime dataAtual       = DateTime.Now; // data atual

            TimeSpan diferencaDias = dataVencimentoo - dataAtual; // calcula a diferença de dias

            if (diferencaDias.Days <= 5 && diferencaDias.Days >= 0) // verifica se a diferença de dias é menor ou igual a 5
            {
                Alerta("Atenção:\n A data de vencimento\n está chegando", form_Alertas.enmType.Info);
            }
        }

        private void LimparTextBox()
        {
            txt_Codigo.Text      = "";
            cmb_TipoDespesa.Text = "";
            cmb_Titulo.Text      = "";
            txt_Descricao.Text   = "";
            dtp_Emissao.Value    = Convert.ToDateTime(null);
            dtp_Vencimento.Value = Convert.ToDateTime(null);
            cmb_Frenquencia.Text = "";
            txt_Valor.Text       = "";
        }

        private void CadastrarDespesa()
        {
            DespesaEstrutura despesaEstrutura = new DespesaEstrutura();


            //int idTipoDespesa = Convert.ToInt32(cmb_TipoDespesa.SelectedValue);

            //int idCategoria = despesaDao.BuscarIdCategoriaDespesa(cmb_TipoDespesa.SelectedItem.ToString());


            despesaEstrutura.fk_Cl_Id_Gastos = despesaDAO.BuscarIdTipo(cmb_TipoDespesa.SelectedItem.ToString());
            despesaEstrutura.des_Titulo      = cmb_Titulo.SelectedItem.ToString();
            despesaEstrutura.des_Descricao   = txt_Descricao.Text;
            despesaEstrutura.des_Emissao     = Convert.ToDateTime(dtp_Emissao.Text);
            despesaEstrutura.des_Vencimento  = Convert.ToDateTime(dtp_Vencimento.Text);
            despesaEstrutura.des_Frequencia  = cmb_Frenquencia.Text;
            despesaEstrutura.des_Valor       = Convert.ToDecimal(txt_Valor.Text);
            this.mensagem                    = despesaDAO.CadastrarDespesa(despesaEstrutura);
            if (despesaDAO.tem)
            {
                Alerta("Inclusão Realizada\n com Sucesso", form_Alertas.enmType.Success);
            }
            else
            {
                MessageBox.Show(despesaDAO.mensagem);
            }
        }

        private void btn_SalvarDespesa_Click(object sender, EventArgs e)
        {
            CadastrarDespesa();
        }

        private void txt_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            form_Vendas formVendas = new form_Vendas();
            formVendas.TextBoxFormatacaoMoeda(sender, e);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AlterarDespesa_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InformarDataVencimentoDespesa();
        }
    }
}