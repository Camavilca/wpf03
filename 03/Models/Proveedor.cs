using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Models
{
    class Proveedor
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }


        public override string ToString()
        {
            return this.Codigo + ", " + this.Nombre + ", " + this.Pais + ", " + this.Ciudad + ", " + this.Direccion;
        }
    }
}
