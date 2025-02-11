namespace CircuitoRLC
{
    partial class CircuitoRLCForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcularImpedancia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcularImpedancia
            // 
            this.btnCalcularImpedancia.Location = new System.Drawing.Point(224, 345);
            this.btnCalcularImpedancia.Name = "btnCalcularImpedancia";
            this.btnCalcularImpedancia.Size = new System.Drawing.Size(175, 23);
            this.btnCalcularImpedancia.TabIndex = 0;
            this.btnCalcularImpedancia.Text = "Calcular Impedancia";
            this.btnCalcularImpedancia.UseVisualStyleBackColor = true;
            this.btnCalcularImpedancia.Click += new System.EventHandler(this.btnCalcularImpedancia_Click);
            // 
            // CircuitoRLCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 450);
            this.Controls.Add(this.btnCalcularImpedancia);
            this.Name = "CircuitoRLCForm";
            this.Text = "CircuitoRLC";
            this.Load += new System.EventHandler(this.CircuitoRLCForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularImpedancia;
    }
}

