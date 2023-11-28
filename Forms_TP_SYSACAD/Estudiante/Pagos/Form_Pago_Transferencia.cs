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
    public partial class Form_Pago_Transferencia : Form
    {
        private string _nombreRemitente;
        private string _cuentaRemitente;
        private string _montoAAbonar;
        private DateTime _fechaActual;
        private Dictionary<string, double> _conceptosSeleccionados = new Dictionary<string, double>();
        private GestorPagos _gestorPagos = new GestorPagos();

        /// <summary>
        /// Constructor de la clase Form_Pago_Transferencia.
        /// </summary>
        /// <param name="montoAAbonar">Monto a abonar mediante transferencia bancaria.</param>
        /// <param name="conceptosSeleccionados">Conceptos seleccionados para el pago.</param>
        public Form_Pago_Transferencia(double montoAAbonar, Dictionary<string, double> conceptosSeleccionados)
        {
            InitializeComponent();

            lblRemitente.Text = "Datos del Remitente: ";
            lblNombreRemit.Text = "Nombre";
            lblCuentaRemit.Text = "Numero de Cuenta (CBU)";
            lblBeneficiario.Text = "Datos del Beneficiario";
            lblNombreBenef.Text = "Nombre: UTNFra";
            lblCuentaBenef.Text = "Numero de Cuenta (CBU): 2112154954879536524011";

            _montoAAbonar = montoAAbonar.ToString();
            lblMonto.Text = $"Monto a Abonar: ${_montoAAbonar}";

            btnAtras.Text = "Atras";
            btnContinuar.Text = "Pagar";

            tbNombreRemit.PlaceholderText = "Apellido Nombre";
            tbCuentaRemit.PlaceholderText = "Ingrese los 22 digitos del CBU";

            _fechaActual = DateTime.Now;
            _conceptosSeleccionados = conceptosSeleccionados;
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde y capacidad de maximizar y minimizar.
        /// </summary>
        private void Form_Pago_Transferencia_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Text = "Pagar con Transferencia Bancaria";
        }

        private void tbNombreRemit_TextChanged(object sender, EventArgs e)
        {
            _nombreRemitente = tbNombreRemit.Text;
        }

        private void tbCuentaRemit_TextChanged(object sender, EventArgs e)
        {
            _cuentaRemitente = tbCuentaRemit.Text;
        }

        /// <summary>
        /// Maneja el evento Click del botón "Continuar".
        /// Realiza la validación y procesamiento del pago mediante transferencia bancaria.
        /// </summary>
        private async void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    { "nombre", _nombreRemitente },
                    { "CBU", _cuentaRemitente }
                };

                RespuestaValidacionInput resultadoInputs = await _gestorPagos.GestionarPago(camposIngresados, _conceptosSeleccionados, _fechaActual, ModoValidacionInput.MediosPagoTransferencia);

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
