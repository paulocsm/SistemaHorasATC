using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using System.Data;

namespace API___ATC_Horas.Funcionamento
{
    public class ApropriacaoHoras
    {
        public static Horas[] BuscarHoras()
        {
             Horas[] retorno = new Horas[] { };

            return retorno;
        }

        public static string CadastrarHoras()
        {
            string retorno = "";

            return retorno;
        }

        public static string AlterarHoras()
        {
            string retorno = "";

            return retorno;
        }

        public static UltimoRegistro BuscaUltimoRegistro(int Matricula)
        {
            UltimoRegistro ultimoRegistro = new UltimoRegistro();

            if (Database.CN.State == ConnectionState.Closed)
            {
                Database.StringConexao = @"Data Source = C:\Program Files\Autentica Softwares\ATCHoras\Dados\Dados.db" + ";Version=3";
                Database.CN.ConnectionString = Database.StringConexao;
                Database.CN.Open();
            }

            string Comando;
            SQLiteCommand CMD = new SQLiteCommand();
            DataTable DT = new DataTable();
            SQLiteDataAdapter DA = new SQLiteDataAdapter();
            DataRow DR;

            Comando = "Select * from Obras";

            try
            {
                CMD.CommandText = Comando;
                CMD.Connection = Database.CN;
                DA.SelectCommand = CMD;
                DA.Fill(DT);
            }
            catch
            {
                ultimoRegistro.Erro = "Erro de servidor, Falha ao Consultar o banco de dados";
                return ultimoRegistro;
            }

            ultimoRegistro.obras = new Obras[DT.Rows.Count];

            if (DT.Rows.Count != 0)
            for (int i = 0; i < (DT.Rows.Count); i++)
            {
                Obras obras = new Obras();
                DR = DT.Rows[i];
                obras.Ano = Convert.ToInt32(DR[0]);
                obras.Codigo = Convert.ToInt32(DR[1]);
                obras.Nome = DR[2].ToString();
                obras.Descricao = DR[3].ToString();
                obras.MatriculaGerente = Convert.ToInt32(DR[4]);
                obras.Descricao = DR[5].ToString();
                ultimoRegistro.obras[i] = obras;
            }

            DA.Dispose();
            DT.Dispose();
            CMD.Dispose();

            DA = new SQLiteDataAdapter();
            DT = new DataTable();
            CMD = new SQLiteCommand();

            Comando = "Select * from Funcionarios where NivelAcesso = 5";

            try
            {
                CMD.CommandText = Comando;
                CMD.Connection = Database.CN;
                DA.SelectCommand = CMD;
                DA.Fill(DT);
            }
            catch(Exception e)
            {
                ultimoRegistro.Erro = "Erro de servidor, Falha ao Consultar o banco de dados";
                return ultimoRegistro;
            }

            ultimoRegistro.gerentes = new Funcionario[DT.Rows.Count];

            if (DT.Rows.Count != 0)
                for (int i = 0; i < (DT.Rows.Count); i++)
                {
                    Funcionario funcionario = new Funcionario();
                    DR = DT.Rows[i];
                    funcionario.Nome = DR[0].ToString();
                    funcionario.Usuario = DR[1].ToString();
                    funcionario.Matricula = Convert.ToInt32(DR[2]);
                    funcionario.Departamento = DR[3].ToString();
                    funcionario.Funcao = DR[4].ToString();
                    funcionario.Senha = DR[5].ToString();
                    funcionario.IndiceBiometria = Convert.ToInt32(DR[6]);
                    funcionario.NivelAcesso = Convert.ToInt32(DR[7]);
                    funcionario.Status = DR[8].ToString();
                    funcionario.Email = DR[9].ToString();
                    funcionario.Telefone = DR[10].ToString();
                    ultimoRegistro.gerentes[i] = funcionario;
                }

            DA.Dispose();
            DT.Dispose();
            CMD.Dispose();

            DA = new SQLiteDataAdapter();
            DT = new DataTable();
            CMD = new SQLiteCommand();

            Comando = "Select * from Atividades";

            try
            {
                CMD.CommandText = Comando;
                CMD.Connection = Database.CN;
                DA.SelectCommand = CMD;
                DA.Fill(DT);
            }
            catch
            {
                ultimoRegistro.Erro = "Erro de servidor, Falha ao Consultar o banco de dados";
                return ultimoRegistro;
            }

            ultimoRegistro.atividades = new Atividades[DT.Rows.Count];

            if (DT.Rows.Count != 0)
                for (int i = 0; i < (DT.Rows.Count); i++)
                {
                    Atividades atividades = new Atividades();
                    DR = DT.Rows[i];
                    atividades.Codigo = Convert.ToInt32(DR[0]);
                    atividades.Descricao = DR[1].ToString();
                    atividades.FuncoesCapacitadas = DR[2].ToString();
                    ultimoRegistro.atividades[i] = atividades;
                }

            DA.Dispose();
            DT.Dispose();
            CMD.Dispose();

            DA = new SQLiteDataAdapter();
            DT = new DataTable();
            CMD = new SQLiteCommand();

            Comando = "Select CodigoLancamento, AnoObra, CodigoObra, MatriculaGerente, Atividade from Horas where MatriculaFuncionario = " + Matricula + " Order By CodigoLancamento DESC";

            try
            {
                CMD.CommandText = Comando;
                CMD.Connection = Database.CN;
                DA.SelectCommand = CMD;
                DA.Fill(DT);
            }
            catch(Exception e)
            {
                ultimoRegistro.Erro = "Erro de servidor, Falha ao Consultar o banco de dados";
                return ultimoRegistro;
            }

            if (DT.Rows.Count != 0)
            {
                DR = DT.Rows[0];
                ultimoRegistro.anoUltimaObra = Convert.ToInt32(DR[1]);
                ultimoRegistro.codUltimaObra = Convert.ToInt32(DR[2]);
                ultimoRegistro.matriculaUltimoGerente = Convert.ToInt32(DR[3]);
                ultimoRegistro.ultimaAtividade = DR[4].ToString();
            }

            ultimoRegistro.Erro = "Sucesso!";
            return ultimoRegistro;
        }
       
    }
}