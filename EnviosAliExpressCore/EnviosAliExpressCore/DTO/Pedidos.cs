using System;
using System.Collections.Generic;
using System.Text;

namespace EnviosAliExpressCore.DTO
{ 
//{
//    public class Pedidos
//    {
//        List<Datos> datos { get; set; }
     
//    }

    public class Pedidos
    {
        public string Procedencia { get; set; }
        public string Destino { get; set; }
        public string Dist_KM { get; set; }
        public string Empresa { get; set; }
        public string MedioTrans { get; set; }
        public string FechaPedido { get; set; }
        public string cDistancia { get; set; }
        public string cPaqueteria { get; set; }
        public string cMedioTransporte { get; set; }
        public string cFechaPedido { get; set; }

        public string cCiudadOrigen { get; set; }
        public string cPaisOrigen { get; set; }
        public string cCiudadDestino { get; set; }
        public string cPaisDestino { get; set; }
    }
}
