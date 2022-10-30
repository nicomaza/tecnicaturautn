using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend
{
    public class DetalleFactura
    {
        public DetalleFactura(Articulo articulo, int cantidad)
        {
            Articulo = articulo;
            Cantidad = cantidad;
        }

        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }

    }
}
