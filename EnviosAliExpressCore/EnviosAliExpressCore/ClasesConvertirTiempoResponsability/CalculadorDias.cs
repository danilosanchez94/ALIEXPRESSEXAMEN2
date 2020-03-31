using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.ClasesConvertirTiempoResponsability
{
    public class CalculadorDias : IConvertirTiempo
    {
        private IConvertirTiempo next;
        public IConvertirTiempo getNext()
        {
            return this.next;
        }

        public void ObtenerTiempo(double dTiempo, Dictionary<string, double> diResultado)
        {
            dTiempo = (int)dTiempo / 24;
            double dResultado = dTiempo % 6;
            string result = dResultado > 1 ? "Semanas" : "Semana";
            diResultado.Add(result,dResultado);
            if (dTiempo > 6)
            {
                next.ObtenerTiempo(dTiempo, diResultado);
            }
        }

 

        public void setNext(IConvertirTiempo iConvertirTiempo)
        {
            this.next = iConvertirTiempo;
        }
    }
}
