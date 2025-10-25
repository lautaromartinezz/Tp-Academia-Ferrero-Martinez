using Domain.Services;
using DTOs;

namespace WebAPI
{
    public static class EspecialidadEndpoints
    {
        public static void MapEspecialidadEndpoints(this WebApplication app)
        {
            app.MapGet("/especialidades", () =>
            {
                EspecialidadService service = new EspecialidadService();

                var especialidades = service.getAll();

                return Results.Ok(especialidades);
            })
            .Produces<List<EspecialidadDTO>>(StatusCodes.Status200OK)
            .WithName("findEspecialidades")
            ;

            app.MapGet("/especialidades/{id}", (int id) =>
            {
                EspecialidadService service = new EspecialidadService();

                EspecialidadDTO? dto = service.getOne(id);
                if (dto == null) return Results.NotFound("Especialidad no encontrada");

                return Results.Ok<EspecialidadDTO>(dto);
            }).WithName("findOneEspecialidad")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status202Accepted);

            app.MapDelete("/especialidades/{id}", (int id) =>
            {
                EspecialidadService service = new EspecialidadService();

                bool rta = service.delete(id);

                if (rta == true)
                {
                    return Results.NoContent();
                }
                ;
                return Results.NotFound("Especialidad no encontrada");
            }).Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithName("deleteEspecialidad");

            app.MapPut("/especialidades", (EspecialidadDTO dto) =>
            {
                try
                {
                    EspecialidadService service = new EspecialidadService();

                    bool rta = service.update(dto);

                    if (rta == true)
                    {
                        
                        return Results.NoContent();
                    }
                    return Results.NotFound("Especialidad no encontrada");

                }
                catch (ArgumentException ex)
                {

                    return Results.BadRequest("Error al actualizar la especialidad");
                }
            }).WithName("updateEspecialidad")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status204NoContent);

            app.MapPost("/especialidades", (EspecialidadDTO dto) =>
            {
                try
                {
                    EspecialidadService service = new EspecialidadService();

                    EspecialidadDTO? createdDTO = service.add(dto);

                    if (createdDTO == null) return Results.NotFound("Especialidadno encontrado");

                    return Results.NoContent();
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest("Error al crear la especialidad");
                }
            }).WithName("addEspecialidad")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest);
        }



    }
}
