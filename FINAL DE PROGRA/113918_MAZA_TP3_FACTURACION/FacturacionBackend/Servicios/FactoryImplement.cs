using FacturacionBackend.Servicios.Implementacion;
using FacturacionBackend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.Servicios
{
    public class FactoryImplement : ServiceFactory
    {
        public override IServicio crearservicio()
        {
            return new Servicio();
        }
    }
}
