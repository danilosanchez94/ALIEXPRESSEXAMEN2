using EnviosAliExpress.ClasesMedioTransporte;
using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnviosAliExpressCore.Clases
{
    public class CrearInstanciaFactory : ICrearInstanciaPaqueteriaFactory
    {


        List<IEmpresa> ICrearInstanciaPaqueteriaFactory.CrearInstancia(string cClave, List<Configuracion> configuracion)
        {
            List<IEmpresa> empresa = null;
            IMediosTransporte medioTransporte = null;
            MediosTransporte Mediotransporte = null;
            Mediotransporte = configuracion[0].mediosTransporte.Where(x => x.Medio.ToUpper() == cClave.ToUpper()).FirstOrDefault();
            switch (cClave)
            {



                case "MARITIMO":
                    
                    medioTransporte = new Maritimo(new CalculadorVelocidadMaritimo(Mediotransporte.VelocidadPorTemporada, new Estacion(configuracion[0].temporadas)), new CalculadorCostoEnvioMaritimo(Mediotransporte.CostoAdicionalPorTemporada, Mediotransporte.CostoPorKilometro, new Estacion(configuracion[0].temporadas)));
                    empresa = new List<IEmpresa>();
                    ParametrosDTO parametros = new ParametrosDTO();

                    empresa.Add(new Fedex(medioTransporte, new CalculadorMargenUtilidadCostoFedex( configuracion[1].Periodos, 
                        configuracion[2].paqueterias.Where(c => c.Paqueteria.ToUpper() == "FEDEX").Select(X => X.MargenUtilidad).FirstOrDefault()), 
                        configuracion[2].paqueterias.Where(c => c.Paqueteria.ToUpper() == "FEDEX").Select(X => X.Medios).FirstOrDefault(),
                        new ParametrosDTO()));
                    empresa.Add(new DHL(medioTransporte, new CalculadorMargenUtilidadCostoDHL(configuracion[1].Periodos,
                        configuracion[2].paqueterias.Where(c => c.Paqueteria.ToUpper() == "DHL").Select(X => X.MargenUtilidad).FirstOrDefault()),
                        configuracion[2].paqueterias.Where(c => c.Paqueteria.ToUpper() == "DHL").Select(X => X.Medios).FirstOrDefault(),
                        new ParametrosDTO()));
                    empresa.Add(new Estafeta(medioTransporte, new CalculadorMargenUtilidadCostoEstafeta(configuracion[1].Periodos,
                        configuracion[2].paqueterias.Where(c => c.Paqueteria.ToUpper() == "ESTAFETA").Select(X => X.MargenUtilidad).FirstOrDefault()),
                        configuracion[2].paqueterias.Where(c => c.Paqueteria.ToUpper() == "ESTAFETA").Select(X => X.Medios).FirstOrDefault(),
                        new ParametrosDTO()));
                    break;
                case "TERRESTRE":
                    medioTransporte = new Terrestre(new CalculadorCostoEnvioTerrestre(Mediotransporte.CostoPorKilometro), new CalculadorTiempoTrasladoTerrestre( new Estacion(configuracion[0].temporadas),Mediotransporte.RetrasoPorDiaPorTemporada));
                    empresa = new List<IEmpresa>();
                    ParametrosDTO parametrosT = new ParametrosDTO();
                    empresa.Add(new Fedex(medioTransporte, new CalculadorMargenUtilidadCostoFedex(configuracion[1].Periodos,
                        configuracion[2].paqueterias.Where(c => c.Paqueteria.ToUpper() == "FEDEX").Select(X => X.MargenUtilidad).FirstOrDefault()),
                        configuracion[2].paqueterias.Where(c => c.Paqueteria.ToUpper() == "FEDEX").Select(X => X.Medios).FirstOrDefault(),
                        new ParametrosDTO()));
                    empresa.Add(new DHL(medioTransporte, new CalculadorMargenUtilidadCostoDHL(configuracion[1].Periodos,
                        configuracion[2].paqueterias.Where(c => c.Paqueteria.ToUpper() == "DHL").Select(X => X.MargenUtilidad).FirstOrDefault()),
                        configuracion[2].paqueterias.Where(c => c.Paqueteria.ToUpper() == "DHL").Select(X => X.Medios).FirstOrDefault(),
                        new ParametrosDTO()));
                    empresa.Add(new Estafeta(medioTransporte, new CalculadorMargenUtilidadCostoEstafeta(configuracion[1].Periodos,
                        configuracion[2].paqueterias.Where(c => c.Paqueteria.ToUpper() == "ESTAFETA").Select(X => X.MargenUtilidad).FirstOrDefault()),
                        configuracion[2].paqueterias.Where(c => c.Paqueteria.ToUpper() == "ESTAFETA").Select(X => X.Medios).FirstOrDefault(),
                        new ParametrosDTO()));
                    break;
                case "AEREO":
                    medioTransporte = new Aereo(new CalculadorEscalas());
                    empresa = new List<IEmpresa>();
                    empresa.Add(new Fedex(medioTransporte, new CalculadorMargenUtilidadCostoFedex(configuracion[1].Periodos,
                      configuracion[2].paqueterias.Where(c => c.Paqueteria.ToUpper() == "FEDEX").Select(X => X.MargenUtilidad).FirstOrDefault()),
                      configuracion[2].paqueterias.Where(c => c.Paqueteria.ToUpper() == "FEDEX").Select(X => X.Medios).FirstOrDefault(),
                      new ParametrosDTO()));
                    empresa.Add(new DHL(medioTransporte, new CalculadorMargenUtilidadCostoDHL(configuracion[1].Periodos,
                        configuracion[2].paqueterias.Where(c => c.Paqueteria.ToUpper() == "DHL").Select(X => X.MargenUtilidad).FirstOrDefault()),
                        configuracion[2].paqueterias.Where(c => c.Paqueteria.ToUpper() == "DHL").Select(X => X.Medios).FirstOrDefault(),
                        new ParametrosDTO()));
                    break;
            }
            return empresa;
        }


    }
}
