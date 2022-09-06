using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            cargargrilla();
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
    }
}
