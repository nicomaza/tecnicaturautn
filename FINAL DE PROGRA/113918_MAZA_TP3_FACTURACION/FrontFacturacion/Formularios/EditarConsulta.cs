using FacturacionBackend.Datos.ClasesGenericas;
using FrontFacturacion.Cliente;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionBackend
{
    public partial class EditarConsulta : Form
    {
        ConexionBD obd = new ConexionBD();
        public EditarConsulta()
        {
            InitializeComponent();
        }
        ClienteSingleton singleton;

        //private async Task editar_LoadAsync(object sender, EventArgs e)
        //{
        //    await cargartodasfacturas();
           
        //}

        private void cargargrilla()
        {
            
            datagridedicion.DataSource = obd.consultasp("consulta_facturas");
        }

        private void baja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO DESEA ANULAR FACTURA?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int filaselect = (int)datagridedicion.CurrentRow.Cells[0].Value;

                obd.modificarfactura("modificar_estadofac", filaselect);

                cargargrilla();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chanulada_CheckedChanged(object sender, EventArgs e)
        {


        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


            if (radioButton1.Checked == true)
            {
              
                cargargrilla();
                lblactual.Text = "TODAS LAS FACTURAS (INCLUYE ANULADAS)";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                datagridedicion.Columns.Clear();
                datagridedicion.DataSource = obd.consultasp("consulta_fanuladas");
                
                lblactual.Text = "FACTURAS ANULADAS";
            }
            if (radioButton2.Checked == false)
            {
                lblactual.Text = "FACTURAS";


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////reportecliente reportecliente = new reportecliente();
            //reportecliente.ShowDialog();
            //reportecliente.Dispose();
        }

        private async void cargartodasfacturas()
        {
            List<ConsultaTodas> lst;
            string url = "https://localhost:7193/todasfacturas";
            var resultado = await ClienteSingleton.getinstance().GetAsync(url);
            lst = JsonConvert.DeserializeObject<List<ConsultaTodas>>(resultado);

            datagridedicion.Rows.Clear();
            foreach(ConsultaTodas consulta in lst)
            {
                datagridedicion.Rows.Add(new object[] { consulta.nro_factura,consulta.fecha,consulta.cliente,consulta.estado });
            }
            
        }

        private void fanuladas_Click(object sender, EventArgs e)
        {

        }

        private void EditarConsulta_Load(object sender, EventArgs e)
        {

        }

        private void fanu_Click(object sender, EventArgs e)
        {
           
        }

        private void EditarConsulta_Load_1(object sender, EventArgs e)
        {

        }

        private void EditarConsulta_Load_2(object sender, EventArgs e)
        {
            cargartodasfacturas();
        }

        private void todas_Click(object sender, EventArgs e)
        {
            cargartodasfacturas();
        }
    }
}
