using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113918_MAZA_TP2_FACTURACION
{
    internal class Articulo
    {
        public Articulo(int idar, string nombre, double precioUnitario)
        {
            id = idar;
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
        }
        public int id { get; set; }
        public string Nombre { get; set; }
        public double PrecioUnitario { get; set; }


        public override string ToString()
        {
            return Nombre + " " + PrecioUnitario;
        }
    }
}
