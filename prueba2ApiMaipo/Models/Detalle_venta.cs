using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba2ApiMaipo.Models
{
    public class Detalle_venta
    {
        public int detalle_venta_id { get; set; }
        public int producto_id { get; set; }
        public int venta_id { get; set; }
    }
}
