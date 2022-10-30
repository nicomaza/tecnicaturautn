using FacturacionBackend.Datos.ClasesGenericas;
using FacturacionBackend.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.Datos.Implementaciones
{
    public class FacturaDAO : IFacturaDAO
    {
        string conexioninicial = @"Data Source=LAPTOP-LLJMLS47\SQLEXPRESS;Initial Catalog=FACTURACIONTP;Integrated Security=True";
        public bool crearfacturaenbd(Factura factura)
        {
            
                bool resultado = true;
                SqlConnection cnn = new SqlConnection();
                SqlTransaction tr1 = null;



                try
                {
                    //this.FormaPagon = new FormaPago();
                    cnn.ConnectionString = @"Data Source=LAPTOP-LLJMLS47\SQLEXPRESS;Initial Catalog=FACTURACIONTP;Integrated Security=True";
                    cnn.Open();
                    tr1 = cnn.BeginTransaction();
                    SqlCommand cmd = new SqlCommand("insertar_factura", cnn, tr1);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fecha", factura.Fecha);
                    cmd.Parameters.AddWithValue("@idformapago", factura.FormaPagon.idformapago);
                    cmd.Parameters.AddWithValue("@cliente", factura.Cliente);
                    cmd.Parameters.AddWithValue("@estado", 0);
                    SqlParameter param = new SqlParameter("@nrofactura", SqlDbType.Int);
                    param.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(param);
                    cmd.ExecuteNonQuery();
                    int nrofactura = Convert.ToInt32(param.Value);
                    int cDetalles = 1;
                    foreach (DetalleFactura det in factura.detalleFacturas)
                    {

                        SqlCommand cmdDet = new SqlCommand("insertar_detalle", cnn, tr1);
                        cmdDet.CommandType = CommandType.StoredProcedure;
                        cmdDet.Parameters.AddWithValue("@idarticulo", det.Articulo.id);
                        cmdDet.Parameters.AddWithValue("@cantidad", det.Cantidad);
                        cmdDet.Parameters.AddWithValue("@nrofactura", nrofactura);

                        SqlParameter param2 = new SqlParameter("@iddetalle", SqlDbType.Int);
                        param2.Direction = ParameterDirection.Output;
                        cmdDet.Parameters.Add(param2);
                        cmdDet.ExecuteNonQuery();
                        int iddetalle = Convert.ToInt32(param2.Value);

                        cDetalles++;
                    }
                    tr1.Commit();
                }
                catch (Exception)
                {
                    tr1.Rollback();
                    resultado = false;

                }
                finally
                {
                    if (cnn != null && cnn.State == ConnectionState.Open)
                        cnn.Close();
                }
                return resultado;

            
        }

        public List<Articulo> traerarticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            string sp = "SP_CONSULTAR_ARTICULOS";

            DataTable tabla = HelperDAO.obtenerinstancia().consultasp(sp);
           

            foreach(DataRow fila in tabla.Rows)
            {
                int id = int.Parse(fila["ID_ARTICULO"].ToString());
                string nombre = fila["NOMBRE"].ToString();
                double precio = double.Parse(fila["PRECIO_UNITARIO"].ToString());
                Articulo articulo = new Articulo(id,nombre,precio);
                lista.Add(articulo);
            }
            return lista;

        
        }

        public List<ConsultaTodas> traertodasfacturas()
        {
            List<ConsultaTodas> lista = new List<ConsultaTodas>();
            string sp = "consulta_facturas";

            DataTable tabla = HelperDAO.obtenerinstancia().consultasp(sp);


            foreach (DataRow fila in tabla.Rows)
            {
                int nro_factura = int.Parse(fila["nro factura"].ToString());
                string fecha = fila["fecha"].ToString();
                string cliente = fila["cliente"].ToString();
                int estado = int.Parse(fila["estado"].ToString());
                ConsultaTodas consulta = new ConsultaTodas(nro_factura,fecha,cliente,estado);
                lista.Add(consulta);
            }
            return lista;


        }
        public List<Articulo> traerfacturasanuladas()
        {
            List<Articulo> lista = new List<Articulo>();
            string sp = "SP_CONSULTAR_ARTICULOS";

            DataTable tabla = HelperDAO.obtenerinstancia().consultasp(sp);


            foreach (DataRow fila in tabla.Rows)
            {
                int id = int.Parse(fila["ID_ARTICULO"].ToString());
                string nombre = fila["NOMBRE"].ToString();
                double precio = double.Parse(fila["PRECIO_UNITARIO"].ToString());
                Articulo articulo = new Articulo(id, nombre, precio);
                lista.Add(articulo);
            }
            return lista;


        }
        public DataTable consultasp(string sp)
        {
            SqlConnection conexion = new SqlConnection(conexioninicial);
            SqlCommand comando = new SqlCommand();
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
    }
}
