using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.EntidadesPrimarias
{
    public class Curso : IEntidadRegistrada, IEntidadReconstruida
    {
        //Atributos que debe contener todo curso
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private int _cupoMaximo;
        private int _cupoDisponible;
        private string _turno;
        private string _aula;
        private string _dia;
        private Carrera _carrera;
        private List<string> _codigosCorrelatividades = new List<string>();
        private int _creditosRequeridos = 0;
        private double _promedioRequerido = 0;
        private string _codigoFamilia;
        private Dictionary<string, DateTime> _alumnosEnListaDeEspera = new Dictionary<string, DateTime>();
        private ConsultasCursos consultasCursos = new ConsultasCursos();

        /// <summary>
        /// Constructor de la clase Curso.
        /// Inicializa los atributos del curso.
        /// </summary>
        public Curso(string nombre, string codigo, string descripcion, int cupoMaximo, string turno, string aula,
            string dia, Carrera carrera)
        {
            _nombre = nombre;
            _codigo = codigo;
            _descripcion = descripcion;
            _cupoMaximo = cupoMaximo;
            _cupoDisponible = cupoMaximo;
            _turno = turno;
            _aula = aula;
            _dia = dia;
            _carrera = carrera;
            _codigoFamilia = ObtenerNuevoCodigoFamilia();
        }

        public Curso(string nombre, string codigo, string descripcion, int cupoMaximo, int cupoDisponible ,string turno, string aula,
            string dia, Carrera carrera, List<string> codigosCorrelatividades, int creditosRequeridos,
            double promedioRequerido, string codigoFamilia, Dictionary<string, DateTime> alumnosEnListaDeEspera)
        {
            _nombre = nombre;
            _codigo = codigo;
            _descripcion = descripcion;
            _cupoMaximo = cupoMaximo;
            _cupoDisponible = cupoDisponible;
            _turno = turno;
            _aula = aula;
            _dia = dia;
            _carrera = carrera;
            _codigosCorrelatividades = codigosCorrelatividades;
            _creditosRequeridos = creditosRequeridos;
            _promedioRequerido = promedioRequerido;
            _codigoFamilia = codigoFamilia;
            _alumnosEnListaDeEspera = alumnosEnListaDeEspera;
        }

        /// <summary>
        /// Registra un nuevo curso en la base de datos.
        /// </summary>
        /// <param name="nuevoCurso">El curso a ser registrado.</param>
        public async Task Registrar()
        {
            await consultasCursos.IngresarCursoBD(this);
        }

        /// <summary>
        /// Verifica si hay cupos disponibles en el curso.
        /// </summary>
        /// <returns>True si hay cupos disponibles, False si no.</returns>
        internal bool ChequearCuposDisponibles()
        {
            if (CupoDisponible > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Devuelve el horario del curso en formato de texto.
        /// </summary>
        /// <returns>El horario del curso.</returns>
        public string DevolverHorario()
        {
            string horarioADevolver = "";

            switch (_turno)
            {
                case "Mañana":
                    horarioADevolver = "8:00 - 12:00 hs";
                    break;
                case "Tarde":
                    horarioADevolver = "14:00 - 18:00 hs";
                    break;
                case "Noche":
                    horarioADevolver = "18:30 - 22:30 hs";
                    break;
            }

            return horarioADevolver;
        }

        /// <summary>
        /// Genera un nuevo código de familia basado en el nombre actual.
        /// </summary>
        /// <returns>Un string que representa el nuevo código de familia generado.</returns>
        private string ObtenerNuevoCodigoFamilia()
        {
            string codigoFamiliaGenerado = _nombre.Replace(" ", "").ToUpper();
            return codigoFamiliaGenerado;
        }

        //Setters y getters
        public string Nombre { get { return _nombre; } internal set { _nombre = value; } }

        public string Codigo { get { return _codigo; } internal set { _codigo = value; } }

        public string Descripcion { get { return _descripcion; } internal set { _descripcion = value; } }

        public int CupoMaximo { get { return _cupoMaximo; } internal set { _cupoMaximo = value; } }

        public int CupoDisponible { get { return _cupoDisponible; } set { _cupoDisponible = value; } }

        public string Turno { get { return _turno; } internal set { _turno = value; } }

        public string Aula { get { return _aula; } internal set { _aula = value; } }

        public string Dia { get { return _dia; } internal set { _dia = value; } }

        public Carrera Carrera { get { return _carrera; } }

        public List<string> Correlatividades { get { return _codigosCorrelatividades; } internal set { _codigosCorrelatividades = value; } }

        public int CreditosRequeridos { get { return _creditosRequeridos; } set { _creditosRequeridos = value; } }

        public double PromedioRequerido { get { return _promedioRequerido; } set { _promedioRequerido = value; } }

        public string CodigoFamilia { get { return _codigoFamilia; } }

        public Dictionary<string, DateTime> ListaDeEspera { get { return _alumnosEnListaDeEspera; } internal set { _alumnosEnListaDeEspera = value; } }

    }
}
