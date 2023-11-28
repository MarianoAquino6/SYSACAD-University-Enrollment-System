using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using Libreria_Clases_TP_SYSACAD.Persistencia;

namespace Libreria_Clases_TP_SYSACAD.EntidadesPrimarias
{
    public static class Sistema
    {
        private static Estudiante _estudianteLogueado;
        private static RegistroExcepciones _registroExcepciones;
        private static string _correoEstudianteLogueado;

        //Codigo de acceso que solo los admins poseen
        private static string _codigoDeAccesoAdmins = "ts5bf4";

        /// <summary>
        /// Inicializa el sistema cargando las instancias de cursos, estudiantes, inscripciones, pagos y profesores desde la base de datos. Además, inicializa el registro de excepciones y gestiona las notificaciones.
        /// </summary>
        public static void InicializarSistema()
        {
            ConsultasCursos.CrearInstanciasDeCursoAPartirDeBD();
            ConsultasEstudiantes.CrearInstanciasDeEstudiantesAPartirDeBD();
            ConsultasInscripciones.CrearInstanciasDeInscripcionesAPartirDeBD();
            ConsultasPagos.CrearInstanciasDePagosAPartirDeBD();
            ConsultasProfesores.CrearInstanciasDeProfesoresAPartirDeBD();

            _registroExcepciones = new RegistroExcepciones();

            GestionarNotificaciones();
        }

        /// <summary>
        /// Gestiona el envío de notificaciones según fechas límite y eventos del periodo académico, utilizando un gestor de eventos de notificaciones.
        /// </summary>
        public static async void GestionarNotificaciones()
        {
            GestorEventosNotificaciones gestorNotificaciones = new GestorEventosNotificaciones();
            gestorNotificaciones.InicioPeriodoAcademico += EmisorCorreoElectronico.EnviarCorreoElectronicoNotificacion;
            gestorNotificaciones.FechaLimiteInscripcion += EmisorCorreoElectronico.EnviarCorreoElectronicoNotificacion;
            gestorNotificaciones.FechaLimiteDePago += EmisorCorreoElectronico.EnviarCorreoElectronicoNotificacion;

            DateTime fechaActual = DateTime.Now;

            //DateTime inicioPeriodoAbril = new DateTime(fechaActual.Year, 12, 7, 23, 59, 59);
            DateTime inicioPeriodoAbril = new DateTime(fechaActual.Year, 4, 1, 23, 59, 59);
            DateTime inicioPeriodoSeptiembre = new DateTime(fechaActual.Year, 9, 1, 23, 59, 59);

            //DateTime limiteInscripcionMarzo = new DateTime(fechaActual.Year, 12, 7, 23, 59, 59);
            DateTime limiteInscripcionMarzo = new DateTime(fechaActual.Year, 3, 25, 23, 59, 59);
            DateTime limiteInscripcionAgosto = new DateTime(fechaActual.Year, 8, 25, 23, 59, 59);

            //DateTime limitePagoJunio = new DateTime(fechaActual.Year, 12, 7, 23, 59, 59);
            DateTime limitePagoJunio = new DateTime(fechaActual.Year, 6, 20, 23, 59, 59);
            DateTime limitePagoNoviembre = new DateTime(fechaActual.Year, 11, 20, 23, 59, 59);

            // Verificar si estamos a 10 días de cada fecha y realizar la acción correspondiente
            if ((inicioPeriodoAbril - fechaActual).Days == 10)
            {
                await Task.Run(() => gestorNotificaciones.EjecutarInicioPeriodoAcademico("primer", "1° de Abril"));
            }
            else if ((inicioPeriodoSeptiembre - fechaActual).Days == 10)
            {
                await Task.Run(() => gestorNotificaciones.EjecutarInicioPeriodoAcademico("segundo", "1° de Septiembre"));
            }
            else if((limiteInscripcionMarzo - fechaActual).Days == 10)
            {
                await Task.Run(() => gestorNotificaciones.EjecutarFechaLimiteInscripcion("25 de Marzo"));
            }
            else if((limiteInscripcionAgosto - fechaActual).Days == 10)
            {
                await Task.Run(() => gestorNotificaciones.EjecutarFechaLimiteInscripcion("25 de Agosto"));
            }
            else if((limitePagoJunio - fechaActual).Days == 10)
            {
                await Task.Run(() => gestorNotificaciones.EjecutarFechaLimiteDePago("20 de Junio"));
            }
            else if((limitePagoNoviembre - fechaActual).Days == 10)
            {
                await Task.Run(() => gestorNotificaciones.EjecutarFechaLimiteDePago("20 de Noviembre"));
            }
        }

        /// <summary>
        /// Establece un estudiante como usuario activo en el sistema.
        /// </summary>
        /// <param name="correo">El correo del estudiante que se desea establecer como usuario activo.</param>
        public static void IngresarEstudianteComoUsuarioActivo(string correo)
        {
            foreach (Estudiante estudiante in ConsultasEstudiantes.Estudiantes)
            {
                if (correo == estudiante.Correo)
                {
                    _estudianteLogueado = estudiante;
                }
            }
        }

        //Getters y Setters
        public static Estudiante EstudianteLogueado { get { return _estudianteLogueado; } set { _estudianteLogueado = value; } }

        public static string CorreoEstudianteLogueado { get { return _correoEstudianteLogueado; } set { _correoEstudianteLogueado = value; } }

        public static string CodigoAccesoAdmins { get { return _codigoDeAccesoAdmins; } }
    }
}
