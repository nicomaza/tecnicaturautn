using _113918_MAZA_TP2_FACTURACION.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113918_MAZA_TP2_FACTURACION.Datos.Implementaciones
{
    internal class FacturaDAO : IFacturaDAO
    {
        public DataTable GetFacturaDataTable(string nombresp)
        {
            return HelperDAO.obtenerinstancia().consultasp(nombresp);
        }
    }
}
