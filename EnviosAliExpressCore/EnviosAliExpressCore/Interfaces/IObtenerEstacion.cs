using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Interfaces
{
    public interface IObtenerEstacion
    {
        string ObtenerEstacion(DateTime dtFechaPedido);
    }
}
