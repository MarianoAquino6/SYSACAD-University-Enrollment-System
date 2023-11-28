using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConsultasProfesores : ConexionBD
    {
        private static List<Profesor> _listaProfesores = new List<Profesor>();

        /////////////////// RECONSTRUCCION DE LA LISTA DE PROFESORES A PARTIR DE BD

        /// <summary>
        /// Crea instancias de profesores a partir de los datos recuperados de la base de datos.
        /// </summary>
        internal static void CrearInstanciasDeProfesoresAPartirDeBD()
        {
            _listaProfesores.Clear();
            _listaProfesores = CargaDeInstanciasDesdeBD.CrearInstanciasDeProfesoresAPartirDeBD();
        }

        ///////////////////////CREATE

        /// <summary>
        /// Ingresa un nuevo profesor en la base de datos.
        /// </summary>
        /// <param name="profesorNuevo">Nuevo objeto de tipo Profesor a ingresar en la base de datos.</param>
        /// <returns>Tarea asincrónica que ingresa el nuevo profesor y actualiza las instancias desde la base de datos.</returns>
        internal static async Task IngresarNuevoProfesor(Profesor profesorNuevo)
        {
            string query = "INSERT INTO Profesores (nombre, direccion, telefono, correo, especializacion) " +
                  "VALUES (@nombre, @direccion, @telefono, @correo, @especializacion)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@nombre", profesorNuevo.Nombre },
                { "@direccion", profesorNuevo.Direccion },
                { "@telefono", profesorNuevo.Telefono },
                { "@correo", profesorNuevo.Correo },
                { "@especializacion", profesorNuevo.Especializacion }
            };

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);

            CrearInstanciasDeProfesoresAPartirDeBD();
        }

        ///////////////////////READ


        /// <summary>
        /// Busca si existe un profesor en la lista según su correo electrónico.
        /// </summary>
        /// <param name="correo">Correo electrónico del profesor a buscar.</param>
        /// <returns>Booleano que indica si el profesor existe o no en la lista.</returns>
        public bool BuscarProfesorExistenteBD(string correo)
        {
            bool resultadoBusqueda = false;

            foreach (Profesor profesor in _listaProfesores)
            {
                if (profesor.Correo == correo)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }


        /// <summary>
        /// Devuelve un objeto Profesor según su correo electrónico.
        /// </summary>
        /// <param name="correo">Correo electrónico del profesor a devolver.</param>
        /// <returns>Objeto Profesor correspondiente al correo proporcionado o null si no se encuentra.</returns>
        public Profesor? DevolverProfesor(string correo)
        {
            foreach (Profesor profesor in _listaProfesores)
            {
                if (profesor.Correo == correo)
                {
                    return profesor;
                }
            }

            return null;
        }

        ///////////////////////UPDATE


        /// <summary>
        /// Edita la información de un profesor en la base de datos.
        /// </summary>
        /// <param name="correo">Correo electrónico del profesor a editar.</param>
        /// <param name="direccion">Nueva dirección del profesor.</param>
        /// <param name="especializacion">Nueva especialización del profesor.</param>
        /// <param name="nombre">Nuevo nombre del profesor.</param>
        /// <param name="telefono">Nuevo teléfono del profesor.</param>
        /// <param name="correoOriginal">Correo original del profesor antes de la edición.</param>
        /// <returns>Tarea asincrónica que edita la información del profesor y actualiza las instancias desde la base de datos.</returns>
        public async Task EditarProfesor(string correo, string direccion, string especializacion, string nombre, string telefono, string correoOriginal)
        {
            string query = "UPDATE Profesores SET nombre = @nombre, direccion = @direccion, telefono = @telefono, correo = @correo, especializacion = @especializacion WHERE correo = @correoOriginal";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@nombre", nombre },
                { "@direccion", direccion },
                { "@telefono", telefono },
                { "@correo", correo },
                { "@especializacion", especializacion },
                { "@correoOriginal", correoOriginal }
            };

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);

            CrearInstanciasDeProfesoresAPartirDeBD();
        }


        /// <summary>
        /// Agrega un curso a la lista de cursos asociados a un profesor en la base de datos.
        /// </summary>
        /// <param name="correoProfesor">Correo del profesor al que se agrega el curso.</param>
        /// <param name="codigoCurso">Código del curso que se agrega al profesor.</param>
        /// <returns>Tarea asincrónica que agrega el curso al profesor y actualiza las instancias desde la base de datos.</returns>
        public async Task AgregarCursoAProfesor(string correoProfesor, string codigoCurso)
        {
            string query = "INSERT INTO ProfesoresEnCursos (correoProfesor, codigoCurso) " +
                   "VALUES (@correo, @codigo)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@correo", correoProfesor },
                { "@codigo", codigoCurso }
            };

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);

            CrearInstanciasDeProfesoresAPartirDeBD();
        }

        ///////////////////////DELETE

        /// <summary>
        /// Elimina un profesor de la base de datos según su correo electrónico.
        /// </summary>
        /// <param name="correo">Correo electrónico del profesor a eliminar.</param>
        /// <returns>Tarea asincrónica que elimina el profesor de la base de datos y actualiza las instancias desde la base de datos.</returns>
        public async Task EliminarProfesorBD(string correo)
        {
            string query = @"DELETE FROM Profesores WHERE correo = @correo";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@correo", correo }
            };

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);

            CrearInstanciasDeProfesoresAPartirDeBD();
        }

        //Getters y setters
        public static List<Profesor> Profesores { get { return _listaProfesores; } }
    }
}
