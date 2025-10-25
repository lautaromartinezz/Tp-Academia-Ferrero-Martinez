using Domain.Services;
using DTOs;

namespace WebAPI
{
    public static class PersonaEndpoints
    {
        public static void MapPersonaEndpoints(this WebApplication app)
        {
            app.MapGet("/personas", () =>
            {
                var service = new PersonaService();
                return Results.Ok(service.getAll());
            });

            app.MapGet("/personas/{id}", (int id) =>
            {
                var service = new PersonaService();
                var persona = service.getOne(id);
                return persona is not null ? Results.Ok(persona) : Results.NotFound();
            });

            app.MapPost("/personas", (PersonaDTO dto) =>
            {
                var service = new PersonaService();
                var result = service.add(dto);
                return result is not null ? Results.Created($"personas/{result.Id}", result) : Results.BadRequest("Plan no encontrado");
            });

            app.MapPut("/personas/{id}", (int id, PersonaDTO dto) =>
            {
                dto.Id = id;
                var service = new PersonaService();
                return service.update(dto) ? Results.Ok() : Results.NotFound();
            });

            app.MapDelete("/personas/{id}", (int id) =>
            {
                var service = new PersonaService();
                return service.delete(id) ? Results.Ok() : Results.NotFound();
            });
        }
    }

}
