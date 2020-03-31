using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EnviosAliExpressCore.Clases
{
    public class CalculadorMargenUtilidadCostoEstafeta : ICalculadorMargenUtilidadCosto
    {
        private readonly List<Periodos> lstperiodos;
        private readonly List<MargenUtilidad> lstMargenUtilidad;
        public CalculadorMargenUtilidadCostoEstafeta(List<Periodos> lstperiodos, List<MargenUtilidad> lstMargenUtilidad)
        {
            this.lstperiodos = lstperiodos;
            this.lstMargenUtilidad = lstMargenUtilidad;
        }

        public double ObtenerMargenUtilidadCosto(double dCosto, DateTime dtFechaPedido)
        {
            
            double dValorMargen = ObtenerPorcentajePorEstacion(dtFechaPedido);
            double dCostoMargen = dValorMargen*dCosto;
            return dCostoMargen;
        }


        private double ObtenerPorcentajePorEstacion(DateTime dtFechaPedido)
        {
            DateTimeFormatInfo formatoFecha = CultureInfo.CurrentCulture.DateTimeFormat;
            string nombreMes = formatoFecha.GetMonthName(dtFechaPedido.Month);
            string cDia = lstperiodos.Where(x => x.Dias.Contains(nombreMes) && x.Dias.Contains(dtFechaPedido.Day.ToString())).Select(x => x.Periodo).FirstOrDefault();
            string cPeriodo = lstperiodos.Where(x => x.Meses.Contains(nombreMes)).Select(x => x.Periodo).FirstOrDefault();
            string cClave = cDia!=""?cDia:cPeriodo;

            double Porcentaje = lstMargenUtilidad.Where(x => x.Periodo == cClave).Select(i => i.Porcentaje).FirstOrDefault();
            return Porcentaje;
        }
    }
}
