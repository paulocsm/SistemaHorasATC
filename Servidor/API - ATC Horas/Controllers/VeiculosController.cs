using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API___ATC_Horas.Funcionamento;

namespace API___ATC_Horas.Controllers
{
    public class VeiculosController : ApiController
    {
        [AcceptVerbs("GET")]
        [Route("api/Veiculos/Todos")]
        public Veiculos[] Todos()
        {
            return Database.BuscaVeiculos("", "", "", "", "");
        }

        [AcceptVerbs("GET")]
        [Route("api/Veiculos/Consulta/{Placa}/{Marca}/{Modelo}/{Localizacao}/{Status}")]
        public Veiculos[] Consulta(string Placa, string Marca, string Modelo, string Localizacao, string Status)
        {
            return Database.BuscaVeiculos(Placa, Marca, Modelo, Localizacao, Status);
        }

        [AcceptVerbs("POST")]
        [Route("api/Veiculos/Cadastrar/{Placa}/{Marca}/{Modelo}/{KM}/{Localizacao}/{Status}/{OBS}")]
        public string Cadastrar(string Placa, string Marca, string Modelo, int KM, string Localizacao, string Status, string OBS)
        {
            return Database.CadastrarVeiculo(Placa, Marca, Modelo, KM, Localizacao, Status, OBS);
        }

        [AcceptVerbs("PUT")]
        [Route("api/Veiculos/Alterar/{Placa}/{Marca}/{Modelo}/{KM}/{Localizacao}/{Status}/{OBS}")]
        public string Alterar(string Placa, string Marca, string Modelo, int KM, string Localizacao, string Status, string OBS)
        {
            return Database.AtualizarVeiculo(Placa, Marca, Modelo, KM, Localizacao, Status, OBS);
        }

        [AcceptVerbs("DELETE")]
        [Route("api/Veiculos/Deletar/{Placa}")]
        public string Deletar(string Placa)
        {
            return Database.DeletarVeiculo(Placa);
        }
    }
}
