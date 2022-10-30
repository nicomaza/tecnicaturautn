using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FacturacionBackend
{
    public class Factura
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
        
    }
}
