using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviosAliExpress.ClasesMedioTransporte
{
    public class Terrestre : IMediosTransporte
    {
        private readonly ICalculadorCostoEnvio calculadorCostoEnvio;
        private readonly ICalculadorTiempoTraslado calculadorTiempoTraslado;

        public Terrestre( ICalculadorCostoEnvio calculadorCostoEnvio, ICalculadorTiempoTraslado calculadorTiempoTraslado)
        {
            this.calculadorTiempoTraslado = calculadorTiempoTraslado;
            this.calculadorCostoEnvio = calculadorCostoEnvio; //costo envio
        }
        public double dVelocidadEntrega => 80;


        string IMediosTransporte.cTipoMedioTransporte => "TERRESTRE";

        public double CalculaCostoEnvio(ParametrosDTO parametros)
        {
            parametros.dCostoEnvio = calculadorCostoEnvio.CalcularCostoEnvio(parametros.dtFechaPedido, parametros.dDistacia);//margen de utlidad aun le falta

            return parametros.dCostoEnvio;
        }


        public double CalculaTiempoTraslado(ParametrosDTO parametros)
        {
            double dTiempoTraslado = parametros.dDistacia /  dVelocidadEntrega;
            double dTiempoTrasladoExtra = calculadorTiempoTraslado.CalcularTiempoTraslado(dTiempoTraslado,parametros.dtFechaPedido);
            double dTiempoTrasladoFinal = dTiempoTraslado + dTiempoTrasladoExtra;
            return Math.Round(dTiempoTrasladoFinal, 2);
        }


    }
}
