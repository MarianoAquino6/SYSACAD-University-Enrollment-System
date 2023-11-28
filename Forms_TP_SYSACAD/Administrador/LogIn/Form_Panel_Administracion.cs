using Forms_TP_SYSACAD.Administrador.Profesores;
using Libreria_Clases_TP_SYSACAD;
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
    public partial class Form_Panel_Administracion : Form
    {
        /// <summary>
        /// Constructor de la clase Form_Panel_Administracion.
        /// Inicializa los componentes visuales y establece los textos iniciales para las etiquetas y botones.
        /// </summary>
        public Form_Panel_Administracion()
        {
            InitializeComponent();
            lblInformacionPanel.Text = "TAREAS:";
            lblOpcionEstudiante.Text = "Estudiantes";
            lblSeccionCursos.Text = "Cursos";
            lblReporte.Text = "Reportes";
            lblRequisitos.Text = "Requisitos";
            lblListasEspera.Text = "Listas de espera";
            lblProfesores.Text = "Profesores";

            btnRegistroEstudiante.Text = "Registrar Alumno";
            btnGestionCursos.Text = "Gestionar Cursos";
            btnReportes.Text = "Generar Reportes";
            btnRequisitos.Text = "Gestionar Requisitos Academicos";
            btnListasEspera.Text = "Manejar Listas de Espera";
            btnProfesores.Text = "Gestionar Profesores";
            btnAtras.Text = "Atras";
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde, y capacidad de maximizar y minimizar.
        /// </summary>
        private void Form_Panel_Administracion_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Panel de Administracion";
        }

        /// <summary>
        /// Maneja el evento Click del botón Registrar Alumno.
        /// Oculta el formulario actual y muestra el formulario Form_Registro_Estudiantes.
        /// </summary>
        private void btnRegistroEstudiante_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Registro_Estudiantes formRegistroEstudiante = new Form_Registro_Estudiantes();
            formRegistroEstudiante.Show();
        }

        /// <summary>
        /// Maneja el evento Click del botón Gestionar Cursos.
        /// Oculta el formulario actual y muestra el formulario Form_Cursos_Disponibles.
        /// </summary>
        private void btnGestionCursos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Cursos_Disponibles nuevoFormCursosDisponibles = new Form_Cursos_Disponibles();
            nuevoFormCursosDisponibles.Show();
        }

        /// <summary>
        /// Maneja el evento Click del botón Atras.
        /// Oculta el formulario actual y muestra el formulario Form_LogIn_Administrador.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_LogIn_Administrador nuevoFormLogIn = new Form_LogIn_Administrador();
            nuevoFormLogIn.Show();
        }

        /// <summary>
        /// Maneja el evento Click del botón Generar Reportes.
        /// Oculta el formulario actual y muestra el formulario Form_Reportes_Principal.
        /// </summary>
        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Reportes_Principal nuevoReportesPrincipal = new Form_Reportes_Principal();
            nuevoReportesPrincipal.Show();
        }

        /// <summary>
        /// Maneja el evento Click del botón Gestionar Requisitos Académicos.
        /// Oculta el formulario actual y muestra el formulario Form_Gestion_Requisitos.
        /// </summary>
        private void btnRequisitos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Gestion_Requisitos formGestionRequisitos = new Form_Gestion_Requisitos();
            formGestionRequisitos.Show();
        }

        /// <summary>
        /// Maneja el evento Click del botón Manejar Listas de Espera.
        /// Oculta el formulario actual y muestra el formulario Form_Gestion_Listas_Espera.
        /// </summary>
        private void btnListasEspera_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Gestion_Listas_Espera formGestionListasEspera = new Form_Gestion_Listas_Espera();
            formGestionListasEspera.Show();
        }

        /// <summary>
        /// Maneja el evento Click del botón Gestionar Profesores.
        /// Oculta el formulario actual y muestra el formulario Form_Profesores_Principal.
        /// </summary>
        private void btnProfesores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Profesores_Principal formProfesoresPrincipal = new Form_Profesores_Principal();
            formProfesoresPrincipal.Show();
        }
    }
}
