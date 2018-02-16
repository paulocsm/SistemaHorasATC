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
            ((System.ComponentModel.ISupportInitialize)(this.PctLogoAtc)).BeginInit();
            this.SuspendLayout();
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(260, 605);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(831, 45);
            this.LblStatus.TabIndex = 1;
            this.LblStatus.Text = "Posicione o dedo no leitor biométrico ou toque na tela";
            // 
            // PctLogoAtc
            // 
            this.PctLogoAtc.Image = global::SistemaATCTotem.Properties.Resources.atclogocinza;
            this.PctLogoAtc.Location = new System.Drawing.Point(440, 62);
            this.PctLogoAtc.Name = "PctLogoAtc";
            this.PctLogoAtc.Size = new System.Drawing.Size(455, 461);
            this.PctLogoAtc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctLogoAtc.TabIndex = 0;
            this.PctLogoAtc.TabStop = false;
            // 
            // FrmLoginBiometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.PctLogoAtc);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmLoginBiometria";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLoginBiometria_Load);
            this.Click += new System.EventHandler(this.FrmLoginBiometria_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PctLogoAtc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctLogoAtc;
        private System.Windows.Forms.Label LblStatus;
    }
}

