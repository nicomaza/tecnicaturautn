using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _113918_MAZA_TP2_FACTURACION
{
    public partial class editar : Form
    {
        ConexionBD obd = new ConexionBD();
        public editar()
        {
            InitializeComponent();
        }

        private void editar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obd.consultasp("consulta_factivas");
        }
        private void cargargrilla()
        {
            dataGridView1.DataSource = obd.consultasp("consulta_facturas");
        }

        private void baja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO DESEA ANULAR FACTURA?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int filaselect = (int)dataGridView1.CurrentRow.Cells[0].Value;

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

                dataGridView1.DataSource = obd.consultasp("consulta_fanuladas");
                lblactual.Text = "FACTURAS ANULADAS";
            }
            if (radioButton2.Checked == false)
            {
                lblactual.Text = "FACTURAS";


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportecliente reportecliente = new reportecliente();
            reportecliente.ShowDialog();
            reportecliente.Dispose();
        }
    }
}
