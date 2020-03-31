using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.ClasesConvertirTiempoResponsability
{
    class CalculadorMinutos : IConvertirTiempo
    {
        private IConvertirTiempo next;
        public IConvertirTiempo getNext()
        {
            return this.next;
        }

        public void ObtenerTiempo(double dTiempo, Dictionary<string, double> diResultado)
        {
            double dResultado = dTiempo % 60;
            dTiempo = dTiempo - (dResultado);
            diResultado.Add("minutos",dResultado);
            if (dTiempo > 59)
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
