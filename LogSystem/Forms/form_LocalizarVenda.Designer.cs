namespace LogSystem.Forms
{
    partial class form_LocalizarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_LocalizarVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.grid_LocalizarVenda = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.txt_BuscarVendaPorVendedor = new System.Windows.Forms.TextBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_BuscarVendaPorProduto = new System.Windows.Forms.TextBox();
            this.txt_BuscarVendaPorCliente = new System.Windows.Forms.TextBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODBARRAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENDEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDITENS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALBRUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALLIQUIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALPAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TROCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_LocalizarVenda)).BeginInit();
            this.bunifuGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lbl_Id);
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.grid_LocalizarVenda);
            this.panel1.Controls.Add(this.bunifuGroupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bunifuSeparator3);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 513);
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
            this.btn_Fechar.Location = new System.Drawing.Point(963, 3);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(25, 25);
            this.btn_Fechar.TabIndex = 77;
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // grid_LocalizarVenda
            // 
            this.grid_LocalizarVenda.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.grid_LocalizarVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_LocalizarVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_LocalizarVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_LocalizarVenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_LocalizarVenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_LocalizarVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_LocalizarVenda.ColumnHeadersHeight = 40;
            this.grid_LocalizarVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.DATA,
            this.CODBARRAS,
            this.PRODUTO,
            this.CLIENTE,
            this.VENDEDOR,
            this.QTDITENS,
            this.TOTALBRUTO,
            this.DESCONTO,
            this.TOTALLIQUIDO,
            this.TOTALPAGO,
            this.TROCO});
            this.grid_LocalizarVenda.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grid_LocalizarVenda.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid_LocalizarVenda.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid_LocalizarVenda.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grid_LocalizarVenda.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grid_LocalizarVenda.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.grid_LocalizarVenda.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grid_LocalizarVenda.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.grid_LocalizarVenda.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.grid_LocalizarVenda.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_LocalizarVenda.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.grid_LocalizarVenda.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grid_LocalizarVenda.CurrentTheme.Name = null;
            this.grid_LocalizarVenda.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_LocalizarVenda.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid_LocalizarVenda.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid_LocalizarVenda.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grid_LocalizarVenda.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_LocalizarVenda.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_LocalizarVenda.EnableHeadersVisualStyles = false;
            this.grid_LocalizarVenda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grid_LocalizarVenda.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.grid_LocalizarVenda.HeaderBgColor = System.Drawing.Color.Empty;
            this.grid_LocalizarVenda.HeaderForeColor = System.Drawing.Color.White;
            this.grid_LocalizarVenda.Location = new System.Drawing.Point(0, 65);
            this.grid_LocalizarVenda.Name = "grid_LocalizarVenda";
            this.grid_LocalizarVenda.ReadOnly = true;
            this.grid_LocalizarVenda.RowHeadersVisible = false;
            this.grid_LocalizarVenda.RowTemplate.Height = 40;
            this.grid_LocalizarVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_LocalizarVenda.Size = new System.Drawing.Size(1086, 449);
            this.grid_LocalizarVenda.TabIndex = 76;
            this.grid_LocalizarVenda.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.txt_BuscarVendaPorVendedor);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel2);
            this.bunifuGroupBox1.Controls.Add(this.txt_BuscarVendaPorProduto);
            this.bunifuGroupBox1.Controls.Add(this.txt_BuscarVendaPorCliente);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel5);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel4);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(0, 34);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(1086, 30);
            this.bunifuGroupBox1.TabIndex = 66;
            this.bunifuGroupBox1.TabStop = false;
            // 
            // txt_BuscarVendaPorVendedor
            // 
            this.txt_BuscarVendaPorVendedor.Location = new System.Drawing.Point(789, 4);
            this.txt_BuscarVendaPorVendedor.Name = "txt_BuscarVendaPorVendedor";
            this.txt_BuscarVendaPorVendedor.Size = new System.Drawing.Size(294, 23);
            this.txt_BuscarVendaPorVendedor.TabIndex = 79;
            this.txt_BuscarVendaPorVendedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BuscarVendaPorVendedor_KeyUp);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.Location = new System.Drawing.Point(718, 7);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(65, 17);
            this.bunifuLabel2.TabIndex = 78;
            this.bunifuLabel2.Text = "Vendedor:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_BuscarVendaPorProduto
            // 
            this.txt_BuscarVendaPorProduto.Location = new System.Drawing.Point(412, 4);
            this.txt_BuscarVendaPorProduto.Name = "txt_BuscarVendaPorProduto";
            this.txt_BuscarVendaPorProduto.Size = new System.Drawing.Size(300, 23);
            this.txt_BuscarVendaPorProduto.TabIndex = 77;
            this.txt_BuscarVendaPorProduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BuscarVendaPorProduto_KeyUp);
            // 
            // txt_BuscarVendaPorCliente
            // 
            this.txt_BuscarVendaPorCliente.Location = new System.Drawing.Point(55, 4);
            this.txt_BuscarVendaPorCliente.Name = "txt_BuscarVendaPorCliente";
            this.txt_BuscarVendaPorCliente.Size = new System.Drawing.Size(289, 23);
            this.txt_BuscarVendaPorCliente.TabIndex = 77;
            this.txt_BuscarVendaPorCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BuscarVendaPorCliente_KeyUp);
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
            this.bunifuLabel5.Size = new System.Drawing.Size(47, 17);
            this.bunifuLabel5.TabIndex = 74;
            this.bunifuLabel5.Text = "Cliente:";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel4.Location = new System.Drawing.Point(350, 8);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(56, 17);
            this.bunifuLabel4.TabIndex = 22;
            this.bunifuLabel4.Text = "Produto:";
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
            this.bunifuLabel1.Size = new System.Drawing.Size(99, 17);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Localizar Venda";
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
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "vd_Id";
            this.CODIGO.HeaderText = "CÓDIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "vd_Data";
            this.DATA.HeaderText = "DATA";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            // 
            // CODBARRAS
            // 
            this.CODBARRAS.DataPropertyName = "vd_CodigoBarrasProduto";
            this.CODBARRAS.HeaderText = "COD. BARRAS";
            this.CODBARRAS.Name = "CODBARRAS";
            this.CODBARRAS.ReadOnly = true;
            // 
            // PRODUTO
            // 
            this.PRODUTO.DataPropertyName = "cl_Descricao";
            this.PRODUTO.HeaderText = "PRODUTO";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            // 
            // CLIENTE
            // 
            this.CLIENTE.DataPropertyName = "cl_Nome";
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            // 
            // VENDEDOR
            // 
            this.VENDEDOR.DataPropertyName = "cl_Usuario";
            this.VENDEDOR.HeaderText = "VENDEDOR";
            this.VENDEDOR.Name = "VENDEDOR";
            this.VENDEDOR.ReadOnly = true;
            // 
            // QTDITENS
            // 
            this.QTDITENS.DataPropertyName = "vd_Item";
            this.QTDITENS.HeaderText = "QTD ITENS";
            this.QTDITENS.Name = "QTDITENS";
            this.QTDITENS.ReadOnly = true;
            // 
            // TOTALBRUTO
            // 
            this.TOTALBRUTO.DataPropertyName = "vd_TotalBruto";
            this.TOTALBRUTO.HeaderText = "TOTAL BRUTO";
            this.TOTALBRUTO.Name = "TOTALBRUTO";
            this.TOTALBRUTO.ReadOnly = true;
            // 
            // DESCONTO
            // 
            this.DESCONTO.DataPropertyName = "vd_Desconto";
            this.DESCONTO.HeaderText = "% DESCONTO";
            this.DESCONTO.Name = "DESCONTO";
            this.DESCONTO.ReadOnly = true;
            // 
            // TOTALLIQUIDO
            // 
            this.TOTALLIQUIDO.DataPropertyName = "vd_TotalLiquido";
            this.TOTALLIQUIDO.HeaderText = "TOTAL LÍQUIDO";
            this.TOTALLIQUIDO.Name = "TOTALLIQUIDO";
            this.TOTALLIQUIDO.ReadOnly = true;
            // 
            // TOTALPAGO
            // 
            this.TOTALPAGO.DataPropertyName = "vd_TotalPago";
            this.TOTALPAGO.HeaderText = "TOTAL PAGO";
            this.TOTALPAGO.Name = "TOTALPAGO";
            this.TOTALPAGO.ReadOnly = true;
            // 
            // TROCO
            // 
            this.TROCO.DataPropertyName = "vd_Troco";
            this.TROCO.HeaderText = "TROCO";
            this.TROCO.Name = "TROCO";
            this.TROCO.ReadOnly = true;
            // 
            // form_LocalizarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 518);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_LocalizarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_LocalizarVenda";
            this.Load += new System.EventHandler(this.form_LocalizarVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_LocalizarVenda)).EndInit();
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Button btn_Fechar;
        private Bunifu.UI.WinForms.BunifuDataGridView grid_LocalizarVenda;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private System.Windows.Forms.TextBox txt_BuscarVendaPorProduto;
        private System.Windows.Forms.TextBox txt_BuscarVendaPorCliente;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox txt_BuscarVendaPorVendedor;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODBARRAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENDEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDITENS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALBRUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALLIQUIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALPAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TROCO;
    }
}