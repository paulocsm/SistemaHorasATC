﻿namespace SistemaATCTotem
{
    partial class FrmCadastroHoras
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
            this.CmdCancelar = new System.Windows.Forms.Button();
            this.CmdConfirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtGerente = new System.Windows.Forms.ComboBox();
            this.TxtDescricao = new System.Windows.Forms.ComboBox();
            this.TxtNumero = new System.Windows.Forms.ComboBox();
            this.TxtAno = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.TxtDataFim = new System.Windows.Forms.DateTimePicker();
            this.TxtHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.TxtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LblMatricula = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LblDepartamento = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LblFunção = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PctLogoAtc = new System.Windows.Forms.PictureBox();
            this.CmdConfiguracoes = new System.Windows.Forms.Button();
            this.TmrData = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogoAtc)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdCancelar
            // 
            this.CmdCancelar.BackColor = System.Drawing.Color.Gray;
            this.CmdCancelar.Font = new System.Drawing.Font("Calibri", 27.75F);
            this.CmdCancelar.ForeColor = System.Drawing.Color.White;
            this.CmdCancelar.Location = new System.Drawing.Point(709, 678);
            this.CmdCancelar.Name = "CmdCancelar";
            this.CmdCancelar.Size = new System.Drawing.Size(188, 72);
            this.CmdCancelar.TabIndex = 15;
            this.CmdCancelar.Text = "Cancelar";
            this.CmdCancelar.UseVisualStyleBackColor = false;
            this.CmdCancelar.Click += new System.EventHandler(this.CmdCancelar_Click);
            // 
            // CmdConfirmar
            // 
            this.CmdConfirmar.BackColor = System.Drawing.Color.Gray;
            this.CmdConfirmar.Font = new System.Drawing.Font("Calibri", 27.75F);
            this.CmdConfirmar.ForeColor = System.Drawing.Color.White;
            this.CmdConfirmar.Location = new System.Drawing.Point(463, 678);
            this.CmdConfirmar.Name = "CmdConfirmar";
            this.CmdConfirmar.Size = new System.Drawing.Size(188, 72);
            this.CmdConfirmar.TabIndex = 14;
            this.CmdConfirmar.Text = "Confirmar";
            this.CmdConfirmar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ano";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(301, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 39);
            this.label3.TabIndex = 19;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 39);
            this.label4.TabIndex = 21;
            this.label4.Text = "Gerente";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TxtGerente);
            this.panel1.Controls.Add(this.TxtDescricao);
            this.panel1.Controls.Add(this.TxtNumero);
            this.panel1.Controls.Add(this.TxtAno);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(17, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 200);
            this.panel1.TabIndex = 22;
            // 
            // TxtGerente
            // 
            this.TxtGerente.Font = new System.Drawing.Font("Calibri", 24F);
            this.TxtGerente.FormattingEnabled = true;
            this.TxtGerente.Location = new System.Drawing.Point(17, 134);
            this.TxtGerente.Name = "TxtGerente";
            this.TxtGerente.Size = new System.Drawing.Size(347, 47);
            this.TxtGerente.TabIndex = 25;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Font = new System.Drawing.Font("Calibri", 24F);
            this.TxtDescricao.FormattingEnabled = true;
            this.TxtDescricao.Location = new System.Drawing.Point(297, 49);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(1015, 47);
            this.TxtDescricao.TabIndex = 24;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("Calibri", 24F);
            this.TxtNumero.FormattingEnabled = true;
            this.TxtNumero.Location = new System.Drawing.Point(158, 49);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(127, 47);
            this.TxtNumero.TabIndex = 23;
            // 
            // TxtAno
            // 
            this.TxtAno.Font = new System.Drawing.Font("Calibri", 24F);
            this.TxtAno.FormattingEnabled = true;
            this.TxtAno.Location = new System.Drawing.Point(17, 49);
            this.TxtAno.Name = "TxtAno";
            this.TxtAno.Size = new System.Drawing.Size(127, 47);
            this.TxtAno.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 39);
            this.label5.TabIndex = 22;
            this.label5.Text = "Dados da Obra";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TxtHoraFim);
            this.panel2.Controls.Add(this.TxtDataFim);
            this.panel2.Controls.Add(this.TxtHoraInicio);
            this.panel2.Controls.Add(this.TxtDataInicio);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.LblHora);
            this.panel2.Controls.Add(this.label7);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(17, 504);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1330, 121);
            this.panel2.TabIndex = 23;
            // 
            // TxtHoraFim
            // 
            this.TxtHoraFim.Font = new System.Drawing.Font("Calibri", 24F);
            this.TxtHoraFim.Location = new System.Drawing.Point(1122, 51);
            this.TxtHoraFim.Mask = "00:00";
            this.TxtHoraFim.Name = "TxtHoraFim";
            this.TxtHoraFim.Size = new System.Drawing.Size(190, 47);
            this.TxtHoraFim.TabIndex = 22;
            this.TxtHoraFim.ValidatingType = typeof(System.DateTime);
            // 
            // TxtDataFim
            // 
            this.TxtDataFim.CalendarFont = new System.Drawing.Font("Calibri", 24F);
            this.TxtDataFim.Font = new System.Drawing.Font("Calibri", 24F);
            this.TxtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtDataFim.Location = new System.Drawing.Point(910, 51);
            this.TxtDataFim.Name = "TxtDataFim";
            this.TxtDataFim.Size = new System.Drawing.Size(190, 47);
            this.TxtDataFim.TabIndex = 21;
            this.TxtDataFim.Value = new System.DateTime(2018, 2, 6, 0, 0, 0, 0);
            // 
            // TxtHoraInicio
            // 
            this.TxtHoraInicio.Font = new System.Drawing.Font("Calibri", 24F);
            this.TxtHoraInicio.Location = new System.Drawing.Point(230, 51);
            this.TxtHoraInicio.Mask = "00:00";
            this.TxtHoraInicio.Name = "TxtHoraInicio";
            this.TxtHoraInicio.Size = new System.Drawing.Size(190, 47);
            this.TxtHoraInicio.TabIndex = 21;
            this.TxtHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // TxtDataInicio
            // 
            this.TxtDataInicio.CalendarFont = new System.Drawing.Font("Calibri", 24F);
            this.TxtDataInicio.Font = new System.Drawing.Font("Calibri", 24F);
            this.TxtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtDataInicio.Location = new System.Drawing.Point(17, 51);
            this.TxtDataInicio.Name = "TxtDataInicio";
            this.TxtDataInicio.Size = new System.Drawing.Size(190, 47);
            this.TxtDataInicio.TabIndex = 20;
            this.TxtDataInicio.Value = new System.DateTime(2018, 2, 6, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1157, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 39);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hora fim";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(912, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 39);
            this.label9.TabIndex = 17;
            this.label9.Text = "Data fim";
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.Color.White;
            this.LblHora.Location = new System.Drawing.Point(232, 9);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(155, 39);
            this.LblHora.TabIndex = 15;
            this.LblHora.Text = "Hora inicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data inicio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(29, 476);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 39);
            this.label10.TabIndex = 24;
            this.label10.Text = "Período";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(160, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(448, 39);
            this.label11.TabIndex = 25;
            this.label11.Text = "Sistema de apropriação de horas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(161, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 36);
            this.label12.TabIndex = 26;
            this.label12.Text = "Matricula:";
            // 
            // LblMatricula
            // 
            this.LblMatricula.AutoSize = true;
            this.LblMatricula.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMatricula.ForeColor = System.Drawing.Color.White;
            this.LblMatricula.Location = new System.Drawing.Point(304, 72);
            this.LblMatricula.Name = "LblMatricula";
            this.LblMatricula.Size = new System.Drawing.Size(129, 36);
            this.LblMatricula.TabIndex = 27;
            this.LblMatricula.Text = "Matricula";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.ForeColor = System.Drawing.Color.White;
            this.LblNome.Location = new System.Drawing.Point(261, 117);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(86, 36);
            this.LblNome.TabIndex = 29;
            this.LblNome.Text = "Nome";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(161, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 36);
            this.label15.TabIndex = 28;
            this.label15.Text = "Nome:";
            // 
            // LblDepartamento
            // 
            this.LblDepartamento.AutoSize = true;
            this.LblDepartamento.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepartamento.ForeColor = System.Drawing.Color.White;
            this.LblDepartamento.Location = new System.Drawing.Point(732, 72);
            this.LblDepartamento.Name = "LblDepartamento";
            this.LblDepartamento.Size = new System.Drawing.Size(187, 36);
            this.LblDepartamento.TabIndex = 31;
            this.LblDepartamento.Text = "Departamento";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(531, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(195, 36);
            this.label17.TabIndex = 30;
            this.label17.Text = "Departamento:";
            // 
            // LblFunção
            // 
            this.LblFunção.AutoSize = true;
            this.LblFunção.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFunção.ForeColor = System.Drawing.Color.White;
            this.LblFunção.Location = new System.Drawing.Point(644, 117);
            this.LblFunção.Name = "LblFunção";
            this.LblFunção.Size = new System.Drawing.Size(99, 36);
            this.LblFunção.TabIndex = 33;
            this.LblFunção.Text = "Função";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(531, 117);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 36);
            this.label19.TabIndex = 32;
            this.label19.Text = "Função:";
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.ForeColor = System.Drawing.Color.White;
            this.LblData.Location = new System.Drawing.Point(1021, 12);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(326, 39);
            this.LblData.TabIndex = 34;
            this.LblData.Text = "dd/mm/aa -- hh:mm:ss";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 24F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 24F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(975, 567);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 47);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2018, 2, 6, 0, 0, 0, 0);
            // 
            // PctLogoAtc
            // 
            this.PctLogoAtc.Image = global::SistemaATCTotem.Properties.Resources.atclogocinza;
            this.PctLogoAtc.Location = new System.Drawing.Point(13, 12);
            this.PctLogoAtc.Name = "PctLogoAtc";
            this.PctLogoAtc.Size = new System.Drawing.Size(141, 141);
            this.PctLogoAtc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctLogoAtc.TabIndex = 35;
            this.PctLogoAtc.TabStop = false;
            // 
            // CmdConfiguracoes
            // 
            this.CmdConfiguracoes.BackColor = System.Drawing.Color.Gray;
            this.CmdConfiguracoes.Font = new System.Drawing.Font("Calibri", 27.75F);
            this.CmdConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.CmdConfiguracoes.Location = new System.Drawing.Point(1100, 678);
            this.CmdConfiguracoes.Name = "CmdConfiguracoes";
            this.CmdConfiguracoes.Size = new System.Drawing.Size(247, 72);
            this.CmdConfiguracoes.TabIndex = 36;
            this.CmdConfiguracoes.Text = "Configurações";
            this.CmdConfiguracoes.UseVisualStyleBackColor = false;
            this.CmdConfiguracoes.Click += new System.EventHandler(this.CmdConfiguracoes_Click);
            // 
            // TmrData
            // 
            this.TmrData.Interval = 1000;
            this.TmrData.Tick += new System.EventHandler(this.TmrData_Tick);
            // 
            // FrmCadastroHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.CmdConfiguracoes);
            this.Controls.Add(this.PctLogoAtc);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.LblFunção);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.LblDepartamento);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.LblMatricula);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CmdCancelar);
            this.Controls.Add(this.CmdConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastroHoras";
            this.Text = "FrmCadastroHoras";
            this.Load += new System.EventHandler(this.FrmCadastroHoras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogoAtc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdCancelar;
        private System.Windows.Forms.Button CmdConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblMatricula;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label LblDepartamento;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label LblFunção;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.ComboBox TxtGerente;
        private System.Windows.Forms.ComboBox TxtDescricao;
        private System.Windows.Forms.ComboBox TxtNumero;
        private System.Windows.Forms.ComboBox TxtAno;
        private System.Windows.Forms.DateTimePicker TxtDataInicio;
        private System.Windows.Forms.DateTimePicker TxtDataFim;
        private System.Windows.Forms.MaskedTextBox TxtHoraInicio;
        private System.Windows.Forms.MaskedTextBox TxtHoraFim;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox PctLogoAtc;
        private System.Windows.Forms.Button CmdConfiguracoes;
        private System.Windows.Forms.Timer TmrData;
    }
}