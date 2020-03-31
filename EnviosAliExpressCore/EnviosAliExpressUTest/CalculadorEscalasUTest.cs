using EnviosAliExpressCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressUTest
{
    [TestClass]
    public class CalculadorEscalasUTest
    {
        [TestMethod]
        public void CalculaEscalas_Distancia1200_1punto2()
        {
            //Arrange

            double dDistancia = 1200;       
            var SUT = new CalculadorEscalas();
            //ACT
            var regreso = SUT.ObtenerEscalas(dDistancia);

            //ASSERT
            Assert.AreEqual(1.2, regreso);

        }

        [TestMethod]
        public void CalculaEscalas_Distancia800_0()
        {
            //Arrange

            double dDistancia = 800;
            var SUT = new CalculadorEscalas();
            //ACT
            var regreso = SUT.ObtenerEscalas(dDistancia);

            //ASSERT
            Assert.AreEqual(0, regreso);

        }

        [TestMethod]
        public void CalculaEscalas_Distancia3000_3()
        {
            //Arrange

            double dDistancia = 3000;
            var SUT = new CalculadorEscalas();
            //ACT
            var regreso = SUT.ObtenerEscalas(dDistancia);

            //ASSERT
            Assert.AreEqual(3, regreso);

        }
    }
}
