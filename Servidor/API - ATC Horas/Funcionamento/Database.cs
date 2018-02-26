using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using System.Data;


namespace API___ATC_Horas.Funcionamento
{
    public class Database      
    {
        public static string StringConexao;
        
        public static SQLiteConnection CN = new SQLiteConnection(StringConexao);

        public static int ConectaDatabase ()
        {
            int retorno = 0;
            try
            {
                CN.Open();
                retorno = 1;
            }
            catch 
            {
                retorno = 2;
            }
            return retorno;
        }

        public static string TesteConexao(string ApiKey, string Origem)
        {
            if (CN.State == ConnectionState.Closed)
            {
                StringConexao = @"Data Source = C:\Program Files\Autentica Softwares\ATCHoras\Dados\Dados.db" + ";Version=3";
                CN.ConnectionString = StringConexao;
                CN.Open();
            }

            string Comando;
            SQLiteCommand CMD = new SQLiteCommand();
            DataTable DT = new DataTable();
            SQLiteDataAdapter DA = new SQLiteDataAdapter();
            DataRow DR;

            if (Origem == "Totem")
            {
                Comando = "Select * from Totems where ApiKey = '" + ApiKey + "'";
                CMD.CommandText = Comando;
                CMD.Connection = CN;
                DA.SelectCommand = CMD;
                DA.Fill(DT);

                if (DT.Rows.Count > 0)
                    return "Sucesso!";
                else
                    return "ApiKey Inexistente";
            }
            else
                return "Origem Desconhecida";
        }

        #region Funcionarios

        public static Funcionario[]  BuscaFuncionarios(string Nome, int Matricula, string Departamento, int IndiceBiometria, int NivelAcesso, string Status)
        {
            if (Nome == null)
                Nome = "";
            if (Departamento == null)
                Departamento = "";
            if (Status == null)
                Status = "";

            if (CN.State == ConnectionState.Closed)
            {
                StringConexao = @"Data Source = C:\Program Files\Autentica Softwares\ATCHoras\Dados\Dados.db" + ";Version=3";
                CN.ConnectionString = StringConexao;
                CN.Open();
            }
            
            string Comando = "Select * from Funcionarios where ";
            bool Primeiro = false;
            SQLiteCommand CMD = new SQLiteCommand();
            DataTable DT = new DataTable();
            SQLiteDataAdapter DA = new SQLiteDataAdapter();
            DataRow DR;

            if (Nome == "" & Matricula == 0 & Departamento == "" & IndiceBiometria == 0 & NivelAcesso == 0 & Status == "")
            {
                Comando = "Select * from Funcionarios";
            }

            if (Nome != "")
            {
                Primeiro = true;
                Comando = Comando + "Nome = '" + Nome + "'";
            }

            if (Matricula != 0)
            {
                if (Primeiro == true)
                    Comando = Comando + " and Matricula = " + Matricula;
                else
                {
                    Primeiro = true;
                    Comando = Comando + "Matricula = " + Matricula;
                }
            }

            if (Departamento != "")
            {
                if (Primeiro == true)
                    Comando = Comando + " and Departamento = '" + Departamento + "'";
                else
                {
                    Primeiro = true;
                    Comando = Comando + "Departamento = '" + Departamento + "'";
                }
            }

            if (IndiceBiometria != 0)
            {
                if (Primeiro == true)
                    Comando = Comando + " and IndiceBiometria = " + IndiceBiometria;
                else
                {
                    Primeiro = true;
                    Comando = Comando + "IndiceBiometria = " + IndiceBiometria;
                }
            }

            if (NivelAcesso != 0)
            {
                if (Primeiro == true)
                    Comando = Comando + " and NivelAcesso = " + NivelAcesso;
                else
                {
                    Primeiro = true;
                    Comando = Comando + "NivelAcesso = " + NivelAcesso;
                }
            }

            if (Status != "")
            {
                if (Primeiro == true)
                    Comando = Comando + " and Status = '" + Status + "'";
                else
                {
                    Primeiro = true;
                    Comando = Comando + "Status = '" + Status + "'";
                }
            }

            CMD.CommandText = Comando;
            CMD.Connection = CN;
            DA.SelectCommand = CMD;
            DA.Fill(DT);

            Funcionario[] funcionario = new Funcionario[DT.Rows.Count];

            if (DT.Rows.Count > 0)
            {
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DR = DT.Rows[i];
                    funcionario[i] = new Funcionario { Nome = DR[0].ToString(), Matricula = Convert.ToInt32(DR[1]), Departamento = DR[2].ToString(), Senha = DR[3].ToString(), IndiceBiometria = Convert.ToInt32(DR[4]), NivelAcesso = Convert.ToInt32(DR[5]), Status = DR[6].ToString()};
                }
            }
                  
            return funcionario;
        }

        public static string CadastrarFuncionario(string Nome, int Matricula, string Departamento, string Senha, int IndiceBiometria, int NivelAcesso, string Status)
        {
            string retorno = "";

            if (CN.State == ConnectionState.Closed)
            {
                StringConexao = @"Data Source = C:\Program Files\Autentica Softwares\ATCHoras\Dados\Dados.db" + ";Version=3";
                CN.ConnectionString = StringConexao;
                CN.Open();
            }

            string Comando = "";
            SQLiteCommand CMD = new SQLiteCommand();

            Comando = "Insert into Funcionarios (Nome, Matricula, Departamento, Senha, IndiceBiometria, NivelAcesso, Status) values ('" + Nome + "'," + Matricula + ",'" + Departamento + "','" + Senha + "'," + IndiceBiometria + "," + NivelAcesso + ",'" + Status + "')";

            try
            {
                CMD.Connection = CN;
                CMD.CommandText = Comando;
                CMD.ExecuteNonQuery();
                retorno = "Sucesso!";
            }
            catch(Exception e)
            {
                retorno = "Falha!:" + Convert.ToString(e);
            }
            return retorno;
        }

        public static string AtualizarFuncionario(string Nome, int Matricula, string Departamento, string Senha, int IndiceBiometria, int NivelAcesso, string Status)
        {
            string retorno = "";

            if (CN.State == ConnectionState.Closed)
            {
                StringConexao = @"Data Source = C:\Program Files\Autentica Softwares\ATCHoras\Dados\Dados.db" + ";Version=3";
                CN.ConnectionString = StringConexao;
                CN.Open();
            }

            string Comando = "";
            SQLiteCommand CMD = new SQLiteCommand();

            Comando = "update Funcionarios set Nome = '" + Nome + "', Departamento = '" + Departamento + "', Senha = '" + Senha + "', IndiceBiometria = " + IndiceBiometria + ", NivelAcesso = " + NivelAcesso + ", Status = '" + Status + "' where Matricula = " + Matricula;

            try
            {
                CMD.Connection = CN;
                CMD.CommandText = Comando;
                CMD.ExecuteNonQuery();
                retorno = "Sucesso!";
            }
            catch (Exception e)
            {
                retorno = "Falha!:" + Convert.ToString(e);
            }
            return retorno;
        }

        public static string DeletarFuncionario(int Matricula)
        {
            string retorno = "";

            if (CN.State == ConnectionState.Closed)
            {
                StringConexao = @"Data Source = C:\Program Files\Autentica Softwares\ATCHoras\Dados\Dados.db" + ";Version=3";
                CN.ConnectionString = StringConexao;
                CN.Open();
            }

            string Comando = "";
            SQLiteCommand CMD = new SQLiteCommand();

            Comando = "delete from Funcionarios where Matricula = " + Matricula;

            try
            {
                CMD.Connection = CN;
                CMD.CommandText = Comando;
                CMD.ExecuteNonQuery();
                retorno = "Sucesso!";
            }
            catch (Exception e)
            {
                retorno = "Falha!:" + Convert.ToString(e);
            }
            return retorno;
        }

        #endregion

        #region Veiculos

        public static Veiculos[] BuscaVeiculos(string Placa, string Marca, string Modelo, string Localizacao, string Status)
        {
            if (Placa == null)
                Placa = "";
            if (Marca == null)
                Marca = "";
            if (Modelo == null)
                Modelo = "";
            if (Localizacao == null)
                Localizacao = "";
            if (Status == null)
                Status = "";

            if (CN.State == ConnectionState.Closed)
            {
                StringConexao = @"Data Source = C:\Program Files\Autentica Softwares\ATCHoras\Dados\Dados.db" + ";Version=3";
                CN.ConnectionString = StringConexao;
                CN.Open();
            }

            string Comando = "Select * from Veiculos where ";
            bool Primeiro = false;
            SQLiteCommand CMD = new SQLiteCommand();
            DataTable DT = new DataTable();
            SQLiteDataAdapter DA = new SQLiteDataAdapter();
            DataRow DR;

            if (Placa == "" & Marca == "" & Modelo == "" & Localizacao == "" & Status == "")
            {
                Comando = "Select * from Veiculos";
            }

            if (Placa != "")
            {
                Primeiro = true;
                Comando = Comando + "Placa = '" + Placa + "'";
            }

            if (Marca != "")
            {
                if (Primeiro == true)
                    Comando = Comando + " and Marca = '" + Marca + "'";
                else
                {
                    Primeiro = true;
                    Comando = Comando + "Marca = '" + Marca + "'";
                }
            }

            if (Modelo != "")
            {
                if (Primeiro == true)
                    Comando = Comando + " and Modelo = '" + Modelo + "'";
                else
                {
                    Primeiro = true;
                    Comando = Comando + "Modelo = '" + Modelo + "'";
                }
            }

            if (Localizacao != "")
            {
                if (Primeiro == true)
                    Comando = Comando + " and Localizacao = '" + Localizacao + "'";
                else
                {
                    Primeiro = true;
                    Comando = Comando + "Localizacao = '" + Localizacao + "'";
                }
            }

            if (Status != "")
            {
                if (Primeiro == true)
                    Comando = Comando + " and Status = '" + Status + "'";
                else
                {
                    Primeiro = true;
                    Comando = Comando + "Status = '" + Status + "'";
                }
            }

            CMD.CommandText = Comando;
            CMD.Connection = CN;
            DA.SelectCommand = CMD;
            DA.Fill(DT);

            Veiculos[] Veiculo = new Veiculos[DT.Rows.Count];

            if (DT.Rows.Count > 0)
            {
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DR = DT.Rows[i];
                    Veiculo[i] = new Veiculos { Placa = DR[0].ToString(), Marca = DR[1].ToString(), Modelo = DR[2].ToString(), KM = Convert.ToInt32(DR[3]), Localizacao = DR[4].ToString(), Status = DR[5].ToString(), OBS = DR[6].ToString() };
                }
            }

            return Veiculo;
        }

        public static string CadastrarVeiculo(string Placa, string Marca, string Modelo, int KM, string Localizacao, string Status, string OBS)
        {
            string retorno = "";


            if (CN.State == ConnectionState.Closed)
            {
                StringConexao = @"Data Source = C:\Program Files\Autentica Softwares\ATCHoras\Dados\Dados.db" + ";Version=3";
                CN.ConnectionString = StringConexao;
                CN.Open();
            }

            string Comando = "";
            SQLiteCommand CMD = new SQLiteCommand();
            DataTable DT = new DataTable();
            SQLiteDataAdapter DA = new SQLiteDataAdapter();

            Comando = "select Placa from Veiculos where Placa ='" + Placa + "'";

            try
            {
                CMD.CommandText = Comando;
                CMD.Connection = CN;
                DA.SelectCommand = CMD;
                DA.Fill(DT);
            }
            catch (Exception e)
            {
                retorno = "Falha!:" + Convert.ToString(e);
                return retorno;
            }

            Comando = "Insert into Veiculos (Placa, Marca, Modelo, KM, Localizacao, Status, OBS) values ('" + Placa + "','" + Marca + "','" + Modelo + "'," + KM + ",'" + Localizacao + "','" + Status + "','" + OBS + "')";

            if (DT.Rows.Count == 0)
            {
                 try
                 {
                    CMD.Connection = CN;
                    CMD.CommandText = Comando;
                    CMD.ExecuteNonQuery();
                    retorno = "Sucesso!";
                 }
                 catch (Exception e)
                 {
                    retorno = "Falha!:" + Convert.ToString(e);
                    return retorno;
                 }            
            }
            else
            {
                retorno = "Placa Duplicada";
            }
            return retorno;
        }

        public static string AtualizarVeiculo(string Placa, string Marca, string Modelo, int KM, string Localizacao, string Status, string OBS)
        {
            string retorno = "";

            if (CN.State == ConnectionState.Closed)
            {
                StringConexao = @"Data Source = C:\Program Files\Autentica Softwares\ATCHoras\Dados\Dados.db" + ";Version=3";
                CN.ConnectionString = StringConexao;
                CN.Open();
            }

            string Comando = "";
            SQLiteCommand CMD = new SQLiteCommand();
          
                Comando = "update Veiculos set Marca = '" + Marca + "', Modelo = '" + Modelo + "', KM = " + KM + ", Localizacao = '" + Localizacao + "', Status = '" + Status + "', OBS = '" + OBS + "' where Placa = '" + Placa + "'";

                try
                {
                    CMD.Connection = CN;
                    CMD.CommandText = Comando;
                    CMD.ExecuteNonQuery();
                    retorno = "Sucesso!";
                }
                catch (Exception e)
                {
                    retorno = "Falha!:" + Convert.ToString(e);
                }

            return retorno;
        }

        public static string DeletarVeiculo(string Placa)
        {
            string retorno = "";

            if (CN.State == ConnectionState.Closed)
            {
                StringConexao = @"Data Source = C:\Program Files\Autentica Softwares\ATCHoras\Dados\Dados.db" + ";Version=3";
                CN.ConnectionString = StringConexao;
                CN.Open();
            }

            string Comando = "";
            SQLiteCommand CMD = new SQLiteCommand();

            Comando = "delete from Veiculos where Placa = '" + Placa + "'";

            try
            {
                CMD.Connection = CN;
                CMD.CommandText = Comando;
                CMD.ExecuteNonQuery();
                retorno = "Sucesso!";
            }
            catch (Exception e)
            {
                retorno = "Falha!:" + Convert.ToString(e);
            }
            return retorno;
        }


        #endregion

    }
}