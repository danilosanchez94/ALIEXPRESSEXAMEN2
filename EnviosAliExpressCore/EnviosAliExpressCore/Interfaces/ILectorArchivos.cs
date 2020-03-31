using EnviosAliExpressCore.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Interfaces
{
    public interface ILectorArchivos
    {
        string cTipoArchivo { get; }
        List<ParametrosDTO> ObtenerDatosDTO();

    }
}
