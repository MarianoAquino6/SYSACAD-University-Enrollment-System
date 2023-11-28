using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Validaciones
{
    public class ValidadorInputNuevaContrasenia : ValidadorInputs
    {
        /// <summary>
        /// Valida la fortaleza de una nueva contraseña según ciertos criterios.
        /// </summary>
        /// <param name="contrasenia">Contraseña a validar.</param>
        /// <returns>Respuesta que indica la validez de la contraseña.</returns>
        public static MensajeRespuestaValidacionCredencialesContraseña ValidarNuevaContrasenia(string contrasenia)
        {
            MensajeRespuestaValidacionCredencialesContraseña mensajeADevolver;

            //Valido si no hay campos vacios. Si todo esta bien devuelve true
            bool resultadoCamposVacios = ValidarCampos(contrasenia);

            //Valido si hay campos vacios y si el regex esta bien
            if (!resultadoCamposVacios)
            {
                mensajeADevolver = MensajeRespuestaValidacionCredencialesContraseña.camposVacios;
            }
            else
            {
                if (!Regex.IsMatch(contrasenia, @"^[a-zA-Z0-9]{6,}$"))
                {
                    mensajeADevolver = MensajeRespuestaValidacionCredencialesContraseña.ERROR;
                }
                else
                {

                    mensajeADevolver = MensajeRespuestaValidacionCredencialesContraseña.OK;
                }
            }

            return mensajeADevolver;
        }
    }
}

// LO QUE ESTOY HACIENDO ES CREAR UNA CAPA INTERMEDIA ENTRE LA LOGICA DE NEGOCIO (LAS VALIDACIONES DE LA CLASE
// "ValidadorInputNuevaContrasenia") Y LA LOGICA DE DATOS (LAS QUERIES DE LA CLASE "ConsultasEstudiantes"). ESTA
// CAPA ES LA INTERFAZ "ICambioDeContraseña". ESTO ME PERMITE LUEGO UTILIZAR UN MOCKING DESDE EL PROYECTO DE MSTEST
// PARA PODER PROBAR LA INTERACCION ENTRE LA LOGICA DE NEGOCIO Y LOGICA DE DATOS, SIN REALMENTE GENERAR NINGUN TIPO
// DE CAMBIO EN LA BASE DE DATOS. :) xdddd
