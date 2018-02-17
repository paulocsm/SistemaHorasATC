using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SistemaATCTotem
{
    public partial class FrmConfiguracoes : Form
    {
        public FrmConfiguracoes()
        {
            InitializeComponent();
        }

        private void TmrData_Tick(object sender, EventArgs e)
        {
            //Atualiza a label de data e hora
            LblData.Text = DateTime.Now.ToShortDateString() + " -- " + DateTime.Now.ToShortTimeString();
        }

        private void FrmConfiguracoes_Load(object sender, EventArgs e)
        {
            TmrData.Start();
            AtualizaCampos();
        }

        private void PreencheCmbPortas()
        {
            TabLeitorCmbPorta.Items.Clear();

            string[] portas = SerialPort.GetPortNames();
            TabLeitorCmbPorta.Items.AddRange(portas);
            bool ExistePorta = false;

            foreach(string porta in portas)
            {
                if (porta == Properties.Settings.Default.PortaComLeitor)
                    ExistePorta = true;
            }

            if (ExistePorta == true)
            {
                TabLeitorCmbPorta.Text = Properties.Settings.Default.PortaComLeitor;
                TabLeitorCmbPorta.BackColor = Color.White;
            }
            else
            {
                TabLeitorCmbPorta.Text = Properties.Settings.Default.PortaComLeitor;
                TabLeitorCmbPorta.BackColor = Color.Red;
            }
        }

        private void TabLeitorCmdAtualizarPortas_Click(object sender, EventArgs e)
        {
            PreencheCmbPortas();
        }

        private void TabLeitorCmbPorta_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabLeitorCmbPorta.BackColor = Color.White;
        }

        private void AtualizaCampos()
        {
            PreencheCmbPortas();
            TabLeitorCmbBaudRate.Text = Properties.Settings.Default.BaudRateLeitor;
            TabLeitorCmbBitsParada.Text = Properties.Settings.Default.BitsParada;
            TabLeitorCmbContFluxo.Text = Properties.Settings.Default.ControleFluxo;
            TabLeitorCmbDataBits.Text = Properties.Settings.Default.DataBitsLeitor;
            TabLeitorCmbParidade.Text = Properties.Settings.Default.ParidadeLeitor;         
        }

        private void TabLeitorCmdSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
