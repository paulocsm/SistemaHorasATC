using System;
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
    public partial class FrmLoguinMatricula : Form
    {
        public Form frmbiometriamatricula { get; set; }

        public FrmLoguinMatricula()
        {
            InitializeComponent();
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            if(TxtMatricula.Text == "")
            {
                LblStatus.Text = "Informe a matricula";
                LblStatus.ForeColor = Color.Red;
                TxtMatricula.Focus();
                return;
            }
            int matricula;
            if (!int.TryParse(TxtMatricula.Text, out matricula) == true)
            {
                LblStatus.Text = "A matricula deve conter um valor numérico";
                LblStatus.ForeColor = Color.Red;
                TxtMatricula.Focus();
                return;
            }
            if (TxtSenha.Text == "")
            {
                LblStatus.Text = "Informe a senha";
                LblStatus.ForeColor = Color.Red;
                TxtSenha.Focus();
                return;
            }

            logar("", Convert.ToInt32(TxtMatricula.Text), 0, TxtSenha.Text, "Totem","");
            LblStatus.Text = "Verificando dados no serividor";
            LblStatus.ForeColor = Color.Black;
        }

        private async void logar(string Usuario, int Matricula, int IndiceBiometria, string Senha, string Origem, string Key)
        {
            API.respostaLogin = await API.Login(Usuario, Matricula, IndiceBiometria, Senha, Origem, Key);
            if (API.respostaLogin != null)
            {
                if (API.respostaLogin.Erro != "Sucesso!")
                {
                    LblStatus.Text = API.respostaLogin.Erro;
                    LblStatus.ForeColor = Color.Red;
                }
                else
                {
                    FrmLoginBiometria.frmCadastroHoras.Show();
                    this.Close();
                }
            }
        }

        private void CmdCancelar_Click(object sender, EventArgs e)
        {
            frmbiometriamatricula.Show();
            FrmLoginBiometria.frmCadastroHoras.Close();
            this.Close();
        }

        private void FrmLoguinMatricula_Load(object sender, EventArgs e)
        {

        }
    }
}
