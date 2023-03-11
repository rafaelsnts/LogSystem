using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogSystem.Forms
{
    public partial class form_DesignAlertas : Form
    {
        public form_DesignAlertas()
        {
            InitializeComponent();

            // CentralizarLabels();
        }

        public void CentralizarLabels()
        {
            lbl_Sucesso.Left = (this.Width / 2) - (lbl_Sucesso.Width / 2);
            lbl_Aviso.Left   = (this.Width / 2) - (lbl_Aviso.Width / 2);
            lbl_Erro.Left    = (this.Width / 2) - (lbl_Erro.Width / 2);
            lbl_Info.Left    = (this.Width / 2) - (lbl_Info.Width / 2);
        }

        public void Alerta(string msg, form_Alertas.enmType type)
        {
            form_Alertas form = new form_Alertas();
            form.showAlert(msg, type);
        }

        private void btn_SucessoAlerta_Click(object sender, EventArgs e)
        {
            CentralizarLabels();
            Alerta("Aviso Alertas", form_Alertas.enmType.Success);
        }

        private void btn_AvisoAlertas_Click(object sender, EventArgs e)
        {
            CentralizarLabels();
            Alerta("Aviso Alerta", form_Alertas.enmType.Warning);
        }

        private void btn_ErroAlertas_Click(object sender, EventArgs e)
        {
            CentralizarLabels();
            Alerta("Erro Alerta", form_Alertas.enmType.Error);
        }

        private void btn_InfoAlertas_Click(object sender, EventArgs e)
        {
            CentralizarLabels();
            Alerta("Info Alerta", form_Alertas.enmType.Info);
        }
    }
}