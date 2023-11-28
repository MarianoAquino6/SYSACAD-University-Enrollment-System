using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Validaciones
{
    public class ValidadorAsignacionCursoAProfesor
    {
        //VALIDO QUE NO HAYA CONFLICTOS DE HORARIOS
        private ConsultasCursos consultasCursos = new ConsultasCursos();


        /// <summary>
        /// Valida si un curso puede ser asignado a un profesor verificando la disponibilidad del mismo.
        /// </summary>
        /// <param name="codigoCursoAsignar">Código del curso a asignar.</param>
        /// <param name="profesor">Profesor al que se intenta asignar el curso.</param>
        /// <returns>
        /// Valor booleano que indica si el curso puede ser asignado al profesor (<c>true</c> si es posible,
        /// <c>false</c> si no es posible).
        /// </returns>
        public bool ValidarAsignacionDeCursoAProfesor(string codigoCursoAsignar, Profesor profesor)
        {
            bool resultadoValidacion = true;
            
            if (profesor.CodigosCursosDeProfesor.Count > 0)
            {
                List<Curso> listaCursosDelProfesor = consultasCursos.ObtenerListaCursosDesdeListaCodigos(profesor.CodigosCursosDeProfesor);
                Curso cursoAAsignar = consultasCursos.ObtenerCursoDesdeCodigo(codigoCursoAsignar);

                foreach (Curso cursoDelProfesor in listaCursosDelProfesor)
                {
                    if (cursoDelProfesor.Dia == cursoAAsignar.Dia && cursoDelProfesor.Turno == cursoAAsignar.Turno)
                    {
                        resultadoValidacion = false;
                        break;
                    }
                }
            }

            return resultadoValidacion;
        }
    }
}
