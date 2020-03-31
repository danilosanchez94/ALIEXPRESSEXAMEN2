using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnviosAliExpressCore
{
    public class CalculadorCostoEnvioMaritimo : ICalculadorCostoEnvio
    {
        private readonly CostoAdicionalPorTemporada lstCostoAdicionalPorTemporada;
        private readonly List<CostoPorKilometro> lstCostoPorKm;
        private readonly IObtenerEstacion obtenerEstacion;
        public CalculadorCostoEnvioMaritimo(CostoAdicionalPorTemporada lstCostoAdicionalPorTemporada, List<CostoPorKilometro> lstCostoPorKm, IObtenerEstacion obtenerEstacion)
        {
            this.lstCostoAdicionalPorTemporada = lstCostoAdicionalPorTemporada;

            this.obtenerEstacion = obtenerEstacion;

            this.lstCostoPorKm = lstCostoPorKm;


        }

        public double CalcularCostoEnvio(DateTime dtFechaPedido, double dDistancia)
        {
            string cEstacion = obtenerEstacion.ObtenerEstacion(dtFechaPedido);
            double dVariacion = lstCostoAdicionalPorTemporada.Variaciones.Where(i => i.Temporada.ToUpper() == cEstacion.ToUpper()).Select(i => i.Porcentaje).FirstOrDefault();
            double dCosto = lstCostoPorKm.Where(x=>dDistancia>=x.inicio && (dDistancia<=x.fin || x.fin==null)).Select(i=>i.costo).FirstOrDefault();
            double dCostoEnvioAux = dDistancia * dCosto;
            double dCostoEnvio = dCostoEnvioAux * dVariacion;
            return dCostoEnvio;
        }

    }
}
