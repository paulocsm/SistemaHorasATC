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
        public static FrmLoguinMatricula frmLoguinMatricula;
        public static FrmCadastroHoras frmCadastroHoras;

        public FrmLoginBiometria()
        {
            InitializeComponent();
        }

        private void FrmLoginBiometria_Load(object sender, EventArgs e)
        {
            TecladoNumerico tecladoNumerico = new TecladoNumerico();
            tecladoNumerico.Show(this);
        }

        private void FrmLoginBiometria_Click(object sender, EventArgs e)
        {
            frmLoguinMatricula = new FrmLoguinMatricula();
            frmLoguinMatricula.frmbiometriamatricula = this;
            frmCadastroHoras = new FrmCadastroHoras();
            frmCadastroHoras.frmbiometriahoras = this;
            frmLoguinMatricula.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroHoras = new FrmCadastroHoras();
            frmCadastroHoras.frmbiometriahoras = this;
            frmCadastroHoras.Show();
            this.Hide();
        }
    }
}
