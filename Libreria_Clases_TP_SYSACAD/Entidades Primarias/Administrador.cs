namespace Libreria_Clases_TP_SYSACAD.EntidadesPrimarias
{
    public class Administrador
    {
        private string _correo;
        private string _contrasenia;

        //El administrador cuenta con correo y contraseña para Logearse
        public Administrador(string correo, string contrasenia)
        {
            _correo = correo;
            _contrasenia = contrasenia;
        }

        //Getters y Setters
        public string Correo { get { return _correo; } }
        public string Contrasenia { get { return _contrasenia; } set { _contrasenia = value; } }
    }
}