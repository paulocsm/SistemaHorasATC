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
    public partial class FrmLoginBiometria : Form
    {
        public static FrmLoguinMatricula frmLoguinMatricula; // Form da tela de login por matrícula
        public static FrmCadastroHoras frmCadastroHoras;     // Form da tela de cadastro de horas

        public FrmLoginBiometria()
        {
            InitializeComponent();
        }

        //Abre tela de login ao clicar por cima da tela
        private void FrmLoginBiometria_Click(object sender, EventArgs e)
        {
            frmLoguinMatricula = new FrmLoguinMatricula();
            frmLoguinMatricula.frmbiometriamatricula = this; // Passa as informações desse formulário para o formulário de login por matrícula instanciado acima
            frmCadastroHoras = new FrmCadastroHoras();
            frmCadastroHoras.frmbiometriahoras = this; // Passa as informações desse formulário para o formulário de login por matrícula instanciado acima
            frmLoguinMatricula.Show();
            this.Hide();
        }

        //Abre tela de login ao clicar por cima da imagem
        private void PctLogoAtc_Click(object sender, EventArgs e)
        {
            frmLoguinMatricula = new FrmLoguinMatricula();
            frmLoguinMatricula.frmbiometriamatricula = this; // Passa as informações desse formulário para o formulário de login por matrícula instanciado acima
            frmCadastroHoras = new FrmCadastroHoras();
            frmCadastroHoras.frmbiometriahoras = this; // Passa as informações desse formulário para o formulário de login por matrícula instanciado acima
            frmLoguinMatricula.Show();
            this.Hide();
        }

        // Aparece balão informando o usuário para clicar na tela e fazer login por matrícula

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLoginBiometria_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this, "Clique na tela para fazer login por matrícula");
        }
    }
}
