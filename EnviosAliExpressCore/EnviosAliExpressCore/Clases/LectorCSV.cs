using CsvHelper;
using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace EnviosAliExpressCore.Clases
{
    public class LectorCSV  :ILectorArchivos
    {
        public string cTipoArchivo => "CSV";


        List<ParametrosDTO> ILectorArchivos.ObtenerDatosDTO()
        {
            List<DatosDTO> lstDatosCSV = ObtenerDatos();
            List<ParametrosDTO> lstDatosCsv = new List<ParametrosDTO>();

            foreach (var x in lstDatosCSV)
            {
                ParametrosDTO parametros = new ParametrosDTO();
                parametros.dDistacia = Convert.ToDouble(x.cDistancia);
                parametros.dtFechaPedido = Convert.ToDateTime(x.cFechaPedido);
                parametros.cMedioTransporte = x.cMedioTransporte.ToUpper();
                parametros.cPaqueteria = x.cPaqueteria.ToUpper();
                parametros.cCiudadDestino = x.cCiudadDestino.ToUpper();
                parametros.cCiudadOrigen = x.cCiudadOrigen.ToUpper();
                parametros.cPaisOrigen = x.cPaisOrigen.ToUpper();
                parametros.cPaisDestino = x.cPaisDestino.ToUpper(); ;

                lstDatosCsv.Add(parametros);
            }
            return lstDatosCsv;
        }

        List<DatosDTO> ObtenerDatos()
        {
            List<DatosDTO> Datos = new List<DatosDTO>();
            List<Pedidos> Pedidos = new List<Pedidos>();
            using (var reader = new StreamReader(@"..\\..\\..\\temp\\PAQUETERIAS.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Datos = csv.GetRecords<DatosDTO>().ToList();

            }

            return Datos;
        }
    }
}
