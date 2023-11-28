using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Gestores;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_TP_SYSACAD.Administrador.Profesores
{
    public partial class Form_Agregar_Curso_A_Profesor : Form
    {
        private string _cursoSeleccionado;
        private Profesor _profesorSeleccionado;
        private GestorProfesores _gestorProfesores = new GestorProfesores();

        /// <summary>
        /// Constructor de la clase Form_Agregar_Curso_A_Profesor.
        /// Inicializa los componentes visuales y establece el profesor seleccionado.
        /// Muestra los cursos disponibles para asignar al profesor.
        /// </summary>
        /// <param name="profesorSeleccionado">Profesor al que se le asignarán cursos.</param>
        public Form_Agregar_Curso_A_Profesor(Profesor profesorSeleccionado)
        {
            InitializeComponent();

            lblInfo.Text = "Cursos Disponibles:";
            btnAgregar.Text = "Agregar";
            btnAtras.Text = "Atras";

            _profesorSeleccionado = profesorSeleccionado;

            MostrarCursosDisponibles();
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde, y capacidad de maximizar y minimizar.
        /// Configura la listView de cursos disponibles para seleccionar.
        /// </summary>
        private void Form_Agregar_Curso_A_Profesor_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Asignar Curso a Profesor";

            listViewCursosDisponibles.MultiSelect = false;
            listViewCursosDisponibles.FullRowSelect = true;
        }

        /// <summary>
        /// Muestra en la listView los cursos disponibles que aún no han sido asignados al profesor.
        /// </summary>
        private void MostrarCursosDisponibles()
        {
            listViewCursosDisponibles.Items.Clear();

            // Itero a través de la lista de cursos disponibles y agrega cada curso a la listView
            if (ConsultasCursos.Cursos.Count > 0)
            {
                foreach (Curso curso in ConsultasCursos.Cursos)
                {
                    if (!_profesorSeleccionado.CodigosCursosDeProfesor.Contains(curso.Codigo))
                    {
                        ListViewItem nuevaFila = new ListViewItem(curso.Nombre);
                        nuevaFila.SubItems.Add(curso.Codigo);
                        nuevaFila.SubItems.Add(curso.Dia);
                        nuevaFila.SubItems.Add(curso.Turno);
                        nuevaFila.SubItems.Add(curso.Aula);
                        nuevaFila.SubItems.Add(curso.Carrera.ToString());

                        listViewCursosDisponibles.Items.Add(nuevaFila);
                    }
                }
            }
        }

        /// <summary>
        /// Maneja el evento ItemSelectionChanged de la listView de cursos disponibles.
        /// Actualiza el curso seleccionado al hacer clic en un elemento de la lista.
        /// </summary>
        private void listViewCursosDisponibles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem cursoSeleccionadoEnListView = e.Item;
            string codigoCursoSeleccionado = cursoSeleccionadoEnListView.SubItems[1].Text;

            _cursoSeleccionado = codigoCursoSeleccionado;
        }

        /// <summary>
        /// Maneja el evento Click del botón Atras.
        /// Oculta el formulario actual y muestra el formulario Form_Profesores_Principal.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Profesores_Principal form_Profesores_Principal = new Form_Profesores_Principal();
            form_Profesores_Principal.Show();
        }

        /// <summary>
        /// Maneja el evento Click del botón Agregar.
        /// Asigna el curso seleccionado al profesor y regresa al formulario principal de profesores.
        /// Muestra mensajes de error en caso necesario.
        /// </summary>
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_cursoSeleccionado is null)
            {
                MessageBox.Show("Debe seleccionar algun curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool resultadoValidacion = await _gestorProfesores.GestionarAsignacionCursoAProfesor(_profesorSeleccionado.Correo, _cursoSeleccionado);

                if (resultadoValidacion)
                {
                    this.Hide();
                    Form_Profesores_Principal form_Profesores_Principal = new Form_Profesores_Principal();
                    form_Profesores_Principal.Show();
                }
                else
                {
                    MessageBox.Show("Conflicto de Horarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
