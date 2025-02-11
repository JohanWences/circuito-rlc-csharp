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
            this.components = new System.ComponentModel.Container();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputResistencia = new System.Windows.Forms.TextBox();
            this.inputInductancia = new System.Windows.Forms.TextBox();
            this.inputCapacitancia = new System.Windows.Forms.TextBox();
            this.inputFrecuencia = new System.Windows.Forms.TextBox();
            this.inputVoltaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.impetanciaRadioBtn = new System.Windows.Forms.RadioButton();
            this.corrienteRadioBtn = new System.Windows.Forms.RadioButton();
            this.potenciaRadioBtn = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(343, 318);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(203, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcularImpedancia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese los valores";
            // 
            // inputResistencia
            // 
            this.inputResistencia.Location = new System.Drawing.Point(59, 120);
            this.inputResistencia.Name = "inputResistencia";
            this.inputResistencia.Size = new System.Drawing.Size(189, 22);
            this.inputResistencia.TabIndex = 2;
            // 
            // inputInductancia
            // 
            this.inputInductancia.Location = new System.Drawing.Point(59, 176);
            this.inputInductancia.Name = "inputInductancia";
            this.inputInductancia.Size = new System.Drawing.Size(189, 22);
            this.inputInductancia.TabIndex = 2;
            // 
            // inputCapacitancia
            // 
            this.inputCapacitancia.Location = new System.Drawing.Point(59, 233);
            this.inputCapacitancia.Name = "inputCapacitancia";
            this.inputCapacitancia.Size = new System.Drawing.Size(189, 22);
            this.inputCapacitancia.TabIndex = 2;
            // 
            // inputFrecuencia
            // 
            this.inputFrecuencia.Location = new System.Drawing.Point(59, 295);
            this.inputFrecuencia.Name = "inputFrecuencia";
            this.inputFrecuencia.Size = new System.Drawing.Size(189, 22);
            this.inputFrecuencia.TabIndex = 2;
            // 
            // inputVoltaje
            // 
            this.inputVoltaje.Location = new System.Drawing.Point(59, 357);
            this.inputVoltaje.Name = "inputVoltaje";
            this.inputVoltaje.Size = new System.Drawing.Size(189, 22);
            this.inputVoltaje.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resistencia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.potenciaRadioBtn);
            this.groupBox1.Controls.Add(this.corrienteRadioBtn);
            this.groupBox1.Controls.Add(this.impetanciaRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(343, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 187);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona una opción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(638, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inductancia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Capacitancia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Frecuencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Voltaje";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(640, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(640, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(640, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 3;
            // 
            // impetanciaRadioBtn
            // 
            this.impetanciaRadioBtn.AutoSize = true;
            this.impetanciaRadioBtn.Location = new System.Drawing.Point(26, 52);
            this.impetanciaRadioBtn.Name = "impetanciaRadioBtn";
            this.impetanciaRadioBtn.Size = new System.Drawing.Size(99, 20);
            this.impetanciaRadioBtn.TabIndex = 0;
            this.impetanciaRadioBtn.TabStop = true;
            this.impetanciaRadioBtn.Text = "Impedancia";
            this.impetanciaRadioBtn.UseVisualStyleBackColor = true;
            // 
            // corrienteRadioBtn
            // 
            this.corrienteRadioBtn.AutoSize = true;
            this.corrienteRadioBtn.Location = new System.Drawing.Point(26, 92);
            this.corrienteRadioBtn.Name = "corrienteRadioBtn";
            this.corrienteRadioBtn.Size = new System.Drawing.Size(82, 20);
            this.corrienteRadioBtn.TabIndex = 0;
            this.corrienteRadioBtn.TabStop = true;
            this.corrienteRadioBtn.Text = "Corriente";
            this.corrienteRadioBtn.UseVisualStyleBackColor = true;
            // 
            // potenciaRadioBtn
            // 
            this.potenciaRadioBtn.AutoSize = true;
            this.potenciaRadioBtn.Location = new System.Drawing.Point(26, 133);
            this.potenciaRadioBtn.Name = "potenciaRadioBtn";
            this.potenciaRadioBtn.Size = new System.Drawing.Size(88, 20);
            this.potenciaRadioBtn.TabIndex = 0;
            this.potenciaRadioBtn.TabStop = true;
            this.potenciaRadioBtn.Text = "Potencias";
            this.potenciaRadioBtn.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(59, 406);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(189, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reiniciar valores";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // CircuitoRLCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 506);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputVoltaje);
            this.Controls.Add(this.inputFrecuencia);
            this.Controls.Add(this.inputCapacitancia);
            this.Controls.Add(this.inputInductancia);
            this.Controls.Add(this.inputResistencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "CircuitoRLCForm";
            this.Text = "CircuitoRLC";
            this.Load += new System.EventHandler(this.CircuitoRLCForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputResistencia;
        private System.Windows.Forms.TextBox inputInductancia;
        private System.Windows.Forms.TextBox inputCapacitancia;
        private System.Windows.Forms.TextBox inputFrecuencia;
        private System.Windows.Forms.TextBox inputVoltaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton potenciaRadioBtn;
        private System.Windows.Forms.RadioButton corrienteRadioBtn;
        private System.Windows.Forms.RadioButton impetanciaRadioBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnReset;
    }
}

