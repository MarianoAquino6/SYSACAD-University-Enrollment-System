using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Libreria_Clases_TP_SYSACAD.Gestores;

namespace Test_SYSACAD
{
    [TestClass]
    public class CambioNuevaContraseniaTests
    {
        /// <summary>
        /// Prueba la lógica de cambio de contraseña cuando se proporciona una contraseña válida.
        /// </summary>
        [TestMethod]
        public async Task ValidadorInputNuevaContrasenia_CuandoContraseñaValida_CambiaContraseña()
        {
            // Arrange
            // Acá implemento un MOCK de una class que implementa la interfaz (Simulo la class ConsultasEstudiantes)
            var mockServicioCambioContraseña = new Mock<ICambioDeContraseña>();
            // Le paso este ConsultasEstudiantes FAKE al constructor del gestor (LOGICA DE NEGOCIO)
            var gestorValidadorContrasenia = new GestorNuevaContrasenia(mockServicioCambioContraseña.Object);

            // Act
            // Le paso los argumentos VALIDOS al metodo de gestion de nueva contraseña
            await gestorValidadorContrasenia.GestionarCambioContrasenia("asd125a", "correo@asd.com");

            // Assert
            // Me fijo si se llamo al metodo "CambiarContraseñaAEstudiante"
            // Como le pase argumentos VALIDOS al validador, se deberia de llamar a este metodo
            mockServicioCambioContraseña.Verify(
                s => s.CambiarContraseñaAEstudiante(It.IsAny<string>(), It.IsAny<string>()),
                Times.Once
            );
        }
        /// <summary>
        /// Prueba la lógica de cambio de contraseña cuando se proporciona una contraseña inválida.
        /// </summary>
        [TestMethod]
        public async Task ValidadorInputNuevaContrasenia_CuandoContraseñaInvalida_NoCambiaContraseña()
        {
            // Arrange
            // Acá implemento un MOCK de una class que implementa la interfaz (Simulo la class ConsultasEstudiantes)
            var mockServicioCambioContraseña = new Mock<ICambioDeContraseña>();
            // Le paso este ConsultasEstudiantes FAKE al constructor del gestor (LOGICA DE NEGOCIO)
            var gestorValidadorContrasenia = new GestorNuevaContrasenia(mockServicioCambioContraseña.Object);

            // Act
            // Le paso los argumentos INVALIDOS al metodo de gestion de nueva contraseña
            await gestorValidadorContrasenia.GestionarCambioContrasenia("aa", "correo@asd.com");

            // Assert
            // Me fijo si se llamo al metodo "CambiarContraseñaAEstudiante"
            // Como le pase argumentos INVALIDOS al validador, NO se deberia de llamar a este metodo
            mockServicioCambioContraseña.Verify(
                s => s.CambiarContraseñaAEstudiante(It.IsAny<string>(), It.IsAny<string>()),
                Times.Never
            );
        }
    }
}
