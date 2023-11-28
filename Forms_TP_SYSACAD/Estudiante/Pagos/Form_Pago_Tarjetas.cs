using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Gestores;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
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
    public partial class Form_Pago_Tarjetas : Form
    {
        private string _nombre;
        private string _numero;
        private string _vencimiento;
        private string _codigo;
        private string _montoAAbonar;
        private DateTime _fechaActual;
        private Dictionary<string, double> _conceptosSeleccionados = new Dictionary<string, double>();
        private GestorPagos _gestorPagos = new GestorPagos();

        /// <summary>
        /// Constructor de la clase Form_Pago_Tarjetas.
        /// </summary>
        /// <param name="montoAAbonar">Monto a abonar con la tarjeta.</param>
        /// <param name="conceptosSeleccionados">Conceptos seleccionados para el pago.</param>
        public Form_Pago_Tarjetas(double montoAAbonar, Dictionary<string, double> conceptosSeleccionados)
        {
            InitializeComponent();

            lblNombre.Text = "Ingrese su nombre";
            lblNumero.Text = "Numero de la tarjeta";
            lblVencimiento.Text = "Fecha de Vencimiento";
            lblCodigo.Text = "Codigo de Seguridad";

            tbNombre.PlaceholderText = "Apellido Nombre";
            tbNumero.PlaceholderText = "Ingrese los 16 digitos";
            tbVencimiento.PlaceholderText = "MM/AA";
            tbCodigo.PlaceholderText = "Ingrese los 3 digitos";

            btnAtras.Text = "Atras";
            btnPagar.Text = "Pagar";

            _montoAAbonar = montoAAbonar.ToString();
            lblMonto.Text = $"Monto a Abonar: ${_montoAAbonar}";

            _fechaActual = DateTime.Now;
            _conceptosSeleccionados = conceptosSeleccionados;
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde y capacidad de maximizar y minimizar.
        /// </summary>
        private void Form_Pago_Tarjetas_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Text = "Pagar con Tarjeta";
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            _nombre = tbNombre.Text;
        }

        private void tbNumero_TextChanged(object sender, EventArgs e)
        {
            _numero = tbNumero.Text;
        }

        private void tbVencimiento_TextChanged(object sender, EventArgs e)
        {
            _vencimiento = tbVencimiento.Text;
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
            _codigo = tbCodigo.Text;
        }

        /// <summary>
        /// Maneja el evento Click del botón "Pagar".
        /// Realiza la validación y procesamiento del pago.
        /// </summary>
        private async void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    { "nombre", _nombre },
                    { "numero", _numero },
                    { "vencimiento", _vencimiento },
                    { "codigo", _codigo },
                };

                RespuestaValidacionInput resultadoInputs = await _gestorPagos.GestionarPago(camposIngresados, _conceptosSeleccionados, _fechaActual, ModoValidacionInput.MediosPagoTarjeta);

                if (!resultadoInputs.AusenciaCamposVacios)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }

                if (resultadoInputs.ExistenciaErrores)
                {
                    throw new Exception(resultadoInputs.MensajeErrores);
                }

                this.Hide();
                Form_Comprobante_Pago formComprobantePago = new Form_Comprobante_Pago(_fechaActual, _montoAAbonar, _conceptosSeleccionados);
                formComprobantePago.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón "Atras".
        /// Oculta el formulario actual y muestra el formulario principal de pagos.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Pagos_Principal formPagosPrincipal = new Form_Pagos_Principal();
            formPagosPrincipal.Show();
        }
    }
}
