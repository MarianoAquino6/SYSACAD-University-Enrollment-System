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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_TP_SYSACAD
{
    public partial class Form_Agregar_Curso : Form
    {
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private string _cupo;
        private string _turno;
        private string _aula;
        private string _dia;
        private Carrera _carrera;
        private GestorCursos _gestorCursos = new GestorCursos();

        /// <summary>
        /// Constructor por defecto de la clase Form_Agregar_Curso.
        /// Inicializa los componentes del formulario y configura elementos visuales.
        /// </summary>
        public Form_Agregar_Curso()
        {
            InitializeComponent();

            lblInfoAgregar.Text = "Ingrese los datos del nuevo curso";
            lblNombre.Text = "Nombre:";
            lblCodigo.Text = "Codigo:";
            lblDescripcion.Text = "Descripcion:";
            lblCupo.Text = "Cupo Maximo:";
            lblAula.Text = "Aula:";
            lblTurno.Text = "Turno:";
            lblDia.Text = "Dia:";
            lblCarrera.Text = "Carrera:";

            textBoxNombre.PlaceholderText = "Por ej. Matematica I";
            textBoxCodigo.PlaceholderText = "Por ej. MateM";
            tbAula.PlaceholderText = "Por ej. 105";
            textBoxCupo.PlaceholderText = "Por ej. 520";

            cbTurno.Items.Add("Mañana");
            cbTurno.Items.Add("Tarde");
            cbTurno.Items.Add("Noche");
            cbTurno.SelectedItem = "Mañana";
            _turno = "Mañana";

            cbDia.Items.Add("Lunes");
            cbDia.Items.Add("Martes");
            cbDia.Items.Add("Miercoles");
            cbDia.Items.Add("Jueves");
            cbDia.Items.Add("Viernes");
            cbDia.SelectedItem = "Lunes";
            _dia = "Lunes";

            cbCarrera.Items.Add("TUP");
            cbCarrera.Items.Add("TUSI");
            cbCarrera.SelectedItem = "TUP";
            _carrera = Carrera.TUP;

            btnAgregar.Text = "Agregar Curso";
            btnAtras.Text = "Atras";
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario.
        /// Configura la posición, estilo y título del formulario.
        /// </summary>
        private void Form_Agregar_Curso_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Agregar Nuevo Curso";
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            _nombre = textBoxNombre.Text;
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {
            _codigo = textBoxCodigo.Text;
        }

        private void richTextBoxDescripcion_TextChanged(object sender, EventArgs e)
        {
            _descripcion = richTextBoxDescripcion.Text;
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

        private void cbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCarrera.SelectedItem.ToString() == "TUP")
            {
                _carrera = Carrera.TUP;
            }
            else
            {
                _carrera = Carrera.TUSI;
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Agregar Curso".
        /// Realiza validaciones de los campos ingresados y agrega un nuevo curso.
        /// </summary>
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Creo un diccionario con los campos ingresados por el usuario
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

                bool validacionDuplicados = await _gestorCursos.GestionarAgregarCurso(_nombre, _codigo, _descripcion, _cupo, _turno, _dia, _aula, _carrera);

                if (validacionDuplicados)
                {
                    throw new Exception("El curso ya se encuentra registrado en el sistema");
                }

                MessageBox.Show("Curso registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Cerrar el formulario actual y mostrar el formulario de cursos disponibles
                this.Hide();
                Form_Cursos_Disponibles formCursosDisponibles = new Form_Cursos_Disponibles();
                formCursosDisponibles.Show();
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
