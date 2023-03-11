namespace LogSystem.Forms
{
    partial class form_ProcurarFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ProcurarFornecedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.grid_PesquisarFornecedor = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.txt_BuscarNomeFornecedor = new System.Windows.Forms.TextBox();
            this.txt_BuscaCodigoFornecedor = new System.Windows.Forms.TextBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.CÓDIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InscEstd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InscMun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CnpjCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGEM = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PesquisarFornecedor)).BeginInit();
            this.bunifuGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lbl_Id);
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.grid_PesquisarFornecedor);
            this.panel1.Controls.Add(this.bunifuGroupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bunifuSeparator3);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 401);
            this.panel1.TabIndex = 3;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(472, 9);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(35, 13);
            this.lbl_Id.TabIndex = 78;
            this.lbl_Id.Text = "label1";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.FlatAppearance.BorderSize = 0;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.Image = global::LogSystem.Properties.Resources.delete_25px;
            this.btn_Fechar.Location = new System.Drawing.Point(699, 5);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(25, 25);
            this.btn_Fechar.TabIndex = 77;
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // grid_PesquisarFornecedor
            // 
            this.grid_PesquisarFornecedor.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.grid_PesquisarFornecedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_PesquisarFornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_PesquisarFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_PesquisarFornecedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_PesquisarFornecedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_PesquisarFornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_PesquisarFornecedor.ColumnHeadersHeight = 40;
            this.grid_PesquisarFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CÓDIGO,
            this.NomeFantasia,
            this.RazaoSocial,
            this.Cep,
            this.Endereco,
            this.Cidade,
            this.InscEstd,
            this.InscMun,
            this.CnpjCpf,
            this.Telefone,
            this.Email,
            this.IMAGEM});
            this.grid_PesquisarFornecedor.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grid_PesquisarFornecedor.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid_PesquisarFornecedor.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid_PesquisarFornecedor.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grid_PesquisarFornecedor.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grid_PesquisarFornecedor.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.grid_PesquisarFornecedor.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grid_PesquisarFornecedor.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.grid_PesquisarFornecedor.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.grid_PesquisarFornecedor.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_PesquisarFornecedor.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.grid_PesquisarFornecedor.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grid_PesquisarFornecedor.CurrentTheme.Name = null;
            this.grid_PesquisarFornecedor.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_PesquisarFornecedor.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid_PesquisarFornecedor.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid_PesquisarFornecedor.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grid_PesquisarFornecedor.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_PesquisarFornecedor.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_PesquisarFornecedor.EnableHeadersVisualStyles = false;
            this.grid_PesquisarFornecedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grid_PesquisarFornecedor.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.grid_PesquisarFornecedor.HeaderBgColor = System.Drawing.Color.Empty;
            this.grid_PesquisarFornecedor.HeaderForeColor = System.Drawing.Color.White;
            this.grid_PesquisarFornecedor.Location = new System.Drawing.Point(1, 64);
            this.grid_PesquisarFornecedor.Name = "grid_PesquisarFornecedor";
            this.grid_PesquisarFornecedor.ReadOnly = true;
            this.grid_PesquisarFornecedor.RowHeadersVisible = false;
            this.grid_PesquisarFornecedor.RowTemplate.Height = 40;
            this.grid_PesquisarFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_PesquisarFornecedor.Size = new System.Drawing.Size(726, 335);
            this.grid_PesquisarFornecedor.TabIndex = 76;
            this.grid_PesquisarFornecedor.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
      //      this.grid_PesquisarFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_PesquisarFornecedor_CellClick);
            this.grid_PesquisarFornecedor.DoubleClick += new System.EventHandler(this.grid_PesquisarFornecedor_DoubleClick);
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.txt_BuscarNomeFornecedor);
            this.bunifuGroupBox1.Controls.Add(this.txt_BuscaCodigoFornecedor);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel5);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel4);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(0, 34);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(730, 30);
            this.bunifuGroupBox1.TabIndex = 66;
            this.bunifuGroupBox1.TabStop = false;
            // 
            // txt_BuscarNomeFornecedor
            // 
            this.txt_BuscarNomeFornecedor.Location = new System.Drawing.Point(278, 4);
            this.txt_BuscarNomeFornecedor.Name = "txt_BuscarNomeFornecedor";
            this.txt_BuscarNomeFornecedor.Size = new System.Drawing.Size(449, 23);
            this.txt_BuscarNomeFornecedor.TabIndex = 77;
            this.txt_BuscarNomeFornecedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BuscarNomeFornecedor_KeyUp);
            // 
            // txt_BuscaCodigoFornecedor
            // 
            this.txt_BuscaCodigoFornecedor.Location = new System.Drawing.Point(58, 4);
            this.txt_BuscaCodigoFornecedor.Name = "txt_BuscaCodigoFornecedor";
            this.txt_BuscaCodigoFornecedor.Size = new System.Drawing.Size(125, 23);
            this.txt_BuscaCodigoFornecedor.TabIndex = 77;
            this.txt_BuscaCodigoFornecedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BuscaCodigoFornecedor_KeyUp);
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel5.Location = new System.Drawing.Point(4, 7);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(48, 17);
            this.bunifuLabel5.TabIndex = 74;
            this.bunifuLabel5.Text = "Código:";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel4.Location = new System.Drawing.Point(197, 6);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(75, 17);
            this.bunifuLabel4.TabIndex = 22;
            this.bunifuLabel4.Text = "Fornecedor:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(425, -67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 22);
            this.button1.TabIndex = 75;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator3.BackgroundImage")));
            this.bunifuSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator3.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.Black;
            this.bunifuSeparator3.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(0, 578);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator3.Size = new System.Drawing.Size(1155, 14);
            this.bunifuSeparator3.TabIndex = 3;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Black;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(1, -6);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(1154, 14);
            this.bunifuSeparator2.TabIndex = 2;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bunifuLabel1.Location = new System.Drawing.Point(4, 8);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(131, 17);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Pesquisar Fornecedor";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Black;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 25);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(1155, 14);
            this.bunifuSeparator1.TabIndex = 0;
            // 
            // CÓDIGO
            // 
            this.CÓDIGO.DataPropertyName = "cl_Codigo";
            this.CÓDIGO.HeaderText = "CÓDIGO";
            this.CÓDIGO.Name = "CÓDIGO";
            this.CÓDIGO.ReadOnly = true;
            // 
            // NomeFantasia
            // 
            this.NomeFantasia.DataPropertyName = "cl_NomeFantasia";
            this.NomeFantasia.HeaderText = "NOME";
            this.NomeFantasia.Name = "NomeFantasia";
            this.NomeFantasia.ReadOnly = true;
            // 
            // RazaoSocial
            // 
            this.RazaoSocial.DataPropertyName = "cl_RazaoSocial";
            this.RazaoSocial.HeaderText = "RazaoSocial";
            this.RazaoSocial.Name = "RazaoSocial";
            this.RazaoSocial.ReadOnly = true;
            this.RazaoSocial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RazaoSocial.Visible = false;
            // 
            // Cep
            // 
            this.Cep.DataPropertyName = "cl_Cep";
            this.Cep.HeaderText = "CEP";
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            this.Cep.Visible = false;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "cl_Endereco";
            this.Endereco.HeaderText = "ENDEREÇO";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Visible = false;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "cl_Cidade";
            this.Cidade.HeaderText = "CIDADE";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Visible = false;
            // 
            // InscEstd
            // 
            this.InscEstd.DataPropertyName = "cl_InscricaoEstadual";
            this.InscEstd.HeaderText = "InscEstd";
            this.InscEstd.Name = "InscEstd";
            this.InscEstd.ReadOnly = true;
            this.InscEstd.Visible = false;
            // 
            // InscMun
            // 
            this.InscMun.DataPropertyName = "cl_InscricaoMunicipal";
            this.InscMun.HeaderText = "InscMun";
            this.InscMun.Name = "InscMun";
            this.InscMun.ReadOnly = true;
            this.InscMun.Visible = false;
            // 
            // CnpjCpf
            // 
            this.CnpjCpf.DataPropertyName = "cl_CnpjCpf";
            this.CnpjCpf.HeaderText = "CNPJ/CPF";
            this.CnpjCpf.Name = "CnpjCpf";
            this.CnpjCpf.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "cl_Telefone";
            this.Telefone.HeaderText = "TELEFONE";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Visible = false;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "cl_Email";
            this.Email.HeaderText = "EMAIL";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // IMAGEM
            // 
            this.IMAGEM.DataPropertyName = "cl_Imagem";
            this.IMAGEM.HeaderText = "IMAGEM";
            this.IMAGEM.Name = "IMAGEM";
            this.IMAGEM.ReadOnly = true;
            this.IMAGEM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IMAGEM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IMAGEM.Visible = false;
            // 
            // form_ProcurarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 404);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_ProcurarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_ProcurarFornecedor";
            this.Load += new System.EventHandler(this.form_ProcurarFornecedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PesquisarFornecedor)).EndInit();
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Button btn_Fechar;
        private Bunifu.UI.WinForms.BunifuDataGridView grid_PesquisarFornecedor;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private System.Windows.Forms.TextBox txt_BuscarNomeFornecedor;
        private System.Windows.Forms.TextBox txt_BuscaCodigoFornecedor;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CÓDIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn InscEstd;
        private System.Windows.Forms.DataGridViewTextBoxColumn InscMun;
        private System.Windows.Forms.DataGridViewTextBoxColumn CnpjCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewImageColumn IMAGEM;
    }
}