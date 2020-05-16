using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba2ApiMaipo.Models
{
    public class Ssubasta
    {
        public int subasta_id { get; set; }
        public DateTime subasta_fecha_inicio { get; set; }
        public DateTime subasta_fecha_fin { get; set; }
        public int transportista_id { get; set; }
    }
}
