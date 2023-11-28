using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConsultasInscripciones : ConexionBD
    {
        private static List<RegistroDeInscripcion> _listaRegistrosInscripcion = new List<RegistroDeInscripcion>();

        /////////////////// RECONSTRUCCION DE LA LISTA DE INSCRIPCIONES A PARTIR DE BD

        /// <summary>
        /// Crea instancias de inscripciones a partir de los datos recuperados de la base de datos.
        /// </summary>
        internal static void CrearInstanciasDeInscripcionesAPartirDeBD()
        {
            _listaRegistrosInscripcion.Clear();
            _listaRegistrosInscripcion = CargaDeInstanciasDesdeBD.CrearInstanciasDeInscripcionesAPartirDeBD();
        }

        ////////////////////////CREATE

        /// <summary>
        /// Ingresa un nuevo registro de inscripción en la base de datos.
        /// </summary>
        /// <param name="nuevoRegistro">Nuevo registro de inscripción a ingresar.</param>
        /// <returns>Tarea asincrónica que ingresa el nuevo registro y actualiza las instancias de inscripciones desde la base de datos.</returns>
        internal static async Task IngresarNuevoRegistro(RegistroDeInscripcion nuevoRegistro)
        {
            string query = "INSERT INTO RegistroInscripcion (legajo, codigoCurso, fechaInscripcion) " +
                   "VALUES (@legajo, @codigoCurso, @fechaInscripcion)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@legajo", nuevoRegistro.Legajo },
                { "@codigoCurso", nuevoRegistro.CodigoCurso },
                { "@fechaInscripcion", nuevoRegistro.Fecha }
            };

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);

            CrearInstanciasDeInscripcionesAPartirDeBD();
            RefrescarEstudianteLogueado();
        }

        ////////////////////////READ

        //METODO PARA OBTENER INSCRIPCIONES SEGUN PERIODO

        /// <summary>
        /// Obtiene una lista de inscripciones en función del período de fechas especificado.
        /// </summary>
        /// <param name="fechaDesde">Fecha de inicio del período.</param>
        /// <param name="fechaHasta">Fecha de fin del período.</param>
        /// <returns>Una lista de inscripciones que están dentro del rango de fechas especificado.</returns>
        public List<RegistroDeInscripcion> ObtenerInscripciones(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<RegistroDeInscripcion> resultados = new List<RegistroDeInscripcion>();

            // Recorro la lista de registros de inscripción
            foreach (RegistroDeInscripcion registro in _listaRegistrosInscripcion)
            {
                if (registro.Fecha >= fechaDesde && registro.Fecha <= fechaHasta)
                {
                    resultados.Add(registro);
                }
            }

            return resultados;
        }

        //SOBRECARGA DEL METODO. OBTIENE INSCRIPCIONES SEGUN T (CODIGO DE CURSO O CARRERA)

        /// <summary>
        /// Obtiene una lista de inscripciones en función del período de fechas y un filtro específico (código de curso o carrera).
        /// </summary>
        /// <typeparam name="T">Tipo de filtro para las inscripciones (string para código de curso, Carrera para carrera).</typeparam>
        /// <param name="fechaDesde">Fecha de inicio del período.</param>
        /// <param name="fechaHasta">Fecha de fin del período.</param>
        /// <param name="filtro">Filtro específico para las inscripciones (código de curso o carrera).</param>
        /// <returns>Una lista de inscripciones que están dentro del rango de fechas y cumplen con el filtro especificado.</returns>
        public List<RegistroDeInscripcion> ObtenerInscripciones<T>(DateTime fechaDesde, DateTime fechaHasta, T filtro)
        {
            // Creo una lista para ir guardando los resultados de las inscripciones que cumplan con los criterios
            List<RegistroDeInscripcion> resultados = new List<RegistroDeInscripcion>();

            // Recorro la lista de registros de inscripción
            foreach (RegistroDeInscripcion registro in _listaRegistrosInscripcion)
            {
                // Verificamos si la fecha de inscripción del registro está dentro del rango especificado
                if (registro.Fecha >= fechaDesde && registro.Fecha <= fechaHasta)
                {
                    // Si el tipo de T es string, comparamos el filtro con el código de curso del registro
                    if (typeof(T) == typeof(string) && filtro.Equals(registro.CodigoCurso))
                    {
                        resultados.Add(registro);
                    }
                    // Si el tipo de T es Carrera (enum), comparamos el filtro con la Carrera del registro
                    else if (typeof(T) == typeof(Carrera) && filtro.Equals(registro.Carrera))
                    {
                        resultados.Add(registro);
                    }
                }
            }

            // Devuelvo la lista de resultados
            return resultados;
        }

        ///////// REFRESCAR ESTUDIANTE LOGUEADO

        /// <summary>
        /// Refresca la información del estudiante logueado actualizando las instancias desde la base de datos.
        /// </summary>
        public static void RefrescarEstudianteLogueado()
        {
            ConsultasEstudiantes.CrearInstanciasDeEstudiantesAPartirDeBD();
            Sistema.IngresarEstudianteComoUsuarioActivo(Sistema.CorreoEstudianteLogueado);
        }

        //Getters y Setters
        public static List<RegistroDeInscripcion> Inscripciones { get { return _listaRegistrosInscripcion; } }
    }
}
