using FacturacionBackend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontFacturacion.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text == "admin" && txtcontrasena.Text == "1234")
            {
                this.Hide();
               InicioForm inicioform = new InicioForm();
                inicioform.Show();
            
            }
            else
            {
                MessageBox.Show("El Usuario es: Admin y el password es: 1234");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
