using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _113918_MAZA_TP2_FACTURACION
{
    internal class Factura
    {
        

        public int NroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public FormaPago FormaPagon { get; set; }
        public List<DetalleFactura> detalleFacturas { get; set; }
        public string Cliente { get; set; }

        public Factura()
        {
            detalleFacturas = new List<DetalleFactura>();
        }
        public Factura(int nroFactura, DateTime fecha, FormaPago formaPago, List<DetalleFactura> detalleFacturas, string cliente)
        {
            NroFactura = nroFactura;
            Fecha = fecha;
            FormaPagon = formaPago;
            this.detalleFacturas = detalleFacturas;
            Cliente = cliente;
        }
        public void agregardetalle(DetalleFactura detalle)
        {
            this.detalleFacturas.Add(detalle);
        }
        public void quitardetalle(int valor)
        {
            this.detalleFacturas.RemoveAt(valor);
        }

        public void agregarformapago(FormaPago forma)
        {
            this.FormaPagon = forma;
        }
        public bool Confirmar()
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
                cmd.Parameters.AddWithValue("@fecha", this.Fecha);
                cmd.Parameters.AddWithValue("@idformapago", this.FormaPagon.idformapago);
                cmd.Parameters.AddWithValue("@cliente", this.Cliente);
                cmd.Parameters.AddWithValue("@estado", 0);
                SqlParameter param = new SqlParameter("@nrofactura", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int nrofactura = Convert.ToInt32(param.Value);
                int cDetalles = 1;
                foreach (DetalleFactura det in detalleFacturas)
                {
                    
                    SqlCommand cmdDet = new SqlCommand("insertar_detalle", cnn,tr1);
                    cmdDet.CommandType = CommandType.StoredProcedure;
                    cmdDet.Parameters.AddWithValue("@idarticulo", det.Articulo.id);
                    cmdDet.Parameters.AddWithValue("@cantidad", det.Cantidad);
                    cmdDet.Parameters.AddWithValue("@nrofactura", nrofactura);

                    SqlParameter param2= new SqlParameter("@iddetalle",SqlDbType.Int);
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
    }
}
