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
    public class EstacacionUTest
    {
        [TestMethod]
        public void ObtenerEstaciun_Mes1_Invierno()
        {
            //Arrange
            var SUT = new Estacion();

            //ACT
            var regreso = SUT.ObtenerEstacion(1);

            //ASSERT
            Assert.AreEqual("INVIERNO", regreso);

        }
        [TestMethod]
        public void ObtenerEstaciun_Mes3_Primavera()
        {
            //Arrange
            var SUT = new Estacion();

            //ACT
            var regreso = SUT.ObtenerEstacion(3);

            //ASSERT
            Assert.AreEqual("PRIMAVERA", regreso);

        }
        [TestMethod]
        public void ObtenerEstaciun_Mes6_VERANO()
        {
            //Arrange
            var SUT = new Estacion();

            //ACT
            var regreso = SUT.ObtenerEstacion(6);

            //ASSERT
            Assert.AreEqual("VERANO", regreso);

        }
        [TestMethod]
        public void ObtenerEstaciun_Mes9_OTONIO()
        {
            //Arrange
            var SUT = new Estacion();

            //ACT
            var regreso = SUT.ObtenerEstacion(9);

            //ASSERT
            Assert.AreEqual("OTONIO", regreso);

        }
    }
}
