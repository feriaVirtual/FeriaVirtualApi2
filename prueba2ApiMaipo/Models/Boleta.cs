using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba2ApiMaipo.Models
{
    public class Boleta
    {
        public int boleta_id { get; set; }
        public DateTime boleta_fecha { get; set; }
        public int venta_id { get; set; }
    }
}
