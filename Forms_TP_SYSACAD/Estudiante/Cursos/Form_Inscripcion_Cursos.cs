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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_TP_SYSACAD
{
    public partial class Form_Inscripcion_Cursos : Form
    {
        private List<Curso> _cursosSeleccionados = new List<Curso>();
        private GestorCursos _gestorCursos = new GestorCursos();

        /// <summary>
        /// Constructor de la clase Form_Inscripcion_Cursos.
        /// Inicializa los componentes visuales y muestra los cursos disponibles para la inscripción.
        /// </summary>
        public Form_Inscripcion_Cursos()
        {
            InitializeComponent();

            lblInfoCursos.Text = "Cursos disponibles:";
            lblCreditos.Text = $"Creditos del estudiante: {Sistema.EstudianteLogueado.Creditos}";
            lblPromedio.Text = $"Promedio del estudiante: {Sistema.EstudianteLogueado.Promedio}";
            btnAtras.Text = "Atras";
            btnInscribirse.Text = "Inscribirse";

            MostrarListView();
        }

        /// <summary>
        /// Muestra los cursos disponibles en el ListView, excluyendo los cursos en los que el estudiante ya está inscrito.
        /// </summary>
        private void MostrarListView()
        {
            listViewCursosEst.Items.Clear();

            // Cargo TODOS los cursos
            List<Curso> _listaCursosDisponibles = ConsultasCursos.Cursos;

            // Si hay cursos en la BD
            if (_listaCursosDisponibles.Count > 0)
            {
                List<Curso> cursosPertenecientesAlEstudiante = new List<Curso>();

                //Corroboro si el estudiante ya esta inscripto a algun curso
                if (Sistema.EstudianteLogueado.CursosInscriptos.Count > 0)
                {
                    cursosPertenecientesAlEstudiante = _gestorCursos.ObtenerListaCursosDesdeListaCodigos(Sistema.EstudianteLogueado.CursosInscriptos);
                }

                //Solo muestro aquellos cursos en los cuales el estudiante aun NO se encuentra inscripto
                foreach (Curso curso in _listaCursosDisponibles)
                {
                    // Verifica si el curso no está en la lista de cursos del estudiante
                    if (!cursosPertenecientesAlEstudiante.Any(cursoEstudiante => cursoEstudiante.Codigo == curso.Codigo))
                    {
                        ListViewItem nuevaFila = new ListViewItem(curso.Nombre);
                        nuevaFila.SubItems.Add(curso.Codigo);
                        nuevaFila.SubItems.Add(curso.Descripcion);
                        nuevaFila.SubItems.Add(curso.CupoMaximo.ToString());
                        nuevaFila.SubItems.Add(curso.CupoDisponible.ToString());
                        nuevaFila.SubItems.Add(curso.Turno);
                        nuevaFila.SubItems.Add(curso.Dia);
                        nuevaFila.SubItems.Add(curso.Aula);
                        nuevaFila.SubItems.Add(curso.CreditosRequeridos.ToString());
                        nuevaFila.SubItems.Add(curso.PromedioRequerido.ToString());
                        nuevaFila.SubItems.Add(curso.Carrera.ToString());

                        // Agrega el ListViewItem al ListView
                        listViewCursosEst.Items.Add(nuevaFila);
                    }
                }
            }
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde y capacidad de maximizar y minimizar.
        /// </summary>
        private void Form_Inscripcion_Cursos_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            listViewCursosEst.FullRowSelect = true;

            this.Text = "Inscripcion a cursos";
        }

        /// <summary>
        /// Maneja el evento ItemSelectionChanged del ListView.
        /// Actualiza la lista de cursos seleccionados al cambiar la selección en el ListView.
        /// </summary>
        private void listViewCursosEst_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _cursosSeleccionados.Clear();

            foreach (ListViewItem item in listViewCursosEst.SelectedItems)
            {
                string nombre = item.SubItems[0].Text;
                string codigo = item.SubItems[1].Text;
                string descripcion = item.SubItems[2].Text;
                int cupoMaximo = int.Parse(item.SubItems[3].Text);
                string turno = item.SubItems[5].Text;
                string dia = item.SubItems[6].Text;
                string aula = item.SubItems[7].Text;
                Carrera carrera = (Carrera)Enum.Parse(typeof(Carrera), item.SubItems[8].Text);

                Curso curso = _gestorCursos.ObtenerCursoDesdeCodigo(codigo);

                _cursosSeleccionados.Add(curso);
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón "Inscribirse".
        /// Realiza el proceso de inscripción a los cursos seleccionados.
        /// </summary>
        private async void btnInscribirse_Click(object sender, EventArgs e)
        {
            // Creo una instancia del validador y administrador de cupos y valido
            ValidadorDeInscripciones nuevaValidacion = new ValidadorDeInscripciones();
            ValidacionInscripcionResultado resultadoValidacion = await nuevaValidacion.ValidarCursosSegunCupo(_cursosSeleccionados);

            switch (resultadoValidacion)
            {
                case ValidacionInscripcionResultado.SinSeleccion:
                    MessageBox.Show("No ha seleccionado ningun curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case ValidacionInscripcionResultado.Exitoso:
                    MostrarListView();
                    MessageBox.Show("Se ha registrado exitosamente a todos los cursos seleccionados", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case ValidacionInscripcionResultado.NoCumpleNingunRequisito:
                    MessageBox.Show("No cumple los requisitos académicos para inscribirse a ningun curso que selecciono", "No cumple los requisitos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ValidacionInscripcionResultado.NoCumpleAlgunosRequisitos:
                    MostrarListView();
                    MessageBox.Show("No cumple los requisitos academicos para inscribirse a algunos de los cursos seleccionados. Sin embargo, se ha inscripto en aquellos que cumple", "No cumple los requisitos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ValidacionInscripcionResultado.SinCupoAbsoluto:
                    MostrarListView();
                    MessageBox.Show("No se ha podido inscribir a ninguno de los cursos seleccionados. Ha sido agregado a la lista de espera", "Cupos Agotados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ValidacionInscripcionResultado.SinCupoParcial:
                    MostrarListView();
                    List<string> cursosSinCupo = nuevaValidacion.CursosSinCupo;

                    string mensaje = "Se ha inscripto exitosamente en los cursos seleccionados, excepto en: " + string.Join(", ", cursosSinCupo + "Ha sido agregado a la lista de espera");
                    MessageBox.Show(mensaje, "Cupos Agotados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

            // Restablecer la lista de cursos seleccionados
            _cursosSeleccionados.Clear();
        }

        /// <summary>
        /// Maneja el evento Click del botón "Atras".
        /// Oculta el formulario actual y muestra el formulario del panel del estudiante.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Panel_Estudiante formPanelEst = new Form_Panel_Estudiante();
            formPanelEst.Show();
        }
    }
}
