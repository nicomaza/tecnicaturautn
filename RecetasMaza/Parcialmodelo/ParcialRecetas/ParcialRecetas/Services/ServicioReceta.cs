using ParcialRecetas.Datos.Implementaciones;
using ParcialRecetas.Datos.Interfaces;
using ParcialRecetas.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialRecetas.Services
{
    internal class ServicioReceta
    {
        private Inuevareceta oDAO;

        public ServicioReceta()
        {
            oDAO = new NewRecetaInterfaz();
        }

        public DataTable cargarcboingredientes()
        {
            return oDAO.ConsultarBD("SP_CONSULTAR_INGREDIENTES");
        }

        public DataTable cargarcombocheff()
        {
            return oDAO.ConsultarBD("SP_CONSULTARCHEF");
        }

        public DataTable cargarcborecetas()
        {
            return oDAO.ConsultarBD("SP_CONSULTAR_RECETA");
        }

        public int proximareceta()
        {
            return oDAO.ProximaReceta();
        }

        public bool confirmareceta(Receta oreceta)
        {
            if(oDAO.cargarmaestrodetalle(oreceta) == true)
                return true;
            return false;
        }
       
    }
}
