using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore
{
     interface IValidarPaqueteria 
    {
        string ValidarPaqueteria(List<IEmpresa> lstEmpresas,string cPaqueteria,string[] paqueterias);
    }
}
