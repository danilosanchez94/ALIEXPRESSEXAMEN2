using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Interfaces
{
    public interface IValidarMedioTransporte
    {
        string ValidarMedioTransporte(List<IEmpresa> lstEmpresas, string cPaqueteria, string cMedioTransporte);
    }
}
