using EnviosAliExpress.ClasesMedioTransporte;
using EnviosAliExpressCore;
using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace EnviosAliExpressUTest
{
    [TestClass]
    public class CalculadorCostoEnvioTerrestreUTest
    {
        [TestMethod]
        public void CalculaCostoEnvioMaritimo_EstacionDistancia40_600()
        {
            //Arrange
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 40;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            List<RangosDTO> lstRangos = new List<RangosDTO>();
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1, iLimiteSuperior = 50, dCosto = 15 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 51, iLimiteSuperior = 200, dCosto = 10 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 201, iLimiteSuperior = 300, dCosto = 8 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 301, iLimiteSuperior = null, dCosto = 7 });
            var SUT = new CalculadorCostoEnvioTerrestre(lstRangos);

            //ACT
            var regreso = SUT.CalcularCostoEnvio(dtFechaPedido,dDistancia);

            //ASSERT
            Assert.AreEqual(600, regreso);

        }
        [TestMethod]
        public void CalculaCostoEnvioMaritimo_EstacionDistancia100_1000()
        {
            //Arrange
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 100;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            List<RangosDTO> lstRangos = new List<RangosDTO>();
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1, iLimiteSuperior = 50, dCosto = 15 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 51, iLimiteSuperior = 200, dCosto = 10 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 201, iLimiteSuperior = 300, dCosto = 8 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 301, iLimiteSuperior = null, dCosto = 7 });
            var SUT = new CalculadorCostoEnvioTerrestre(lstRangos);

            //ACT
            var regreso = SUT.CalcularCostoEnvio(dtFechaPedido, dDistancia);

            //ASSERT
            Assert.AreEqual(1000, regreso);

        }
        [TestMethod]
        public void CalculaCostoEnvioMaritimo_EstacionDistancia250_2000()
        {
            //Arrange
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 250;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            List<RangosDTO> lstRangos = new List<RangosDTO>();
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1, iLimiteSuperior = 50, dCosto = 15 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 51, iLimiteSuperior = 200, dCosto = 10 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 201, iLimiteSuperior = 300, dCosto = 8 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 301, iLimiteSuperior = null, dCosto = 7 });
            var SUT = new CalculadorCostoEnvioTerrestre(lstRangos);

            //ACT
            var regreso = SUT.CalcularCostoEnvio(dtFechaPedido, dDistancia);

            //ASSERT
            Assert.AreEqual(2000, regreso);

        }
        [TestMethod]
        public void CalculaCostoEnvioMaritimo_EstacionDistancia500_3500()
        {
            //Arrange
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 500;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            List<RangosDTO> lstRangos = new List<RangosDTO>();
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1, iLimiteSuperior = 50, dCosto = 15 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 51, iLimiteSuperior = 200, dCosto = 10 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 201, iLimiteSuperior = 300, dCosto = 8 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 301, iLimiteSuperior = null, dCosto = 7 });
            var SUT = new CalculadorCostoEnvioTerrestre(lstRangos);

            //ACT
            var regreso = SUT.CalcularCostoEnvio(dtFechaPedido, dDistancia);

            //ASSERT
            Assert.AreEqual(3500, regreso);

        }

    }
}
