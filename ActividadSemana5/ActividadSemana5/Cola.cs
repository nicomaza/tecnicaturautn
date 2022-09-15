using ActividadSemana5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadSemana5
{
    internal class Cola : ICollection
    {

        List<object> lCola = new List<object>();
        public bool añadir(int numero)
        {
            lCola.Add(numero);
            return true;
        }

        public bool estaVacia()
        {
            {
                for (int i = 0; i < lCola.Count; i++)
                {
                    if (lCola[i] == null)
                        return true;
                }
                return false;
            }
        }

        public object extraer(int ultimo)
        {
            object ultimaCola = null;
            for (int i = 0; i < lCola.Count; i++)
            {
                ultimaCola = lCola[ultimo];
                lCola[ultimo] = null;
            }
            return ultimaCola;
        }

        public object primero()
        {
          
            object Primero = null;
            for (int i = 0; i < lCola.Count; i++)
            {
                Primero = lCola[i];
            }
            return Primero;
        }
    }
}
