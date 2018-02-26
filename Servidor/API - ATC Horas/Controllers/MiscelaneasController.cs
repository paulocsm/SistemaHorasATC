using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API___ATC_Horas.Controllers
{
    public class MiscelaneasController : ApiController
    {
        [AcceptVerbs("GET")]
        [Route("API/Miscelaneas/Datetime")]
        public DateTime dateTime()
        {
            return DateTime.Now;
        }
    }
}
