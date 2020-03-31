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
    public class CalculadorVelocidadMaritimoUTest
    {
        [TestMethod]
        public void CalculadorVelocidadMaritimo_EstacionInviernoVelocidadEntrega46_32punto2()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dVelocidad = 46;
    
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(2)).Returns("INVIERNO");

            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 0 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = -0.1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 0.15 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = -0.30 });
            var SUT = new CalculadorVelocidadMaritimo(lstEstaciones,DOCObtenerEstacion.Object );

            //ACT
            var regreso = SUT.CalculadorVariacionVelocidad(dtFechaPedido, dVelocidad);

            //ASSERT
            Assert.AreEqual(32.2, regreso);

        }
        [TestMethod]
        public void CalculadorVelocidadMaritimo_EstacionPrimaveraVelocidadEntrega46_46()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            DateTime dtFechaPedido = new DateTime(2020, 03, 22);
            double dVelocidad = 46;

            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(3)).Returns("PRIMAVERA");

            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 0 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = -0.1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 0.15 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = -0.30 });
            var SUT = new CalculadorVelocidadMaritimo(lstEstaciones, DOCObtenerEstacion.Object);

            //ACT
            var regreso = SUT.CalculadorVariacionVelocidad(dtFechaPedido, dVelocidad);

            //ASSERT
            Assert.AreEqual(46, regreso);

        }
        [TestMethod]
        public void CalculadorVelocidadMaritimo_EstacionVeranoVelocidadEntrega46_41punto4()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            DateTime dtFechaPedido = new DateTime(2020, 07, 22);
            double dVelocidad = 46;

            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(7)).Returns("VERANO");

            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 0 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = -0.1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 0.15 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = -0.30 });
            var SUT = new CalculadorVelocidadMaritimo(lstEstaciones, DOCObtenerEstacion.Object);

            //ACT
            var regreso = SUT.CalculadorVariacionVelocidad(dtFechaPedido, dVelocidad);

            //ASSERT
            Assert.AreEqual(41.4, regreso);

        }
        [TestMethod]
        public void CalculadorVelocidadMaritimo_EstacionOtonioVelocidadEntrega46_52punto9()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            DateTime dtFechaPedido = new DateTime(2020, 09, 22);
            double dVelocidad = 46;

            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(9)).Returns("OTONIO");

            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 0 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = -0.1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 0.15 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = -0.30 });
            var SUT = new CalculadorVelocidadMaritimo(lstEstaciones, DOCObtenerEstacion.Object);

            //ACT
            var regreso = SUT.CalculadorVariacionVelocidad(dtFechaPedido, dVelocidad);

            //ASSERT
            Assert.AreEqual(52.9, regreso);

        }
    }
}
