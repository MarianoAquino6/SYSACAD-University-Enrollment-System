using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SYSACAD
{
    [TestClass]
    public class FiltrarElementosTest
    {
        /// <summary>
        /// Verifica si el método de filtrado devuelve una lista según el predicado proporcionado.
        /// </summary>
        [TestMethod]
        public void FiltrarElementos_DeberiaFiltrarDevolviendoUnaLista_SegunElPredicado()
        {
            // Arrange
            List<Curso> lista = new List<Curso>
            {
                new Curso("Matematica", "MateM", "asdasd", 120, "Mañana", "120", "Lunes", Carrera.TUP),
                new Curso("Ingenieria", "ASDada", "asdasd", 150, "Noche", "190", "Martes", Carrera.TUSI),
                new Curso("Estadistica", "EstaM", "asdasd", 130, "Mañana", "120", "Jueves", Carrera.TUP)
            };

            string codigo = "MateM";

            //Creo un predicado (Acepta parametros y devuelve BOOL), que toma como parametro "Curso" y devuelve
            //un booleano. Uso un lambda para crear el cuerpo del metodo predicate:
            //Basicamente, toma como argumento un curso (De la class "Curso"), y comprueba si el codigo
            //del mismo es igual a un codigo determinado.
            // SINTAXIS LAMBDA:
            //DELEGADO<ARGUMENTO> NombreVariable = InstanciaDelArgumento => Cuerpo del metodo
            Predicate<Curso> predicado = curso => curso.Codigo == codigo;

            // Act
            List<Curso> elementosFiltrados = ConsultasGenericas.FiltrarElementos(lista, predicado);

            // Assert
            Assert.IsNotNull(elementosFiltrados);
            CollectionAssert.Contains(elementosFiltrados, lista[0]);
            CollectionAssert.DoesNotContain(elementosFiltrados, lista[1]);
            CollectionAssert.DoesNotContain(elementosFiltrados, lista[2]);
        }
    }
}
