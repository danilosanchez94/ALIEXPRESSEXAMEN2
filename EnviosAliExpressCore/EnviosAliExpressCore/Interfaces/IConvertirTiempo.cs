using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Interfaces
{
    public interface IConvertirTiempo
    {
        void setNext(IConvertirTiempo iConvertirTiempo);
        IConvertirTiempo getNext();

        void ObtenerTiempo(double dTiempo, Dictionary<string,double> diResultado);
    }
}
