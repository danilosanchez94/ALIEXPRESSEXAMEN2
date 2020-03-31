using EnviosAliExpress.ClasesMedioTransporte;
using EnviosAliExpressCore;
using EnviosAliExpressCore.Clases;
using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace EnviosAliExpressUTest
{
    [TestClass]
    public class CalculadorMargenutilidadCostoFedexUTest
    {
        [TestMethod]
        public void CalculaMargenUtilidadCostoFedex_MesFebreroCosto200_280()
        {
            //Arrange
            DateTime dtFechaPedido = new DateTime(2020, 02, 25);
            double dCosto = 200;

            var SUT = new CalculadorMargenUtilidadCostoFedex();

            //ACT
            var regreso = SUT.ObtenerMargenUtilidadCosto(dCosto,dtFechaPedido);

            //ASSERT
            Assert.AreEqual(280, regreso);

        }

        [TestMethod]
        public void CalculaMargenUtilidadCostoFedex_MesMarzoCosto200_260()
        {
            //Arrange
            DateTime dtFechaPedido = new DateTime(2020, 03, 25);
            double dCosto = 200;

            var SUT = new CalculadorMargenUtilidadCostoFedex();

            //ACT
            var regreso = SUT.ObtenerMargenUtilidadCosto(dCosto, dtFechaPedido);

            //ASSERT
            Assert.AreEqual(260, regreso);

        }
    }
}
