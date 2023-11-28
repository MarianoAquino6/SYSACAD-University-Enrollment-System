using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Persistencia;

namespace Libreria_Clases_TP_SYSACAD.EntidadesPrimarias
{
    public class Estudiante : IEntidadReconstruida, IEntidadPersona
    {
        //Atributos del estudiante
        private string _nombre;
        private string _legajo;
        private string _direccion;
        private string _numeroTelefono;
        private string _correo;
        private string _contrasenia;
        private Guid _identificadorUnico;
        private bool _debeCambiarContrasenia;
        private int _creditos;
        private double _promedio;

        private List<string> _codigosCursosInscriptos = new List<string>();
        private List<ConceptoDePago> _conceptosAPagar = new List<ConceptoDePago>();
        private List<string> _codigosDeFamiliaDeCursosCompletados = new List<string>();

        /// <summary>
        /// Constructor de la clase Estudiante.
        /// Inicializa los atributos del estudiante.
        /// </summary>
        public Estudiante(string nombre, string legajo, string direccion, string telefono,
            string correo, string contrasenia, bool debeCambiarContrasenia)
        {
            _nombre = nombre;
            _legajo = legajo;
            _direccion = direccion;
            _numeroTelefono = telefono;
            _correo = correo;
            _contrasenia = contrasenia;
            _debeCambiarContrasenia = debeCambiarContrasenia;
            _creditos = 0;
            _promedio = 0;
        }

        public Estudiante(string nombre, string legajo, string direccion, string telefono,
            string correo, string contrasenia, bool debeCambiarContrasenia, int creditos, double promedio,
            List<string> codigosCursosInscriptos, List<ConceptoDePago> conceptosAPagar, List<string> codigosDeFamiliaDeCursosCompletados)
        {
            _nombre = nombre;
            _legajo = legajo;
            _direccion = direccion;
            _numeroTelefono = telefono;
            _correo = correo;
            _contrasenia = contrasenia;
            _debeCambiarContrasenia = debeCambiarContrasenia;
            _creditos = creditos;
            _promedio = promedio;
            _codigosCursosInscriptos = codigosCursosInscriptos;
            _conceptosAPagar = conceptosAPagar;
            _codigosDeFamiliaDeCursosCompletados = codigosDeFamiliaDeCursosCompletados;
        }

        /// <summary>
        /// Registra un nuevo estudiante en la base de datos.
        /// </summary>
        /// <param name="nuevoEstudiante">El estudiante a ser registrado.</param>
        public async Task Registrar()
        {
            //Sistema.BaseDatosEstudiantes.IngresarUsuarioBD(this);
            await ConsultasEstudiantes.IngresarUsuarioBD(this);

        }

        /// <summary>
        /// Actualiza los conceptos de pago del estudiante en base a los pagos realizados.
        /// </summary>
        /// <param name="listaConceptosPagados">La lista de conceptos pagados con sus montos.</param>
        public async Task ActualizarConceptosDePago(Dictionary<string, double> listaConceptosPagados)
        {
            await ConsultasPagos.ActualizarConceptosDePagoDeEstudiante(listaConceptosPagados, Legajo);
        }

        //Getters y Setters
        public string Legajo { get { return _legajo; } }

        public string Correo { get { return _correo; } }

        public Guid IdentificadorUnico { get { return _identificadorUnico; } internal set { _identificadorUnico = value; } }

        public string Nombre { get { return _nombre; } }

        public string Direccion { get { return _direccion; } }

        public string Telefono { get { return _numeroTelefono; } }

        public string Contrasenia { get { return _contrasenia; } set { _contrasenia = value; } }

        public List<string> CursosInscriptos { get { return _codigosCursosInscriptos; } }

        public bool DebeCambiarContrasenia { get { return _debeCambiarContrasenia; } set { _debeCambiarContrasenia = value; } }

        public List<ConceptoDePago> ConceptosDePago { get { return _conceptosAPagar; } }

        public List<string> CursosCompletados { get { return _codigosDeFamiliaDeCursosCompletados; } }

        public int Creditos { get { return _creditos; } internal set { _creditos = value; } }

        public double Promedio { get { return _promedio; } internal set { _promedio = value; } }
    }
}
