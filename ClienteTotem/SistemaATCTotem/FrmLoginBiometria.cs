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
        public FrmLoginBiometria()
        {
            InitializeComponent();
        }

        private void FrmLoginBiometria_Load(object sender, EventArgs e)
        {

        }

        private void FrmLoginBiometria_Click(object sender, EventArgs e)
        {
            FrmLoguinMatricula frmLoguinMatricula = new FrmLoguinMatricula();
            frmLoguinMatricula.frmbiometria = this;
            frmLoguinMatricula.Show();
            this.Hide();
        }
    }
}
