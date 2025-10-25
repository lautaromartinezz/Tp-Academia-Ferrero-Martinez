using Domain.Services;
using DTOs;

namespace WebAPI
{
    public static class ComisionEndpoints
    {
        public static void MapComisionEndpoints(this WebApplication app)
        {
            app.MapGet("/comisiones/{id}", (int id) =>
            {
                ComisionService comService = new ComisionService();

                ComisionDTO? dto = comService.getOne(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(dto);
            })
            .WithName("GetCom")
            .Produces<DTOs.ComisionDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/comisiones", () =>
            {
                ComisionService comService = new ComisionService();


                var dtos = comService.getAll();

                return Results.Ok(dtos);

            })
            .WithName("GetAllCom")
            .Produces<List<DTOs.ComisionDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/comisiones", (ComisionDTO dto) =>
            {
                try
                {
                    ComisionService comService = new ComisionService();

                    ComisionDTO? comDto = comService.add(dto);

                    if (comDto == null)
                    {
                        return Results.NotFound("El plan ingresada no existe");
                    }

                    return Results.Created($"/comisiones/{comDto.Id}", comDto);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddCom")
            .Produces<DTOs.ComisionDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapPut("/comisiones", (DTOs.ComisionDTO dto) =>
            {
                try
                {
                    ComisionService comService = new ComisionService();

                    var found = comService.update(dto);

                    if (!found)
                    {
                        return Results.NotFound("Error al actualizar la comision. Revise el id de el plan");
                    }

                    return Results.NoContent();
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("UpdateCom")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/comisiones/{id}", (int id) =>
            {
                ComisionService comService = new ComisionService();

                var deleted = comService.delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();

            })
            .WithName("DeleteCom")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();
        }
    }
}
