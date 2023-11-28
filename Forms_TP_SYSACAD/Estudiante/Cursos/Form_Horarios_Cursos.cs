using Libreria_Clases_TP_SYSACAD;
using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Gestores;
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
    public partial class Form_Horarios_Cursos : Form
    {
        private GestorCursos _gestorCursos = new GestorCursos();

        /// <summary>
        /// Constructor de la clase Form_Horarios_Cursos.
        /// Inicializa los componentes visuales y muestra los horarios de los cursos inscritos por el estudiante logueado.
        /// </summary>
        public Form_Horarios_Cursos()
        {
            InitializeComponent();

            btnAtras.Text = "Atras";

            MostrarHorariosListView(Sistema.EstudianteLogueado);
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde y capacidad de maximizar y minimizar.
        /// </summary>
        private void Form_Horarios_Cursos_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Text = "Consultar Horarios";
        }

        /// <summary>
        /// Muestra los horarios de los cursos del estudiante en el ListView.
        /// </summary>
        private void MostrarHorariosListView(Estudiante estudianteLogeado)
        {
            listViewHorarios.Items.Clear();

            // Obtengo la lista de cursos del estudiante
            List<Curso> listaCursosAlumno = _gestorCursos.ObtenerListaCursosDesdeListaCodigos(estudianteLogeado.CursosInscriptos);

            foreach (Curso curso in listaCursosAlumno)
            {
                ListViewItem nuevaFila = new ListViewItem(curso.Nombre);
                nuevaFila.SubItems.Add(curso.DevolverHorario());
                nuevaFila.SubItems.Add(curso.Dia);
                nuevaFila.SubItems.Add(curso.Aula);

                listViewHorarios.Items.Add(nuevaFila);
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón "Atras".
        /// Oculta el formulario actual y muestra el formulario del panel del estudiante.
        /// </summary>
        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form_Panel_Estudiante formPanelEstudiante = new Form_Panel_Estudiante();
            formPanelEstudiante.Show();
        }
    }
}
