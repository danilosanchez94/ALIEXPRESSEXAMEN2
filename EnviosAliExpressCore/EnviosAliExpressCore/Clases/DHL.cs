using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnviosAliExpressCore.Clases
{
    public class DHL :IEmpresa
    {
        private readonly IMediosTransporte medioTransporte;
        private readonly ICalculadorMargenUtilidadCosto CalculadorMargenUtilidadCosto;
        private readonly List<Medios> lstMedios;
        private readonly ParametrosDTO parametrosFinal;
        public DHL(IMediosTransporte medioTransporte, ICalculadorMargenUtilidadCosto CalculadorMargenUtilidadCosto, List<Medios> lstMedios, ParametrosDTO parametrosFinal)
        {
            this.medioTransporte = medioTransporte;
            this.CalculadorMargenUtilidadCosto = CalculadorMargenUtilidadCosto;
            this.lstMedios = lstMedios;
            this.parametrosFinal = parametrosFinal;
      
        }

        public string cEmpresa => "DHL";

        public double ObtenerCostoEnvio(ParametrosDTO parametros)
        {
            double dCostoEnvio = medioTransporte.CalculaCostoEnvio(parametros);
            double dCostoEnvioMarge = CalculadorMargenUtilidadCosto.ObtenerMargenUtilidadCosto(dCostoEnvio, parametros.dtFechaPedido);

            return dCostoEnvioMarge;
        }

        public double ObtenerTiempoEntrega(ParametrosDTO parametros)
        {
            double dTiempoTraslado = medioTransporte.CalculaTiempoTraslado(parametros);
            double dTiempoReparto = dTiempoTraslado + lstMedios.Where(i => i.Medio == medioTransporte.cTipoMedioTransporte).Select(i => i.TiempoRepartoHRS).FirstOrDefault();
            return dTiempoReparto;
        }

        public ParametrosDTO ObtenerDatosPaqueteria(ParametrosDTO parametros)
        {
            parametrosFinal.dCostoEnvio = ObtenerCostoEnvio(parametros);
            parametrosFinal.cCiudadDestino = parametros.cCiudadDestino;
            parametrosFinal.cPaisDestino = parametros.cPaisDestino;
            parametrosFinal.cCiudadOrigen = parametros.cCiudadOrigen;
            parametrosFinal.cPaisOrigen = parametros.cPaisOrigen;
            parametrosFinal.dtFechaEntrega = ObtenerFechaEntrega(parametros);
            parametrosFinal.cPaqueteria = cEmpresa;


            return parametrosFinal;

        }

        public DateTime ObtenerFechaEntrega(ParametrosDTO parametros)
        {
            DateTime dtFechaEntrega = parametros.dtFechaPedido.AddHours(ObtenerTiempoEntrega(parametros));
            return dtFechaEntrega;
        }
    }
}
