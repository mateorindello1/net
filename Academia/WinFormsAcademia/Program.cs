namespace WinFormsAcademia
{
    internal static class Program
    {
        const string administrador = "Administrador";
        const string docente = "Docente";
        const string alumno = "Alumno";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var fondo = new Fondo();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Application.Run(fondo);
        }
    }
}