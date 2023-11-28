using Libreria_Clases_TP_SYSACAD;
using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
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
    public enum FuncionReporte
    {
        InscripcionesTotalesPorPeriodo,
        InscripcionesPorCursoPeriodo,
        IngresosPorConceptoPeriodo,
        InscripcionesPorCarreraPeriodo,
        ListaEspera
    }

    public partial class Form_Reportes_Principal : Form
    {
        private FuncionReporte _funcionSeleccionada = FuncionReporte.InscripcionesTotalesPorPeriodo;

        /// <summary>
        /// Constructor de la clase Form_Reportes_Principal.
        /// Inicializa los componentes visuales y configura las opciones iniciales del formulario.
        /// </summary>
        public Form_Reportes_Principal()
        {
            InitializeComponent();

            lblInfo.Text = "Seleccione el tipo de informe:";

            rbInscripcionPeriodo.Text = "Cantidad de inscripciones totales por periodo";
            rbCantidadPorCurso.Text = "Cantidad de inscripciones por curso y periodo";
            rbIngresosPorConcepto.Text = "Ingresos por concepto de pago y periodo";
            rbInscripcionPorCarrera.Text = "Inscripciones por carrera y periodo";
            rbListasDeEspera.Text = "Listas de esperas por periodo";
            rbInscripcionPeriodo.Checked = true;

            btnAtras.Text = "Atras";
            btnGenerarInforme.Text = "Generar Informe";
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde y capacidad de maximizar y minimizar.
        /// </summary>
        private void Form_Reportes_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Generar Reportes";
        }

        private void rbInscripcionPeriodo_Click(object sender, EventArgs e)
        {
            rbInscripcionPeriodo.Checked = true;
            rbCantidadPorCurso.Checked = false;
            rbIngresosPorConcepto.Checked = false;
            rbInscripcionPorCarrera.Checked = false;
            rbListasDeEspera.Checked = false;
            _funcionSeleccionada = FuncionReporte.InscripcionesTotalesPorPeriodo;
        }

        private void rbCantidadPorCurso_Click(object sender, EventArgs e)
        {
            rbInscripcionPeriodo.Checked = false;
            rbCantidadPorCurso.Checked = true;
            rbIngresosPorConcepto.Checked = false;
            rbInscripcionPorCarrera.Checked = false;
            rbListasDeEspera.Checked = false;
            _funcionSeleccionada = FuncionReporte.InscripcionesPorCursoPeriodo;
        }

        private void rbIngresosPorConcepto_Click(object sender, EventArgs e)
        {
            rbInscripcionPeriodo.Checked = false;
            rbCantidadPorCurso.Checked = false;
            rbIngresosPorConcepto.Checked = true;
            rbInscripcionPorCarrera.Checked = false;
            rbListasDeEspera.Checked = false;
            _funcionSeleccionada = FuncionReporte.IngresosPorConceptoPeriodo;
        }

        private void rbInscripcionPorCarrera_Click(object sender, EventArgs e)
        {
            rbInscripcionPeriodo.Checked = false;
            rbCantidadPorCurso.Checked = false;
            rbIngresosPorConcepto.Checked = false;
            rbInscripcionPorCarrera.Checked = true;
            rbListasDeEspera.Checked = false;
            _funcionSeleccionada = FuncionReporte.InscripcionesPorCarreraPeriodo;
        }

        private void rbListasDeEspera_Click(object sender, EventArgs e)
        {
            rbInscripcionPeriodo.Checked = false;
            rbCantidadPorCurso.Checked = false;
            rbIngresosPorConcepto.Checked = false;
            rbInscripcionPorCarrera.Checked = false;
            rbListasDeEspera.Checked = true;
            _funcionSeleccionada = FuncionReporte.ListaEspera;
        }

        /// <summary>
        /// Maneja el evento Click del botón "Generar Informe".
        /// Dependiendo de la función de reporte seleccionada, abre el formulario correspondiente para obtener los parámetros del informe.
        /// </summary>
        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            List<RegistroDeInscripcion> registrosDeInscripciones = ConsultasInscripciones.Inscripciones;
            List<RegistroDePago> registrosDePagos = ConsultasPagos.Pagos;

            switch (_funcionSeleccionada)
            {
                case FuncionReporte.InscripcionesTotalesPorPeriodo:
                    if (registrosDeInscripciones.Count > 0)
                    {
                        Form_Input_Reporte_Periodo formInputReportePeriodo = new Form_Input_Reporte_Periodo(this, FuncionReporte.InscripcionesTotalesPorPeriodo);
                        formInputReportePeriodo.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Aun no existen registros de inscripciones en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case FuncionReporte.InscripcionesPorCursoPeriodo:
                    if (registrosDeInscripciones.Count > 0)
                    {
                        Form_Input_Reporte_ComboBox_Periodo formInputReporteComboPeriodo = new Form_Input_Reporte_ComboBox_Periodo(_funcionSeleccionada, this);
                        formInputReporteComboPeriodo.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Aun no existen registros de inscripciones en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case FuncionReporte.IngresosPorConceptoPeriodo:
                    if (registrosDePagos.Count > 0)
                    {
                        Form_Input_Reporte_ComboBox_Periodo formInputReporteComboPeriodo = new Form_Input_Reporte_ComboBox_Periodo(_funcionSeleccionada, this);
                        formInputReporteComboPeriodo.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Aun no existen registros de pagos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case FuncionReporte.InscripcionesPorCarreraPeriodo:
                    if (registrosDeInscripciones.Count > 0)
                    {
                        Form_Input_Reporte_ComboBox_Periodo formInputReporteComboPeriodo = new Form_Input_Reporte_ComboBox_Periodo(_funcionSeleccionada, this);
                        formInputReporteComboPeriodo.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Aun no existen registros de inscripciones en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case FuncionReporte.ListaEspera:
                    bool hayListaDeEspera = ConsultasCursos.HallarSiHayAlgunCursoConListaDeEspera();

                    if (hayListaDeEspera)
                    {
                        Form_Input_Reporte_Periodo formInputReportePeriodo = new Form_Input_Reporte_Periodo(this, FuncionReporte.ListaEspera);
                        formInputReportePeriodo.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Aun no existen registros de listas de espera en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón "Atras".
        /// Oculta el formulario actual y muestra el formulario de administración.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Panel_Administracion formPanelAdministracion = new Form_Panel_Administracion();
            formPanelAdministracion.Show();
        }
    }
}
