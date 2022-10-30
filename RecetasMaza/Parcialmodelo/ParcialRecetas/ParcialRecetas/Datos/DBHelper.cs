using ParcialRecetas.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialRecetas.Datos
{
    internal class DBHelper
    {
        private static DBHelper instance;

        private SqlConnection cnn;

        public DBHelper()
        {
            cnn = new SqlConnection(Properties.Resources.ConexionString);
        }

        public static DBHelper ObtenerInstanciaHelper()
        {
            if (instance == null)
            {
                instance = new DBHelper();
            }
            return instance;
        }

        public DataTable ConsultarDB(string nombresp)
        {
            DataTable dt = new DataTable();
            SqlCommand comando = new SqlCommand();
            cnn.Open();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombresp;
            dt.Load(comando.ExecuteReader());
            cnn.Close();
            return dt;
        }

        public DataTable ConsultarDB(string nombresp, List<parametros> valores)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            cnn.Open();
            comando.Connection = cnn;
            comando.CommandText = nombresp;
            comando.CommandType = CommandType.StoredProcedure;
            if(valores != null)
            {
                foreach (parametros p in valores)
                {
                    comando.Parameters.AddWithValue(p.Clave, p.Valor);
                }
                tabla.Load(comando.ExecuteReader());
            }

            cnn.Close();
            return tabla;
        }

        public bool CargarMaestroDetalle(Receta oReceta)
        {

            SqlTransaction t = null;
            try
            {
                SqlCommand cmd1 = new SqlCommand();
                cnn.ConnectionString = Properties.Resources.ConexionString;
                cnn.Open();
                cmd1.Connection = cnn;
            t = cnn.BeginTransaction();
            cmd1.Transaction = t;
            cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "SP_INSERTAR_RECETA";
                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@nombre", oReceta.Nombre);
                cmd1.Parameters.AddWithValue("@id_cheff", oReceta.Cheff);
                cmd1.Parameters.AddWithValue("@id_tipo_receta", oReceta.TipoReceta);


                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@id_receta";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd1.Parameters.Add(pOut);
                cmd1.ExecuteNonQuery();

                int idReceta = (int)pOut.Value;

                SqlCommand cmd2;
                int count = 1;

                for (int i = 0; i < oReceta.Detalles.Count; i++)
                {
                    cmd2 = new SqlCommand("SP_INSERTAR_DETALLES", cnn,t);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    cmd2.Parameters.AddWithValue("@detalle_nro", count);
                    cmd2.Parameters.AddWithValue("@id_receta", idReceta);
                    cmd2.Parameters.AddWithValue("@id_ingrediente", oReceta.Detalles[i].Ingrediente.IngredienteId);
                    cmd2.Parameters.AddWithValue("@cantidad", oReceta.Detalles[i].Cantidad);

                    cmd2.ExecuteNonQuery();
                    count++;
                }
            t.Commit();
            cnn.Close();
                return true;
        }
            catch (SqlException)
            {
                
                if (t != null)
                    t.Rollback();
                cnn.Close();
                return false;
            }




}
        public int SPconParametroSalida(string SP, string Parametro)
        {
            SqlParameter pOut = new SqlParameter();
            try
            {
                SqlConnection cnn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();

                cnn.ConnectionString = Properties.Resources.ConexionString;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SP;
                pOut.ParameterName = Parametro;
                pOut.Value = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();
                cnn.Close();
                int idReceta = (int)pOut.Value;
                return idReceta;
            }
            catch (Exception)
            {
                pOut.Value = 1;
                return (int)pOut.Value;
            }


        }

    }
}
