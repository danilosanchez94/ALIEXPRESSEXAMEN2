using EnviosAliExpressCore.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Interfaces
{
    public interface IMensajeEnvio
    {
        string cConjugacion { get;}
        MensajeEnvioDTO ObtenerMensajeEnvio(Dictionary<string, double> diTiempos, ParametrosDTO parametros);

        MensajesColoresDTO FormatearMensaje(Dictionary<string, double> diTiempos, ParametrosDTO parametros);
    }
}
