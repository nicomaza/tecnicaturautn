using ParcialRecetas.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialRecetas.Datos.Interfaces
{
     internal interface Inuevareceta
    {
        DataTable ConsultarBD(string sp);
        int ProximaReceta();
        bool cargarmaestrodetalle(Receta oreceta);

    }
}
