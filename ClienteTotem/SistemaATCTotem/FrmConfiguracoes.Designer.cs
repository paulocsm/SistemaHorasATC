namespace SistemaATCTotem
{
    partial class FrmConfiguracoes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TabServCmdTestCom = new System.Windows.Forms.Button();
            this.TabServLblStatus = new System.Windows.Forms.Label();
            this.TabServCmdSair = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TabServTxtApiKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TabServTxtPortaServidor = new System.Windows.Forms.TextBox();
            this.TabServCmdSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TabServTxtEndServidor = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TabLeitorCmdAtualizarPortas = new System.Windows.Forms.Button();
            this.TabLeitorCmdTestCom = new System.Windows.Forms.Button();
            this.TabLeitorLblStatus = new System.Windows.Forms.Label();
            this.TabLeitorCmbBaudRate = new System.Windows.Forms.ComboBox();
            this.TabLeitorCmbDataBits = new System.Windows.Forms.ComboBox();
            this.TabLeitorCmbContFluxo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TabLeitorCmbBitsParada = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TabLeitorCmbParidade = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TabLeitorCmbPorta = new System.Windows.Forms.ComboBox();
            this.TabLeitorCmdSair = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TabLeitorCmdSalvar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PctLogoAtc = new System.Windows.Forms.PictureBox();
            this.LblData = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TmrData = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogoAtc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1342, 625);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(85)))));
            this.tabPage1.Controls.Add(this.TabServCmdTestCom);
            this.tabPage1.Controls.Add(this.TabServLblStatus);
            this.tabPage1.Controls.Add(this.TabServCmdSair);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TabServTxtApiKey);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TabServTxtPortaServidor);
            this.tabPage1.Controls.Add(this.TabServCmdSalvar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TabServTxtEndServidor);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1334, 586);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Servidor";
            // 
            // TabServCmdTestCom
            // 
            this.TabServCmdTestCom.BackColor = System.Drawing.Color.Gray;
            this.TabServCmdTestCom.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabServCmdTestCom.ForeColor = System.Drawing.Color.White;
            this.TabServCmdTestCom.Location = new System.Drawing.Point(21, 527);
            this.TabServCmdTestCom.Name = "TabServCmdTestCom";
            this.TabServCmdTestCom.Size = new System.Drawing.Size(200, 44);
            this.TabServCmdTestCom.TabIndex = 43;
            this.TabServCmdTestCom.Text = "Testar Comunicação";
            this.TabServCmdTestCom.UseVisualStyleBackColor = false;
            this.TabServCmdTestCom.Click += new System.EventHandler(this.TabServCmdTestCom_Click);
            // 
            // TabServLblStatus
            // 
            this.TabServLblStatus.AutoSize = true;
            this.TabServLblStatus.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabServLblStatus.ForeColor = System.Drawing.Color.White;
            this.TabServLblStatus.Location = new System.Drawing.Point(493, 3);
            this.TabServLblStatus.Name = "TabServLblStatus";
            this.TabServLblStatus.Size = new System.Drawing.Size(350, 29);
            this.TabServLblStatus.TabIndex = 40;
            this.TabServLblStatus.Text = "Parametros de acesso ao servidor";
            this.TabServLblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabServCmdSair
            // 
            this.TabServCmdSair.BackColor = System.Drawing.Color.Gray;
            this.TabServCmdSair.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabServCmdSair.ForeColor = System.Drawing.Color.White;
            this.TabServCmdSair.Location = new System.Drawing.Point(680, 527);
            this.TabServCmdSair.Name = "TabServCmdSair";
            this.TabServCmdSair.Size = new System.Drawing.Size(136, 44);
            this.TabServCmdSair.TabIndex = 17;
            this.TabServCmdSair.Text = "Sair";
            this.TabServCmdSair.UseVisualStyleBackColor = false;
            this.TabServCmdSair.Click += new System.EventHandler(this.TabServCmdSair_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "API Key";
            // 
            // TabServTxtApiKey
            // 
            this.TabServTxtApiKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabServTxtApiKey.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabServTxtApiKey.Location = new System.Drawing.Point(21, 145);
            this.TabServTxtApiKey.Name = "TabServTxtApiKey";
            this.TabServTxtApiKey.Size = new System.Drawing.Size(458, 26);
            this.TabServTxtApiKey.TabIndex = 14;
            this.TabServTxtApiKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabServTxtApiKey_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(514, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Porta do servidor";
            // 
            // TabServTxtPortaServidor
            // 
            this.TabServTxtPortaServidor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabServTxtPortaServidor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabServTxtPortaServidor.Location = new System.Drawing.Point(519, 77);
            this.TabServTxtPortaServidor.Name = "TabServTxtPortaServidor";
            this.TabServTxtPortaServidor.Size = new System.Drawing.Size(153, 26);
            this.TabServTxtPortaServidor.TabIndex = 12;
            this.TabServTxtPortaServidor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabServTxtPortaServidor_KeyPress);
            // 
            // TabServCmdSalvar
            // 
            this.TabServCmdSalvar.BackColor = System.Drawing.Color.Gray;
            this.TabServCmdSalvar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabServCmdSalvar.ForeColor = System.Drawing.Color.White;
            this.TabServCmdSalvar.Location = new System.Drawing.Point(519, 527);
            this.TabServCmdSalvar.Name = "TabServCmdSalvar";
            this.TabServCmdSalvar.Size = new System.Drawing.Size(136, 44);
            this.TabServCmdSalvar.TabIndex = 11;
            this.TabServCmdSalvar.Text = "Salvar";
            this.TabServCmdSalvar.UseVisualStyleBackColor = false;
            this.TabServCmdSalvar.Click += new System.EventHandler(this.TabServCmdSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Endereço do servidor";
            // 
            // TabServTxtEndServidor
            // 
            this.TabServTxtEndServidor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabServTxtEndServidor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabServTxtEndServidor.Location = new System.Drawing.Point(21, 77);
            this.TabServTxtEndServidor.Name = "TabServTxtEndServidor";
            this.TabServTxtEndServidor.Size = new System.Drawing.Size(458, 26);
            this.TabServTxtEndServidor.TabIndex = 9;
            this.TabServTxtEndServidor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabServTxtEndServidor_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(85)))));
            this.tabPage2.Controls.Add(this.TabLeitorCmdAtualizarPortas);
            this.tabPage2.Controls.Add(this.TabLeitorCmdTestCom);
            this.tabPage2.Controls.Add(this.TabLeitorLblStatus);
            this.tabPage2.Controls.Add(this.TabLeitorCmbBaudRate);
            this.tabPage2.Controls.Add(this.TabLeitorCmbDataBits);
            this.tabPage2.Controls.Add(this.TabLeitorCmbContFluxo);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.TabLeitorCmbBitsParada);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.TabLeitorCmbParidade);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.TabLeitorCmbPorta);
            this.tabPage2.Controls.Add(this.TabLeitorCmdSair);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.TabLeitorCmdSalvar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1334, 586);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Leitor biométrico";
            // 
            // TabLeitorCmdAtualizarPortas
            // 
            this.TabLeitorCmdAtualizarPortas.BackColor = System.Drawing.Color.Gray;
            this.TabLeitorCmdAtualizarPortas.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabLeitorCmdAtualizarPortas.ForeColor = System.Drawing.Color.White;
            this.TabLeitorCmdAtualizarPortas.Location = new System.Drawing.Point(226, 71);
            this.TabLeitorCmdAtualizarPortas.Name = "TabLeitorCmdAtualizarPortas";
            this.TabLeitorCmdAtualizarPortas.Size = new System.Drawing.Size(165, 44);
            this.TabLeitorCmdAtualizarPortas.TabIndex = 43;
            this.TabLeitorCmdAtualizarPortas.Text = "Atualizar Portas";
            this.TabLeitorCmdAtualizarPortas.UseVisualStyleBackColor = false;
            this.TabLeitorCmdAtualizarPortas.Click += new System.EventHandler(this.TabLeitorCmdAtualizarPortas_Click);
            // 
            // TabLeitorCmdTestCom
            // 
            this.TabLeitorCmdTestCom.BackColor = System.Drawing.Color.Gray;
            this.TabLeitorCmdTestCom.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabLeitorCmdTestCom.ForeColor = System.Drawing.Color.White;
            this.TabLeitorCmdTestCom.Location = new System.Drawing.Point(21, 527);
            this.TabLeitorCmdTestCom.Name = "TabLeitorCmdTestCom";
            this.TabLeitorCmdTestCom.Size = new System.Drawing.Size(200, 44);
            this.TabLeitorCmdTestCom.TabIndex = 42;
            this.TabLeitorCmdTestCom.Text = "Testar Comunicação";
            this.TabLeitorCmdTestCom.UseVisualStyleBackColor = false;
            // 
            // TabLeitorLblStatus
            // 
            this.TabLeitorLblStatus.AutoSize = true;
            this.TabLeitorLblStatus.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabLeitorLblStatus.ForeColor = System.Drawing.Color.White;
            this.TabLeitorLblStatus.Location = new System.Drawing.Point(415, 3);
            this.TabLeitorLblStatus.Name = "TabLeitorLblStatus";
            this.TabLeitorLblStatus.Size = new System.Drawing.Size(537, 29);
            this.TabLeitorLblStatus.TabIndex = 41;
            this.TabLeitorLblStatus.Text = "Parametros de comunicação com o leitor biométrico";
            this.TabLeitorLblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabLeitorCmbBaudRate
            // 
            this.TabLeitorCmbBaudRate.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.TabLeitorCmbBaudRate.FormattingEnabled = true;
            this.TabLeitorCmbBaudRate.Items.AddRange(new object[] {
            "110",
            "",
            "300",
            "",
            "600",
            "",
            "1200",
            "",
            "2400",
            "",
            "4800",
            "",
            "9600",
            "",
            "14400",
            "",
            "19200",
            "",
            "28800",
            "",
            "38400",
            "",
            "56000",
            "",
            "57600",
            "",
            "115200"});
            this.TabLeitorCmbBaudRate.Location = new System.Drawing.Point(21, 142);
            this.TabLeitorCmbBaudRate.Name = "TabLeitorCmbBaudRate";
            this.TabLeitorCmbBaudRate.Size = new System.Drawing.Size(152, 34);
            this.TabLeitorCmbBaudRate.TabIndex = 39;
            // 
            // TabLeitorCmbDataBits
            // 
            this.TabLeitorCmbDataBits.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.TabLeitorCmbDataBits.FormattingEnabled = true;
            this.TabLeitorCmbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.TabLeitorCmbDataBits.Location = new System.Drawing.Point(21, 207);
            this.TabLeitorCmbDataBits.Name = "TabLeitorCmbDataBits";
            this.TabLeitorCmbDataBits.Size = new System.Drawing.Size(152, 34);
            this.TabLeitorCmbDataBits.TabIndex = 38;
            // 
            // TabLeitorCmbContFluxo
            // 
            this.TabLeitorCmbContFluxo.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.TabLeitorCmbContFluxo.FormattingEnabled = true;
            this.TabLeitorCmbContFluxo.Items.AddRange(new object[] {
            "Xon / Xoff",
            "Hardware",
            "Nenhum"});
            this.TabLeitorCmbContFluxo.Location = new System.Drawing.Point(21, 402);
            this.TabLeitorCmbContFluxo.Name = "TabLeitorCmbContFluxo";
            this.TabLeitorCmbContFluxo.Size = new System.Drawing.Size(152, 34);
            this.TabLeitorCmbContFluxo.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(16, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 26);
            this.label12.TabIndex = 36;
            this.label12.Text = "Controle de fluxo";
            // 
            // TabLeitorCmbBitsParada
            // 
            this.TabLeitorCmbBitsParada.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.TabLeitorCmbBitsParada.FormattingEnabled = true;
            this.TabLeitorCmbBitsParada.Items.AddRange(new object[] {
            "1",
            "1,5",
            "2"});
            this.TabLeitorCmbBitsParada.Location = new System.Drawing.Point(21, 337);
            this.TabLeitorCmbBitsParada.Name = "TabLeitorCmbBitsParada";
            this.TabLeitorCmbBitsParada.Size = new System.Drawing.Size(152, 34);
            this.TabLeitorCmbBitsParada.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 26);
            this.label10.TabIndex = 34;
            this.label10.Text = "Bits de parada";
            // 
            // TabLeitorCmbParidade
            // 
            this.TabLeitorCmbParidade.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.TabLeitorCmbParidade.FormattingEnabled = true;
            this.TabLeitorCmbParidade.Items.AddRange(new object[] {
            "Par",
            "Impar",
            "Nenhum"});
            this.TabLeitorCmbParidade.Location = new System.Drawing.Point(21, 272);
            this.TabLeitorCmbParidade.Name = "TabLeitorCmbParidade";
            this.TabLeitorCmbParidade.Size = new System.Drawing.Size(152, 34);
            this.TabLeitorCmbParidade.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 26);
            this.label8.TabIndex = 32;
            this.label8.Text = "Paridade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 26);
            this.label9.TabIndex = 30;
            this.label9.Text = "Data Bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(172, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 26);
            this.label6.TabIndex = 28;
            this.label6.Text = "Bps";
            // 
            // TabLeitorCmbPorta
            // 
            this.TabLeitorCmbPorta.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.TabLeitorCmbPorta.FormattingEnabled = true;
            this.TabLeitorCmbPorta.Location = new System.Drawing.Point(21, 77);
            this.TabLeitorCmbPorta.Name = "TabLeitorCmbPorta";
            this.TabLeitorCmbPorta.Size = new System.Drawing.Size(186, 34);
            this.TabLeitorCmbPorta.TabIndex = 27;
            this.TabLeitorCmbPorta.SelectedIndexChanged += new System.EventHandler(this.TabLeitorCmbPorta_SelectedIndexChanged);
            // 
            // TabLeitorCmdSair
            // 
            this.TabLeitorCmdSair.BackColor = System.Drawing.Color.Gray;
            this.TabLeitorCmdSair.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabLeitorCmdSair.ForeColor = System.Drawing.Color.White;
            this.TabLeitorCmdSair.Location = new System.Drawing.Point(680, 527);
            this.TabLeitorCmdSair.Name = "TabLeitorCmdSair";
            this.TabLeitorCmdSair.Size = new System.Drawing.Size(136, 44);
            this.TabLeitorCmdSair.TabIndex = 26;
            this.TabLeitorCmdSair.Text = "Sair";
            this.TabLeitorCmdSair.UseVisualStyleBackColor = false;
            this.TabLeitorCmdSair.Click += new System.EventHandler(this.TabLeitorCmdSair_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Baud Rate";
            // 
            // TabLeitorCmdSalvar
            // 
            this.TabLeitorCmdSalvar.BackColor = System.Drawing.Color.Gray;
            this.TabLeitorCmdSalvar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabLeitorCmdSalvar.ForeColor = System.Drawing.Color.White;
            this.TabLeitorCmdSalvar.Location = new System.Drawing.Point(519, 527);
            this.TabLeitorCmdSalvar.Name = "TabLeitorCmdSalvar";
            this.TabLeitorCmdSalvar.Size = new System.Drawing.Size(136, 44);
            this.TabLeitorCmdSalvar.TabIndex = 20;
            this.TabLeitorCmdSalvar.Text = "Salvar";
            this.TabLeitorCmdSalvar.UseVisualStyleBackColor = false;
            this.TabLeitorCmdSalvar.Click += new System.EventHandler(this.TabLeitorCmdSalvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "Porta de comunicação";
            // 
            // PctLogoAtc
            // 
            this.PctLogoAtc.Image = global::SistemaATCTotem.Properties.Resources.atclogocinza;
            this.PctLogoAtc.Location = new System.Drawing.Point(2, 3);
            this.PctLogoAtc.Name = "PctLogoAtc";
            this.PctLogoAtc.Size = new System.Drawing.Size(105, 107);
            this.PctLogoAtc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctLogoAtc.TabIndex = 38;
            this.PctLogoAtc.TabStop = false;
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.ForeColor = System.Drawing.Color.White;
            this.LblData.Location = new System.Drawing.Point(1028, 3);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(326, 39);
            this.LblData.TabIndex = 37;
            this.LblData.Text = "dd/mm/aa -- hh:mm:ss";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(113, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(448, 39);
            this.label11.TabIndex = 36;
            this.label11.Text = "Sistema de apropriação de horas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 39);
            this.label1.TabIndex = 39;
            this.label1.Text = "Configurações do sistema";
            // 
            // TmrData
            // 
            this.TmrData.Interval = 1000;
            this.TmrData.Tick += new System.EventHandler(this.TmrData_Tick);
            // 
            // FrmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PctLogoAtc);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfiguracoes";
            this.Text = "FrmConfiguracoes";
            this.Load += new System.EventHandler(this.FrmConfiguracoes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogoAtc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox PctLogoAtc;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TabServCmdSair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TabServTxtApiKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TabServTxtPortaServidor;
        private System.Windows.Forms.Button TabServCmdSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TabServTxtEndServidor;
        private System.Windows.Forms.Button TabLeitorCmdSair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TabLeitorCmdSalvar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TabLeitorCmbBaudRate;
        private System.Windows.Forms.ComboBox TabLeitorCmbDataBits;
        private System.Windows.Forms.ComboBox TabLeitorCmbContFluxo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox TabLeitorCmbBitsParada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox TabLeitorCmbParidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TabLeitorCmbPorta;
        private System.Windows.Forms.Label TabServLblStatus;
        private System.Windows.Forms.Label TabLeitorLblStatus;
        private System.Windows.Forms.Button TabLeitorCmdTestCom;
        private System.Windows.Forms.Button TabServCmdTestCom;
        private System.Windows.Forms.Timer TmrData;
        private System.Windows.Forms.Button TabLeitorCmdAtualizarPortas;
    }
}