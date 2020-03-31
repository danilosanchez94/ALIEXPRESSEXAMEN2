using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.DTO
{
    public class Configuracion
    {
        public List<Temporadas> temporadas { get; set; }
        public List<MediosTransporte> mediosTransporte { get; set; }
        public List<Periodos> Periodos { get; set; }
        public List<Paqueterias> paqueterias { get; set; }
    }
}
