using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace SistemaATCTotem
{
   public class API
    {
        static HttpClient Cliente = new HttpClient();
        static string UrlBase = "http://" + Properties.Settings.Default.EndServidor + ":" + Properties.Settings.Default.PortaServidor + "/API/";

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
    }
}
