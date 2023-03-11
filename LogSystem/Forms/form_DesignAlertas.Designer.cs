namespace LogSystem.Forms
{
    partial class form_DesignAlertas
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
            this.btn_SucessoAlerta = new System.Windows.Forms.Button();
            this.btn_AvisoAlertas = new System.Windows.Forms.Button();
            this.btn_ErroAlertas = new System.Windows.Forms.Button();
            this.btn_InfoAlertas = new System.Windows.Forms.Button();
            this.lbl_Sucesso = new System.Windows.Forms.Label();
            this.lbl_Aviso = new System.Windows.Forms.Label();
            this.lbl_Erro = new System.Windows.Forms.Label();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SucessoAlerta
            // 
            this.btn_SucessoAlerta.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_SucessoAlerta.FlatAppearance.BorderSize = 0;
            this.btn_SucessoAlerta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SucessoAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SucessoAlerta.ForeColor = System.Drawing.Color.White;
            this.btn_SucessoAlerta.Location = new System.Drawing.Point(62, 55);
            this.btn_SucessoAlerta.Name = "btn_SucessoAlerta";
            this.btn_SucessoAlerta.Size = new System.Drawing.Size(183, 50);
            this.btn_SucessoAlerta.TabIndex = 0;
            this.btn_SucessoAlerta.UseVisualStyleBackColor = false;
            this.btn_SucessoAlerta.Click += new System.EventHandler(this.btn_SucessoAlerta_Click);
            // 
            // btn_AvisoAlertas
            // 
            this.btn_AvisoAlertas.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_AvisoAlertas.FlatAppearance.BorderSize = 0;
            this.btn_AvisoAlertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AvisoAlertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AvisoAlertas.ForeColor = System.Drawing.Color.White;
            this.btn_AvisoAlertas.Location = new System.Drawing.Point(62, 111);
            this.btn_AvisoAlertas.Name = "btn_AvisoAlertas";
            this.btn_AvisoAlertas.Size = new System.Drawing.Size(183, 50);
            this.btn_AvisoAlertas.TabIndex = 1;
            this.btn_AvisoAlertas.UseVisualStyleBackColor = false;
            this.btn_AvisoAlertas.Click += new System.EventHandler(this.btn_AvisoAlertas_Click);
            // 
            // btn_ErroAlertas
            // 
            this.btn_ErroAlertas.BackColor = System.Drawing.Color.DarkRed;
            this.btn_ErroAlertas.FlatAppearance.BorderSize = 0;
            this.btn_ErroAlertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ErroAlertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ErroAlertas.ForeColor = System.Drawing.Color.White;
            this.btn_ErroAlertas.Location = new System.Drawing.Point(62, 166);
            this.btn_ErroAlertas.Name = "btn_ErroAlertas";
            this.btn_ErroAlertas.Size = new System.Drawing.Size(183, 50);
            this.btn_ErroAlertas.TabIndex = 2;
            this.btn_ErroAlertas.UseVisualStyleBackColor = false;
            this.btn_ErroAlertas.Click += new System.EventHandler(this.btn_ErroAlertas_Click);
            // 
            // btn_InfoAlertas
            // 
            this.btn_InfoAlertas.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_InfoAlertas.FlatAppearance.BorderSize = 0;
            this.btn_InfoAlertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InfoAlertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InfoAlertas.ForeColor = System.Drawing.Color.White;
            this.btn_InfoAlertas.Location = new System.Drawing.Point(62, 220);
            this.btn_InfoAlertas.Name = "btn_InfoAlertas";
            this.btn_InfoAlertas.Size = new System.Drawing.Size(183, 50);
            this.btn_InfoAlertas.TabIndex = 3;
            this.btn_InfoAlertas.UseVisualStyleBackColor = false;
            this.btn_InfoAlertas.Click += new System.EventHandler(this.btn_InfoAlertas_Click);
            // 
            // lbl_Sucesso
            // 
            this.lbl_Sucesso.AutoSize = true;
            this.lbl_Sucesso.BackColor = System.Drawing.Color.SeaGreen;
            this.lbl_Sucesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_Sucesso.ForeColor = System.Drawing.Color.White;
            this.lbl_Sucesso.Location = new System.Drawing.Point(120, 71);
            this.lbl_Sucesso.Name = "lbl_Sucesso";
            this.lbl_Sucesso.Size = new System.Drawing.Size(67, 18);
            this.lbl_Sucesso.TabIndex = 4;
            this.lbl_Sucesso.Text = "Sucesso";
            // 
            // lbl_Aviso
            // 
            this.lbl_Aviso.AutoSize = true;
            this.lbl_Aviso.BackColor = System.Drawing.Color.OrangeRed;
            this.lbl_Aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_Aviso.ForeColor = System.Drawing.Color.White;
            this.lbl_Aviso.Location = new System.Drawing.Point(131, 127);
            this.lbl_Aviso.Name = "lbl_Aviso";
            this.lbl_Aviso.Size = new System.Drawing.Size(44, 18);
            this.lbl_Aviso.TabIndex = 5;
            this.lbl_Aviso.Text = "Aviso";
            // 
            // lbl_Erro
            // 
            this.lbl_Erro.AutoSize = true;
            this.lbl_Erro.BackColor = System.Drawing.Color.DarkRed;
            this.lbl_Erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_Erro.ForeColor = System.Drawing.Color.White;
            this.lbl_Erro.Location = new System.Drawing.Point(135, 182);
            this.lbl_Erro.Name = "lbl_Erro";
            this.lbl_Erro.Size = new System.Drawing.Size(37, 18);
            this.lbl_Erro.TabIndex = 6;
            this.lbl_Erro.Text = "Erro";
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_Info.ForeColor = System.Drawing.Color.White;
            this.lbl_Info.Location = new System.Drawing.Point(137, 236);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(32, 18);
            this.lbl_Info.TabIndex = 7;
            this.lbl_Info.Text = "Info";
            // 
            // form_DesignAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 345);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.lbl_Erro);
            this.Controls.Add(this.lbl_Aviso);
            this.Controls.Add(this.lbl_Sucesso);
            this.Controls.Add(this.btn_InfoAlertas);
            this.Controls.Add(this.btn_ErroAlertas);
            this.Controls.Add(this.btn_AvisoAlertas);
            this.Controls.Add(this.btn_SucessoAlerta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_DesignAlertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Alertas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SucessoAlerta;
        private System.Windows.Forms.Button btn_AvisoAlertas;
        private System.Windows.Forms.Button btn_ErroAlertas;
        private System.Windows.Forms.Button btn_InfoAlertas;
        private System.Windows.Forms.Label lbl_Sucesso;
        private System.Windows.Forms.Label lbl_Aviso;
        private System.Windows.Forms.Label lbl_Erro;
        private System.Windows.Forms.Label lbl_Info;
    }
}