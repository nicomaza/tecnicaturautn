using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadSemana5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        Pila pila = new Pila();
        Cola cola = new Cola();
        int contadorpila = 0;
        int contadorcola = 0;

        
        private void agregapila_Click(object sender, EventArgs e)
        {
            
            pila.añadir(contadorpila);
            contadorpila++;
            lstpila.Items.Add(contadorpila.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            
        }

        private void quitapila_Click(object sender, EventArgs e)
        {
            pila.extraer(contadorpila);
            contadorpila--;
            lstpila.Items.RemoveAt(contadorpila);
        }

        private void agregacola_Click(object sender, EventArgs e)
        {
            cola.añadir(contadorcola);
            contadorcola++;
            lstcola.Items.Add(contadorcola);
        }

        private void quitacola_Click(object sender, EventArgs e)
        {
            contadorcola--;
                cola.extraer(contadorcola);
                lstcola.Items.RemoveAt(0);
            
        }
    }
}
