using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnviosAliExpressCore.Clases
{
    public class ValidadorMedioTransporte : IValidarMedioTransporte
    {
        public string ValidarMedioTransporte(List<IEmpresa> lstEmpresas, string cPaqueteria,string cMedioTransporte)
        {
            string cMensaje = "";
            if (lstEmpresas==null || lstEmpresas.Where(c=>c.cEmpresa==cPaqueteria).Select(c=>c).ToList().FirstOrDefault()==null)
            {
                cMensaje= string.Format("{0} no ofrece el servicio de transporte {1}, te recomendamos cotizar en otra empresa.",cPaqueteria,cMedioTransporte);
            }
            return cMensaje;
        }
    }
}
