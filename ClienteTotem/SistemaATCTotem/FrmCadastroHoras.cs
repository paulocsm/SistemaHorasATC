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
        List<LancamentoDeHoras> lancamentoDeHoras = new List<LancamentoDeHoras>(); // Lista dos lnçamentos de horas anteriores
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

        private void CmdConfiguracoes_Click(object sender, EventArgs e) // Abre a tela de configurações quando clica no botão
        {
            FrmConfiguracoes frmConfiguracoes = new FrmConfiguracoes();
            frmConfiguracoes.Show(this);
        }

        private void CmdCancelar_Click(object sender, EventArgs e) // Desloga quando clica em cancelar
        {
            Logout("Totem", "", "", 0, API.respostaLogin.Matricula);
        }

        private void TmrData_Tick(object sender, EventArgs e)
        {
            //Atualiza a label de data e hora
            LblData.Text = DateTime.Now.ToShortDateString() + " -- " + DateTime.Now.ToLongTimeString();
        }

        private async void AtualizaTela()
        {
            AuxAtualizaTela = true;

            // Atualiza os labels do cabeçalho (Matrícula, Nome, Deartamento e Função):
            LblMatricula.Text = API.respostaLogin.Matricula.ToString();
            LblNome.Text = API.respostaLogin.Nome;
            LblDepartamento.Text = API.respostaLogin.Departamento;
            LblFunção.Text = API.respostaLogin.Funcao;

            // Atualiza os campos de data e hora inicial e final:
            TxtDataInicio.Text = DateTime.Now.Date.ToLongDateString();
            TxtHoraInicio.Text = "07:30";
            TxtDataFim.Text = DateTime.Now.Date.ToLongDateString();
            TxtHoraFim.Text = DateTime.Now.TimeOfDay.Hours.ToString() + ":" + DateTime.Now.TimeOfDay.Minutes.ToString();
            
            ultimoRegistro = await API.BuscaUltimoRegistro("asdf", API.respostaLogin.Matricula);

            //Atualiza o combobox de gerentes
            TxtGerente.Items.Clear();
            int selected = 0;
            for(int i=0; i < ultimoRegistro.gerentes.Length; i++)
            {
                TxtGerente.Items.Add(ultimoRegistro.gerentes[i].Nome); // Adiciona os gerentes na lista do combobox
                if (ultimoRegistro.matriculaUltimoGerente == ultimoRegistro.gerentes[i].Matricula) // Pega o índice do último gerente
                {
                    selected = i;
                }
            }
            TxtGerente.SelectedIndex = selected; // Seleciona no combobox o último gerente

            //Atualiza o combobox de atividades
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

            //Atualiza o combobox de ano
            selected = 0;
            TxtAno.Items.Clear();
            contador = 0;
            for (int i = 0; i < ultimoRegistro.obras.Length; i++)
            {
                if (TxtAno.Items.Contains(ultimoRegistro.obras[i].Ano) == false)
                {
                    TxtAno.Items.Add(ultimoRegistro.obras[i].Ano);
                    if (ultimoRegistro.obras[i].Ano == ultimoRegistro.anoUltimaObra)
                    {
                        selected = contador;
                    }
                    contador++;
                }            
            }
            TxtAno.SelectedIndex = selected;

            //Atualiza o combobox de Codigo
            selected = 0;
            TxtNumero.Items.Clear();
            contador = 0;
            for (int i = 0; i < ultimoRegistro.obras.Length; i++)
            {
                if (ultimoRegistro.obras[i].Ano == ultimoRegistro.anoUltimaObra)
                {
                    TxtNumero.Items.Add(ultimoRegistro.obras[i].Codigo.ToString().PadLeft(3, '0')); ;
                    if (ultimoRegistro.obras[i].Codigo == ultimoRegistro.codUltimaObra)
                    {
                        selected = contador;
                    }
                    contador++;
                }
            }
            TxtNumero.SelectedIndex = selected;

            AtualizaDataGridView(); // Atualiza o data grid

            //Atualiza o combobox de Descrição
            selected = 0;
            TxtDescricao.Items.Clear();
            contador = 0;
            for (int i = 0; i < ultimoRegistro.obras.Length; i++)
            {
                if ((ultimoRegistro.obras[i].Ano == ultimoRegistro.anoUltimaObra) & (ultimoRegistro.obras[i].Codigo == ultimoRegistro.codUltimaObra))
                {
                    TxtDescricao.Items.Add(ultimoRegistro.obras[i].Nome);
                    selected = 0;
                }
            }
            TxtDescricao.SelectedIndex = selected;
            AuxAtualizaTela = false;
        }

        private async void Logout(string Origem, string ApiKey, string Usuario, int IndiceBiometria, int Matricula)
        {
            await API.Logout(Origem, ApiKey, Usuario, IndiceBiometria, Matricula);
            frmbiometriahoras.Show();
            this.Close();
        }

        private void TxtAno_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if (AuxAtualizaTela == false)
            {
                AuxAtualizaTela = true;
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
                AuxAtualizaTela = false;
            }
        }

        private void TxtNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AuxAtualizaTela == false)
            {
                AuxAtualizaTela = true;
                TxtDescricao.Items.Clear();
                TxtDescricao.Text = "";
                int Selected = 0;               

                for (int i = 0; i < ultimoRegistro.obras.Length; i++)
                {
                    if (Convert.ToInt32(TxtNumero.Text) == ultimoRegistro.obras[i].Codigo & Convert.ToInt32(TxtAno.Text) == ultimoRegistro.obras[i].Ano)
                    {
                        TxtDescricao.Items.Add(ultimoRegistro.obras[i].Nome);
                        Selected = 0;
                    }
                }
                TxtDescricao.SelectedIndex = Selected;
                AuxAtualizaTela = false;
            }
        }

        private void TxtDescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AuxAtualizaTela == false & TxtDescricao.Items.Count > 1)
            {
                AuxAtualizaTela = true;
                int Selected = TxtDescricao.SelectedIndex;             
                TxtNumero.SelectedIndex = Selected;
                AuxAtualizaTela = false;
            }
        }

        private void AtualizaDataGridView()
        {
            // Percorre a lista de lançamento de obras, adicionando seus itens no Grid View
            for (int c = 0; c < lancamentoDeHoras.Count; c++)
            {
                this.DG.Rows.Insert(c, lancamentoDeHoras[c].obra.Codigo, lancamentoDeHoras[c].gerente.Nome,
                                    lancamentoDeHoras[c].atividade.Descricao, lancamentoDeHoras[c].dataInicio,
                                    lancamentoDeHoras[c].horaInicio, lancamentoDeHoras[c].dataFim,
                                    lancamentoDeHoras[c].horaFim);
            }
        }

        // Aparece mensagem em um balão ao passar o mouse sobre itens do formulário
        #region MouseHover
        private void TxtAno_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.InitialDelay = 500;
            tt.ShowAlways = true;
            tt.SetToolTip(TxtAno, "Selecione o ano da obra");
        }

        private void TxtNumero_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.InitialDelay = 500;
            tt.ShowAlways = true;
            tt.SetToolTip(TxtNumero, "Selecione o número da obra");
        }

        private void TxtDescricao_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.InitialDelay = 500;
            tt.ShowAlways = true;
            tt.SetToolTip(TxtDescricao, "Selecione a descrição da obra");
        }

        private void TxtGerente_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.InitialDelay = 500;
            tt.ShowAlways = true;
            tt.SetToolTip(TxtGerente, "Selecione o gerente responsável pela obra");
        }

        private void TxtAtividade_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.InitialDelay = 500;
            tt.ShowAlways = true;
            tt.SetToolTip(TxtAtividade, "Selecione a atividade que deseja adicionar");
        }
        #endregion
    }
}
