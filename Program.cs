
namespace ProyectoFinalPOO
{
    internal static class Program
    {

        // Esta es la clase principal que inicia la ejecución del programa.
        // El método Main() es el punto de entrada de la aplicación.
        // [STAThread] se usa porque estamos trabajando con una interfaz gráfica (Windows Forms).
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        // Esta clase está marcada como static porque no se necesita crear objetos de ella.
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // ApplicationConfiguration.Initialize() configura opciones iniciales de la app, como la resolución y el estilo.
            ApplicationConfiguration.Initialize();

            // Application.Run(new Form1()) abre la ventana principal llamada Form1.
            Application.Run(new Form1());
        }
    }

}



