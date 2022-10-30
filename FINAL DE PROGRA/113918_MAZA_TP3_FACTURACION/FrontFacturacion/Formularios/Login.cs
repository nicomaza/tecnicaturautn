using FacturacionBackend;
using FacturacionBackend.Datos.ClasesGenericas;
using Newtonsoft.Json;
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
        List<Usuarios> lusuarios = new List<Usuarios>();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                bool aux = false;
                foreach (var usuario in lusuarios)
                {
                    
                    if (txtusuario.Text.Equals(usuario.usuario.ToString()) && txtcontrasena.Text == usuario.clave.ToString())
                    {
                        this.Hide();
                        InicioForm inicioform = new InicioForm();
                        inicioform.Show();
                        aux = true;

                    }
                    
                    else if(aux == true)
                    {
                        break;
                    }
                }
                if(aux == false)
                {
                    MessageBox.Show("Usuario no registrado");
                }
                    

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error");

            }



        }

        private async Task validarusuario()
        {
            
            string url = "https://localhost:7193/usuariospass";
            HttpClient client = new HttpClient();
            var result = await client.GetAsync(url);
            var bodyjson = await result.Content.ReadAsStringAsync();

            lusuarios = JsonConvert.DeserializeObject<List<Usuarios>>(bodyjson);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            validarusuario();
            txtcontrasena.PasswordChar = '*';
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
                pbmostrar.BringToFront();
                txtcontrasena.PasswordChar = '*';
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
                pbocultar.BringToFront();
                txtcontrasena.PasswordChar = '\0';
            
        }
    }
}
