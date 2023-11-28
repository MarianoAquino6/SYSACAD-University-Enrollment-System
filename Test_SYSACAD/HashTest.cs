using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_Clases_TP_SYSACAD.Herramientas;

namespace Test_SYSACAD
{
    [TestClass]
    public class HashTest
    {
        /// <summary>
        /// Verifica si el método para generar un hash a partir de una contraseña produce un hash válido.
        /// </summary>
        [TestMethod]
        public void HashPassword_DeberiaGenerarUnHashValido()
        {
            // Arrange
            string password = "MiContraseña123";

            // Act
            string hashedPassword = Hash.HashPassword(password);

            // Assert
            Assert.IsNotNull(hashedPassword);
            Assert.AreNotEqual(string.Empty, hashedPassword);
            Assert.AreEqual(64, hashedPassword.Length); // El hash SHA-256 debe tener 64 caracteres en hexadecimal
        }
    }
}
