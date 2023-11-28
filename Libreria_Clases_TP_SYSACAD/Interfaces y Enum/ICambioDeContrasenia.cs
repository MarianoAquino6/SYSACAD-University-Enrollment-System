using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum
{
    public interface ICambioDeContraseña
    {
        Task CambiarContraseñaAEstudiante(string correo, string nuevaContrasenia);
    }
}
