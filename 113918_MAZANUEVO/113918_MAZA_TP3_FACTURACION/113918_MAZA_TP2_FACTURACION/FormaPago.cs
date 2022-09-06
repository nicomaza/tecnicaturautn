using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113918_MAZA_TP2_FACTURACION
{
    internal class FormaPago
    {
        public FormaPago(int id, string nombre)
        {
            idformapago = id;
            Nombre = nombre;
        }
        public FormaPago()
        {
            Nombre = "";
            idformapago = 0;
        }
        public string Nombre { get; set; }
        public int idformapago { get; set; }

        public override string ToString()
        {
            return idformapago + " " + Nombre;
        }
    }
}
