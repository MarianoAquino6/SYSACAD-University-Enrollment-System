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

namespace Forms_TP_SYSACAD
{
    public partial class Form_Inicio : Form
    {
        /// <summary>
        /// Constructor de la clase Form_Inicio.
        /// Configura la apariencia inicial del formulario y los elementos visuales.
        /// </summary>
        public Form_Inicio()
        {
            InitializeComponent();

            lblInfoInicio.Text = "Bienvenido a SYSACAD";
            btnEstudiante.Text = "Ingresar como Estudiante";
            btnAdmin.Text = "Ingresar como Administrador";
        }

        /// <summary>
        /// Maneja el evento Click del botón "Ingresar como Estudiante".
        /// Oculta el formulario actual y muestra el formulario de inicio de sesión para estudiantes.
        /// </summary>
        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_LogIn_Estudiante formLogInEstudiante = new Form_LogIn_Estudiante();
            formLogInEstudiante.Show();
        }

        internal void MostrarMensajeCargando()
        {
            // Muestra el ProgressBar en el formulario
            progressBarCargando.Visible = true;
        }

        internal void OcultarMensajeCargando()
        {
            // Oculta el ProgressBar cuando se termina de cargar la BD
            progressBarCargando.Visible = false;
        }

        /// <summary>
        /// Muestra un cuadro de diálogo de entrada de contraseña y valida la contraseña ingresada para el acceso de administrador.
        /// </summary>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Muestra un cuadro de diálogo de entrada de contraseña
            string codigoIngresado = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la contraseña:", "Verificar Contraseña", "");

            //Valido la contraseña ingresada
            ValidadorCredenciales validadorCodigoAcceso = new ValidadorCredenciales();
            bool resultadoValidacion = validadorCodigoAcceso.ValidarCodigoAccesoAdmins(codigoIngresado);

            if (resultadoValidacion)
            {
                this.Hide();
                Form_LogIn_Administrador formLogInAdmin = new Form_LogIn_Administrador();
                formLogInAdmin.Show();
            }
            else
            {
                MessageBox.Show("Acceso Denegado", "Codigo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde y capacidad de maximizar y minimizar.
        /// </summary>
        private void Form_Inicio_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Bienvenido";
        }
    }
}
