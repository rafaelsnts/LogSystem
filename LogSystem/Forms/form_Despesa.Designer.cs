namespace LogSystem.Forms
{
    partial class form_Despesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Despesa));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Frenquencia = new System.Windows.Forms.ComboBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.dtp_Vencimento = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dtp_Emissao = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Titulo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.cmb_TipoDespesa = new System.Windows.Forms.ComboBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_InserirFoto = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel28 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_ExcluirDespesa = new System.Windows.Forms.Button();
            this.btn_ProcurarDespesa = new System.Windows.Forms.Button();
            this.btn_AlterarDespesa = new System.Windows.Forms.Button();
            this.btn_SalvarDespesa = new System.Windows.Forms.Button();
            this.btn_NovaDespesa = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmb_Frenquencia);
            this.panel1.Controls.Add(this.txt_Valor);
            this.panel1.Controls.Add(this.dtp_Vencimento);
            this.panel1.Controls.Add(this.dtp_Emissao);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Descricao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmb_Titulo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Codigo);
            this.panel1.Controls.Add(this.cmb_TipoDespesa);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.btn_InserirFoto);
            this.panel1.Controls.Add(this.bunifuLabel28);
            this.panel1.Controls.Add(this.bunifuSeparator3);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 630);
            this.panel1.TabIndex = 6;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bunifuLabel1.Location = new System.Drawing.Point(6, 5);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(58, 17);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Despesas";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 90;
            this.label8.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 89;
            this.label7.Text = "Frequência";
            // 
            // cmb_Frenquencia
            // 
            this.cmb_Frenquencia.FormattingEnabled = true;
            this.cmb_Frenquencia.Location = new System.Drawing.Point(4, 492);
            this.cmb_Frenquencia.Name = "cmb_Frenquencia";
            this.cmb_Frenquencia.Size = new System.Drawing.Size(200, 21);
            this.cmb_Frenquencia.TabIndex = 88;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(3, 562);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(201, 20);
            this.txt_Valor.TabIndex = 87;
            this.txt_Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Valor_KeyPress);
            // 
            // dtp_Vencimento
            // 
            this.dtp_Vencimento.BackColor = System.Drawing.Color.White;
            this.dtp_Vencimento.BorderRadius = 1;
            this.dtp_Vencimento.Color = System.Drawing.Color.Silver;
            this.dtp_Vencimento.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtp_Vencimento.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtp_Vencimento.DisabledColor = System.Drawing.Color.Gray;
            this.dtp_Vencimento.DisplayWeekNumbers = false;
            this.dtp_Vencimento.DPHeight = 0;
            this.dtp_Vencimento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_Vencimento.FillDatePicker = false;
            this.dtp_Vencimento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_Vencimento.ForeColor = System.Drawing.Color.Black;
            this.dtp_Vencimento.Icon = ((System.Drawing.Image)(resources.GetObject("dtp_Vencimento.Icon")));
            this.dtp_Vencimento.IconColor = System.Drawing.Color.Gray;
            this.dtp_Vencimento.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtp_Vencimento.LeftTextMargin = 5;
            this.dtp_Vencimento.Location = new System.Drawing.Point(294, 399);
            this.dtp_Vencimento.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtp_Vencimento.Name = "dtp_Vencimento";
            this.dtp_Vencimento.Size = new System.Drawing.Size(259, 32);
            this.dtp_Vencimento.TabIndex = 86;
            this.dtp_Vencimento.Value = new System.DateTime(2023, 2, 13, 16, 1, 0, 0);
            // 
            // dtp_Emissao
            // 
            this.dtp_Emissao.BackColor = System.Drawing.Color.White;
            this.dtp_Emissao.BorderRadius = 1;
            this.dtp_Emissao.Color = System.Drawing.Color.Gray;
            this.dtp_Emissao.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtp_Emissao.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtp_Emissao.DisabledColor = System.Drawing.Color.Gray;
            this.dtp_Emissao.DisplayWeekNumbers = false;
            this.dtp_Emissao.DPHeight = 0;
            this.dtp_Emissao.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_Emissao.FillDatePicker = false;
            this.dtp_Emissao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_Emissao.ForeColor = System.Drawing.Color.Black;
            this.dtp_Emissao.Icon = ((System.Drawing.Image)(resources.GetObject("dtp_Emissao.Icon")));
            this.dtp_Emissao.IconColor = System.Drawing.Color.Gray;
            this.dtp_Emissao.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtp_Emissao.LeftTextMargin = 5;
            this.dtp_Emissao.Location = new System.Drawing.Point(4, 399);
            this.dtp_Emissao.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtp_Emissao.Name = "dtp_Emissao";
            this.dtp_Emissao.Size = new System.Drawing.Size(259, 32);
            this.dtp_Emissao.TabIndex = 85;
            this.dtp_Emissao.Value = new System.DateTime(2023, 2, 13, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 84;
            this.label6.Text = "Vencimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 83;
            this.label5.Text = "Emissão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Descrição";
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(4, 319);
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(547, 20);
            this.txt_Descricao.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 79;
            this.label3.Text = "Título";
            // 
            // cmb_Titulo
            // 
            this.cmb_Titulo.FormattingEnabled = true;
            this.cmb_Titulo.Location = new System.Drawing.Point(4, 259);
            this.cmb_Titulo.Name = "cmb_Titulo";
            this.cmb_Titulo.Size = new System.Drawing.Size(218, 21);
            this.cmb_Titulo.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tipo de Despesa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 76;
            this.label1.Text = "Código";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Enabled = false;
            this.txt_Codigo.Location = new System.Drawing.Point(4, 198);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(77, 20);
            this.txt_Codigo.TabIndex = 74;
            // 
            // cmb_TipoDespesa
            // 
            this.cmb_TipoDespesa.FormattingEnabled = true;
            this.cmb_TipoDespesa.Location = new System.Drawing.Point(105, 197);
            this.cmb_TipoDespesa.Name = "cmb_TipoDespesa";
            this.cmb_TipoDespesa.Size = new System.Drawing.Size(117, 21);
            this.cmb_TipoDespesa.TabIndex = 73;
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Image = global::LogSystem.Properties.Resources.delete_25px;
            this.btn_Exit.Location = new System.Drawing.Point(533, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(22, 22);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Fechar.FlatAppearance.BorderSize = 0;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Fechar.ForeColor = System.Drawing.Color.Red;
            this.btn_Fechar.Location = new System.Drawing.Point(1048, 40);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(92, 73);
            this.btn_Fechar.TabIndex = 72;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            // 
            // btn_InserirFoto
            // 
            this.btn_InserirFoto.AllowAnimations = true;
            this.btn_InserirFoto.AllowMouseEffects = true;
            this.btn_InserirFoto.AllowToggling = false;
            this.btn_InserirFoto.AnimationSpeed = 200;
            this.btn_InserirFoto.AutoGenerateColors = false;
            this.btn_InserirFoto.AutoRoundBorders = false;
            this.btn_InserirFoto.AutoSizeLeftIcon = true;
            this.btn_InserirFoto.AutoSizeRightIcon = true;
            this.btn_InserirFoto.BackColor = System.Drawing.Color.Transparent;
            this.btn_InserirFoto.BackColor1 = System.Drawing.Color.Silver;
            this.btn_InserirFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_InserirFoto.BackgroundImage")));
            this.btn_InserirFoto.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_InserirFoto.ButtonText = "Inserir Foto Cliente";
            this.btn_InserirFoto.ButtonTextMarginLeft = 0;
            this.btn_InserirFoto.ColorContrastOnClick = 45;
            this.btn_InserirFoto.ColorContrastOnHover = 45;
            this.btn_InserirFoto.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_InserirFoto.CustomizableEdges = borderEdges4;
            this.btn_InserirFoto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_InserirFoto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_InserirFoto.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_InserirFoto.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_InserirFoto.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_InserirFoto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_InserirFoto.ForeColor = System.Drawing.Color.Black;
            this.btn_InserirFoto.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InserirFoto.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_InserirFoto.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_InserirFoto.IconMarginLeft = 11;
            this.btn_InserirFoto.IconPadding = 10;
            this.btn_InserirFoto.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InserirFoto.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_InserirFoto.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_InserirFoto.IconSize = 25;
            this.btn_InserirFoto.IdleBorderColor = System.Drawing.Color.Silver;
            this.btn_InserirFoto.IdleBorderRadius = 1;
            this.btn_InserirFoto.IdleBorderThickness = 1;
            this.btn_InserirFoto.IdleFillColor = System.Drawing.Color.Silver;
            this.btn_InserirFoto.IdleIconLeftImage = null;
            this.btn_InserirFoto.IdleIconRightImage = null;
            this.btn_InserirFoto.IndicateFocus = false;
            this.btn_InserirFoto.Location = new System.Drawing.Point(960, 336);
            this.btn_InserirFoto.Name = "btn_InserirFoto";
            this.btn_InserirFoto.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_InserirFoto.OnDisabledState.BorderRadius = 1;
            this.btn_InserirFoto.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_InserirFoto.OnDisabledState.BorderThickness = 1;
            this.btn_InserirFoto.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_InserirFoto.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_InserirFoto.OnDisabledState.IconLeftImage = null;
            this.btn_InserirFoto.OnDisabledState.IconRightImage = null;
            this.btn_InserirFoto.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_InserirFoto.onHoverState.BorderRadius = 1;
            this.btn_InserirFoto.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_InserirFoto.onHoverState.BorderThickness = 1;
            this.btn_InserirFoto.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_InserirFoto.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_InserirFoto.onHoverState.IconLeftImage = null;
            this.btn_InserirFoto.onHoverState.IconRightImage = null;
            this.btn_InserirFoto.OnIdleState.BorderColor = System.Drawing.Color.Silver;
            this.btn_InserirFoto.OnIdleState.BorderRadius = 1;
            this.btn_InserirFoto.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_InserirFoto.OnIdleState.BorderThickness = 1;
            this.btn_InserirFoto.OnIdleState.FillColor = System.Drawing.Color.Silver;
            this.btn_InserirFoto.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_InserirFoto.OnIdleState.IconLeftImage = null;
            this.btn_InserirFoto.OnIdleState.IconRightImage = null;
            this.btn_InserirFoto.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_InserirFoto.OnPressedState.BorderRadius = 1;
            this.btn_InserirFoto.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_InserirFoto.OnPressedState.BorderThickness = 1;
            this.btn_InserirFoto.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_InserirFoto.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_InserirFoto.OnPressedState.IconLeftImage = null;
            this.btn_InserirFoto.OnPressedState.IconRightImage = null;
            this.btn_InserirFoto.Size = new System.Drawing.Size(168, 30);
            this.btn_InserirFoto.TabIndex = 65;
            this.btn_InserirFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_InserirFoto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_InserirFoto.TextMarginLeft = 0;
            this.btn_InserirFoto.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_InserirFoto.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuLabel28
            // 
            this.bunifuLabel28.AllowParentOverrides = false;
            this.bunifuLabel28.AutoEllipsis = false;
            this.bunifuLabel28.CursorType = null;
            this.bunifuLabel28.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel28.Location = new System.Drawing.Point(1007, 139);
            this.bunifuLabel28.Name = "bunifuLabel28";
            this.bunifuLabel28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel28.Size = new System.Drawing.Size(73, 17);
            this.bunifuLabel28.TabIndex = 64;
            this.bunifuLabel28.Text = "Foto Cliente";
            this.bunifuLabel28.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel28.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.bunifuSeparator3.Location = new System.Drawing.Point(3, 598);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator3.Size = new System.Drawing.Size(559, 19);
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
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Black;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 19);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(560, 19);
            this.bunifuSeparator1.TabIndex = 0;
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Sair.FlatAppearance.BorderSize = 0;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Image = global::LogSystem.Properties.Resources.exit_50px;
            this.btn_Sair.Location = new System.Drawing.Point(465, 42);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(87, 99);
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sair.UseVisualStyleBackColor = false;
            // 
            // btn_ExcluirDespesa
            // 
            this.btn_ExcluirDespesa.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ExcluirDespesa.Enabled = false;
            this.btn_ExcluirDespesa.FlatAppearance.BorderSize = 0;
            this.btn_ExcluirDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExcluirDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirDespesa.Image = global::LogSystem.Properties.Resources.trash_can_50px;
            this.btn_ExcluirDespesa.Location = new System.Drawing.Point(372, 42);
            this.btn_ExcluirDespesa.Name = "btn_ExcluirDespesa";
            this.btn_ExcluirDespesa.Size = new System.Drawing.Size(87, 99);
            this.btn_ExcluirDespesa.TabIndex = 4;
            this.btn_ExcluirDespesa.Text = "Excluir";
            this.btn_ExcluirDespesa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ExcluirDespesa.UseVisualStyleBackColor = false;
            // 
            // btn_ProcurarDespesa
            // 
            this.btn_ProcurarDespesa.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ProcurarDespesa.FlatAppearance.BorderSize = 0;
            this.btn_ProcurarDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProcurarDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProcurarDespesa.Image = global::LogSystem.Properties.Resources.search_50px;
            this.btn_ProcurarDespesa.Location = new System.Drawing.Point(279, 42);
            this.btn_ProcurarDespesa.Name = "btn_ProcurarDespesa";
            this.btn_ProcurarDespesa.Size = new System.Drawing.Size(87, 99);
            this.btn_ProcurarDespesa.TabIndex = 3;
            this.btn_ProcurarDespesa.Text = "Procurar";
            this.btn_ProcurarDespesa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ProcurarDespesa.UseVisualStyleBackColor = false;
            // 
            // btn_AlterarDespesa
            // 
            this.btn_AlterarDespesa.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_AlterarDespesa.Enabled = false;
            this.btn_AlterarDespesa.FlatAppearance.BorderSize = 0;
            this.btn_AlterarDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AlterarDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarDespesa.Image = global::LogSystem.Properties.Resources.edit_file_50px;
            this.btn_AlterarDespesa.Location = new System.Drawing.Point(186, 42);
            this.btn_AlterarDespesa.Name = "btn_AlterarDespesa";
            this.btn_AlterarDespesa.Size = new System.Drawing.Size(87, 99);
            this.btn_AlterarDespesa.TabIndex = 2;
            this.btn_AlterarDespesa.Text = "Alterar";
            this.btn_AlterarDespesa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AlterarDespesa.UseVisualStyleBackColor = false;
            this.btn_AlterarDespesa.Click += new System.EventHandler(this.btn_AlterarDespesa_Click);
            // 
            // btn_SalvarDespesa
            // 
            this.btn_SalvarDespesa.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_SalvarDespesa.FlatAppearance.BorderSize = 0;
            this.btn_SalvarDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalvarDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarDespesa.Image = global::LogSystem.Properties.Resources.Salvar;
            this.btn_SalvarDespesa.Location = new System.Drawing.Point(93, 42);
            this.btn_SalvarDespesa.Name = "btn_SalvarDespesa";
            this.btn_SalvarDespesa.Size = new System.Drawing.Size(87, 99);
            this.btn_SalvarDespesa.TabIndex = 1;
            this.btn_SalvarDespesa.Text = "Salvar";
            this.btn_SalvarDespesa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SalvarDespesa.UseVisualStyleBackColor = false;
            this.btn_SalvarDespesa.Click += new System.EventHandler(this.btn_SalvarDespesa_Click);
            // 
            // btn_NovaDespesa
            // 
            this.btn_NovaDespesa.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_NovaDespesa.Enabled = false;
            this.btn_NovaDespesa.FlatAppearance.BorderSize = 0;
            this.btn_NovaDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NovaDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovaDespesa.Image = global::LogSystem.Properties.Resources.Novo;
            this.btn_NovaDespesa.Location = new System.Drawing.Point(3, 42);
            this.btn_NovaDespesa.Name = "btn_NovaDespesa";
            this.btn_NovaDespesa.Size = new System.Drawing.Size(87, 99);
            this.btn_NovaDespesa.TabIndex = 0;
            this.btn_NovaDespesa.Text = "Nova";
            this.btn_NovaDespesa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_NovaDespesa.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form_Despesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 625);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_ExcluirDespesa);
            this.Controls.Add(this.btn_ProcurarDespesa);
            this.Controls.Add(this.btn_AlterarDespesa);
            this.Controls.Add(this.btn_SalvarDespesa);
            this.Controls.Add(this.btn_NovaDespesa);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Despesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_ControleDespesa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NovaDespesa;
        private System.Windows.Forms.Button btn_SalvarDespesa;
        private System.Windows.Forms.Button btn_ProcurarDespesa;
        private System.Windows.Forms.Button btn_AlterarDespesa;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_ExcluirDespesa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Fechar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_InserirFoto;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel28;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuDatePicker dtp_Emissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.ComboBox cmb_TipoDespesa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Frenquencia;
        private System.Windows.Forms.TextBox txt_Valor;
        private Bunifu.UI.WinForms.BunifuDatePicker dtp_Vencimento;
        private System.Windows.Forms.Timer timer1;
    }
}