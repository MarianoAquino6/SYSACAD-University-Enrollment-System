using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Gestores;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TP_SYSACAD
{
    public partial class Form_Gestion_Requisitos : Form
    {
        private string _codigoDeFamiliaDelCursoSeleccionado;
        private Curso _cursoSeleccionado;

        private List<string> _correlatividadesDelCursoSeleccionado = new List<string>();

        private List<Curso> _cursosSeleccionadosDelListView = new List<Curso>();
        private Curso _nuevaCorrelatividadSeleccionada;
        private GestorRequisitos _gestorRequisitos = new GestorRequisitos();
        private GestorCursos _gestorCursos = new GestorCursos();

        private string _creditos;
        private string _promedio;

        ///////////////////////////////////CONFIGURACION INICIAL////////////////////////////////////////

        /// <summary>
        /// Constructor por defecto de la clase Form_Gestion_Requisitos.
        /// Inicializa los componentes del formulario y configura elementos visuales iniciales.
        /// </summary>
        public Form_Gestion_Requisitos()
        {
            InitializeComponent();
            InicializarComboBoxCursos();
            MostrarListView();
            ConfigurarTextBoxes();
            ConfigurarComboBoxCorrelatividadesDisponibles();

            lblCurso.Text = "Seleccione un curso:";
            lblRequisitoCursos.Text = "Cursos requeridos:";
            lblRequisitoCreditos.Text = "Creditos requeridos:";
            lblRequisitoPromedio.Text = "Promedio requerido:";
            lblAgregar.Text = "Agregar nuevo curso:";
            lblModificar.Text = "Modificar requisitos";
            lblEliminar.Text = "Eliminar requisito";

            btnAtras.Text = "Atras";
            btnEliminar.Text = "Eliminar";
            btnGuardar.Text = "Guardar Cambios";
            btnAgregar.Text = "Agregar";
        }

        /// <summary>
        /// Inicializa el ComboBox con los cursos disponibles y configura elementos iniciales del formulario.
        /// </summary>
        private void InicializarComboBoxCursos()
        {
            List<Curso> listaDeCursosSegunCodigoFamilia = _gestorCursos.ObtenerUnCursoPorCadaCodigoDeFamilia();

            if (listaDeCursosSegunCodigoFamilia.Count > 0)
            {
                foreach (Curso curso in listaDeCursosSegunCodigoFamilia)
                {
                    string nombreCurso = curso.Nombre;
                    cbCursos.Items.Add(nombreCurso);
                }

                cbCursos.SelectedIndex = 0;

                //Obtengo el codigo de familia a partir del nombre del codigo seleccionado
                _codigoDeFamiliaDelCursoSeleccionado = _gestorCursos.ObtenerCodigoDeFamiliaDesdeNombre(cbCursos.Text);
                //Obtengo el curso seleccionado a partir de su codigo de familia
                _cursoSeleccionado = _gestorCursos.ObtenerCursoDesdeCodigoDeFamilia(_codigoDeFamiliaDelCursoSeleccionado);
                //Obtengo las correlatividades que posee la familia. 
                _correlatividadesDelCursoSeleccionado = _cursoSeleccionado.Correlatividades;
            }
        }

        /// <summary>
        /// Configura el ComboBox de correlatividades disponibles.
        /// </summary>
        private void ConfigurarComboBoxCorrelatividadesDisponibles()
        {
            cbAgregarCorrelatividad.Items.Clear();

            //Obtengo la lista de nombres de aquellos cursos aun no correlativos al seleccionado
            HashSet<string> nombresDeCursosNoCorrelativos = _gestorCursos.ObtenerNombresDeCursosNoCorrelativos(_cursoSeleccionado);

            if (nombresDeCursosNoCorrelativos.Count > 0)
            {
                foreach (string nombre in nombresDeCursosNoCorrelativos)
                {
                    cbAgregarCorrelatividad.Items.Add(nombre);
                }
            }
        }

        /// <summary>
        /// Muestra en el ListView las correlatividades del curso seleccionado.
        /// </summary>
        private void MostrarListView()
        {
            listViewCursosRequisitos.Items.Clear();

            if (_correlatividadesDelCursoSeleccionado.Count > 0)
            {
                //Recorro los codigos de familia de las correlatividades del curso seleccionado
                foreach (string codigoDeFamiliaDeCursoRequerido in _correlatividadesDelCursoSeleccionado)
                {
                    //Obtengo el curso a partir del codigo de familia iterado
                    Curso cursoIterado = _gestorCursos.ObtenerCursoDesdeCodigoDeFamilia(codigoDeFamiliaDeCursoRequerido);

                    //Muestro la informacion del curso respectivo en el listView
                    if (cursoIterado != null)
                    {
                        ListViewItem nuevaFila = new ListViewItem(cursoIterado.CodigoFamilia);
                        nuevaFila.SubItems.Add(cursoIterado.Nombre);

                        listViewCursosRequisitos.Items.Add(nuevaFila);
                    }
                }
            }
        }

        /// <summary>
        /// Configura los TextBoxes con los valores actuales de créditos y promedio requeridos.
        /// </summary>
        private void ConfigurarTextBoxes()
        {
            tbCreditos.Text = _cursoSeleccionado.CreditosRequeridos.ToString();
            tbPromedio.Text = _cursoSeleccionado.PromedioRequerido.ToString();

            _creditos = _cursoSeleccionado.CreditosRequeridos.ToString();
            _promedio = _cursoSeleccionado.PromedioRequerido.ToString();
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario.
        /// Configura la posición, estilo y título del formulario.
        /// </summary>
        private void Form_Gestion_Requisitos_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Gestion de Requisitos Academicos";
        }


        //////////////////////////////////LOGICA DE LOS ELEMENTOS DEL FORM/////////////////////////////////

        /// <summary>
        /// Evento que se ejecuta al seleccionar un curso en el ComboBox.
        /// Actualiza la información y los controles del formulario según el curso seleccionado.
        /// </summary>
        private void cbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreDeCursoSeleccionado = cbCursos.SelectedItem.ToString();

            //Obtengo el codigo de familia a partir del nombre del codigo seleccionado
            _codigoDeFamiliaDelCursoSeleccionado = _gestorCursos.ObtenerCodigoDeFamiliaDesdeNombre(nombreDeCursoSeleccionado);
            //Obtengo el curso seleccionado a partir de su codigo de familia
            _cursoSeleccionado = _gestorCursos.ObtenerCursoDesdeCodigoDeFamilia(_codigoDeFamiliaDelCursoSeleccionado);
            //Obtengo las correlatividades que posee la familia. 
            _correlatividadesDelCursoSeleccionado = _cursoSeleccionado.Correlatividades;

            //Actualizo los displays
            MostrarListView();
            ConfigurarTextBoxes();
            ConfigurarComboBoxCorrelatividadesDisponibles();
        }

        private void tbCreditos_TextChanged(object sender, EventArgs e)
        {
            _creditos = tbCreditos.Text;
        }

        private void tbPromedio_TextChanged(object sender, EventArgs e)
        {
            _promedio = tbPromedio.Text;
        }

        /// <summary>
        /// Evento que se ejecuta al cambiar la selección en el ListView de correlatividades.
        /// Actualiza la lista de cursos seleccionados en el ListView.
        /// </summary>
        private void listViewCursosRequisitos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _cursosSeleccionadosDelListView = new List<Curso>();

            List<string> codigosSeleccionados = new List<string>();

            //Extraigo los codigos de familia del listView y los meto en una lista "codigosSeleccionados"
            foreach (ListViewItem item in listViewCursosRequisitos.SelectedItems)
            {
                string valorPrimeraColumna = item.SubItems[0].Text;
                codigosSeleccionados.Add(valorPrimeraColumna);
            }

            //Obtengo los cursos a partir de su codigo de familia y los meto en la lista de cursos seleccionados
            foreach (string codigo in codigosSeleccionados)
            {
                _cursosSeleccionadosDelListView.Add(_gestorCursos.ObtenerCursoDesdeCodigoDeFamilia(codigo));
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Eliminar".
        /// Elimina las correlatividades seleccionadas del curso.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_cursosSeleccionadosDelListView.Count > 0)
            {
                //Saco de la lista de correlatividades al curso seleccionado para eliminar
                foreach (Curso cursoRequisitoSeleccionado in _cursosSeleccionadosDelListView)
                {
                    _correlatividadesDelCursoSeleccionado.Remove(cursoRequisitoSeleccionado.CodigoFamilia);
                }

                //Actualizo los display
                MostrarListView();
                ConfigurarComboBoxCorrelatividadesDisponibles();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun curso de la lista de correlatividades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento que se ejecuta al seleccionar una correlatividad en el ComboBox de agregar.
        /// Actualiza la correlatividad seleccionada para agregar al curso.
        /// </summary>
        private void cbAgregarCorrelatividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nuevaCorrelatividadCodigoDeFamilia = _gestorCursos.ObtenerCodigoDeFamiliaDesdeNombre(cbAgregarCorrelatividad.Text);
            _nuevaCorrelatividadSeleccionada = _gestorCursos.ObtenerCursoDesdeCodigoDeFamilia(nuevaCorrelatividadCodigoDeFamilia);
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Agregar".
        /// Agrega la correlatividad seleccionada al curso.
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_nuevaCorrelatividadSeleccionada != null)
            {
                //Meto el curso seleccionado del cb en la lista de correlatividades
                _correlatividadesDelCursoSeleccionado.Add(_nuevaCorrelatividadSeleccionada.CodigoFamilia);
                //Borro la seleccion previa
                _nuevaCorrelatividadSeleccionada = null;
                cbAgregarCorrelatividad.SelectedItem = null;

                //Actualizo los display
                MostrarListView();
                ConfigurarComboBoxCorrelatividadesDisponibles();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna nueva correlatividad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Guardar Cambios".
        /// Realiza validaciones y guarda los cambios en los requisitos del curso.
        /// </summary>
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>();
                camposIngresados["creditos"] = _creditos;
                camposIngresados["promedio"] = _promedio;

                RespuestaValidacionInput respuestaValidacion = await _gestorRequisitos.GestionarConfirmacionRequisitos(camposIngresados, _codigoDeFamiliaDelCursoSeleccionado, _correlatividadesDelCursoSeleccionado, _creditos, _promedio);

                if (!respuestaValidacion.AusenciaCamposVacios)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }

                if (respuestaValidacion.ExistenciaErrores)
                {
                    throw new Exception(respuestaValidacion.MensajeErrores);
                }

                MessageBox.Show("Requisitos Actualizados Exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Hide();
                Form_Panel_Administracion formPanelAdmin = new Form_Panel_Administracion();
                formPanelAdmin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Atras".
        /// Muestra el formulario de administración.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Panel_Administracion formPanelAdmin = new Form_Panel_Administracion();
            formPanelAdmin.Show();
        }
    }
}
