namespace clinica_dental_ev03;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        //Application.Run(new EmpleadosForm());
        //Application.Run(new UsuarioForm());
        //Application.Run(new PacientesForm());
        //Application.Run(new ServiciosForm());
        //Application.Run(new CitaForm());
        //Application.Run(new PagosForm());
        Application.Run(new LoginForm());
        //Application.Run(new MenuForm());
    }
}