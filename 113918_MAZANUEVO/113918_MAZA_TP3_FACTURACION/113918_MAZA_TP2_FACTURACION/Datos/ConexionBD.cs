using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _113918_MAZA_TP2_FACTURACION
{
    internal class ConexionBD
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-LLJMLS47\SQLEXPRESS;Initial Catalog=FACTURACIONTP;Integrated Security=True");
        SqlCommand comando = new SqlCommand();

        public DataTable consultasp(string sp)
        {
            conexion.Open();
            comando.Parameters.Clear();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sp;
            

            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;

        }

        public void modificarfactura(string sp, int parametro)
        {
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
