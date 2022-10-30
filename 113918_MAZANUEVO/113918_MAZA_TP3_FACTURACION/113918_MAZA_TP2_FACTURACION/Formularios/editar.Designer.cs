namespace _113918_MAZA_TP2_FACTURACION
{
    partial class editar
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fACTURACIONTPDataSet = new _113918_MAZA_TP2_FACTURACION.FACTURACIONTPDataSet();
            this.fACTURACIONTPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblactual = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONTPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONTPDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 377);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fACTURACIONTPDataSet
            // 
            this.fACTURACIONTPDataSet.DataSetName = "FACTURACIONTPDataSet";
            this.fACTURACIONTPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fACTURACIONTPDataSetBindingSource
            // 
            this.fACTURACIONTPDataSetBindingSource.DataSource = this.fACTURACIONTPDataSet;
            this.fACTURACIONTPDataSetBindingSource.Position = 0;
            // 
            // baja
            // 
            this.baja.Location = new System.Drawing.Point(683, 61);
            this.baja.Name = "baja";
            this.baja.Size = new System.Drawing.Size(135, 43);
            this.baja.TabIndex = 1;
            this.baja.Text = "ANULAR";
            this.baja.UseVisualStyleBackColor = true;
            this.baja.Click += new System.EventHandler(this.baja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
            // 
            // lblactual
            // 
            this.lblactual.AutoSize = true;
            this.lblactual.Location = new System.Drawing.Point(32, 24);
            this.lblactual.Name = "lblactual";
            this.lblactual.Size = new System.Drawing.Size(59, 16);
            this.lblactual.TabIndex = 5;
            this.lblactual.Text = "Facturas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(683, 223);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(181, 20);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mostrar todas las facturas";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(683, 259);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(211, 20);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mostrar solo facturas anuladas";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 457);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblactual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baja);
            this.Controls.Add(this.dataGridView1);
            this.Name = "editar";
            this.Text = "editar";
            this.Load += new System.EventHandler(this.editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONTPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONTPDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fACTURACIONTPDataSetBindingSource;
        private FACTURACIONTPDataSet fACTURACIONTPDataSet;
        private System.Windows.Forms.Button baja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblactual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}