using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConsultasEstudiantes : ConexionBD, ICambioDeContraseña
    {
        private static List<Estudiante> _listaEstudiantes = new List<Estudiante>();

        /////////////////// RECONSTRUCCION DE LA LISTA DE ESTUDIANTES A PARTIR DE BD

        /// <summary>
        /// Crea instancias de estudiantes a partir de la base de datos y las asigna a la lista interna de estudiantes.
        /// </summary>
        internal static void CrearInstanciasDeEstudiantesAPartirDeBD()
        {
            _listaEstudiantes.Clear();
            _listaEstudiantes = CargaDeInstanciasDesdeBD.CrearInstanciasDeEstudiantesAPartirDeBD();
        }

        ///////////////////////CREATE

        /// <summary>
        /// Añade conceptos de pago iniciales para un estudiante dado.
        /// </summary>
        /// <param name="legajo">Legajo del estudiante.</param>
        private static async Task AñadirConceptosDePagoIniciales(string legajo)
        {
            Dictionary<string, double> conceptosIniciales = new Dictionary<string, double>
            {
                { "Matricula de Ingreso", 20000 },
                { "Matricula del Primer Cuatrimestre", 15000 },
                { "Cargos Administrativos primer cuatrimestre", 5000 },
                { "Bibliografia Primer Cuatrimestre", 5000 }
            };

            foreach (var parKeyValue in conceptosIniciales)
            {
                string query = "INSERT INTO ConceptosDePagoDeEstudiante (legajoEstudiante, conceptoNombre, montoPendiente) " +
                       "VALUES (@legajoEstudiante, @conceptoNombre, @montoPendiente)";

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@legajoEstudiante", legajo },
                    { "@conceptoNombre", parKeyValue.Key },
                    { "@montoPendiente", parKeyValue.Value }
                };

                await ConsultasGenericas.EjecutarNonQuery(query, parametros);
            }
        }

        /// <summary>
        /// Ingresa un nuevo estudiante a la base de datos junto con sus detalles y conceptos de pago iniciales.
        /// </summary>
        /// <param name="nuevoEstudiante">Estudiante a ingresar.</param>
        internal static async Task IngresarUsuarioBD(Estudiante nuevoEstudiante)
        {
            Guid nuevoGuid = Guid.NewGuid();
            nuevoEstudiante.IdentificadorUnico = nuevoGuid;
            nuevoEstudiante.Contrasenia = Hash.HashPassword(nuevoEstudiante.Contrasenia);

            string query = "INSERT INTO Estudiante (legajo, nombre, direccion, numeroTelefono, correo, " +
                   "contrasenia, identificadorUnico, debeCambiarContrasenia, creditos, promedio) " +
                   "VALUES (@legajoEstudiante, @nombreEstudiante, @direccionEstudiante, " +
                   "@telefonoEstudiante, @correoEstudiante, @contraseniaEstudiante, " +
                   "@identifiadorUnicoEstudiante, @debeCambiarContraseniaEstudiante, " +
                   "@creditosEstudiante, @promedioEstudiante)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@legajoEstudiante", nuevoEstudiante.Legajo },
                { "@nombreEstudiante", nuevoEstudiante.Nombre },
                { "@direccionEstudiante", nuevoEstudiante.Direccion },
                { "@telefonoEstudiante", nuevoEstudiante.Telefono },
                { "@correoEstudiante", nuevoEstudiante.Correo },
                { "@contraseniaEstudiante", nuevoEstudiante.Contrasenia },
                { "@identifiadorUnicoEstudiante", nuevoEstudiante.IdentificadorUnico },
                { "@debeCambiarContraseniaEstudiante", nuevoEstudiante.DebeCambiarContrasenia },
                { "@creditosEstudiante", nuevoEstudiante.Creditos },
                { "@promedioEstudiante", nuevoEstudiante.Promedio }
            };

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);

            await AñadirConceptosDePagoIniciales(nuevoEstudiante.Legajo);
            CrearInstanciasDeEstudiantesAPartirDeBD();
        }

        ///////////////////////READ

        /// <summary>
        /// Busca un usuario en la base de datos utilizando correo y contraseña para autenticación.
        /// </summary>
        /// <param name="correo">Correo electrónico del usuario.</param>
        /// <param name="contrasenia">Contraseña del usuario.</param>
        /// <returns>Booleano que indica si se encontró un usuario con las credenciales proporcionadas.</returns>
        internal static bool BuscarUsuarioCredencialesBD(string correo, string contrasenia)
        {
            Predicate<Estudiante> predicado = estudiante => estudiante.Correo == correo && Hash.VerifyPassword(contrasenia, estudiante.Contrasenia);

            List<Estudiante> estudiantesFiltrados = ConsultasGenericas.FiltrarElementos(_listaEstudiantes, predicado);
            return estudiantesFiltrados.Count > 0;
        }

        /// <summary>
        /// Busca un usuario existente en la base de datos utilizando correo o legajo como criterio.
        /// </summary>
        /// <param name="correo">Correo electrónico del usuario.</param>
        /// <param name="legajo">Legajo del usuario.</param>
        /// <returns>Booleano que indica si se encontró un usuario con el correo o legajo proporcionado.</returns>
        internal static bool BuscarUsuarioExistenteBD(string correo, string legajo)
        {
            Predicate<Estudiante> predicado = estudiante => estudiante.Correo == correo || estudiante.Legajo == legajo;

            List<Estudiante> estudiantesFiltrados = ConsultasGenericas.FiltrarElementos(_listaEstudiantes, predicado);
            return estudiantesFiltrados.Count > 0;
        }

        /// <summary>
        /// Verifica si un usuario, dado su correo, necesita cambiar su contraseña.
        /// </summary>
        /// <param name="correo">Correo electrónico del usuario.</param>
        /// <returns>Booleano que indica si el usuario con el correo dado necesita cambiar su contraseña.</returns>
        public bool BuscarSiUsuarioDebeCambiarContrasenia(string correo)
        {
            Predicate<Estudiante> predicado = estudiante => estudiante.Correo == correo && estudiante.DebeCambiarContrasenia == true;

            List<Estudiante> estudiantesFiltrados = ConsultasGenericas.FiltrarElementos(_listaEstudiantes, predicado);
            return estudiantesFiltrados.Count > 0;
        }

        /// <summary>
        /// Obtiene un estudiante según su legajo.
        /// </summary>
        /// <param name="legajo">Legajo del estudiante a buscar.</param>
        /// <returns>El estudiante correspondiente al legajo proporcionado o nulo si no se encuentra.</returns>
        public Estudiante? ObtenerEstudianteSegunLegajo(string legajo)
        {
            Predicate<Estudiante> predicado = estudiante => estudiante.Legajo == legajo;

            //Uso .FirstOrDefault() para agarrar al primer curso que encuentre que tenga el legajo.
            List<Estudiante> estudiantesFiltrados = ConsultasGenericas.FiltrarElementos(_listaEstudiantes, predicado);
            return estudiantesFiltrados.FirstOrDefault();
        }

        /// <summary>
        /// Obtiene una lista de correos electrónicos de todos los estudiantes.
        /// </summary>
        /// <returns>Lista de correos electrónicos de los estudiantes.</returns>
        internal static List<string> ObtenerListaDeCorreosEstudiantes()
        {
            List<string> listaCorreosEstudiantes = new List<string>();

            foreach (Estudiante estudiante in _listaEstudiantes)
            {
                listaCorreosEstudiantes.Add(estudiante.Correo);
            }

            return listaCorreosEstudiantes;
        }

        ///////////////////////UPDATE

        /// <summary>
        /// Cambia la contraseña de un estudiante en la base de datos.
        /// </summary>
        /// <param name="correo">Correo electrónico del estudiante.</param>
        /// <param name="nuevaContrasenia">Nueva contraseña del estudiante.</param>
        /// <returns>Tarea asincrónica que actualiza la contraseña del estudiante en la base de datos.</returns>
        public async Task CambiarContraseñaAEstudiante(string correo, string nuevaContrasenia)
        {
            string nuevaContraseniaHasheada = Hash.HashPassword(nuevaContrasenia);

            string query = "UPDATE Estudiante SET contrasenia = @nuevaContraseniaHasheada, debeCambiarContrasenia = 'False' WHERE correo = @correo";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@nuevaContraseniaHasheada", nuevaContraseniaHasheada },
                { "@correo", correo }
            };

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);

            CrearInstanciasDeEstudiantesAPartirDeBD();
        }

        //Getters y setters
        public static List<Estudiante> Estudiantes { get { return _listaEstudiantes; } }
    }
}
