using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ActividadSemana5.Interfaces
{
    internal interface ICollection
    {
        bool estaVacia();
            //devuelve true si la colección está vacía y false en caso contrario.
        object extraer(int ultimo); 
            //devuelve y elimina el primer elemento de la colección.
        object primero();
        // devuelve el primer elemento de la colección.
        bool añadir(int numero); 
            //añade un objeto por el extremo que corresponda, y devuelve true si se ha añadido y false en caso contrario.

    }
}
