namespace ActividadSemana5
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
            this.agregapila = new System.Windows.Forms.Button();
            this.lstcola = new System.Windows.Forms.ListBox();
            this.lstpila = new System.Windows.Forms.ListBox();
            this.quitapila = new System.Windows.Forms.Button();
            this.quitacola = new System.Windows.Forms.Button();
            this.agregacola = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // agregapila
            // 
            this.agregapila.Location = new System.Drawing.Point(489, 374);
            this.agregapila.Name = "agregapila";
            this.agregapila.Size = new System.Drawing.Size(104, 42);
            this.agregapila.TabIndex = 0;
            this.agregapila.Text = "AGREGAR";
            this.agregapila.UseVisualStyleBackColor = true;
            this.agregapila.Click += new System.EventHandler(this.agregapila_Click);
            // 
            // lstcola
            // 
            this.lstcola.FormattingEnabled = true;
            this.lstcola.ItemHeight = 16;
            this.lstcola.Location = new System.Drawing.Point(80, 68);
            this.lstcola.Name = "lstcola";
            this.lstcola.Size = new System.Drawing.Size(218, 260);
            this.lstcola.TabIndex = 1;
            // 
            // lstpila
            // 
            this.lstpila.FormattingEnabled = true;
            this.lstpila.ItemHeight = 16;
            this.lstpila.Location = new System.Drawing.Point(489, 68);
            this.lstpila.Name = "lstpila";
            this.lstpila.Size = new System.Drawing.Size(218, 260);
            this.lstpila.TabIndex = 2;
            // 
            // quitapila
            // 
            this.quitapila.Location = new System.Drawing.Point(611, 374);
            this.quitapila.Name = "quitapila";
            this.quitapila.Size = new System.Drawing.Size(96, 42);
            this.quitapila.TabIndex = 4;
            this.quitapila.Text = "QUITAR";
            this.quitapila.UseVisualStyleBackColor = true;
            this.quitapila.Click += new System.EventHandler(this.quitapila_Click);
            // 
            // quitacola
            // 
            this.quitacola.Location = new System.Drawing.Point(202, 374);
            this.quitacola.Name = "quitacola";
            this.quitacola.Size = new System.Drawing.Size(96, 42);
            this.quitacola.TabIndex = 6;
            this.quitacola.Text = "QUITAR";
            this.quitacola.UseVisualStyleBackColor = true;
            this.quitacola.Click += new System.EventHandler(this.quitacola_Click);
            // 
            // agregacola
            // 
            this.agregacola.Location = new System.Drawing.Point(80, 374);
            this.agregacola.Name = "agregacola";
            this.agregacola.Size = new System.Drawing.Size(104, 42);
            this.agregacola.TabIndex = 5;
            this.agregacola.Text = "AGREGAR";
            this.agregacola.UseVisualStyleBackColor = true;
            this.agregacola.Click += new System.EventHandler(this.agregacola_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "COLA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "PILA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quitacola);
            this.Controls.Add(this.agregacola);
            this.Controls.Add(this.quitapila);
            this.Controls.Add(this.lstpila);
            this.Controls.Add(this.lstcola);
            this.Controls.Add(this.agregapila);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregapila;
        private System.Windows.Forms.ListBox lstcola;
        private System.Windows.Forms.ListBox lstpila;
        private System.Windows.Forms.Button quitapila;
        private System.Windows.Forms.Button quitacola;
        private System.Windows.Forms.Button agregacola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

