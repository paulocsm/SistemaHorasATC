﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaATCTotem
{
    public partial class FrmCadastroHoras : Form
    {
        public Form frmbiometriahoras { get; set; }

        public FrmCadastroHoras()
        {
            InitializeComponent();
        }

        private void FrmCadastroHoras_Load(object sender, EventArgs e)
        {
            //Atualiza a label de data e hora
            LblData.Text = DateTime.Now.ToShortDateString() + " -- " + DateTime.Now.ToLongTimeString();
            TmrData.Start();
        }

        private void CmdConfiguracoes_Click(object sender, EventArgs e)
        {
            FrmConfiguracoes frmConfiguracoes = new FrmConfiguracoes();
            frmConfiguracoes.Show(this);
        }

        private void CmdCancelar_Click(object sender, EventArgs e)
        {
            frmbiometriahoras.Show();
            this.Close();
        }

        private void TmrData_Tick(object sender, EventArgs e)
        {
            //Atualiza a label de data e hora
            LblData.Text = DateTime.Now.ToShortDateString() + " -- " + DateTime.Now.ToLongTimeString();
        }
    }
}
