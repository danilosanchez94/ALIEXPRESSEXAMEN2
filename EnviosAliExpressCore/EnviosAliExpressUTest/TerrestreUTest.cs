using EnviosAliExpress.ClasesMedioTransporte;
using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace EnviosAliExpressUTest
{
    [TestClass]
    public class TerrestreUTest
    {
        [TestMethod]
        public void CalculaCostoEnvio_EstacionDistancia40_600()
        {
            //Arrange
            var DOCcalculadorCostoPorDistancia = new Mock<ICalculadorCostoEnvio>();
            var DOCcalculadorTiempoTraslado = new Mock<ICalculadorTiempoTraslado>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCcalculadorCostoPorDistancia.Setup(doc => doc.CalcularCostoEnvio(dtFechaPedido, parametros.dDistacia)).Returns(600);

            var SUT = new Terrestre(DOCcalculadorCostoPorDistancia.Object, DOCcalculadorTiempoTraslado.Object);

            //ACT
            var regreso = SUT.CalculaCostoEnvio(parametros);

            //ASSERT
            Assert.AreEqual(600, regreso);

        }

        [TestMethod]
        public void CalculaCostoEnvio_EstacionDistancia100_1000()
        {
            //Arrange
            var DOCcalculadorCostoPorDistancia = new Mock<ICalculadorCostoEnvio>();
            var DOCcalculadorTiempoTraslado = new Mock<ICalculadorTiempoTraslado>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCcalculadorCostoPorDistancia.Setup(doc => doc.CalcularCostoEnvio(dtFechaPedido, parametros.dDistacia)).Returns(600);

            var SUT = new Terrestre(DOCcalculadorCostoPorDistancia.Object, DOCcalculadorTiempoTraslado.Object);

            //ACT
            var regreso = SUT.CalculaCostoEnvio(parametros);

            //ASSERT
            Assert.AreEqual(600, regreso);

        }
        [TestMethod]
        public void CalculaCostoEnvio_EstacionDistancia250_2000()
        {
            //Arrange
            var DOCcalculadorCostoPorDistancia = new Mock<ICalculadorCostoEnvio>();
            var DOCcalculadorTiempoTraslado = new Mock<ICalculadorTiempoTraslado>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCcalculadorCostoPorDistancia.Setup(doc => doc.CalcularCostoEnvio(dtFechaPedido, parametros.dDistacia)).Returns(2000);

            var SUT = new Terrestre(DOCcalculadorCostoPorDistancia.Object, DOCcalculadorTiempoTraslado.Object);

            //ACT
            var regreso = SUT.CalculaCostoEnvio(parametros);

            //ASSERT
            Assert.AreEqual(2000, regreso);

        }
        [TestMethod]
        public void CalculaCostoEnvio_EstacionDistancia500_3500()
        {
            //Arrange
            var DOCcalculadorCostoPorDistancia = new Mock<ICalculadorCostoEnvio>();
            var DOCcalculadorTiempoTraslado = new Mock<ICalculadorTiempoTraslado>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCcalculadorCostoPorDistancia.Setup(doc => doc.CalcularCostoEnvio(dtFechaPedido, parametros.dDistacia)).Returns(3500);

            var SUT = new Terrestre(DOCcalculadorCostoPorDistancia.Object, DOCcalculadorTiempoTraslado.Object);

            //ACT
            var regreso = SUT.CalculaCostoEnvio(parametros);

            //ASSERT
            Assert.AreEqual(3500, regreso);

        }
        [TestMethod]
        public void CalculaTiempoTraslado_distancia1200_20()
        {
            //Arrange
            var DOCcalculadorCostoPorDistancia = new Mock<ICalculadorCostoEnvio>();
            var DOCcalculadorTiempoTraslado = new Mock<ICalculadorTiempoTraslado>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            parametros.dTiempoTraslado = 15;
            DOCcalculadorTiempoTraslado.Setup(doc => doc.CalcularTiempoTraslado(15, dtFechaPedido)).Returns(5);

            var SUT = new Terrestre(DOCcalculadorCostoPorDistancia.Object, DOCcalculadorTiempoTraslado.Object);

            //ACT
            var regreso = SUT.CalculaTiempoTraslado(parametros);

            //ASSERT
            Assert.AreEqual(20, regreso);

        }
    }
}
