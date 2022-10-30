using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.Datos
{
    public class HelperDAO
    {
        private static HelperDAO intance;
   
        private SqlConnection Conexion;

        private HelperDAO()
        {
            Conexion = new SqlConnection(@"Data Source=LAPTOP-LLJMLS47\SQLEXPRESS;Initial Catalog=FACTURACIONTP;Integrated Security=True");

        }

        public static HelperDAO obtenerinstancia()
        {
            if (intance == null)
            {
                intance = new HelperDAO();
            }
            return intance;
        }
        

        public DataTable consultasp(string sp)
        {
            SqlCommand comando = new SqlCommand();
            Conexion.Open();
            comando.Parameters.Clear();
            comando.Connection = Conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sp;


            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            Conexion.Close();
            return tabla;

        }
        public DataTable consultacomun(string select)
        {
            SqlCommand comando = new SqlCommand();
            Conexion.Open();
            comando.Parameters.Clear();
            comando.Connection = Conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = select;


            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            Conexion.Close();
            return tabla;

        }
        public void modificarfactura(string sp, int parametro)
        {
            SqlCommand comando = new SqlCommand();
            Conexion.Open();
            comando.Parameters.Clear();
            comando.Connection = Conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sp;
            comando.Parameters.AddWithValue("@nro_factura", parametro);
            comando.ExecuteNonQuery();
            Conexion.Close();

        }

        internal SqlConnection obtenerconexion()
        {
            return Conexion;
        }
    }
}
