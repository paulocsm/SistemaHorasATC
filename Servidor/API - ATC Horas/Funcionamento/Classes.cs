using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API___ATC_Horas.Funcionamento
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public int Matricula { get; set; }
        public string Departamento { get; set; }
        public string Funcao { get; set; }
        public string Senha { get; set; }
        public int IndiceBiometria { get; set; }
        public int NivelAcesso { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }

    public class Veiculos
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int KM { get; set; }
        public string Localizacao { get; set; }
        public string Status { get; set; }
        public string OBS { get; set; }
    }

    public class Horas
    {
        public int CodigoLancamento { get; set; }
        public string CodigoObra { get; set; }
        public string MatriculaFuncionario { get; set; }
        public string Status { get; set; }
        public string MatriculaGerente { get; set; }
        public string DataLancamento { get; set; }
        public string HoraLancamento { get; set; }
        public string OrigemLancamento { get; set; }  
        public string DataInicio { get; set; }
        public string HoraInicio { get; set; }
        public string DataTermino { get; set; }
        public string HoraTermino { get; set; }
        public string Atividade { get; set; }
        public string Historico { get; set; } 
    }

    public class Obras
    {
        public int Ano { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int MatriculaGerente { get; set; }
        public string Status { get; set; }
    }

    public class login
    {
        public string Erro { get; set; }
        public string Origem { get; set; }
        public string ApiKey { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public int IndiceBiometria { get; set; }
        public string Departamento { get; set; }
        public string Funcao { get; set; }
        public int NivelAcesso { get; set; }
        public DateTime DatTimelogin { get; set; }
    }

    public class UltimoRegistro
    {
        public string Erro { get; set; }
        public int codUltimaObra { get; set; }
        public int anoUltimaObra { get; set; }
        public int matriculaUltimoGerente { get; set; }
        public string ultimaAtividade { get; set; }
        public Obras[] obras { get; set; }
        public Funcionario[] gerentes { get; set; }
        public Atividades[] atividades { get; set; }
    }

    public class Atividades
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string FuncoesCapacitadas { get; set; }
    }

}