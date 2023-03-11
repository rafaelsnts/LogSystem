namespace LogSystem
{
    partial class form_MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbc_Cadastro = new System.Windows.Forms.TabPage();
            this.btn_Produto = new System.Windows.Forms.Button();
            this.btn_CadastrarUsuario = new System.Windows.Forms.Button();
            this.btn_Fornecedores = new System.Windows.Forms.Button();
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbc_Cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_Sair);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 655);
            this.panel1.TabIndex = 0;
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Sair.FlatAppearance.BorderSize = 0;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Sair.Image = global::LogSystem.Properties.Resources.shutdown_50px;
            this.btn_Sair.Location = new System.Drawing.Point(935, 552);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(120, 100);
            this.btn_Sair.TabIndex = 72;
            this.btn_Sair.Text = "Sair do Sistema";
            this.btn_Sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbc_Cadastro);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1056, 167);
            this.tabControl1.TabIndex = 0;
            // 
            // tbc_Cadastro
            // 
            this.tbc_Cadastro.BackColor = System.Drawing.Color.Gainsboro;
            this.tbc_Cadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbc_Cadastro.Controls.Add(this.btn_Produto);
            this.tbc_Cadastro.Controls.Add(this.btn_CadastrarUsuario);
            this.tbc_Cadastro.Controls.Add(this.btn_Fornecedores);
            this.tbc_Cadastro.Controls.Add(this.btn_Cliente);
            this.tbc_Cadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_Cadastro.Location = new System.Drawing.Point(4, 22);
            this.tbc_Cadastro.Name = "tbc_Cadastro";
            this.tbc_Cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbc_Cadastro.Size = new System.Drawing.Size(1048, 141);
            this.tbc_Cadastro.TabIndex = 0;
            this.tbc_Cadastro.Text = "Cadastro";
            // 
            // btn_Produto
            // 
            this.btn_Produto.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Produto.FlatAppearance.BorderSize = 0;
            this.btn_Produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Produto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Produto.Image = global::LogSystem.Properties.Resources.add_user_male_30px;
            this.btn_Produto.Location = new System.Drawing.Point(394, 13);
            this.btn_Produto.Name = "btn_Produto";
            this.btn_Produto.Size = new System.Drawing.Size(122, 115);
            this.btn_Produto.TabIndex = 71;
            this.btn_Produto.Text = "Produto";
            this.btn_Produto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Produto.UseVisualStyleBackColor = false;
            // 
            // btn_CadastrarUsuario
            // 
            this.btn_CadastrarUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_CadastrarUsuario.FlatAppearance.BorderSize = 0;
            this.btn_CadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastrarUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_CadastrarUsuario.Image = global::LogSystem.Properties.Resources.add_user_male_30px;
            this.btn_CadastrarUsuario.Location = new System.Drawing.Point(10, 13);
            this.btn_CadastrarUsuario.Name = "btn_CadastrarUsuario";
            this.btn_CadastrarUsuario.Size = new System.Drawing.Size(122, 115);
            this.btn_CadastrarUsuario.TabIndex = 68;
            this.btn_CadastrarUsuario.Text = "Cadastrar Usuario";
            this.btn_CadastrarUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CadastrarUsuario.UseVisualStyleBackColor = false;
            this.btn_CadastrarUsuario.Click += new System.EventHandler(this.btn_CadastrarUsuario_Click);
            // 
            // btn_Fornecedores
            // 
            this.btn_Fornecedores.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Fornecedores.FlatAppearance.BorderSize = 0;
            this.btn_Fornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fornecedores.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Fornecedores.Image = global::LogSystem.Properties.Resources.add_user_male_30px;
            this.btn_Fornecedores.Location = new System.Drawing.Point(266, 13);
            this.btn_Fornecedores.Name = "btn_Fornecedores";
            this.btn_Fornecedores.Size = new System.Drawing.Size(122, 115);
            this.btn_Fornecedores.TabIndex = 70;
            this.btn_Fornecedores.Text = "Fornecedores";
            this.btn_Fornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Fornecedores.UseVisualStyleBackColor = false;
            this.btn_Fornecedores.Click += new System.EventHandler(this.btn_Fornecedores_Click);
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Cliente.FlatAppearance.BorderSize = 0;
            this.btn_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Cliente.Image = global::LogSystem.Properties.Resources.add_user_male_30px;
            this.btn_Cliente.Location = new System.Drawing.Point(138, 13);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(122, 115);
            this.btn_Cliente.TabIndex = 69;
            this.btn_Cliente.Text = "Cliente";
            this.btn_Cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cliente.UseVisualStyleBackColor = false;
            this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 141);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1048, 141);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // form_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 658);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbc_Cadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbc_Cadastro;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_Produto;
        private System.Windows.Forms.Button btn_CadastrarUsuario;
        private System.Windows.Forms.Button btn_Fornecedores;
        private System.Windows.Forms.Button btn_Cliente;
        private System.Windows.Forms.Button btn_Sair;
    }
}

