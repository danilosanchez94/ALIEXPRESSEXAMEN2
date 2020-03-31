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
    public class CalculadorCostoEnvioMaritimoUTest
    {
        [TestMethod]
        public void CalculaCostoEnvioMaritimo_EstacionInviernoDistancia1200_442()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(2)).Returns("INVIERNO");
            //DOCobtenerVelocidadVariacion.Setup(doc=>doc.CalculadorVariacionVelocidad(dtFechaPedido,));
            List<RangosDTO> lstRangos = new List<RangosDTO>(); 
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1, iLimiteSuperior = 100, dCosto = 1 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 101, iLimiteSuperior = 1000, dCosto = 0.5 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1001, iLimiteSuperior = null, dCosto = 0.3 });
            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = 1.1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 1.15 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = 1.23 });
            var SUT = new CalculadorCostoEnvioMaritimo(lstEstaciones,lstRangos,DOCObtenerEstacion.Object );

            //ACT
            var regreso = SUT.CalcularCostoEnvio(dtFechaPedido,dDistancia);

            //ASSERT
            Assert.AreEqual(442.8, regreso);

        }
        [TestMethod]
        public void CalculaCostoEnvioMaritimo_EstacionPrimaveraDistancia1200_360()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 03, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(3)).Returns("PRIMAVERA");
            //DOCobtenerVelocidadVariacion.Setup(doc=>doc.CalculadorVariacionVelocidad(dtFechaPedido,));
            List<RangosDTO> lstRangos = new List<RangosDTO>();
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1, iLimiteSuperior = 100, dCosto = 1 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 101, iLimiteSuperior = 1000, dCosto = 0.5 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1001, iLimiteSuperior = null, dCosto = 0.3 });
            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = 1.1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 1.15 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = 1.23 });
            var SUT = new CalculadorCostoEnvioMaritimo(lstEstaciones, lstRangos, DOCObtenerEstacion.Object);

            //ACT
            var regreso = SUT.CalcularCostoEnvio(dtFechaPedido, dDistancia);

            //ASSERT
            Assert.AreEqual(360, regreso);

        }
        [TestMethod]
        public void CalculaCostoEnvioMaritimo_EstacionVeranoDistancia1200_396()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 06, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(dtFechaPedido.Month)).Returns("VERANO");
            //DOCobtenerVelocidadVariacion.Setup(doc=>doc.CalculadorVariacionVelocidad(dtFechaPedido,));
            List<RangosDTO> lstRangos = new List<RangosDTO>();
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1, iLimiteSuperior = 100, dCosto = 1 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 101, iLimiteSuperior = 1000, dCosto = 0.5 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1001, iLimiteSuperior = null, dCosto = 0.3 });
            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = 1.1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 1.15 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = 1.23 });
            var SUT = new CalculadorCostoEnvioMaritimo(lstEstaciones, lstRangos, DOCObtenerEstacion.Object);

            //ACT
            var regreso = SUT.CalcularCostoEnvio(dtFechaPedido, dDistancia);
            //ASSERT
            Assert.AreEqual(396.00000000000006, regreso);

        }
        [TestMethod]
        public void CalculaCostoEnvioMaritimo_EstacionOtonioDistancia1200_414()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 10, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(dtFechaPedido.Month)).Returns("OTONIO");
            //DOCobtenerVelocidadVariacion.Setup(doc=>doc.CalculadorVariacionVelocidad(dtFechaPedido,));
            List<RangosDTO> lstRangos = new List<RangosDTO>();
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1, iLimiteSuperior = 100, dCosto = 1 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 101, iLimiteSuperior = 1000, dCosto = 0.5 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1001, iLimiteSuperior = null, dCosto = 0.3 });
            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = 1.1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 1.15 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = 1.23 });
            var SUT = new CalculadorCostoEnvioMaritimo(lstEstaciones, lstRangos, DOCObtenerEstacion.Object);

            //ACT
            var regreso = Math.Round(SUT.CalcularCostoEnvio(dtFechaPedido, dDistancia),2);
            //ASSERT
            Assert.AreEqual(414, regreso);

        }
        [TestMethod]
        public void CalculaCostoEnvioMaritimo_EstacionInviernoDistancia500_307punto5()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 500;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(2)).Returns("INVIERNO");
            //DOCobtenerVelocidadVariacion.Setup(doc=>doc.CalculadorVariacionVelocidad(dtFechaPedido,));
            List<RangosDTO> lstRangos = new List<RangosDTO>();
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1, iLimiteSuperior = 100, dCosto = 1 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 101, iLimiteSuperior = 1000, dCosto = 0.5 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1001, iLimiteSuperior = null, dCosto = 0.3 });
            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = 1.1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 1.15 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = 1.23 });
            var SUT = new CalculadorCostoEnvioMaritimo(lstEstaciones, lstRangos, DOCObtenerEstacion.Object);

            //ACT
            var regreso = Math.Round(SUT.CalcularCostoEnvio(dtFechaPedido, dDistancia),2);

            //ASSERT
            Assert.AreEqual(307.5, regreso);

        }
        [TestMethod]
        public void CalculaCostoEnvioMaritimo_EstacionPrimaveraDistancia500_250()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 03, 22);
            double dDistancia = 500;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(3)).Returns("PRIMAVERA");
            //DOCobtenerVelocidadVariacion.Setup(doc=>doc.CalculadorVariacionVelocidad(dtFechaPedido,));
            List<RangosDTO> lstRangos = new List<RangosDTO>();
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1, iLimiteSuperior = 100, dCosto = 1 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 101, iLimiteSuperior = 1000, dCosto = 0.5 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1001, iLimiteSuperior = null, dCosto = 0.3 });
            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = 1.1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 1.15 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = 1.23 });
            var SUT = new CalculadorCostoEnvioMaritimo(lstEstaciones, lstRangos, DOCObtenerEstacion.Object);

            //ACT
            var regreso = Math.Round(SUT.CalcularCostoEnvio(dtFechaPedido, dDistancia));

            //ASSERT
            Assert.AreEqual(250, regreso);

        }
        [TestMethod]
        public void CalculaCostoEnvioMaritimo_EstacionVeranoDistancia500_275()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 06, 22);
            double dDistancia = 500;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(dtFechaPedido.Month)).Returns("VERANO");
            //DOCobtenerVelocidadVariacion.Setup(doc=>doc.CalculadorVariacionVelocidad(dtFechaPedido,));
            List<RangosDTO> lstRangos = new List<RangosDTO>();
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1, iLimiteSuperior = 100, dCosto = 1 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 101, iLimiteSuperior = 1000, dCosto = 0.5 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1001, iLimiteSuperior = null, dCosto = 0.3 });
            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = 1.1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 1.15 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = 1.23 });
            var SUT = new CalculadorCostoEnvioMaritimo(lstEstaciones, lstRangos, DOCObtenerEstacion.Object);

            //ACT
            var regreso = Math.Round(SUT.CalcularCostoEnvio(dtFechaPedido, dDistancia),2);
            //ASSERT
            Assert.AreEqual(275, regreso);

        }
        [TestMethod]
        public void CalculaCostoEnvioMaritimo_EstacionOtonioDistancia500_287punto5()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 10, 22);
            double dDistancia = 500;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(dtFechaPedido.Month)).Returns("OTONIO");
            //DOCobtenerVelocidadVariacion.Setup(doc=>doc.CalculadorVariacionVelocidad(dtFechaPedido,));
            List<RangosDTO> lstRangos = new List<RangosDTO>();
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1, iLimiteSuperior = 100, dCosto = 1 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 101, iLimiteSuperior = 1000, dCosto = 0.5 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1001, iLimiteSuperior = null, dCosto = 0.3 });
            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = 1.1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 1.15 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = 1.23 });
            var SUT = new CalculadorCostoEnvioMaritimo(lstEstaciones, lstRangos, DOCObtenerEstacion.Object);

            //ACT
            var regreso = Math.Round(SUT.CalcularCostoEnvio(dtFechaPedido, dDistancia), 2);
            //ASSERT
            Assert.AreEqual(287.5, regreso);

        }

        [TestMethod]
        public void CalculaCostoEnvioMaritimo_EstacionInviernoDistancia85_104punto55()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 85;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(2)).Returns("INVIERNO");
            //DOCobtenerVelocidadVariacion.Setup(doc=>doc.CalculadorVariacionVelocidad(dtFechaPedido,));
            List<RangosDTO> lstRangos = new List<RangosDTO>();
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1, iLimiteSuperior = 100, dCosto = 1 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 101, iLimiteSuperior = 1000, dCosto = 0.5 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1001, iLimiteSuperior = null, dCosto = 0.3 });
            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = 1.1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 1.15 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = 1.23 });
            var SUT = new CalculadorCostoEnvioMaritimo(lstEstaciones, lstRangos, DOCObtenerEstacion.Object);

            //ACT
            var regreso = Math.Round(SUT.CalcularCostoEnvio(dtFechaPedido, dDistancia), 2);

            //ASSERT
            Assert.AreEqual(104.55, regreso);

        }
        [TestMethod]
        public void CalculaCostoEnvioMaritimo_EstacionPrimaveraDistancia85_85()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 03, 22);
            double dDistancia = 85;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(3)).Returns("PRIMAVERA");
            //DOCobtenerVelocidadVariacion.Setup(doc=>doc.CalculadorVariacionVelocidad(dtFechaPedido,));
            List<RangosDTO> lstRangos = new List<RangosDTO>();
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1, iLimiteSuperior = 100, dCosto = 1 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 101, iLimiteSuperior = 1000, dCosto = 0.5 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1001, iLimiteSuperior = null, dCosto = 0.3 });
            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = 1.1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 1.15 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = 1.23 });
            var SUT = new CalculadorCostoEnvioMaritimo(lstEstaciones, lstRangos, DOCObtenerEstacion.Object);

            //ACT
            var regreso = Math.Round(SUT.CalcularCostoEnvio(dtFechaPedido, dDistancia));

            //ASSERT
            Assert.AreEqual(85, regreso);

        }
        [TestMethod]
        public void CalculaCostoEnvioMaritimo_EstacionVeranoDistancia85_93puto5()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 06, 22);
            double dDistancia = 85;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(dtFechaPedido.Month)).Returns("VERANO");
            //DOCobtenerVelocidadVariacion.Setup(doc=>doc.CalculadorVariacionVelocidad(dtFechaPedido,));
            List<RangosDTO> lstRangos = new List<RangosDTO>();
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1, iLimiteSuperior = 100, dCosto = 1 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 101, iLimiteSuperior = 1000, dCosto = 0.5 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1001, iLimiteSuperior = null, dCosto = 0.3 });
            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = 1.1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 1.15 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = 1.23 });
            var SUT = new CalculadorCostoEnvioMaritimo(lstEstaciones, lstRangos, DOCObtenerEstacion.Object);

            //ACT
            var regreso = Math.Round(SUT.CalcularCostoEnvio(dtFechaPedido, dDistancia), 2);
            //ASSERT
            Assert.AreEqual(93.5, regreso);

        }
        [TestMethod]
        public void CalculaCostoEnvioMaritimo_EstacionOtonioDistancia85_97punto5()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 10, 22);
            double dDistancia = 85;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(dtFechaPedido.Month)).Returns("OTONIO");
            //DOCobtenerVelocidadVariacion.Setup(doc=>doc.CalculadorVariacionVelocidad(dtFechaPedido,));
            List<RangosDTO> lstRangos = new List<RangosDTO>();
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1, iLimiteSuperior = 100, dCosto = 1 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 101, iLimiteSuperior = 1000, dCosto = 0.5 });
            lstRangos.Add(new RangosDTO { iLimiteInferior = 1001, iLimiteSuperior = null, dCosto = 0.3 });
            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = 1.1 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 1.15 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = 1.23 });
            var SUT = new CalculadorCostoEnvioMaritimo(lstEstaciones, lstRangos, DOCObtenerEstacion.Object);

            //ACT
            var regreso = Math.Round(SUT.CalcularCostoEnvio(dtFechaPedido, dDistancia), 2);
            //ASSERT
            Assert.AreEqual(97.75, regreso);

        }
    }
}
