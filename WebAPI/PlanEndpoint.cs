using Domain.Services;
using DTOs;
using WebAPI.Reports;

namespace WebAPI
{
    public static class PlanEndpoint
    {
        public static void MapPlanEndpoints(this WebApplication app)
        {
            app.MapGet("/planes/{id}", (int id) =>
            {
                PlanService planService = new PlanService();

                PlanDTO? dto = planService.getOne(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(dto);
            })
            .WithName("GetPlan")
            .Produces<DTOs.PlanDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/planes/report/{id}", (int id) =>
            {
                var report = new ReportePlanes(id);

                report.CreateDocument();

                using var ms = new MemoryStream();
                report.ExportToPdf(ms);
                ms.Position = 0;

                return Results.File(ms.ToArray(), "application/pdf");

            })
            .WithName("GetReportePlanes")
            .WithOpenApi();

            app.MapGet("/planes", () =>
            {
                PlanService planService = new PlanService();


                var dtos = planService.getAll();

                return Results.Ok(dtos);

            })
            .WithName("GetAllPlanes")
            .Produces<List<DTOs.PlanDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/planes", (PlanDTO dto) =>
            {
                try
                {
                    PlanService planService = new PlanService();

                    PlanDTO planDto = planService.add(dto);

                    return Results.Created($"/planes/{planDto.Id}", planDto);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddPlan")
            .Produces<DTOs.PlanDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/planes", (DTOs.PlanDTO dto) =>
            {
                try
                {
                    PlanService planService = new PlanService();

                    var found = planService.update(dto);

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
            .WithName("UpdatePlan")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/planes/{id}", (int id) =>
            {
                PlanService planService = new PlanService();

                var deleted = planService.delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();

            })
            .WithName("DeletePlan")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();
        }
    }
}
