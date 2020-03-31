using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviosAliExpress.ClasesMedioTransporte
{
    public class Maritimo : IMediosTransporte
    {
       
        private readonly IObtenerVelocidadVariacion obtenerVelocidadVariacion;
        private readonly ICalculadorCostoEnvio calculadorCostoEnvio;

        public Maritimo(IObtenerVelocidadVariacion obtenerVelocidadVariacion, ICalculadorCostoEnvio calculadorCostoEnvio)
        {
            this.obtenerVelocidadVariacion = obtenerVelocidadVariacion;
            this.calculadorCostoEnvio = calculadorCostoEnvio; //costo envio
        }

        public double dVelocidadEntrega => 46;

        public string cTipoMedioTransporte => "MARITIMO";

        public double CalculaCostoEnvio(ParametrosDTO parametros)
        {
            double dCostoEnvio = calculadorCostoEnvio.CalcularCostoEnvio(parametros.dtFechaPedido,parametros.dDistacia);//margen de utlidad aun le falta
            
            return dCostoEnvio;
        }


        public double CalculaTiempoTraslado(ParametrosDTO parametros)
        {
            double dTiempoTraslado = parametros.dDistacia / obtenerVelocidadVariacion.CalculadorVariacionVelocidad(parametros.dtFechaPedido,dVelocidadEntrega);
            return Math.Round(dTiempoTraslado,2);
        }

    }
}