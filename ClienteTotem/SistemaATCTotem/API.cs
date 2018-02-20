using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Security.Cryptography;

namespace SistemaATCTotem
{
   public class API
    {
        static HttpClient Cliente = new HttpClient();
        static string UrlBase = "http://" + Properties.Settings.Default.EndServidor + ":" + Properties.Settings.Default.PortaServidor + "/API/";

        public static async Task<Classes.RespostaLogin> Login(string Usuario, int Matricula, int IndiceBiometria, string Senha, string Origem, string Key)
        {
            string Resposta;
            string UrlComplementar;

        //    if (Usuario != "" & Matricula == 0 & IndiceBiometria == 0 & Senha != "" & Origem != "") // loguin  por usuário e senha;
        //    {
        //
        //    }

            if (Usuario == "" & Matricula != 0 & IndiceBiometria == 0 & Senha != "" & Origem != "") // Loguin por matricula e senha
            {
                UrlComplementar = "Matricula?Origem=Totem&Matricula=" + Matricula + "&Senha=" + MD5Hash(Senha);

                try
                {
                    Resposta = await Cliente.GetStringAsync((UrlBase + UrlComplementar));
                    
                    Resposta = JsonConvert.DeserializeObject<Classes.RespostaLogin>(Resposta);
                }
                catch (Exception)
                {
                    return "Falha!";
                }
            }
            if (Usuario == "" & Matricula == 0 & IndiceBiometria != 0 & Senha == "" & Origem != "" & Key != "") //Loguin por biometria
            {

            }
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
