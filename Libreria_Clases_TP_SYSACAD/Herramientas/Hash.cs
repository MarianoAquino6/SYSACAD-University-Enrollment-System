using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Libreria_Clases_TP_SYSACAD.Persistencia;

namespace Libreria_Clases_TP_SYSACAD.Herramientas
{
    public static class Hash
    {
        /// <summary>
        /// Genera un hash SHA-256 a partir de una contraseña.
        /// </summary>
        /// <param name="password">La contraseña a ser hasheada.</param>
        /// <returns>El hash de la contraseña como una cadena hexadecimal.</returns>
        public static string HashPassword(string password)
        {
            try
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    // Convertir la contraseña en bytes
                    byte[] bytes = Encoding.UTF8.GetBytes(password);

                    // Calcular el hash
                    byte[] hash = sha256.ComputeHash(bytes);

                    // Convertir el hash en una cadena hexadecimal
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int i = 0; i < hash.Length; i++)
                    {
                        stringBuilder.Append(hash[i].ToString("x2"));
                    }

                    return stringBuilder.ToString();
                }
            }
            catch (Exception ex)
            {
                // No freno el programa, sino que registro el tipo de excepcion que se produjo y
                // devuelvo una pass vacia. Que obviamente no esta hasheada porque se produjo un
                // error.

                RegistroExcepciones.RegistrarExcepcion(ex);
                return string.Empty;
            }
        }

        /// <summary>
        /// Verifica si una contraseña coincide con su hash previamente calculado.
        /// </summary>
        /// <param name="password">La contraseña a ser verificada.</param>
        /// <param name="hashedPassword">El hash de la contraseña a ser comparado.</param>
        /// <returns>True si la contraseña coincide con el hash, False si no coincide.</returns>
        internal static bool VerifyPassword(string password, string hashedPassword)
        {
            // Calcular el hash de la contraseña proporcionada
            string hashedInput = HashPassword(password);

            // Comparar los hashes para verificar si coinciden
            return string.Equals(hashedInput, hashedPassword, StringComparison.OrdinalIgnoreCase);
        }
    }
}
