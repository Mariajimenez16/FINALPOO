
namespace ProyectoFinalPOO
{
    internal static class Program
    {

        // Esta es la clase principal que inicia la ejecuci�n del programa.
        // El m�todo Main() es el punto de entrada de la aplicaci�n.
        // [STAThread] se usa porque estamos trabajando con una interfaz gr�fica (Windows Forms).
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        // Esta clase est� marcada como static porque no se necesita crear objetos de ella.
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // ApplicationConfiguration.Initialize() configura opciones iniciales de la app, como la resoluci�n y el estilo.
            ApplicationConfiguration.Initialize();

            // Application.Run(new Form1()) abre la ventana principal llamada Form1.
            Application.Run(new Form1());
        }
    }

}



