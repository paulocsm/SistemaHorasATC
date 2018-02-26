using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API___ATC_Horas.Funcionamento;

/// <summary>
/// Controler apenas para responder as requisições de teste de conexão dos clientes
/// Se os dados estiverem ok responde Sucesso!
/// Se der algum problema na requisição responde Falha!
/// Se o ApiKey não existir responde ApiKey Inexistente
/// </summary>

namespace API___ATC_Horas.Controllers
{
    public class TesteController : ApiController
    {
        [AcceptVerbs("GET")]
        [Route("API/Teste/{ApiKey}/{Origem}")]
        // API/Teste?ApiKey=&Origem=
        public string RespostaTeste(string ApiKey, string Origem)
        {
            return Database.TesteConexao(ApiKey, Origem);
        }
    }
}
