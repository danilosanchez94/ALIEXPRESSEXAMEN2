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
    public class AereoUTest
    {
        [TestMethod]
        public void CalculaCostoEnvio_1Escala_12200()
        {
            //Arrange
            var DOCcalculadorEscalas = new Mock<ICalculadorEscalas>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCcalculadorEscalas.Setup(doc => doc.ObtenerEscalas(dDistancia)).Returns(1);

            var SUT = new Aereo(DOCcalculadorEscalas.Object);

            //ACT
            var regreso = SUT.CalculaCostoEnvio(parametros);

            //ASSERT
            Assert.AreEqual(12200, regreso);

        }

        public void CalculaCalculaTiempoTraslado_1Escala_6()
        {
            var DOCcalculadorEscalas = new Mock<ICalculadorEscalas>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCcalculadorEscalas.Setup(doc => doc.ObtenerEscalas(dDistancia)).Returns(1);

            var SUT = new Aereo(DOCcalculadorEscalas.Object);

            //ACT
            var regreso = SUT.CalculaTiempoTraslado(parametros);

            //ASSERT
            Assert.AreEqual(6, regreso);

        }
    }
}
