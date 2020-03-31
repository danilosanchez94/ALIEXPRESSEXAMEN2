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
    public class CalculadorPaqueteriaMasBarataUTest
    {
        [TestMethod]
        public void ImprimirMensajePaqueteriaMasBarata_SiHayMasBarata()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            List<ParametrosDTO> lstParametros = new List<ParametrosDTO>();
            ParametrosDTO parametros = new ParametrosDTO();
            parametros.dCostoEnvio = 20;
            parametros.cMedioTransporte = "MARITIMO";
            parametros.cPaqueteria = "FEDEX";
            ParametrosDTO parametros2 = new ParametrosDTO();
            parametros2.dCostoEnvio = 10;
            parametros2.cMedioTransporte = "MARITIMO";
            parametros2.cPaqueteria = "DHL";
            ParametrosDTO parametros3 = new ParametrosDTO();
            parametros3.dCostoEnvio = 5;
            parametros3.cMedioTransporte = "MARITIMO";
            parametros3.cPaqueteria = "ESTAFETA";
            lstParametros.Add(parametros2);
            lstParametros.Add(parametros);
            lstParametros.Add(parametros3);
            var SUT = new CalculadorPaqueteriaMasBarata();

            //ACT
            var regreso = SUT.ImprimirMensajePaqueteriaMasBarata(lstParametros, parametros);
            string cMensaje = string.Format("Si hubieras pedido en {0} te hubiera costado {1}.", parametros3.cPaqueteria, parametros3.dCostoEnvio);
            //ASSERT
            Assert.AreEqual(cMensaje, regreso);

        }

        [TestMethod]
        public void ImprimirMensajePaqueteriaMasBarata_NoHayMasBarata()
        {
            //Arrange
            var DOCObtenerEstacion = new Mock<IObtenerEstacion>();
            var DOCobtenerVelocidadVariacion = new Mock<IObtenerVelocidadVariacion>();
            List<ParametrosDTO> lstParametros = new List<ParametrosDTO>();
            ParametrosDTO parametros = new ParametrosDTO();
            parametros.dCostoEnvio = 20;
            parametros.cMedioTransporte = "MARITIMO";
            parametros.cPaqueteria = "FEDEX";
            ParametrosDTO parametros2 = new ParametrosDTO();
            parametros2.dCostoEnvio = 30;
            parametros2.cMedioTransporte = "MARITIMO";
            parametros2.cPaqueteria = "DHL";
            ParametrosDTO parametros3 = new ParametrosDTO();
            parametros3.dCostoEnvio = 40;
            parametros3.cMedioTransporte = "MARITIMO";
            parametros3.cPaqueteria = "ESTAFETA";
            lstParametros.Add(parametros2);
            lstParametros.Add(parametros);
            lstParametros.Add(parametros3);
            var SUT = new CalculadorPaqueteriaMasBarata();

            //ACT
            var regreso = SUT.ImprimirMensajePaqueteriaMasBarata(lstParametros, parametros);
            string cMensaje = "";
            //ASSERT
            Assert.AreEqual(cMensaje, regreso);

        }

    }
}
