using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Interfaces
{
    public interface ICalculadorCostoEnvio
    {
        double CalcularCostoEnvio(DateTime dtFechaPedido, double dDistancia);
    }
}
