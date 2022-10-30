using System.Security.Cryptography.X509Certificates;

namespace FacturacionBackend.Datos.ClasesGenericas
{
    public class ConsultaTodas
    {
        public int nro_factura { get; set; }
        public string fecha { get; set; }
        public string cliente { get; set; }
        public int estado { get; set; }
        public ConsultaTodas(int nro,string fecha, string cliente, int estado)
        { 
           nro_factura = nro;
            this.fecha = fecha;
            this.cliente = cliente;
            this.estado = estado;


        }
    }
}