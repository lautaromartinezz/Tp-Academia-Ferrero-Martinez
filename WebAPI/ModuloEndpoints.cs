

using System.Reflection.Metadata;
using Domain.Services;
using DTOs;
namespace WebAPI
{
    public static class ModuloEndpoints
    {
        public static void MapModuloEndpoints(this WebApplication app)
        {
            app.MapGet("/modulos", () =>
            {
                ModuloService service = new ModuloService();

                var modulos = service.findAll();

                return Results.Ok(modulos);
            })
            .Produces<List<ModuloDTO>>(StatusCodes.Status200OK)
            .WithName("findModulos")
            ;

            app.MapGet("/modulos/{id}", (int id) =>
            {
                ModuloService service = new ModuloService();

                ModuloDTO? dto = service.findOne(new ModuloDTO
                {
                    Id = id
                });
                if (dto == null) return Results.NotFound("Modulo no encontrado");

                return Results.Ok<ModuloDTO>(dto);
            }).WithName("findOneModulo")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status202Accepted);

            app.MapDelete("/modulos/{id}", (int id) =>
            {
                ModuloService service = new ModuloService();

                ModuloDTO? dto = service.delete(new ModuloDTO { Id = id });

                if (dto == null)
                {
                    return Results.NotFound("Modulo no encontrado");
                }
                ;
                return Results.NoContent();
            }).Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithName("deleteModulo");

            app.MapPut("/modulos", (ModuloDTO dto) =>
            {
                try
                {
                    ModuloService service = new ModuloService();

                    ModuloDTO? dtoUpdated = service.update(dto);

                    if (dtoUpdated == null)
                    {
                        return Results.NotFound("Modulo no encontrado");

                    }
                    return Results.NoContent();
                }
                catch (ArgumentException ex)
                {

                    return Results.BadRequest("Error al actualizar el modulo");
                }
            }).WithName("updateModulo")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound);

            app.MapPost("/modulos", (ModuloDTO dto) =>
            {
                try
                {
                    ModuloService service = new ModuloService();

                    ModuloDTO? createdDTO = service.add(dto);

                    if (createdDTO == null) return Results.NotFound("Modulo no encontrado");

                    return Results.NoContent();
                }
                catch (ArgumentException ex) {
                    return Results.BadRequest("Error al crear el modulo");
                }
            }).WithName("addModulo")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest);
        }


    }
}