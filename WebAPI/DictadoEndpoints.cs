using Domain.Services;
using DTOs;

namespace WebAPI
{
    public static class DictadoEndpoints
    {
        public static void MapDictadoEndpoints(this WebApplication app)
        {
            app.MapGet("/dictados/{id}", (int id) =>
            {
                DictadoService dictadoService = new DictadoService();

                DictadoDTO? dto = dictadoService.getOne(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(dto);
            })
            .WithName("GetDictado")
            .Produces<DTOs.DictadoDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/dictados", () =>
            {
                DictadoService dictadoService = new DictadoService();


                var dtos = dictadoService.getAll();

                return Results.Ok(dtos);

            })
            .WithName("GetAllDictadoes")
            .Produces<List<DTOs.DictadoDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/dictados", (DictadoDTO dto) =>
            {
                try
                {
                    DictadoService dictadoService = new DictadoService();

                    DictadoDTO dictadoDTO = dictadoService.add(dto);

                    if (dictadoDTO == null)
                    {
                        return Results.NotFound("El dictado no existe");
                    }

                    return Results.Created($"/dictados/{dictadoDTO.Id}", dictadoDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddDictado")
            .Produces<DTOs.DictadoDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapPut("/dictados", (DTOs.DictadoDTO dto) =>
            {
                try
                {
                    DictadoService dictadoService = new DictadoService();

                    var found = dictadoService.update(dto);

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
            .WithName("UpdateDictado")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/dictados/{id}", (int id) =>
            {
                DictadoService dictadoService = new DictadoService();

                var deleted = dictadoService.delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();

            })
            .WithName("DeleteDictado")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/dictados/profesor/{idProfesor}", (int idProfesor) =>
            {
                DictadoService dictadoService = new DictadoService();
                var dtos = dictadoService.getByProfesorId(idProfesor);
                return Results.Ok(dtos);
            }).WithName("GetByDictadosByProfesor")
            .Produces<List<DTOs.DictadoDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();
        }
    }
}
