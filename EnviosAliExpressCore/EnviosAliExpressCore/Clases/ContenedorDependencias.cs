using EnviosAliExpress.ClasesMedioTransporte;
using EnviosAliExpressCore.ClasesConvertirTiempoResponsability;
using EnviosAliExpressCore.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Clases
{
    public class ContenedorDependencias
    {
        public IServiceProvider Services()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<Fedex>();
            serviceCollection.AddSingleton<Estafeta>();
            serviceCollection.AddSingleton<DHL>();
            serviceCollection.AddSingleton<Aereo>();
            serviceCollection.AddSingleton<Maritimo>();
            serviceCollection.AddSingleton<Terrestre>();
            serviceCollection.AddScoped<ICrearInstanciaPaqueteriaFactory, CrearInstanciaFactory>();
            serviceCollection.AddScoped<IValidarMedioTransporte, ValidadorMedioTransporte>();
            serviceCollection.AddScoped<IValidarPaqueteria, ValidadorPaqueteria>();
            serviceCollection.AddScoped<IEvaluadorEstrategiaFormatearMensajeEnvio, EvaluadorEstrategiaFormatearMensajeEnvio>();
            serviceCollection.AddSingleton<CalculadorDias>();
            serviceCollection.AddSingleton<CalculadorHoras>();
            serviceCollection.AddSingleton<CalculadorMeses>();
            serviceCollection.AddSingleton<CalculadorMinutos>();
            serviceCollection.AddScoped<IObtenerMensajeMejorPaqueteria, CalculadorPaqueteriaMasBarata>();
            return serviceCollection.BuildServiceProvider();
        }
    }
}
