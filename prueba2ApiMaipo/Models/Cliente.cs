using Microsoft.AspNetCore.Mvc.Razor.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba2ApiMaipo.Models
{
    public class Cliente
    {
        public int cliente_id { get; set; }
        public string cliente_nombre { get; set; }
        public string cliente_apellido_paterno { get; set; }
        public string cliente_apellido_materno { get; set; }
        public string cliente_rut { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string razon_social { get; set; }
        public int cliente_tipo_id { get; set; }
        public int rol_id { get; set; }
        public int cliente_activo { get; set; }
        public int region_id { get; set; }
        public int comuna_id { get; set; }
    }
}
