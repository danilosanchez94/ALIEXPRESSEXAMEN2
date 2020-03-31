using EnviosAliExpressCore.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Interfaces
{
    public interface IMediosTransporte
    {
        double dVelocidadEntrega { get; }
        string cTipoMedioTransporte { get; }

        double CalculaTiempoTraslado(ParametrosDTO parametros);

        //DateTime CalculaFechaEntrega(ParametrosDTO parametros);

        double CalculaCostoEnvio(ParametrosDTO parametros);
    }
}
