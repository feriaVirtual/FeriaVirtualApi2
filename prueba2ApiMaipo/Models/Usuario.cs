using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba2ApiMaipo.Models
{
    public class Usuario
    {
        public int usuario_id { get; set; }
        public string username { get; set; }
        public string contrasena { get; set; }
        public int usuario_activo { get; set; }
        public int rol_id { get; set; }
    }
}
