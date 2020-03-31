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
    public class MaritimoUTest
    {
        [TestMethod]
        public void CalculaCostoEnvio_EstacionInviernoDistancia1200_442()
        {
            //Arrange
            var DOCcalculadorCostoPorDistancia = new Mock<ICalculadorCostoEnvio>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCcalculadorCostoPorDistancia.Setup(doc => doc.CalcularCostoEnvio(dtFechaPedido, parametros.dDistacia)).Returns(442);

            var SUT = new Maritimo(DOCobtenerVelocidadVariacion.Object, DOCcalculadorCostoPorDistancia.Object);

            //ACT
            var regreso = SUT.CalculaCostoEnvio(parametros);

            //ASSERT
            Assert.AreEqual(442, regreso);

        }

        [TestMethod]
        public void CalculaCostoEnvio_EstacionPrimaveraDistancia1200_360()
        {
            //Arrange
            var DOCcalculadorCostoPorDistancia = new Mock<ICalculadorCostoEnvio>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 03, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCcalculadorCostoPorDistancia.Setup(doc => doc.CalcularCostoEnvio(dtFechaPedido, parametros.dDistacia)).Returns(360);

            var SUT = new Maritimo(DOCobtenerVelocidadVariacion.Object, DOCcalculadorCostoPorDistancia.Object);

            //ACT
            var regreso = SUT.CalculaCostoEnvio(parametros);

            //ASSERT
            Assert.AreEqual(360, regreso);

        }

        [TestMethod]
        public void CalculaCostoEnvio_EstacionVeranoDistancia1200_396()
        {
            //Arrange
            var DOCcalculadorCostoPorDistancia = new Mock<ICalculadorCostoEnvio>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 06, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCcalculadorCostoPorDistancia.Setup(doc => doc.CalcularCostoEnvio(dtFechaPedido, parametros.dDistacia)).Returns(396);

            var SUT = new Maritimo(DOCobtenerVelocidadVariacion.Object, DOCcalculadorCostoPorDistancia.Object);

            //ACT
            var regreso = Math.Round(SUT.CalculaCostoEnvio(parametros),2);

            //ASSERT
            Assert.AreEqual(396.00, regreso);

        }

        [TestMethod]
        public void CalculaCostoEnvio_EstacionOTonioDistancia1200_396()
        {
            //Arrange
            var DOCcalculadorCostoPorDistancia = new Mock<ICalculadorCostoEnvio>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 10, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCcalculadorCostoPorDistancia.Setup(doc => doc.CalcularCostoEnvio(dtFechaPedido, parametros.dDistacia)).Returns(414);

            var SUT = new Maritimo(DOCobtenerVelocidadVariacion.Object, DOCcalculadorCostoPorDistancia.Object);

            //ACT
            var regreso = Math.Round(SUT.CalculaCostoEnvio(parametros), 2);

            //ASSERT
            Assert.AreEqual(414, regreso);

        }

        [TestMethod]
        public void CalculaCalculaTiempoTraslado_InviernoDistancia1200_37()
        {
            //Arrange
            var DOCcalculadorCostoPorDistancia = new Mock<ICalculadorCostoEnvio>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 1200;
            double dVelocidadEntrega = 46;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCobtenerVelocidadVariacion.Setup(doc => doc.CalculadorVariacionVelocidad(dtFechaPedido, dVelocidadEntrega)).Returns(32.2);

            var SUT = new Maritimo(DOCobtenerVelocidadVariacion.Object, DOCcalculadorCostoPorDistancia.Object);

            //ACT
            var regreso = Math.Round(SUT.CalculaTiempoTraslado(parametros));

            //ASSERT
            Assert.AreEqual(37, regreso);

        }

        [TestMethod]
        public void CalculaCalculaTiempoTraslado_PrimaveraDistancia1200_26punto08()
        {
            //Arrange
            var DOCcalculadorCostoPorDistancia = new Mock<ICalculadorCostoEnvio>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 03, 22);
            double dDistancia = 1200;
            double dVelocidadEntrega = 46;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCobtenerVelocidadVariacion.Setup(doc => doc.CalculadorVariacionVelocidad(dtFechaPedido, dVelocidadEntrega)).Returns(46);

            var SUT = new Maritimo(DOCobtenerVelocidadVariacion.Object, DOCcalculadorCostoPorDistancia.Object);

            //ACT
            var regreso = Math.Round(SUT.CalculaTiempoTraslado(parametros),2);

            //ASSERT
            Assert.AreEqual(26.09, regreso);

        }
        [TestMethod]
        public void CalculaCalculaTiempoTraslado_VeranoDistancia1200_28punto98()
        {
            //Arrange
            var DOCcalculadorCostoPorDistancia = new Mock<ICalculadorCostoEnvio>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 06, 22);
            double dDistancia = 1200;
            double dVelocidadEntrega = 46;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCobtenerVelocidadVariacion.Setup(doc => doc.CalculadorVariacionVelocidad(dtFechaPedido, dVelocidadEntrega)).Returns(41.4);

            var SUT = new Maritimo(DOCobtenerVelocidadVariacion.Object, DOCcalculadorCostoPorDistancia.Object);

            //ACT
            var regreso = Math.Round(SUT.CalculaTiempoTraslado(parametros), 2);

            //ASSERT
            Assert.AreEqual(28.99, regreso);

        }
        [TestMethod]
        public void CalculaCalculaTiempoTraslado_Otonioistancia1200_22punto68()
        {
            //Arrange
            var DOCcalculadorCostoPorDistancia = new Mock<ICalculadorCostoEnvio>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 09, 22);
            double dDistancia = 1200;
            double dVelocidadEntrega = 46;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCobtenerVelocidadVariacion.Setup(doc => doc.CalculadorVariacionVelocidad(dtFechaPedido, dVelocidadEntrega)).Returns(52.9);

            var SUT = new Maritimo(DOCobtenerVelocidadVariacion.Object, DOCcalculadorCostoPorDistancia.Object);

            //ACT
            var regreso = Math.Round(SUT.CalculaTiempoTraslado(parametros), 2);

            //ASSERT
            Assert.AreEqual(22.68, regreso);

        }
    }
}
