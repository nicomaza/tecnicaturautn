using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _113918_MAZA_TP2_FACTURACION
{
    public partial class inicio : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-LLJMLS47\SQLEXPRESS;Initial Catalog=FACTURACIONTP;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        public inicio()
        {
            InitializeComponent();
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            string consutla = "SELECT FACTURA.NRO_FACTURA, FACTURA.CLIENTE, ARTICULOS.NOMBRE, ARTICULOS.PRECIO_UNITARIO, DETALLE_FACTURA.CANTIDAD " +
               "FROM FACTURA INNER JOIN FORMA_PAGO ON FACTURA.ID_FORMAPAGO = FORMA_PAGO.ID_FORMAPAGO " +
               "INNER JOIN DETALLE_FACTURA ON FACTURA.NRO_FACTURA = DETALLE_FACTURA.NRO_FACTURA " +
               "INNER JOIN ARTICULOS ON DETALLE_FACTURA.ID_ARTICULO = ARTICULOS.ID_ARTICULO";

            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consutla;

            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", tabla));
            reportViewer1.RefreshReport();

            //this.informedtTableAdapter.Fillinforme(this.dataSet1.informedt);
            ////reportViewer1.LocalReport.DataSources.Clear();
            ////reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("informedt"));
            //this.reportViewer1.RefreshReport();
           // this.reportViewer1.RefreshReport();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog(); //bloquea el form ppal
            form1.Dispose();
        }

        private void edicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editar editar = new editar();
            editar.ShowDialog();
            editar.Dispose();
        }
    }
}
