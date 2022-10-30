using FacturacionBackend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.Servicios
{
    public abstract class ServiceFactory
    {
        public abstract IServicio crearservicio();
    }
}
