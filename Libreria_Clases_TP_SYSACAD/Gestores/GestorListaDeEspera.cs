using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Gestores
{
    public class GestorListaDeEspera
    {
        private ConsultasCursos _consultasCursos = new ConsultasCursos();

        /// <summary>
        /// Valida el ingreso de un estudiante a la lista de espera de un curso específico.
        /// </summary>
        /// <param name="legajoDelEstudianteAAgregar">Legajo del estudiante a agregar en la lista de espera.</param>
        /// <param name="cursoSeleccionado">Curso al que se intenta agregar el estudiante en lista de espera.</param>
        /// <returns>Resultado de la validación del ingreso del estudiante en lista de espera.</returns>
        public RespuestaValidacionInput ValidarInputListaEspera(string legajoDelEstudianteAAgregar, Curso cursoSeleccionado)
        {
            ValidadorAdicionDeAlumnoEnListaDeEspera validadorDelInputLegajo = new ValidadorAdicionDeAlumnoEnListaDeEspera();
            RespuestaValidacionInput respuestaValidacion = validadorDelInputLegajo.ValidarAdicionAlumnoEnLista(legajoDelEstudianteAAgregar, cursoSeleccionado);

            return respuestaValidacion;
        }

        /// <summary>
        /// Gestiona la actualización de la lista de espera para un curso determinado.
        /// </summary>
        /// <param name="cursoSeleccionado">Curso al que se actualiza la lista de espera.</param>
        /// <param name="alumnosEnListaDeEspera">Diccionario que contiene los alumnos en lista de espera con su fecha de ingreso.</param>
        /// <returns><c>true</c> si la actualización de la lista de espera se realizó con éxito; de lo contrario, <c>false</c>.</returns>
        public async Task<bool> GestionarActualizacionListaEspera(Curso cursoSeleccionado, Dictionary<string, DateTime> alumnosEnListaDeEspera)
        {
            bool resultadoActualizacion = false;

            if (cursoSeleccionado != null)
            {
                await _consultasCursos.ActualizarListaDeEsperaDeCurso(cursoSeleccionado, alumnosEnListaDeEspera);
                resultadoActualizacion = true;
            }

            return resultadoActualizacion;
        }
    }
}
