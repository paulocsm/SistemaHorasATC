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
        public Form frmbiometriamatricula { get; set; } // Variável usada para receber os parametros de FormLoginBiometria

        // Inicializa a tela
        public FrmLoguinMatricula()
        {
            InitializeComponent();
        }

        // Método sensível ao clique no botão "Acessar"
        private void CmdLogin_Click(object sender, EventArgs e)
        {
            // Testa se usuario entrou com valor nulo no campo de matricula
            if (TxtMatricula.Text == "")
            {
                LblStatus.Text = "Informe a matricula";
                LblStatus.ForeColor = Color.Red;
                TxtMatricula.Focus();
                return;
            }
            int matricula;

            // Testa se usuario entrou com valor numerico valido no campo de matricula
            if (!int.TryParse(TxtMatricula.Text, out matricula) == true)
            {
                LblStatus.Text = "A matricula deve conter um valor numérico";
                LblStatus.ForeColor = Color.Red;
                TxtMatricula.Focus();
                return;
            }
            // Testa se usuario entrou com valor nulo no campo de senha
            if (TxtSenha.Text == "")
            {
                LblStatus.Text = "Informe a senha";
                LblStatus.ForeColor = Color.Red;
                TxtSenha.Focus();
                return;
            }

            // Usa o login e senha entrado pelo usuario para fazer login
            logar("", Convert.ToInt32(TxtMatricula.Text), 0, TxtSenha.Text, "Totem","");
            // Informa o usuario da verificacao no servidor
            LblStatus.Text = "Verificando dados no serividor";
            LblStatus.ForeColor = Color.Black;
        }


        /* logar(nomeUsario, numeroMatricula, indiceBiometria, senha, identificadorDeOrigem, chave)
         * Funcao responsavel por pegar os dados do cliente e requisitar login para o servidor, alem de conferir e tratar se houve erro
         * Saida -> ---//---
         */
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

        // Faz login quando usuário aperta enter
        #region SensibilidadeAoEnter
        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CmdLogin_Click(sender, e);
            }
        }

        private void TxtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CmdLogin_Click(sender, e);
            }
        }

        private void FrmLoguinMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CmdLogin_Click(sender, e);
            }
        }
        #endregion
    }
}
