using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaATCTotem
{
    public class RespostaLogin
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

    public class Obras
    {
        public int Ano { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int MatriculaGerente { get; set; }
        public string Status { get; set; }
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
