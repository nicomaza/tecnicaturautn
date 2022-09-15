using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113918_MAZA_TP2_FACTURACION.Datos
{
     class HelperDAO
    {
        private static HelperDAO intance;
   
        private string Conexion;

        private HelperDAO()
        {
            Conexion = @"Data Source=LAPTOP-LLJMLS47\SQLEXPRESS;Initial Catalog=FACTURACIONTP;Integrated Security=True";

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
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Conexion;
            conn.Open();
            comando.Parameters.Clear();
            comando.Connection = conn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sp;


            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conn.Close();
            return tabla;

        }

        public void modificarfactura(string sp, int parametro)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            conexion.Open();
            comando.Parameters.Clear();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sp;
            comando.Parameters.AddWithValue("@nro_factura", parametro);
            comando.ExecuteNonQuery();
            conexion.Close();

        }
    }
}
