using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Gestores;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
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

namespace Forms_TP_SYSACAD.Administrador.Profesores
{
    public partial class Form_Agregar_Profesor : Form
    {
        private string _nombre;
        private string _correo;
        private string _direccion;
        private string _especializacion;
        private string _telefono;
        private GestorProfesores _gestorProfesores = new GestorProfesores();

        /// <summary>
        /// Constructor de la clase Form_Agregar_Profesor.
        /// Inicializa los componentes visuales y establece los textos iniciales para las etiquetas y botones.
        /// </summary>
        public Form_Agregar_Profesor()
        {
            InitializeComponent();

            lblInfo.Text = "Ingrese los datos del nuevo profesor";
            lblCorreo.Text = "Correo:";
            tbCorreo.PlaceholderText = "Por ej: david_vincent@gmail.com";
            lblDireccion.Text = "Direccion:";
            tbDireccion.PlaceholderText = "Por ej: Av Santa Fe 1245";
            lblEspecializacion.Text = "Especializacion";
            tbEspecializacion.PlaceholderText = "Por ej: Matematica Discreta";
            lblNombre.Text = "Nombre:";
            tbNombre.PlaceholderText = "Por ej: David Vincent";
            lblTelefono.Text = "Telefono:";
            tbTelefono.PlaceholderText = "Por ej: 1156124587";

            btnAtras.Text = "Atras";
            btnAgregar.Text = "Agregar";
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Configura propiedades iniciales del formulario, como posición, borde, y capacidad de maximizar y minimizar.
        /// </summary>
        private void Form_Agregar_Profesor_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Agregar Profesor";
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            _nombre = tbNombre.Text;
        }

        private void tbCorreo_TextChanged(object sender, EventArgs e)
        {
            _correo = tbCorreo.Text;
        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {
            _telefono = tbTelefono.Text;
        }

        private void tbDireccion_TextChanged(object sender, EventArgs e)
        {
            _direccion = tbDireccion.Text;
        }

        private void tbEspecializacion_TextChanged(object sender, EventArgs e)
        {
            _especializacion = tbEspecializacion.Text;
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
        /// Valida los campos ingresados, registra al nuevo profesor y muestra un mensaje de éxito.
        /// En caso de error, muestra un mensaje de error.
        /// </summary>
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Creo un diccionario con los campos ingresados por el usuario
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    { "nombre", _nombre },
                    { "correo", _correo },
                    { "direccion", _direccion },
                    { "especializacion", _especializacion },
                    { "telefono", _telefono }
                };

                RespuestaValidacionInput resultadoInputs = _gestorProfesores.ValidarInputsProfesor(camposIngresados);

                if (!resultadoInputs.AusenciaCamposVacios)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }

                if (resultadoInputs.ExistenciaErrores)
                {
                    throw new Exception(resultadoInputs.MensajeErrores);
                }

                Profesor nuevoProfesor = new Profesor(_nombre, _direccion, _telefono, _correo, _especializacion);
                bool validacionDuplicados = await _gestorProfesores.GestionarAgregarProfesorEnBaseADuplicados(nuevoProfesor);

                if (validacionDuplicados)
                {
                    throw new Exception("El profesor ya se encuentra registrado en el sistema");
                }
                else
                {
                    MessageBox.Show("Profesor registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // Cerrar el formulario actual y mostrar el formulario principal de profesores
                    this.Hide();
                    Form_Profesores_Principal form_Profesores_Principal = new Form_Profesores_Principal();
                    form_Profesores_Principal.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
