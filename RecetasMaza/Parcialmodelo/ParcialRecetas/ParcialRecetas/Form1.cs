using ParcialRecetas.Dominio;
using ParcialRecetas.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialRecetas
{
    public partial class Form1 : Form
    {
        private ServicioReceta servicio;
        private Receta oreceta;

        public Form1()
        {
            InitializeComponent();
            servicio = new ServicioReceta();
            oreceta = new Receta();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarcombo(servicio.cargarcborecetas(),cbotiporeceta);
            cargarcombo(servicio.cargarcboingredientes(), cboingredientes);
            cargarcombo(servicio.cargarcombocheff(),cbocheff);
            proximo();
            totaling();
           

        }

        private void cargarcombo(DataTable tabla, ComboBox combo)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        private void proximo()
        {
            int id = servicio.proximareceta();
            lblnumero.Text = "Receta #: " + id;
        }
        private void totaling()
        {
            int cantidad = dataGridView1.Rows.Count;
            lbltotal.Text = "Total de Ingredientes: " + cantidad;
        }

        public bool ValidarDatosReceta()
        {
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un Nombre a la receta");
                txtnombre.Focus();
                return false;
            }

            if (cbocheff.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Chef a la receta");
                cbocheff.Focus();
                return false;
            }

            if (cbotiporeceta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un tipo de receta");
                cbotiporeceta.Focus();
                return false;
            }

            if (dataGridView1.Rows.Count <= 2)
            {
                MessageBox.Show("AH olvidado Ingredientes?");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (ValidarDataIngrediente())
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["colingredientes"].Value != null && row.Cells["colingredientes"].Value.ToString().Equals(cboingredientes.Text))
                    {
                        MessageBox.Show("Ingrediente ya cargado");
                        return;
                    }
                }

                DataRowView item = (DataRowView)cboingredientes.SelectedItem;

                int ingrediente = (int)item.Row.ItemArray[0];
                string Nombre = item.Row.ItemArray[1].ToString();
                string unidad = item.Row.ItemArray[2].ToString();
                Ingrediente i = new Ingrediente(ingrediente, Nombre, unidad);
                int Cantidad = Convert.ToInt32(txtcantidad.Text);

                DetalleReceta detalle = new DetalleReceta(i, Cantidad);
                oreceta.AgregarDetalle(detalle);
                dataGridView1.Rows.Add(new object[] { item.Row.ItemArray[0], item.Row.ItemArray[1], Cantidad + " " + item.Row.ItemArray[2] });

                totaling();
            }
        }
            public bool ValidarDataIngrediente()
            {
                if (cboingredientes.Text == "")
                {
                    MessageBox.Show("Debe Seleccionar un ingrediente");
                    cboingredientes.Focus();
                    return false;
                }

                if ( txtcantidad.Text.ToString() == "")
                {
                    MessageBox.Show("Debe ingresar una cantidad valida");
                    cboingredientes.Focus();
                    return false;
                }

                return true;
            }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosReceta() == true)
                GuardarReceta();
        }

        public void GuardarReceta()
        {
            oreceta.Nombre = txtnombre.Text;
            oreceta.TipoReceta = (int)cbotiporeceta.SelectedValue;
            oreceta.Cheff = (int)cbocheff.SelectedValue;

            if (servicio.confirmareceta(oreceta))
            {
                MessageBox.Show("Se guardo una receta nueva", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
               
            }
            else
            {
                MessageBox.Show("Se produjo un error", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtnombre.Text = "";
            cbocheff.Text = null;
            cboingredientes.Text = null;
            cbotiporeceta.Text  = null;
        }
    }
}

