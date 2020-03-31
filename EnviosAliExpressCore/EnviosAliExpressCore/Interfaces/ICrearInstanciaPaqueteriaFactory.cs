using EnviosAliExpressCore.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Interfaces
{
    public interface ICrearInstanciaPaqueteriaFactory
    {
        List<IEmpresa> CrearInstancia(string cClave ,List<Configuracion> configuracion);
    }
}
