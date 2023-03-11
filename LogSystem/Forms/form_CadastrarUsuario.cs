using LogSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogSystem
{
    public partial class form_CadastrarUsuario : Form
    {
        public form_CadastrarUsuario()
        {
            InitializeComponent();
        }

        public void Alerta(string msg, form_Alertas.enmType type)
        {
            form_Alertas form = new form_Alertas();
            form.showAlert(msg, type);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string mensagem = controle.cadastrarUsuario(txt_CadastrarUsuario.Text, txt_CadastrarEmail.Text, txt_CadastrarSenha.Text,
                 txt_CadastrarConfSenha.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alerta("Usuário Cadastrado", form_Alertas.enmType.Success);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}