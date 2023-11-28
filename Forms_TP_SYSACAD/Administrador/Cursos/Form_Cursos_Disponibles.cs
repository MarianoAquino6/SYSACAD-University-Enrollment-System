using Libreria_Clases_TP_SYSACAD;
using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Gestores;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
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

namespace Forms_TP_SYSACAD
{
    public partial class Form_Cursos_Disponibles : Form
    {
        private List<Curso> _listaCursosDisponibles = new List<Curso>();
        private Curso _cursoSeleccionado;
        private GestorCursos _gestorCursos = new GestorCursos();

        /// <summary>
        /// Constructor por defecto de la clase Form_Cursos_Disponibles.
        /// Inicializa los componentes del formulario, configura elementos visuales y muestra los cursos disponibles.
        /// </summary>
        public Form_Cursos_Disponibles()
        {
            InitializeComponent();
            lblInfoCursos.Text = "INFORMACION DE CURSOS ACTUALES:";
            btnAgregar.Text = "Agregar Curso";
            btnModificar.Text = "Editar Curso";
            btnEliminar.Text = "Eliminar Curso";
            btnAtras.Text = "Atras";

            MostrarCursosDisponibles();
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario.
        /// Configura la posición, estilo y título del formulario, así como propiedades del control ListView.
        /// </summary>
        private void Form_Cursos_Disponibles_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Gestion de Cursos";

            listView1.MultiSelect = false;
            listView1.FullRowSelect = true;
        }

        /// <summary>
        /// Método privado que actualiza el control ListView con la lista de cursos disponibles.
        /// </summary>
        private void MostrarCursosDisponibles()
        {
            listView1.Items.Clear();

            _listaCursosDisponibles = ConsultasCursos.Cursos;

            if (_listaCursosDisponibles.Count > 0)
            {
                foreach (Curso curso in _listaCursosDisponibles)
                {
                    ListViewItem nuevaFila = new ListViewItem(curso.Nombre);
                    nuevaFila.SubItems.Add(curso.Codigo);
                    nuevaFila.SubItems.Add(curso.Descripcion);
                    nuevaFila.SubItems.Add(curso.CupoMaximo.ToString());
                    nuevaFila.SubItems.Add(curso.CupoDisponible.ToString());
                    nuevaFila.SubItems.Add(curso.Turno);
                    nuevaFila.SubItems.Add(curso.Dia);
                    nuevaFila.SubItems.Add(curso.Aula);
                    nuevaFila.SubItems.Add(curso.Carrera.ToString());

                    listView1.Items.Add(nuevaFila);
                }
            }
        }

        /// <summary>
        /// Evento que se ejecuta al cambiar la selección de un elemento en el ListView.
        /// Actualiza la variable _cursoSeleccionado con la información del curso seleccionado.
        /// </summary>
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem cursoSeleccionadoEnListView = e.Item;

            string nombreCursoSeleccinado = cursoSeleccionadoEnListView.SubItems[0].Text;
            string codigoCursoSeleccionado = cursoSeleccionadoEnListView.SubItems[1].Text;
            string descripcionCursoSeleccionado = cursoSeleccionadoEnListView.SubItems[2].Text;
            int cupoCursoSeleccionado = int.Parse(cursoSeleccionadoEnListView.SubItems[3].Text);
            string turnoCursoSeleccinado = cursoSeleccionadoEnListView.SubItems[5].Text;
            string diaCursoSeleccionado = cursoSeleccionadoEnListView.SubItems[6].Text;
            string aulaCursoSeleccionado = cursoSeleccionadoEnListView.SubItems[7].Text;
            Carrera carreraCursoSeleccionado = (Carrera)Enum.Parse(typeof(Carrera), cursoSeleccionadoEnListView.SubItems[8].Text);

            _cursoSeleccionado = new Curso(nombreCursoSeleccinado, codigoCursoSeleccionado,
                descripcionCursoSeleccionado, cupoCursoSeleccionado, turnoCursoSeleccinado,
                aulaCursoSeleccionado, diaCursoSeleccionado, carreraCursoSeleccionado);
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Agregar Curso".
        /// Oculta el formulario actual y muestra el formulario para agregar un nuevo curso.
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Agregar_Curso nuevoFormAgregarCurso = new Form_Agregar_Curso();
            nuevoFormAgregarCurso.Show();
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Editar Curso".
        /// Verifica la existencia de cursos y que se haya seleccionado uno antes de mostrar el formulario de edición.
        /// </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Verifica si no se han agregado cursos
            if (_listaCursosDisponibles.Count == 0)
            {
                MessageBox.Show("Primero debe agregar cursos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_cursoSeleccionado is null)
            {
                MessageBox.Show("Debe seleccionar algun curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Form_Editar_Curso nuevoFormEditarCurso = new Form_Editar_Curso(_cursoSeleccionado);
                nuevoFormEditarCurso.Show();
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Eliminar Curso".
        /// Verifica la existencia de cursos y que se haya seleccionado uno antes de eliminarlo.
        /// </summary>
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifico si al menos una fila está seleccionada
            if (listView1.SelectedItems.Count > 0 && _cursoSeleccionado != null)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el curso seleccionado?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    //Elimino el curso de la BD
                    await _gestorCursos.EliminarCurso(_cursoSeleccionado.Codigo);

                    // Elimina el curso de la lista local
                    _listaCursosDisponibles.Remove(_cursoSeleccionado);

                    //Actualizo el listView
                    MostrarCursosDisponibles();
                }
                else
                {
                    // El usuario presiono "Cancelar" y no se realiza ninguna acción
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar algun curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Atras".
        /// Oculta el formulario actual y muestra el formulario principal de administración.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Panel_Administracion formPanelAdministrador = new Form_Panel_Administracion();
            formPanelAdministrador.Show();
        }
    }
}
