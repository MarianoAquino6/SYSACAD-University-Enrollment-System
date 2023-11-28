using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
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

namespace Forms_TP_SYSACAD.Administrador.Reportes
{
    public partial class Form_Reporte_Listas_Espera : Form
    {
        private Dictionary<Curso, Dictionary<string, DateTime>> _cursosConListaDeEsperaSegunFechas = new Dictionary<Curso, Dictionary<string, DateTime>>();
        private DateTime _fechaDesde;
        private DateTime _fechaHasta;

        /// <summary>
        /// Constructor de la clase Form_Reporte_Listas_Espera.
        /// Inicializa los componentes visuales, asigna los parámetros recibidos a los atributos correspondientes,
        /// y muestra la lista de espera en el control ListView del formulario.
        /// </summary>
        /// <param name="cursosConListaDeEsperaSegunFechas">Diccionario que contiene información sobre listas de espera por curso y fecha.</param>
        /// <param name="fechaDesde">Fecha desde la cual se filtran las listas de espera.</param>
        /// <param name="fechaHasta">Fecha hasta la cual se filtran las listas de espera.</param>
        public Form_Reporte_Listas_Espera(Dictionary<Curso, Dictionary<string, DateTime>> cursosConListaDeEsperaSegunFechas, DateTime fechaDesde, DateTime fechaHasta)
        {
            InitializeComponent();

            _cursosConListaDeEsperaSegunFechas = cursosConListaDeEsperaSegunFechas;
            _fechaDesde = fechaDesde;
            _fechaHasta = fechaHasta;

            MostrarListaDeEspera();

            btnPanel.Text = "Volver al Panel";
            btnPDF.Text = "Descargar PDF";
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde, y capacidad de maximizar y minimizar.
        /// </summary>
        private void Form_Reporte_Listas_Espera_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Reporte de Listas de Espera";
        }

        /// <summary>
        /// Muestra la lista de espera en el control ListView del formulario.
        /// </summary>
        private void MostrarListaDeEspera()
        {

            foreach (var parClaveValor in _cursosConListaDeEsperaSegunFechas)
            {
                string nombre = parClaveValor.Key.Nombre;
                string turno = parClaveValor.Key.Turno;

                foreach (var parKeyValue in parClaveValor.Value)
                {
                    string alumno = parKeyValue.Key;
                    DateTime fecha = parKeyValue.Value;

                    ListViewItem nuevaFila = new ListViewItem(nombre);
                    nuevaFila.SubItems.Add(turno);
                    nuevaFila.SubItems.Add(alumno);
                    nuevaFila.SubItems.Add(fecha.ToString());

                    listViewListasEspera.Items.Add(nuevaFila);
                }
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón "Descargar PDF".
        /// Genera un archivo PDF con la información de las listas de espera y muestra un mensaje indicando el resultado de la generación.
        /// </summary>
        private void btnPDF_Click(object sender, EventArgs e)
        {
            string fechaYHora = DateTime.Now.ToString("dd-MM-yyyy HH.mm");
            string fechaDesde = _fechaDesde.ToString("dd-MM-yyyy");
            string fechaHasta = _fechaHasta.ToString("dd-MM-yyyy");

            string nombreArchivoPDF = $"Reporte lista de espera {fechaYHora}.pdf";

            bool resultadoGeneracionPfd = GeneradorDePDF.GenerarPDFListaEspera(nombreArchivoPDF, _cursosConListaDeEsperaSegunFechas,
                fechaYHora, fechaDesde, fechaHasta);

            if (resultadoGeneracionPfd)
            {
                MessageBox.Show("Se ha guardado el archivo PDF en la carpeta 'Listas de Espera' localizada en 'Documentos/SYSACAD/Reportes PDF'", "PDF Generado Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
