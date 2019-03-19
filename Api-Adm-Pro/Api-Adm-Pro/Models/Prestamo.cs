using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAdmPro.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int TasaIntereses { get; set; }
        public Plazo plazo { get; set; }
        public int InteresMora { get; set; }
    }
}
