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
    public partial class TecladoNumerico : Form
    {
        // Variáveis de Projeto
        public bool teveMudanca; // Indica se o usuário clicou em algum dos botões do teclado
        protected char digito;     // Valor do botão
        protected int quemMeChamou; // 1: TxtMatricula, 2: TxtSenha

        public TecladoNumerico()
        {
            InitializeComponent();
        }

        public void salvaQuemChamou(int aux)
        {
            this.quemMeChamou = aux;
        }

        //
        //
        // CONTINUAR A PARTIR DAQUI
        //
        //
        private void button1_Click(object sender, EventArgs e)
        {
            teveMudanca = true;
            digito = '1';
            switch (quemMeChamou)
            {
                case 1:
                    break;
                case 2:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teveMudanca = true;
            digito = '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teveMudanca = true;
            digito = '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            teveMudanca = true;
            digito = '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            teveMudanca = true;
            digito = '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            teveMudanca = true;
            digito = '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            teveMudanca = true;
            digito = '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            teveMudanca = true;
            digito = '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            teveMudanca = true;
            digito = '9';
        }

        private void button0_Click(object sender, EventArgs e)
        {
            teveMudanca = true;
            digito = '0';
        }
    }
}
