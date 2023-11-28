using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
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

namespace Forms_TP_SYSACAD
{
    public partial class Form_LogIn_Estudiante : Form
    {
        private string _correoLogIn;
        private string _contraseñaLogIn;
        private GestorEstudiantes _gestorEstudiantes = new GestorEstudiantes();

        /// <summary>
        /// Constructor de la clase Form_LogIn_Estudiante.
        /// Inicializa los componentes visuales y establece los textos y acciones de los botones.
        /// </summary>
        public Form_LogIn_Estudiante()
        {
            InitializeComponent();

            lblInfoEstudiante.Text = "Bienvenido a SYSACAD ESTUDIANTE";
            lblCorreo.Text = "Ingrese su direccion de email:";
            lblContraseña.Text = "Ingrese su contraseña:";

            btnIngresar.Text = "Ingresar";
            btnAtras.Text = "Atras";
            btnAutoCompletar.Text = "Autocompletar";
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde y capacidad de maximizar y minimizar.
        /// </summary>
        private void Form_LogInEstudiante_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Iniciar Sesion ESTUDIANTE";
        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {
            _correoLogIn = textBoxCorreo.Text;
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            _contraseñaLogIn = textBoxContraseña.Text;
        }

        /// <summary>
        /// Maneja el evento Click del botón "Ingresar".
        /// Realiza la validación de las credenciales y gestiona el inicio de sesión del estudiante.
        /// </summary>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Valido las credenciales
            ValidadorCredenciales validadorCredenciales = new ValidadorCredenciales();
            MensajeRespuestaValidacionCredencialesContraseña resultadoValidacion = validadorCredenciales.ValidarCredenciales(_correoLogIn, _contraseñaLogIn, Log.Estudiante);

            switch (resultadoValidacion)
            {
                case MensajeRespuestaValidacionCredencialesContraseña.OK:
                    // Me fijo si el estudiante debe cambiar la verificacion
                    bool debeCambiarContraseñaPrimeraVerificacion = _gestorEstudiantes.BuscarSiUsuarioDebeCambiarContrasenia(_correoLogIn);

                    // Si debe cambiar la contraseña
                    if (debeCambiarContraseñaPrimeraVerificacion)
                    {
                        Form_Nueva_Contrasenia formNuevaContrasenia = new Form_Nueva_Contrasenia(_correoLogIn);
                        formNuevaContrasenia.ShowDialog();

                        // Me fijo si el estudiante cambio bien la contraseña
                        bool debeCambiarContraseñaSegundaVerificacion = _gestorEstudiantes.BuscarSiUsuarioDebeCambiarContrasenia(_correoLogIn);

                        //Si ahora se cambio el estado de "Debe Cambiar Contraseña"
                        if (debeCambiarContraseñaPrimeraVerificacion != debeCambiarContraseñaSegundaVerificacion)
                        {
                            this.Hide();

                            //Ingresamos al usuario como activo (Estudiante Logueado)
                            Sistema.IngresarEstudianteComoUsuarioActivo(_correoLogIn);
                            Form_Panel_Estudiante formPanelEstudiante = new Form_Panel_Estudiante();
                            formPanelEstudiante.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("No ha cambiado su contraseña de forma exitosa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    // Si no debe cambiarla
                    else
                    {
                        //Ingresamos al usuario como activo (Estudiante Logueado)
                        Sistema.IngresarEstudianteComoUsuarioActivo(_correoLogIn);
                        Sistema.CorreoEstudianteLogueado = Sistema.EstudianteLogueado.Correo;

                        this.Hide();
                        Form_Panel_Estudiante formPanelEstudiante = new Form_Panel_Estudiante();
                        formPanelEstudiante.ShowDialog();
                    }

                    break;
                case MensajeRespuestaValidacionCredencialesContraseña.camposVacios:
                    MessageBox.Show("Asegurese de completar los campos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case MensajeRespuestaValidacionCredencialesContraseña.noEncontrado:
                    MessageBox.Show("Credenciales de inicio incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón "Atras".
        /// Oculta el formulario actual y muestra el formulario de inicio.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Inicio formInicio = new Form_Inicio();
            formInicio.Show();
        }

        /// <summary>
        /// Maneja el evento Click del botón "Autocompletar".
        /// Llena automáticamente los cuadros de texto con datos de ejemplo para facilitar las pruebas.
        /// </summary>
        private void btnAutoCompletar_Click(object sender, EventArgs e)
        {
            textBoxCorreo.Text = "aaaa@hotmail.com";
            _correoLogIn = "aaaa@hotmail.com";
            textBoxContraseña.Text = "123456";
            _contraseñaLogIn = "123456";
        }
    }
}
