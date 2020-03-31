using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.DTO
{
    public class ParametrosDTO
    {
        public double dCosto { get; set; }
        public double dDistacia { get; set; }
        public decimal dMargenUtilidad { get; set; }
        public DateTime dtFechaPedido { get; set; }
        public int iHorasReparto { get; set; }
        public double dTiempoTraslado { get; set; }
        public double dTiempoReparto { get; set; }
        public double dVelocidad { get; set; }
        public List<RangosDTO> lstRangosDTO { get; set; }
        public string cMedioTransporte { get; set; }
        public string cPaqueteria { get; set; }
        public string cCiudadOrigen { get; set; }
        public string cPaisOrigen { get; set; }
        public string cCiudadDestino { get; set; }
        public string cPaisDestino { get; set; }
        public int iReparto { get; set; }
        public double dEntrega { get; set; }
        public double dCostoEnvio { get; set; }
        public DateTime dtFechaEntrega { get; set; }
        public double dPorcentaje { get; set; }
    }
}
