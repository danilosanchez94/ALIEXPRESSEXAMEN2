using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.DTO
{
    public class Temporadas
    {
        public int ID { get; set; }
        public string Temporada { get; set; }
        public string Inicio { get; set; }
        public string Fin { get; set; }
        public DateTime dtInicio { get; set; }
        public DateTime dtFin { get; set; }
       
    }
}
