using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EnviosAliExpressCore.Clases
{
    public class CalculadorMargenUtilidadCostoDHL : ICalculadorMargenUtilidadCosto
    {
        private readonly List<Periodos> lstperiodos;
        private readonly List<MargenUtilidad> lstMargenUtilidad;
        public CalculadorMargenUtilidadCostoDHL(List<Periodos> lstperiodos, List<MargenUtilidad> lstMargenUtilidad)
        {
            this.lstperiodos = lstperiodos;
            this.lstMargenUtilidad = lstMargenUtilidad;
        }

        public double ObtenerMargenUtilidadCosto(double dCosto, DateTime dtFechaPedido)
        {
            double dPorcentaje = ObtenerPorcentajePorEstacion(dtFechaPedido);
            double dCostoMargen = dCosto * ((dCosto * dPorcentaje) / 100);
            return dCostoMargen;
        }

        private double ObtenerPorcentajePorEstacion(DateTime dtFechaPedido)
        {
            DateTimeFormatInfo formatoFecha = CultureInfo.CurrentCulture.DateTimeFormat;
            string nombreMes = formatoFecha.GetMonthName(dtFechaPedido.Month);

            string cPeriodo = lstperiodos.Where(x => x.Meses.Contains(nombreMes)).Select(x => x.Periodo).FirstOrDefault();
            double Porcentaje = lstMargenUtilidad.Where(x => x.Periodo == cPeriodo).Select(i => i.Porcentaje).FirstOrDefault();
            return Porcentaje;
        }
    }
}
