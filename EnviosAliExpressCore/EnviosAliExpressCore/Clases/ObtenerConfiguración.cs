using EnviosAliExpressCore.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EnviosAliExpressCore.Clases
{
    public class ObtenerConfiguración
    {

        public List<Configuracion> ObtenerDatos()
        {
            List<Configuracion> config = new List<Configuracion>();
            string path = @"..\\..\\..\\temp\\Config.json";
            using (StreamReader jsonStream = File.OpenText(path))
            {
                var json = jsonStream.ReadToEnd();
                config = JsonConvert.DeserializeObject<List<Configuracion>>(json);
            }
            return config;

        }
    }
}
