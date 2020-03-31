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
    public class CalculadorMargenutilidadCostoEstafetaUTest
    {
        [TestMethod]
        public void CalculaMargenUtilidadCostoEstafeta_MesFebreroCosto200_220()
        {
            //Arrange

            DateTime dtFechaPedido = new DateTime(2020, 02, 14);
            double dCosto = 200;

            List<RangosMargenDTO> lstRangosMargen = new List<RangosMargenDTO>();
            lstRangosMargen.Add(new RangosMargenDTO { dtInicio = new DateTime(2020, 01, 01), dtFin = new DateTime(2020, 02, 13), dValor = 1.45 });
            lstRangosMargen.Add(new RangosMargenDTO { dtInicio = new DateTime(2020, 02, 14), dtFin = new DateTime(2020, 02, 14), dValor = 1.1 });
            lstRangosMargen.Add(new RangosMargenDTO { dtInicio = new DateTime(2020, 02, 15), dtFin = new DateTime(2020, 11, 30), dValor = 1.45 });
            lstRangosMargen.Add(new RangosMargenDTO { dtInicio = new DateTime(2020, 12, 1), dtFin = new DateTime(2020, 12, 31), dValor = 1.5 });

            var SUT = new CalculadorMargenUtilidadCostoEstafeta(lstRangosMargen );

            //ACT
            var regreso = Math.Round(SUT.ObtenerMargenUtilidadCosto(dCosto,dtFechaPedido),2);

            //ASSERT
            Assert.AreEqual(220.00, regreso);

        }
        [TestMethod]
        public void CalculaMargenUtilidadCostoEstafeta_MesEneroCosto200_290()
        {
            //Arrange

            DateTime dtFechaPedido = new DateTime(2020, 01, 14);
            double dCosto = 200;

            List<RangosMargenDTO> lstRangosMargen = new List<RangosMargenDTO>();
            lstRangosMargen.Add(new RangosMargenDTO { dtInicio = new DateTime(2020, 01, 01), dtFin = new DateTime(2020, 02, 13), dValor = 1.45 });
            lstRangosMargen.Add(new RangosMargenDTO { dtInicio = new DateTime(2020, 02, 14), dtFin = new DateTime(2020, 02, 14), dValor = 1.1 });
            lstRangosMargen.Add(new RangosMargenDTO { dtInicio = new DateTime(2020, 02, 15), dtFin = new DateTime(2020, 11, 30), dValor = 1.45 });
            lstRangosMargen.Add(new RangosMargenDTO { dtInicio = new DateTime(2020, 12, 1), dtFin = new DateTime(2020, 12, 31), dValor = 1.5 });
            var SUT = new CalculadorMargenUtilidadCostoEstafeta(lstRangosMargen);

            //ACT
            var regreso = SUT.ObtenerMargenUtilidadCosto(dCosto, dtFechaPedido);

            //ASSERT
            Assert.AreEqual(290, regreso);

        }
        [TestMethod]
        public void CalculaMargenUtilidadCostoEstafeta_MesMarzoCosto200_290()
        {
            //Arrange

            DateTime dtFechaPedido = new DateTime(2020, 03, 16);
            double dCosto = 200;

            List<RangosMargenDTO> lstRangosMargen = new List<RangosMargenDTO>();
            lstRangosMargen.Add(new RangosMargenDTO { dtInicio = new DateTime(2020, 01, 01), dtFin = new DateTime(2020, 02, 13), dValor = 1.45 });
            lstRangosMargen.Add(new RangosMargenDTO { dtInicio = new DateTime(2020, 02, 14), dtFin = new DateTime(2020, 02, 14), dValor = 1.1 });
            lstRangosMargen.Add(new RangosMargenDTO { dtInicio = new DateTime(2020, 02, 15), dtFin = new DateTime(2020, 11, 30), dValor = 1.45 });
            lstRangosMargen.Add(new RangosMargenDTO { dtInicio = new DateTime(2020, 12, 1), dtFin = new DateTime(2020, 12, 31), dValor = 1.5 });

            var SUT = new CalculadorMargenUtilidadCostoEstafeta(lstRangosMargen);

            //ACT
            var regreso = SUT.ObtenerMargenUtilidadCosto(dCosto, dtFechaPedido);

            //ASSERT
            Assert.AreEqual(290, regreso);

        }
        [TestMethod]
        public void CalculaMargenUtilidadCostoEstafeta_MesDiciembreCosto200_300()
        {
            //Arrange

            DateTime dtFechaPedido = new DateTime(2020, 12, 14);
            double dCosto = 200;

            List<RangosMargenDTO> lstRangosMargen = new List<RangosMargenDTO>();
            lstRangosMargen.Add(new RangosMargenDTO { dtInicio = new DateTime(2020, 01, 01), dtFin = new DateTime(2020, 02, 13), dValor = 1.45 });
            lstRangosMargen.Add(new RangosMargenDTO { dtInicio = new DateTime(2020, 02, 14), dtFin = new DateTime(2020, 02, 14), dValor = 1.1 });
            lstRangosMargen.Add(new RangosMargenDTO { dtInicio = new DateTime(2020, 02, 15), dtFin = new DateTime(2020, 11, 30), dValor = 1.45 });
            lstRangosMargen.Add(new RangosMargenDTO { dtInicio = new DateTime(2020, 12, 1), dtFin = new DateTime(2020, 12, 31), dValor = 1.5 });

            var SUT = new CalculadorMargenUtilidadCostoEstafeta(lstRangosMargen);

            //ACT
            var regreso = SUT.ObtenerMargenUtilidadCosto(dCosto, dtFechaPedido);

            //ASSERT
            Assert.AreEqual(300, regreso);

        }
    }
}
