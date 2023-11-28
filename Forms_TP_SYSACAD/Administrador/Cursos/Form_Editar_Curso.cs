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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_TP_SYSACAD
{
    public partial class Form_Editar_Curso : Form
    {
        //Nuevos datos
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private string _cupo;
        private string _turno;
        private string _aula;
        private string _dia;

        //Datos originales
        private string _codigoOriginal;

        private GestorCursos _gestorCursos = new GestorCursos();

        /// <summary>
        /// Constructor que recibe un curso seleccionado para su edición.
        /// Inicializa los componentes del formulario y configura elementos visuales con los datos del curso seleccionado.
        /// </summary>
        /// <param name="cursoSeleccionado">Curso que se va a editar.</param>
        public Form_Editar_Curso(Curso cursoSeleccionado)
        {
            InitializeComponent();

            //Codigo del curso tal cual como aparecia en el ListView
            _codigoOriginal = cursoSeleccionado.Codigo;

            //Labels y Buttons
            lblInfoEditar.Text = "Edite los datos del curso seleccionado";
            lblNombre.Text = "Nombre: ";
            lblCodigo.Text = "Codigo";
            lblDescripcion.Text = "Descripcion";
            lblCupo.Text = "Cupo Maximo";
            lblAula.Text = "Aula";
            lblTurno.Text = "Turno";
            lblDia.Text = "Dia";

            cbTurno.Items.Add("Mañana");
            cbTurno.Items.Add("Tarde");
            cbTurno.Items.Add("Noche");

            cbDia.Items.Add("Lunes");
            cbDia.Items.Add("Martes");
            cbDia.Items.Add("Miercoles");
            cbDia.Items.Add("Jueves");
            cbDia.Items.Add("Viernes");

            btnConfirmarEdicion.Text = "Confirmar";
            btnAtras.Text = "Atras";

            //Asigno valores default a los campos de texto
            textBoxNombre.Text = cursoSeleccionado.Nombre;
            textBoxCodigo.Text = cursoSeleccionado.Codigo;
            richTextBoxDecripcion.Text = cursoSeleccionado.Descripcion;
            textBoxCupo.Text = cursoSeleccionado.CupoMaximo.ToString();
            tbAula.Text = cursoSeleccionado.Aula;
            cbTurno.SelectedItem = cursoSeleccionado.Turno;
            cbDia.SelectedItem = cursoSeleccionado.Dia;

            //Inicializar estos atributos con los del curso seleccionado me sirven luego para la correcta validacion
            _nombre = cursoSeleccionado.Nombre;
            _codigo = cursoSeleccionado.Codigo;
            _descripcion = cursoSeleccionado.Descripcion;
            _cupo = cursoSeleccionado.CupoMaximo.ToString();
            _aula = cursoSeleccionado.Aula;
            _turno = cursoSeleccionado.Turno;
            _dia = cursoSeleccionado.Dia;
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario.
        /// Configura la posición, estilo y título del formulario.
        /// </summary>
        private void Form_Editar_Curso_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Editar Curso";
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            _nombre = textBoxNombre.Text;
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {
            _codigo = textBoxCodigo.Text;
        }

        private void richTextBoxDecripcion_TextChanged(object sender, EventArgs e)
        {
            _descripcion = richTextBoxDecripcion.Text;
        }

        private void textBoxCupo_TextChanged(object sender, EventArgs e)
        {
            _cupo = textBoxCupo.Text;
        }

        private void cbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            _turno = cbTurno.SelectedItem.ToString();
        }

        private void cbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dia = cbDia.SelectedItem.ToString();
        }

        private void tbAula_TextChanged(object sender, EventArgs e)
        {
            _aula = tbAula.Text;
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Confirmar Edición".
        /// Realiza validaciones de los campos ingresados y gestiona la edición del curso.
        /// </summary>
        private async void btnConfirmarEdicion_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    { "nombre", _nombre },
                    { "codigo", _codigo },
                    { "aula", _aula },
                    { "descripcion", _descripcion },
                    { "cupoMax", _cupo }
                };

                RespuestaValidacionInput resultadoInputs = _gestorCursos.ValidarInputsCursos(camposIngresados);

                if (!resultadoInputs.AusenciaCamposVacios)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }

                if (resultadoInputs.ExistenciaErrores)
                {
                    throw new Exception(resultadoInputs.MensajeErrores);
                }

                //Corroboro si el codigo se cambio
                bool cambioDeCodigo;
                if (_codigoOriginal != _codigo)
                {
                    cambioDeCodigo = true;
                }
                else
                {
                    cambioDeCodigo = false;
                }

                bool resultadoGestion = await _gestorCursos.GestionarEdicionCursoEnBaseADuplicados(cambioDeCodigo,
                    _codigoOriginal, _nombre, _codigo, _descripcion, _cupo, _turno, _dia, _aula);

                if (resultadoGestion)
                {
                    this.Hide();
                    Form_Cursos_Disponibles formCursosDisponibles = new Form_Cursos_Disponibles();
                    formCursosDisponibles.Show();
                }
                else
                {
                    throw new Exception("Error... Codigo de curso duplicado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Atras".
        /// Oculta el formulario actual y muestra el formulario de cursos disponibles.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Cursos_Disponibles formCursosDisponibles = new Form_Cursos_Disponibles();
            formCursosDisponibles.Show();
        }
    }
}
