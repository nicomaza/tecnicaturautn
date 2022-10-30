using FacturacionBackend.Datos.ClasesGenericas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.Servicios.Interfaces
{
    public interface IServicio
    {
        public List<Articulo> getarticulos();
        public bool crearfactura(Factura factura);

        public DataTable consultasp(string sp);

        public List<ConsultaTodas> todasfacturas();
    }
}
