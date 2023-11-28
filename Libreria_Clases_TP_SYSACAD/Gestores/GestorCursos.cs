using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Gestores
{
    public class GestorCursos
    {
        private ConsultasCursos _consultasCursos = new ConsultasCursos();

        /// <summary>
        /// Obtiene un curso a partir de un código.
        /// </summary>
        /// <param name="codigo">Código del curso a buscar.</param>
        /// <returns>El curso encontrado o null si no se encuentra.</returns>
        public Curso? ObtenerCursoDesdeCodigo(string codigo)
        {
            return _consultasCursos.ObtenerCursoDesdeCodigo(codigo);
        }

        /// <summary>
        /// Obtiene una lista de cursos a partir de una lista de códigos.
        /// </summary>
        /// <param name="listaCodigos">Lista de códigos de cursos a buscar.</param>
        /// <returns>Una lista de cursos encontrados.</returns>
        public List<Curso> ObtenerListaCursosDesdeListaCodigos(List<string> listaCodigos)
        {
            return _consultasCursos.ObtenerListaCursosDesdeListaCodigos(listaCodigos);
        }

        /// <summary>
        /// Edita un curso con los nuevos datos proporcionados.
        /// </summary>
        /// <param name="codigoABuscar">Código del curso a editar.</param>
        /// <param name="nombre">Nuevo nombre del curso.</param>
        /// <param name="codigo">Nuevo código del curso.</param>
        /// <param name="descripcion">Nueva descripción del curso.</param>
        /// <param name="cupoMaximo">Nuevo cupo máximo del curso.</param>
        /// <param name="turno">Nuevo turno del curso.</param>
        /// <param name="dia">Nuevo día del curso.</param>
        /// <param name="aula">Nueva aula del curso.</param>
        /// <returns>Tarea asincrónica.</returns>
        public async Task EditarCurso(string codigoABuscar, string nombre, string codigo, string descripcion, int cupoMaximo, string turno, string dia, string aula)
        {
            await _consultasCursos.EditarCursoBD(codigoABuscar, nombre, codigo, descripcion, cupoMaximo, turno, dia, aula);
        }


        /// <summary>
        /// Edita un curso en la base de datos con los nuevos valores proporcionados.
        /// </summary>
        /// <param name="codigoABuscar">Código del curso a buscar para realizar la edición.</param>
        /// <param name="nombre">Nuevo nombre del curso.</param>
        /// <param name="codigo">Nuevo código del curso.</param>
        /// <param name="descripcion">Nueva descripción del curso.</param>
        /// <param name="cupoMaximo">Nuevo cupo máximo del curso.</param>
        /// <param name="turno">Nuevo turno del curso.</param>
        /// <param name="dia">Nuevo día del curso.</param>
        /// <param name="aula">Nueva aula del curso.</param>
        /// <param name="codigoFamilia">Nuevo código de familia del curso.</param>
        /// <returns>Tarea asincrónica.</returns>
        public async Task EditarCurso(string codigoABuscar, string nombre, string codigo, string descripcion, int cupoMaximo, string turno, string dia, string aula, string codigoFamilia)
        {
            await _consultasCursos.EditarCursoBD(codigoABuscar, nombre, codigo, descripcion, cupoMaximo, turno, dia, aula, codigoFamilia);
        }

        /// <summary>
        /// Actualiza la lista de espera de un curso con la nueva lista recibida.
        /// </summary>
        /// <param name="cursoRecibido">Curso para el cual se actualiza la lista de espera.</param>
        /// <param name="listaEsperaRecibida">Nueva lista de espera para el curso.</param>
        /// <returns>Tarea asincrónica.</returns>
        public async Task ActualizarListaDeEsperaDeCurso(Curso cursoRecibido, Dictionary<string, DateTime> listaEsperaRecibida)
        {
            await _consultasCursos.ActualizarListaDeEsperaDeCurso(cursoRecibido, listaEsperaRecibida);
        }

        /// <summary>
        /// Elimina un curso de la base de datos según el código proporcionado.
        /// </summary>
        /// <param name="codigoABuscar">Código del curso a eliminar.</param>
        /// <returns>Tarea asincrónica.</returns>
        public async Task EliminarCurso(string codigoABuscar)
        {
            await _consultasCursos.EliminarCursoBD(codigoABuscar);
        }


        /// <summary>
        /// Valida la existencia de duplicados de cursos en la base de datos, según el código proporcionado.
        /// </summary>
        /// <param name="codigo">Código del curso a buscar.</param>
        /// <returns>True si existen duplicados, False si no existen.</returns>
        public bool ValidarDuplicadosCursos(string codigo)
        {
            return _consultasCursos.BuscarCursoBD(codigo);
        }

        /// <summary>
        /// Obtiene un curso a partir del nombre y turno proporcionados.
        /// </summary>
        /// <param name="nombreCurso">Nombre del curso a buscar.</param>
        /// <param name="turno">Turno del curso a buscar.</param>
        /// <returns>El curso correspondiente al nombre y turno especificados.</returns>
        public Curso ObtenerCursoAPartirDeNombreYTurno(string nombreCurso, string turno)
        {
            return _consultasCursos.ObtenerCursoAPartirDeNombreYTurno(nombreCurso, turno);
        }

        /// <summary>
        /// Obtiene una lista de cursos, uno por cada código de familia existente.
        /// </summary>
        /// <returns>Lista de cursos, uno por cada código de familia.</returns>
        public List<Curso> ObtenerUnCursoPorCadaCodigoDeFamilia()
        {
            return _consultasCursos.ObtenerUnCursoPorCadaCodigoDeFamilia();
        }


        /// <summary>
        /// Obtiene el código de familia a partir del nombre proporcionado.
        /// </summary>
        /// <param name="nombre">Nombre de la familia a buscar.</param>
        /// <returns>El código de la familia correspondiente al nombre especificado.</returns>
        public string ObtenerCodigoDeFamiliaDesdeNombre(string nombre)
        {
            return _consultasCursos.ObtenerCodigoDeFamiliaDesdeNombre(nombre);
        }

        /// <summary>
        /// Obtiene un curso a partir del código de familia proporcionado.
        /// </summary>
        /// <param name="codigoDeFamilia">Código de la familia para buscar el curso.</param>
        /// <returns>El curso correspondiente al código de familia especificado, si existe.</returns>
        public Curso? ObtenerCursoDesdeCodigoDeFamilia(string codigoDeFamilia)
        {
            return _consultasCursos.ObtenerCursoDesdeCodigoDeFamilia(codigoDeFamilia);
        }

        /// <summary>
        /// Obtiene los nombres de cursos que no son correlativos al curso seleccionado.
        /// </summary>
        /// <param name="cursoSeleccionado">Curso seleccionado para buscar cursos no correlativos.</param>
        /// <returns>Un conjunto de nombres de cursos no correlativos al curso seleccionado.</returns>
        public HashSet<string> ObtenerNombresDeCursosNoCorrelativos(Curso cursoSeleccionado)
        {
            return _consultasCursos.ObtenerNombresDeCursosNoCorrelativos(cursoSeleccionado);
        }


        //////////////////////////////////////GESTION/////////////////////////////////

        /// <summary>
        /// Valida los datos de entrada relacionados con la gestión de cursos.
        /// </summary>
        /// <param name="dictCampos">Diccionario que contiene los campos a validar.</param>
        /// <returns>Respuesta de validación de los datos de entrada.</returns>
        public RespuestaValidacionInput ValidarInputsCursos(Dictionary<string, string> dictCampos)
        {
            ValidadorInputGenerico validadorInputCursos = new ValidadorInputGenerico();
            RespuestaValidacionInput validacionCursos = validadorInputCursos.ValidarDatos(dictCampos, ModoValidacionInput.CursoAgregarOEditar);

            return validacionCursos;
        }

        /// <summary>
        /// Gestiona la edición de un curso basándose en la detección de duplicados.
        /// </summary>
        /// <param name="cambioDeCodigo">Indica si hay un cambio en el código del curso.</param>
        /// <param name="codigoOriginal">Código original del curso.</param>
        /// <param name="nombre">Nombre del curso.</param>
        /// <param name="codigo">Código del curso.</param>
        /// <param name="descripcion">Descripción del curso.</param>
        /// <param name="cupoMaximo">Cupo máximo del curso.</param>
        /// <param name="turno">Turno del curso.</param>
        /// <param name="dia">Día del curso.</param>
        /// <param name="aula">Aula del curso.</param>
        /// <returns>Devuelve verdadero si la gestión de edición se realiza con éxito; de lo contrario, falso.</returns>
        public async Task<bool> GestionarEdicionCursoEnBaseADuplicados(bool cambioDeCodigo, string codigoOriginal, string nombre, string codigo, string descripcion, string cupoMaximo, string turno, string dia, string aula)
        {
            if (cambioDeCodigo)
            {
                // Valida si existen duplicados para el nuevo código
                bool validacionDuplicados = ValidarDuplicadosCursos(codigo);

                if (!validacionDuplicados)
                {
                    // Obtiene el nuevo código de familia
                    string nuevoCodigoFamilia = ConsultasCursos.ObtenerCodigoDeFamilia(codigo);

                    // Realiza la edición del curso con el nuevo código de familia
                    await EditarCurso(codigoOriginal, nombre, codigo, descripcion, int.Parse(cupoMaximo), turno, dia, aula, nuevoCodigoFamilia);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                // Realiza la edición del curso sin cambios en el código
                await EditarCurso(codigoOriginal, nombre, codigo, descripcion, int.Parse(cupoMaximo), turno, dia, aula);

                return true;
            }
        }


        /// <summary>
        /// Gestiona la adición de un nuevo curso.
        /// </summary>
        /// <param name="nombre">Nombre del curso.</param>
        /// <param name="codigo">Código del curso.</param>
        /// <param name="descripcion">Descripción del curso.</param>
        /// <param name="cupoMaximo">Cupo máximo del curso.</param>
        /// <param name="turno">Turno del curso.</param>
        /// <param name="dia">Día del curso.</param>
        /// <param name="aula">Aula del curso.</param>
        /// <param name="carrera">Carrera asociada al curso.</param>
        /// <returns>
        /// Devuelve verdadero si la gestión de agregar el curso se lleva a cabo exitosamente.
        /// Devuelve falso si se detecta un duplicado del código de curso y no se puede agregar el curso.
        /// </returns>
        public async Task<bool> GestionarAgregarCurso(string nombre, string codigo, string descripcion, string cupoMaximo, string turno, string dia, string aula, Carrera carrera)
        {
            // Valida si existen duplicados para el nuevo código
            bool validacionDuplicados = ValidarDuplicadosCursos(codigo);

            if (!validacionDuplicados)
            {
                // Crea un nuevo curso
                Curso nuevoCurso = new Curso(nombre, codigo, descripcion, int.Parse(cupoMaximo), turno, aula, dia, carrera);

                // Registra el nuevo curso
                await nuevoCurso.Registrar();
            }

            return validacionDuplicados;
        }


        /// <summary>
        /// Gestiona el proceso de inscripción a cursos.
        /// </summary>
        /// <param name="cursosSeleccionados">Lista de cursos seleccionados para la inscripción.</param>
        /// <returns>Resultado de la validación de la inscripción a los cursos.</returns>
        public async Task<ValidacionInscripcionResultado> GestionarInscripcionACurso(List<Curso> cursosSeleccionados)
        {
            // Crea una nueva instancia de validador de inscripciones
            ValidadorDeInscripciones nuevaValidacion = new ValidadorDeInscripciones();

            // Valida los cursos seleccionados según el cupo disponible
            ValidacionInscripcionResultado resultadoValidacion = await nuevaValidacion.ValidarCursosSegunCupo(cursosSeleccionados);

            return resultadoValidacion;
        }
    }




}
