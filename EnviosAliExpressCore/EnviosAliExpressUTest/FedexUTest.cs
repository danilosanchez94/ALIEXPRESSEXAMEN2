using EnviosAliExpress.ClasesMedioTransporte;
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
    public class FedexUTest
    {
        [TestMethod]
        public void CalculaCostoEnvio_EstacionInviernoDistancia1200_618punto8()
        {
            //Arrange
            var DOCMedioTransporte = new Mock<IMediosTransporte>();
            var DOCcalculaMargen = new Mock<ICalculadorMargenUtilidadCosto>();

            ParametrosDTO parametros = new ParametrosDTO();
            ParametrosDTO parametrosFinal = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCMedioTransporte.Setup(doc => doc.CalculaCostoEnvio(parametros)).Returns(442);
            DOCcalculaMargen.Setup(doc=>doc.ObtenerMargenUtilidadCosto(442,dtFechaPedido)).Returns(618.8);
            List<TiempoRepartoDTO> lstTiempoReparto = new List<TiempoRepartoDTO>(); 
            lstTiempoReparto.Add(new TiempoRepartoDTO { cMedioTransporte = "MARITIMO", iHoras = 21, iMinutos = 0 });
            lstTiempoReparto.Add(new TiempoRepartoDTO { cMedioTransporte = "TERRESTRE", iHoras = 10, iMinutos = 0 });
            lstTiempoReparto.Add(new TiempoRepartoDTO { cMedioTransporte = "AEREO", iHoras = 21, iMinutos = 0 });

            var SUT = new Fedex(DOCMedioTransporte.Object, DOCcalculaMargen.Object, lstTiempoReparto, parametrosFinal);

            //ACT
            var regreso = SUT.ObtenerCostoEnvio(parametros);

            //ASSERT
            Assert.AreEqual(618.8, regreso);

        }
        [TestMethod]
        public void CalculaCalculaTiempoEntrega_MaritimoTiempoReparto21_37punto2()
        {
            //Arrange
            var DOCMedioTransporte = new Mock<IMediosTransporte>();
            var DOCcalculaMargen = new Mock<ICalculadorMargenUtilidadCosto>();

            ParametrosDTO parametros = new ParametrosDTO();
            ParametrosDTO parametrosFinal = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCMedioTransporte.Setup(doc => doc.CalculaTiempoTraslado(parametros)).Returns(37.2);
            List<TiempoRepartoDTO> lstTiempoReparto = new List<TiempoRepartoDTO>();
            lstTiempoReparto.Add(new TiempoRepartoDTO { cMedioTransporte = "MARITIMO", iHoras = 21, iMinutos = 0 });
            lstTiempoReparto.Add(new TiempoRepartoDTO { cMedioTransporte = "TERRESTRE", iHoras = 10, iMinutos = 0 });
            lstTiempoReparto.Add(new TiempoRepartoDTO { cMedioTransporte = "AEREO", iHoras = 21, iMinutos = 0 });

            var SUT = new Fedex(DOCMedioTransporte.Object, DOCcalculaMargen.Object, lstTiempoReparto, parametrosFinal);

            //ACT
            var regreso = SUT.ObtenerTiempoEntrega(parametros);

            //ASSERT
            Assert.AreEqual(37.2, regreso);

        }
        [TestMethod]
        public void ObtenerFechaEntrega_MaritimoTiempoReparto21_23febrero2020()
        {
            //Arrange
            var DOCMedioTransporte = new Mock<IMediosTransporte>();
            var DOCcalculaMargen = new Mock<ICalculadorMargenUtilidadCosto>();

            ParametrosDTO parametros = new ParametrosDTO();
            ParametrosDTO parametrosFinal = new ParametrosDTO();
            DateTime dtFechaPedido = new DateTime(2020, 02, 22);
            double dDistancia = 1200;
            parametros.dtFechaPedido = dtFechaPedido;
            parametros.dDistacia = dDistancia;
            DOCMedioTransporte.Setup(doc => doc.CalculaTiempoTraslado(parametros)).Returns(37.2);
            List<TiempoRepartoDTO> lstTiempoReparto = new List<TiempoRepartoDTO>();
            lstTiempoReparto.Add(new TiempoRepartoDTO { cMedioTransporte = "MARITIMO", iHoras = 21, iMinutos = 0 });
            lstTiempoReparto.Add(new TiempoRepartoDTO { cMedioTransporte = "TERRESTRE", iHoras = 10, iMinutos = 0 });
            lstTiempoReparto.Add(new TiempoRepartoDTO { cMedioTransporte = "AEREO", iHoras = 21, iMinutos = 0 });

            var SUT = new Fedex(DOCMedioTransporte.Object, DOCcalculaMargen.Object, lstTiempoReparto, parametrosFinal);

            //ACT
            var regreso = SUT.ObtenerFechaEntrega(parametros);

            //ASSERT
            Assert.AreEqual(new DateTime(2020,02,23,13,12,0), regreso);

        }
    }
}
