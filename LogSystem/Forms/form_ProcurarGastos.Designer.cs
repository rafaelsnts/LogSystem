namespace LogSystem.Forms
{
    partial class form_ProcurarGastos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ProcurarGastos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Teste = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.grid_BuscarGastos = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.txt_BuscaPorTipo = new System.Windows.Forms.TextBox();
            this.txt_BuscaPorCategoria = new System.Windows.Forms.TextBox();
            this.txt_BuscaPorCodigo = new System.Windows.Forms.TextBox();
            this.txt_BuscaPorTitulo = new System.Windows.Forms.TextBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_BuscarGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.lbl_Teste);
            this.panel1.Controls.Add(this.grid_BuscarGastos);
            this.panel1.Controls.Add(this.txt_BuscaPorTipo);
            this.panel1.Controls.Add(this.txt_BuscaPorCategoria);
            this.panel1.Controls.Add(this.txt_BuscaPorCodigo);
            this.panel1.Controls.Add(this.txt_BuscaPorTitulo);
            this.panel1.Controls.Add(this.bunifuLabel5);
            this.panel1.Controls.Add(this.bunifuLabel4);
            this.panel1.Controls.Add(this.bunifuLabel3);
            this.panel1.Controls.Add(this.bunifuLabel2);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.bunifuSeparator3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 556);
            this.panel1.TabIndex = 1;
            // 
            // lbl_Teste
            // 
            this.lbl_Teste.AllowParentOverrides = false;
            this.lbl_Teste.AutoEllipsis = false;
            this.lbl_Teste.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Teste.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_Teste.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Teste.Location = new System.Drawing.Point(464, 6);
            this.lbl_Teste.Name = "lbl_Teste";
            this.lbl_Teste.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Teste.Size = new System.Drawing.Size(33, 17);
            this.lbl_Teste.TabIndex = 27;
            this.lbl_Teste.Text = "Teste";
            this.lbl_Teste.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Teste.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Image = global::LogSystem.Properties.Resources.delete_25px;
            this.btn_Exit.Location = new System.Drawing.Point(1002, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(22, 22);
            this.btn_Exit.TabIndex = 26;
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // grid_BuscarGastos
            // 
            this.grid_BuscarGastos.AllowCustomTheming = false;
            this.grid_BuscarGastos.AllowUserToAddRows = false;
            this.grid_BuscarGastos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.grid_BuscarGastos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_BuscarGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_BuscarGastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_BuscarGastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_BuscarGastos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_BuscarGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_BuscarGastos.ColumnHeadersHeight = 40;
            this.grid_BuscarGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Categoria,
            this.Titulo,
            this.Tipo,
            this.Descricao,
            this.Emissao,
            this.Vencimento,
            this.Frequencia,
            this.Valor});
            this.grid_BuscarGastos.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grid_BuscarGastos.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid_BuscarGastos.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid_BuscarGastos.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grid_BuscarGastos.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grid_BuscarGastos.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.grid_BuscarGastos.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grid_BuscarGastos.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.grid_BuscarGastos.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.grid_BuscarGastos.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_BuscarGastos.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.grid_BuscarGastos.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grid_BuscarGastos.CurrentTheme.Name = null;
            this.grid_BuscarGastos.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_BuscarGastos.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid_BuscarGastos.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid_BuscarGastos.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grid_BuscarGastos.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_BuscarGastos.DefaultCellStyle = dataGridViewCellStyle9;
            this.grid_BuscarGastos.EnableHeadersVisualStyles = false;
            this.grid_BuscarGastos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grid_BuscarGastos.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.grid_BuscarGastos.HeaderBgColor = System.Drawing.Color.Empty;
            this.grid_BuscarGastos.HeaderForeColor = System.Drawing.Color.White;
            this.grid_BuscarGastos.Location = new System.Drawing.Point(0, 90);
            this.grid_BuscarGastos.Name = "grid_BuscarGastos";
            this.grid_BuscarGastos.ReadOnly = true;
            this.grid_BuscarGastos.RowHeadersVisible = false;
            this.grid_BuscarGastos.RowTemplate.Height = 40;
            this.grid_BuscarGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_BuscarGastos.Size = new System.Drawing.Size(1027, 466);
            this.grid_BuscarGastos.TabIndex = 25;
            this.grid_BuscarGastos.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.grid_BuscarGastos.DoubleClick += new System.EventHandler(this.grid_BuscarGastos_DoubleClick);
            // 
            // txt_BuscaPorTipo
            // 
            this.txt_BuscaPorTipo.Location = new System.Drawing.Point(627, 64);
            this.txt_BuscaPorTipo.Name = "txt_BuscaPorTipo";
            this.txt_BuscaPorTipo.Size = new System.Drawing.Size(250, 20);
            this.txt_BuscaPorTipo.TabIndex = 24;
            this.txt_BuscaPorTipo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BuscaPorTipo_KeyUp);
            // 
            // txt_BuscaPorCategoria
            // 
            this.txt_BuscaPorCategoria.Location = new System.Drawing.Point(99, 64);
            this.txt_BuscaPorCategoria.Name = "txt_BuscaPorCategoria";
            this.txt_BuscaPorCategoria.Size = new System.Drawing.Size(250, 20);
            this.txt_BuscaPorCategoria.TabIndex = 23;
            this.txt_BuscaPorCategoria.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BuscaPorCategoria_KeyUp);
            // 
            // txt_BuscaPorCodigo
            // 
            this.txt_BuscaPorCodigo.Location = new System.Drawing.Point(6, 64);
            this.txt_BuscaPorCodigo.Name = "txt_BuscaPorCodigo";
            this.txt_BuscaPorCodigo.Size = new System.Drawing.Size(78, 20);
            this.txt_BuscaPorCodigo.TabIndex = 21;
            this.txt_BuscaPorCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BuscaPorCodigo_KeyUp);
            // 
            // txt_BuscaPorTitulo
            // 
            this.txt_BuscaPorTitulo.Location = new System.Drawing.Point(364, 64);
            this.txt_BuscaPorTitulo.Name = "txt_BuscaPorTitulo";
            this.txt_BuscaPorTitulo.Size = new System.Drawing.Size(250, 20);
            this.txt_BuscaPorTitulo.TabIndex = 20;
            this.txt_BuscaPorTitulo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BuscaPorTitulo_KeyUp);
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bunifuLabel5.Location = new System.Drawing.Point(627, 41);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(27, 17);
            this.bunifuLabel5.TabIndex = 19;
            this.bunifuLabel5.Text = "Tipo";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bunifuLabel4.Location = new System.Drawing.Point(364, 41);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(36, 17);
            this.bunifuLabel4.TabIndex = 18;
            this.bunifuLabel4.Text = "Titulo";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bunifuLabel3.Location = new System.Drawing.Point(6, 41);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(42, 17);
            this.bunifuLabel3.TabIndex = 17;
            this.bunifuLabel3.Text = "Código";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bunifuLabel2.Location = new System.Drawing.Point(99, 41);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(60, 17);
            this.bunifuLabel2.TabIndex = 14;
            this.bunifuLabel2.Text = "Categoria";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bunifuLabel1.Location = new System.Drawing.Point(6, 6);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(86, 17);
            this.bunifuLabel1.TabIndex = 7;
            this.bunifuLabel1.Text = "Buscar Gastos";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 19);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(1027, 19);
            this.bunifuSeparator2.TabIndex = 6;
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(1, -7);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(1026, 19);
            this.bunifuSeparator1.TabIndex = 5;
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
            this.bunifuSeparator3.Location = new System.Drawing.Point(3, 545);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator3.Size = new System.Drawing.Size(1024, 19);
            this.bunifuSeparator3.TabIndex = 4;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "gst_Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "gst_Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "gst_Titulo";
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "gst_Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "gst_Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Emissao
            // 
            this.Emissao.DataPropertyName = "gst_Emissao";
            this.Emissao.HeaderText = "Emissão";
            this.Emissao.Name = "Emissao";
            this.Emissao.ReadOnly = true;
            // 
            // Vencimento
            // 
            this.Vencimento.DataPropertyName = "gst_Vencimento";
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            // 
            // Frequencia
            // 
            this.Frequencia.DataPropertyName = "gst_Frequencia";
            this.Frequencia.HeaderText = "Frequência";
            this.Frequencia.Name = "Frequencia";
            this.Frequencia.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "gst_Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form_ProcurarGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 557);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_ProcurarGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_ProcurarGastos";
            this.Load += new System.EventHandler(this.form_ProcurarGastos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_BuscarGastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView grid_BuscarGastos;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Button btn_Exit;
        public Bunifu.UI.WinForms.BunifuLabel lbl_Teste;
        public System.Windows.Forms.TextBox txt_BuscaPorTipo;
        public System.Windows.Forms.TextBox txt_BuscaPorCategoria;
        public System.Windows.Forms.TextBox txt_BuscaPorCodigo;
        public System.Windows.Forms.TextBox txt_BuscaPorTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Timer timer1;
    }
}