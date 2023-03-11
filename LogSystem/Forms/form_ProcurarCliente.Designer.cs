namespace LogSystem.Forms
{
    partial class form_ProcurarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ProcurarCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.grid_PesquisarCliente = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.CÓDIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATACADASTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONERESIDENCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMISSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATAEMISSAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADOCIVIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSCESTADUAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPLEMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NATURALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATANASCIMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDITO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEBITO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BLOQUEIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.txt_BuscarNomeCliente = new System.Windows.Forms.TextBox();
            this.txt_BuscaCodigoCliente = new System.Windows.Forms.TextBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PesquisarCliente)).BeginInit();
            this.bunifuGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lbl_Id);
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.grid_PesquisarCliente);
            this.panel1.Controls.Add(this.bunifuGroupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bunifuSeparator3);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 401);
            this.panel1.TabIndex = 2;
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
            // grid_PesquisarCliente
            // 
            this.grid_PesquisarCliente.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.grid_PesquisarCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_PesquisarCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_PesquisarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_PesquisarCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_PesquisarCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_PesquisarCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_PesquisarCliente.ColumnHeadersHeight = 40;
            this.grid_PesquisarCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CÓDIGO,
            this.DATACADASTRO,
            this.NOME,
            this.TELEFONE,
            this.TELEFONERESIDENCIAL,
            this.TIPO,
            this.CPFCNPJ,
            this.RG,
            this.EMISSOR,
            this.DATAEMISSAO,
            this.ESTADOCIVIL,
            this.INSCESTADUAL,
            this.CEP,
            this.ENDERECO,
            this.COMPLEMENTO,
            this.BAIRRO,
            this.CIDADE,
            this.UF,
            this.NATURALIDADE,
            this.DATANASCIMENTO,
            this.CREDITO,
            this.DEBITO,
            this.SALDO,
            this.BLOQUEIO,
            this.EMAIL});
            this.grid_PesquisarCliente.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grid_PesquisarCliente.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid_PesquisarCliente.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid_PesquisarCliente.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grid_PesquisarCliente.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grid_PesquisarCliente.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.grid_PesquisarCliente.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grid_PesquisarCliente.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.grid_PesquisarCliente.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.grid_PesquisarCliente.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_PesquisarCliente.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.grid_PesquisarCliente.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grid_PesquisarCliente.CurrentTheme.Name = null;
            this.grid_PesquisarCliente.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_PesquisarCliente.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid_PesquisarCliente.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid_PesquisarCliente.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grid_PesquisarCliente.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_PesquisarCliente.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_PesquisarCliente.EnableHeadersVisualStyles = false;
            this.grid_PesquisarCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grid_PesquisarCliente.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.grid_PesquisarCliente.HeaderBgColor = System.Drawing.Color.Empty;
            this.grid_PesquisarCliente.HeaderForeColor = System.Drawing.Color.White;
            this.grid_PesquisarCliente.Location = new System.Drawing.Point(1, 64);
            this.grid_PesquisarCliente.Name = "grid_PesquisarCliente";
            this.grid_PesquisarCliente.ReadOnly = true;
            this.grid_PesquisarCliente.RowHeadersVisible = false;
            this.grid_PesquisarCliente.RowTemplate.Height = 40;
            this.grid_PesquisarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_PesquisarCliente.Size = new System.Drawing.Size(726, 335);
            this.grid_PesquisarCliente.TabIndex = 76;
            this.grid_PesquisarCliente.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.grid_PesquisarCliente.DoubleClick += new System.EventHandler(this.grid_PesquisarCliente_DoubleClick);
            // 
            // CÓDIGO
            // 
            this.CÓDIGO.DataPropertyName = "cl_Codigo";
            this.CÓDIGO.HeaderText = "CÓDIGO";
            this.CÓDIGO.Name = "CÓDIGO";
            this.CÓDIGO.ReadOnly = true;
            // 
            // DATACADASTRO
            // 
            this.DATACADASTRO.DataPropertyName = "cl_Data_Cadastro";
            this.DATACADASTRO.HeaderText = "DATA DE CADASTRO";
            this.DATACADASTRO.Name = "DATACADASTRO";
            this.DATACADASTRO.ReadOnly = true;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "cl_Nome";
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // TELEFONE
            // 
            this.TELEFONE.DataPropertyName = "cl_Telefone";
            this.TELEFONE.HeaderText = "TELEFONE";
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.ReadOnly = true;
            this.TELEFONE.Visible = false;
            // 
            // TELEFONERESIDENCIAL
            // 
            this.TELEFONERESIDENCIAL.DataPropertyName = "cl_Telefone_Residencial";
            this.TELEFONERESIDENCIAL.HeaderText = "TEL RESIDENCIAL";
            this.TELEFONERESIDENCIAL.Name = "TELEFONERESIDENCIAL";
            this.TELEFONERESIDENCIAL.ReadOnly = true;
            this.TELEFONERESIDENCIAL.Visible = false;
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "cl_Tipo";
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Visible = false;
            // 
            // CPFCNPJ
            // 
            this.CPFCNPJ.DataPropertyName = "cl_Cpf_Cnpj";
            this.CPFCNPJ.HeaderText = "CPF / CNPJ";
            this.CPFCNPJ.Name = "CPFCNPJ";
            this.CPFCNPJ.ReadOnly = true;
            this.CPFCNPJ.Visible = false;
            // 
            // RG
            // 
            this.RG.DataPropertyName = "cl_Rg";
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            this.RG.Visible = false;
            // 
            // EMISSOR
            // 
            this.EMISSOR.DataPropertyName = "cl_Emissor";
            this.EMISSOR.HeaderText = "EMISSOR";
            this.EMISSOR.Name = "EMISSOR";
            this.EMISSOR.ReadOnly = true;
            this.EMISSOR.Visible = false;
            // 
            // DATAEMISSAO
            // 
            this.DATAEMISSAO.DataPropertyName = "cl_Data_Emissao";
            this.DATAEMISSAO.HeaderText = "DATA DE EMISSÃO";
            this.DATAEMISSAO.Name = "DATAEMISSAO";
            this.DATAEMISSAO.ReadOnly = true;
            this.DATAEMISSAO.Visible = false;
            // 
            // ESTADOCIVIL
            // 
            this.ESTADOCIVIL.DataPropertyName = "cl_Estado_Civil";
            this.ESTADOCIVIL.HeaderText = "ESTADO CIVIL";
            this.ESTADOCIVIL.Name = "ESTADOCIVIL";
            this.ESTADOCIVIL.ReadOnly = true;
            this.ESTADOCIVIL.Visible = false;
            // 
            // INSCESTADUAL
            // 
            this.INSCESTADUAL.DataPropertyName = "cl_Inscricao_Estadual";
            this.INSCESTADUAL.HeaderText = "INSC. ESTADUAL";
            this.INSCESTADUAL.Name = "INSCESTADUAL";
            this.INSCESTADUAL.ReadOnly = true;
            this.INSCESTADUAL.Visible = false;
            // 
            // CEP
            // 
            this.CEP.DataPropertyName = "cl_Cep";
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            this.CEP.Visible = false;
            // 
            // ENDERECO
            // 
            this.ENDERECO.DataPropertyName = "cl_Endereco";
            this.ENDERECO.HeaderText = "ENDEREÇO";
            this.ENDERECO.Name = "ENDERECO";
            this.ENDERECO.ReadOnly = true;
            this.ENDERECO.Visible = false;
            // 
            // COMPLEMENTO
            // 
            this.COMPLEMENTO.DataPropertyName = "cl_Complemento";
            this.COMPLEMENTO.HeaderText = "COMPLEMENTO";
            this.COMPLEMENTO.Name = "COMPLEMENTO";
            this.COMPLEMENTO.ReadOnly = true;
            this.COMPLEMENTO.Visible = false;
            // 
            // BAIRRO
            // 
            this.BAIRRO.DataPropertyName = "cl_Bairro";
            this.BAIRRO.HeaderText = "BAIRRO";
            this.BAIRRO.Name = "BAIRRO";
            this.BAIRRO.ReadOnly = true;
            this.BAIRRO.Visible = false;
            // 
            // CIDADE
            // 
            this.CIDADE.DataPropertyName = "cl_Cidade";
            this.CIDADE.HeaderText = "CIDADE";
            this.CIDADE.Name = "CIDADE";
            this.CIDADE.ReadOnly = true;
            this.CIDADE.Visible = false;
            // 
            // UF
            // 
            this.UF.DataPropertyName = "cl_Uf";
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            this.UF.Visible = false;
            // 
            // NATURALIDADE
            // 
            this.NATURALIDADE.DataPropertyName = "cl_Naturalidade";
            this.NATURALIDADE.HeaderText = "NATURALIDADE";
            this.NATURALIDADE.Name = "NATURALIDADE";
            this.NATURALIDADE.ReadOnly = true;
            this.NATURALIDADE.Visible = false;
            // 
            // DATANASCIMENTO
            // 
            this.DATANASCIMENTO.DataPropertyName = "cl_Data_Nascimento";
            this.DATANASCIMENTO.HeaderText = "DATA NASCIMENTO";
            this.DATANASCIMENTO.Name = "DATANASCIMENTO";
            this.DATANASCIMENTO.ReadOnly = true;
            this.DATANASCIMENTO.Visible = false;
            // 
            // CREDITO
            // 
            this.CREDITO.DataPropertyName = "cl_Credito";
            this.CREDITO.HeaderText = "CREDITO";
            this.CREDITO.Name = "CREDITO";
            this.CREDITO.ReadOnly = true;
            this.CREDITO.Visible = false;
            // 
            // DEBITO
            // 
            this.DEBITO.DataPropertyName = "cl_Debito";
            this.DEBITO.HeaderText = "DEBITO";
            this.DEBITO.Name = "DEBITO";
            this.DEBITO.ReadOnly = true;
            this.DEBITO.Visible = false;
            // 
            // SALDO
            // 
            this.SALDO.DataPropertyName = "cl_Saldo";
            this.SALDO.HeaderText = "SALDO";
            this.SALDO.Name = "SALDO";
            this.SALDO.ReadOnly = true;
            this.SALDO.Visible = false;
            // 
            // BLOQUEIO
            // 
            this.BLOQUEIO.DataPropertyName = "cl_Bloqueio";
            this.BLOQUEIO.HeaderText = "BLOQUEIO";
            this.BLOQUEIO.Name = "BLOQUEIO";
            this.BLOQUEIO.ReadOnly = true;
            this.BLOQUEIO.Visible = false;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "cl_Email";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Visible = false;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.txt_BuscarNomeCliente);
            this.bunifuGroupBox1.Controls.Add(this.txt_BuscaCodigoCliente);
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
            // txt_BuscarNomeCliente
            // 
            this.txt_BuscarNomeCliente.Location = new System.Drawing.Point(256, 4);
            this.txt_BuscarNomeCliente.Name = "txt_BuscarNomeCliente";
            this.txt_BuscarNomeCliente.Size = new System.Drawing.Size(471, 23);
            this.txt_BuscarNomeCliente.TabIndex = 77;
            this.txt_BuscarNomeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BuscarNomeCliente_KeyPress);
            this.txt_BuscarNomeCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BuscarNomeCliente_KeyUp_1);
            // 
            // txt_BuscaCodigoCliente
            // 
            this.txt_BuscaCodigoCliente.Location = new System.Drawing.Point(75, 4);
            this.txt_BuscaCodigoCliente.Name = "txt_BuscaCodigoCliente";
            this.txt_BuscaCodigoCliente.Size = new System.Drawing.Size(108, 23);
            this.txt_BuscaCodigoCliente.TabIndex = 77;
            this.txt_BuscaCodigoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BuscaCodigoCliente_KeyPress);
            this.txt_BuscaCodigoCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
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
            this.bunifuLabel4.Location = new System.Drawing.Point(206, 7);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(47, 17);
            this.bunifuLabel4.TabIndex = 22;
            this.bunifuLabel4.Text = "Cliente:";
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
            this.bunifuLabel1.Size = new System.Drawing.Size(107, 17);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Pesquisar Cliente";
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
            // form_ProcurarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 400);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "form_ProcurarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_ProcurarCliente";
            this.Load += new System.EventHandler(this.form_ProcurarCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PesquisarCliente)).EndInit();
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView grid_PesquisarCliente;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox txt_BuscaCodigoCliente;
        private System.Windows.Forms.TextBox txt_BuscarNomeCliente;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CÓDIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATACADASTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONERESIDENCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMISSOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATAEMISSAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADOCIVIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSCESTADUAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPLEMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NATURALIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATANASCIMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDITO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEBITO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BLOQUEIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
    }
}