using Domain.Services;
using DTOs;

namespace WebAPI
{
    public static class InscripcionEndpoints
    {
        public static void MapInscripcionEndpoints(this WebApplication app)
        {
            app.MapGet("/inscripciones/{id}", (int id) =>
            {
                InscripcionService inscripcionService = new InscripcionService();

                InscripcionDTO? dto = inscripcionService.getOne(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(dto);
            })
            .WithName("GetInscripcion")
            .Produces<DTOs.InscripcionDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/inscripciones", () =>
            {
                InscripcionService inscripcionService = new InscripcionService();


                var dtos = inscripcionService.getAll();

                return Results.Ok(dtos);

            })
            .WithName("GetAllInscripciones")
            .Produces<List<DTOs.InscripcionDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/inscripciones", (InscripcionDTO dto) =>
            {
                try
                {
                    InscripcionService inscripcionService = new InscripcionService();

                    InscripcionDTO inscripcionDTO = inscripcionService.add(dto);

                    if (inscripcionDTO == null)
                    {
                        return Results.NotFound("La inscripcion no existe");
                    }

                    return Results.Created($"/inscripciones/{inscripcionDTO.Id}", inscripcionDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddInscripcion")
            .Produces<DTOs.InscripcionDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapPut("/inscripciones", (DTOs.InscripcionDTO dto) =>
            {
                try
                {
                    InscripcionService inscripcionService = new InscripcionService();

                    var found = inscripcionService.update(dto);

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
            .WithName("UpdateInscripcion")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/inscripciones/{id}", (int id) =>
            {
                InscripcionService inscripcionService = new InscripcionService();

                var deleted = inscripcionService.delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();

            })
            .WithName("DeleteInscripcion")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/inscripciones/curso/{idCurso}", (int idCurso) =>
            {
                InscripcionService inscripcionService = new InscripcionService();


                var dtos = inscripcionService.getByCurso(idCurso);

                return Results.Ok(dtos);

            })
            .WithName("GetAllInscripcionesByCurso")
            .Produces<List<DTOs.InscripcionDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();
        }
    }
    
}
