using FacturacionBackend.Datos.ClasesGenericas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.Datos.Interfaces
{
    public interface IFacturaDAO
    {
        public bool crearfacturaenbd(Factura factura);
        public List<Articulo> traerarticulos();

        public List<ConsultaTodas> traertodasfacturas();

        public DataTable consultasp(string sp);
    }
}
