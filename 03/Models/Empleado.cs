using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Empleado
    {
        public Int32 IdEmpleado { get; set; }
        public String Apellido { get; set; }
        public String Nombre { get; set; }
        public DateTime Nacimiento { get; set; }
        public String Direccion { get; set; }
        public string Apellidos { get; internal set; }
        public string Cargo { get; internal set; }
    }
}
