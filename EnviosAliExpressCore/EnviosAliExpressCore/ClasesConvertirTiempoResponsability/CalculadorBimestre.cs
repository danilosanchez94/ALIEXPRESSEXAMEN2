using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.ClasesConvertirTiempoResponsability
{
    public class CalculadorBimestre : IConvertirTiempo
    {
        private IConvertirTiempo next;
        public IConvertirTiempo getNext()
        {
            return this.next;
        }

        public void ObtenerTiempo(double dTiempo, Dictionary<string, double> diResultado)
        {
            dTiempo = (int)dTiempo / 2;
            double dResultado = dTiempo % 2;
            string result = dResultado > 1 ? "Bimestre" : "Bismestres";
            diResultado.Add(result, dResultado);
            if (dTiempo > 6)
            {
                next.ObtenerTiempo(dTiempo, diResultado);
            }
            //if (dTiempo > 1)
            //{
            //    double dResultado = (int)dTiempo / 30;
            //    string result= dResultado > 1?"Meses":"Mes";
            //    diResultado.Add(result, dResultado);
            //}
        }

        public void setNext(IConvertirTiempo iConvertirTiempo)
        {
            this.next = iConvertirTiempo;
        }
    }
}
