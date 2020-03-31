using EnviosAliExpressCore.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Interfaces
{
    public interface IEmpresa
    {
        string cEmpresa { get; }


        double ObtenerCostoEnvio(ParametrosDTO parametros);
        double ObtenerTiempoEntrega(ParametrosDTO parametros);
        DateTime ObtenerFechaEntrega(ParametrosDTO parametros);
        ParametrosDTO ObtenerDatosPaqueteria(ParametrosDTO parametros);


    }
}
