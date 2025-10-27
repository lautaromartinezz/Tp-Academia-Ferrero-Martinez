using API.Clients;
using API.Auth.WindowsForms;
using Academia;
using System.Web;
namespace WindowsForms
{
    internal static class Program
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
            // Handler para excepciones de UI no manejadas
            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Ejecutar async main
            Task.Run(async () => await MainAsync()).GetAwaiter().GetResult();
        }
        static async Task MainAsync()
        {
            // Registrar AuthService en singleton
            var authService = new WindowsFormsAuthService();
            var authApiClient = new AuthApiClient();
            AuthServiceProvider.Register(authService);

            // Loop principal de autenticación
            while (true)
            {
                string? userRol = null;
                string? userId = null;
                if (!await authService.IsAuthenticatedAsync())
                {
                    var loginForm = new formLogin();
                    
                    
                    if (loginForm.ShowDialog() != DialogResult.OK)
                    {
                        // Usuario canceló login, cerrar aplicación
                        return;
                    }
                    string? token = await authService.GetTokenAsync();
                    if(token == null)
                    {
                        return;
                    }
                    userRol = await authApiClient.GetRoleFromTokenAsync(token);

                    if (userRol == null)
                    {
                        return;
                    }
                    userId = await authApiClient.GetUserIdFromToken(token);

                    if (userId == null)
                    {
                        MessageBox.Show("No se pudo obtener el ID del usuario desde el token.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                try
                {
                    if(userRol == "Admin")
                    {
                        Inicio inicio = new Inicio();
                        inicio.Mode = TipoUsuario.Admin;
                        inicio.UserId = userId;
                        Application.Run(inicio);
                    } else if (userRol == "Profesor")
                    {
                        // CU de Profesor

                        Inicio inicio = new Inicio();
                        inicio.Mode = TipoUsuario.Profesor;
                        inicio.UserId= userId;
                        Application.Run(inicio);

                    }
                    else if (userRol == "Alumno")
                    {
                        // CU de Alumno

                        Inicio inicio = new Inicio();
                        inicio.Mode = TipoUsuario.Alumno;
                        inicio.UserId = userId;
                        Application.Run(inicio);

                    }
                    break; // La aplicación se cerró normalmente
                }
                catch (UnauthorizedAccessException ex)
                {
                    // Sesión expirada, mostrar mensaje y volver al login
                    MessageBox.Show(ex.Message, "Sesión Expirada",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // El loop continuará y volverá a mostrar login
                }
            }
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            if (e.Exception is UnauthorizedAccessException)
            {
                // Sesión expirada
                MessageBox.Show("Su sesión ha expirado. Debe volver a autenticarse.", "Sesión Expirada",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Reiniciar la aplicación para volver al login
                Application.Restart();
            }
            else
            {
                // Otras excepciones, mostrar error genérico
                MessageBox.Show($"Error inesperado: {e.Exception.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}