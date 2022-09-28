using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialRecetas.Dominio
{
    internal class parametros
    {
        public string Clave { get; set; }
        public string Valor { get; set; }

        public parametros(string clave, string valor)
        {
            Clave = clave;
            Valor = valor;
        }
    }
}
