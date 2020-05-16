using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba2ApiMaipo.Models
{
    public class Vehiculo_transportista
    {
        public int vehiculo_id { get; set; }
        public string vehiculo_marca { get; set; }
        public string vehiculo_modelo { get; set; }
        public string capacidad_refrigeracion { get; set; }
        public string vehiculo_patente { get; set; }
        public int capacidad_carga { get; set; }
    }
}
