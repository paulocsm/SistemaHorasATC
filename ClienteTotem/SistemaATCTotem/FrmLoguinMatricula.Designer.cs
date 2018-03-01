namespace SistemaATCTotem
{
    partial class FrmLoguinMatricula
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
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.CmdLogin = new System.Windows.Forms.Button();
            this.CmdCancelar = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.PctLogoAtc = new System.Windows.Forms.PictureBox();
            this.CmdConfiguracoes = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogoAtc)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMatricula.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMatricula.Location = new System.Drawing.Point(566, 357);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(242, 46);
            this.TxtMatricula.TabIndex = 4;
            this.TxtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtMatricula.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtMatricula_MouseClick);
            this.TxtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMatricula_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(604, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(629, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            // 
            // TxtSenha
            // 
            this.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSenha.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(566, 454);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(242, 46);
            this.TxtSenha.TabIndex = 6;
            this.TxtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSenha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtSenha_MouseClick);
            this.TxtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSenha_KeyPress);
            // 
            // CmdLogin
            // 
            this.CmdLogin.BackColor = System.Drawing.Color.Gray;
            this.CmdLogin.Font = new System.Drawing.Font("Calibri", 27.75F);
            this.CmdLogin.ForeColor = System.Drawing.Color.White;
            this.CmdLogin.Location = new System.Drawing.Point(469, 545);
            this.CmdLogin.Name = "CmdLogin";
            this.CmdLogin.Size = new System.Drawing.Size(188, 72);
            this.CmdLogin.TabIndex = 8;
            this.CmdLogin.Text = "Acessar";
            this.CmdLogin.UseVisualStyleBackColor = false;
            this.CmdLogin.Click += new System.EventHandler(this.CmdLogin_Click);
            // 
            // CmdCancelar
            // 
            this.CmdCancelar.BackColor = System.Drawing.Color.Gray;
            this.CmdCancelar.Font = new System.Drawing.Font("Calibri", 27.75F);
            this.CmdCancelar.ForeColor = System.Drawing.Color.White;
            this.CmdCancelar.Location = new System.Drawing.Point(715, 545);
            this.CmdCancelar.Name = "CmdCancelar";
            this.CmdCancelar.Size = new System.Drawing.Size(188, 72);
            this.CmdCancelar.TabIndex = 9;
            this.CmdCancelar.Text = "Cancelar";
            this.CmdCancelar.UseVisualStyleBackColor = false;
            this.CmdCancelar.Click += new System.EventHandler(this.CmdCancelar_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(463, 650);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(444, 45);
            this.LblStatus.TabIndex = 3;
            this.LblStatus.Text = "Informe os dados solicitados";
            // 
            // PctLogoAtc
            // 
            this.PctLogoAtc.Image = global::SistemaATCTotem.Properties.Resources.atclogocinza;
            this.PctLogoAtc.Location = new System.Drawing.Point(563, 39);
            this.PctLogoAtc.Name = "PctLogoAtc";
            this.PctLogoAtc.Size = new System.Drawing.Size(245, 242);
            this.PctLogoAtc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctLogoAtc.TabIndex = 2;
            this.PctLogoAtc.TabStop = false;
            // 
            // CmdConfiguracoes
            // 
            this.CmdConfiguracoes.BackColor = System.Drawing.Color.Gray;
            this.CmdConfiguracoes.Font = new System.Drawing.Font("Calibri", 22F);
            this.CmdConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.CmdConfiguracoes.Location = new System.Drawing.Point(1121, 639);
            this.CmdConfiguracoes.Name = "CmdConfiguracoes";
            this.CmdConfiguracoes.Size = new System.Drawing.Size(201, 72);
            this.CmdConfiguracoes.TabIndex = 37;
            this.CmdConfiguracoes.Text = "Configurações";
            this.CmdConfiguracoes.UseVisualStyleBackColor = false;
            this.CmdConfiguracoes.Click += new System.EventHandler(this.CmdConfiguracoes_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::SistemaATCTotem.Properties.Resources.close__1_;
            this.btnFechar.Location = new System.Drawing.Point(1307, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(59, 27);
            this.btnFechar.TabIndex = 40;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmLoguinMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.CmdConfiguracoes);
            this.Controls.Add(this.CmdCancelar);
            this.Controls.Add(this.CmdLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.PctLogoAtc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoguinMatricula";
            this.Text = "FrmLoguinMatricula";
            this.Load += new System.EventHandler(this.FrmLoguinMatricula_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmLoguinMatricula_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmLoguinMatricula_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.PctLogoAtc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PctLogoAtc;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Button CmdLogin;
        private System.Windows.Forms.Button CmdCancelar;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Button CmdConfiguracoes;
        private System.Windows.Forms.Button btnFechar;
    }
}