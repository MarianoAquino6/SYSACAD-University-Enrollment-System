using Libreria_Clases_TP_SYSACAD;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Gestores;
using Libreria_Clases_TP_SYSACAD.Herramientas;
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
    public partial class Form_Reporte_Ingresos : Form
    {
        private List<RegistroDePago> _listaRegistrosAMostrar;
        private int _pagosTotales;
        private double _ingresosTotales;
        private DateTime _fechaPopular;
        private DateTime _fechaDesdeRecibida;
        private DateTime _fechaHastaRecibida;
        private GestorReportes _gestorReportes = new GestorReportes();

        /// <summary>
        /// Constructor de la clase Form_Reporte_Ingresos.
        /// Inicializa los componentes visuales, muestra la lista de registros de pago,
        /// y calcula estadísticas relevantes para mostrar en el formulario.
        /// </summary>
        /// <param name="listaRegistrosAMostrar">Lista de registros de pago a mostrar.</param>
        /// <param name="fechaDesde">Fecha desde la cual se filtran los registros.</param>
        /// <param name="fechaHasta">Fecha hasta la cual se filtran los registros.</param>
        public Form_Reporte_Ingresos(List<RegistroDePago> listaRegistrosAMostrar, DateTime fechaDesde, DateTime fechaHasta)
        {
            InitializeComponent();

            MostrarRegistrosDeInscripcion(listaRegistrosAMostrar);

            _listaRegistrosAMostrar = listaRegistrosAMostrar;
            _pagosTotales = _gestorReportes.CalcularRegistrosTotales(listaRegistrosAMostrar);
            _ingresosTotales = _gestorReportes.CalcularMontoIngresosTotales(listaRegistrosAMostrar);
            _fechaPopular = _gestorReportes.CalcularFechaMasPopular(listaRegistrosAMostrar);

            _fechaDesdeRecibida = fechaDesde;
            _fechaHastaRecibida = fechaHasta;

            lblInfo.Text = "Estadisticas:";
            lblCantidadDeRegistros.Text = $"Pagos totales: {_pagosTotales}";
            lblIngresosTotales.Text = $"Ingresos totales del concepto: ${_ingresosTotales}";
            lblFechaPopular.Text = $"Fecha con mayor cantidad de pagos: {_fechaPopular.Date.ToString("dd/MM/yyyy")}";

            btnPanel.Text = "Volver al Panel";
            btnPDF.Text = "Descargar PDF";
        }

        /// <summary>
        /// Muestra los registros de pago en el control ListView del formulario.
        /// </summary>
        /// <param name="listaRegistrosAMostrar">Lista de registros de pago a mostrar.</param>
        private void MostrarRegistrosDeInscripcion(List<RegistroDePago> listaRegistrosAMostrar)
        {
            listViewPagos.Items.Clear();

            foreach (RegistroDePago registro in listaRegistrosAMostrar)
            {
                ListViewItem nuevaFila = new ListViewItem(registro.Concepto);
                nuevaFila.SubItems.Add(registro.NombreEstudiante);
                nuevaFila.SubItems.Add(registro.Legajo);
                nuevaFila.SubItems.Add(registro.Ingreso.ToString());
                nuevaFila.SubItems.Add(registro.Fecha.ToString());

                listViewPagos.Items.Add(nuevaFila);
            }
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde, y capacidad de maximizar y minimizar.
        /// </summary>
        private void Form_Reporte_Ingresos_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Reporte de Ingresos";
        }

        /// <summary>
        /// Maneja el evento Click del botón "Descargar PDF".
        /// Genera un archivo PDF con la información de los registros de pago y estadísticas,
        /// y muestra un mensaje indicando el resultado de la generación.
        /// </summary>
        private void btnPDF_Click(object sender, EventArgs e)
        {
            string fechaYHora = DateTime.Now.ToString("dd-MM-yyyy HH.mm");
            string fechaDesde = _fechaDesdeRecibida.ToString("dd-MM-yyyy");
            string fechaHasta = _fechaHastaRecibida.ToString("dd-MM-yyyy");

            string nombreArchivoPDF = $"Reporte Pagos {fechaYHora}.pdf";
            bool resultadoGeneracionPfd = GeneradorDePDF.GenerarPDFIngresos(nombreArchivoPDF, _listaRegistrosAMostrar, _pagosTotales,
                _ingresosTotales, _fechaPopular, fechaYHora, fechaDesde, fechaHasta);

            if (resultadoGeneracionPfd)
            {
                MessageBox.Show("Se ha guardado el archivo PDF en la carpeta 'Ingresos' localizada en 'Documentos/SYSACAD/Reportes PDF'", "PDF Generado Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No ha sido posible generar el PDF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón "Volver al Panel".
        /// Oculta el formulario actual y muestra el formulario de administración.
        /// </summary>
        private void btnPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Panel_Administracion formPanelAdministracion = new Form_Panel_Administracion();
            formPanelAdministracion.Show();
        }
    }
}
