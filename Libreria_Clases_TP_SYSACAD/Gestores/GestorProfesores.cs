using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;

namespace Libreria_Clases_TP_SYSACAD.Gestores
{
    public class GestorProfesores
    {
        private ConsultasProfesores _consultasProfesores = new ConsultasProfesores();
        private ValidadorAsignacionCursoAProfesor validadorAsignacionCursoAProfesor = new ValidadorAsignacionCursoAProfesor();

        /// <summary>
        /// Devuelve un profesor según su correo electrónico.
        /// </summary>
        /// <param name="correo">Correo electrónico del profesor a buscar.</param>
        /// <returns>Profesor encontrado o nulo si no se encuentra.</returns>
        public Profesor? DevolverProfesor(string correo)
        {
            return _consultasProfesores.DevolverProfesor(correo);
        }

        /// <summary>
        /// Edita los detalles de un profesor en la base de datos.
        /// </summary>
        /// <param name="correo">Nuevo correo electrónico.</param>
        /// <param name="direccion">Nueva dirección.</param>
        /// <param name="especializacion">Nueva especialización.</param>
        /// <param name="nombre">Nuevo nombre.</param>
        /// <param name="telefono">Nuevo teléfono.</param>
        /// <param name="correoOriginal">Correo electrónico original del profesor a editar.</param>
        private async Task EditarProfesor(string correo, string direccion, string especializacion, string nombre, string telefono, string correoOriginal)
        {
            await _consultasProfesores.EditarProfesor(correo, direccion, especializacion, nombre, telefono, correoOriginal);
        }

        /// <summary>
        /// Elimina un profesor de la base de datos.
        /// </summary>
        /// <param name="correo">Correo electrónico del profesor a eliminar.</param>
        public async Task EliminarProfesor(string correo)
        {
            await _consultasProfesores.EliminarProfesorBD(correo);
        }

        /// <summary>
        /// Valida la existencia de un profesor en la base de datos a través del correo electrónico.
        /// </summary>
        /// <param name="correo">Correo electrónico del profesor a validar.</param>
        /// <returns>True si el profesor ya existe, False si no existe.</returns>
        public bool ValidarDuplicadosProfesores(string correo)
        {
            return _consultasProfesores.BuscarProfesorExistenteBD(correo);
        }

        //////////////////////////////////////GESTION/////////////////////////////////

        /// <summary>
        /// Valida los inputs relacionados con un profesor.
        /// </summary>
        /// <param name="dictCampos">Diccionario de campos ingresados para el profesor.</param>
        /// <returns>Respuesta de validación indicando el resultado de la validación de los inputs.</returns>
        public RespuestaValidacionInput ValidarInputsProfesor(Dictionary<string, string> dictCampos)
        {
            ValidadorInputGenerico validadorInputProfesores = new ValidadorInputGenerico();
            RespuestaValidacionInput validacionProfesor = validadorInputProfesores.ValidarDatos(dictCampos, ModoValidacionInput.Profesores);

            return validacionProfesor;
        }

        /// <summary>
        /// Gestiona la edición de un profesor en base a la validación de duplicados.
        /// </summary>
        /// <param name="cambioDeCorreo">Indica si se realiza un cambio de correo.</param>
        /// <param name="correo">Nuevo correo electrónico.</param>
        /// <param name="direccion">Nueva dirección.</param>
        /// <param name="especializacion">Nueva especialización.</param>
        /// <param name="nombre">Nuevo nombre.</param>
        /// <param name="telefono">Nuevo teléfono.</param>
        /// <param name="correoOriginal">Correo electrónico original del profesor a editar.</param>
        /// <returns>True si la edición fue exitosa, False si hay duplicados.</returns>
        public async Task<bool> GestionarEdicionProfesorEnBaseADuplicados(bool cambioDeCorreo, string correo, string direccion, string especializacion, string nombre, string telefono, string correoOriginal)
        {
            if (cambioDeCorreo)
            {
                bool validacionDuplicados = ValidarDuplicadosProfesores(correo);

                if (!validacionDuplicados)
                {
                    await EditarProfesor(correo, direccion, especializacion, nombre, telefono, correoOriginal);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                await EditarProfesor(correo, direccion, especializacion, nombre, telefono, correoOriginal);
                return true;
            }
        }

        /// <summary>
        /// Gestiona la adición de un nuevo profesor en base a la validación de duplicados.
        /// </summary>
        /// <param name="profesor">Profesor a agregar.</param>
        /// <returns>True si la adición fue exitosa, False si hay duplicados.</returns>
        public async Task<bool> GestionarAgregarProfesorEnBaseADuplicados(Profesor profesor)
        {
            bool validacionDuplicados = ValidarDuplicadosProfesores(profesor.Correo);

            if (!validacionDuplicados)
            {
                await profesor.Registrar();
            }

            return validacionDuplicados;
        }

        /// <summary>
        /// Gestiona la asignación de un curso a un profesor verificando la validez de la asignación.
        /// </summary>
        /// <param name="correoProfesor">Correo electrónico del profesor.</param>
        /// <param name="codigoCurso">Código del curso a asignar.</param>
        /// <returns>True si la asignación es válida y se realiza, False si no es válida.</returns>
        public async Task<bool> GestionarAsignacionCursoAProfesor(string correoProfesor, string codigoCurso)
        {
            Profesor profesorGestionado = DevolverProfesor(correoProfesor);
            bool resultadoValidacion = validadorAsignacionCursoAProfesor.ValidarAsignacionDeCursoAProfesor(codigoCurso, profesorGestionado);

            if (resultadoValidacion)
            {
                await _consultasProfesores.AgregarCursoAProfesor(correoProfesor, codigoCurso);
            }

            return resultadoValidacion;
        }
    }
}
