using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadSemana5.Interfaces
{
    internal interface ICollection
    {
        bool estaVacia();
            //devuelve true si la colección está vacía y false en caso contrario.
        void extraer(); 
            //devuelve y elimina el primer elemento de la colección.
        object primero();
            // devuelve el primer elemento de la colección.
        bool añadir(); 
            //añade un objeto por el extremo que corresponda, y devuelve true si se ha añadido y false en caso contrario.

    }
}
