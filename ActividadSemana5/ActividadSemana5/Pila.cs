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
        public object[] ArrayPila = new object[10];
        int ultimo = 0;

        public bool estaVacia()
        {
            if(ArrayPila.Length == 0)
            {
                return true;
            }
            return false;
        }
        //devuelve true si la colección está vacía y false en caso contrario.
        public object extraer(int ultimo)
        {
            object objeto = ArrayPila[ultimo];
            ArrayPila[ultimo] = null;
            return objeto;
        }
        //devuelve y elimina el primer elemento de la colección.
        public object primero()
        {
            object objeto =  ArrayPila[0];
            return objeto;
        }
        // devuelve el primer elemento de la colección.
        public bool añadir(int numero)
        {

            if (ultimo < ArrayPila.Length)
            {
                ArrayPila[ultimo] = numero;
                ultimo++;
                return true;
            }
            return false;

        }
        //añade un objeto por el extremo que corresponda, y devuelve true si se ha añadido y false en caso contrario.

    }
}
