using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.EntidadesSecundarias
{
    public class EstadisticasReportes
    {
        /// <summary>
        /// Calcula el número total de registros mostrados en una lista dada.
        /// </summary>
        /// <typeparam name="T">Tipo de registro.</typeparam>
        /// <param name="listaRegistrosMostrados">Lista de registros a evaluar.</param>
        /// <returns>Número total de registros mostrados.</returns>
        public int CalcularRegistrosTotales<T>(List<T> listaRegistrosMostrados) 
            where T : IRegistroEstadistico
        {
            return listaRegistrosMostrados.Count;
        }

        /// <summary>
        /// Calcula el monto total de ingresos a partir de una lista de registros de pago.
        /// </summary>
        /// <param name="listaRegistrosMostrados">Lista de registros de pago a evaluar.</param>
        /// <returns>Monto total de ingresos.</returns>
        public double CalcularMontoIngresosTotales(List<RegistroDePago> listaRegistrosMostrados)
        {
            double ingresosTotales = 0;

            foreach (RegistroDePago registro in listaRegistrosMostrados)
            {
                ingresosTotales += registro.Ingreso;
            }

            return ingresosTotales;
        }

        /// <summary>
        /// Calcula la fecha más popular dentro de una lista de registros estadísticos.
        /// </summary>
        /// <typeparam name="T">Tipo de registro estadístico.</typeparam>
        /// <param name="listaRegistrosMostrados">Lista de registros a evaluar.</param>
        /// <returns>Fecha más popular.</returns>
        public DateTime CalcularFechaMasPopular<T>(List<T> listaRegistrosMostrados) 
            where T : IRegistroEstadistico
        {
            // Creamos un diccionario para contar cuántas veces ocurre cada fecha
            Dictionary<DateTime, int> conteoFechas = new Dictionary<DateTime, int>();

            foreach (T registro in listaRegistrosMostrados)
            {
                // Obtenemos la fecha del registro iterado
                DateTime fecha = registro.Fecha.Date;

                // Verificamos si la fecha ya existe en el diccionario
                if (conteoFechas.ContainsKey(fecha))
                {
                    // Si existe, le aumentamos el conteo
                    conteoFechas[fecha]++;
                }
                else
                {
                    // Si no existe, le inicializamos el conteo en 1
                    conteoFechas[fecha] = 1;
                }
            }

            // Inicializamos variables para rastrear la fecha más popular y el conteo más alto
            DateTime fechaPopular = DateTime.MinValue;
            int maxConteo = 0;

            // Iteramos a través del diccionario para encontrar la fecha más popular
            foreach (var kvp in conteoFechas)
            {
                if (kvp.Value > maxConteo)
                {
                    // Si encontramos un conteo más alto, actualizamos la fecha y el conteo más altos
                    fechaPopular = kvp.Key;
                    maxConteo = kvp.Value;
                }
            }

            return fechaPopular;
        }

        /// <summary>
        /// Calcula la media de inscripciones por día a partir de una lista de registros de inscripción.
        /// </summary>
        /// <param name="listaRegistrosMostrados">Lista de registros de inscripción a evaluar.</param>
        /// <returns>Media de inscripciones por día.</returns>
        public double CalcularMediaPorDia(List<RegistroDeInscripcion> listaRegistrosMostrados)
        {
            // Crear un diccionario para contar las inscripciones por día
            Dictionary<DateTime, int> inscripcionesPorDia = new Dictionary<DateTime, int>();

            // Recorrer la lista de registros y contar las inscripciones por día
            foreach (RegistroDeInscripcion registro in listaRegistrosMostrados)
            {
                DateTime fechaInscripcion = registro.Fecha.Date; // Ignorar la hora

                if (inscripcionesPorDia.ContainsKey(fechaInscripcion))
                {
                    inscripcionesPorDia[fechaInscripcion]++;
                }
                else
                {
                    inscripcionesPorDia[fechaInscripcion] = 1;
                }
            }

            // Calcular la cantidad total de inscripciones y la cantidad de días
            int totalInscripciones = inscripcionesPorDia.Values.Sum();
            int totalDias = inscripcionesPorDia.Count;

            // Calcular la media
            double mediaPorDia = totalInscripciones / (double)totalDias;

            return mediaPorDia;
        }
    }
}
