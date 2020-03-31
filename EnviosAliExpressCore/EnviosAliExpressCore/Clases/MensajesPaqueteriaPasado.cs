using EnviosAliExpressCore.DTO;
using EnviosAliExpressCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnviosAliExpressCore.Clases
{
    public class MensajesPaqueteriaPasado : IMensajeEnvio
    {
        private readonly List<string> lstExpresiones;
        private readonly MensajeEnvioDTO mensaje;
        private readonly MensajesColoresDTO mensajeColorDTO;
        public MensajesPaqueteriaPasado(List<string> lstExpresiones, MensajeEnvioDTO mensaje,  MensajesColoresDTO mensajeColorDTO)
        {
            this.lstExpresiones = lstExpresiones;
            lstExpresiones.Add("salío");
            lstExpresiones.Add("llegó");
            lstExpresiones.Add("hace");
            lstExpresiones.Add("tuvó");
            this.mensaje = mensaje;
            this.mensajeColorDTO = mensajeColorDTO;
        }

        public string cConjugacion => "PASADO";
        public MensajesColoresDTO FormatearMensaje(Dictionary<string, double> diTiempos, ParametrosDTO parametros)
        {
            var objetoMensaje = ObtenerMensajeEnvio(diTiempos, parametros);
            mensajeColorDTO.cMensaje = string.Format("Tu paquete {0} de {1} y {2} a {3} {4} {5} y " +
                                                    "{6} un costo de {7} (Cualquier reclamación con {8})."
                                                    , objetoMensaje.cExpresion1, objetoMensaje.cOrigen, objetoMensaje.cExpresion2, objetoMensaje.cDestino, objetoMensaje.cExpresion3,
                                                    objetoMensaje.cRangoTiempo, objetoMensaje.cExpresion4, objetoMensaje.cCostoEnvio, objetoMensaje.cPaqueteria);
            mensajeColorDTO.cColor = "Green";          
            return mensajeColorDTO;
        }
        public MensajeEnvioDTO ObtenerMensajeEnvio(Dictionary<string, double> diTiempos, ParametrosDTO parametros)
        {
            KeyValuePair<string, double> itemLast = diTiempos.Last();
            mensaje.cDestino = parametros.cCiudadDestino + " ," + parametros.cPaisDestino;
            mensaje.cOrigen = parametros.cCiudadOrigen + " ," + parametros.cPaisOrigen;
            mensaje.cExpresion1 = lstExpresiones[0];
            mensaje.cExpresion2 = lstExpresiones[1];
            mensaje.cExpresion3 = lstExpresiones[2];
            mensaje.cExpresion4 = lstExpresiones[3];
            mensaje.cPaqueteria = parametros.cPaqueteria;
             mensaje.cRangoTiempo = itemLast.Value + " " + itemLast.Key;
            mensaje.cCostoEnvio = parametros.dCostoEnvio.ToString("C");
            return mensaje;
         


        }

   
    }
}
