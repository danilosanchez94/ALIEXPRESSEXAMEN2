using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnviosAliExpressCore
{
    public class Estacion : IObtenerEstacion
    {
        private readonly List<Temporadas> lstTemporadasConfig;
        public Estacion( List<Temporadas> lstTemporadasConfig) { 
            this.lstTemporadasConfig=lstTemporadasConfig;
        }

        public string ObtenerEstacion(DateTime dtFechaPedido)
        {
            string cEstacion = lstTemporadasConfig.Where(x =>   Convert.ToDateTime(x.Inicio)<= dtFechaPedido &&   Convert.ToDateTime(x.Fin)>= dtFechaPedido).Select(x=>x.Temporada).FirstOrDefault();
         
            return cEstacion;       
        }
    }
}
