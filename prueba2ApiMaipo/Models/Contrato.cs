using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba2ApiMaipo.Models
{
    public class Contrato
    {
        public int contrato_id { get; set; }

        public DateTime contrato_fecha_inicio { get; set; }
        public DateTime contrato_fecha_fin { get; set; }
        public int contrato_activo { get; set; }
        public int productor_id { get; set; }

        public int transportista_id { get; set; }
    }
}
