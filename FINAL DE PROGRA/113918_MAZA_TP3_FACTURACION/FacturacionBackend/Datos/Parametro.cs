using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.Datos
{
    public class Parametro
    {
        public string Clave { get; set; }
        public string Valor { get; set; }

        public Parametro(string name, string value)
        {
            Clave = name;
            Valor = value;
        }
    }
}
