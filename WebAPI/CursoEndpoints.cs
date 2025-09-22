using Domain.Services;
using DTOs;

namespace WebAPI
{
    public static class CursoEndpoints
    {
        public static void MapCursoEndpoints(this WebApplication app)
        {
            app.MapGet("/cursos/{id}", (int id) =>
            {
                CursoService cursoService = new CursoService();

                CursoDTO? dto = cursoService.getOne(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(dto);
            })
            .WithName("GetCurso")
            .Produces<DTOs.CursoDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/cursos", () =>
            {
                CursoService cursoService = new CursoService();


                var dtos = cursoService.getAll();

                return Results.Ok(dtos);

            })
            .WithName("GetAllCursos")
            .Produces<List<DTOs.CursoDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/cursos", (CursoDTO dto) =>
            {
                try
                {
                    CursoService cursoService = new CursoService();

                    CursoDTO? cursoDto = cursoService.add(dto);

                    if(cursoDto == null)
                    {
                        return Results.NotFound("La materia ingresada no existe");
                    }

                    return Results.Created($"/cursos/{cursoDto.Id}", cursoDto);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddCurso")
            .Produces<DTOs.CursoDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapPut("/cursos", (DTOs.CursoDTO dto) =>
            {
                try
                {
                    CursoService cursoService = new CursoService();

                    var found = cursoService.update(dto);

                    if (!found)
                    {
                        return Results.NotFound("Error al actualizar el curso. Revise el id de la Materia o Comision");
                    }

                    return Results.NoContent();
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("UpdateCurso")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/cursos/{id}", (int id) =>
            {
                CursoService cursoService = new CursoService();

                var deleted = cursoService.delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();

            })
            .WithName("DeleteCurso")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();
        }
    }
}
