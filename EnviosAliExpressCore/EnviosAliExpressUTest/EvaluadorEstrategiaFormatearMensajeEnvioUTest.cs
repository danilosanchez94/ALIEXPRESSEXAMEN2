using EnviosAliExpressCore.Clases;
using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressUTest
{
    [TestClass]
    public class EvaluadorEstrategiaFormatearMensajeEnvioUTest
    {

        [TestMethod]
        public void ObtenerClaveEstrategia_FUTURO()
        {
            //Arrange
            var SUT = new EvaluadorEstrategiaFormatearMensajeEnvio();
            DateTime dtFechaEntrega = new DateTime(2020, 03, 22);
            //ACT
            var regreso = SUT.ObtenerClaveEstrategia(dtFechaEntrega);

            //ASSERT
            Assert.AreEqual("FUTURO", regreso);

        }

        [TestMethod]
        public void ObtenerClaveEstrategia_PASADO()
        {
            //Arrange
            var SUT = new EvaluadorEstrategiaFormatearMensajeEnvio();
            DateTime dtFechaEntrega = new DateTime(2020, 02, 22);
            //ACT
            var regreso = SUT.ObtenerClaveEstrategia(dtFechaEntrega);

            //ASSERT
            Assert.AreEqual("PASADO", regreso);

        }
    }
}
