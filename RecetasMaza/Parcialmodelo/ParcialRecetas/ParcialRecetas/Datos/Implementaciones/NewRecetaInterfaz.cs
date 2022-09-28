using ParcialRecetas.Datos.Interfaces;
using ParcialRecetas.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialRecetas.Datos.Implementaciones
{
    class NewRecetaInterfaz : Inuevareceta
    {
        public bool cargarmaestrodetalle(Receta oreceta)
        {
            if (DBHelper.ObtenerInstanciaHelper().CargarMaestroDetalle(oreceta) == true)
                return true;
            return false;
        }

        public DataTable ConsultarBD(string SP)
        {
            return DBHelper.ObtenerInstanciaHelper().ConsultarDB(SP);
        }

        public int ProximaReceta()
        {
            return DBHelper.ObtenerInstanciaHelper().SPconParametroSalida("SP_PROXIMARECETA", "@next");
        }
    }
}
