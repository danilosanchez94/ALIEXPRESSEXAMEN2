using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Interfaces
{
    public interface IObtenerVelocidadVariacion
    {
        double CalculadorVariacionVelocidad(DateTime dtFechaPedido, double dVelocidad);
    }
}
