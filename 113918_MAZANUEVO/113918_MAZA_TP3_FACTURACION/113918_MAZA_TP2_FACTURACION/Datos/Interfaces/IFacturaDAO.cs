using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113918_MAZA_TP2_FACTURACION.Datos.Interfaces
{
    internal interface IFacturaDAO
    {
        DataTable GetFacturaDataTable(string nombresp);
    }
}
