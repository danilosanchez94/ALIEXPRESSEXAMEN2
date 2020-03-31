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
    public class CalculadorTiempoTrasladoTerrestreUTest
    {
        [TestMethod]
        public void CalculadorTiempoTrasladoTerrestre_INVIERNOTiempoTraslado15_5()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 14);
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(2)).Returns("INVIERNO");
            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 4 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = 6 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 5 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = 8 });
            var SUT = new CalculadorTiempoTrasladoTerrestre( DOCObtenerEstacion.Object, lstEstaciones);

            //ACT
            var regreso = SUT.CalcularTiempoTraslado(15, dtFechaPedido);

            //ASSERT
            Assert.AreEqual(5, regreso);

        }
        [TestMethod]
        public void CalculadorTiempoTrasladoTerrestrePRIMAVERATiempoTraslado15_2punto5()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 03, 14);
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(3)).Returns("PRIMAVERA");
            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 4 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = 6 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 5 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = 8 });
            var SUT = new CalculadorTiempoTrasladoTerrestre(DOCObtenerEstacion.Object, lstEstaciones);

            //ACT
            var regreso = SUT.CalcularTiempoTraslado(15, dtFechaPedido);

            //ASSERT
            Assert.AreEqual(2.5, regreso);

        }
        [TestMethod]
        public void CalculadorTiempoTrasladoTerrestre_OTONIOTiempoTraslado15_3punto125()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 10, 14);
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(10)).Returns("OTONIO");
            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 4 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = 6 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 5 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = 8 });
            var SUT = new CalculadorTiempoTrasladoTerrestre(DOCObtenerEstacion.Object, lstEstaciones);

            //ACT
            var regreso = SUT.CalcularTiempoTraslado(15, dtFechaPedido);

            //ASSERT
            Assert.AreEqual(3.125, regreso);

        }
        [TestMethod]
        public void CalculadorTiempoTrasladoTerrestre_VERANOTiempoTraslado15_442()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            ParametrosDTO parametros = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 07, 14);
            DOCObtenerEstacion.Setup(doc => doc.ObtenerEstacion(7)).Returns("VERANO");
            List<EstacionesDTO> lstEstaciones = new List<EstacionesDTO>();
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "PRIMAVERA", dValor = 4 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "VERANO", dValor = 6 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "OTONIO", dValor = 5 });
            lstEstaciones.Add(new EstacionesDTO { cEstacion = "INVIERNO", dValor = 8 });
            var SUT = new CalculadorTiempoTrasladoTerrestre(DOCObtenerEstacion.Object, lstEstaciones);

            //ACT
            var regreso = SUT.CalcularTiempoTraslado(15, dtFechaPedido);

            //ASSERT
            Assert.AreEqual(3.75, regreso);

        }

    }
}
