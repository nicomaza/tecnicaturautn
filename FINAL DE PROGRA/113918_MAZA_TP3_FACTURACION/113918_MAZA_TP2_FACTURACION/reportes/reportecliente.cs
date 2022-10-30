using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionBackend
{
    public partial class reportecliente : Form
    {
        public reportecliente()
        {
            InitializeComponent();
        }

        private void reportecliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.agrupado' table. You can move, or remove it, as needed.
            this.agrupadoTableAdapter.Fill(this.dataSet1.agrupado);

            this.reportViewer1.RefreshReport();
        }
    }
}
