using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Herramientas
{
    public class ElementosCorreoElectronicoArgs : EventArgs
    {
        public string Asunto { get; set; }
        public string Cuerpo { get; set; }

        public ElementosCorreoElectronicoArgs(string asunto, string cuerpo)
        {
            Asunto = asunto;
            Cuerpo = cuerpo;
        }
    }
}
