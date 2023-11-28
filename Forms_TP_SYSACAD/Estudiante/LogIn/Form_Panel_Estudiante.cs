using Libreria_Clases_TP_SYSACAD;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
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
    public partial class Form_Panel_Estudiante : Form
    {
        /// <summary>
        /// Constructor de la clase Form_Panel_Estudiante.
        /// Inicializa los componentes visuales y establece textos y acciones para los elementos del formulario.
        /// </summary>
        public Form_Panel_Estudiante()
        {
            InitializeComponent();

            lblInfoPanel.Text = "TAREAS:";
            lblCursos.Text = "Cursos";
            lblPagos.Text = "Pagos:";
            lblHorarios.Text = "Horarios";
            btnPagos.Text = "Realizar pagos";
            btnInscripcion.Text = "Inscripcion de Cursos";
            btnAtras.Text = "Atras";
            btnHorarios.Text = "Consultar Horarios";
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde y capacidad de maximizar y minimizar.
        /// </summary>
        private void Form_Panel_Estudiante_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Panel de Estudiante";
        }

        /// <summary>
        /// Maneja el evento Click del botón "Inscripción de Cursos".
        /// Oculta el formulario actual y muestra el formulario de inscripción de cursos.
        /// </summary>
        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Inscripcion_Cursos formInscripcionCursos = new Form_Inscripcion_Cursos();
            formInscripcionCursos.Show();
        }

        /// <summary>
        /// Maneja el evento Click del botón "Atrás".
        /// Oculta el formulario actual y muestra el formulario de inicio de sesión para estudiantes.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_LogIn_Estudiante formLogInEst = new Form_LogIn_Estudiante();
            formLogInEst.Show();
        }

        /// <summary>
        /// Maneja el evento Click del botón "Realizar pagos".
        /// Oculta el formulario actual y muestra el formulario principal de pagos.
        /// </summary>
        private void btnPagos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Pagos_Principal formPagosPrincipal = new Form_Pagos_Principal();
            formPagosPrincipal.Show();
        }

        /// <summary>
        /// Maneja el evento Click del botón "Consultar Horarios".
        /// Verifica si el estudiante está inscrito en algún curso y muestra los horarios o un mensaje de advertencia.
        /// </summary>
        private void btnHorarios_Click(object sender, EventArgs e)
        {
            if (Sistema.EstudianteLogueado.CursosInscriptos.Count > 0)
            {
                this.Hide();
                Form_Horarios_Cursos formHorarios = new Form_Horarios_Cursos();
                formHorarios.Show();
            }
            else
            {
                MessageBox.Show("No esta inscripto en ningun curso", "Ausencia de Cursos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
