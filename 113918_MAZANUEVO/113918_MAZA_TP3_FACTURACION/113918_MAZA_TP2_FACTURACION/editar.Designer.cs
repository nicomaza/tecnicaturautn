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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONTPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONTPDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 44);
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
            this.baja.Location = new System.Drawing.Point(708, 44);
            this.baja.Name = "baja";
            this.baja.Size = new System.Drawing.Size(135, 43);
            this.baja.TabIndex = 1;
            this.baja.Text = "ANULAR";
            this.baja.UseVisualStyleBackColor = true;
            this.baja.Click += new System.EventHandler(this.baja_Click);
            // 
            // editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.baja);
            this.Controls.Add(this.dataGridView1);
            this.Name = "editar";
            this.Text = "editar";
            this.Load += new System.EventHandler(this.editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONTPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONTPDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fACTURACIONTPDataSetBindingSource;
        private FACTURACIONTPDataSet fACTURACIONTPDataSet;
        private System.Windows.Forms.Button baja;
    }
}