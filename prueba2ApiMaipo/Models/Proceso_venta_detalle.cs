using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba2ApiMaipo.Models
{
    public class Proceso_venta_detalle
    {
        public int proceso_venta_detalle_id { get; set; }
        public DateTime fecha_detalle { get; set; }
        public string comentario { get; set; }
        public int productor_id { get; set; }
        public int producto_id { get; set; }
    }
}
