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
        DataTable lancamentoDeHoras = new DataTable(); // Tabela de dados dos lançamentos de horas anteriores
        bool AuxAtualizaTela;

        public FrmCadastroHoras()
        {
            InitializeComponent();
        }

        private void FrmCadastroHoras_Load(object sender, EventArgs e)
        {
            //Atualiza a label de data e hora
            LblData.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
            TmrData.Start();
            AtualizaTela();
            // Cria tabela de dados de atividade
            lancamentoDeHoras.Columns.Add("CodObra", typeof(string));
            lancamentoDeHoras.Columns.Add("GerenteResponsavel", typeof(string));
            lancamentoDeHoras.Columns.Add("AtividadeDesenvolvida", typeof(string));
            lancamentoDeHoras.Columns.Add("DataInicio", typeof(string));
            lancamentoDeHoras.Columns.Add("HoraInicio", typeof(string));
            lancamentoDeHoras.Columns.Add("DataFim", typeof(string));
            lancamentoDeHoras.Columns.Add("HoraFim", typeof(string));
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
            LblData.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
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
            TxtDataInicio.Text = DateTime.Now.ToString();
            TxtHoraInicio.Text = DateTime.Now.TimeOfDay.ToString();
            TxtDataFim.Text    = DateTime.Now.Date.ToLongDateString();
            TxtHoraFim.Text    = DateTime.Now.TimeOfDay.ToString();

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
            this.DG.Rows.Insert(lancamentoDeHoras.Rows.Count - 1,
                                lancamentoDeHoras.Rows[lancamentoDeHoras.Rows.Count - 1][0],
                                lancamentoDeHoras.Rows[lancamentoDeHoras.Rows.Count - 1][1],
                                lancamentoDeHoras.Rows[lancamentoDeHoras.Rows.Count - 1][2],
                                lancamentoDeHoras.Rows[lancamentoDeHoras.Rows.Count - 1][3],
                                lancamentoDeHoras.Rows[lancamentoDeHoras.Rows.Count - 1][4],
                                lancamentoDeHoras.Rows[lancamentoDeHoras.Rows.Count - 1][5],
                                lancamentoDeHoras.Rows[lancamentoDeHoras.Rows.Count - 1][6]);
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

        // Pega as informações colocadas pelo usuário no formulário, salva na tabela e mostra no DataGrid
        private void CmdAdicionarAtividade_Click(object sender, EventArgs e)
        {
            // Preenche a tabela de dados da atividade:
            DataRow linha = lancamentoDeHoras.NewRow(); // Cria nova linha para a data table

            // Pega apenas a data dos campos dataInicio e dataFim
            var dataInicio = TxtDataInicio.Text;
            var dataFim    = TxtDataFim.Text;

            // Pega todas as informações selecionadas pelo usuário no formulário
            linha["CodObra"]               = TxtAno.Text + '-' + TxtNumero.Text.PadLeft(3, '0');
            linha["GerenteResponsavel"]    = TxtGerente.Text;
            linha["AtividadeDesenvolvida"] = TxtAtividade.Text;
            linha["DataInicio"]            = dataInicio.ToString();
            linha["HoraInicio"]            = TxtHoraInicio.Text;
            linha["DataFim"]               = dataFim.ToString();
            linha["HoraFim"]               = TxtHoraFim.Text;

            lancamentoDeHoras.Rows.Add(linha); // Adiciona as informações na tabela

            AtualizaDataGridView(); // Atualiza o data grid na tela
        }

        // Remove uma atividade selecionada no data grid view
        private void CmdRemoverAtividade_Click(object sender, EventArgs e)
        {
            if (DG.SelectedRows.Count <= 0) // Mostra mensagem de erro se o usuário não selecionar nenhuma linha
                MessageBox.Show("Selecione a atividade que deseja remover.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (DG.Rows.Count > 1) // Impede que remova mais linhas que o possível
                {
                    DG.Rows.RemoveAt(DG.CurrentCell.RowIndex);                // Remove a atividade do data grid
                    lancamentoDeHoras.Rows.RemoveAt(DG.CurrentCell.RowIndex); // Remove a atividade do data table
                }
            }
        }
    }
}
