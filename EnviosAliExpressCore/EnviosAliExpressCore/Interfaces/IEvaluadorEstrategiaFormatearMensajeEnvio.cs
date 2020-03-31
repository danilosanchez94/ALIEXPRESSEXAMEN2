using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Interfaces
{
    public interface IEvaluadorEstrategiaFormatearMensajeEnvio
    {
        string ObtenerClaveEstrategia(DateTime dtFechaPedido);
    }
}
