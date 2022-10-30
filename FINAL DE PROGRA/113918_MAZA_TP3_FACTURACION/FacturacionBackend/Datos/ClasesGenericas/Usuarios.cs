using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.Datos.ClasesGenericas
{
    public class Usuarios
    {
        public string usuario { get; set; }
        public string clave { get; set; }

        public Usuarios(string usuario, string clave)
        {
            this.usuario = usuario;
            this.clave = clave;
        }
    }
}
