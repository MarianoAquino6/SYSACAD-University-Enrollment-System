using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using System.Security.Cryptography;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConsultasCursos : ConexionBD
    {
        private static List<Curso> _listaCursos = new List<Curso>();

        /////////////////// RECONSTRUCCION DE LA LISTA DE CURSOS A PARTIR DE BD

        /// <summary>
        /// Crea instancias de cursos a partir de los datos obtenidos de la base de datos y actualiza la lista interna de cursos.
        /// </summary>
        internal static void CrearInstanciasDeCursoAPartirDeBD()
        {
            _listaCursos.Clear();
            _listaCursos = CargaDeInstanciasDesdeBD.CrearInstanciasDeCursoAPartirDeBD();
        }

        //////////////////////////////////CREATE

        /// <summary>
        /// Obtiene el ID de un registro en una tabla específica basado en un valor de texto proporcionado.
        /// </summary>
        /// <param name="tabla">Nombre de la tabla en la base de datos.</param>
        /// <param name="campo">Nombre del campo en la tabla.</param>
        /// <param name="valor">Valor del campo por el cual se busca el ID.</param>
        /// <returns>ID correspondiente al valor proporcionado en la tabla especificada.</returns>
        private int ObtenerIdDesdeTexto(string tabla, string campo, string valor)
        {
            string query = $"SELECT id FROM {tabla} WHERE {campo} = @valor";
            return ConsultasGenericas.EjecutarEscalar<int>(query, "@valor", valor);
        }

        /// <summary>
        /// Obtiene el ID de un turno según el nombre del turno.
        /// </summary>
        /// <param name="nombreTurno">Nombre del turno a buscar en la base de datos.</param>
        /// <returns>ID correspondiente al nombre del turno proporcionado.</returns>
        private int ObtenerTurnoIdSegunTexto(string nombreTurno)
        {
            return ObtenerIdDesdeTexto("Turno", "nombre", nombreTurno);
        }

        /// <summary>
        /// Obtiene el ID de un día según el nombre del día.
        /// </summary>
        /// <param name="nombreDia">Nombre del día a buscar en la base de datos.</param>
        /// <returns>ID correspondiente al nombre del día proporcionado.</returns>
        private int ObtenerDiaIdSegunTexto(string nombreDia)
        {
            return ObtenerIdDesdeTexto("Dia", "nombre", nombreDia);
        }

        /// <summary>
        /// Obtiene el ID asociado a un código de familia. Verifica si el código de familia existe en la tabla.
        /// Si existe, devuelve su ID correspondiente; de lo contrario, agrega el nuevo código y devuelve su ID.
        /// </summary>
        /// <param name="codigoFamilia">Código de familia a buscar o agregar en la tabla.</param>
        /// <returns>El ID del código de familia proporcionado.</returns>
        private async Task<int> ObtenerIdDeCodigoFamilia(string codigoFamilia)
        {
            int? codigoFamiliaId = ObtenerIdDesdeTexto("CodigoFamilia", "codigo", codigoFamilia);

            if (codigoFamiliaId != 0)
            {
                return codigoFamiliaId.Value; // Devuelve el ID existente si se encontró.
            }
            else
            {
                // El código de familia no existe en la tabla, lo agrego y obtengo su ID.
                //return AgregarNuevoCodigoDeFamiliaYDevolverSuId(codigoFamilia);
                return await AgregarNuevoCodigoDeFamiliaYDevolverSuId(codigoFamilia);
            }
        }

        /// <summary>
        /// Agrega un nuevo código de familia a la tabla "CodigoFamilia" y devuelve su ID.
        /// </summary>
        /// <param name="codigoFamilia">Código de familia a agregar en la tabla.</param>
        /// <returns>El ID del código de familia recién agregado.</returns>
        private async Task<int> AgregarNuevoCodigoDeFamiliaYDevolverSuId(string codigoFamilia)
        {
            using (var connectionAlternativa2 = new SqlConnection(@"Server = .; Database = TestSYSACAD; Trusted_Connection = True; Encrypt=False; TrustServerCertificate=True;"))
            {
                using (var commandAlternativo2 = new SqlCommand("INSERT INTO CodigoFamilia (codigo) VALUES (@codigo); SELECT SCOPE_IDENTITY();", connectionAlternativa2))
                {
                    commandAlternativo2.Parameters.AddWithValue("@codigo", codigoFamilia);
                    //connectionAlternativa2.Open();
                    await connectionAlternativa2.OpenAsync();

                    try
                    {
                        // Ejecuta la consulta y devuelve el ID del código de familia recién agregado.
                        var result = await commandAlternativo2.ExecuteScalarAsync();
                        return Convert.ToInt32(result);

                        //return Convert.ToInt32(commandAlternativo2.ExecuteScalar());
                    }
                    catch (SqlException ex)
                    {
                        RegistroExcepciones.RegistrarExcepcion(ex);
                        throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Ingresa un nuevo curso en la base de datos.
        /// </summary>
        /// <param name="nuevoCurso">Nuevo curso a ingresar en la base de datos.</param>
        internal async Task IngresarCursoBD(Curso nuevoCurso)
        {
            string query = "INSERT INTO Curso (codigo, nombre, descripcion, cupoMaximo, cupoDisponible, turnoId, aula, diaId, carreraCodigo, creditosRequeridos, promedioRequerido, codigoFamiliaId) " +
                   "VALUES (@codigo, @nombre, @descripcion, @cupoMaximo, @cupoDisponible, @turnoId, @aula, @diaId, @carreraCodigo, @creditosRequeridos, @promedioRequerido, @codigoFamiliaId)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@codigo", nuevoCurso.Codigo },
                { "@nombre", nuevoCurso.Nombre },
                { "@descripcion", nuevoCurso.Descripcion },
                { "@cupoMaximo", nuevoCurso.CupoMaximo },
                { "@cupoDisponible", nuevoCurso.CupoDisponible },
                { "@turnoId", ObtenerTurnoIdSegunTexto(nuevoCurso.Turno) },
                { "@aula", nuevoCurso.Aula },
                { "@diaId", ObtenerDiaIdSegunTexto(nuevoCurso.Dia) },
                { "@carreraCodigo", nuevoCurso.Carrera.ToString() },
                { "@creditosRequeridos", nuevoCurso.CreditosRequeridos },
                { "@promedioRequerido", nuevoCurso.PromedioRequerido },
                { "@codigoFamiliaId", await ObtenerIdDeCodigoFamilia(nuevoCurso.CodigoFamilia) }
            };

            //ConsultasGenericas.EjecutarNonQuery(query, parametros);

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);

            CrearInstanciasDeCursoAPartirDeBD();
        }

        /////////////////////////////////////READ

        /// <summary>
        /// Busca un curso en la lista de cursos según un código proporcionado.
        /// </summary>
        /// <param name="codigo">Código del curso a buscar.</param>
        /// <returns>Booleano que indica si el curso fue encontrado o no.</returns>
        public bool BuscarCursoBD(string codigo)
        {
            Predicate<Curso> predicado = curso => curso.Codigo == codigo;

            //Uso .Any() para verificar si por lo menos existe un curso con ese codigo
            return ConsultasGenericas.FiltrarElementos(_listaCursos, predicado).Any();
        }

        /// <summary>
        /// Obtiene una lista de cursos únicos, uno por cada código de familia.
        /// </summary>
        /// <returns>Lista de cursos, uno por cada código de familia.</returns>
        public List<Curso> ObtenerUnCursoPorCadaCodigoDeFamilia()
        {
            Predicate<Curso> predicado = curso => true; // No voy a filtrar ningun curso. Los agarro todos

            Dictionary<string, Curso> cursosUnicos = new Dictionary<string, Curso>();

            // Utiliza FiltrarElementos sin modificarlo
            foreach (var curso in ConsultasGenericas.FiltrarElementos(_listaCursos, predicado))
            {
                // Verifica si ya hay un curso con el mismo código de familia
                if (!cursosUnicos.ContainsKey(curso.CodigoFamilia))
                {
                    // Agrega el curso al diccionario si no existe
                    cursosUnicos.Add(curso.CodigoFamilia, curso);
                }
            }

            // Convierte los valores del diccionario de nuevo a una lista
            List<Curso> resultado = cursosUnicos.Values.ToList();

            return resultado;
        }

        /// <summary>
        /// Obtiene un curso dado un código específico.
        /// </summary>
        /// <param name="codigo">Código del curso a buscar.</param>
        /// <returns>El curso correspondiente al código proporcionado, si existe; de lo contrario, devuelve nulo.</returns>
        public Curso? ObtenerCursoDesdeCodigo(string codigo)
        {
            Predicate<Curso> predicado = curso => curso.Codigo == codigo;

            //Uso .FirstOrDefault() para agarrar al primer curso que encuentre que tenga el codigo.
            return ConsultasGenericas.FiltrarElementos(_listaCursos, predicado).FirstOrDefault();
        }

        /// <summary>
        /// Obtiene el código de familia a partir del nombre del curso.
        /// </summary>
        /// <param name="nombre">Nombre del curso para el que se busca el código de familia.</param>
        /// <returns>
        /// El código de familia correspondiente al nombre del curso si se encuentra; 
        /// de lo contrario, devuelve una cadena vacía.
        /// </returns>
        public string ObtenerCodigoDeFamiliaDesdeNombre(string nombre)
        {
            Predicate<Curso> predicado = curso => curso.Nombre == nombre;

            //Uso .FirstOrDefault() para agarrar al primer curso que encuentre que tenga el codigo pasado.
            //Uso .CodigoFamilia para acceder al codigo de familia del curso que encontre
            //Uso ?? "" para darle un valor predeterminado vacio si no lo encuentra
            return ConsultasGenericas.FiltrarElementos(_listaCursos, predicado).FirstOrDefault()?.CodigoFamilia ?? "";
        }

        /// <summary>
        /// Obtiene una lista de cursos a partir de un código de familia dado.
        /// </summary>
        /// <param name="codigoDeFamilia">Código de familia para filtrar los cursos.</param>
        /// <returns>Lista de cursos que pertenecen al código de familia especificado.</returns>
        public static List<Curso> ObtenerCursosDesdeCodigoDeFamilia(string codigoDeFamilia)
        {
            Predicate<Curso> predicado = curso => curso.CodigoFamilia == codigoDeFamilia;
            return ConsultasGenericas.FiltrarElementos(_listaCursos, predicado);
        }

        /// <summary>
        /// Obtiene un curso a partir de un código de familia dado.
        /// </summary>
        /// <param name="codigoDeFamilia">Código de familia para buscar un curso.</param>
        /// <returns>
        /// El primer curso que coincida con el código de familia especificado;
        /// de lo contrario, devuelve null si no se encuentra ningún curso.
        /// </returns>
        public Curso? ObtenerCursoDesdeCodigoDeFamilia(string codigoDeFamilia)
        {
            Predicate<Curso> predicado = curso => curso.CodigoFamilia == codigoDeFamilia;

            //Uso .FirstOrDefault() para agarrar al primer curso que encuentre que tenga el codigo de familia.
            return ConsultasGenericas.FiltrarElementos(_listaCursos, predicado).FirstOrDefault();
        }

        /// <summary>
        /// Obtiene un curso a partir de un nombre y un turno especificado.
        /// </summary>
        /// <param name="nombre">Nombre del curso a buscar.</param>
        /// <param name="turno">Turno del curso a buscar.</param>
        /// <returns>
        /// El primer curso que coincida con el nombre y turno especificados;
        /// devuelve null si no se encuentra ningún curso.
        /// </returns>
        public Curso? ObtenerCursoAPartirDeNombreYTurno(string nombre, string turno)
        {
            Predicate<Curso> predicado = curso => curso.Nombre == nombre && curso.Turno == turno;

            //Uso .FirstOrDefault() para agarrar al primer curso que encuentre que tenga el nombre y turno.
            return ConsultasGenericas.FiltrarElementos(_listaCursos, predicado).FirstOrDefault();
        }

        /// <summary>
        /// Obtiene una lista de cursos a partir de una lista de códigos de curso dados.
        /// </summary>
        /// <param name="listaCodigos">Lista de códigos de curso para filtrar los cursos.</param>
        /// <returns>Lista de cursos que coinciden con los códigos proporcionados.</returns>
        public List<Curso> ObtenerListaCursosDesdeListaCodigos(List<string> listaCodigos)
        {
            Predicate<Curso> predicado = curso => listaCodigos.Contains(curso.Codigo);
            return ConsultasGenericas.FiltrarElementos(_listaCursos, predicado);
        }

        /// <summary>
        /// Obtiene un conjunto de nombres de cursos que no están correlacionados con el curso seleccionado.
        /// </summary>
        /// <param name="cursoSeleccionado">Curso seleccionado como referencia para la búsqueda.</param>
        /// <returns>Conjunto de nombres de cursos que no son correlativos al curso seleccionado.</returns>
        public HashSet<string> ObtenerNombresDeCursosNoCorrelativos(Curso cursoSeleccionado)
        {
            HashSet<string> nombresAgregados = new HashSet<string>();

            foreach (Curso curso in _listaCursos)
            {
                // Si el curso iterado no se encuentra ya dentro de las correlatividades de la familia
                // del curso seleccionado y el curso iterado no se encuentra en la familia del
                // curso seleccionado.
                if (!cursoSeleccionado.Correlatividades.Contains(curso.CodigoFamilia) &&
                    curso.CodigoFamilia != cursoSeleccionado.CodigoFamilia)
                {
                    if (!nombresAgregados.Contains(curso.CodigoFamilia))
                    {
                        nombresAgregados.Add(curso.Nombre);
                    }
                }
            }

            return nombresAgregados;
        }

        /// <summary>
        /// Verifica si hay algún curso con una lista de espera no vacía.
        /// </summary>
        /// <returns>
        /// Devuelve true si al menos un curso tiene una lista de espera no vacía;
        /// de lo contrario, devuelve false.
        /// </returns>
        public static bool HallarSiHayAlgunCursoConListaDeEspera()
        {
            bool hayCursoConListaDeEspera = false;

            foreach (Curso curso in _listaCursos)
            {
                if (curso.ListaDeEspera.Count > 0)
                {
                    hayCursoConListaDeEspera = true;
                    break;
                }
            }

            return hayCursoConListaDeEspera;
        }

        /// <summary>
        /// Devuelve un diccionario de cursos con registros de lista de espera filtrados por fechas.
        /// </summary>
        /// <param name="fechaDesde">Fecha inicial para filtrar los registros de lista de espera.</param>
        /// <param name="fechaHasta">Fecha final para filtrar los registros de lista de espera.</param>
        /// <returns>
        /// Diccionario que contiene cursos con registros de lista de espera en el rango de fechas especificado.
        /// </returns>
        public Dictionary<Curso, Dictionary<string, DateTime>> DevolverDiccionarioConRegistrosListaDeEsperaSegunFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            Dictionary<Curso, Dictionary<string, DateTime>> cursosConListaDeEspera = new Dictionary<Curso, Dictionary<string, DateTime>>();

            foreach (Curso curso in _listaCursos)
            {
                if (curso.ListaDeEspera.Count > 0)
                {
                    Dictionary<string, DateTime> registrosFiltrados = new Dictionary<string, DateTime>();

                    foreach (var registro in curso.ListaDeEspera)
                    {
                        if (registro.Value >= fechaDesde && registro.Value <= fechaHasta)
                        {
                            registrosFiltrados.Add(registro.Key, registro.Value);
                        }
                    }

                    if (registrosFiltrados.Count > 0)
                    {
                        cursosConListaDeEspera[curso] = registrosFiltrados;
                    }
                }
            }

            return cursosConListaDeEspera;
        }

        /// <summary>
        /// Obtiene el código de familia a partir del nombre del curso.
        /// </summary>
        /// <param name="nombre">Nombre del curso para obtener el código de familia.</param>
        /// <returns>Código de familia correspondiente al nombre del curso.</returns>
        public static string ObtenerCodigoDeFamilia(string nombre)
        {
            string codigoDeFamilia = nombre.Trim().ToUpper();
            codigoDeFamilia = codigoDeFamilia.Replace(" ", "");

            return codigoDeFamilia;
        }

        ///////////////////////////////////UPDATE

        ///////UPDATE REQUISITOS


        /// <summary>
        /// Elimina las correlatividades del curso seleccionado.
        /// </summary>
        /// <param name="idCodigoFamilia">ID de la familia del curso a modificar.</param>
        private static async Task EliminarCorrelatividadesDeCursoSeleccionado(int idCodigoFamilia)
        {
            string query = "DELETE FROM Correlatividades WHERE idFamiliaCursoBase = @CFId";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@CFId", idCodigoFamilia }
            };

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);
        }

        /// <summary>
        /// Agrega nuevas correlatividades al curso seleccionado.
        /// </summary>
        /// <param name="CFCursoAModificar">Código de la familia del curso a modificar.</param>
        /// <param name="CFNuevasCorrelatividades">Lista de nuevas correlatividades a agregar.</param>
        private async Task AgregarNuevasCorrelatividadesACursoSeleccionado(string CFCursoAModificar, List<string> CFNuevasCorrelatividades)
        {
            int idCodigoFamilia = await ObtenerIdDeCodigoFamilia(CFCursoAModificar);

            foreach (string CF in CFNuevasCorrelatividades)
            {
                string query = "INSERT INTO Correlatividades (idFamiliaCursoBase, codigoFamiliaCorrelatividad) VALUES (@id, @CF)";

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@id", idCodigoFamilia },
                    { "@CF", CF }
                };

                await ConsultasGenericas.EjecutarNonQuery(query, parametros);
            }
        }

        /// <summary>
        /// Actualiza los requisitos (créditos y promedio) de los cursos.
        /// </summary>
        /// <param name="CFCursoAModificar">Código de la familia del curso a modificar.</param>
        /// <param name="CFcorrelatividades">Lista de nuevas correlatividades a agregar.</param>
        /// <param name="creditos">Créditos requeridos para el curso.</param>
        /// <param name="promedio">Promedio requerido para el curso.</param>
        public async Task ActualizarRequisitosACursos(string CFCursoAModificar, List<string> CFcorrelatividades, int creditos, double promedio)
        {
            int idCodigoFamilia = await ObtenerIdDeCodigoFamilia(CFCursoAModificar);

            string updateQuery = "UPDATE Curso SET creditosRequeridos = @creditos, promedioRequerido = @promedio WHERE codigoFamiliaId = @valorABuscar";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@creditos", creditos },
                { "@promedio", promedio },
                { "@valorABuscar", idCodigoFamilia }
            };

            await ConsultasGenericas.EjecutarNonQuery(updateQuery, parametros);

            await EliminarCorrelatividadesDeCursoSeleccionado(idCodigoFamilia);
            await AgregarNuevasCorrelatividadesACursoSeleccionado(CFCursoAModificar, CFcorrelatividades);

            CrearInstanciasDeCursoAPartirDeBD();
        }

        ///////UPDATE TABLA CURSOS

        /// <summary>
        /// Edita un curso en la base de datos con código de familia.
        /// </summary>
        /// <param name="codigoABuscar">Código a buscar para la edición del curso.</param>
        /// <param name="nombre">Nuevo nombre para el curso.</param>
        /// <param name="codigo">Nuevo código para el curso.</param>
        /// <param name="descripcion">Nueva descripción para el curso.</param>
        /// <param name="cupoMaximo">Nuevo cupo máximo para el curso.</param>
        /// <param name="turno">Nuevo turno para el curso.</param>
        /// <param name="dia">Nuevo día para el curso.</param>
        /// <param name="aula">Nueva aula para el curso.</param>
        /// <param name="codigoFamilia">Nuevo código de familia para el curso.</param>
        public async Task EditarCursoBD(string codigoABuscar, string nombre, string codigo, string descripcion, int cupoMaximo, string turno, string dia, string aula)
        {
            int idTurno = ObtenerTurnoIdSegunTexto(turno);
            int idDia = ObtenerDiaIdSegunTexto(dia);

            string updateQuery = "UPDATE Curso SET codigo = @codigo, nombre = @nombre, descripcion = @descripcion," +
                "cupoMaximo = @cupoMaximo, cupoDisponible = @cupoMaximo, turnoId = @turnoId, aula = @aula, " +
                "diaId = @diaId WHERE codigo = @valorABuscar";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@codigo", codigo },
                { "@nombre", nombre },
                { "@descripcion", descripcion },
                { "@cupoMaximo", cupoMaximo },
                { "@turnoId", idTurno },
                { "@aula", aula },
                { "@diaId", idDia },
                { "@valorABuscar", codigoABuscar }
            };

            await ConsultasGenericas.EjecutarNonQuery(updateQuery, parametros);

            CrearInstanciasDeCursoAPartirDeBD();
        }

        /// <summary>
        /// Edita un curso en la base de datos sin código de familia.
        /// </summary>
        /// <param name="codigoABuscar">Código a buscar para la edición del curso.</param>
        /// <param name="nombre">Nuevo nombre para el curso.</param>
        /// <param name="codigo">Nuevo código para el curso.</param>
        /// <param name="descripcion">Nueva descripción para el curso.</param>
        /// <param name="cupoMaximo">Nuevo cupo máximo para el curso.</param>
        /// <param name="turno">Nuevo turno para el curso.</param>
        /// <param name="dia">Nuevo día para el curso.</param>
        /// <param name="aula">Nueva aula para el curso.</param>
        public async Task EditarCursoBD(string codigoABuscar, string nombre, string codigo, string descripcion, int cupoMaximo, string turno, string dia, string aula, string codigoFamilia)
        {
            int idTurno = ObtenerTurnoIdSegunTexto(turno);
            int idDia = ObtenerDiaIdSegunTexto(dia);
            int CFid = await ObtenerIdDeCodigoFamilia(codigoFamilia);

            string updateQuery = "UPDATE Curso SET codigo = @codigo, nombre = @nombre, descripcion = @descripcion," +
                "cupoMaximo = @cupoMaximo, cupoDisponible = @cupoMaximo, turnoId = @turnoId, aula = @aula, " +
                "diaId = @diaId, codigoFamiliaId = @codigoFamilia WHERE codigo = @valorABuscar";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@codigo", codigo },
                { "@nombre", nombre },
                { "@descripcion", descripcion },
                { "@cupoMaximo", cupoMaximo },
                { "@turnoId", idTurno },
                { "@aula", aula },
                { "@diaId", idDia },
                { "@codigoFamilia", CFid },
                { "@valorABuscar", codigoABuscar }
            };

            await ConsultasGenericas.EjecutarNonQuery(updateQuery, parametros);

            CrearInstanciasDeCursoAPartirDeBD();
        }

        ///////UPDATE TABLA ALUMNOS EN LISTA DE ESPERA

        /// <summary>
        /// Elimina la lista de espera de un curso seleccionado en la base de datos.
        /// </summary>
        /// <param name="codigoCurso">Código del curso del cual se eliminará la lista de espera.</param>
        private static async Task EliminarListaEsperaDeCursoSeleccionado(string codigoCurso)
        {
            string query = "DELETE FROM AlumnosEnListaDeEspera WHERE codigoCurso = @codigoCurso";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@codigoCurso", codigoCurso }
            };

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);
        }

        /// <summary>
        /// Agrega una nueva lista de espera a un curso seleccionado en la base de datos.
        /// </summary>
        /// <param name="codigoCurso">Código del curso al cual se agregará la lista de espera.</param>
        /// <param name="listaEsperaRecibida">Diccionario con la lista de espera a agregar.</param>
        private static async Task AgregarNuevaListaEsperaACursoSeleccionado(string codigoCurso, Dictionary<string, DateTime> listaEsperaRecibida)
        {
            foreach (var parKeyValue in listaEsperaRecibida)
            {
                string query = "INSERT INTO AlumnosEnListaDeEspera (legajoEstudiante, codigoCurso, fechaIngreso) VALUES (@legajo, @codigoCurso, @fechaIngreso)";

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@legajo", parKeyValue.Key },
                    { "@codigoCurso", codigoCurso },
                    { "@fechaIngreso", parKeyValue.Value }
                };

                await ConsultasGenericas.EjecutarNonQuery(query, parametros);
            }
        }

        /// <summary>
        /// Actualiza la lista de espera de un curso en la base de datos.
        /// </summary>
        /// <param name="cursoRecibido">Curso al que se actualizará la lista de espera.</param>
        /// <param name="listaEsperaRecibida">Diccionario con la nueva lista de espera.</param>
        public async Task ActualizarListaDeEsperaDeCurso(Curso cursoRecibido, Dictionary<string, DateTime> listaEsperaRecibida)
        {
            await EliminarListaEsperaDeCursoSeleccionado(cursoRecibido.Codigo);
            await AgregarNuevaListaEsperaACursoSeleccionado(cursoRecibido.Codigo, listaEsperaRecibida);

            CrearInstanciasDeCursoAPartirDeBD();
        }

        ////// AGREGAR ESTUDIANTE A LISTA DE ESPERA

        /// <summary>
        /// Agrega un estudiante a la lista de espera de un curso.
        /// </summary>
        /// <param name="codigoCurso">Código del curso al que se agrega el estudiante.</param>
        /// <param name="legajoEstudiante">Legajo del estudiante a agregar.</param>
        internal static async Task AgregarEstudianteAListaDeEspera(string codigoCurso, string legajoEstudiante)
        {
            string query = "INSERT INTO AlumnosEnListaDeEspera (legajoEstudiante, codigoCurso, fechaIngreso) VALUES (@legajo, @codigoCurso, @fechaIngreso)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@legajo", legajoEstudiante },
                { "@codigoCurso", codigoCurso },
                { "@fechaIngreso", DateTime.Now }
            };

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);

            CrearInstanciasDeCursoAPartirDeBD();
        }


        ///////UPDATE UNICAMENTE CUPOS DISPONIBLES

        /// <summary>
        /// Resta un cupo disponible en el curso especificado.
        /// </summary>
        /// <param name="cursoARestarCupo">Curso al que se resta un cupo disponible.</param>
        internal static async Task RestarCupoDisponible(Curso cursoARestarCupo)
        {
            string updateQuery = "UPDATE Curso SET cupoDisponible = cupoDisponible - 1 WHERE codigo = @valorABuscar";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@valorABuscar", cursoARestarCupo.Codigo }
            };

            await ConsultasGenericas.EjecutarNonQuery(updateQuery, parametros);

            CrearInstanciasDeCursoAPartirDeBD();
        }

        ///////////////////////DELETE


        /// <summary>
        /// Verifica si hay códigos de familia sin cursos correspondientes y los elimina.
        /// </summary>
        private static async Task CorroborarSiHayCFSinCursosCorrespondientesYBorrarlos()
        {
            string query = "DELETE FROM CodigoFamilia WHERE id NOT IN (SELECT DISTINCT codigoFamiliaId FROM Curso)";

            Dictionary<string, object> parametros = new Dictionary<string, object>();

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);
        }

        /// <summary>
        /// Elimina un curso de la base de datos.
        /// </summary>
        /// <param name="codigoABuscar">Código del curso a eliminar.</param>
        public async Task EliminarCursoBD(string codigoABuscar)
        {
            string query = "DELETE FROM Curso WHERE codigo = @codigoABuscar";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@codigoABuscar", codigoABuscar }
            };

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);

            await CorroborarSiHayCFSinCursosCorrespondientesYBorrarlos();
            CrearInstanciasDeCursoAPartirDeBD();
            ConsultasInscripciones.RefrescarEstudianteLogueado();
        }

        //Getters y setters
        public static List<Curso> Cursos { get { return _listaCursos; } }
    }
}
