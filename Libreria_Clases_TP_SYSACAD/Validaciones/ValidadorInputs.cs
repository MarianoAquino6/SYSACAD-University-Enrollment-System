using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Validaciones
{
    public abstract class ValidadorInputs
    {
        /// <summary>
        /// Valida si todos los campos en una lista tienen valores no nulos ni vacíos.
        /// </summary>
        /// <param name="campos">Lista de campos a validar.</param>
        /// <returns>Devuelve verdadero si todos los campos no están vacíos o nulos, de lo contrario, falso.</returns>
        protected static bool ValidarCampos(List<string> campos)
        {
            bool resultado = true;

            foreach (var campo in campos)
            {
                if (string.IsNullOrWhiteSpace(campo))
                {
                    resultado = false;
                    break;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Valida si la contraseña proporcionada no está vacía ni nula.
        /// </summary>
        /// <param name="contrasenia">Contraseña a validar.</param>
        /// <returns>Devuelve verdadero si la contraseña no está vacía o nula, de lo contrario, falso.</returns>
        protected static bool ValidarCampos(string contrasenia)
        {
            bool resultado = true;

            if (string.IsNullOrWhiteSpace(contrasenia))
            {
                resultado = false;
            }

            return resultado;
        }

        /// <summary>
        /// Realiza la validación de expresiones regulares para un diccionario de campos ingresados.
        /// </summary>
        /// <param name="diccionarioConCamposIngresados">Diccionario de campos a validar.</param>
        /// <returns>Devuelve una lista de errores encontrados al validar las expresiones regulares.</returns>
        protected virtual List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados)
        {
            List<string> errores = new List<string>();
            return errores;
        }

        //Sobrecarga del metodo para aplicar polimorfismo 

        /// <summary>
        /// Realiza la validación de expresiones regulares para un diccionario de campos ingresados en función de un modo específico.
        /// </summary>
        /// <param name="diccionarioConCamposIngresados">Diccionario de campos a validar.</param>
        /// <param name="modo">Modo de validación específico.</param>
        /// <returns>Devuelve una lista de errores encontrados al validar las expresiones regulares.</returns>
        /// <remarks>
        /// Esta es una sobrecarga del método para aplicar polimorfismo y permitir validaciones específicas según el modo proporcionado.
        /// </remarks>
        protected virtual List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados, ModoValidacionInput modo)
        {
            List<string> errores = new List<string>();
            return errores;
        }

        /// <summary>
        /// Verifica si existen errores en la lista proporcionada.
        /// </summary>
        /// <param name="listaDeErrores">Lista de errores a comprobar.</param>
        /// <returns>Devuelve verdadero si la lista contiene algún error, de lo contrario, falso.</returns>
        protected static bool ComprobarExistenciaErrores(List<string> listaDeErrores)
        {
            return listaDeErrores.Count > 0;
        }

        /// <summary>
        /// Obtiene una lista de campos desde un diccionario de campos.
        /// </summary>
        /// <param name="diccionarioConCampos">Diccionario de campos del cual se extraerán los valores.</param>
        /// <returns>Devuelve una lista de los valores contenidos en el diccionario.</returns>
        protected static List<string> ObtenerListaDeCamposDesdeDiccionario(Dictionary<string, string> diccionarioConCampos)
        {
            return new List<string>(diccionarioConCampos.Values);
        }

        /// <summary>
        /// Valida si un campo especificado es alfanumérico (letras y números) permitiendo espacios en blanco.
        /// </summary>
        /// <param name="campo">Campo a validar.</param>
        /// <param name="diccionario">Diccionario que contiene el campo a validar.</param>
        /// <param name="errores">Lista de errores donde se agregará un error si la validación falla.</param>
        /// <param name="mensajeError">Mensaje de error a agregar si la validación falla.</param>
        protected void ValidarAlfanumerico(string campo, Dictionary<string, string> diccionario, List<string> errores, string mensajeError)
        {
            // Valida que el campo sea alfanumérico (letras y números) con espacios en blanco permitidos.
            if (!Regex.IsMatch(diccionario[campo], @"^[a-zA-Z0-9\s]+$"))
            {
                errores.Add(mensajeError);
            }
        }

        /// <summary>
        /// Valida si un campo especificado contiene un número exacto de dígitos.
        /// </summary>
        /// <param name="campo">Campo a validar.</param>
        /// <param name="diccionario">Diccionario que contiene el campo a validar.</param>
        /// <param name="longitud">Longitud exacta que debe tener el campo.</param>
        /// <param name="errores">Lista de errores donde se agregará un error si la validación falla.</param>
        /// <param name="mensajeError">Mensaje de error a agregar si la validación falla.</param>
        protected void ValidarNumeroExacto(string campo, Dictionary<string, string> diccionario, int longitud, List<string> errores, string mensajeError)
        {
            // Valida que el campo contenga un número exacto de dígitos especificado por 'longitud'.
            if (!Regex.IsMatch(diccionario[campo], $@"^\d{{{longitud}}}$"))
            {
                errores.Add(mensajeError);
            }
        }

        /// <summary>
        /// Valida si el campo especificado es un número entero entre 0 y 10 o un número decimal con coma y un solo dígito decimal.
        /// </summary>
        /// <param name="campo">Campo a validar.</param>
        /// <param name="diccionario">Diccionario que contiene el campo a validar.</param>
        /// <param name="maxValor">Valor máximo permitido.</param>
        /// <param name="errores">Lista de errores donde se agregará un error si la validación falla.</param>
        /// <param name="mensajeError">Mensaje de error a agregar si la validación falla.</param>
        protected void ValidarNumeroConDecimal(string campo, Dictionary<string, string> diccionario, double maxValor, List<string> errores, string mensajeError)
        {
            // Valida que el campo sea un número entero del 0 al 10 o un número decimal con coma y un solo decimal después de la coma.
            if (!Regex.IsMatch(diccionario[campo], @"^(10|[0-9](,\d)?)$"))
            {
                errores.Add(mensajeError);
            }
        }

        /// <summary>
        /// Valida si el campo especificado contiene solo números.
        /// </summary>
        /// <param name="campo">Campo a validar.</param>
        /// <param name="diccionario">Diccionario que contiene el campo a validar.</param>
        /// <param name="errores">Lista de errores donde se agregará un error si la validación falla.</param>
        /// <param name="mensajeError">Mensaje de error a agregar si la validación falla.</param>
        protected void ValidarNumerico(string campo, Dictionary<string, string> diccionario, List<string> errores, string mensajeError)
        {
            // Valida que el campo contenga solo números.
            if (!Regex.IsMatch(diccionario[campo], @"^[0-9]+$"))
            {
                errores.Add(mensajeError);
            }
        }

        /// <summary>
        /// Valida si el campo especificado tiene un formato de correo electrónico válido.
        /// </summary>
        /// <param name="campo">Campo a validar.</param>
        /// <param name="diccionario">Diccionario que contiene el campo a validar.</param>
        /// <param name="errores">Lista de errores donde se agregará un error si la validación falla.</param>
        /// <param name="mensajeError">Mensaje de error a agregar si la validación falla.</param>
        protected void ValidarCorreo(string campo, Dictionary<string, string> diccionario, List<string> errores, string mensajeError)
        {
            // Valida que el campo tenga un formato de correo electrónico válido.
            if (!Regex.IsMatch(diccionario[campo], @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                errores.Add(mensajeError);
            }
        }

        /// <summary>
        /// Valida si el campo especificado contiene un número dentro de un rango específico de longitud.
        /// </summary>
        /// <param name="campo">Campo a validar.</param>
        /// <param name="diccionario">Diccionario que contiene el campo a validar.</param>
        /// <param name="minLongitud">Longitud mínima permitida.</param>
        /// <param name="maxLongitud">Longitud máxima permitida.</param>
        /// <param name="errores">Lista de errores donde se agregará un error si la validación falla.</param>
        /// <param name="mensajeError">Mensaje de error a agregar si la validación falla.</param>
        protected void ValidarNumeroRango(string campo, Dictionary<string, string> diccionario, int minLongitud, int maxLongitud, List<string> errores, string mensajeError)
        {
            // Valida que el campo contenga un número en un rango específico de longitud.
            if (!Regex.IsMatch(diccionario[campo], $@"^\d{{{minLongitud},{maxLongitud}}}$"))
            {
                errores.Add(mensajeError);
            }
        }

        /// <summary>
        /// Valida si el campo especificado tiene una longitud mínima especificada.
        /// </summary>
        /// <param name="campo">Campo a validar.</param>
        /// <param name="diccionario">Diccionario que contiene el campo a validar.</param>
        /// <param name="minLongitud">Longitud mínima requerida.</param>
        /// <param name="errores">Lista de errores donde se agregará un error si la validación falla.</param>
        /// <param name="mensajeError">Mensaje de error a agregar si la validación falla.</param>
        protected void ValidarMinLongitud(string campo, Dictionary<string, string> diccionario, int minLongitud, List<string> errores, string mensajeError)
        {
            // Valida que el campo tenga al menos una longitud mínima especificada.
            if (!Regex.IsMatch(diccionario[campo], $@"^[a-zA-Z0-9]{{{minLongitud},}}$"))
            {
                errores.Add(mensajeError);
            }
        }


        /// <summary>
        /// Valida si el campo especificado tiene un formato de fecha MM/YY válido.
        /// </summary>
        /// <param name="campo">Campo a validar.</param>
        /// <param name="diccionario">Diccionario que contiene el campo a validar.</param>
        /// <param name="errores">Lista de errores donde se agregará un error si la validación falla.</param>
        /// <param name="mensajeError">Mensaje de error a agregar si la validación falla.</param>
        protected void ValidarFormatoFecha(string campo, Dictionary<string, string> diccionario, List<string> errores, string mensajeError)
        {
            // Valida que el campo tenga un formato de fecha MM/YY válido.
            if (!Regex.IsMatch(diccionario[campo], @"^(0[1-9]|1[0-2])/\d{2}$"))
            {
                errores.Add(mensajeError);
            }
        }
    }
}
