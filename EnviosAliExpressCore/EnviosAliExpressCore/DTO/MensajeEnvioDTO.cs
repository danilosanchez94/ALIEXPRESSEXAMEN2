using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.DTO
{
    public class MensajeEnvioDTO
    {
        public string cOrigen { get; set; }
        public string cDestino { get; set; }
        public string cExpresion1 { get; set; }
        public string cExpresion2 { get; set; }
        public string cExpresion3 { get; set; }
        public string cExpresion4 { get; set; }
        public string cRangoTiempo { get; set; }
        public string cCostoEnvio { get; set; }
        public string cPaqueteria { get; set; }
    }
}
