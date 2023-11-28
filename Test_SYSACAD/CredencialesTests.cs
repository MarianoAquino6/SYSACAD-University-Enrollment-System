using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SYSACAD
{
    [TestClass]
    public class CredencialesTests
    {
        /// <summary>
        /// Verifica que el método ValidarCredenciales de la clase ValidadorCredenciales
        /// devuelva MensajeRespuestaValidacionCredencialesContraseña.camposVacios
        /// cuando se le proporcionan campos de correo y contraseña vacíos.
        /// </summary>
        [TestMethod]
        public void ValidarCredenciales_DeberiaDevolverCamposVacios_CuandoCamposEstanVacios()
        {
            // Arrange
            ValidadorCredenciales validador = new ValidadorCredenciales();
            string correo = string.Empty;
            string contraseña = string.Empty;
            Log modo = Log.Admin;

            // Act
            MensajeRespuestaValidacionCredencialesContraseña resultado = validador.ValidarCredenciales(correo, contraseña, modo);

            // Assert
            Assert.AreEqual(MensajeRespuestaValidacionCredencialesContraseña.camposVacios, resultado);
        }

        /// <summary>
        /// Verifica que el método ValidarCredenciales de la clase ValidadorCredenciales
        /// devuelva MensajeRespuestaValidacionCredencialesContraseña.OK
        /// cuando se le proporcionan credenciales válidas.
        /// </summary>
        [TestMethod]
        public void ValidarCredenciales_DeberiaDevolverOK_CuandoCredencialesSonValidas()
        {
            // Arrange
            ValidadorCredenciales validador = new ValidadorCredenciales();
            string correo = "johntravolta@hotmail.com";
            string contraseña = "666666";
            Log modo = Log.Admin;

            // Act
            MensajeRespuestaValidacionCredencialesContraseña resultado = validador.ValidarCredenciales(correo, contraseña, modo);

            // Assert
            Assert.AreEqual(MensajeRespuestaValidacionCredencialesContraseña.OK, resultado);
        }

        /// <summary>
        /// Verifica si la validación de credenciales devuelve "no encontrado" cuando las credenciales no son válidas.
        /// </summary>
        [TestMethod]
        public void ValidarCredenciales_DeberiaDevolverNoEncontrado_CuandoCredencialesNoSonValidas()
        {
            // Arrange
            ValidadorCredenciales validador = new ValidadorCredenciales();
            string correo = "rickyfort@gmail.com";
            string contraseña = "vamobooocaaaaaa";
            Log modo = Log.Admin;

            // Act
            MensajeRespuestaValidacionCredencialesContraseña resultado = validador.ValidarCredenciales(correo, contraseña, modo);

            // Assert
            Assert.AreEqual(MensajeRespuestaValidacionCredencialesContraseña.noEncontrado, resultado);
        }
    }
}
