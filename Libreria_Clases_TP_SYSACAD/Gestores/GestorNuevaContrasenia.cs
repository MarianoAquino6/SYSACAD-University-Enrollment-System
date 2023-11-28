using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Gestores
{
    public class GestorNuevaContrasenia
    {
        private readonly ICambioDeContraseña _servicioCambioContraseña;

        // INYECCION DE DEPENDENCIAS:
        // Creo un constructor que reciba una referencia a una clase que implemente la interfaz "ICambioDeContraseña"
        // En este caso será un MOCK (Pero la clase que realmente implementa esta interfaz es ConsultasEstudiantes)
        // Esta interfaz tiene un metodo "CambiarContraseñaAEstudiante" que se localiza en la capa de datos.
        public GestorNuevaContrasenia(ICambioDeContraseña servicioCambioContraseña)
        {
            _servicioCambioContraseña = servicioCambioContraseña;
        }

        // Creo un constructor sin argumentos para poder llamarlo libremente desde el forms
        public GestorNuevaContrasenia()
        {
            _servicioCambioContraseña = new ConsultasEstudiantes();
        }

        /// <summary>
        /// Gestiona el cambio de contraseña para un estudiante.
        /// </summary>
        /// <param name="contrasenia">Nueva contraseña a asignar.</param>
        /// <param name="correo">Correo electrónico del estudiante.</param>
        /// <returns>Mensaje indicando el resultado de la validación y el cambio de contraseña.</returns>
        public async Task<MensajeRespuestaValidacionCredencialesContraseña> GestionarCambioContrasenia(string contrasenia, string correo)
        {
            MensajeRespuestaValidacionCredencialesContraseña mensajeADevolver = ValidadorInputNuevaContrasenia.ValidarNuevaContrasenia(contrasenia);

            if (mensajeADevolver == MensajeRespuestaValidacionCredencialesContraseña.OK)
            {
                // DIRECTAMENTE ACCEDO A LA INSTANCIA QUE IMPLEMENTA LA INTERFAZ 
                await _servicioCambioContraseña.CambiarContraseñaAEstudiante(correo, contrasenia);
            }

            return mensajeADevolver;
        }
    }
}

// LO QUE ESTOY HACIENDO ES CREAR UNA CAPA INTERMEDIA ENTRE LA LOGICA DE NEGOCIO (LAS VALIDACIONES Y EL PROPIO GESTOR)
// Y LA LOGICA DE DATOS (LAS QUERIES DE LA CLASE "ConsultasEstudiantes"). ESTA CAPA ES LA INTERFAZ
// "ICambioDeContraseña". ESTO ME PERMITE LUEGO UTILIZAR UN MOCKING DESDE EL PROYECTO DE MSTEST
// PARA PODER PROBAR LA INTERACCION ENTRE LA LOGICA DE NEGOCIO Y LOGICA DE DATOS, SIN REALMENTE GENERAR
// NINGUN TIPO DE CAMBIO EN LA BASE DE DATOS. :) xdddd
