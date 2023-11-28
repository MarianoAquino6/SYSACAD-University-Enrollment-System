using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum
{
    public interface IEntidadRegistrada
    {
        public Task Registrar();
    }

    public interface IEntidadPersona : IEntidadRegistrada
    {
        public string Nombre { get;}
        public string Correo { get;}
        public string Telefono { get;}
        public string Direccion { get;}
    }
}