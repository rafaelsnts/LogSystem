using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogSystem.Forms;

namespace LogSystem
{
    public partial class form_MenuPrincipal : Form
    {
        public form_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_CadastrarUsuario_Click(object sender, EventArgs e)
        {
            form_CadastrarUsuario cadastrarUsuario = new form_CadastrarUsuario();
            cadastrarUsuario.ShowDialog();
        }

        private void btn_Cliente_Click_1(object sender, EventArgs e)
        {
            form_Cliente cliente = new form_Cliente();
            cliente.ShowDialog();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Fornecedores_Click(object sender, EventArgs e)
        {
            form_Fornecedor fornecedor = new form_Fornecedor();
            fornecedor.CarregandoBotoes();
            fornecedor.ShowDialog();
        }
    }
}