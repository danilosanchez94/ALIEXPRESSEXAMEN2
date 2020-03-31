using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Interfaces
{
    public interface ICalculadorTiempoTraslado
    {
        double CalcularTiempoTraslado( double dTiempoTrasalado, DateTime dtFechaPedido);

    }
}

