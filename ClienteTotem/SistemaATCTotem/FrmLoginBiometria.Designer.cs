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
            this.LblStatus = new System.Windows.Forms.Label();
            this.PctLogoAtc = new System.Windows.Forms.PictureBox();
            this.CmdSimulaBiometria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
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
            this.PctLogoAtc.MouseHover += new System.EventHandler(this.PctLogoAtc_MouseHover);
            // 
            // CmdSimulaBiometria
            // 
            this.CmdSimulaBiometria.Location = new System.Drawing.Point(1161, 545);
            this.CmdSimulaBiometria.Name = "CmdSimulaBiometria";
            this.CmdSimulaBiometria.Size = new System.Drawing.Size(133, 129);
            this.CmdSimulaBiometria.TabIndex = 2;
            this.CmdSimulaBiometria.Text = "Simula biometria";
            this.CmdSimulaBiometria.UseVisualStyleBackColor = true;
            this.CmdSimulaBiometria.Click += new System.EventHandler(this.button1_Click);
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
            // FrmLoginBiometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdSimulaBiometria);
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
        private System.Windows.Forms.Button CmdSimulaBiometria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
    }
}

