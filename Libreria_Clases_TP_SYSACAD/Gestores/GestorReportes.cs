using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Gestores
{
    public class GestorReportes //CLASE INTERMEDIA ENTRE FORMS Y LAS CONSULTAS/ESTADISTICAS
    {
        private ConsultasInscripciones _consultasInscripciones = new ConsultasInscripciones();
        private ConsultasPagos _consultasPagos = new ConsultasPagos();
        private ConsultasCursos _consultasCursos = new ConsultasCursos();
        private EstadisticasReportes _generadorDeEstadisticas = new EstadisticasReportes();

        /////////////////////////////// METODOS PARA OBTENER LOS REGISTROS ////////////////////////////////

        /// <summary>
        /// Obtiene inscripciones para un curso específico dentro de un período dado.
        /// </summary>
        /// <param name="fechaDesde">Fecha de inicio del período.</param>
        /// <param name="fechaHasta">Fecha de fin del período.</param>
        /// <param name="codigoCurso">Código del curso a consultar.</param>
        /// <returns>Lista de inscripciones para el curso en el período especificado.</returns>
        public List<RegistroDeInscripcion> ObtenerInscripcionesPorCursoPeriodo(DateTime fechaDesde, DateTime fechaHasta, string codigoCurso)
        {
            return _consultasInscripciones.ObtenerInscripciones(fechaDesde, fechaHasta, codigoCurso);
        }

        /// <summary>
        /// Obtiene inscripciones para una carrera específica dentro de un período dado.
        /// </summary>
        /// <param name="fechaDesde">Fecha de inicio del período.</param>
        /// <param name="fechaHasta">Fecha de fin del período.</param>
        /// <param name="carrera">Carrera a consultar.</param>
        /// <returns>Lista de inscripciones para la carrera en el período especificado.</returns>
        public List<RegistroDeInscripcion> ObtenerInscripcionesPorCarreraPeriodo(DateTime fechaDesde, DateTime fechaHasta, Carrera carrera)
        {
            return _consultasInscripciones.ObtenerInscripciones(fechaDesde, fechaHasta, carrera);
        }

        /// <summary>
        /// Obtiene ingresos para un concepto de pago específico dentro de un período dado.
        /// </summary>
        /// <param name="fechaDesde">Fecha de inicio del período.</param>
        /// <param name="fechaHasta">Fecha de fin del período.</param>
        /// <param name="conceptoPago">Concepto de pago a consultar.</param>
        /// <returns>Lista de ingresos para el concepto de pago en el período especificado.</returns>
        public List<RegistroDePago> ObtenerIngresosPorConceptoPeriodo(DateTime fechaDesde, DateTime fechaHasta, string conceptoPago)
        {
            return _consultasPagos.ObtenerIngresosSegunConceptoYFecha(fechaDesde, fechaHasta, conceptoPago);
        }

        /// <summary>
        /// Obtiene todas las inscripciones en un período dado.
        /// </summary>
        /// <param name="fechaDesde">Fecha de inicio del período.</param>
        /// <param name="fechaHasta">Fecha de fin del período.</param>
        /// <returns>Lista de todas las inscripciones en el período especificado.</returns>
        public List<RegistroDeInscripcion> ObtenerInscripcionesTotalesPorPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _consultasInscripciones.ObtenerInscripciones(fechaDesde, fechaHasta);
        }

        /// <summary>
        /// Obtiene un diccionario con cursos y sus listas de espera según un rango de fechas.
        /// </summary>
        /// <param name="fechaDesde">Fecha de inicio del rango.</param>
        /// <param name="fechaHasta">Fecha de fin del rango.</param>
        /// <returns>Diccionario con cursos y listas de espera según las fechas especificadas.</returns>
        public Dictionary<Curso, Dictionary<string, DateTime>> ObtenerCursosConListaDeEsperaSegunFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _consultasCursos.DevolverDiccionarioConRegistrosListaDeEsperaSegunFechas(fechaDesde, fechaHasta);
        }

        /////////////////////////////// METODOS PARA OBTENER LAS ESTADISTICAS ////////////////////////////////

        /// <summary>
        /// Calcula el número total de registros estadísticos.
        /// </summary>
        /// <typeparam name="T">Tipo de registro estadístico.</typeparam>
        /// <param name="listaRegistrosMostrados">Lista de registros a considerar.</param>
        /// <returns>Número total de registros estadísticos.</returns>
        public int CalcularRegistrosTotales<T>(List<T> listaRegistrosMostrados) where T : IRegistroEstadistico
        {
            return _generadorDeEstadisticas.CalcularRegistrosTotales(listaRegistrosMostrados);
        }

        /// <summary>
        /// Calcula el monto total de ingresos a partir de registros de pago.
        /// </summary>
        /// <param name="listaRegistrosMostrados">Lista de registros de pago a considerar.</param>
        /// <returns>Monto total de ingresos.</returns>
        public double CalcularMontoIngresosTotales(List<RegistroDePago> listaRegistrosMostrados)
        {
            return _generadorDeEstadisticas.CalcularMontoIngresosTotales(listaRegistrosMostrados);
        }

        /// <summary>
        /// Calcula la fecha más popular dentro de una lista de registros estadísticos.
        /// </summary>
        /// <typeparam name="T">Tipo de registro estadístico.</typeparam>
        /// <param name="listaRegistrosMostrados">Lista de registros a considerar.</param>
        /// <returns>La fecha más popular dentro de los registros.</returns>
        public DateTime CalcularFechaMasPopular<T>(List<T> listaRegistrosMostrados) where T : IRegistroEstadistico
        {
            return _generadorDeEstadisticas.CalcularFechaMasPopular(listaRegistrosMostrados);
        }

        /// <summary>
        /// Calcula la media por día a partir de registros de inscripción.
        /// </summary>
        /// <param name="listaRegistrosMostrados">Lista de registros de inscripción a considerar.</param>
        /// <returns>La media de registros por día.</returns>
        public double CalcularMediaPorDia(List<RegistroDeInscripcion> listaRegistrosMostrados)
        {
            return _generadorDeEstadisticas.CalcularMediaPorDia(listaRegistrosMostrados);
        }
    }
}
