using FacturacionBackend.Datos;
using FacturacionBackend.Datos.Implementaciones;
using FacturacionBackend.Servicios.Implementacion;
using FacturacionBackend.Servicios.Interfaces;
using FrontFacturacion.Cliente;
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

namespace FacturacionBackend
{
    public partial class FormFactura : Form
    {
        
        public FormFactura()
        {
            InitializeComponent();
            
        }

        ConexionBD obd = new ConexionBD();
        Factura ofactura = new Factura();
        IServicio oservico = new Servicio();
       
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dtpfecha.Value = DateTime.Today;
            txtcliente.Text = "CONSUMIDOR FINAL";

            cargarcomboproducto();
            cargarcbofpago();

            this.ActiveControl = cboproducto;

            cboproducto.SelectedIndex = -1;
            cboformapago.SelectedIndex = 1;

            txtcantidad.Text = "1";

            DataTable dt = new DataTable();
            dt = obd.consultasp("consulta_ultimo");
            string ultimafac = dt.Rows[0][0].ToString();
            label5.Text += " "+ ultimafac;

        }

        private void cargarcomboproducto()
        {
            DataTable dt = new DataTable();
            dt = obd.consultasp("consulta_articulos");
            cboproducto.DataSource = dt;
            cboproducto.ValueMember = dt.Columns[0].ColumnName;
            cboproducto.DisplayMember = dt.Columns[1].ColumnName;
            cboproducto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cargarcbofpago()
        {
            HelperDAO odao = HelperDAO.obtenerinstancia();
            //odao.GetFacturaDataTable("formas de pago");
            DataTable dt = new DataTable();
            //dt = obd.consultasp("formas_pago");
            dt = odao.consultasp("formas_pago");
            cboformapago.DataSource = dt;
            cboformapago.ValueMember = dt.Columns[0].ColumnName;
            cboformapago.DisplayMember = dt.Columns[1].ColumnName;
            cboformapago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cboformapago.Text.Equals(string.Empty))
            {
                MessageBox.Show("Ingrese una forma de pago","Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboproducto.Text.Equals(string.Empty))
            {
                MessageBox.Show("seleccione un producto", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtcantidad.Text == "")
            {
                MessageBox.Show("debe ingresar una cantidad valida!", "control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["producol"].Value.ToString().Equals(cboproducto.Text))
                {
                    MessageBox.Show("producto: " + cboproducto.Text + " ya se encuentra como detalle", "control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
            }
            DataRowView item = (DataRowView)cboproducto.SelectedItem;

            int idprod = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            double pre = Convert.ToDouble(item.Row.ItemArray[2]);

            Articulo p = new Articulo(idprod, nom, pre);

            int cantidad = Convert.ToInt32(txtcantidad.Text);

            DetalleFactura detallefactura = new DetalleFactura(p, cantidad);

            ofactura.agregardetalle(detallefactura);
            dataGridView1.Rows.Add(new object[] { item.Row.ItemArray[0], item.Row.ItemArray[1], item.Row.ItemArray[2], txtcantidad.Text });


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                ofactura.quitardetalle(dataGridView1.CurrentRow.Index);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
              
            }
        }
        //BOTON CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        ///BOTON ACEPTAR
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtcliente.Text == "")
            {
                MessageBox.Show("Debe ingresar un cliente!", "Control",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos detalle!",
                "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            guardarfactura();
        }
        
        private async void guardarfactura()
        {
            ofactura.Cliente = txtcliente.Text;
            ofactura.Fecha = Convert.ToDateTime(dtpfecha.Value.ToString());

            DataRowView item = (DataRowView)cboformapago.SelectedItem;

            int idforma = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            
            FormaPago forpago = new FormaPago();

            forpago.idformapago = idforma;
            forpago.Nombre = nom;

            ofactura.agregarformapago(forpago);

            string facturajason = JsonConvert.SerializeObject(ofactura);
            string url = "https://localhost:7193/cargarfactura";

            var resultado = await ClienteSingleton.getinstance().PostAsync(url,facturajason);

            if (resultado != null)
            {
                DataTable dt = new DataTable();
                dt = obd.consultasp("consulta_ultimo");
                string ultimafac = dt.Rows[0][0].ToString();
                int ultimafactura = Convert.ToInt32(dt.Rows[0][0]) - 1;
                MessageBox.Show("Presupuesto " + ultimafactura + " registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el Presupuesto", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
