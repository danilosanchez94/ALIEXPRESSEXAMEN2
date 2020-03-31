using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore
{
    public class CalculadorEscalas : ICalculadorEscalas
    {
        public double ObtenerEscalas(double dDistancia)
        {
            double dEscala = 0;
            if (dDistancia >= 1000)
            {
                dEscala = dDistancia / 1000;                
            }
            return dEscala;
        }
    }
}
