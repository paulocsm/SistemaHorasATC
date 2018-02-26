using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using System.Data;
using Newtonsoft.Json;

namespace API___ATC_Horas.Funcionamento
{
    public class Autenticacao
    {
       public static List<login> UsuariosLogados = new List<login>();

        public static login Logar(string Usuario, int Matricula, int IndiceBiometria, string Senha, string Origem, string Key)
        {
            if (Database.CN.State == ConnectionState.Closed)
            {
                Database.StringConexao = @"Data Source = C:\Program Files\Autentica Softwares\ATCHoras\Dados\Dados.db" + ";Version=3";
                Database.CN.ConnectionString = Database.StringConexao;
                Database.CN.Open();
            }

            login UsuarioLogado = new login();
            string Comando;
            SQLiteCommand CMD = new SQLiteCommand();
            DataTable DT = new DataTable();
            DataTable DT1 = new DataTable();
            SQLiteDataAdapter DA = new SQLiteDataAdapter();
            SQLiteDataAdapter DA1 = new SQLiteDataAdapter();
            DataRow DR;
            DataRow DR1;


            if (Usuario != "" & Matricula == 0 & IndiceBiometria == 0 & Senha != "" & Origem != "") // loguin  por usuário e senha;
            {
                Comando = "Select Nome, Usuario, Matricula, Departamento, Funcao, IndiceBiometria, NivelAcesso, Status from Funcionarios where Usuario = '" + Usuario + "' and senha = '" + Senha + "'";

                try
                {
                    CMD.CommandText = Comando;
                    CMD.Connection = Database.CN;
                    DA.SelectCommand = CMD;
                    DA.Fill(DT);
                }
                catch
                {
                    UsuarioLogado.Erro = "Erro de servidor, Falha ao Consultar o banco de dados";
                    return UsuarioLogado;
                }

                if (DT.Rows.Count == 1) // Credenciais encontradas
                {
                    DR = DT.Rows[0];
                    UsuarioLogado.Erro = "Sucesso!";
                    UsuarioLogado.Origem = Origem;
                    UsuarioLogado.Nome = DR[0].ToString();
                    UsuarioLogado.Usuario = DR[1].ToString();
                    UsuarioLogado.Matricula = Convert.ToInt32(DR[2]);
                    UsuarioLogado.Departamento = DR[3].ToString();
                    UsuarioLogado.Funcao = DR[4].ToString();
                    UsuarioLogado.IndiceBiometria = Convert.ToInt32(DR[5]);
                    UsuarioLogado.NivelAcesso = Convert.ToInt32(DR[6]);
                    UsuarioLogado.ApiKey = GerarKey(30);
                    UsuarioLogado.DatTimelogin = DateTime.Now;

                    if (VerificarLogin(UsuarioLogado.Matricula, "") == false) // Verifica se o usuario já está logado no sistema
                    {
                        //Efetua logoff de algum usuario que esteja logado na mesma origem
                        int contador = 0;
                        foreach (login User in UsuariosLogados)
                        {
                            contador++;
                            if (User.Origem == Origem)
                            {
                                UsuariosLogados.RemoveAt((contador - 1));
                                break;
                            }
                        }

                        UsuariosLogados.Add(UsuarioLogado);
                        return UsuarioLogado;
                    }
                    else
                    {
                        UsuarioLogado.Erro = "Usuário já logado no sistema";
                        return UsuarioLogado;
                    }
                }
                else
                {
                    UsuarioLogado.Erro = "Credenciais Incorretas";
                    return UsuarioLogado;
                }
            }

            if (Usuario == "" & Matricula != 0 & IndiceBiometria == 0 & Senha != "" & Origem != "") // Loguin por matricula e senha
            {
                Comando = "Select Nome, Usuario, Matricula, Departamento, Funcao, IndiceBiometria, NivelAcesso, Status from Funcionarios where Matricula = '" + Matricula + "' and senha = '" + Senha + "'";

                try
                {
                    CMD.CommandText = Comando;
                    CMD.Connection = Database.CN;
                    DA.SelectCommand = CMD;
                    DA.Fill(DT);
                }
                catch
                {
                    UsuarioLogado.Erro = "Erro de servidor, Falha ao Consultar o banco de dados";
                    return UsuarioLogado;
                }

                if (DT.Rows.Count == 1) // Credenciais encontradas
                {
                    DR = DT.Rows[0];
                    UsuarioLogado.Erro = "Sucesso!";
                    UsuarioLogado.Origem = Origem;
                    UsuarioLogado.Nome = DR[0].ToString();
                    UsuarioLogado.Usuario = DR[1].ToString();
                    UsuarioLogado.Matricula = Convert.ToInt32(DR[2]);
                    UsuarioLogado.Departamento = DR[3].ToString();
                    UsuarioLogado.Funcao = DR[4].ToString();
                    UsuarioLogado.IndiceBiometria = Convert.ToInt32(DR[5]);
                    UsuarioLogado.NivelAcesso = Convert.ToInt32(DR[6]);
                    UsuarioLogado.ApiKey = GerarKey(30);
                    UsuarioLogado.DatTimelogin = DateTime.Now;

                    if (VerificarLogin(UsuarioLogado.Matricula, "") == false) // Verifica se o usuario já está logado no sistema
                    {
                        //Efetua logoff de algum usuario que esteja logado na mesma origem
                        int contador = 0;
                        foreach (login User in UsuariosLogados)
                        {
                            contador++;
                            if (User.Origem == Origem)
                            {
                                UsuariosLogados.RemoveAt((contador - 1));
                                break;
                            }
                        }

                        UsuariosLogados.Add(UsuarioLogado);
                        return UsuarioLogado;
                    }
                    else
                    {
                        UsuarioLogado.Erro = "Usuário já logado no sistema";
                        return UsuarioLogado;
                    }
                }
                else
                {
                    UsuarioLogado.Erro = "Credenciais Incorretas";
                    return UsuarioLogado;
                }
            }

            if (Usuario == "" & Matricula == 0 & IndiceBiometria != 0 & Senha == "" & Origem != "" & Key != "") //Loguin por biometria
            {
                // Verifica se a Key do toten bate com a do sistema
                Comando = "Select * from Totems where ApiKey = '" + Key + "'";

                try
                {
                    CMD.CommandText = Comando;
                    CMD.Connection = Database.CN;
                    DA.SelectCommand = CMD;
                    DA.Fill(DT);
                }
                catch
                {
                    UsuarioLogado.Erro = "Erro de servidor, Falha ao Consultar o banco de dados";
                    return UsuarioLogado;
                }

                if (DT.Rows.Count == 1) // Key do totem existe
                {
                    Comando = "Select Nome, Usuario, Matricula, Departamento, Funcao, IndiceBiometria, NivelAcesso, Status from Funcionarios where IndiceBiometria = " + IndiceBiometria;

                    try
                    {
                        CMD.CommandText = Comando;
                        CMD.Connection = Database.CN;
                        DA1.SelectCommand = CMD;
                        DA1.Fill(DT1);
                    }
                    catch
                    {
                        UsuarioLogado.Erro = "Erro de servidor, Falha ao Consultar o banco de dados";
                        return UsuarioLogado;
                    }

                    if (DT1.Rows.Count == 1) // Indice Biometria encontrado
                    {
                        DR = DT.Rows[0];
                        UsuarioLogado.Erro = "Sucesso!";
                        UsuarioLogado.Origem = Origem;
                        UsuarioLogado.Nome = DR[0].ToString();
                        UsuarioLogado.Usuario = DR[1].ToString();
                        UsuarioLogado.Matricula = Convert.ToInt32(DR[2]);
                        UsuarioLogado.Departamento = DR[3].ToString();
                        UsuarioLogado.Funcao = DR[4].ToString();
                        UsuarioLogado.IndiceBiometria = Convert.ToInt32(DR[5]);
                        UsuarioLogado.NivelAcesso = Convert.ToInt32(DR[6]);
                        UsuarioLogado.ApiKey = GerarKey(30);
                        UsuarioLogado.DatTimelogin = DateTime.Now;

                        if (VerificarLogin(UsuarioLogado.Matricula, "") == false) // Verifica se o usuario já está logado no sistema
                        {
                            //Efetua logoff de algum usuario que esteja logado na mesma origem
                            int contador = 0;
                            foreach (login User in UsuariosLogados)
                            {
                                contador++;
                                if (User.Origem == Origem)
                                {
                                    UsuariosLogados.RemoveAt((contador - 1));
                                    break;
                                }
                            }

                            UsuariosLogados.Add(UsuarioLogado);
                            return UsuarioLogado;
                        }
                        else
                        {
                            UsuarioLogado.Erro = "Usuário já logado no sistema";
                            return UsuarioLogado;
                        }
                    }
                    else
                    {
                        UsuarioLogado.Erro = "Indice de Biometria não associado a nenhum funcionário";
                        return UsuarioLogado;
                    }
                }
                else
                {
                    UsuarioLogado.Erro = "ApiKey do totem incorreta, Acesso negado";
                    return UsuarioLogado;
                }            
            }
            UsuarioLogado.Erro = "Requisição incorreta";
            return UsuarioLogado;
        }

        public static string logout(string Origem, string ApiKey, string Usuario, int IndiceBiometria, int Matricula)       
        {
            if (Origem == null)
                Origem = "";
            if (ApiKey == null)
                ApiKey = "";
            if (Usuario == null)
                Usuario = "";

            if (ApiKey != "" & Usuario == "" & IndiceBiometria == 0 & Matricula == 0) // Logout por ApiKey
            {
                int contador = 0;

                foreach (login User in UsuariosLogados)
                {
                    contador++;
                    if (User.ApiKey == ApiKey)
                    {
                        UsuariosLogados.RemoveAt((contador - 1));
                        return "Sucesso!";
                    }                
                }
                return "Usuário não está logado no sistema";
            }

            if (ApiKey == "" & Usuario != "" & IndiceBiometria == 0 & Matricula == 0) // Logout por Usuario
            {
                int contador = 0;

                foreach (login User in UsuariosLogados)
                {
                    contador++;
                    if (User.Usuario == Usuario)
                    {
                        UsuariosLogados.RemoveAt((contador - 1));
                        return "Sucesso!";
                    }

                }
                return "Usuário não está logado no sistema";
            }

            if (ApiKey == "" & Usuario == "" & IndiceBiometria != 0 & Matricula == 0) // Logout por Indice De Biometria
            {
                int contador = 0;

                foreach (login User in UsuariosLogados)
                {
                    contador++;
                    if (User.IndiceBiometria == IndiceBiometria)
                    {
                        UsuariosLogados.RemoveAt((contador - 1));
                        return "Sucesso!";
                    }

                }
                return "Usuário não está logado no sistema";
            }

            if (ApiKey == "" & Usuario == "" & IndiceBiometria == 0 & Matricula != 0) // Logout por Matricula
            {
                int contador = 0;

                foreach (login User in UsuariosLogados)
                {
                    contador++;
                    if (User.Matricula == Matricula)
                    {
                        UsuariosLogados.RemoveAt((contador - 1));
                        return "Sucesso!";
                    }

                }
                return "Usuário não está logado no sistema";
            }
            return "Falha ao efetuar o logout";
        }

        public static bool VerificarLogin(int Matricula, string ApiKey)
        {
            if (Matricula == 0 & ApiKey != "") //Verifica se existe um usuario logado por ApiKey
            {
                foreach (login usuario in UsuariosLogados)
                {
                    if (usuario.ApiKey == ApiKey)
                        return true;
                    else
                        return false;
                }
            }

            if (Matricula != 0 & ApiKey == "") //Verifica se existe um usuario logado por Matricula
            {
                foreach (login usuario in UsuariosLogados)
                {
                    if (usuario.Matricula == Matricula)
                        return true;
                    else
                        return false;
                }

            }
            return false;
        }

        public static string GerarKey(int tamanho)
        {
            var chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, tamanho)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
        //teste
    }
}