using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConsultasGenericas : ConexionBD
    {
        //////////////////////// CONSULTAS INTERNAS

        //////// SI SE DEVUELVE UNA LISTA

        /// <summary>
        /// Obtiene una lista de elementos utilizando una consulta SQL proporcionada.
        /// </summary>
        /// <typeparam name="T">Tipo de elemento a recuperar.</typeparam>
        /// <param name="query">Consulta SQL utilizada para obtener los elementos.</param>
        /// <param name="nombreParametro">Nombre del parámetro para la consulta SQL.</param>
        /// <param name="valorParametro">Valor del parámetro para la consulta SQL.</param>
        /// <param name="mapFunc">Función de mapeo para convertir los resultados del lector SQL en elementos del tipo T.</param>
        /// <returns>Una lista de elementos del tipo T obtenidos a través de la consulta SQL.</returns>
        internal static List<T> ObtenerListaMedianteQuery<T>(string query, string nombreParametro, object valorParametro, Func<SqlDataReader, T> mapFunc)
        {
            List<T> listaADevolver = new List<T>();

            using (var connectionAlternativa = new SqlConnection(@"Server = .; Database = TestSYSACAD; Trusted_Connection = True; Encrypt=False; TrustServerCertificate=True;"))
            using (var commandAlternativo = new SqlCommand(query, connectionAlternativa))
            {
                commandAlternativo.Parameters.AddWithValue(nombreParametro, valorParametro);

                try
                {
                    connectionAlternativa.Open();

                    using (var readerAlternativo = commandAlternativo.ExecuteReader())
                    {
                        while (readerAlternativo.Read())
                        {
                            listaADevolver.Add(mapFunc(readerAlternativo));
                        }
                    }
                }
                catch (SqlException ex)
                {
                    RegistroExcepciones.RegistrarExcepcion(ex);
                    throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                }
            }

            return listaADevolver;
        }

        //////// SI SE DEVUELVE UN ESCALAR

        /// <summary>
        /// Ejecuta una consulta SQL que devuelve un valor escalar de la base de datos.
        /// </summary>
        /// <typeparam name="T">Tipo de valor escalar a devolver.</typeparam>
        /// <param name="query">Consulta SQL a ejecutar.</param>
        /// <param name="nombreParametro">Nombre del parámetro para la consulta SQL.</param>
        /// <param name="valorParametro">Valor del parámetro para la consulta SQL.</param>
        /// <returns>El valor escalar resultado de la consulta SQL.</returns>
        internal static T EjecutarEscalar<T>(string query, string nombreParametro, object valorParametro)
        {
            using (var connectionAlternativa = new SqlConnection(@"Server = .; Database = TestSYSACAD; Trusted_Connection = True; Encrypt=False; TrustServerCertificate=True;"))
            using (var commandAlternativo = new SqlCommand(query, connectionAlternativa))
            {
                commandAlternativo.Parameters.AddWithValue(nombreParametro, valorParametro);

                try
                {
                    connectionAlternativa.Open();

                    var result = commandAlternativo.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return (T)result;
                    }
                    else
                    {
                        return default(T);
                    }
                }
                catch (SqlException ex)
                {
                    RegistroExcepciones.RegistrarExcepcion(ex);
                    throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                }
            }
        }

        //////////////////////// CREACION DE INSTANCIAS

        /// <summary>
        /// Crea instancias de objetos a partir de la base de datos utilizando una consulta SQL y un mapeador.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a crear.</typeparam>
        /// <param name="query">Consulta SQL para obtener los datos necesarios.</param>
        /// <param name="mapper">Función que mapea los resultados del lector SQL a objetos del tipo T.</param>
        /// <returns>Una lista de objetos del tipo T creados a partir de la base de datos.</returns>
        public static List<T> CrearInstanciasDesdeBD<T>(string query, Func<SqlDataReader, T> mapper)
            where T : IEntidadReconstruida
        {
            List<T> listaReconstruida = new List<T>();

            try
            {
                connection.Open();

                command.CommandText = query;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T entidad = mapper(reader);
                        listaReconstruida.Add(entidad);
                    }
                }
            }
            catch (SqlException ex)
            {
                RegistroExcepciones.RegistrarExcepcion(ex);
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return listaReconstruida;
        }


        ////////// METODO GENERICO PARA LOS READ


        /// <summary>
        /// Filtra una lista de elementos basado en un predicado proporcionado.
        /// </summary>
        /// <typeparam name="T">Tipo de elemento a filtrar.</typeparam>
        /// <param name="lista">Lista de elementos a filtrar.</param>
        /// <param name="predicado">Predicado para filtrar los elementos.</param>
        /// <returns>Una lista de elementos del tipo T que cumplen con el predicado.</returns>
        public static List<T> FiltrarElementos<T>(List<T> lista, Predicate<T> predicado)
            where T : IEntidadRegistrada
        {
            //Guardo los elementos filtrados en esta lista
            List<T> elementosFiltrados = new List<T>();

            //Recorro los elementos de la lista que pase como argumento.
            foreach (T elemento in lista)
            {
                //Accedo al metodo que recibi como argumento (Del tipo "Predicate") que toma un parametro y devuelve
                //un bool y le paso como argumento el elemento que estoy iterando.
                //Por ejemplo, estoy iterando una lista de "Curso" y mi predicate se encarga de verificar si el codigo
                //del curso iterado es equivalente a un codigo determinado. (curso.Codigo == codigo)
                //Entonces llamo a este predicate que recibi como argumento, y le paso el curso iterado como argumento
                //para que pueda corroborar o no si el codigo es equivalente a un codigo determinado.
                if (predicado(elemento))
                {
                    elementosFiltrados.Add(elemento);
                }
            }

            return elementosFiltrados;
        }

        /// <summary>
        /// Ejecuta una consulta SQL que no devuelve resultados (como INSERT, UPDATE o DELETE) en la base de datos.
        /// </summary>
        /// <param name="query">Consulta SQL a ejecutar.</param>
        /// <param name="parametros">Diccionario de parámetros para la consulta SQL.</param>
        /// <returns>Tarea asincrónica que ejecuta la consulta SQL en la base de datos.</returns>
        internal async static Task EjecutarNonQuery(string query, Dictionary<string, object> parametros)
        {
            try
            {
                await connection.OpenAsync();

                command.CommandText = query;

                foreach (var parametro in parametros)
                {
                    command.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }

                await command.ExecuteNonQueryAsync();
            }
            catch (SqlException ex)
            {
                RegistroExcepciones.RegistrarExcepcion(ex);
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }
        }
    }
}
