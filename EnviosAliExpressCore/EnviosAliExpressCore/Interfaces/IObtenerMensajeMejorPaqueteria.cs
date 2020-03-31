using EnviosAliExpressCore.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.Interfaces
{
    public interface IObtenerMensajeMejorPaqueteria
    {
        string ImprimirMensajePaqueteriaMasBarata(List<ParametrosDTO> LstEmpresas, ParametrosDTO empresaSeleccionada);
    }
}
