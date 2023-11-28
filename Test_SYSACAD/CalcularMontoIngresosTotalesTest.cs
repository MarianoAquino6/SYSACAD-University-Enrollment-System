using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SYSACAD
{
    [TestClass]
    public class CalcularMontoIngresosTotalesTest
    {
        /// <summary>
        /// Prueba el cálculo del monto total de ingresos.
        /// </summary>
        [TestMethod]
        public void CalcularMontoIngresosTotales_DeberiaCalcularSumaCorrecta()
        {
            // Arrange
            List<RegistroDePago> listaRegistros = new List<RegistroDePago>
            {
                new RegistroDePago("13232652", "Eduardo", "Matrícula", 10000.0, DateTime.Now),
                new RegistroDePago("15521254", "Pedro", "Gastos Administrativos", 500.0, DateTime.Now),
                new RegistroDePago("00315265", "Charly", "Bibliografia", 400.0, DateTime.Now)
            };
            EstadisticasReportes generadorEstadisticas = new EstadisticasReportes();

            double sumaEsperada = 10000.0 + 500.0 + 400.0;

            // Act
            double resultado = generadorEstadisticas.CalcularMontoIngresosTotales(listaRegistros);

            // Assert
            Assert.AreEqual(sumaEsperada, resultado);
        }
    }
}
