using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba2ApiMaipo.Models
{
    public class Producto
    {
        public int producto_id { get; set; }
        public string producto_nombre { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public string observacion { get; set; }
        public int productor_id { get; set; }
        public int stock { get; set; }
        public int tipo_producto_id { get; set; }

    }
}
