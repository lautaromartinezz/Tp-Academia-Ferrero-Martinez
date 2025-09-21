using Domain.Services;
using DTOs;

namespace WebAPI
{
    public static class MateriaEndpoints
    {
        public static void MapMateriaEndpoints(this WebApplication app)
        {
            app.MapGet("/materias/{id}", (int id) =>
            {
                MateriaService materiaService = new MateriaService();

                MateriaDTO? dto = materiaService.getOne(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(dto);
            })
            .WithName("GetMateria")
            .Produces<DTOs.MateriaDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/materias", () =>
            {
                MateriaService materiaService = new MateriaService();


                var dtos = materiaService.getAll();

                return Results.Ok(dtos);

            })
            .WithName("GetAllMaterias")
            .Produces<List<DTOs.MateriaDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/materias", (MateriaDTO dto) =>
            {
                try
                {
                    MateriaService materiaService = new MateriaService();

                    MateriaDTO materiaDto = materiaService.add(dto);

                    return Results.Created($"/materias/{materiaDto.Id}", materiaDto);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddMateria")
            .Produces<DTOs.MateriaDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/materias", (DTOs.MateriaDTO dto) =>
            {
                try
                {
                    MateriaService materiaService = new MateriaService();

                    var found = materiaService.update(dto);

                    if (!found)
                    {
                        return Results.NotFound();
                    }

                    return Results.NoContent();
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("UpdateMateria")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/materias/{id}", (int id) =>
            {
                MateriaService materiaService = new MateriaService();

                var deleted = materiaService.delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();

            })
            .WithName("DeleteMateria")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();
        }
    }
}
