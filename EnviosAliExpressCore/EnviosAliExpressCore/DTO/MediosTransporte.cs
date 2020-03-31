using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.DTO
{
    public class MediosTransporte
    {
        public string Medio { get; set; }
       
        public double Velocidad { get; set; }

        public List<CostoPorKilometro> CostoPorKilometro { get; set; }
        public VelocidadPorTemporada VelocidadPorTemporada { get; set; }
        public CostoAdicionalPorTemporada CostoAdicionalPorTemporada { get; set; }
        public RetrasoPorDiaPorTemporada RetrasoPorDiaPorTemporada { get; set; }
    }
}
