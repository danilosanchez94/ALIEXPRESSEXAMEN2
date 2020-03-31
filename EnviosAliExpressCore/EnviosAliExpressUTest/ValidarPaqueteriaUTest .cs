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
    public class ValidarPaqueteriaUTest
    {
        [TestMethod]
        public void ValidarPaqueteria_SiExiste()
        {
            //Arrange
            IMediosTransporte medioTransporte = new Maritimo(new CalculadorVelocidadMaritimo(new List<EstacionesDTO>(), new Estacion()), new CalculadorCostoEnvioMaritimo(new List<EstacionesDTO>(), new List<RangosDTO>(), new Estacion()));
            List<IEmpresa> lstEmpresas = new List<IEmpresa>();
            lstEmpresas.Add(new Fedex(medioTransporte, new CalculadorMargenUtilidadCostoFedex(), new List<TiempoRepartoDTO>(), new ParametrosDTO()));
            lstEmpresas.Add(new DHL(medioTransporte, new CalculadorMargenUtilidadCostoDHL(), new List<TiempoRepartoDTO>(), new ParametrosDTO()));
            lstEmpresas.Add(new Estafeta(medioTransporte, new CalculadorMargenUtilidadCostoEstafeta(new List<RangosMargenDTO>()), new List<TiempoRepartoDTO>(), new ParametrosDTO()));
            var SUT = new ValidadorPaqueteria();
            string[] cPaqueterias = { "FEDEX", "DHL", "ESTAFETA" };
            //ACT
            var regreso = SUT.ValidarPaqueteria(lstEmpresas,"FEDEX", cPaqueterias);
            //ASSERT
            Assert.AreEqual("", regreso);

        }

        [TestMethod]
        public void ValidarPaqueteria_NoExiste()
        {
            //Arrange
            List<IEmpresa> lstEmpresas = null; ;
            
            var SUT = new ValidadorPaqueteria();

            //ACT
            string cMensaje = string.Format("La  Paquetería: {0} no se encuentra registrada en nuestra red de distribución.", "FEDEX");
            string[] cPaqueterias = { "FEDEX", "DHL", "ESTAFETA" };
            var regreso = SUT.ValidarPaqueteria(lstEmpresas, "FEDEX", cPaqueterias);
            //ASSERT
            Assert.AreEqual(cMensaje, regreso);

        }
        
        

    }
}
