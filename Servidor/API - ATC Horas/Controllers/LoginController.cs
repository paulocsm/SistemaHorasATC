using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API___ATC_Horas.Funcionamento;

namespace API___ATC_Horas.Controllers
{
    /// <summary>
    /// Controller para gerenciamento dos logins
    /// login por matricula e senha ou por biometria
    /// </summary>
    
    public class LoginController : ApiController
    {
        [AcceptVerbs("GET")]
        [Route("API/Login/Matricula/{Origem}/{Matricula}/{Senha}")]
        public login LoginMatricula(string Origem, int Matricula, string Senha)
        {
            return Autenticacao.Logar("", Matricula, 0, Senha, Origem, "");
        }

        [AcceptVerbs("GET")]
        [Route("API/Login/Biometria/{Origem}/{ApiKey}/{IndiceBiometria}")]
        public login LoginBiometria(string Origem, string ApiKey, int IndiceBiometria)
        {
            return Autenticacao.Logar("", 0, IndiceBiometria, "", Origem, ApiKey);
        }

        [AcceptVerbs("GET")]
        [Route("API/Login/Usuario/{Origem}/{Usuario}/{Senha}")]
        public login LoginUsuario(string Origem, string Usuario, string Senha)
        {
            return Autenticacao.Logar(Usuario, 0, 0, Senha, Origem, "");
        }

        [AcceptVerbs("GET")]
        [Route("API/Login/Logout/{Origem}/{ApiKey}/{Usuario}/{IndiceBiometria}/{Matricula}")]
        public string Logout(string Origem, string ApiKey, string Usuario, int IndiceBiometria, int Matricula)
        {
            return Autenticacao.logout(Origem, ApiKey, Usuario, IndiceBiometria, Matricula);
        }
    }
}
