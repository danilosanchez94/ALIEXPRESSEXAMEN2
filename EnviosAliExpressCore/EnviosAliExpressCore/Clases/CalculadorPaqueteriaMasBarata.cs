using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnviosAliExpressCore
{
    public class CalculadorPaqueteriaMasBarata : IObtenerMensajeMejorPaqueteria
    {
        public string ImprimirMensajePaqueteriaMasBarata(List<ParametrosDTO> LstEmpresas, ParametrosDTO empresaSeleccionada)
        {
            double dCostoMin = LstEmpresas.Min(x => x.dCostoEnvio);
            ParametrosDTO empresaMasBarata = LstEmpresas.Where(x=>x.dCostoEnvio== dCostoMin).Select(x=>x).FirstOrDefault();
            string cMensaje = "";
            if (empresaMasBarata != null && empresaMasBarata!=empresaSeleccionada)
            {
                double dCosto =empresaSeleccionada.dCostoEnvio- empresaMasBarata.dCostoEnvio;
                cMensaje = string.Format("Si hubieras pedido en {0} te hubiera costado {1} más barato.",empresaMasBarata.cPaqueteria,dCosto.ToString("C"));
            }
            return cMensaje;
                
        }
    }
}
