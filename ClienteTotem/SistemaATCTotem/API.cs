﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SistemaATCTotem
{
   public class API
    {
        static HttpClient Cliente = new HttpClient();
        static string UrlBase = "http://" + Properties.Settings.Default.EndServidor + ":" + Properties.Settings.Default.PortaServidor + "/API/";
        public static RespostaLogin respostaLogin = new RespostaLogin();

        public static async Task<RespostaLogin> Login(string Usuario, int Matricula, int IndiceBiometria, string Senha, string Origem, string Key)
        {
        RespostaLogin UsuarioLogado = new RespostaLogin();
        string Resposta;
        string UrlComplementar;

            if (Usuario == "" & Matricula != 0 & IndiceBiometria == 0 & Senha != "" & Origem != "") // Loguin por matricula e senha
            {
                UrlComplementar = "Login/Matricula?Origem=Totem&Matricula=" + Matricula + "&Senha=" + MD5Hash(Senha);

                try
                {
                    Resposta = await Cliente.GetStringAsync((UrlBase + UrlComplementar));
                    UsuarioLogado = JsonConvert.DeserializeObject<RespostaLogin>(Resposta);                   
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    UsuarioLogado.Erro = "Falha";
                }
                return UsuarioLogado;
            }
            if (Usuario == "" & Matricula == 0 & IndiceBiometria != 0 & Senha == "" & Origem != "" & Key != "") //Loguin por biometria
            {

            }
            return UsuarioLogado;
        }

        public static async Task<string> Logout(string Origem, string ApiKey, string Usuario, int IndiceBiometria, int Matricula)
        {
            string Resposta;
            string UrlComplementar = "Login/Logout?Origem=Totem&ApiKey=" + ApiKey + "&Usuario=" + Usuario + "&IndiceBiometria=" + IndiceBiometria + "&Matricula=" + Matricula;

            try
            {
                Resposta = await Cliente.GetStringAsync((UrlBase + UrlComplementar));
                Resposta = JsonConvert.DeserializeObject<string>(Resposta);
            }
            catch (Exception)
            {
                return "Falha!";
            }

            return Resposta;
        }

        public static async Task<UltimoRegistro> BuscaUltimoRegistro(string ApiKey, int Matricula)
        {
            UltimoRegistro ultimoRegistro = new UltimoRegistro();
            string Resposta;
            string UrlComplementar;

            UrlComplementar = "Funcionarios/UltimoRegistro?ApiKey=" + ApiKey + "&Matricula=" + Matricula;

            try
            {
                Resposta = await Cliente.GetStringAsync((UrlBase + UrlComplementar));
                ultimoRegistro = JsonConvert.DeserializeObject<UltimoRegistro>(Resposta);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                ultimoRegistro.Erro = "Falha";
            }
            return ultimoRegistro;

        }

        public static async Task<string> BuscaHoraeData(string ApiKey)
        {
            string horaeData;
            string UrlComplementar;

            UrlComplementar = "Miscelaneas/Datetime";

            try
            {
                horaeData = await Cliente.GetStringAsync((UrlBase + UrlComplementar));
                horaeData = JsonConvert.DeserializeObject<string>(horaeData);
            }
            catch (Exception e)
            {
                return "Falha!";
            }
            return horaeData;

        }

        public static async Task<string> TesteComServidor(string url)
        {
            string Resposta;

            try
            {
                Resposta = await Cliente.GetStringAsync(url);
                Resposta = JsonConvert.DeserializeObject<string>(Resposta);
            }
            catch (Exception)
            {
                return "Falha!";
            }

            return Resposta;
        }

        public static async Task<DateTime> BuscaHoraeData()
        {
            DateTime horaeData = DateTime.Now;
            string Resposta;
            string UrlComplementar;

            UrlComplementar = "Miscelaneas/Datetime";

            try
            {
                Resposta = await Cliente.GetStringAsync((UrlBase + UrlComplementar));
                horaeData = JsonConvert.DeserializeObject<DateTime>(Resposta);
            }
            catch (Exception e)
            {
                return horaeData;
            }
            return horaeData;
        }

        public static async Task<string> CadastrarHoras()
        {
            string Resposta;
            string UrlComplementar;
            UrlComplementar = "Horas/Cadastro";
            HttpContent httpContent = new HttpContent();


            try
            {
                Resposta = await Cliente.PostAsync()
                Resposta = await Cliente.GetStringAsync((UrlBase + UrlComplementar));
                horaeData = JsonConvert.DeserializeObject<DateTime>(Resposta);
            }
            catch (Exception e)
            {
                return horaeData;
            }
            return horaeData;
        }

        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
    }
}
