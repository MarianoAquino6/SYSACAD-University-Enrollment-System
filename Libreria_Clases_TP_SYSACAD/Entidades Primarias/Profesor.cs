using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Entidades_Primarias
{
    public class Profesor : IEntidadReconstruida, IEntidadPersona
    {
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _correo;
        private string _especializacion;
        private List<string> _codigosCursosDeProfesor = new List<string>();

        /// <summary>
        /// Constructor de la clase Profesor.
        /// Inicializa los atributos del profesor.
        /// </summary>
        public Profesor(string nombre, string direccion, string telefono, string correo, string especializacion)
        {
            _nombre = nombre;
            _direccion = direccion;
            _telefono = telefono;
            _correo = correo;
            _especializacion= especializacion;
        }

        public Profesor(string nombre, string direccion, string telefono, string correo, string especializacion, List<string> codigosCursosDeProfesor)
        {
            _nombre = nombre;
            _direccion = direccion;
            _telefono = telefono;
            _correo = correo;
            _especializacion = especializacion;
            _codigosCursosDeProfesor = codigosCursosDeProfesor;
        }

        /// <summary>
        /// Registra un nuevo profesor utilizando el método de consulta asíncrona.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica.</returns>
        public async Task Registrar()
        {
            await ConsultasProfesores.IngresarNuevoProfesor(this);
        }

        public string Nombre { get { return _nombre; } }
        public string Direccion { get { return _direccion; } }
        public string Telefono { get { return _telefono; } }
        public string Correo { get { return _correo; } }
        public string Especializacion { get { return _especializacion; } }
        public List<string> CodigosCursosDeProfesor { get { return _codigosCursosDeProfesor; } }
    }
}
