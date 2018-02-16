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
        public Form frmbiometria { get; set; }

        public FrmLoguinMatricula()
        {
            InitializeComponent();
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            FrmCadastroHoras frmCadastroHoras = new FrmCadastroHoras();
            frmCadastroHoras.Show();
            this.Close();
        }

        private void CmdCancelar_Click(object sender, EventArgs e)
        {
            frmbiometria.Show();
            this.Close();
        }

        private void FrmLoguinMatricula_Load(object sender, EventArgs e)
        {

        }
    }
}
