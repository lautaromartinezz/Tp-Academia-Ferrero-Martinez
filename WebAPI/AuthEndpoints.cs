using DTOs;
using Domain.Services;

namespace WebAPI
{
    public static class AuthEndpoints
    {
        public static void MapAuthEndpoints(this WebApplication app)
        {
            app.MapPost("/auth/login", async (LoginRequest request, IConfiguration configuration) =>
            {
                try
                {
                    var authService = new AuthService(configuration);
                    var response = await authService.LoginAsync(request);

                    if (response == null)
                    {
                        return Results.Unauthorized();
                    }

                    return Results.Ok(response);
                }
                catch (Exception ex)
                {
                    return Results.Problem($"Error durante el login: {ex.Message}");
                }
            })
            .WithName("Login")
            .Produces<LoginResponse>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status401Unauthorized)
            .Produces(StatusCodes.Status500InternalServerError)
            .WithOpenApi()
            .AllowAnonymous();

            app.MapPost("/auth/getrole", async (LoginRequest request, IConfiguration configuration) =>
            {
                try
                {
                    var authService = new AuthService(configuration);
                    
                    string? role = authService.GetRoleFromToken(request.Token);

                    if (role == null)
                    {
                        return Results.Unauthorized();
                    }
                    LoginResponse response = new LoginResponse() { Role = role};
                    return Results.Ok(response);
                }
                catch (Exception ex)
                {
                    return Results.Problem($"Error durante el login: {ex.Message}");
                }
            })
            .WithName("GetRole")
            .Produces<LoginResponse>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status401Unauthorized)
            .Produces(StatusCodes.Status500InternalServerError)
            .WithOpenApi()
            .AllowAnonymous();

            app.MapPost("/auth/getId", async (LoginRequest request, IConfiguration configuration) =>
            {
                try
                {
                    var authService = new AuthService(configuration);

                    int? userId = authService.GetUserIdFromToken(request.Token);

                    if (userId == null)
                    {
                        return Results.Unauthorized();
                    }
                    LoginResponse response = new LoginResponse() { UserId = userId.ToString() };
                    return Results.Ok(response);
                }
                catch (Exception ex)
                {
                    return Results.Problem($"Error durante el login: {ex.Message}");
                }
            })
                .WithName("GetId")
                .Produces<LoginResponse>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status401Unauthorized)
                .Produces(StatusCodes.Status500InternalServerError)
                .WithOpenApi()
                .AllowAnonymous();
        }
    }
}
