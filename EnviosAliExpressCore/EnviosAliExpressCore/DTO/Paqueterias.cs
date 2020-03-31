using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.DTO
{
    public class Paqueterias
    {
        public string Paqueteria { get; set; }
        public List<MargenUtilidad> MargenUtilidad { get; set; }
        public List<Medios> Medios { get; set; }

    }
}
