using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System.Diagnostics;

namespace Forms_TP_SYSACAD
{
    public partial class Form_LogIn_Administrador : Form
    {
        private string _correoLogIn;
        private string _contraseñaLogIn;

        /// <summary>
        /// Constructor de la clase Form_LogIn_Administrador.
        /// Inicializa los componentes visuales y establece los textos iniciales para las etiquetas y botones.
        /// </summary>
        public Form_LogIn_Administrador()
        {
            InitializeComponent();
            lblBienvenida.Text = "Bienvenido a SYSACAD ADMINISTRADOR";
            lblMail.Text = "Ingrese su direccion de email:";
            lblContraseña.Text = "Ingrese su contraseña:";
            lblCodigoAcceso.Text = $"Codigo de acceso para admins: {Sistema.CodigoAccesoAdmins}";

            btnIngresar.Text = "Ingresar";
            btnAtras.Text = "Atras";
            btnAutoCompletar.Text = "Autocompletar";
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde, y capacidad de maximizar y minimizar.
        /// </summary>
        private void Inicio_Sesion_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Iniciar Sesion ADMINISTRADOR";
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            _correoLogIn = textBoxEmail.Text;
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            _contraseñaLogIn = textBoxContraseña.Text;
        }

        /// <summary>
        /// Maneja el evento Click del botón Ingresar.
        /// Valida las credenciales ingresadas y muestra el formulario de administración si son válidas.
        /// Muestra mensajes de error en caso contrario.
        /// </summary>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del validador de credenciales y valido las credenciales
            ValidadorCredenciales validadorCredenciales = new ValidadorCredenciales();
            MensajeRespuestaValidacionCredencialesContraseña resultadoValidacion = validadorCredenciales.ValidarCredenciales(_correoLogIn, _contraseñaLogIn, Log.Admin);

            switch (resultadoValidacion)
            {
                case MensajeRespuestaValidacionCredencialesContraseña.OK:
                    this.Hide();
                    Form_Panel_Administracion formPanelAdministracion = new Form_Panel_Administracion();
                    formPanelAdministracion.ShowDialog();
                    break;
                case MensajeRespuestaValidacionCredencialesContraseña.camposVacios:
                    MessageBox.Show("Asegúrese de completar los campos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case MensajeRespuestaValidacionCredencialesContraseña.noEncontrado:
                    MessageBox.Show("Credenciales de inicio incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón Atras.
        /// Oculta el formulario actual y muestra el formulario Form_Inicio.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Inicio formInicio = new Form_Inicio();
            formInicio.Show();
        }

        /// <summary>
        /// Maneja el evento Click del botón Autocompletar.
        /// Llena automáticamente los cuadros de texto con valores predefinidos para facilitar el desarrollo y pruebas.
        /// </summary>
        private void btnAutoCompletar_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = "johntravolta@hotmail.com";
            _correoLogIn = "johntravolta@hotmail.com";
            textBoxContraseña.Text = "666666";
            _contraseñaLogIn = "666666";
        }
    }
}