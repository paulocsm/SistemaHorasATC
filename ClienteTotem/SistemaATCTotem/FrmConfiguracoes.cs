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
            LblData.Text = DateTime.Now.ToShortDateString() + " -- " + DateTime.Now.ToLongTimeString();
        }

        private void FrmConfiguracoes_Load(object sender, EventArgs e)
        {
            TmrData.Start();
            AtualizaCampos();
            //Atualiza a label de data e hora
            LblData.Text = DateTime.Now.ToShortDateString() + " -- " + DateTime.Now.ToLongTimeString();
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
            TabServTxtApiKey.Text = Properties.Settings.Default.ApiKey;
            TabServTxtEndServidor.Text = Properties.Settings.Default.EndServidor;
            TabServTxtPortaServidor.Text = Properties.Settings.Default.PortaServidor.ToString();
        }

        private void TabLeitorCmdSalvar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BaudRateLeitor = TabLeitorCmbBaudRate.Text;
            Properties.Settings.Default.BitsParada = TabLeitorCmbBitsParada.Text;
            Properties.Settings.Default.ControleFluxo = TabLeitorCmbContFluxo.Text;
            Properties.Settings.Default.DataBitsLeitor = TabLeitorCmbDataBits.Text;
            Properties.Settings.Default.ParidadeLeitor = TabLeitorCmbParidade.Text;
            Properties.Settings.Default.PortaComLeitor = TabLeitorCmbPorta.Text;
            Properties.Settings.Default.Save();
            TabLeitorLblStatus.Text = "Dados Salvos com Sucesso!";
            TabLeitorLblStatus.ForeColor = Color.Green;
        }

        private void TabLeitorCmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabLeitorLblStatus.Text = "Parametros de comunicação com o leitor biométrico";
            TabLeitorLblStatus.ForeColor = Color.White;
            TabServLblStatus.Text = "Parametros de acesso ao servidor";
            TabServLblStatus.ForeColor = Color.White;
        }

        private void TabServCmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TabServCmdSalvar_Click(object sender, EventArgs e)
        {   
            //validação do endereço do servidor
            if(TabServTxtEndServidor.Text == "")
            {
                TabServLblStatus.Text = "O Endereço do servidor deve ser informado!";
                TabServLblStatus.ForeColor = Color.Red;
                TabServTxtEndServidor.BackColor = Color.Red;
                TabServTxtEndServidor.Focus();
                return;
            }
            //validação da porta do servidor
            //Verifica se a a porta é vazia
            if (TabServTxtPortaServidor.Text == "")
            {
                TabServLblStatus.Text = "A porta de comunicação deve ser informada!";
                TabServLblStatus.ForeColor = Color.Red;
                TabServTxtPortaServidor.BackColor = Color.Red;
                TabServTxtPortaServidor.Focus();
                return;
            }
            //Verifica se o valor da porta é numerico
            int porta;
            if (!int.TryParse(TabServTxtPortaServidor.Text, out porta) == true)
            {
                TabServLblStatus.Text = "A porta de comunicação deve ser um valor numérico!";
                TabServLblStatus.ForeColor = Color.Red;
                TabServTxtPortaServidor.BackColor = Color.Red;
                TabServTxtPortaServidor.Focus();
                return;
            }
            //verifica se o valor da porta está dentro de um range valido
            porta = Convert.ToInt32(TabServTxtPortaServidor.Text);
            if (porta < 30 || porta > 65535)
            {
                TabServLblStatus.Text = "A porta de comunicação deve estar entre 30 e 65535!";
                TabServLblStatus.ForeColor = Color.Red;
                TabServTxtPortaServidor.BackColor = Color.Red;
                TabServTxtPortaServidor.Focus();
                return;
            }
            //Validação o APIKEY
            if (TabServTxtApiKey.Text == "")
            {
                TabServLblStatus.Text = "A API Key deve ser informada!";
                TabServLblStatus.ForeColor = Color.Red;
                TabServTxtApiKey.BackColor = Color.Red;
                TabServTxtApiKey.Focus();
                return;
            }
            //Verifica o tamanho da APIKEY
            if (TabServTxtApiKey.TextLength != 30)
            {
                TabServLblStatus.Text = "A API Key deve conter 30 caracteres!";
                TabServLblStatus.ForeColor = Color.Red;
                TabServTxtApiKey.BackColor = Color.Red;
                TabServTxtApiKey.Focus();
                return;
            }

            Properties.Settings.Default.EndServidor = TabServTxtEndServidor.Text;
            Properties.Settings.Default.PortaServidor = Convert.ToInt32(TabServTxtPortaServidor.Text);
            Properties.Settings.Default.ApiKey = TabServTxtApiKey.Text;
            Properties.Settings.Default.Save();
            TabServLblStatus.Text = "Dados Salvos com Sucesso!";
            TabServLblStatus.ForeColor = Color.Green;
        }

        private void TabServTxtEndServidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            TabServTxtEndServidor.BackColor = Color.White;
            TabServLblStatus.Text = "Parametros de acesso ao servidor";
            TabServLblStatus.ForeColor = Color.White;
        }

        private void TabServTxtPortaServidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            TabServTxtPortaServidor.BackColor = Color.White;
            TabServLblStatus.Text = "Parametros de acesso ao servidor";
            TabServLblStatus.ForeColor = Color.White;
        }

        private void TabServTxtApiKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            TabServTxtApiKey.BackColor = Color.White;
            TabServLblStatus.Text = "Parametros de acesso ao servidor";
            TabServLblStatus.ForeColor = Color.White;
        }

        private void TabServCmdTestCom_Click(object sender, EventArgs e)
        {
            TesteComServidor();
        }

        private async void TesteComServidor()
        {
            string Resultado;
            string Url = "http://" + TabServTxtEndServidor.Text + ":" + TabServTxtPortaServidor.Text + "/API/Teste?ApiKey=" + TabServTxtApiKey.Text + "&Origem=Totem";
            Resultado = await API.TesteComServidor(Url);

            switch (Resultado)
            {
                case "Sucesso!":
                    {
                        TabServLblStatus.Text = "Teste de comunicação efetuado com sucesso, o servidor está OK";
                        TabServLblStatus.ForeColor = Color.Green;
                    }
                    break;
                case "ApiKey Inexistente":
                    {
                        TabServLblStatus.Text = "Teste de comunicação efetuado, ApiKey Incorreta";
                        TabServLblStatus.ForeColor = Color.Red;
                    }
                    break;
                default:
                    {
                        TabServLblStatus.Text = "Não foi possivel se comunicar com o servidor, verifique as configurações";
                        TabServLblStatus.ForeColor = Color.Red;
                    }
                    break;
            }

        }
    }
}
