using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Interfaces
{
    public interface ICalculadorMargenUtilidadCosto
    {
        double ObtenerMargenUtilidadCosto(double dCosto,DateTime dtFechaPedido);
    }
}
