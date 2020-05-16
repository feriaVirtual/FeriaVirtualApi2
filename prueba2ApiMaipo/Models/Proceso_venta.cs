using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba2ApiMaipo.Models
{
    public class Proceso_venta
    {
        public int proceso_venta_id { get; set; }
        public DateTime proceso_venta_fecha { get; set; }
        public string proceso_venta_descripcion { get; set; }
        public int proceso_venta_estado_id { get; set; }
        public int cliente_id { get; set; }
    }
}
