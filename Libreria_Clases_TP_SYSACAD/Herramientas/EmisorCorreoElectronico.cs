using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;

namespace Libreria_Clases_TP_SYSACAD.Herramientas
{
    public class EmisorCorreoElectronico
    {
        /// <summary>
        /// Envía un correo electrónico con las credenciales de inicio de sesión a un estudiante específico.
        /// </summary>
        /// <param name="estudianteReceptor">Estudiante que recibirá el correo.</param>
        /// <param name="contrasenia">Contraseña para el inicio de sesión.</param>
        /// <returns>Booleano que indica si el correo se envió correctamente.</returns>
        public static async Task<bool> EnviarCorreoElectronicoCredenciales(Estudiante estudianteReceptor, string contrasenia)
        {
            try
            {
                // Configura las credenciales y detalles del servidor SMTP
                string servidorSmtp = "smtp-mail.outlook.com"; // Reemplaza con tu servidor SMTP
                int puertoSmtp = 587; // Reemplaza con el puerto correcto de tu servidor SMTP
                string usuarioSmtp = "tp_sysacad_m6@outlook.com"; // Reemplaza con tu dirección de correo
                string contraseñaSmtp = "Sysacad661"; // Reemplaza con tu contraseña de correo

                // Crea una instancia de la clase SmtpClient
                SmtpClient clienteSmtp = new SmtpClient(servidorSmtp, puertoSmtp);

                // Configura las credenciales
                clienteSmtp.Credentials = new NetworkCredential(usuarioSmtp, contraseñaSmtp);

                // Habilita SSL si es necesario (por ejemplo, para Gmail)
                clienteSmtp.EnableSsl = true;

                await Task.Run(() =>
                {
                    // Crea un objeto MailMessage
                    MailMessage mensaje = new MailMessage(usuarioSmtp, estudianteReceptor.Correo);

                    // Asigna el asunto y el cuerpo del correo
                    mensaje.Subject = "SYSACAD - Credenciales de Inicio de Sesion";
                    mensaje.Body = "Hola " + estudianteReceptor.Nombre + ", a continuacion sus credenciales de inicio: \n" +
                        $"Correo: {estudianteReceptor.Correo} \n" +
                        $"Contraseña: {contrasenia}";

                    // Envía el correo
                    clienteSmtp.Send(mensaje);

                    // Limpia recursos
                    mensaje.Dispose();
                });

                return true;
            }
            catch (SmtpException smtpEx)
            {
                // El programa no se detiene, sino que devuelve false al form
                // para que mostrar el error mediante un messageBox. Se registra
                // la excepcion en el JSON
                RegistroExcepciones.RegistrarExcepcion(smtpEx);
                return false;
            }
            catch (Exception e)
            {
                RegistroExcepciones.RegistrarExcepcion(e);
                return false;
            }
        }


        /// <summary>
        /// Envía un correo electrónico de notificación a todos los estudiantes registrados.
        /// </summary>
        /// <param name="EmisorCorreoElectronico">Emisor del correo electrónico.</param>
        /// <param name="infoMail">Información del correo electrónico (asunto y cuerpo).</param>
        internal static void EnviarCorreoElectronicoNotificacion(object EmisorCorreoElectronico, ElementosCorreoElectronicoArgs infoMail)
        {
            List<string> correosEstudiantes = ConsultasEstudiantes.ObtenerListaDeCorreosEstudiantes();

            foreach (string correo in correosEstudiantes)
            {
                try
                {
                    // Configura las credenciales y detalles del servidor SMTP
                    string servidorSmtp = "smtp-mail.outlook.com"; // Reemplaza con tu servidor SMTP
                    int puertoSmtp = 587; // Reemplaza con el puerto correcto de tu servidor SMTP
                    string usuarioSmtp = "tp_sysacad_m6@outlook.com"; // Reemplaza con tu dirección de correo
                    string contraseñaSmtp = "Sysacad661"; // Reemplaza con tu contraseña de correo

                    // Crea una instancia de la clase SmtpClient
                    SmtpClient clienteSmtp = new SmtpClient(servidorSmtp, puertoSmtp);

                    // Configura las credenciales
                    clienteSmtp.Credentials = new NetworkCredential(usuarioSmtp, contraseñaSmtp);

                    // Habilita SSL si es necesario (por ejemplo, para Gmail)
                    clienteSmtp.EnableSsl = true;

                    // Crea un objeto MailMessage
                    MailMessage mensaje = new MailMessage(usuarioSmtp, correo);

                    // Asigna el asunto y el cuerpo del correo
                    mensaje.Subject = infoMail.Asunto;
                    mensaje.Body = infoMail.Cuerpo;

                    // Envía el correo
                    clienteSmtp.Send(mensaje);

                    // Limpia recursos
                    mensaje.Dispose();
                }
                catch (SmtpException smtpEx)
                {
                    // El programa no se detiene, sino que devuelve false al form
                    // para que mostrar el error mediante un messageBox. Se registra
                    // la excepcion en el JSON
                    RegistroExcepciones.RegistrarExcepcion(smtpEx);
                }
            }
        }
    }
}
