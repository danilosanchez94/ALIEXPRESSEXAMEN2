using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Clases
{
    public class EvaluadorEstrategiaFormatearMensajeEnvio : IEvaluadorEstrategiaFormatearMensajeEnvio
    {
        public string ObtenerClaveEstrategia(DateTime dtFechaEntrega)
        {
            if (dtFechaEntrega == null)
                throw new ArgumentNullException("Fecha Incorrecta");
            string cClaveEstrategia = "";
            var dtFechaHoy = DateTime.Now;
            if (dtFechaEntrega < dtFechaHoy)
                cClaveEstrategia = "PASADO";
            else
                cClaveEstrategia = "FUTURO";

            return cClaveEstrategia;
        }
    }
}
