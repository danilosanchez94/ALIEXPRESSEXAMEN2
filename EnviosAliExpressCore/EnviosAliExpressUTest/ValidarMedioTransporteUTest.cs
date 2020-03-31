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
    public class ValidarMedioTransporteUTest
    {
        [TestMethod]
        public void ValidarMeidoTransporte_SiExiste()
        {
            //Arrange
            IMediosTransporte medioTransporte = new Maritimo(new CalculadorVelocidadMaritimo(new List<EstacionesDTO>(), new Estacion()), new CalculadorCostoEnvioMaritimo(new List<EstacionesDTO>(), new List<RangosDTO>(), new Estacion()));
            List<IEmpresa> lstEmpresas = new List<IEmpresa>();
            lstEmpresas.Add(new Fedex(medioTransporte, new CalculadorMargenUtilidadCostoFedex(), new List<TiempoRepartoDTO>(), new ParametrosDTO()));
            lstEmpresas.Add(new DHL(medioTransporte, new CalculadorMargenUtilidadCostoDHL(), new List<TiempoRepartoDTO>(), new ParametrosDTO()));
            lstEmpresas.Add(new Estafeta(medioTransporte, new CalculadorMargenUtilidadCostoEstafeta(new List<RangosMargenDTO>()), new List<TiempoRepartoDTO>(), new ParametrosDTO()));
            var SUT = new ValidadorMedioTransporte();

            //ACT
            var regreso = SUT.ValidarMedioTransporte(lstEmpresas,"FEDEX","MARITIMO");
            //ASSERT
            Assert.AreEqual("", regreso);

        }

        [TestMethod]
        public void ValidarPaqueteria_NoExiste()
        {
            //Arrange
            IMediosTransporte medioTransporte = new Maritimo(new CalculadorVelocidadMaritimo(new List<EstacionesDTO>(), new Estacion()), new CalculadorCostoEnvioMaritimo(new List<EstacionesDTO>(), new List<RangosDTO>(), new Estacion()));
            List<IEmpresa> lstEmpresas = new List<IEmpresa>();
            lstEmpresas.Add(new Fedex(medioTransporte, new CalculadorMargenUtilidadCostoFedex(), new List<TiempoRepartoDTO>(), new ParametrosDTO()));

            var SUT = new ValidadorMedioTransporte();

            //ACT
            string  cMensaje = string.Format("{0} no ofrece el servicio de transporte {1}, te recomendamos cotizar en otra empresa.", "DHL", "MARITIMO");
            var regreso = SUT.ValidarMedioTransporte(lstEmpresas, "DHL","MARITIMO");
            //ASSERT
            Assert.AreEqual(cMensaje, regreso);

        }
        
        

    }
}
