using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TP_SYSACAD
{
    public partial class Form_Comprobante_Pago : Form
    {
        /// <summary>
        /// Constructor de la clase Form_Comprobante_Pago.
        /// Inicializa los componentes visuales y configura la información del comprobante.
        /// </summary>
        /// <param name="fecha">Fecha de la transacción.</param>
        /// <param name="monto">Monto abonado.</param>
        /// <param name="conceptosPagados">Diccionario que contiene los conceptos abonados y sus montos.</param>
        public Form_Comprobante_Pago(DateTime fecha, string monto, Dictionary<string, double> conceptosPagados)
        {
            // Inicializa los componentes del formulario
            InitializeComponent();

            // Configura los textos en los controles del formulario
            lblExitoso.Text = "Pago Exitoso!";
            lblDetalles.Text = "Detalles de la transaccion:";
            lblFecha.Text = $"Fecha: {fecha.ToString()}";
            lblMonto.Text = $"Monto abonado: ${monto.ToString()}";

            // Crea un mensaje con los conceptos abonados
            string mensajeConceptos = "Conceptos abonados:\n";
            bool primerConcepto = true;

            foreach (var nombreConcepto in conceptosPagados.Keys)
            {
                if (!primerConcepto)
                {
                    mensajeConceptos += "\n";
                }
                else
                {
                    primerConcepto = false;
                }

                mensajeConceptos += $"-{nombreConcepto}";
            }

            // Establece el mensaje de conceptos en el control correspondiente
            lblConceptos.Text = mensajeConceptos;

            btnVolver.Text = "Volver Al Panel";
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde y capacidad de maximizar y minimizar.
        /// </summary>
        private void Form_Comprobante_Pago_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Text = "Comprobante de Pago";
        }

        /// <summary>
        /// Maneja el evento Click del botón "Volver Al Panel".
        /// Oculta el formulario actual y muestra el formulario del panel del estudiante.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Panel_Estudiante formPanelEstudiante = new Form_Panel_Estudiante();
            formPanelEstudiante.Show();
        }
    }
}
