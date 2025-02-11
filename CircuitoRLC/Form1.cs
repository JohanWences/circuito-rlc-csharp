using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircuitoRLC
{
    public partial class CircuitoRLCForm : Form
    {
        public CircuitoRLCForm()
        {
            InitializeComponent();
        }

        private void CircuitoRLCForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularImpedancia_Click(object sender, EventArgs e)
        {

            errorProvider1.SetError(inputCapacitancia, "");
            errorProvider1.SetError(inputInductancia, "");
            errorProvider1.SetError(inputFrecuencia, "");
            errorProvider1.SetError(inputVoltaje, "");
            errorProvider1.SetError(inputResistencia, "");

            int errors = 0;

            double resistenciaObtenida = 0;
            double inductanciaObtenida = 0;
            double capacitanciaObtenida = 0;
            double frecuenciaObtenida = 0;
            double voltajeObtenido = 0;

            double Z; // Impedancia
            double I; // Corriente
            double thetha; // angulo de fase
            double reactancia;


            // Obtener el valor del TextBox y convertirlo a un número
            if (double.TryParse(inputResistencia.Text, out double resistencia))
            {
                resistenciaObtenida = resistencia;
            }
            else
            {
                errorProvider1.SetError(inputResistencia, "Ingrese un valor numérico válido.");
                errors++;
            }

            if (double.TryParse(inputInductancia.Text, out double inductancia))
            {
                inductanciaObtenida = inductancia;
            }
            else
            {
                errorProvider1.SetError(inputInductancia, "Ingrese un valor numérico válido.");
                errors++;
            }

            if (double.TryParse(inputInductancia.Text, out double capacitancia))
            {
                capacitanciaObtenida = capacitancia;
            }
            else
            {
                errorProvider1.SetError(inputCapacitancia, "Ingrese un valor numérico válido.");
                errors++;
            }

            if (double.TryParse(inputFrecuencia.Text, out double frecuencia))
            {
                frecuenciaObtenida = frecuencia;
            }
            else
            {
                errorProvider1.SetError(inputFrecuencia, "Ingrese un valor numérico válido.");
                errors++;
            }

            if (double.TryParse(inputVoltaje.Text, out double voltaje))
            {
                voltajeObtenido = voltaje;
            }
            else
            {
                errorProvider1.SetError(inputVoltaje, "Ingrese un valor numérico válido.");
                errors++;
            }

            if (impetanciaRadioBtn.Checked)
            {
                if (errors > 0)
                {
                    MessageBox.Show("Existen campos vacíos");
                } else
                {
                    reactancia = 2 * Math.PI * frecuenciaObtenida * inductanciaObtenida;
                    Z = Math.Sqrt(Math.Pow(resistenciaObtenida, 2) + Math.Pow(reactancia, 2)); // Inductancia capacitiva
                    label8.Text = Z.ToString() + " Ω";
                    label9.Text = "";
                    label10.Text = "";
                }
            }
            else if (corrienteRadioBtn.Checked)
            {
                if (errors > 0)
                {
                    MessageBox.Show("Existen campos vacíos");
                }
            }
            else if (potenciaRadioBtn.Checked)
            {
                if (errors > 0)
                {
                    MessageBox.Show("Existen campos vacíos");
                }
            }
            else
            {
                MessageBox.Show("Ninguna opción seleccionada.");
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            inputResistencia.Clear();
            inputCapacitancia.Clear();
            inputFrecuencia.Clear();
            inputVoltaje.Clear();
            inputFrecuencia.Clear();
            inputInductancia.Clear();
        }
    }
}
