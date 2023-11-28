using Libreria_Clases_TP_SYSACAD;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using System;
using System.Text;

namespace Forms_TP_SYSACAD
{
    internal static class Program
    {
        private static Form_Inicio _formInicio;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Sistema.InicializarSistema();
            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //Application.Run(new Form_Inicio());


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            _formInicio = new Form_Inicio();
            MostrarMensajeCargando();

            Task.Run(() =>
            {
                //Abro la inicializacion del sistema en un nuevo hilo
                Sistema.InicializarSistema();
            }).ContinueWith((task) =>  //Aca le digo que una vez que termino el hilo, continue haciendo esto...
            {
                // Oculto el mensaje de "Cargando" cuando la tarea se termina de completar
                OcultarMensajeCargando();
            }, TaskScheduler.FromCurrentSynchronizationContext()); //Le digo que esta parte de ocultar mensaje
            //de cargando tiene que realizarse en el hilo del form (El hilo principal actual)

            Application.Run(_formInicio);
        }

        private static void MostrarMensajeCargando()
        {
            _formInicio.MostrarMensajeCargando();
        }

        private static void OcultarMensajeCargando()
        {
            _formInicio.OcultarMensajeCargando();
        }
    }
}