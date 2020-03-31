using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EnviosAliExpressCore.Clases
{
    public class LectorJson : ILectorArchivos
    {
        public string cTipoArchivo => "JSON";

        List<ParametrosDTO> ILectorArchivos.ObtenerDatosDTO()
        {
            List<Pedidos> lstDatos = ObtenerDatos();
            List<ParametrosDTO> lstDatosParametros = new List<ParametrosDTO>();
            foreach (var x in lstDatos)
            {
                ParametrosDTO parametros = new ParametrosDTO();
                parametros.dDistacia = Convert.ToDouble(x.Dist_KM);
                parametros.dtFechaPedido = Convert.ToDateTime(x.FechaPedido);
                parametros.cMedioTransporte = x.MedioTrans.ToUpper();
                parametros.cPaqueteria = x.Empresa.ToUpper();
                parametros.cCiudadDestino = x.Destino.ToUpper();
                parametros.cCiudadOrigen = x.Procedencia.ToUpper();
                parametros.cPaisOrigen = x.Procedencia.ToUpper();
                parametros.cPaisDestino = x.Destino.ToUpper(); ;

                lstDatosParametros.Add(parametros);
            }
            return lstDatosParametros;
        }

        List<Pedidos> ObtenerDatos()
        {
            List<Pedidos> Datos = new List<Pedidos>();
            string path = @"..\\..\\..\\temp\\Pedidos.json";
            using (StreamReader jsonStream = File.OpenText(path))
            {
                var json = jsonStream.ReadToEnd();
                Datos = JsonConvert.DeserializeObject<List<Pedidos>>(json);
            }
            return Datos;
        }
    }
}
