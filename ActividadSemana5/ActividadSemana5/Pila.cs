using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActividadSemana5.Interfaces;


namespace ActividadSemana5
{
    internal class Pila : ICollection
    {
        public bool estaVacia()
        {
            return true;
        }
        //devuelve true si la colección está vacía y false en caso contrario.
        public void extraer()
        {

        }
        //devuelve y elimina el primer elemento de la colección.
        public object primero()
        {
            throw new NotImplementedException();
        }
        // devuelve el primer elemento de la colección.
        public bool añadir()
        {
            return false;
        }
        //añade un objeto por el extremo que corresponda, y devuelve true si se ha añadido y false en caso contrario.

    }
}
