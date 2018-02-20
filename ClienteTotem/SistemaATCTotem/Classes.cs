using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaATCTotem
{
    class Classes
    {
        public class RespostaLogin
        {
            public string Origem { get; set; }
            public string ApiKey { get; set; }
            public int Matricula { get; set; }
            public string Nome { get; set; }
            public string Usuario { get; set; }
            public int IndiceBiometria { get; set; }
            public string Departamento { get; set; }
            public string Funcao { get; set; }
            public int NivelAcesso { get; set; }
            public DateTime DatetimeLogin { get; set; }
        }
    }
}
