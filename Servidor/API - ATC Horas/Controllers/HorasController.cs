using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API___ATC_Horas.Funcionamento;

namespace API___ATC_Horas.Controllers
{
    public class HorasController : ApiController
    {
       // [AcceptVerbs("POST")]
        [Route("api/Horas/Cadastro")]
        [HttpPost]
        public string CadastraHoras([FromBody] Atividades atividades)
        {
            string descricao;
            descricao = atividades.FuncoesCapacitadas;
            return descricao;
        }
    }
}
