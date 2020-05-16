using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba2ApiMaipo.Models
{
    public class Venta
    {
        public int venta_id { get; set; }
        public int venta_monto { get; set; }
        public int estado_venta_id { get; set; }
        public int forma_pago_id { get; set; }
        public int cliente_id { get; set; }
        public int productor_id { get; set; }
    }
}
