using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnviosAliExpressCore.Interfaces;

namespace EnviosAliExpressCore
{
    public class ValidadorPaqueteria : IValidarPaqueteria
    {
        public string ValidarPaqueteria(List<IEmpresa> lstEmpresas, string cPaqueteria,string[] Paqueterias)
        {
          
            string cMensaje = "";
            string cPaqueteriaF=Paqueterias.FirstOrDefault(x=>x==cPaqueteria);
            if (lstEmpresas == null || string.IsNullOrEmpty(cPaqueteria))
            {
                cMensaje= string.Format("La  Paquetería: {0} no se encuentra registrada en nuestra red de distribución.",cPaqueteria);
            }
            return cMensaje;
        }
    }
}
