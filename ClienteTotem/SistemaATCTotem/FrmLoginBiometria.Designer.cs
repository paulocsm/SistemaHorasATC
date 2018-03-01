namespace SistemaATCTotem
{
    partial class FrmLoginBiometria
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
            this.LblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.CmdConfiguracoes = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.PctLogoAtc = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PctLogoAtc)).BeginInit();
            this.SuspendLayout();
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(271, 605);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(831, 45);
            this.LblStatus.TabIndex = 1;
            this.LblStatus.Text = "Posicione o dedo no leitor biométrico ou toque na tela";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1148, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(1175, 503);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 4;
            // 
            // CmdConfiguracoes
            // 
            this.CmdConfiguracoes.BackColor = System.Drawing.Color.Gray;
            this.CmdConfiguracoes.Font = new System.Drawing.Font("Calibri", 22F);
            this.CmdConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.CmdConfiguracoes.Location = new System.Drawing.Point(1140, 542);
            this.CmdConfiguracoes.Name = "CmdConfiguracoes";
            this.CmdConfiguracoes.Size = new System.Drawing.Size(169, 134);
            this.CmdConfiguracoes.TabIndex = 38;
            this.CmdConfiguracoes.Text = "Simula Biometria";
            this.CmdConfiguracoes.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Gray;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::SistemaATCTotem.Properties.Resources.close__1_;
            this.btnFechar.Location = new System.Drawing.Point(1307, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(59, 27);
            this.btnFechar.TabIndex = 39;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // PctLogoAtc
            // 
            this.PctLogoAtc.Image = global::SistemaATCTotem.Properties.Resources.atclogocinza;
            this.PctLogoAtc.Location = new System.Drawing.Point(451, 62);
            this.PctLogoAtc.Name = "PctLogoAtc";
            this.PctLogoAtc.Size = new System.Drawing.Size(455, 461);
            this.PctLogoAtc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctLogoAtc.TabIndex = 0;
            this.PctLogoAtc.TabStop = false;
            this.PctLogoAtc.Click += new System.EventHandler(this.PctLogoAtc_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.Image = global::SistemaATCTotem.Properties.Resources.line;
            this.btnMinimizar.Location = new System.Drawing.Point(1247, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(59, 27);
            this.btnMinimizar.TabIndex = 42;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            // 
            // FrmLoginBiometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.CmdConfiguracoes);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.PctLogoAtc);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoginBiometria";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.FrmLoginBiometria_Click);
            this.MouseHover += new System.EventHandler(this.FrmLoginBiometria_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.PctLogoAtc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctLogoAtc;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button CmdConfiguracoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

