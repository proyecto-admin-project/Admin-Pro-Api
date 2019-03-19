using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAdmPro.Models
{
    public class Pagos
    {
        public int Id { get; set; }
        public DateTime FechaPago { get; set; }
        public int Estado { get; set; }
        public int MontoMensual { get; set; }
        public Mora Mora { get; set; }
    }
}
