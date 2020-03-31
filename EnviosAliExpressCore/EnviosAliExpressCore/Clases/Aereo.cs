using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EnviosAliExpress.ClasesMedioTransporte
{
    public class Aereo : IMediosTransporte
    {
        private readonly ICalculadorEscalas calculadorEscalas;
        public Aereo(ICalculadorEscalas calculadorEscalas)
        {
            this.calculadorEscalas = calculadorEscalas;
        }
        public double dVelocidadEntrega => 600;

        public string cTipoMedioTransporte => "AEREO";

        public double CalculaCostoEnvio(ParametrosDTO parametros)
        {
            double dCargoExtra =  calculadorEscalas.ObtenerEscalas(parametros.dDistacia)*200;
            double dCostoEnvio =  (parametros.dDistacia * 10)+dCargoExtra;

            return dCostoEnvio;
        }
 
        public double CalculaTiempoTraslado(ParametrosDTO parametros)
        {
            double dTiempoExtra = 0;
            double dEscala = calculadorEscalas.ObtenerEscalas(parametros.dDistacia);
            if (dEscala > 0)
            {
                dTiempoExtra = Math.Truncate(dEscala) * 6;
            }
           
            return dTiempoExtra;
        }

    }
}
