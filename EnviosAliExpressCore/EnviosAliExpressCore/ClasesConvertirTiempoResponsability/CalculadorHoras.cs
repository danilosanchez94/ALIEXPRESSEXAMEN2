using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.ClasesConvertirTiempoResponsability
{
    public class CalculadorHoras : IConvertirTiempo
    {
        private IConvertirTiempo next;
        public IConvertirTiempo getNext()
        {
            return this.next;
        }

        public void ObtenerTiempo(double dTiempo, Dictionary<string, double> diResultado)
        {
            dTiempo = (int)dTiempo / 60;
            double dResultado = dTiempo % 24;//validar si hay que multiplicar por 24
            string result = dResultado > 1 ? "Horas" : "Hora";
            diResultado.Add(result,dResultado);
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
