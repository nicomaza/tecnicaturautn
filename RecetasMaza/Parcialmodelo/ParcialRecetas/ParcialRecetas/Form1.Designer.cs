namespace ParcialRecetas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcheff = new System.Windows.Forms.Label();
            this.lbltiporeceta = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cbotiporeceta = new System.Windows.Forms.ComboBox();
            this.cboingredientes = new System.Windows.Forms.ComboBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbocheff = new System.Windows.Forms.ComboBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.IDING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(69, 89);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(56, 16);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            // 
            // lblcheff
            // 
            this.lblcheff.AutoSize = true;
            this.lblcheff.Location = new System.Drawing.Point(88, 120);
            this.lblcheff.Name = "lblcheff";
            this.lblcheff.Size = new System.Drawing.Size(37, 16);
            this.lblcheff.TabIndex = 1;
            this.lblcheff.Text = "Cheff";
            // 
            // lbltiporeceta
            // 
            this.lbltiporeceta.AutoSize = true;
            this.lbltiporeceta.Location = new System.Drawing.Point(24, 161);
            this.lbltiporeceta.Name = "lbltiporeceta";
            this.lbltiporeceta.Size = new System.Drawing.Size(101, 16);
            this.lbltiporeceta.TabIndex = 2;
            this.lbltiporeceta.Text = "Tipo de Receta";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(161, 86);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(260, 22);
            this.txtnombre.TabIndex = 3;
            // 
            // cbotiporeceta
            // 
            this.cbotiporeceta.FormattingEnabled = true;
            this.cbotiporeceta.Location = new System.Drawing.Point(161, 153);
            this.cbotiporeceta.Name = "cbotiporeceta";
            this.cbotiporeceta.Size = new System.Drawing.Size(121, 24);
            this.cbotiporeceta.TabIndex = 5;
            // 
            // cboingredientes
            // 
            this.cboingredientes.FormattingEnabled = true;
            this.cboingredientes.Location = new System.Drawing.Point(27, 211);
            this.cboingredientes.Name = "cboingredientes";
            this.cboingredientes.Size = new System.Drawing.Size(255, 24);
            this.cboingredientes.TabIndex = 6;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(446, 211);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(114, 24);
            this.btnagregar.TabIndex = 7;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(166, 583);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(113, 40);
            this.btnaceptar.TabIndex = 8;
            this.btnaceptar.Text = "ACEPTAR";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(301, 583);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(113, 40);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDING,
            this.clmIngrediente,
            this.clmCantidad});
            this.dataGridView1.Location = new System.Drawing.Point(27, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 269);
            this.dataGridView1.TabIndex = 11;
            // 
            // cbocheff
            // 
            this.cbocheff.FormattingEnabled = true;
            this.cbocheff.Location = new System.Drawing.Point(161, 117);
            this.cbocheff.Name = "cbocheff";
            this.cbocheff.Size = new System.Drawing.Size(260, 24);
            this.cbocheff.TabIndex = 12;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(69, 35);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(56, 16);
            this.lblnumero.TabIndex = 13;
            this.lblnumero.Text = "Nombre";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(388, 538);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(115, 16);
            this.lbltotal.TabIndex = 14;
            this.lbltotal.Text = "Total Ingredientes";
            // 
            // IDING
            // 
            this.IDING.HeaderText = "IDING";
            this.IDING.MinimumWidth = 6;
            this.IDING.Name = "IDING";
            this.IDING.Visible = false;
            this.IDING.Width = 125;
            // 
            // clmIngrediente
            // 
            this.clmIngrediente.HeaderText = "Ingrediente";
            this.clmIngrediente.MinimumWidth = 6;
            this.clmIngrediente.Name = "clmIngrediente";
            this.clmIngrediente.Width = 125;
            // 
            // clmCantidad
            // 
            this.clmCantidad.HeaderText = "Cantidad";
            this.clmCantidad.MinimumWidth = 6;
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.Width = 125;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(375, 211);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(46, 22);
            this.txtcantidad.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cantidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 635);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.cbocheff);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.cboingredientes);
            this.Controls.Add(this.cbotiporeceta);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbltiporeceta);
            this.Controls.Add(this.lblcheff);
            this.Controls.Add(this.lblnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcheff;
        private System.Windows.Forms.Label lbltiporeceta;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox cbotiporeceta;
        private System.Windows.Forms.ComboBox cboingredientes;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbocheff;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDING;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label1;
    }
}

