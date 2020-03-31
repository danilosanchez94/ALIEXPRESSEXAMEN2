using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Interfaces
{
    public interface ITarifaDistancia
    {

        string cMedioTransporte { get; }
        int iInicio { get; }
        int iFin { get; }
        decimal dCosto { get; }
    }
}
