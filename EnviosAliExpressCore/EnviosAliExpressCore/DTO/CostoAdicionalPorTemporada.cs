using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.DTO
{
    public class CostoAdicionalPorTemporada
    {
        public string Aplicar { get; set; }
        public List<Variaciones> Variaciones { get; set; }
    }
}
