using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAdmPro.Models
{
    public class Solicitud
    {
        public int Estado { get; set; }
        public int MontoSolicitado { get; set; }
        public int MontoAprobado { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Descripcion { get; set; }
    }
}
