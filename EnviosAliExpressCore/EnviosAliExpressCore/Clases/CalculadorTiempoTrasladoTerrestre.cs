using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnviosAliExpressCore
{
    public class CalculadorTiempoTrasladoTerrestre : ICalculadorTiempoTraslado
    {
        private readonly RetrasoPorDiaPorTemporada lstRetrasoPorDiaPorTemporada;
        private readonly IObtenerEstacion obtenerEstacion;
        public CalculadorTiempoTrasladoTerrestre(IObtenerEstacion obtenerEstacion, RetrasoPorDiaPorTemporada lstRetrasoPorDiaPorTemporada)
        {
            this.lstRetrasoPorDiaPorTemporada = lstRetrasoPorDiaPorTemporada;
            this.obtenerEstacion = obtenerEstacion;
        }
        public double CalcularTiempoTraslado(double dTiempoTraslado,DateTime dtFechaPedido)
        {
            string cEstacion = obtenerEstacion.ObtenerEstacion(dtFechaPedido);
            //
            double dVariacion = lstRetrasoPorDiaPorTemporada.TiemposRetraso.Where(i => i.Temporada.ToUpper() == cEstacion.ToUpper()).Select(i => i.Tiempo).FirstOrDefault();
            double dTiempoExtra = (dTiempoTraslado * dVariacion);
            return dTiempoExtra;
        }
    }
}
