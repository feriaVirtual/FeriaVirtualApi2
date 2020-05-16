using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba2ApiMaipo.Models
{
    public class Transportista
    {
        public int transportista_id { get; set; }
        public string transportista_nombre { get; set; }
        public string transportista_rut { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public int vehiculo_id { get; set; }
        public string transportista_activo { get; set; }


    }
}
