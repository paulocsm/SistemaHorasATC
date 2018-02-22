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
    public partial class FrmCadastroHoras : Form
    {
        public Form frmbiometriahoras { get; set; }
        UltimoRegistro ultimoRegistro = new UltimoRegistro();
        bool AuxAtualizaTela;

        public FrmCadastroHoras()
        {
            InitializeComponent();
        }

        private void FrmCadastroHoras_Load(object sender, EventArgs e)
        {
            //Atualiza a label de data e hora
            LblData.Text = DateTime.Now.ToShortDateString() + " -- " + DateTime.Now.ToLongTimeString();
            TmrData.Start();
            AtualizaTela();
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

        private async void AtualizaTela()
        {
            AuxAtualizaTela = true;

            LblMatricula.Text = API.respostaLogin.Matricula.ToString();
            LblNome.Text = API.respostaLogin.Nome;
            LblDepartamento.Text = API.respostaLogin.Departamento;
            LblFunção.Text = API.respostaLogin.Funcao;

            TxtDataInicio.Text = DateTime.Now.Date.ToLongDateString();
            TxtHoraInicio.Text = "07:30";
            TxtDataFim.Text = DateTime.Now.Date.ToLongDateString();
            TxtHoraFim.Text = DateTime.Now.TimeOfDay.Hours.ToString() + ":" + DateTime.Now.TimeOfDay.Minutes.ToString();
            
            ultimoRegistro = await API.BuscaUltimoRegistro("asdf", API.respostaLogin.Matricula);

            TxtGerente.Items.Clear();
            int selected = 0;
            for(int i=0; i < ultimoRegistro.gerentes.Length; i++)
            {
                TxtGerente.Items.Add(ultimoRegistro.gerentes[i].Nome);
                if (ultimoRegistro.matriculaUltimoGerente == ultimoRegistro.gerentes[i].Matricula)
                {
                    selected = i;
                }
            }
            TxtGerente.SelectedIndex = selected;

            selected = 0;
            TxtAno.Items.Clear();
            TxtNumero.Items.Clear();
            TxtDescricao.Items.Clear();
            for (int i = 0; i < ultimoRegistro.obras.Length; i++)
            {
                TxtAno.Items.Add(ultimoRegistro.obras[i].Ano);
                TxtNumero.Items.Add(ultimoRegistro.obras[i].Codigo.ToString().PadLeft(3,'0'));
                TxtDescricao.Items.Add(ultimoRegistro.obras[i].Nome);
                if (ultimoRegistro.anoUltimaObra == ultimoRegistro.obras[i].Ano & ultimoRegistro.codUltimaObra == ultimoRegistro.obras[i].Codigo)
                {
                    selected = i;
                }
            }
            TxtAno.SelectedIndex = selected;
            TxtNumero.SelectedIndex = selected;
            TxtDescricao.SelectedIndex = selected;

            TxtAtividade.Items.Clear();
            selected = 0;
            int contador = 0;
            for (int i = 0; i < ultimoRegistro.atividades.Length; i++)
            {

                if (ultimoRegistro.atividades[i].FuncoesCapacitadas.Contains(API.respostaLogin.Funcao))
                {
                    TxtAtividade.Items.Add(ultimoRegistro.atividades[i].Descricao);
                    if (ultimoRegistro.ultimaAtividade == ultimoRegistro.atividades[i].Descricao)
                    {
                        selected = contador;
                    }
                    contador++;
                }
            }
            TxtAtividade.SelectedIndex = selected;
            AuxAtualizaTela = false;
        }

        private void TxtAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AuxAtualizaTela == false)
            {
                TxtNumero.Items.Clear();
                TxtNumero.Text = "";
                TxtDescricao.Items.Clear();
                TxtDescricao.Text = "";
                
                for (int i = 0; i < ultimoRegistro.obras.Length; i++)
                {
                    if (Convert.ToInt32(TxtAno.Text) == ultimoRegistro.obras[i].Ano)
                    {
                        TxtNumero.Items.Add(ultimoRegistro.obras[i].Codigo.ToString().PadLeft(3, '0'));
                        TxtDescricao.Items.Add(ultimoRegistro.obras[i].Nome);
                    }
                }
            }
        }
    }
}
