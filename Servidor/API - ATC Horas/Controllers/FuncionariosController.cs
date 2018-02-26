using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API___ATC_Horas.Funcionamento;

namespace API___ATC_Horas.Controllers
{
    public class FuncionariosController : ApiController
    {
        [AcceptVerbs("GET")]
        [Route("api/Funcionarios/Consulta/{Nome}/{Matricula}/{Departamento}/{IndiceBiometria}/{NivelAcesso}/{Status}")]
        public Funcionario[] Consulta(string Nome, int Matricula, string Departamento, int IndiceBiometria, int NivelAcesso, string Status)
        {
            return Database.BuscaFuncionarios(Nome, Matricula, Departamento, IndiceBiometria, NivelAcesso, Status);          
        }

        [AcceptVerbs("GET")]
        [Route("api/Funcionarios/UltimoRegistro/{ApiKey}/{Matricula}")]
        public UltimoRegistro UltimoRegistro(string ApiKey, int Matricula)
        {
            return ApropriacaoHoras.BuscaUltimoRegistro(Matricula);
        }

        [AcceptVerbs("POST")]
        [Route("api/Funcionarios/Cadastrar/{Nome}/{Matricula}/{Departamento}/{Senha}/{IndiceBiometria}/{NivelAcesso}/{Status}")]
        public string Cadastrar(string Nome, int Matricula, string Departamento, string Senha, int IndiceBiometria, int NivelAcesso, string Status)
        {
            return Database.CadastrarFuncionario(Nome, Matricula, Departamento, Senha, IndiceBiometria, NivelAcesso, Status);
        }

        [AcceptVerbs("PUT")]
        [Route("api/Funcionarios/Alterar/{Nome}/{Matricula}/{Departamento}/{Senha}/{IndiceBiometria}/{NivelAcesso}/{Status}")]

        public string  Alterar(string Nome, int Matricula, string Departamento, string Senha, int IndiceBiometria, int NivelAcesso, string Status)
        {
            return Database.AtualizarFuncionario(Nome, Matricula, Departamento, Senha, IndiceBiometria, NivelAcesso, Status);
        }

        [AcceptVerbs("DELETE")]
        [Route("api/Funcionarios/Deletar/{Matricula}")]
        public string Deletar(int Matricula)
        {
            return Database.DeletarFuncionario(Matricula);
        }
    }
}
