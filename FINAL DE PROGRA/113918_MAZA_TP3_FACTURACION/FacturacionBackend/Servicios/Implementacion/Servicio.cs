using FacturacionBackend.Datos.ClasesGenericas;
using FacturacionBackend.Datos.Implementaciones;
using FacturacionBackend.Datos.Interfaces;
using FacturacionBackend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        public IFacturaDAO facturaDAO;

        public Servicio()
        {
            facturaDAO = new FacturaDAO();
        }

        public List<Articulo> getarticulos()
        {
            return facturaDAO.traerarticulos();
        }

        public bool crearfactura(Factura factura)
        {
            return facturaDAO.crearfacturaenbd(factura);
        }

        public DataTable consultasp(string sp)
        {
            return facturaDAO.consultasp(sp);
        }

        public List<ConsultaTodas> todasfacturas()
        {
            return facturaDAO.traertodasfacturas();
        }
    }
}
