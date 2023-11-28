using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Gestores
{
    public class GestorEstudiantes
    {
        private ConsultasEstudiantes _consultasEstudiantes = new ConsultasEstudiantes();

        /// <summary>
        /// Verifica si un usuario, identificado por su correo, debe cambiar su contraseña.
        /// </summary>
        /// <param name="correo">Correo electrónico del usuario.</param>
        /// <returns><c>true</c> si el usuario debe cambiar la contraseña; de lo contrario, <c>false</c>.</returns>
        public bool BuscarSiUsuarioDebeCambiarContrasenia(string correo)
        {
            return _consultasEstudiantes.BuscarSiUsuarioDebeCambiarContrasenia(correo);
        }

        /// <summary>
        /// Obtiene los datos de un estudiante basado en su número de legajo.
        /// </summary>
        /// <param name="legajo">Número de legajo del estudiante.</param>
        /// <returns>Información del estudiante correspondiente al legajo.</returns>
        public Estudiante ObtenerEstudianteSegunLegajo(string legajo)
        {
            return _consultasEstudiantes.ObtenerEstudianteSegunLegajo(legajo);
        }

        /// <summary>
        /// Verifica si existen duplicados de estudiantes en la base de datos, utilizando el número de legajo y el correo.
        /// </summary>
        /// <param name="legajo">Número de legajo del estudiante.</param>
        /// <param name="correo">Correo electrónico del estudiante.</param>
        /// <returns><c>true</c> si existe un estudiante con el mismo número de legajo y correo; de lo contrario, <c>false</c>.</returns>
        public bool ValidarDuplicadosEstudiantes(string legajo, string correo)
        {
            return ConsultasEstudiantes.BuscarUsuarioExistenteBD(correo, legajo);
        }

        /// <summary>
        /// Envía un correo electrónico con las credenciales al estudiante especificado.
        /// </summary>
        /// <param name="estudiante">Estudiante al que se enviarán las credenciales.</param>
        /// <param name="contrasenia">Contraseña del estudiante.</param>
        /// <returns><c>true</c> si se envió correctamente el correo; de lo contrario, <c>false</c>.</returns>
        public async Task<bool> EnviarCorreoElectronicoAEstudiante(Estudiante estudiante, string contrasenia)
        {
            bool resultadoEmisionCorreo = await EmisorCorreoElectronico.EnviarCorreoElectronicoCredenciales(estudiante, contrasenia);
            return resultadoEmisionCorreo;
        }

        ///////////////////////////////GESTION///////////////////////////////////////

        /// <summary>
        /// Valida los campos de entrada para el registro de estudiantes.
        /// </summary>
        /// <param name="dictCampos">Diccionario de campos a validar.</param>
        /// <returns>Resultado de la validación de los campos de entrada.</returns>
        public RespuestaValidacionInput ValidarInputsEstudiantes(Dictionary<string, string> dictCampos)
        {
            ValidadorInputGenerico validadorInputEstudiantes = new ValidadorInputGenerico();
            RespuestaValidacionInput validacionEstudiantes = validadorInputEstudiantes.ValidarDatos(dictCampos, ModoValidacionInput.Estudiantes);

            return validacionEstudiantes;
        }

        /// <summary>
        /// Gestiona el registro de un estudiante en la base de datos, verificando duplicados previamente.
        /// </summary>
        /// <param name="estudiante">Estudiante a registrar.</param>
        /// <returns><c>true</c> si el estudiante se registró con éxito o ya existe; de lo contrario, <c>false</c>.</returns>
        public async Task<bool> GestionarRegistrarEstudianteEnBaseADuplicados(Estudiante estudiante)
        {
            bool validacionDuplicados = ValidarDuplicadosEstudiantes(estudiante.Legajo, estudiante.Correo);

            if (!validacionDuplicados)
            {
                await estudiante.Registrar();
            }

            return validacionDuplicados;
        }


    }
}
