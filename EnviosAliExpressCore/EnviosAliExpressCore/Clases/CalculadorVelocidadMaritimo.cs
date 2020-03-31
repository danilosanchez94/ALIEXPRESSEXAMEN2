using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EnviosAliExpressCore
{
    public class CalculadorVelocidadMaritimo: IObtenerVelocidadVariacion
    {


        private readonly VelocidadPorTemporada lstVelocidadPorTemporada;
        private readonly IObtenerEstacion obtenerEstacion;
        public CalculadorVelocidadMaritimo(VelocidadPorTemporada lstVelocidadPorTemporada, IObtenerEstacion obtenerEstacion)
        {
            this.lstVelocidadPorTemporada = lstVelocidadPorTemporada;
            this.obtenerEstacion = obtenerEstacion;
        }
        public double CalculadorVariacionVelocidad(DateTime dtFechaPedido, double dVelocidad)
        {
            string cEstacion = obtenerEstacion.ObtenerEstacion(dtFechaPedido);
            double dVariacion = lstVelocidadPorTemporada.Variaciones.Where(i=>i.Temporada.ToUpper() == cEstacion.ToUpper()).Select(i=>i.Porcentaje).FirstOrDefault();
            double dVariacionVelocidad= dVelocidad +  (dVelocidad * dVariacion);
            return dVariacionVelocidad;
        }


    }
}
