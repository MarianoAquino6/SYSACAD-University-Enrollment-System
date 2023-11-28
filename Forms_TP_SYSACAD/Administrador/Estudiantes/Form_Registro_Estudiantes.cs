using Libreria_Clases_TP_SYSACAD.Herramientas;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
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
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Gestores;

namespace Forms_TP_SYSACAD
{
    public partial class Form_Registro_Estudiantes : Form
    {
        private string _nombre;
        private string _legajo;
        private string _direccion;
        private string _numeroTelefono;
        private string _correo;
        private string _contraseñaProvisional;
        private bool _cambioContraseña;
        private GestorEstudiantes _gestorEstudiantes = new GestorEstudiantes();

        /// <summary>
        /// Constructor de la clase Form_Registro_Estudiantes.
        /// Inicializa los componentes visuales y establece los textos iniciales para las etiquetas y botones.
        /// </summary>
        public Form_Registro_Estudiantes()
        {
            InitializeComponent();
            lblInfoRegistro.Text = "Ingrese los datos del estudiante:";
            lblNombre.Text = "Nombre:";
            lblLegajo.Text = "Legajo";
            lblDireccion.Text = "Direccion";
            lblTelefono.Text = "Numero de telefono";
            lblCorreo.Text = "Direccion e-mail";
            lblContraseñaProv.Text = "Contraseña provisional";
            lblCambioContraseña.Text = "Cambio de contraseña";
            checkBoxCambioContraseña.Text = "Debe cambiar contraseña provisional";
            btnRegistrar.Text = "Registrar";
            btnAtras.Text = "Atras";

            textBoxNombre.PlaceholderText = "Esteban Sanchez";
            textBoxLegajo.PlaceholderText = "Num 8 cifras";
            textBoxDireccion.PlaceholderText = "Av. 25 de Mayo";
            textBoxTelefono.PlaceholderText = "1135156482";
            textBoxCorreo.PlaceholderText = "pepe@hotmail.com";
            textBoxContraseñaProv.PlaceholderText = "Al menos 6 caracteres";
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde, y capacidad de maximizar y minimizar.
        /// </summary>
        private void Form_Registro_Estudiantes_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Registro de Estudiantes";
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            _nombre = textBoxNombre.Text;
        }

        private void textBoxLegajo_TextChanged(object sender, EventArgs e)
        {
            _legajo = textBoxLegajo.Text;
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {
            _direccion = textBoxDireccion.Text;
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            _numeroTelefono = textBoxTelefono.Text;
        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {
            _correo = textBoxCorreo.Text;
        }

        private void textBoxContraseñaProv_TextChanged(object sender, EventArgs e)
        {
            _contraseñaProvisional = textBoxContraseñaProv.Text;
        }

        private void checkBoxCambioContraseña_CheckedChanged(object sender, EventArgs e)
        {
            _cambioContraseña = checkBoxCambioContraseña.Checked;
        }

        /// <summary>
        /// Maneja el evento Click del botón Registrar.
        /// Valida los datos ingresados, crea un nuevo objeto Estudiante, y lo registra si cumple con los criterios.
        /// Muestra mensajes de error o éxito según el resultado.
        /// </summary>
        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    { "nombre", _nombre},
                    { "legajo", _legajo },
                    { "direccion", _direccion},
                    { "telefono", _numeroTelefono},
                    { "correo", _correo},
                    { "contrasenia", _contraseñaProvisional }
                };

                RespuestaValidacionInput resultadoInputs = _gestorEstudiantes.ValidarInputsEstudiantes(camposIngresados);

                if (!resultadoInputs.AusenciaCamposVacios)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }

                if (resultadoInputs.ExistenciaErrores)
                {
                    throw new Exception(resultadoInputs.MensajeErrores);
                }

                Estudiante nuevoEstudiante = new Estudiante(_nombre, _legajo, _direccion, _numeroTelefono, _correo, _contraseñaProvisional, _cambioContraseña);
                bool resultadoValidacionDuplicados = await _gestorEstudiantes.GestionarRegistrarEstudianteEnBaseADuplicados(nuevoEstudiante);

                if (!resultadoValidacionDuplicados)
                {
                    MessageBox.Show("Usuario registrado exitosamente. Se envian las credenciales al correo del estudiante. Este proceso puede llevar unos segundos", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    bool resultadoEmisionCorreo = await _gestorEstudiantes.EnviarCorreoElectronicoAEstudiante(nuevoEstudiante, _contraseñaProvisional);

                    if (resultadoEmisionCorreo)
                    {
                        MessageBox.Show("Se ha enviado las credenciales al correo del estudiante", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Error al enviar email con credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    throw new Exception("El estudiante ya se encuentra registrado en el sistema");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
