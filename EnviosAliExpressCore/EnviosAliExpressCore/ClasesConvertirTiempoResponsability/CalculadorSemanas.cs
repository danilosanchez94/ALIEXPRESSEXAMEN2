
using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.ClasesConvertirTiempoResponsability
{
    public class CalculadorSemanas : IConvertirTiempo
    {
        private IConvertirTiempo next;
        public IConvertirTiempo getNext()
        {
            return this.next;
        }

        public void ObtenerTiempo(double dTiempo, Dictionary<string, double> diResultado)
        {
            dTiempo = (int)dTiempo / 6;
            double dResultado = dTiempo % 30;
            string result = dResultado > 1 ? "Días" : "Día";
            diResultado.Add(result, dResultado);
            if (dTiempo > 24)
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
