namespace FacturacionBackend
{
    partial class EditarConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagridedicion = new System.Windows.Forms.DataGridView();
            this.nro_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblactual = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagridedicion)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridedicion
            // 
            this.datagridedicion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridedicion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridedicion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridedicion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridedicion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datagridedicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridedicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro_factura,
            this.fecha,
            this.cliente,
            this.estado});
            this.datagridedicion.EnableHeadersVisualStyles = false;
            this.datagridedicion.GridColor = System.Drawing.Color.White;
            this.datagridedicion.Location = new System.Drawing.Point(32, 72);
            this.datagridedicion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datagridedicion.Name = "datagridedicion";
            this.datagridedicion.ReadOnly = true;
            this.datagridedicion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridedicion.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridedicion.RowHeadersVisible = false;
            this.datagridedicion.RowHeadersWidth = 51;
            this.datagridedicion.RowTemplate.Height = 24;
            this.datagridedicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridedicion.Size = new System.Drawing.Size(694, 471);
            this.datagridedicion.TabIndex = 0;
            this.datagridedicion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nro_factura
            // 
            this.nro_factura.HeaderText = "nro_cliente";
            this.nro_factura.MinimumWidth = 6;
            this.nro_factura.Name = "nro_factura";
            this.nro_factura.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "cliente";
            this.cliente.MinimumWidth = 6;
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // baja
            // 
            this.baja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.baja.Location = new System.Drawing.Point(829, 72);
            this.baja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.baja.Name = "baja";
            this.baja.Size = new System.Drawing.Size(181, 37);
            this.baja.TabIndex = 1;
            this.baja.Text = "ANULAR";
            this.baja.UseVisualStyleBackColor = true;
            this.baja.Click += new System.EventHandler(this.baja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // lblactual
            // 
            this.lblactual.AutoSize = true;
            this.lblactual.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblactual.Location = new System.Drawing.Point(32, 30);
            this.lblactual.Name = "lblactual";
            this.lblactual.Size = new System.Drawing.Size(92, 23);
            this.lblactual.TabIndex = 5;
            this.lblactual.Text = "Facturas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(752, 135);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(303, 33);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mostrar todas las facturas";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(752, 176);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(303, 33);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mostrar solo facturas anuladas";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // EditarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 579);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblactual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baja);
            this.Controls.Add(this.datagridedicion);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editar";
            this.Load += new System.EventHandler(this.EditarConsulta_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.datagridedicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridedicion;
        //private System.Windows.Forms.BindingSource //fACTURACIONTPDataSetBindingSource;
        //private FACTURACIONTPDataSet fACTURACIONTPDataSet;
        private System.Windows.Forms.Button baja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblactual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private DataGridViewTextBoxColumn nro_factura;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn estado;
        //private Button fanuladas;
    }
}