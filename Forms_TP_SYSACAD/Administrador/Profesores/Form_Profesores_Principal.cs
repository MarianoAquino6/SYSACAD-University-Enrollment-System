using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_TP_SYSACAD.Administrador.Profesores
{
    public partial class Form_Profesores_Principal : Form
    {
        private List<Profesor> _listaProfesores = new List<Profesor>();
        private Profesor _profesorSeleccionado;
        private GestorProfesores _gestorProfesores = new GestorProfesores();

        /// <summary>
        /// Constructor de la clase Form_Profesores_Principal.
        /// Inicializa los componentes visuales, configura el formulario y muestra la lista de profesores.
        /// </summary>
        public Form_Profesores_Principal()
        {
            InitializeComponent();
            lblInfo.Text = "INFORMACION DE PROFESORES:";
            btnAtras.Text = "Atras";
            btnAgregar.Text = "Agregar Profesor";
            btnEditar.Text = "Editar Profesor";
            btnAgregarCurso.Text = "Asignar Curso";
            btnEliminar.Text = "Eliminar Profesor";

            MostrarProfesores();
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde, y capacidad de maximizar y minimizar.
        /// </summary>
        private void Form_Profesores_Principal_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Gestion de Profesores";

            listViewProfesores.MultiSelect = false;
            listViewProfesores.FullRowSelect = true;
        }

        /// <summary>
        /// Actualiza el contenido de la listViewProfesores con la lista actualizada de profesores.
        /// </summary>
        private void MostrarProfesores()
        {
            listViewProfesores.Items.Clear();

            _listaProfesores = ConsultasProfesores.Profesores;

            // Itero a través de la lista de cursos disponibles y agrega cada curso a la listView
            if (_listaProfesores.Count > 0)
            {
                foreach (Profesor profesor in _listaProfesores)
                {
                    ListViewItem nuevaFila = new ListViewItem(profesor.Nombre);
                    nuevaFila.SubItems.Add(profesor.Correo);
                    nuevaFila.SubItems.Add(profesor.Telefono);
                    nuevaFila.SubItems.Add(profesor.Especializacion);
                    nuevaFila.SubItems.Add(string.Join(", ", profesor.CodigosCursosDeProfesor));
                    nuevaFila.SubItems.Add(profesor.Direccion);

                    listViewProfesores.Items.Add(nuevaFila);
                }
            }
        }

        /// <summary>
        /// Maneja el evento ItemSelectionChanged de la listViewProfesores.
        /// Captura los datos del profesor seleccionado y los almacena en _profesorSeleccionado.
        /// </summary>
        private void listViewProfesores_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem cursoSeleccionadoEnListView = e.Item;

            string nombreProfesorSeleccionado = cursoSeleccionadoEnListView.SubItems[0].Text;
            string correoProfesorSeleccionado = cursoSeleccionadoEnListView.SubItems[1].Text;
            string telefonoProfesorSeleccionado = cursoSeleccionadoEnListView.SubItems[2].Text;
            string especializacionProfesorSeleccionado = cursoSeleccionadoEnListView.SubItems[3].Text;
            List<string> cursosProfesorSeleccionado = new List<string>(cursoSeleccionadoEnListView.SubItems[4].Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries));
            string direccionProfesorSeleccionado = cursoSeleccionadoEnListView.SubItems[5].Text;

            //Creo una copia del curso seleccionado
            _profesorSeleccionado = new Profesor(nombreProfesorSeleccionado, direccionProfesorSeleccionado, telefonoProfesorSeleccionado, correoProfesorSeleccionado, especializacionProfesorSeleccionado, cursosProfesorSeleccionado);
        }

        /// <summary>
        /// Maneja el evento Click del botón Agregar Profesor.
        /// Oculta el formulario actual y muestra el formulario Form_Agregar_Profesor.
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Agregar_Profesor formAgregarProfesor = new Form_Agregar_Profesor();
            formAgregarProfesor.Show();
        }

        /// <summary>
        /// Maneja el evento Click del botón Editar Profesor.
        /// Oculta el formulario actual y muestra el formulario Form_Editar_Profesor si hay profesores agregados.
        /// Muestra un mensaje de error si no hay profesores seleccionados.
        /// </summary>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verifica si no se han agregado cursos
            if (_listaProfesores.Count == 0)
            {
                MessageBox.Show("Primero debe agregar profesores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_profesorSeleccionado is null)
            {
                MessageBox.Show("Debe seleccionar algun profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Form_Editar_Profesor nuevoFormEditarProfesor = new Form_Editar_Profesor(_profesorSeleccionado);
                nuevoFormEditarProfesor.Show();
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón Eliminar Profesor.
        /// Elimina el profesor seleccionado, actualiza la lista y la vista.
        /// Muestra un mensaje de error si no hay profesores seleccionados.
        /// </summary>
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifico si al menos una fila está seleccionada
            if (listViewProfesores.SelectedItems.Count > 0 && _profesorSeleccionado != null)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el profesor seleccionado?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    //Elimino el curso de la BD
                    await _gestorProfesores.EliminarProfesor(_profesorSeleccionado.Correo);

                    // Elimina el curso de la lista local
                    _listaProfesores.Remove(_profesorSeleccionado);

                    //Actualizo el listView
                    MostrarProfesores();
                }
                else
                {
                    // El usuario presiono "Cancelar" y no se realiza ninguna acción
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar algun profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón Asignar Curso.
        /// Oculta el formulario actual y muestra el formulario Form_Agregar_Curso_A_Profesor si hay profesores agregados.
        /// Muestra un mensaje de error si no hay profesores seleccionados.
        /// </summary>
        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            // Verifica si no se han agregado cursos
            if (_listaProfesores.Count == 0)
            {
                MessageBox.Show("Primero debe agregar profesores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_profesorSeleccionado is null)
            {
                MessageBox.Show("Debe seleccionar algun profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Form_Agregar_Curso_A_Profesor formAgregaCursoProfesor = new Form_Agregar_Curso_A_Profesor(_profesorSeleccionado);
                formAgregaCursoProfesor.Show();
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón Atras.
        /// Oculta el formulario actual y muestra el formulario Form_Panel_Administracion.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Panel_Administracion formPanelAdministrador = new Form_Panel_Administracion();
            formPanelAdministrador.Show();
        }
    }
}
