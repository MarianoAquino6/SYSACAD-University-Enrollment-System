using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConsultasPagos : ConexionBD
    {
        private static List<RegistroDePago> _listaRegistrosPagos = new List<RegistroDePago>();

        ///////////////////RECONSTRUCCION DE LA LISTA DE PAGOS A PARTIR DE BD

        /// <summary>
        /// Crea instancias de pagos a partir de los datos recuperados de la base de datos.
        /// </summary>
        internal static void CrearInstanciasDePagosAPartirDeBD()
        {
            _listaRegistrosPagos.Clear();
            _listaRegistrosPagos = CargaDeInstanciasDesdeBD.CrearInstanciasDePagosAPartirDeBD();
        }

        //////////////////////CREATE

        /// <summary>
        /// Ingresa nuevos registros de pago en la base de datos.
        /// </summary>
        /// <param name="nuevosPagos">Lista de nuevos registros de pago a ingresar.</param>
        /// <returns>Tarea asincrónica que ingresa los nuevos registros de pago y actualiza las instancias desde la base de datos.</returns>
        public static async Task IngresarNuevoPago(List<RegistroDePago> nuevosPagos)
        {
            foreach (RegistroDePago registro in nuevosPagos)
            {
                string query = "INSERT INTO RegistroDePago (legajoEstudiante, conceptoNombre, ingreso, fechaPago) " +
                       "VALUES (@legajoEstudiante, @conceptoNombre, @ingreso, @fechaPago)";

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@legajoEstudiante", registro.Legajo },
                    { "@conceptoNombre", registro.Concepto },
                    { "@ingreso", registro.Ingreso },
                    { "@fechaPago", DateTime.Now }
                };

                await ConsultasGenericas.EjecutarNonQuery(query, parametros);
            }

            CrearInstanciasDePagosAPartirDeBD();
        }

        //////////////////////READ

        /// <summary>
        /// Obtiene una lista de ingresos según un concepto y un rango de fechas específico.
        /// </summary>
        /// <param name="fechaDesde">Fecha de inicio del período.</param>
        /// <param name="fechaHasta">Fecha de fin del período.</param>
        /// <param name="concepto">Concepto de pago para filtrar los ingresos.</param>
        /// <returns>Una lista de ingresos que coinciden con el concepto y el rango de fechas especificados.</returns>
        public List<RegistroDePago> ObtenerIngresosSegunConceptoYFecha(DateTime fechaDesde, DateTime fechaHasta, string concepto)
        {
            List<RegistroDePago> listaIngresosSegunConceptoYFecha = new List<RegistroDePago>();

            foreach (RegistroDePago registro in _listaRegistrosPagos)
            {
                if (registro.Fecha >= fechaDesde && registro.Fecha <= fechaHasta && registro.Concepto == concepto)
                {
                    listaIngresosSegunConceptoYFecha.Add(registro);
                }
            }

            return listaIngresosSegunConceptoYFecha;
        }

        /////////////////////UPDATE

        /// <summary>
        /// Actualiza los conceptos de pago de un estudiante en la base de datos según los montos pagados.
        /// </summary>
        /// <param name="listaConceptosPagados">Diccionario de conceptos y montos pagados.</param>
        /// <param name="legajo">Legajo del estudiante cuyos conceptos se actualizan.</param>
        /// <returns>Tarea asincrónica que actualiza los conceptos de pago y refresca la información del estudiante logueado.</returns>
        public static async Task ActualizarConceptosDePagoDeEstudiante(Dictionary<string, double> listaConceptosPagados, string legajo)
        {
            foreach (var parKeyValue in listaConceptosPagados)
            {
                string query = "UPDATE ConceptosDePagoDeEstudiante SET montoPendiente = montoPendiente - @montoPagado " +
                       "WHERE legajoEstudiante = @legajo and conceptoNombre = @conceptoPago";

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@montoPagado", parKeyValue.Value },
                    { "@legajo", legajo },
                    { "@conceptoPago", parKeyValue.Key }
                };

                await ConsultasGenericas.EjecutarNonQuery(query, parametros);
            }

            RefrescarEstudianteLogueado();
        }

        ///////// REFRESCAR ESTUDIANTE LOGUEADO

        /// <summary>
        /// Refresca la información del estudiante logueado actualizando las instancias desde la base de datos.
        /// </summary>
        private static void RefrescarEstudianteLogueado()
        {
            ConsultasEstudiantes.CrearInstanciasDeEstudiantesAPartirDeBD();
            Sistema.IngresarEstudianteComoUsuarioActivo(Sistema.CorreoEstudianteLogueado);
        }

        //Getters y Setters
        public static List<RegistroDePago> Pagos { get { return _listaRegistrosPagos; } }
    }
}
