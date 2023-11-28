using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
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
    public class GestorRequisitos
    {
        private ConsultasCursos _consultasCursos = new ConsultasCursos();

        /////////////////////////////// GESTION ANTE CONFIRMACION DE REQUISITOS ////////////////////////////////

        /// <summary>
        /// Gestiona la confirmación de requisitos para un curso.
        /// </summary>
        /// <param name="camposIngresados">Diccionario de campos ingresados para validación.</param>
        /// <param name="CFCursoAModificar">Código del curso a modificar.</param>
        /// <param name="CFcorrelatividades">Lista de códigos de correlatividades.</param>
        /// <param name="creditos">Créditos del curso.</param>
        /// <param name="promedio">Promedio del curso.</param>
        /// <returns>Respuesta de validación de los requisitos.</returns>
        public async Task<RespuestaValidacionInput> GestionarConfirmacionRequisitos(Dictionary<string, string> camposIngresados, string CFCursoAModificar, List<string> CFcorrelatividades, string creditos, string promedio)
        {
            RespuestaValidacionInput respuestaValidacion = ValidarRequisitos(camposIngresados);

            if (respuestaValidacion.AusenciaCamposVacios && !respuestaValidacion.ExistenciaErrores)
            {
                await _consultasCursos.ActualizarRequisitosACursos(CFCursoAModificar, CFcorrelatividades, int.Parse(creditos), double.Parse(promedio));
            }

            return respuestaValidacion;
        }

        /// <summary>
        /// Valida los requisitos para un curso a partir de campos ingresados.
        /// </summary>
        /// <param name="camposIngresados">Diccionario de campos ingresados para validación.</param>
        /// <returns>Respuesta de validación de los requisitos.</returns>
        private RespuestaValidacionInput ValidarRequisitos(Dictionary<string, string> camposIngresados)
        {
            ValidadorInputGenerico validacionInputRequisitos = new ValidadorInputGenerico();
            RespuestaValidacionInput respuestaValidacion = validacionInputRequisitos.ValidarDatos(camposIngresados, ModoValidacionInput.CursoRequisitos);

            return respuestaValidacion;
        }
    }
}
