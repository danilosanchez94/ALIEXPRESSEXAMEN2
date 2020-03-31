using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnviosAliExpressCore
{
    public class CalculadorCostoEnvioTerrestre : ICalculadorCostoEnvio
    {

        private readonly List<CostoPorKilometro> lstCostoPorKm;
        public CalculadorCostoEnvioTerrestre(List<CostoPorKilometro> lstCostoPorKm)
        {

            this.lstCostoPorKm = lstCostoPorKm;

        }

        public double CalcularCostoEnvio(DateTime dtFechaPedido, double dDistancia)
        {
            double dCosto = lstCostoPorKm.Where(x => dDistancia >= x.inicio && (dDistancia <= x.fin || x.fin == null)).Select(i => i.costo).FirstOrDefault();
            double dCostoEnvio = dDistancia * dCosto;
            return dCostoEnvio;
        }
    }
}
