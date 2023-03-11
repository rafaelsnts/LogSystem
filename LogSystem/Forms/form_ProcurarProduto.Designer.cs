namespace LogSystem.Forms
{
    partial class form_ProcurarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ProcurarProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.grid_PesquisarProduto = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.txt_BuscarMarca = new System.Windows.Forms.TextBox();
            this.txt_BuscarDescricao = new System.Windows.Forms.TextBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_BuscarReferencia = new System.Windows.Forms.TextBox();
            this.txt_BuscaCodigoProduto = new System.Windows.Forms.TextBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btn_AbrirCadastroProdutos = new System.Windows.Forms.Button();
            this.btn_ImprimirRelacaoProdutos = new System.Windows.Forms.Button();
            this.btn_ExportarExcel = new System.Windows.Forms.Button();
            this.btn_FecharPesquisaProduto = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODBARRAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECOCOMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARGEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUCRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECOVENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECOPRAZO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBGRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORNECEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUEMINIMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GARANTIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATAVALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMISSAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACOES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUEATUAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PesquisarProduto)).BeginInit();
            this.bunifuGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lbl_Id);
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.grid_PesquisarProduto);
            this.panel1.Controls.Add(this.bunifuGroupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bunifuSeparator3);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 458);
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
            this.btn_Fechar.Location = new System.Drawing.Point(1029, 5);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(25, 25);
            this.btn_Fechar.TabIndex = 77;
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // grid_PesquisarProduto
            // 
            this.grid_PesquisarProduto.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.grid_PesquisarProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_PesquisarProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_PesquisarProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_PesquisarProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_PesquisarProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_PesquisarProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_PesquisarProduto.ColumnHeadersHeight = 40;
            this.grid_PesquisarProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.CODBARRAS,
            this.DESCRICAO,
            this.UNIDADE,
            this.PRECOCOMPRA,
            this.MARGEM,
            this.LUCRO,
            this.PRECOVENDA,
            this.PRECOPRAZO,
            this.GRUPO,
            this.SUBGRUPO,
            this.FORNECEDOR,
            this.ESTOQUEMINIMO,
            this.GARANTIA,
            this.MARCA,
            this.REFERENCIA,
            this.DATAVALIDADE,
            this.COMISSAO,
            this.OBSERVACOES,
            this.ESTOQUEATUAL,
            this.Imagem});
            this.grid_PesquisarProduto.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grid_PesquisarProduto.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid_PesquisarProduto.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid_PesquisarProduto.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grid_PesquisarProduto.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grid_PesquisarProduto.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.grid_PesquisarProduto.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grid_PesquisarProduto.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.grid_PesquisarProduto.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.grid_PesquisarProduto.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_PesquisarProduto.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.grid_PesquisarProduto.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grid_PesquisarProduto.CurrentTheme.Name = null;
            this.grid_PesquisarProduto.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_PesquisarProduto.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid_PesquisarProduto.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid_PesquisarProduto.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grid_PesquisarProduto.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_PesquisarProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_PesquisarProduto.EnableHeadersVisualStyles = false;
            this.grid_PesquisarProduto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grid_PesquisarProduto.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.grid_PesquisarProduto.HeaderBgColor = System.Drawing.Color.Empty;
            this.grid_PesquisarProduto.HeaderForeColor = System.Drawing.Color.White;
            this.grid_PesquisarProduto.Location = new System.Drawing.Point(0, 66);
            this.grid_PesquisarProduto.Name = "grid_PesquisarProduto";
            this.grid_PesquisarProduto.ReadOnly = true;
            this.grid_PesquisarProduto.RowHeadersVisible = false;
            this.grid_PesquisarProduto.RowTemplate.Height = 40;
            this.grid_PesquisarProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_PesquisarProduto.Size = new System.Drawing.Size(1054, 442);
            this.grid_PesquisarProduto.TabIndex = 76;
            this.grid_PesquisarProduto.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.grid_PesquisarProduto.DoubleClick += new System.EventHandler(this.grid_PesquisarProduto_DoubleClick);
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.txt_BuscarMarca);
            this.bunifuGroupBox1.Controls.Add(this.txt_BuscarDescricao);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel2);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel3);
            this.bunifuGroupBox1.Controls.Add(this.txt_BuscarReferencia);
            this.bunifuGroupBox1.Controls.Add(this.txt_BuscaCodigoProduto);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel5);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel4);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(0, 34);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(1057, 30);
            this.bunifuGroupBox1.TabIndex = 66;
            this.bunifuGroupBox1.TabStop = false;
            // 
            // txt_BuscarMarca
            // 
            this.txt_BuscarMarca.Location = new System.Drawing.Point(221, 4);
            this.txt_BuscarMarca.Name = "txt_BuscarMarca";
            this.txt_BuscarMarca.Size = new System.Drawing.Size(222, 23);
            this.txt_BuscarMarca.TabIndex = 80;
            this.txt_BuscarMarca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BuscarMarca_KeyUp);
            // 
            // txt_BuscarDescricao
            // 
            this.txt_BuscarDescricao.Location = new System.Drawing.Point(519, 4);
            this.txt_BuscarDescricao.Name = "txt_BuscarDescricao";
            this.txt_BuscarDescricao.Size = new System.Drawing.Size(232, 23);
            this.txt_BuscarDescricao.TabIndex = 81;
            this.txt_BuscarDescricao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BuscarDescricao_KeyUp);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.Location = new System.Drawing.Point(449, 7);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(64, 17);
            this.bunifuLabel2.TabIndex = 79;
            this.bunifuLabel2.Text = "Descrição:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.Location = new System.Drawing.Point(172, 7);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(43, 17);
            this.bunifuLabel3.TabIndex = 78;
            this.bunifuLabel3.Text = "Marca:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_BuscarReferencia
            // 
            this.txt_BuscarReferencia.Location = new System.Drawing.Point(841, 4);
            this.txt_BuscarReferencia.Name = "txt_BuscarReferencia";
            this.txt_BuscarReferencia.Size = new System.Drawing.Size(210, 23);
            this.txt_BuscarReferencia.TabIndex = 77;
            this.txt_BuscarReferencia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BuscarReferencia_KeyUp);
            // 
            // txt_BuscaCodigoProduto
            // 
            this.txt_BuscaCodigoProduto.Location = new System.Drawing.Point(58, 4);
            this.txt_BuscaCodigoProduto.Name = "txt_BuscaCodigoProduto";
            this.txt_BuscaCodigoProduto.Size = new System.Drawing.Size(108, 23);
            this.txt_BuscaCodigoProduto.TabIndex = 77;
            this.txt_BuscaCodigoProduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BuscaCodigoProduto_KeyUp);
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
            this.bunifuLabel4.Location = new System.Drawing.Point(764, 7);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(71, 17);
            this.bunifuLabel4.TabIndex = 22;
            this.bunifuLabel4.Text = "Referência:";
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
            this.bunifuLabel1.Size = new System.Drawing.Size(112, 17);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Pesquisar Produto";
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
            // btn_AbrirCadastroProdutos
            // 
            this.btn_AbrirCadastroProdutos.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_AbrirCadastroProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_AbrirCadastroProdutos.Location = new System.Drawing.Point(0, 459);
            this.btn_AbrirCadastroProdutos.Name = "btn_AbrirCadastroProdutos";
            this.btn_AbrirCadastroProdutos.Size = new System.Drawing.Size(207, 50);
            this.btn_AbrirCadastroProdutos.TabIndex = 4;
            this.btn_AbrirCadastroProdutos.Text = "Abrir cadastro de produtos";
            this.btn_AbrirCadastroProdutos.UseVisualStyleBackColor = false;
            this.btn_AbrirCadastroProdutos.Click += new System.EventHandler(this.btn_AbrirCadastroProdutos_Click);
            // 
            // btn_ImprimirRelacaoProdutos
            // 
            this.btn_ImprimirRelacaoProdutos.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ImprimirRelacaoProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ImprimirRelacaoProdutos.Location = new System.Drawing.Point(285, 459);
            this.btn_ImprimirRelacaoProdutos.Name = "btn_ImprimirRelacaoProdutos";
            this.btn_ImprimirRelacaoProdutos.Size = new System.Drawing.Size(207, 50);
            this.btn_ImprimirRelacaoProdutos.TabIndex = 5;
            this.btn_ImprimirRelacaoProdutos.Text = "Imprimir relação de produtos";
            this.btn_ImprimirRelacaoProdutos.UseVisualStyleBackColor = false;
            // 
            // btn_ExportarExcel
            // 
            this.btn_ExportarExcel.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ExportarExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ExportarExcel.Location = new System.Drawing.Point(570, 459);
            this.btn_ExportarExcel.Name = "btn_ExportarExcel";
            this.btn_ExportarExcel.Size = new System.Drawing.Size(207, 50);
            this.btn_ExportarExcel.TabIndex = 6;
            this.btn_ExportarExcel.Text = "Exportar para Excel relação de produtos";
            this.btn_ExportarExcel.UseVisualStyleBackColor = false;
            // 
            // btn_FecharPesquisaProduto
            // 
            this.btn_FecharPesquisaProduto.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_FecharPesquisaProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_FecharPesquisaProduto.Location = new System.Drawing.Point(848, 459);
            this.btn_FecharPesquisaProduto.Name = "btn_FecharPesquisaProduto";
            this.btn_FecharPesquisaProduto.Size = new System.Drawing.Size(207, 50);
            this.btn_FecharPesquisaProduto.TabIndex = 7;
            this.btn_FecharPesquisaProduto.Text = "Fechar";
            this.btn_FecharPesquisaProduto.UseVisualStyleBackColor = false;
            this.btn_FecharPesquisaProduto.Click += new System.EventHandler(this.button5_Click);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "cl_Codigo";
            this.codigo.HeaderText = "CÓDIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // CODBARRAS
            // 
            this.CODBARRAS.DataPropertyName = "cl_CodigoBarras";
            this.CODBARRAS.HeaderText = "CÓDIGO DE BARRAS";
            this.CODBARRAS.Name = "CODBARRAS";
            this.CODBARRAS.ReadOnly = true;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.DataPropertyName = "cl_Descricao";
            this.DESCRICAO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            // 
            // UNIDADE
            // 
            this.UNIDADE.DataPropertyName = "cl_Unidade";
            this.UNIDADE.HeaderText = "UNIDADE";
            this.UNIDADE.Name = "UNIDADE";
            this.UNIDADE.ReadOnly = true;
            this.UNIDADE.Visible = false;
            // 
            // PRECOCOMPRA
            // 
            this.PRECOCOMPRA.DataPropertyName = "cl_PrecoCompra";
            this.PRECOCOMPRA.HeaderText = "PREÇO COMPRA";
            this.PRECOCOMPRA.Name = "PRECOCOMPRA";
            this.PRECOCOMPRA.ReadOnly = true;
            this.PRECOCOMPRA.Visible = false;
            // 
            // MARGEM
            // 
            this.MARGEM.DataPropertyName = "cl_Margem";
            this.MARGEM.HeaderText = "MARGEM";
            this.MARGEM.Name = "MARGEM";
            this.MARGEM.ReadOnly = true;
            this.MARGEM.Visible = false;
            // 
            // LUCRO
            // 
            this.LUCRO.DataPropertyName = "cl_Lucro";
            this.LUCRO.HeaderText = "LUCRO";
            this.LUCRO.Name = "LUCRO";
            this.LUCRO.ReadOnly = true;
            this.LUCRO.Visible = false;
            // 
            // PRECOVENDA
            // 
            this.PRECOVENDA.DataPropertyName = "cl_PrecoVenda";
            this.PRECOVENDA.HeaderText = "PREÇO DE VENDA";
            this.PRECOVENDA.Name = "PRECOVENDA";
            this.PRECOVENDA.ReadOnly = true;
            this.PRECOVENDA.Visible = false;
            // 
            // PRECOPRAZO
            // 
            this.PRECOPRAZO.DataPropertyName = "cl_PrecoAPrazo";
            this.PRECOPRAZO.HeaderText = "PREÇO A PRAZO";
            this.PRECOPRAZO.Name = "PRECOPRAZO";
            this.PRECOPRAZO.ReadOnly = true;
            this.PRECOPRAZO.Visible = false;
            // 
            // GRUPO
            // 
            this.GRUPO.DataPropertyName = "cl_Grupo";
            this.GRUPO.HeaderText = "GRUPO";
            this.GRUPO.Name = "GRUPO";
            this.GRUPO.ReadOnly = true;
            // 
            // SUBGRUPO
            // 
            this.SUBGRUPO.DataPropertyName = "cl_Subgrupo";
            this.SUBGRUPO.HeaderText = "SUB GRUPO";
            this.SUBGRUPO.Name = "SUBGRUPO";
            this.SUBGRUPO.ReadOnly = true;
            // 
            // FORNECEDOR
            // 
            this.FORNECEDOR.DataPropertyName = "cl_Fornecedor";
            this.FORNECEDOR.HeaderText = "FORNECEDOR";
            this.FORNECEDOR.Name = "FORNECEDOR";
            this.FORNECEDOR.ReadOnly = true;
            this.FORNECEDOR.Visible = false;
            // 
            // ESTOQUEMINIMO
            // 
            this.ESTOQUEMINIMO.DataPropertyName = "cl_EstoqueMinimo";
            this.ESTOQUEMINIMO.HeaderText = "ESTOQUE MIN";
            this.ESTOQUEMINIMO.Name = "ESTOQUEMINIMO";
            this.ESTOQUEMINIMO.ReadOnly = true;
            this.ESTOQUEMINIMO.Visible = false;
            // 
            // GARANTIA
            // 
            this.GARANTIA.DataPropertyName = "cl_Garantia";
            this.GARANTIA.HeaderText = "GARANTIA";
            this.GARANTIA.Name = "GARANTIA";
            this.GARANTIA.ReadOnly = true;
            this.GARANTIA.Visible = false;
            // 
            // MARCA
            // 
            this.MARCA.DataPropertyName = "cl_Marca";
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            this.MARCA.ReadOnly = true;
            // 
            // REFERENCIA
            // 
            this.REFERENCIA.DataPropertyName = "cl_Referencia";
            this.REFERENCIA.HeaderText = "REFERÊNCIA ";
            this.REFERENCIA.Name = "REFERENCIA";
            this.REFERENCIA.ReadOnly = true;
            // 
            // DATAVALIDADE
            // 
            this.DATAVALIDADE.DataPropertyName = "cl_DataValidade";
            this.DATAVALIDADE.HeaderText = "DATA DE VALIDADE";
            this.DATAVALIDADE.Name = "DATAVALIDADE";
            this.DATAVALIDADE.ReadOnly = true;
            this.DATAVALIDADE.Visible = false;
            // 
            // COMISSAO
            // 
            this.COMISSAO.DataPropertyName = "cl_Comissao";
            this.COMISSAO.HeaderText = "COMISSÃO";
            this.COMISSAO.Name = "COMISSAO";
            this.COMISSAO.ReadOnly = true;
            this.COMISSAO.Visible = false;
            // 
            // OBSERVACOES
            // 
            this.OBSERVACOES.DataPropertyName = "cl_Observacoes";
            this.OBSERVACOES.HeaderText = "OBSERVAÇÕES";
            this.OBSERVACOES.Name = "OBSERVACOES";
            this.OBSERVACOES.ReadOnly = true;
            this.OBSERVACOES.Visible = false;
            // 
            // ESTOQUEATUAL
            // 
            this.ESTOQUEATUAL.DataPropertyName = "cl_EstoqueAtual";
            this.ESTOQUEATUAL.HeaderText = "ESTOQUE ATUAL";
            this.ESTOQUEATUAL.Name = "ESTOQUEATUAL";
            this.ESTOQUEATUAL.ReadOnly = true;
            this.ESTOQUEATUAL.Visible = false;
            // 
            // Imagem
            // 
            this.Imagem.DataPropertyName = "cl_Imagem";
            this.Imagem.HeaderText = "IMAGEM";
            this.Imagem.Name = "Imagem";
            this.Imagem.ReadOnly = true;
            this.Imagem.Visible = false;
            // 
            // form_ProcurarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 509);
            this.Controls.Add(this.btn_FecharPesquisaProduto);
            this.Controls.Add(this.btn_ExportarExcel);
            this.Controls.Add(this.btn_ImprimirRelacaoProdutos);
            this.Controls.Add(this.btn_AbrirCadastroProdutos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_ProcurarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_ProcurarProduto";
            this.Load += new System.EventHandler(this.form_ProcurarProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PesquisarProduto)).EndInit();
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Button btn_Fechar;
        private Bunifu.UI.WinForms.BunifuDataGridView grid_PesquisarProduto;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private System.Windows.Forms.TextBox txt_BuscarReferencia;
        private System.Windows.Forms.TextBox txt_BuscaCodigoProduto;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox txt_BuscarMarca;
        private System.Windows.Forms.TextBox txt_BuscarDescricao;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private System.Windows.Forms.Button btn_AbrirCadastroProdutos;
        private System.Windows.Forms.Button btn_ImprimirRelacaoProdutos;
        private System.Windows.Forms.Button btn_ExportarExcel;
        private System.Windows.Forms.Button btn_FecharPesquisaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODBARRAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECOCOMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARGEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUCRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECOVENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECOPRAZO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBGRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORNECEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUEMINIMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GARANTIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATAVALIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMISSAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACOES;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUEATUAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagem;
    }
}