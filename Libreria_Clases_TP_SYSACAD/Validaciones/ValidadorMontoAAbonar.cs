using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Validaciones
{
    public class ValidadorMontoAAbonar
    {
        private List<double> _listaMontos;
        private List<double> _listaMontosOriginales;

        public ValidadorMontoAAbonar(List<double> listaMontos)
        {
            _listaMontos = listaMontos;
        }

        //Sobrecarga
        public ValidadorMontoAAbonar(List<double> listaMontos, List<double> listaMontosOriginales) : this(listaMontos)
        {
            _listaMontosOriginales = listaMontosOriginales;
        }

        /// <summary>
        /// Verifica si hay algún número negativo en la lista de montos.
        /// </summary>
        /// <returns>True si hay al menos un número negativo; de lo contrario, false.</returns>
        public bool VerificarSiHayNumeroNegativo()
        {
            bool hayNumeroNegativo = false;

            foreach (double monto in _listaMontos)
            {
                if (monto < 0)
                {
                    hayNumeroNegativo = true;
                    break;
                }
            }

            return hayNumeroNegativo;
        }

        /// <summary>
        /// Verifica si algún monto en la lista de montos es mayor que su correspondiente en la lista de montos originales.
        /// </summary>
        /// <returns>True si hay algún valor excesivo; de lo contrario, false.</returns>
        public bool VerificarSiHayValorExcesivo()
        {
            // Verifica si algún valor en la columna de índice 2 es mayor que el valor en la columna de índice 1
            bool hayValorExcesivo = false;

            for (int i = 0; i < _listaMontos.Count; i++)
            {
                for (int j = 0; j < _listaMontosOriginales.Count; j++)
                {
                    if (i == j && _listaMontos[i] > _listaMontosOriginales[j])
                    {
                        hayValorExcesivo = true;
                        break;
                    }
                }
            }

            return hayValorExcesivo;
        }
    }
}
