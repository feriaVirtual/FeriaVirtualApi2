using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba2ApiMaipo.Models
{
    public class Productor
    {
        public int productor_id { get; set; }
        public string productor_nombre { get; set; }
        public string apellido_paterno { get; set; }
        public string productor_materno { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int productor_activo { get; set; }
        public int rol_id { get; set; }
    }
}
