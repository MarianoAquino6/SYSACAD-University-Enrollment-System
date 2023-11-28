using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Validaciones
{
    public class ValidadorCredenciales
    {
        /// <summary>
        /// Valida las credenciales de inicio de sesión y la existencia de campos vacíos.
        /// </summary>
        /// <param name="correo">El correo proporcionado.</param>
        /// <param name="contraseña">La contraseña proporcionada.</param>
        /// <param name="modo">El modo de inicio de sesión (Admin o Estudiante).</param>
        /// <returns>Un mensaje que indica el resultado de la validación.</returns>
        public MensajeRespuestaValidacionCredencialesContraseña ValidarCredenciales(string correo, string contraseña, Log modo)
        {
            MensajeRespuestaValidacionCredencialesContraseña mensajeADevolver;

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña))
            {
                mensajeADevolver = MensajeRespuestaValidacionCredencialesContraseña.camposVacios;
            }
            else
            {
                // Validación de usuario en la base de datos
                if (ValidarUsuarioEnBD(correo, contraseña, modo))
                {
                    mensajeADevolver = MensajeRespuestaValidacionCredencialesContraseña.OK;
                }
                else
                {
                    mensajeADevolver = MensajeRespuestaValidacionCredencialesContraseña.noEncontrado;
                }
            }

            return mensajeADevolver;
        }

        /// <summary>
        /// Valida un usuario en la base de datos según el modo especificado.
        /// </summary>
        /// <param name="correo">El correo proporcionado.</param>
        /// <param name="contraseña">La contraseña proporcionada.</param>
        /// <param name="modo">El modo de inicio de sesión (Admin o Estudiante).</param>
        /// <returns>true si se encuentra el usuario en la base de datos, de lo contrario, false.</returns>
        private static bool ValidarUsuarioEnBD(string correo, string contraseña, Log modo)
        {
            bool resultadoBusquedaUsuario = false;

            if (modo == Log.Admin)
            {
                //resultadoBusquedaUsuario = Sistema.BaseDatosAdministradores.BuscarUsuarioBD(correo, contraseña);
                resultadoBusquedaUsuario = ConsultasAdministradores.BuscarUsuarioBD(correo, contraseña);
            }
            else if (modo == Log.Estudiante)
            {
                //resultadoBusquedaUsuario = Sistema.BaseDatosEstudiantes.BuscarUsuarioCredencialesBD(correo, contraseña);
                resultadoBusquedaUsuario = ConsultasEstudiantes.BuscarUsuarioCredencialesBD(correo, contraseña);
            }

            return resultadoBusquedaUsuario;
        }

        /// <summary>
        /// Valida un código de acceso de administrador.
        /// </summary>
        /// <param name="codigo">El código de acceso proporcionado.</param>
        /// <returns>true si el código coincide con el código de acceso de administradores, de lo contrario, false.</returns>
        public bool ValidarCodigoAccesoAdmins(string codigo)
        {
            if (codigo == Sistema.CodigoAccesoAdmins)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
