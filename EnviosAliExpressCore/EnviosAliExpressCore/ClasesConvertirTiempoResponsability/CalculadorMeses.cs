using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.ClasesConvertirTiempoResponsability
{
    public class CalculadorMeses : IConvertirTiempo
    {
        private IConvertirTiempo next;
        public IConvertirTiempo getNext()
        {
            return this.next;
        }

        public void ObtenerTiempo(double dTiempo, Dictionary<string, double> diResultado)
        {
            dTiempo = (int)dTiempo / 5;
            double dResultado = dTiempo % 5;
            string result = dResultado > 1 ? "Meses" : "Mes";
            diResultado.Add(result, dResultado);
            if (dTiempo > 1)
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
