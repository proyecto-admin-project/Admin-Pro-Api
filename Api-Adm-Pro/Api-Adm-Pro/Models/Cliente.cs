using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAdmPro.Models
{
    public class Cliente
    {
        public DateTime fecha_Nac { get; set; }
        public int Ingresos { get; set; }
        public string Telefono { get; set; }
        public string LugarDeTrabajo { get; set; }
        public string Sexo { get; set; }
        public string Cedula { get; set; }
        public Direccion Direccion { get; set; }
        public int PuntosCliente { get; set; }
        public string Tiempo_Laborando { get; set; }
    }
}
