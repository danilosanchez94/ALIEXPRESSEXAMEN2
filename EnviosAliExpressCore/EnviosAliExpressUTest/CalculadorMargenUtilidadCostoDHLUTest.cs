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
    public class CalculadorMargenUtilidadCostoDHLUTest
    {
        [TestMethod]
        public void CalculaMargenUtilidadCostoDHL_Costo1200MesPrimerSemestre_1800()
        {
            //Arrange
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dCosto = 1200;
            var SUT = new CalculadorMargenUtilidadCostoDHL();

            //ACT
            var regreso = SUT.ObtenerMargenUtilidadCosto(dCosto,dtFechaPedido);

            //ASSERT
            Assert.AreEqual(1800, regreso);

        }

        [TestMethod]
        public void CalculaMargenUtilidadCostoDHL_Costo1200Mes2Semestre_1560()
        {
            //Arrange
            DateTime dtFechaPedido = new DateTime(2020, 08, 22);
            double dCosto = 1200;
            var SUT = new CalculadorMargenUtilidadCostoDHL();

            //ACT
            var regreso = SUT.ObtenerMargenUtilidadCosto(dCosto, dtFechaPedido);

            //ASSERT
            Assert.AreEqual(1560, regreso);

        }


    }
}
